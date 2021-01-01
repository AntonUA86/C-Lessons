using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
   public  static class  ActionStudent
    {
        public static void wash(string name, int energe)
        {
            Console.WriteLine($"Студент {name}  был помыт, энергия {energe} ");
        }
        public static void feed(string name, int energe)
        {
            Console.WriteLine($"Студент {name}  был накормлен, энергия  {energe} ");
        }
        public static void slep(string name, int energe)
        {
            Console.WriteLine($"Студент {name}  лег спать, энергия  {energe} ");
        }
        public static void scholarship(string name, int energe)
        {
            Console.WriteLine($"Студент {name}  получил стипедию, энергия  {energe} ");
        }
 
    }
}
