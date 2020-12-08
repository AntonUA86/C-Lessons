using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] myArray = new int[100];
            int negativeNum = 0;
            int index = 0;

            Random random = new Random();


            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0)
                    myArray[i] = random.Next(1, 50);
                else
                    myArray[i] = (random.Next(1, 50)) * -1;

            }
            Console.WriteLine("Изначальный Массив :");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                {
                    negativeNum = myArray[i];
                    myArray[i] = myArray[index];
                    myArray[index] = negativeNum;
                    index++;
                }
            }

            Console.WriteLine("\nОтсортированный Массив : \n");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }
            Console.ReadLine();

        }
    }
}