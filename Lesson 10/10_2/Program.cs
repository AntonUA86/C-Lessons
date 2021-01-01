using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*У вас есть массив студентов..(Студент-это структура)…(У студента есть имя, кол-во
энергии, и средний балл за сессию)…Еще у вас есть массив делегатов с которыми
сообщены методы (помыть студента, накормить студента, уложить спать студента, и дать
стипендию, если средний балл более 4,5)….Весь этот массив делегатов должен пройтись по 
каждому студенту…Методы накормить и уложить спать должны увеличивать энергию
студента на 1…
*/
namespace Lesson_2
{
    
class Program
    {
        public delegate void Training(string name, int energe);
        

        static void Main(string[] args)
        {
            
            Training[] trainings = new Training[]
         {
             ActionStudent.wash, ActionStudent.feed,ActionStudent.slep, ActionStudent.scholarship
         };

                List<Student> students = new List<Student>();
                   students.Add(new Student() { name = "Anton", energe = 20, averageScore = 5 });
                   students.Add(new Student() { name = "Olha", energe = 40, averageScore = 4.2 });
                   students.Add(new Student() { name = "Igor", energe = 60, averageScore = 3.2 });
                   students.Add(new Student() { name = "Emma", energe = 90, averageScore = 4.6 });
                   students.Add(new Student() { name = "Danny",  energe = 43, averageScore = 3.4 });

                 foreach (Student student in students)
                   {
                       foreach (Training train in trainings)
                       {
                           if(student.averageScore > 4.5)
                           {
                        train(student.name, student.energe);
                           }
                       }
                  }
          
          









            Console.Read();
        }
    }
}

