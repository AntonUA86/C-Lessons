using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{


    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            Developer_array developer_array = new Developer_array();
            developer_array.addToStart(ref myArray, 10);
            developer_array.addToEnd(ref myArray, 13);
            developer_array.addToIndex(ref myArray, 77,2);
            bool check = developer_array.searchElement(myArray, 2);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            if (check == true)
                Console.WriteLine("Число есть");
            else
                Console.WriteLine("Нету");
            Console.ReadKey();
            

        }
    }
}

