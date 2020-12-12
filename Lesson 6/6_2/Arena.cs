using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте 3 класса СуперГероев с соответствующими свойствами и методами…Все они
имеют имя, энергию и тип героя (хороший или плохой)…и еще…У первого героя есть
пистолет и он им может стрелять…при каждом выстреле, выводится “ПИФ-ПАФ” и
количество пулек уменьшается на одну……Не забудьте написать метод для зарядки
пистолета…) ..Второй герой –мудрец ….Когда его о чем то спросишь он говорит
очередную фразу из великих…Аристотеля, Эйнштейна, Дарвина… Ну а третий герой
девочка…она любит готовить всякие зелья и эликсиры, которые или дают энергию другим
персонажам или ее забирают, в зависимости хороший герой или нет…)….Задача, в общем
на вашу фантазию …)… И еще подумайте как сделать класс от которого будут
наследоваться , добавьте вашим классам конструкторы и свойства. */






namespace ConsoleApp5
{
    class Arena
    {
        static void Main(string[] args)
        {
            Deadpool deadpool = new Deadpool();
            ProfessorX professorX = new ProfessorX();
            SailorMoon sailorMoon = new SailorMoon();


            deadpool.shot(professorX);
            professorX.indicators();
            professorX.professorSay();
            sailorMoon.healing(professorX);
            deadpool.recoveryGun();
            deadpool.shot(sailorMoon);
            sailorMoon.indicators();
            sailorMoon.healing(deadpool);
            




            Console.ReadLine();
        }
    }
}
