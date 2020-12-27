using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    struct Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int cost { get; set; }

   

        public Book(string name, string author, string genre, int cost)
            {
                this.name = name;
                this.author = author;
                this.genre = genre;
                this.cost = cost;
            }



    }
}