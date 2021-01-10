using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
   sealed class Telegram : iMessenger
    {
        public void name() => Console.WriteLine("Telegram");
        public void text() => Console.WriteLine("С наступающим всех! :)");
    }
}
