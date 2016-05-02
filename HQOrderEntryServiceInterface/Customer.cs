using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HQOrderEntryServiceInterface
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string CustomerAddressLine1 { get; set; }
        [DataMember]
        public string CustomerAddressLine2 { get; set; }
        [DataMember]
        public string CustomerCountryCode { get; set; }
    }
}
