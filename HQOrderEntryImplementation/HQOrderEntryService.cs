using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using System.Threading.Tasks;
using HQOrderEntryServiceInterface;
using LocalOrderEntryInterface;

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
            //Add code later
            return true;
        }

        private LocalOrderEntry ConvertOrderEntrySchema(HQOrderEntry orderEntry)
        {
            //Add code later
            return null;
        }

        private void RouteOrderEntry(LocalOrderEntry localOrderEntry)
        {
            //Add code later
        }

        private void SendToInvalidOrderQueue(MsmqMessage<HQOrderEntry> orderEntryMsg) 
        {
            //Add  code later
        }

        private string TranslateProductDescription(string productID,string languageCode) 
        {
            //Add code later
            return "";
        }
    }
}
