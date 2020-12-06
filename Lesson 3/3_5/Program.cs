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
          
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[13];
            jaggedArray[1] = new int[11];
            jaggedArray[2] = new int[7];
            int countBy8 = 0;
            int[] arrayBy7 = new int[4];
            int[] arrayBy4 = new int[4];
            int[] arrayBy4Multi9 = new int[8];
            int[] arrayBy7Multi9 = new int[8];
            int minEven = 0;
            int minOdd = 0;


            Random random = new Random();


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(33, 133);
                }
            }
            int firstValue = jaggedArray[0][0];
            for (int i = 0; i < jaggedArray.Length; i++)

            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (j % 8 == 0)
                        countBy8++;

                    if (jaggedArray[i][j] % 7 == 0)
                        arrayBy7[i] = jaggedArray[i][j];

                    if (jaggedArray[i][j] % 4 == 0)
                        arrayBy4[i] = jaggedArray[i][j];

                    if (jaggedArray[i][j] % 2 == 0 && (jaggedArray[i][j] < firstValue))
                    {
                        minEven = jaggedArray[i][j];


                    }
                    if (jaggedArray[i][j] % 2 == 1 && (jaggedArray[i][j] < firstValue))
                    {
                        minOdd = jaggedArray[i][j];
                    }

                }
            }

            for (int i = 0; i < arrayBy4.Length; i++)
            {
                arrayBy4Multi9[i] = arrayBy4[i] * 9;
                arrayBy7Multi9[i] = arrayBy7[i] * 9;

            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Первые значения, которые делятся на 7: ");
            for (int i = 0; i < arrayBy7.Length; ++i)
            {
                if (arrayBy7[i] == 0)
                    break;
                Console.Write(" " + arrayBy7[i]);

            }
            Console.Write("\nПервые значения, которые делятся на 4: ");
            for (int i = 0; i < arrayBy4.Length; ++i)
            {
                if (arrayBy4[i] == 0)
                    break;
                Console.Write(" " + arrayBy4[i]);
            }
            Console.Write("\nКаждое значение которое делиться на 7 умножить 9 =");
            for (int i = 0; i < arrayBy7Multi9.Length; i++)
            {
                if (arrayBy7Multi9[i] == 0)
                    break;
                Console.Write(" " + arrayBy7Multi9[i]);
            }
            Console.Write("\nКаждое значение которое делиться на 4 умножить 9 =");
            for (int i = 0; i < arrayBy4Multi9.Length; i++)
            {
                if (arrayBy4Multi9[i] == 0)
                    break;
                Console.Write(" " + arrayBy4Multi9[i]);
            }
            Console.Write("\nКаждое значение которое делиться на 4 умножить 9 =");
            for (int i = 0; i < arrayBy4Multi9.Length; i++)
            {
                if (arrayBy4Multi9[i] == 0)
                    break;
                Console.Write(" " + arrayBy4Multi9[i]);
            }

            Console.WriteLine($"\nМинимальное значение среди четных  значений : {minEven}");
            Console.WriteLine($"\nМинимальное значение среди нечетных значений : {minOdd}");
            Console.WriteLine($"\nКоличество значение делиться на 8 без остатка:  {countBy8}");
            Console.ReadLine();
        }
    }
}

