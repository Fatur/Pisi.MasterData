using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Pisi.MasterData.Contract
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IRegistrationService
    {
        [OperationContract]
        VerificationEmployee GetEmployeeByVerificationKey(string key);

    }

    public interface IRegistrationChannel : IRegistrationService, IClientChannel { }
}
