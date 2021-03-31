using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Location
{
    struct SecondLevel : ILocation
    {
        public string Name => "Police station";

        public string NameBoss => "Sheriff";

        public double Exp => 10;

        public string Quest => "Убеги из тюрьмы";


        public override string ToString()
        {
            return $"Локация: {Name} Имя Босса :{NameBoss} Награда: {Exp} Задание: {Quest}";
        }


    }
}
