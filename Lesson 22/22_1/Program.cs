using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_2
{
    /*Задача на RegisterWaitForSingleObject …У вас есть бригада строителей: каменьщик,
гвоздезабиватель и собиратель табуреток…Все они работают в отдельных потоках…Вам
необходимо наладить рабочий процесс…Чтобы каменьщик клал по одному кирпичу в 3
секунду… гвоздезабиватель , забивал по гвоздю в 1.5 секунды и табуреточник- по 1
табуретке в 5 секнуд….И у вас еще есть возможность подгонять строителей…Если
нажимаете ‘К’ каменьщик сразу кладет кирпичь…если ‘Г’ то гвоздезабиватель забивает
гвоздь и т.д.. */

    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Идёт стройка");
            Console.WriteLine("К - Пнуть Каменщика");
            Console.WriteLine("M - Пнуть Маляра");
            Console.WriteLine("P - Пнуть Плотника");
            Console.WriteLine("Q - Разогнать всех");


           
            AutoResetEvent controllStonemason = new AutoResetEvent(false);
            AutoResetEvent controllPainter = new AutoResetEvent(false);
            AutoResetEvent controllСarpenter = new AutoResetEvent(false);

            RegisteredWaitHandle registeredStonemason = ThreadPool.RegisterWaitForSingleObject(controllStonemason, Stonemason, null, 1500, false);
            RegisteredWaitHandle registeredPainter = ThreadPool.RegisterWaitForSingleObject(controllPainter, Painter, null, 2000, false);
            RegisteredWaitHandle registeredСarpenter = ThreadPool.RegisterWaitForSingleObject(controllСarpenter, Сarpenter, null, 3000, false);


            while (true)
            { 
           
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.K:
                        controllStonemason.Set();      
                        break;
                    case ConsoleKey.M:
                        controllPainter.Set();
                        break;
                    case ConsoleKey.P:
                        controllСarpenter.Set();
                        break;
                    case ConsoleKey.Q:
                        registeredStonemason.Unregister(controllStonemason);
                        registeredPainter.Unregister(controllPainter);
                        registeredСarpenter.Unregister(controllСarpenter);
                        break;
                }

            }
           

        }

        static void Stonemason(object state, bool timedOut)
        {
            Thread.CurrentThread.Name = "Каменщик работает";
            Console.WriteLine($"{Thread.CurrentThread.Name}");
        }

        static void Painter(object state, bool timedOut)
        {
            Thread.CurrentThread.Name = "Маляр работает";
            Console.WriteLine($"{Thread.CurrentThread.Name}");

        }
        static void Сarpenter(object state, bool timedOut)
        {
            Thread.CurrentThread.Name = "Плотник работает";
            Console.WriteLine($"{Thread.CurrentThread.Name}");

        }

    }
}
