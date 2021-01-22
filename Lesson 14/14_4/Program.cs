using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreApp
{

    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            object locker = new object();

            for (int i = 0; i < Console.WindowWidth - 1; i++)
            {
                new Thread(() => Print(i)).Start();
            }



            void Print(int stream)
            {

                char symbol = (char)random.Next(50, 100);
                int height = random.Next(0, Console.WindowHeight);
                int weight = random.Next(0, Console.WindowWidth);
                int currentHeight = 0;

                Console.ForegroundColor = ConsoleColor.Green;

                while (true)
                {
                    lock (locker)
                    {
                        if (height == Console.WindowHeight - 1)
                        {
                            height = 0;
                            currentHeight = stream + weight;
                            weight += 1;
                            ;

                        }
                        else
                        {
                            currentHeight = stream + weight++;
                            weight += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new string(' ', currentHeight) + symbol);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new string(' ', currentHeight) + symbol);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(new string(' ', currentHeight) + symbol);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new string(' ', currentHeight) + symbol);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(new string(' ', currentHeight) + symbol);
                        Thread.Sleep(200);


                    }
                }

            }

        }
    }
}



