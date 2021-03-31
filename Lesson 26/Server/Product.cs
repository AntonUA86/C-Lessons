using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [DataContract(Namespace = "Other")]
    public class Product
    {
       
        [DataMember]
        public int Cost { get; set; }
       
        public Product(string name, int cost)
        {
            Cost = cost;
        }


    }
}
