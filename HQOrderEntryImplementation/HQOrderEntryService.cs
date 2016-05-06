using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using System.Threading.Tasks;
using HQOrderEntryServiceInterface;
using LocalOrderEntryInterface;
using HQOrderEntryImplementation.HQProductServiceASMXClient;
using System.Net;
using System.IO;
using HelperLib;

namespace HQOrderEntryImplementation
{
    public class HQOrderEntryService : IOrderEntryService
    {
        public void SendOrderEntry(MsmqMessage<HQOrderEntry> orderEntryMsg)
        {
            try
            {
                if (CheckIfOrderIsValid(orderEntryMsg.Body))
                {
                    Console.WriteLine("got one");
                    RouteOrderEntry(ConvertOrderEntrySchema(orderEntryMsg.Body));
                }
                else 
                {
                    SendToInvalidOrderQueue(orderEntryMsg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool CheckIfOrderIsValid(HQOrderEntry orderEntry) 
        {
            ProductServiceSoapClient client = new ProductServiceSoapClient();
            bool orderIsValid = true;

            foreach (var item in orderEntry.OrderOrderedProducts)
            {
                if (!orderIsValid)
                {
                    break;
                }
                orderIsValid = client.IsProductAvailableForCountry(item.ProductID,orderEntry.OrderCustomer.CustomerCountryCode);
            }
            return true;
        }

        private LocalOrderEntry ConvertOrderEntrySchema(HQOrderEntry orderEntry)
        {
            LocalOrderEntry localOrderEntry = new LocalOrderEntry();
            localOrderEntry.CustomerName = orderEntry.OrderCustomer.CustomerName;
            localOrderEntry.CustomerAddressLine1 = orderEntry.OrderCustomer.CustomerAddressLine1;
            localOrderEntry.CustomerAddressLine2 = orderEntry.OrderCustomer.CustomerAddressLine2;
            localOrderEntry.CustomerCountryCode = orderEntry.OrderCustomer.CustomerCountryCode;
            localOrderEntry.OrderOrderedProducts = new List<LocalOrderEntryInterface.OrderedProducts>();

            foreach (var item in orderEntry.OrderOrderedProducts)
            {
                string translation = TranslateProductDescription(item.ProductID, orderEntry.OrderCustomer.CustomerCountryCode);

                localOrderEntry.OrderOrderedProducts.Add(new LocalOrderEntryInterface.OrderedProducts 
                {
                    ProductID = orderEntry.OrderCustomer.CustomerCountryCode+"/"+item.ProductID,
                    Quantity = item.Quantity,
                    LocalizeDescription = translation
                });
            }
            return localOrderEntry;
        }

        private void RouteOrderEntry(LocalOrderEntry localOrderEntry)
        {
            try
            {
                LocalOrderEntryProxy proxy = new LocalOrderEntryProxy();
                int a = proxy.SendLocalOrderEntry(localOrderEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SendToInvalidOrderQueue(MsmqMessage<HQOrderEntry> orderEntryMsg) 
        {
            //Add  code later
        }

        private string TranslateProductDescription(string productID,string languageCode) 
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(string.Format(@"http://localhost:53170/HQLocalizationService/TranslateProductDescription/{0}/{1}",languageCode,productID));
            webRequest.ContentLength = 0;
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Encoding encoding = Encoding.GetEncoding(1252);
            StreamReader reader = new StreamReader(webResponse.GetResponseStream(),encoding);
            string response = reader.ReadToEnd();
            string result = GenericSerializer<string>.DeSerializeDC(response);
            return result;
        }
    }
}
