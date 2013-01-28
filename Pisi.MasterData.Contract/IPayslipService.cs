using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Pisi.MasterData.Contract
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IPayslipService
    {
        [OperationContract]
        IList<PayrollPeriod> FindAllPublishedPeriod();
    }
    public interface IPayslipChannel : IPayslipService, IClientChannel { }
}
