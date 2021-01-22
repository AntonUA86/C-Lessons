using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(() => PrintWord());
                threads[i].Start();
                Thread.Sleep(random.Next(100, 300));
            }
            void PrintWord()
            {
                Console.WriteLine((new string(' ', random.Next(0, 40)) + "МНОГОПОТОЧНОСТЬ "));
            }
            Console.Read();
        }


    }
}
