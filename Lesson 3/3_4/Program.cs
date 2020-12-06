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
           
            int[] myArray = { 13, 3, 4, 13, 5, 7, 11, 9, 8, 10 };

            int negativeMin = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 1 && myArray[i] < negativeMin)
                {
                    negativeMin = myArray[i];
                }
            }

            Console.WriteLine(negativeMin);

            Console.ReadLine();
        }
    }
}

