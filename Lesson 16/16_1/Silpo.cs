using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
   public class Silpo 
    {
        public Product product = new Product();
        public bool VIP;
        public Silpo(bool vip)
        {
            this.VIP = vip;
            
        }

        public IEnumerable<string> GetProducts()
        {
            if (VIP == true)
            {
                yield return product.Jamon;
                yield return product.Passionfruit;
                yield return product.ChocolateMarshmallows;
            }
            else
            {
                yield return product.ExpiredCrackers;
                yield return product.StillWater;
            }
        }
    }
}
