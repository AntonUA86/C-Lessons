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
            
            Wardrobe wardrobe = new Wardrobe();
            Console.WriteLine("Добро пожаловать в гардероб ,сдавайте вещи");
            wardrobe[1] = "Hat";
            Console.WriteLine(wardrobe[1]);
            Console.ReadKey();
        }
    }

    class Wardrobe
    {
        private string[] clothes = new string[3];
        public  int time = int.Parse(DateTime.Now.ToString("HH"));
        public string this[int index]
        {
            get
            {
                return clothes[index];

            }   
            set
            {
                if(time < 9 || time > 18)
                {
                    Console.WriteLine("Не работаем");
                }
                else
                {
                    clothes[index] = value;
                    
                }
                
            }
        }
        public Wardrobe()
        {
          
        }
    
        public void print()
        {
            for (int i = 0; i < clothes.Length; i++)
            {       
             Console.WriteLine(clothes[i]);
            }
        }
    }

    

}
    
  


