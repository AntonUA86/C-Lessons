using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Location
{
    interface ILocation
    {
        string Name { get; }
        string NameBoss { get; }
        double Exp { get; }
        string Quest { get; }



    }
}
