using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQOrderEntryImplementation
{
    public class SubscribeServiceSingleton
    {
        private static SubscribeService instance;
        private static readonly object singletonLock = new object();

        public static SubscribeService GetInstance()
        {
            if (instance == null)
            {
                lock (singletonLock)
                {
                    if (instance == null)
                    {
                        instance = new SubscribeService();
                    }
                }
            }
            return instance;
        }
    }
}
