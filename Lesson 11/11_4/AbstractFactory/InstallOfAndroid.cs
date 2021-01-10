using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class InstallOfAndroid : Dowloand
    {
        public override Winamp installWinamp()
        {
            return new Winamp(); 
        }
        public override Telegram installTelegram()
        {
            return new Telegram();
        }

    }
}
