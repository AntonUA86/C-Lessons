using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Напишите регулярку для ввода числа от 0 до 99999...Обратите внимание что число 00 или
01 не должно быть валидным…..*/

namespace Lesson
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Regex regex = new Regex(@"^([1-9][0-9]{0,2}|999)$");


            while (true)
            {
                Console.WriteLine("Введите число");
                int number = int.Parse(Console.ReadLine());
                MatchCollection match = regex.Matches(Convert.ToString(number));
                if (match.Count > 0)
                    Console.WriteLine("Правильно");
                else
                    Console.WriteLine("Нет");
            }

            
        }
    }

}
