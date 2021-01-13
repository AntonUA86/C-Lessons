using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    delegate void PrintLatter(int size, int column, int row);
    delegate bool Line(int size, int column, int row);

    class Program
    {
        static void Main(string[] args)
        {

            Line[] N = new Line[]
         {
             new Line(Lines.VerticalLeft),
             new Line(Lines.VerticalRight),
             new Line(Lines.DiagonalRow),
         };

            Line[] O = new Line[]
        {
                new Line(Lines.HorizontalTop),
                new Line(Lines.HorizontalBottom),
                new Line(Lines.VerticalLeft),
                new Line(Lines.VerticalRight)
        };

            Line[] Z = new Line[]
            {
                new Line(Lines.Slash),
                new Line(Lines.HorizontalBottom),
                new Line(Lines.HorizontalTop)
            };

            Line[] X = new Line[]
            {
                new Line(Lines.DiagonalRow),
                new Line(Lines.Slash)
            };
      

           PrintLatter(9, N);
           PrintLatter(9, Z);
           PrintLatter(9, X);
           PrintLatter(9, O);

            Console.Read();
        }


        static void PrintLatter(int size, Line[] letter)
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    for (int index = 0; index < letter.Length; index++)
                    {
                        if (letter[index](size , column ,row))
                        {
                            Console.Write("*");
                        }
                    }
                    if (row == 0 || row == (size - 1))
                        Console.Write("");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}



