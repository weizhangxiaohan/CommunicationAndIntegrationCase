using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ArgentinaHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Argentina Host");
                ServiceHost host = new ServiceHost(typeof(ArgentinaOrderEntryImplemenation));
                host.Open();
                Console.WriteLine("Started");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
