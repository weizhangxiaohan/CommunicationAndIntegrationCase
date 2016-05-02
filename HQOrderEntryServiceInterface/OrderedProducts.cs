using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HQOrderEntryServiceInterface
{
    [DataContract]
    public class OrderedProducts
    {
        [DataMember]
        public string ProductID { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public string ProductName { get; set; }
    }
}
