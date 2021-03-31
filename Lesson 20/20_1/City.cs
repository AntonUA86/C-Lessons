using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
  abstract  class City
    {
        string County { get; set; }
        string Name { get; set; }
        int Population { get; set; }

        public City(string county, string name, int population)
        {
            County = county;
            Name = name;
            Population = population;
        }

        public  string GetPopulation()
        {
            return $"{Population}";
        }


    }
}
