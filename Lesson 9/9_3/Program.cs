using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    /*  3.Создать класс Ferrari, особенность этого класса что более 100 экземпляров Ferrari создать нельзя*/
    class Program
    {
        static void Main(string[] args)
        {

            Ferrari ferrari = new Ferrari();
            Ferrari ferrar2 = new Ferrari();
            Ferrari ferrar3 = new Ferrari();
            public class Car
        {
            public event EventDelegate myEvent = null;




            public void InvokeEvent()
            {
                myEvent();
            }
        }
        static private void Handler1()
        {
            while (speed > 100)
                speed++;
            Console.WriteLine("Сломася двигатель");
        }
        static int speed = 0;
        static void Main(string[] args)
        {

            Car car = new Car();

            car.myEvent += new EventDelegate(Handler1);


            car.InvokeEvent();
            Console.ReadLine();
        }


        Console.Read();
        }

        class Ferrari
        {
            static int count = 0;

            public Ferrari()
            {
                count++;
                if (count > 2)
                {
                    Console.WriteLine("Ferrari больше нет");
                }
            }
        }
    }
}
    
  

