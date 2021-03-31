using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

     
            Console.WriteLine(calc.Sum(20, 20));

            IAsyncResult asyncResult = calc.BeginInvoke(32, 33, CallBack,calc);
  
            Console.ReadLine();
        }
        static void CallBack(IAsyncResult asyncResult)
        {
            // Получение экземпляра, с котором была связана асинхронная операция.
            Calc calculator = (Calc)asyncResult.AsyncState;

            // Получение результатов асинхронной операции.
            int sum = calculator.EndInvoke(asyncResult);
            Console.Write("{0}, " , sum);

        }
    }

    class Calc
    {
        int argOne;
        int argTwo;
        int sum;
        public int Sum(int argOne,int argTwo)
        {
            sum = argTwo + argOne;
            return sum;
        }

        public int Invoke(int argOne,int argTwo)
        {
            sum = Sum(argOne, argTwo);
            return sum;
        }

       

        public IAsyncResult BeginInvoke(int argOne,int argTwo, AsyncCallback callback, object @object)
        {
            Func<int, int,int> sum = new Func<int, int,int>(Sum);
            IAsyncResult asyncResult = sum.BeginInvoke(argOne, argTwo, callback, @object);
            return asyncResult;
        }

        public int EndInvoke(IAsyncResult result)
        {
            AsyncResult asyncResult = result as AsyncResult;
            Func<int, int, int> plus = asyncResult.AsyncDelegate as Func<int, int, int>;
            sum = plus.EndInvoke(result);

            return sum;
        }
     
    }

   
}
