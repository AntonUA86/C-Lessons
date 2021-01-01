using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Есть класс дом…..В классе ДОМ описать событие:
 ‘случился пожар’ и навесить обработчик на класс ‘Пожарное отделени’е метод
приезда пожарная машина…
 ‘День рождение’ и навесить обработчик, на класс ‘Друг’ , который на этом
событии должен вызывать метод громко играет музыка и ‘Хихикает’….
 Событие ‘Приехала мама’ – навесить обработчик, в котором класс Мама
вызывает метод и спрашивает кто эта девочка …. */

namespace Lesson_4
{
   public delegate void actionHome(); 
    
    class Program
    {
        
        static void Main(string[] args)
        {
          
            Home home = new Home();
            FireDepartment fireDepartment = new FireDepartment();
            Friend friend = new Friend();
            Mom mom = new Mom();

            
            home.action += fireDepartment.fireTruck;
            home.action += friend.loudMusicPlaying;
            home.action += mom.momSay;

            home.Party();


            Console.Read();

        

    }
    }
}
