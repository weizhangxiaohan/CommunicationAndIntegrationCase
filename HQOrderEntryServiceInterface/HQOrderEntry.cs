using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HQOrderEntryServiceInterface
{
    [DataContract]
    public class HQOrderEntry
    {
        [DataMember]
        public string OrderEntryID { get; set; }
        [DataMember]
        public DateTime OrderEntryDate { get; set; }
        [DataMember]
        public Customer OrderCustomer { get; set; }
        [DataMember]
        public List<OrderedProducts> OrderOrderedProducts { get; set; }
    }
}
