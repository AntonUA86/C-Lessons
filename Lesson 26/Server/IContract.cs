﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
  

    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        int Sum(Product OneProd , Product twoProd);


        [OperationContract]
        int Receipt(List<Product> products);
    }

  
}
