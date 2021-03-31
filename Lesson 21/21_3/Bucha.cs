using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    [CityAttribute("7/07/2021", "Буча", Release = "Demo", System = "Windows", Version = 2.01)]
    class Bucha : City
    {
        public Bucha(string county, string name, int population)
            :base (county,name,population)
        {

        }
    }
}
