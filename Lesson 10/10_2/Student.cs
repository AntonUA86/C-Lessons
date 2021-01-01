using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_2
{
    struct Student
    {
        

        public string name { get; set; }
        public  int  energe { get; set; }
        public double averageScore { get; set; }

        

        public Student(string name,int energe, int averageScore)
        {
            this.name = name;
            this.energe = energe;
            this.averageScore = averageScore;
        }
    }
}
