using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LocalOrderEntryInterface;

namespace HQOrderEntryImplementation
{
    public class LocalOrderEntryProxy : ClientBase<IReceiveOrderEntryLocalBranch>, IReceiveOrderEntryLocalBranch
    {
        public LocalOrderEntryProxy() 
            :base("LocalOrderEntryEndpoint")
        {
        
        }

        public int SendLocalOrderEntry(LocalOrderEntry localOrderEntry)
        {
            return Channel.SendLocalOrderEntry(localOrderEntry);
        }
    }
}
