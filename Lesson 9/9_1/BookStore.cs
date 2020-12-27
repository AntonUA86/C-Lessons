using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    class BookStore
    {

        public  Book[] books =
          {
            new Book {name = "Думай и богатей", author = "Наполеон Хилл", genre = "Литература по саморазвитию",cost= 3000},
            new Book {name = "Моби Дик, или Белый кит", author = "Герман Мелвилл", genre= "Художественная  литература", cost= 2000},
            new Book {name = "Война и мир", author = "Лев Толстой", genre= "Роман", cost= 1000},
            new Book {name = "Мастер и Маргарита", author = "Михаил Булгаков", genre= "Роман", cost= 2000},
            new Book {name = "Великий Гэтсби", author = "Фрэнсис Скотт Фицджеральд", genre= "Роман", cost= 3000},
          };
        

        
        public void PrintBook(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine($" Название книги : {book.name} Автор : {book.author} Жанр :{book.genre} Цена:{book.cost}");
            }
        }

        public string this[string author]
        {
            get
            {
                
                foreach (Book book in books)
                {
                    if (book.author == author)
                        return book.author + " - " + book.name;
                }

                return string.Format("{0} - нет такого автора ", author);
            }
        }
        public string this[string genre, int cost]
        {
            get
            {
                foreach(Book book in books)
                {
                    if (book.genre == genre && book.cost <= cost)
                    {
                        Console.WriteLine($" Название книги : {book.name} Автор : {book.author} Жанр :{book.genre} Цена:{book.cost}");
                    }

                }
                return string.Format("{0} нет такого ", genre);
            }
        }
        public void add( string name, string author, string genre, int cost)
        {
            Array.Resize(ref books, books.Length + 1);

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].name == null)
                {
                    books[i].name = name;
                    books[i].author = author;
                    books[i].genre = genre;
                    books[i].cost = cost;
                }
            }
            
        }






    }

}