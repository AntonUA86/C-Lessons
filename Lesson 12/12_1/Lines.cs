using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    static class Lines
    {
    

        public static bool VerticalLeft(int size ,int column, int row )
        {
            if (column == 0)
                return true;
            return false;

        }
        public static bool VerticalRight(int size, int column, int row)
        {
            if (column == size - 1)
                return true;
            return false;
        }
        public static bool HorizontalTop(int size, int column, int row)
        {
            if (row == 0)
                return true;
            return false;
        }
        public static bool HorizontalBottom(int size, int column, int row)
        {
            if (row == (size - 1))
                return true;
            return false;
        }
        public static bool Slash(int size, int column, int row)
        {
            if (column == size - row - 1)
                return true;
            return false;
        }
        public static bool DiagonalRow(int size, int column, int row)
        {
            if (column == row)
                return true;
            return false;
        }
    }
}
