using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    /* Создайте структуру описывающую точку в трехмерной системе координат.Организуйте
 возможность сложения, умножения, сравнение на больше и меньше и еще на равно и на не
 равно двух точек в трехмерной системе, через использование перегрузки оператора +, *,<, >
 и т.д...*/

    class Program
    {
        static void Main(string[] args)
        {
            Point OnePoint = new Point(10, 11, 10);
            Point TwoPoint = new Point(10, 11, 11);

            Point result = OnePoint + TwoPoint;
            Point result2 = OnePoint - TwoPoint;
            Point result3 = OnePoint / TwoPoint;
            Point result4 = OnePoint * TwoPoint;
            bool result5 = OnePoint < TwoPoint;
            bool result6 = OnePoint > TwoPoint;
            bool result7 = OnePoint <= TwoPoint;
            bool result8 = OnePoint >= TwoPoint;
            bool result9 = OnePoint == TwoPoint;
            bool result10 = OnePoint != TwoPoint;
            bool result11 = Equals(OnePoint, TwoPoint);


            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.ReadLine();
        }

        public struct Point
        {
            public int x, y, z;

            public Point(int posX, int posY, int posZ)
            {
                this.x = posX;
                this.y = posY;
                this.z = posZ;
            }
            public static Point operator +(Point FirstPoint, Point SecondPoint)
            {
                return new Point { x = FirstPoint.x + SecondPoint.x, y = FirstPoint.y + SecondPoint.y, z = FirstPoint.z + SecondPoint.z };
            }

            public static Point operator -(Point FirstPoint, Point SecondPoint)
            {
                return new Point { x = FirstPoint.x - SecondPoint.x, y = FirstPoint.y - SecondPoint.y, z = FirstPoint.z - SecondPoint.z };
            }

            public static Point operator *(Point FirstPoint, Point SecondPoint)
            {
                return new Point { x = FirstPoint.x * SecondPoint.x, y = FirstPoint.y * SecondPoint.y, z = FirstPoint.z * SecondPoint.z };
            }

            public static Point operator /(Point FirstPoint, Point SecondPoint)
            {
                return new Point { x = FirstPoint.x / SecondPoint.x, y = FirstPoint.y / SecondPoint.y, z = FirstPoint.z / SecondPoint.z };
            }

            public static bool operator <(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x < SecondPoint.x) || (FirstPoint.y < SecondPoint.y) || (FirstPoint.z < SecondPoint.z))
                    return true;
                return false;
            }
            public static bool operator >(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x > SecondPoint.x) || (FirstPoint.y > SecondPoint.y) || (FirstPoint.z > SecondPoint.z))
                    return true;
                return false;
            }

            public static bool operator <=(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x <= SecondPoint.x) && (FirstPoint.y <= SecondPoint.y) && (FirstPoint.z <= SecondPoint.z))
                    return true;
                return false;
            }

            public static bool operator >=(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x >= SecondPoint.x) && (FirstPoint.y >= SecondPoint.y) && (FirstPoint.z >= SecondPoint.z))
                    return true;
                return false;
            }

            public static bool operator ==(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x == SecondPoint.x) && (FirstPoint.y == SecondPoint.y) && (FirstPoint.z == SecondPoint.z))
                    return true;
                return false;
            }

            public static bool operator !=(Point FirstPoint, Point SecondPoint)
            {
                if ((FirstPoint.x != SecondPoint.x) && (FirstPoint.y != SecondPoint.y) && (FirstPoint.z != SecondPoint.z))
                    return true;
                return false;
            }



            public override string ToString()
            {
                return $"Координата X :{this.x} Координата Y:{this.y} Координата Z:{this.z}";
            }

        }
    }
}



