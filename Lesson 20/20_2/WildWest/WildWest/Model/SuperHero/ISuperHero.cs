using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.SuperHero
{

  public  interface ISuperHero
    {
        string Name { get; }
        int Level { get; set; }
        double Health { get; set; }
        double Exp { get; set; }

        string AttackWeapon();
        string StartQuests(string nameQuest);


    }
}
