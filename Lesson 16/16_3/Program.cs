using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*3.Создайте класс Tovar, с необходимыми полями….Переопределите методы Equals и
GetHashCode, таким образом, чтобы если товары одного названия, типа и цены то они равны. И
далее сделать HAshTable, в которой ключами будут товары , а значения экземпляр класса
Поставщик 
*/
namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(new Product("Edge", "Browser", 3),new Vendor("Microsoft"));
            hashTable.Add(new Product("Internet Explorer", "Browser", 1), new Vendor("Microsoft"));
            hashTable.Add(new Product("Google Chrome", "Browser", 10), new Vendor("Google"));
            Console.Read();
        }


    }

    class Product
    {

        public string Name { get; set; }
        public string Type { get; set; }
       
        public int Cost { get; set; }

        public Product(string name, string type, int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
          
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            Product product = (Product)obj;
            return (this.Name == product.Name) && (this.Type == product.Type) && (this.Cost == product.Cost);
        }

    }

    class Vendor
    {
        public string Name { get; set; }
        public Vendor(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }



}
