using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using Wcf.Contracts.DataContracts;

namespace Wcf.Contracts.Contracts
{
    [ServiceContract]
    public interface IRandomUserGeneratorService
    {
        [OperationContract]
        [Description("Gets some random user")]
        IEnumerable<User> GetRandomUsers();
    }
}
