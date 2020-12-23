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
   abstract class Figure
    {
        string typeFigure { get; set; }

        public Figure(string typeFigure)
        {
            this.typeFigure = typeFigure;
        }
        public abstract double calculateArea();
      


    }

    class Circle : Figure
    {

        double radius { get; set; }
        public  Circle(string typeFigure,double radius) 
            :base(typeFigure)
        {
            this.radius = radius;
        }
        public override double calculateArea()
        {
            return 2 * Math.PI * radius;
        }
      
    }
    class Rectangle : Figure
    {
        int width;
        int height;

        public Rectangle(string typeFigure,int width, int height)
            : base(typeFigure) 
        {
            this.width = width;
            this.height = height;
        }

        public override double calculateArea()
        {
            return width * height;
        }
    }
}
