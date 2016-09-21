using System.ComponentModel;
using System.ServiceModel;

namespace Wcf.Contracts.Contracts
{
    [ServiceContract(Namespace = "wcf.common/random/char")]
    public interface IRandomCharService
    {
        [OperationContract(Name = "GetChar")]
        [Description("Gets random alphanumeric char.")]
        char GetRandomChar();
    }
}
