using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1. Вам необходимо описать класс книжный магазин...В нем вы описуете поле которое
содержит массив книг...Книга – это структура, в которой описаны поля: название, автор,
жанр,цена...Вам необходимо:
 Описать индексатор, в который вы передаете имя автора, а индексатор вам
возвращает название книги, первой попавшейся.
 Описать индексатор, в который вы передаете жанр, и цену а индексатор вам
возвращает массив книг этого жанра с указанной или менее ценой.
 В класс книжный магазин, добавить метод Add, который будет в массив книг
добавлять очередную книгу. */



namespace One
{
    class Program
    {
        static void Main(string[] arg)
        {
            BookStore bookStore = new BookStore();
            

            bookStore.PrintBook(bookStore.books);
            Console.WriteLine(bookStore["Лев Толстой"]);
            Console.WriteLine(bookStore["Роман", 2500]);
            bookStore.add("Никогда не сдавайся. Лучшие речи Черчилля", "Уинстон Черчилль", "Биография",  2400);
            bookStore.add("Кровь, пот и пиксели", "Джейсон Шрейер", "История",  3200);
            bookStore.PrintBook(bookStore.books);
            
            Console.ReadLine();
      
        
    }   
    }
}

