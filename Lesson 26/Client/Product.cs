using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [DataContract(Namespace = "Other")]
    public class Product
    {




        [DataMember]
        public int Cost { get; set; }
        public Product(int cost)
        {

            Cost = cost;
        }



    }
}
