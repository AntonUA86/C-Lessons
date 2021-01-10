using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
   sealed  class Winamp : iMediaPlayer
    {
        public void name() => Console.WriteLine("Winamp");
        public void sound() => Console.WriteLine("Бац-Бац-Бац");
    }
}
