using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Deadpool : SuperHero
    {
        public Deadpool()
        {
            Name = "Deadpool";
            Health = 100;
            Energe = 100;
            Сharacter = false;
        }
        uint bullets = 6;
        
        public uint Bullets
        {
            get { return bullets; }
            set { bullets = value; }
        }
        public void shot(SuperHero person)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deadpoll достал револьвер");
            Console.ResetColor();
            while (person.Health <= 100 && Bullets > 0 )
            {
                
               
                if (Bullets != 0)
                {
                    for (; 0 < 6;)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Deadpoll открыл огонь по {person.Name}!!! Выстрел номер  {Bullets}");
                        Console.ResetColor();
                        person.Health -= 5;
                        Bullets--;
                        
                        if (Bullets == 0)
                            break;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Deadpoll не смог выстрелить ,  барабан пуст");
                    Console.ResetColor();
                }
            }
        
            
          

        }
        public void recoveryGun()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deadpoll перезарядил револьвер");
            Console.ResetColor();
            if (Bullets == 0)
                Bullets +=  3;
           
        }



    }    
}
