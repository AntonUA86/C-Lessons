using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_2
{
    class Program
    {
        static void Main(string[] args)

        {

            /**1.1* вы вводите число от 1 до 12 (число месяцев в году) */

            int seasons = int.Parse(Console.ReadLine());

            if (seasons <= 3)
            {
                Console.WriteLine("снежинка");
            }
            else if (seasons >= 4 && seasons <= 6)
            {
                Console.WriteLine("дождик");
            }
            else if (seasons >= 7 && seasons <= 8)
            {
                Console.WriteLine("солнышко");
            }
            else if (seasons >= 9 && seasons <= 12)
            {
                Console.WriteLine("ветерок");
            }

            /**1.2* Создать сценарий работы программы ‘Умный дом’…*/

            int inputHome = int.Parse(Console.ReadLine()); ;

            switch (inputHome)
            {
                case 1:
                    {
                        Console.WriteLine("Cвет в доме, включен");
                        Console.WriteLine("Кондиционер, включен");
                        Console.WriteLine("Все окна и двери, закрыты");
                        Console.WriteLine("Сигнализация включена");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Сигнализация отключина");
                        Console.WriteLine("Кондиционер включен");
                        Console.WriteLine("Кофемашина, включена");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Пылесос включен");
                        Console.WriteLine("Стиральная машина включена");
                        Console.WriteLine("Посудомоечная машина включена");
                        break;
                    }

                case 8:
                    {
                        goto case 3;
                    }
                default:
                    {
                        Console.WriteLine("Cообщение в охранную службу,отправлено!!!");
                        Console.WriteLine("Сообщение хозяину дома,отправлено!!! ");
                        Console.WriteLine("ЗЛАЯ СОБАКА,включена!!!");
                        break;
                    }

            }
            /**1.3* Найти среднее арифметическое среди чисел кратных восьми от 3 до 104*/

            int count = 0;
            int summ = 0;
            int result = 0;
            for (int i = 3; i <= 103; i++)
            {

                if (i % 8 == 0)
                {
                    count++;
                    summ += i;
                    result = summ / count;
                }
            }
            Console.WriteLine("Cреднее арифметическое = " + result);
            Console.ReadKey();
            Console.ReadLine();

            /*1.4*/
            namespace test3
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] arrayNum = new int[50];
                int[] multipleArr = new int[50];


                int current;
                while (true)
                {
                    for (int y = 0; y < arrayNum.Length; y++)
                    {
                        Console.Write("Введите число:\t");
                        current = int.Parse(Console.ReadLine());
                        arrayNum[y] = current;

                        if (current % 7 == 0)
                        {
                            do
                            {
                                multipleArr[y] = current;
                            } while (multipleArr[y] == 0);

                        }
                        if (current == 666)
                        {
                            goto end;
                        }
                    }
                end:
                    Console.WriteLine("Общий массив : \t");
                    for (int i = 0; i < arrayNum.Length; i++)
                    {
                        if (arrayNum[i] == 0)
                        {

                            continue;
                        }
                        Console.WriteLine(arrayNum[i] + " ");



                    }
                    Console.WriteLine("Кратные числа : \t");
                    for (int z = 0; z < multipleArr.Length; z++)
                    {
                        if (multipleArr[z] == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(multipleArr[z] + " ");
                    }
                    Console.WriteLine("Сумма = {0}\t", arrayNum.Sum() + multipleArr.Sum());
                    Console.ReadKey();

                }

            }
        }
    }




}
