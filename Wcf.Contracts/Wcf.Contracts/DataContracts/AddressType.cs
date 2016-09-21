using System.Runtime.Serialization;

namespace Wcf.Contracts.DataContracts
{
    [DataContract(Name = "Type")]
    public enum AddressType
    {
        [EnumMember]
        Default = 0,

        [EnumMember]
        Abroad = 1
    }
}
