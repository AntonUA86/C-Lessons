﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    public interface IClientContractCallback
    {
        [OperationContract(IsOneWay = true)]
        void GetSignalOfResult(long result);
    }

}
