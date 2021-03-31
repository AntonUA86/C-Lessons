using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    [CityAttribute("7/06/2021", "Киев", Release = "Realese", System = "Linux", Version = 7.01)]
    class Kyiv : City
    {
        public Kyiv(string county, string name, int population)
           : base(county, name, population)
        {

        }
    }
}
