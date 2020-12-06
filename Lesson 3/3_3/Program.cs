using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*3.Вам необходимо вывести такое количество звездочек в строке 
             * - равное значению элемента массива*/

            int[] array = { 3, 5, 4, -4, 5, -5, 7, -5, -8, 10 };
            int positiveCount = 0;
            int negativeCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    positiveCount++;

                else
                    negativeCount++;
            }
            Console.WriteLine("Положительное количество :");
            for (int i = 0; i < positiveCount; i++)
                Console.Write("*");
            Console.WriteLine("\nОтрицательное количество :");
            for (int i = 0; i < negativeCount; i++)
                Console.Write("*");
            Console.ReadLine();


         
        }
    }
}

