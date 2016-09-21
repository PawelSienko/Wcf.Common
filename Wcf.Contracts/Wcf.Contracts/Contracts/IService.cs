using System.ServiceModel;
using Wcf.Contracts.DataContracts;

namespace Wcf.Contracts.Contracts
{
    [ServiceContract]
    public interface IService<in TItem,in TId> 
        where TItem: ContractBase
    {
        [OperationContract]
        void Add(TItem item);


        [OperationContract]
        void Delete(TItem item);
        

        [OperationContract]
        void Select(TId id);


        [OperationContract]
        void Update(TItem item);
    }
}
