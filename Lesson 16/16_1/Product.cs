using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
  public  class Product 
    { 
        public string jamon = "Хамон";
        string passionfruit = "Маракуйя";
        string chocolateMarshmallows = "Зефир в шоколад";
        string expiredCrackers = "Сухарики";
        string stillWater = "Воду без газа";

        public string Jamon
        {
            get
            {
                return jamon;
            }
            set
            {
                jamon = value;
            }
        }
        public string Passionfruit
        {
            get
            {
                return passionfruit;
            }
            set
            {
                passionfruit = value;
            }
        }
        public string ChocolateMarshmallows
        {
            get
            {
                return chocolateMarshmallows;
            }
            set
            {
                chocolateMarshmallows = value;
            }
        }
        public string ExpiredCrackers
        {
            get
            {
                return expiredCrackers;
            }
            set
            {
                expiredCrackers = value;
            }
        }
        public string StillWater
        {
            get
            {
                return stillWater;
            }
            set
            {
                stillWater = value;
            }
        }

        public Product(string jamon,
                       string passionfruit,
                       string chocolateMarshmallows,
                       string expiredCrackers,
                       string stillWater)
        {
            this.Jamon = jamon;
            this.passionfruit = passionfruit;
            this.chocolateMarshmallows = chocolateMarshmallows;
            this.expiredCrackers = expiredCrackers;
            this.stillWater = stillWater;
        }

        public Product()
        {

        }


    }
}
