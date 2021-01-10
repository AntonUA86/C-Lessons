using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
   public class Keyboard
    {
                         
        public void start(Key[] deleg)
        {
   
            while (true)
            {
                string key = Console.ReadLine();
                switch (key)
                {
                    case "z":
                    case "Z":
                        deleg[1]();
                        deleg[0]();
                        deleg[1]();
                        break;
                    case "o":
                    case "O":
                        deleg[2]();
                        break;
                    case "n":
                    case "N":
                        deleg[3]();
                        deleg[0]();
                        
                        break;

                    default:
                        Console.WriteLine("Нет обработчика нажатия на клавишу {0}", key);
                        break;
                }

            }
        }
    }
}
