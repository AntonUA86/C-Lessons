using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using World;

namespace Lesson
{
    class Program
    {
     /*   1. Создайте атрибут…При его использовании необходимо передавать два позиционный и
три именованных параметров(например версия(version) и дата релиза(release))….Далее с
помощью механизма рефлексии необходимо вывести метаданные этих атрибутов а также
отобразить список классов version = 7.01 или у которых дата релиза с начала ноября 2019
года.*/

        static void Main(string[] args)
        {
            Type Bucha = Type.GetType("World.Bucha", true, true);
            Type Kyiv = Type.GetType("World.Kyiv", true, true);
            Type attributess = Type.GetType("World.CityAttribute", true, true);
            
            object[] anyTypeName = { Bucha.GetCustomAttributes() ,  Kyiv.GetCustomAttributes() };
           
            var ActivatorBucha = Activator.CreateInstance(Bucha, "UA","Bucha", 12300);
            var ActivatorKyiv = Activator.CreateInstance(Kyiv, "UA","Kyiv", 5000000);
  
            
            MethodInfo methodPopulationBucha = Bucha.GetMethod("GetPopulation");
            MethodInfo methodPopulationKyiv = Kyiv.GetMethod("GetPopulation");


            Type[] type = { typeof(Bucha), typeof(Kyiv) };
            for (int i = 0; i < type.Length; i++)
            {
              var currentAtr =  type[i].GetCustomAttributes(false);
                foreach (CityAttribute attribute in currentAtr)
                {
                    Console.WriteLine($"Город: {attribute.Name} Дата: {attribute.Date}\n Версия: {attribute.Version} Релиз: {attribute.Release}  Система: {attribute.System}");

                    if (attribute.Version > 7)
                        Console.WriteLine($"Города с версией больше 7 {attribute.Name}");
                }
             
            }

          



            Console.WriteLine(methodPopulationBucha.Invoke(ActivatorBucha, null));
            Console.WriteLine(methodPopulationKyiv.Invoke(ActivatorKyiv, null));
            
            Console.ReadLine();

            


        }

  
    }

}
