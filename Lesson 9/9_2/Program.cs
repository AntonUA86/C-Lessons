using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.Создайте класс рыбка....Добавьте ей, с помощью расширяющих методов, возможность
бегать и говорить....Причем метод говорить принимает, как аргумент то что рыбка должна
сказать.*/
namespace LessonTwo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            fish.run();
            fish.say("Hello World");
            Console.Read();
        }
    }

   sealed class Fish
    {
        public static decimal bonus = 100;
    }

    static class ExtensionFish 
    {
        
        public static void run(this Fish fish)
        {

            Console.WriteLine("Бегать");
        }
        public static void say(this Fish fish,string text)
        {
            Console.WriteLine($"{text}");

        }
    }



}
    
  


