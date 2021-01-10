using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
   public delegate void Key();
   public delegate bool Predicate(Key predicate);


    class Program
    {
        /* 2.  Задача по построению букв О,X.N,Z…….Надо написать одну, универсальную
             функцию которая принимает массив делегатов и размер буквы(размер прямоугольника, в который будет вписана буква)
             и рисует букву….Ну и описать функции-предикаты, которые будут сообщены с делегатами….
             Одна функция для одной из линий, которые и формируют букву…Функция возвращает*/
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();



            Key[] delegates = new Key[]
            {
                CreateLetter.slash, CreateLetter.horizontel, CreateLetter.zero, CreateLetter.vertical
            };
            Predicate<Key> predicate = isDelegates;
            bool isDelegates(Key predicate)
            {
                foreach (Key item in delegates)
                {
                    if (item != null)
                    {
                        return true;
                    }
                }

            }





            keyboard.start(delegates);

        }

            
     }
}
        

