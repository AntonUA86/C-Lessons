using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SuperHero
    {
        string name;
        int energe;
        int health;
        bool сharacter;

        public string Name { get { return name; } set { name = value; } }
        public int Energe { get { return energe; } set { energe = value; } }
        public bool Сharacter { get { return сharacter; } set { сharacter = value; } }
        public int Health { get { return health; } set { health = value; } }


        public  int random(int index)
        {
            Random random = new Random();
            return random.Next(index);
         }

        public void indicators()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} Энергия : {Energe} Здоровья : {Health}");
            Console.ResetColor();
        }

   



    }
}
