using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Phone", 1876, "Stationary");
            RadioPhone radioPhone = new RadioPhone("RadioTelefon", 1957, "Radio",  true);
            ScreenPhone screenPhone = new ScreenPhone("Nokia  ", 1987, "NMT ", true, true, "monochrome");
            Smartphone smartphone = new Smartphone("Motorola C350", 2003, "GSM 900/1800 ", true, true, "colour screen");
            radioPhone.call();
            Console.ReadLine();
            
        }

        
    }
}

