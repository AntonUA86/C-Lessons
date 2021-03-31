using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest.Model.Location
{
    struct FirstLevel : ILocation
    {
        public string Name => "Old West Saloon";

        public string NameBoss => "Billy the Kid";

        public double Exp => 50;

        public string Quest => "Убей Billy the Kid";

        public override string ToString()
        {
            return $"Локация: {Name} Имя Босса :{NameBoss} Награда: {Exp} Задание: {Quest}";
        }
    }
}
