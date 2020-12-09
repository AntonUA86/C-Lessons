using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program

    {
        static void Main(string[] args)
        {
            Book book = new Book();

            Book[] arrayBoks = new Book[3];
            arrayBoks[0] = new Book(1, "Думай и богатей", "Литература по саморазвитию", 3000);
            arrayBoks[1] = new Book(2, "Моби Дик, или Белый кит", "Художественная  литература", 2000);
            arrayBoks[2] = new Book(3, "Война и мир", "Роман", 1000);



            
            BookStore bookStore = new BookStore();
            Console.WriteLine("Добро пожаловать в Книжнный магазин\n");
            Console.WriteLine("Выберите понравившуюся книгу:\n");
            book.GetInfo(arrayBoks);
            Console.WriteLine("Введите номер:\n");
            int num = int.Parse((Console.ReadLine()));
            bookStore.sellBook(arrayBoks, num);
            Console.WriteLine("Сумма покупки:\n");
            bookStore.pritCash();


            Console.WriteLine("Сделать наценку : Видете жанр и на сколько увеличить стоимость");
            string nameBook = Console.ReadLine();
            int extraNumber = int.Parse((Console.ReadLine()));
            bookStore.extraCharge(arrayBoks, nameBook, extraNumber);
            book.GetInfo(arrayBoks);
            Console.ReadLine();


        }

    }
}