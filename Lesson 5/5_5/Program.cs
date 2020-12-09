using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Добавить умения студенту\n");
            string takeSkill = Console.ReadLine();
            student.addToSkill(takeSkill);
            Console.WriteLine("Поиск умения\n");
            string screachSkill = Console.ReadLine();
            student.checkSkill(screachSkill);
            student.printArray();
            
            Console.ReadLine();
            
            

            
           
            
        }
    }

    class Student
    {
        string newSkill;
        string screachSkillValue;
        bool checkSkillss = false;

        public string NewSkill
        {
            get { return newSkill; }
            set { newSkill = value; }
        }
        public string ScreachSkill
        {
            get { return screachSkillValue; }
            set { screachSkillValue = value; }
        }


        private string[] arraySkills = new string[]
       {"Умный","Целеустремленный","Пунктуальный","Усидчивый" };
       
        
    public void addToSkill(string newSkill)
        {
            Array.Resize(ref arraySkills, arraySkills.Length + 1);

            for (int i = 0; i < arraySkills.Length; i++)
            {
                if (arraySkills[i] == null)
                    arraySkills[i] = newSkill;
            }
        }
    public void printArray()
        {
            for (int i = 0; i < arraySkills.Length; i++)
            {
                Console.WriteLine(arraySkills[i]);
            }
        }
    public void printError(bool checkSkillss)
        {
            if(checkSkillss == false)
            Console.WriteLine("Нету \n \n");
        }
    private void printSearchPositive()
        {
            if (checkSkillss == true) 
            Console.WriteLine("Есть совподение \n \n");
        }
    public void checkSkill(string screachSkill)
        {
           
            for (int i = 0; i < arraySkills.Length; i++)
            {

                if (arraySkills[i] == screachSkill)
                {
                    checkSkillss = true;
                    printSearchPositive();
                }

            }
            if (checkSkillss == false)
                printError(checkSkillss);
     
        }



    }
}
