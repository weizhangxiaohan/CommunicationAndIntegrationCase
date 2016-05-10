using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Routing;

namespace RouterHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("RoutingService");
                ServiceHost serviceHost = new ServiceHost(typeof(RoutingService));
                serviceHost.Open();
                Console.WriteLine("Started");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
    }
}
