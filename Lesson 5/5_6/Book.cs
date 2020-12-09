using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Book
    {
        private int numberBook;
        private string name;
        private string genre;
        private int cost;

        public int NumberBook
        {
            get { return numberBook; }
            set { numberBook = value; }
        }
       public  string Name
        {
            get { return name; }
            set { name = value; }
        }
    public    string Genre

        {
            get { return genre; }
            set { genre = value; }
        }
    public    int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Book(int numberBook, string name, string genre, int cost)
        {
            NumberBook = numberBook;
            Name = name;
            Genre = genre;
            Cost = cost;
        }

        public Book()
        {

        }
        public void GetInfo(Book[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {   
               
                Console.WriteLine($"Номер: {array[i].NumberBook} \n Название книги : {array[i].Name}, Жанр : {array[i].Genre}, Цена :{array[i].Cost}");
            }
           
        }
        
        

















    }

}

