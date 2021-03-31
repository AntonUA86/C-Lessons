using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Weapon
{
    interface iWeapons
    {
        string Name { get; }
        double Damage { get; set; }
    }
}
