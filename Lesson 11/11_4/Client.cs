using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Client
    {
        static void Main(string[] args)
        {
            Dowloand DowloandOfAndroid = new InstallOfAndroid();
            Dowloand DowloandOfWindows = new InstallOfWindows();

             

            DowloandOfAndroid.installTelegram().text();
            DowloandOfWindows.installWinamp().sound();


            Console.Read();
        }
    }
}
