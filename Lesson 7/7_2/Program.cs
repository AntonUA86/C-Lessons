using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
   
    class Program
    {
        static void Main(string[] args)
        {

            Animals[] animals = new Animals[3];
            animals[0] = new Cat("Cat");
            animals[1] = new Cock("Cock");
            animals[2] = new Dog("Dog");
           

            foreach (Animals beast in animals)
            {
                if (beast.Name == "Cat" || beast.Name == "Cock")
                {
                    beast.Sing();
                    
                }else if(beast.Name == "Dog")
                {
                    beast.Sing();
                    ((Dog)beast).wagging();
                }
            }
            Console.ReadLine();
        }


    }
    class Cat : Animals
    {


        public Cat(string name)
        : base(name) { }

        public override void Sing()
        {
            Console.WriteLine("Мяу Мяу Мяу");
        }
    }
    class Cock : Animals
    {


        public Cock(string name)
        : base(name) { }

        public override void Sing()
        {
            Console.WriteLine("Ку-ка-ре-ку! ");
        }

    }
    class Dog : Animals,iDog
    {


        public Dog(string name)
        : base(name) {
            
        }
     

        public override void Sing()
        {
            Console.WriteLine("Гав-гав-гав! ");
        }
        public  void wagging()
        {
            Console.WriteLine("wagging");
        }
    }


}