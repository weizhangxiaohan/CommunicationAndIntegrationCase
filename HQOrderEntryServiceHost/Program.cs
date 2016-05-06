using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using HQOrderEntryServiceInterface;
using HQOrderEntryImplementation;

namespace HQOrderEntryServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Service-OrderEntry-Started");
            try
            {
                ServiceHost host = new ServiceHost(typeof(HQOrderEntryService));
                host.Open();
                Console.WriteLine("OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
