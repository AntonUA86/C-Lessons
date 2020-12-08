using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {

        static void Main(string[] args)
        {
            byte numberOne = 0111;
            byte numberTwo = 0011;
            getMax(numberOne, numberTwo);
            Console.WriteLine(getMax(numberOne, numberTwo));
            Console.ReadLine();
        }

        static int getMax(int a, int b)
        {
            int c = a - b;
            int k = (c >> 7) & 0x1;
            int max = a - k * c;
            return max;
        }
    }
}
