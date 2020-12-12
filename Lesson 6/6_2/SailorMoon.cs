using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SailorMoon : SuperHero
    {

        public SailorMoon()
        {
            Name = "SailorMoon";
            Health = 100;
            Energe = 100;
            Сharacter = true;
        }

        public int healing(SuperHero person)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name}  Лунная Призма, дай мне силу!");
            Console.ResetColor();
            if (person.Health <= 100 && person.Сharacter == true)
            {
                person.Health += 20;
                Energe -= 20;
                person.indicators();
            }
            else
            {
                person.Health -= 20;
                Energe -= 20;
                person.indicators();

            }
            indicators();
            return person.Health;
        }
    }
}