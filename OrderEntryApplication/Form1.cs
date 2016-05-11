using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HQOrderEntryServiceInterface;

namespace OrderEntryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void SendMessage(string data)
        {
            MessageQueue messageQueue = new MessageQueue(@".\private$\OrderEntryQueue");

            System.Messaging.Message message = new System.Messaging.Message();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.InnerXml = data;

            message.Body = xmlDocument;

            messageQueue.Send(message);
        }

        private static string GetXmlForOrderEntry()
        {
            string tmp;

            HQOrderEntry test = new HQOrderEntry();
            test.OrderEntryID = "00000001";
            test.OrderEntryDate = DateTime.Now;
            test.OrderCustomer = new Customer()
            {
                CustomerName = "WROX",
                CustomerAddressLine1 = "CustomerAddressLine1",
                CustomerAddressLine2 = "CustomerAddressLine2",
                CustomerCountryCode = "AR" 
            };

            test.OrderOrderedProducts = new List<OrderedProducts>();
            test.OrderOrderedProducts.Add(new OrderedProducts()
            {
                ProductID = "P08872",
                Quantity = 5,
                ProductName = "Car"
            });
            test.OrderOrderedProducts.Add(new OrderedProducts()
            {
                ProductID = "P02287",
                Quantity = 5,
                ProductName = "Bike"
            });

            tmp = HelperLib.GenericSerializer<HQOrderEntry>.Serialize(test);

            return tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = GetXmlForOrderEntry();
            SendMessage(message);
        }
    }
}
