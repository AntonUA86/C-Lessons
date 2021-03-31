using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    /* 1. Создайте класс Сильпо….Когда вы создаете экземпляр этого класса, в методе Main, то вы
указываете, являетесь вы VIP- персоной или нет…Далее передаете ваш экземпляр в
foreach… в foreach мы перебираем товары из Сильпо …. товар (экземпляр класса
Товар)…Причем если вы VIP-персона, то вам показывают хамон, маракую и зефир в
шоколаде, а если нет то показывают просроченные сухарики и воду без газа….(попробуйте
решить задачу через yield) 
.*/

    class Program
    {

        static void Main(string[] args)
        {
            Silpo silpo = new Silpo(true);
            foreach (string product in silpo.GetProducts())
            {
                Console.WriteLine(product);
            }
           
            Console.Read();
        }



    }
}



