using System.Runtime.Serialization;

namespace Wcf.Contracts.DataContracts
{
    [DataContract]
    public class Address : ContractBase
    {
        [DataMember]
        public string StreetName { get; set; }

        [DataMember]
        public string Home1 { get; set; }

        [DataMember]
        public string Home2 { get; set; }

        [DataMember]
        public AddressType AddressType { get; set; }
    }
}
