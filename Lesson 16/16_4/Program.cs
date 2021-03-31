using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreApp
{
    /*  1.  Сделать sorted list  в которого вы добавляете студентов а ключь это экземпляр класса 
     *  город (у города есть название и название области)….Каждый студент это имя, факультет и средний бал….
     *  Вам необходимо сделать свой  comparer , чтобы студенты были отсортированы по городам*/


    class Program
    {
        static void Main(string[] args)
        {


            SortedList<City, Student> Studenst = new SortedList<City, Student>();

            Studenst.Add(new City("Одесса", "Одеская облость"), new Student("Катя", "Физра", 3.5));
            Studenst.Add(new City("Донецк", "Донецкая облость"), new Student("Антон", "Физико-Математический", 4.3));
            Studenst.Add(new City("Киев", "Киевская облость"), new Student("Ольга", "ФизМат", 3.5));
            Studenst.Add(new City("Одесса", "Одеская облость"), new Student("Марина", "Физико-Математический", 3.5));
            Studenst.Add(new City("Киев", "Киевская облость"), new Student("Валера", "УкрМова", 4.5));

            
            Console.WriteLine(Studenst.Values);

            Console.ReadLine();
        }

        class Student 
        {
            string Name { get; set; }
            string Faculty { get; set; }
            double GPA { get; set; }

            City city { get; set; }

            public Student(string name, string faculty, double gpa)
            {
                Name = name;
                Faculty = faculty;
                GPA = gpa;
            }

           
        }

        class City : IComparable<City>
        {
            string Name { get; set; }
            string Region { get; set; }
            public City(string Name, string Region)
            {
                this.Name = Name;
                this.Region = Region;
            }

            public int CompareTo(City other)
            {
                return this.Name.CompareTo(other.Name);
            }
        }


    }
}



