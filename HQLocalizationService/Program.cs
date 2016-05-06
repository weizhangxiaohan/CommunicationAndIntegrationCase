using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HQLocalizationService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TranslateProductDescriptions");
            WebServiceHost host = new WebServiceHost(typeof(TranslateProductDescriptions));
            host.Open();
            Console.WriteLine("Started");
            Console.ReadKey();
        }
    }
}
