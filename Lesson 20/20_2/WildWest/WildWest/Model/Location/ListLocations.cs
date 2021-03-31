using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Location
{
    public class ListLocations
    {


        List<ILocation> locations = new List<ILocation>();

        public ListLocations()
        {
            locations.Add(new FirstLevel());
            locations.Add(new SecondLevel());
        }

        public IEnumerable GetAllLocations(string nameLocation)
        {

            foreach (var location in locations)
            {
                if (nameLocation == location.Name)
                {
                    yield return location.ToString();
                }
            }

        }

    }
}
