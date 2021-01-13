using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            NoteBook<IntelCore3, DDR3 , WiFiVersion2, BlueToothVersion2> noteBook = new NoteBook<IntelCore3, DDR3, WiFiVersion2, BlueToothVersion2>();

            iUpgradeNoteBook<IntelCore5, DDR4> upgradeNoteBook = noteBook;
            upgradeNoteBook.addProcessor(new IntelCore7());
            upgradeNoteBook.addRAM(new DDR5());


            iDataTransmission<WiFi, BlueTooth> lowNoteboke = noteBook;

            lowNoteboke.TransmissionWiFi();
            lowNoteboke.ToString();

            
            Console.Read();

        }
    }

    class NoteBook<Processor,RAM, WiFi, BlueTooth> : iUpgradeNoteBook<Processor, RAM> , iDataTransmission<WiFi, BlueTooth>
    {
        private RAM ddr { get; set; }
        private Processor proc { get; set; }

        private WiFi wiFi { get; set; }
        private BlueTooth blueTooth { get; set; }



        public void addProcessor(Processor processor)
        {
            proc = processor;
        }
        public void addRAM(RAM ram)
        {
            ddr = ram;
        }

  
        public WiFi TransmissionWiFi()
        {
            return wiFi;
        }

        public BlueTooth TransmissionBlueTooth()
        {
            return blueTooth;
        }
    }

    interface iDataTransmission<out WiFi,out BlueTooth>
    {
        WiFi TransmissionWiFi();
        BlueTooth TransmissionBlueTooth();
    }

    interface iUpgradeNoteBook<in Processor, in RAM>
    {
        void addProcessor(Processor processor);
        void addRAM(RAM ram);
    }

    class DDR3 { };
    class DDR4 : DDR3 { };
    class DDR5 : DDR4 { };

    class IntelCore3 { };
    class IntelCore5 : IntelCore3 { };
    class IntelCore7 : IntelCore5 { };

    class WiFi{ };
    class WiFiVersion2: WiFi { };
    


    class BlueTooth { };
    class BlueToothVersion2 : BlueTooth { };
   


}
