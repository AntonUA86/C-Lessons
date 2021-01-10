using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    public static class CreateLetter
    {


        public static void horizontel()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
            }

        }
        public static void slash()
        {
            string tempString = "            *";
            for (int i = 0; tempString.Length > 2; i++)
            {
                Console.WriteLine(tempString);
                tempString = tempString.Substring(2);
            }
        }

        public static void vertical()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }
        }
        public static void zero()
        {
            int radius = 10;
            double ratio = Convert.ToDouble(4.0 / 1.0);
            double a = ratio * radius;
            double b = radius;

            for (int i = -radius; i <= radius; i++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (i / b) * (i / b);
                    if (d > 0.1 && d < 0.2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }

                }
                 Console.WriteLine("\n");
            }
        }

    }
}
