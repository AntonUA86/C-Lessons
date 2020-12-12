using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ProfessorX : SuperHero
    {
        public  ProfessorX()
        {
            Name = "ProfessorX";
            Energe = 100;
            Health = 100;
            Сharacter = true;
        }
        public void  timeToSay()
        {
            if (Health < 80)
                professorSay();
        }
        public void professorSay()
        {
            string[] aristotlePhrases = new string[5];
            
            aristotlePhrases[0] = "Мы работаем, чтобы иметь свободное время, и воюем, чтобы жить мирно.";
            aristotlePhrases[1] = "Два года человек учится говорить, а потом всю оставшуюся жизнь — молчать.";
            aristotlePhrases[2] = "Не было еще ни одного великого ума без примеси безумства.";
            aristotlePhrases[3] = "Корни образования горькие, но плоды сладкие.";
            aristotlePhrases[4] = "Ясность — главное достоинство речи.";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} {aristotlePhrases[random(5)]}");
            Console.ResetColor();
        }



    }
}
