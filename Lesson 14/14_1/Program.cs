using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Bun = new Product("Булка", 21, new Address("Крещатик", 43, new City("Киев")));
            ///поверхностое клонирование
            Product Jam = Bun.Clone() as Product;
            Jam.Name = "Антон";
            Jam.Weight = 30;
            Jam.Home.Number = 30;
            Jam.Home.City.Name = "Донецк";
            ///глубокое клонирование
            Product Nutella = Bun.FullClone() as Product;
            Nutella.Name = "Нутелла";
            Nutella.Weight = 20;
            Nutella.Home.Number = 43;
            Nutella.Home.Street = "Пушкина";
            Nutella.Home.City.Name = "Прага";

            Console.WriteLine(Bun);
            Console.WriteLine(Jam);
            Console.WriteLine(Nutella);



            Console.ReadLine();
        }
    }

    class Product : ICloneable
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Address Home { get; set; }

        public Product(string Name, int Age, Address Home)
        {
            this.Name = Name;
            this.Weight = Age;
            this.Home = Home;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public object FullClone()
        {
            Product student = (Product)this.MemberwiseClone();
            student.Home = new Address(this.Home.Street, this.Home.Number, new City(this.Name));
            return student;
        }

        public override string ToString()
        {
            return $"Имя :{Name}\nВозрарост :{Weight}\nАдрес\n{Home}\n";
        }
    }

    class Address
    {
        public int Number { get; set; }
        public string Street { get; set; }

        public City City { get; set; }

        public Address(string Street, int NumberHome, City City)
        {
            this.Number = NumberHome;
            this.Street = Street;
            this.City = City;
        }
        public override string ToString()
        {
            return $"Номер дома: {Number}\nУлица: {Street}\n{City}";
        }
    }

    class City
    {
        public string Name { get; set; }

        public City(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"Город: {Name}";
        }
    }
}



