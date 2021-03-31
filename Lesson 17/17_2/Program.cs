using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_7
{

    class Program
    {
        static void Main(string[] args)
        {
            List<СarOwner> carOwner = new List<СarOwner>();
            carOwner.Add(new СarOwner("Mercedes-Benz", "Vlad", 0956253232));
            carOwner.Add(new СarOwner("Renault", "Mark", 0256253331));
            carOwner.Add(new СarOwner("Mercedes-Benz", "Anton", 0956353235));
            carOwner.Add(new СarOwner("Peugeot", "Olha", 0953252323));
            carOwner.Add(new СarOwner("Hyundai", "Igor", 0753232399));

            List<Car> cars = new List<Car>();
            cars.Add(new Car("Mercedes-Benz", 2020, "Black"));
            cars.Add(new Car("Peugeot", 2018, "Red"));
            cars.Add(new Car("Hyundai", 2016, "Black"));
            cars.Add(new Car("BMW", 2021, "Green"));
            cars.Add(new Car("Renault", 2014, "White"));




            var ListClients = carOwner.OrderBy(i => i.Name)
                                      .Join(cars,
                                            client => client.Brand,
                                            car => car.Brand,
                                           (client, car) => new
                                           {
                                               Name = client.Name,
                                               Phone = client.NumberPhone,
                                               Model = car.Brand,
                                               YearOfIssue = car.YearOfIssue,
                                               Color = car.Color
                                           });

            foreach (var clients in ListClients)
            {
                Console.WriteLine($"Имя: {clients.Name} Телефон: {clients.Phone} Модель: {clients.Model} Год Выпуска: {clients.YearOfIssue} Цвет: {clients.Color}");
            }

            Console.Read();

        }



    }

    class Car
    {
        public string Brand { get; set; }
        public int YearOfIssue { get; set; }
        public string Color { get; set; }

        public Car(string Brand, int YearOfIssue, string Color)
        {
            this.Brand = Brand;
            this.YearOfIssue = YearOfIssue;
            this.Color = Color;
        }


    }

    class СarOwner
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int NumberPhone { get; set; }

        public СarOwner(string Brand, string Name, int NumberPhone)
        {
            this.Brand = Brand;
            this.Name = Name;
            this.NumberPhone = NumberPhone;
        }
    }


}

