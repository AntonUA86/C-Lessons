using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_3
{
   

    class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 5, 6, 7, 10, 2, 5, 6, 7, 444 };

            Func<int[], int> result = new Func<int[], int>(Average);


            IAsyncResult asyncResult = result.BeginInvoke(array, CallBack, "{0}");

            Console.Read();
        }

        static void CallBack(IAsyncResult asyncResult)
        {

            AsyncResult ar = asyncResult as AsyncResult;
            Func<int[], int> caller = (Func<int[], int>)ar.AsyncDelegate;


            int sum = caller.EndInvoke(asyncResult);

            string result = string.Format(asyncResult.AsyncState.ToString(), sum);
            Console.WriteLine("Результат асинхронной операции: " + result);
        }

        static int Average(int[] mas)
        {
            int summ = 0;
            int ave;
            for (int i = 0; i < mas.Length; i++)
                summ += mas[i];
            return ave = summ / mas.Length;

        }

    }
}
