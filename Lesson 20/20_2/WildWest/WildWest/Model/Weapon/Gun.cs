using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Weapon
{ 
    [Serializable]
    class Gun : iWeapons
    {
        double damage = 7;

        public double Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        public string Name => "Пистолет";




        public double Shot()
        {
            return Damage;
        }
    }
}
