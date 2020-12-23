using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    abstract class  Animals
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Animals(string name)
        {
            Name = name;
        }

        public abstract void Sing();
    }
}
