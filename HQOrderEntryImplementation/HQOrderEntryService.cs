using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using System.Threading.Tasks;
using HQOrderEntryServiceInterface;

namespace HQOrderEntryImplementation
{
    public class HQOrderEntryService : IOrderEntryService
    {
        public void SendOrderEntry(MsmqMessage<HQOrderEntry> orderEntry)
        {
            throw new NotImplementedException();
        }
    }
}
