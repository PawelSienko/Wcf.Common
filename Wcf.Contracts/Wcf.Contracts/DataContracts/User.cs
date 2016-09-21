using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Wcf.Contracts.DataContracts
{
    [DataContract]
    public class User : ContractBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public IEnumerable<Address> Address { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}