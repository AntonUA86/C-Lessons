using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    /*   1. Создайте коллекцию продуктов со следующими данными: Код товара, название товара,тип
     товара, цена…. Используя LINQ запрос, выведите на экран код товара с ценой выше 30.
   
    */

    class Program
    {

        static void Main(string[] args)
        {
            List<Product> catlog = new List<Product>();
            catlog.Add(new Product(3, "Баклажан", "Овощи", 20));
            catlog.Add(new Product(25, "Мыло", "Химия", 123));
            catlog.Add(new Product(34, "Шампунь", "Химия", 200));
            catlog.Add(new Product(2, "Банан", "Фрукты", 55));
            catlog.Add(new Product(22, "Джек Дэниэлс", "Алкоголь", 560));
            catlog.Add(new Product(23, "Мандарин", "Фрукты", 69));


            var query =
                from product in catlog
                where product.Cost > 30
                select new
                {
                    CodeProduct = product.CodeProduct,
                    Name = product.Name,
                    TypeProduct = product.TypeProduct,
                    Cost = product.Cost
                };
          

            Console.WriteLine("Список продуктов :\n");
            foreach (var item in query)
            {
                Console.WriteLine("Код :{0} Имя :{1} Тип :{2}  Цена:{3}", item.CodeProduct, item.Name, item.TypeProduct, item.Cost);
            }
            Console.Read();

        }

        class Product
        {

            public int CodeProduct { get; set; }
            public string Name { get; set; }
            public string TypeProduct { get; set; }
            public int Cost { get; set; }

            public Product(int CodeProduct, string Name, string TypeProduct, int Cost)
            {
                this.CodeProduct = CodeProduct;
                this.Name = Name;
                this.TypeProduct = TypeProduct;
                this.Cost = Cost;
            }

        }
    }
}




