using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Server
{
    public class Service : IContract
    {
        public int Receipt(List<Product> products)
        {
            int result = 0;
            foreach (var item in products)
            {
                result += item.Cost;
            }
            return result;
        }

        public int Sum(Product OneProd, Product twoProd)
        {

            int resulet =  OneProd.Cost + twoProd.Cost;   
            return resulet;
           
        }

       
       
    
    }
}