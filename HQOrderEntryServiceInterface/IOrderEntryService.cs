using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.MsmqIntegration;
using System.ServiceModel;

namespace HQOrderEntryServiceInterface
{
    [ServiceContract]
    [ServiceKnownType(typeof(HQOrderEntry))]
    public interface IOrderEntryService
    {
        [OperationContract(IsOneWay = true,Action = "*")]
        void SendOrderEntry(MsmqMessage<HQOrderEntry> orderEntry);
    }
}
