
using System.ServiceModel;
using Wcf.Contracts.DataContracts;

namespace Wcf.Contracts.Contracts
{
    [ServiceContract(Namespace = "Wcf.Contracts.IUserService")]
    public interface IUserService : IService<User,long>
    {
    }
}
