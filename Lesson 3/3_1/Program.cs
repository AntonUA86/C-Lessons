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
            /*1.четности / не четности значения используя логический сдвиг*/

            Console.WriteLine("Введите число для проверки:");
            byte number = byte.Parse(Console.ReadLine());
            byte result = (byte)(number << 7);

            if (result == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
            Console.ReadKey();
           
    }
}

