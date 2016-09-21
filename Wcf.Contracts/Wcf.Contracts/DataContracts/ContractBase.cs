using System.Runtime.Serialization;

namespace Wcf.Contracts.DataContracts
{
    [DataContract]
    public class ContractBase
    {
        [DataMember]
        public long Id { get; set; }
    }
}
