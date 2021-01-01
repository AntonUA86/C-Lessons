using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
     delegate void Corporate(ref Abramovich abarm);
         
    /*Создайте класс Абрамович и событие ‘Корпоратив’… методы, которые могут быть
сообщены с этим событием принимают один аргумент с модификатором ref (это кошелек
Абрамовича) …Привяжите на это событие методы разных классов которые будут
устраивать фейерверки, дискотеки, кормить гостей и т.д…..каждый метод будет из
кошелька Абрамовича забирать солидную сумму*/
    class Program
    {
        static void Main(string[] args)
        {
           
            Abramovich abramovich = new Abramovich();
            Women women = new Women();
            Friends friends = new Friends();

            abramovich.eventCorporate += women.fireworks;
            abramovich.eventCorporate += abramovich.buyFood;
            abramovich.eventCorporate += friends.fireworks;

            abramovich.Party(ref abramovich);
            Console.WriteLine(abramovich.Cash);


            Console.Read();
        }
    }

   


}
