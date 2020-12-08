using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                int number;
                do
                {
                    number = random.Next(100) + 1;
                } while (Array.IndexOf(myArray, number) != -1);
                myArray[i] = number;
            }
            Console.WriteLine("Изначальный Массив :");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1 - i; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                        swap(ref myArray[j], ref myArray[j + 1]);
                }
            }


            Console.WriteLine("\nОтсортированный Массив : \n");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }

            Console.ReadLine();
        }
        public static void swap(ref int elemFirst, ref int elemSecond)
        {
            int currentElem = elemFirst;
            elemFirst = elemSecond;
            elemSecond = currentElem;
        }

    }
}
