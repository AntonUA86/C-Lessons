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
вызывает метод и спрашивает кто эта девочка …. 
*/
namespace Lesson_4
{
   public class Home 
    {
        public event actionHome action;

        public void Party()
        {
            action();
        }

        public static void fire() => Console.WriteLine("Пожар");
        public void happyDay() => Console.WriteLine("День рождение ");
        public void momСame() => Console.WriteLine("Мама приехала ");






    }
}
