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

            Car car = new Car();
            Car[] arrayCars = new Car[4];
            arrayCars[0] = new Car("BMW", 2017, "Black", 430000);
            arrayCars[1] = new Car("Mercedes-Benz", 2020, "Red", 4000000);
            arrayCars[2] = new Car("Audi", 2015, "White", 5000000);
            arrayCars[3] = new Car("Honda", 2012, "Black", 1400);
            int currentYear = 2020;
            int costCar = 200000;
            car.GetInfo(arrayCars);


            car.sreachCars(arrayCars, costCar, currentYear);
            
            
            Console.ReadLine();
        }
       
        
           

        }


    }
    class Car
    {

        public string model;
        public int year;
        public string color;
        public int cost ;
      
        public Car(string model, int year, string color, int cost)
        {
           this.model = model;
           this.year = year;
           this.color = color;
           this.cost = cost;
        }
    public Car()
    {

    }

     public void sreachCars(Car[] arrayCars, int costCar, int currentYear)
     {

       
        for (int i = 0; i < arrayCars.Length; i++)
        {
            if (arrayCars[i].cost < costCar)
            {
                if(arrayCars[i].year < currentYear)
                Console.WriteLine(arrayCars[i].model);
                Console.WriteLine(arrayCars[i].color);
            }
        }
     }
    public void GetInfo(Car[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {

            Console.WriteLine($"Модель: {array[i].model} \n Год: {array[i].year}, Цвет : {array[i].color}, Цена :{array[i].cost}");
        }

    }
}

