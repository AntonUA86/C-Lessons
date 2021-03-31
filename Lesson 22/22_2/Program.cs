using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_3
{
    /* Задача на Timer…Вам необходимо…В 5 часов утра запустить метод в котором
 закукарекает петух….И сразу в 10 потокох 10 куриц начнут нести яйцаа с рандомным
 интервалом….Затем в 16.00 запуститься метод в который петух закукарекает ‘Хватит
 нести яйца’ и курицы прекратят.*/

    class Program
    {
        static Semaphore semaphore;
        static Timer timer;


        static void Main(string[] args)
        {
          
            Random rnd = new Random();
            
            semaphore = new Semaphore(10, 10, "henhouse");
            timer = new Timer(new TimerCallback(rooster), null, 0, 2000);


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
                
                if (timeWork < 4 || timeWork > 16)
                    Console.WriteLine(" Хватит нести яйца");
            }


        }
    }
}
