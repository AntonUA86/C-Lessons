using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract(Namespace = "Duplex", SessionMode = SessionMode.Required,
                 CallbackContract = typeof(IClientContractCallback))]
    public class CallbackHandler : IClientContractCallback
    {
        [OperationContract(IsOneWay = true)]
        public void GetSignalOfResult(long result)
        {
            Console.WriteLine(result); 
        }
    }
}
