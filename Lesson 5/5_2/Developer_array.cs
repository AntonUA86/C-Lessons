using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    /*2. Класс Developer_array...У него есть методы: добавить в начало, добавить в
конец,добавить по указанному индексу....и метод который возвращает есть
ли в массиве элемент с таким значением*/
    class Developer_array
    {
       

        public void addToStart(ref int[] array, int num)
        {
            Array.Resize(ref array, array.Length +1);

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }


            array[0] = num;
        }
        public void addToEnd(ref int[] array, int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length -1] = num;

        }

        public void addToIndex(ref int[] array,int addNum,int index)
        {
       
            int[] newArray = new int[array.Length +1];
            newArray[index] = addNum;
            for (int i = 0 ; i < index; i++)
                newArray[i] = array[i];
            for (int i = index ; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;
        } 

        public bool searchElement(int[] array, int element)
        { 
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num = array[i];
                if (num == element)
                    return true;
            }
            return false ;
        }
    }
}