using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        public static void StreamThird()
        {

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(new string(' ', 30) + "Третий поток");
                Thread.Sleep(300);
            }
        }

        static void StreamSecond()
        {
            Thread stream = Thread.CurrentThread;
            Thread backgroundProcess = new Thread(StreamThird);
            backgroundProcess.IsBackground = true;
            backgroundProcess.Start();
            stream.Name = "Второй поток";


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string(' ', 15) + $"{Thread.CurrentThread.Name}");
                Thread.Sleep(400);
            }
        }


        static void Main(string[] args)
        {
            Thread Stream = new Thread(new ThreadStart(StreamSecond));
            Stream.Start();
            Stream.Join();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Первый поток");
                Thread.Sleep(400);
            }

            Console.ReadLine();
        }

    }
}
