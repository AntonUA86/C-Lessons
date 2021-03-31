using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public  class Service : IServiceContractDuplex
    {
          
        public void ServiceFactorial()
        {
            var callback =
               OperationContext.Current.GetCallbackChannel<IClientContractCallback>();
            int n = 52;  
            long factorial = 1;  

            for (int i = 2; i <= n; i++) 
            {
                Thread.Sleep(300);
                factorial = factorial * i;
                Console.WriteLine(factorial);
            }
               callback.GetSignalOfResult(factorial);
         
        }

    }
}