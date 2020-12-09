using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class BookStore
    {
        int cashbox = 0;
   

       public int Cashbox
        {

           private get { return cashbox; }
            set { cashbox = value; }
        }



        public void sellBook(Book[] array , int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].NumberBook == num)
                    Cashbox += array[i].Cost;      
            }
        }

        public void extraCharge(Book[] array, string genre, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Genre == genre)
                    array[i].Cost += num;
            }
        }
        public void pritCash()
        {
            Console.WriteLine(cashbox);
        }

 
    }
}


