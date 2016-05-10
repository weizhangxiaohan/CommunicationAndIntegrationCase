using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgentinaHost
{
    public class ArgentinaOrderEntryImplemenation : LocalOrderEntryInterface.IReceiveOrderEntryLocalBranch
    {
        public int SendLocalOrderEntry(LocalOrderEntryInterface.LocalOrderEntry localOrderEntry)
        {
            Console.WriteLine("Argentina SendLocalOrderEntry");
            Console.WriteLine(localOrderEntry.CustomerName);
            foreach (var item in localOrderEntry.OrderOrderedProducts)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", item.ProductID, item.Quantity.ToString(), item.LocalizeDescription));
            }
            return 2;
        }
    }
}
