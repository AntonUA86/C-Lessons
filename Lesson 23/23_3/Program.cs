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
        static Semaphore semaphore;
        static Timer timer;
        static CancellationTokenSource cancellation;

        static void Main(string[] args)
        {

            cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;

            semaphore = new Semaphore(10, 10, "henhouse");
 

            Task task = new Task(() => new Timer(new TimerCallback(rooster), null, 0, 2000), token);


            if (!task.IsCanceled)
            {
                task.Start();
            }



            Console.Read();

        }

        static void chicken(object obj)
        {
            semaphore.WaitOne();
            Console.WriteLine($"Курица {obj} несет яйца");
            Thread.Sleep(3000);
            semaphore.Release();
        }
        static void SayChiken()
        {
            for (int i = 0; i < 10; i++)
                new Thread(chicken).Start(i);
        }
        static void rooster(object obj)
        {
            int timeWork = int.Parse(DateTime.Now.ToString("HH"));
            if (timeWork > 5 || timeWork < 16)
            {
                Console.WriteLine("Ку-ка-ре-ку");
                SayChiken();

            }
            if (timeWork < 5 || timeWork > 16)
            {
                Console.WriteLine(" Хватит нести яйца");
                cancellation.Cancel();
            }

        }
    }


}
