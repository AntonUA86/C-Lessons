using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 5, 6, 7, 10, 2, 5, 6, 7, 444 };

            Task<int> task = new Task<int>(() => Average(array));
            task.Start();
            Console.WriteLine($"{task.Result}");




            Console.Read();
        }

    

        static int Average(int[] mas)
        {
            int summ = 0;
            int ave;
            for (int i = 0; i < mas.Length; i++)
                summ += mas[i];
            return ave = summ / mas.Length;

        }

  

    }

 

   
}
