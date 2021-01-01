using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void EventDelegate(int speed);

    class Program
    {
        static void Main(string[] args)
            {
            Car car = new Car();

             
            car.speed += car.printMove;

            car.Start();

            Console.ReadLine();
            }
        }
     class Car
    {

        public event EventDelegate speed ;
        
        public void Start()
        {  
            int speedometer = 0;
            while (speedometer < 100)         
            {
                speedometer ++;
                if (speedometer == 30)
                    speed(speedometer);
                else if (speedometer == 60) 
                    speed(speedometer);
                else if (speedometer == 99)
                    speed(speedometer);
            }
        }
        public void printMove(int speed)
        {
            switch (speed)
            {
                case 30:
                    Console.WriteLine("Первая передача");
                    break;
                case 60:
                    Console.WriteLine("Вторая передача");
                    break;
                case 99:
                    Console.WriteLine("Хана движку");
                    break;

            }

        }

    }
}


