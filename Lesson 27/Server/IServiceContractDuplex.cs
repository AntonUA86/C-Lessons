using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract(Namespace = "Duplex", SessionMode = SessionMode.Required,
                     CallbackContract = typeof(IClientContractCallback))]
    public interface IServiceContractDuplex
    {

        [OperationContract(IsOneWay = true)]
        void ServiceFactorial();

    }
}
