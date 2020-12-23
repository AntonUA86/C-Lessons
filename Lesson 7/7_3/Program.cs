using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree 
{
    /*Есть абстрактный класс фигура...Он имеет поле “тип фигуры”, конструктор который
принимает тип фигуры и абстрактный метод “Вычислить площадь фигуры”....Есть
наследники(классы прямоугольник и круг)...у прямоугольника есть поля- высота и ширина
а у круга есть радиус...Еще они переопределяют метод “Вычислить площадь фигуры”....*/
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 360);
            Rectangle rectangle  = new Rectangle("rectangle", 300,400);

            Console.WriteLine(circle.calculateArea());
            Console.WriteLine(rectangle.calculateArea());
            Console.ReadKey();
        }
    }
}