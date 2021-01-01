using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Abramovich
    {
        public event Corporate eventCorporate;
        protected int cash = 9999999;

        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
            }

        }

        public void Party(ref Abramovich abram)
        {
            eventCorporate(ref abram);

        }

        public void buyFood(ref Abramovich abram) => abram.Cash -= 10000;

    }



}
