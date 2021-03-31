using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program : MarshalByRefObject
    {
        static void Main(string[] args)
        {




            AppDomain Domain = AppDomain.CreateDomain("Range");

            ObjectHandle handleAN225 = Domain.CreateInstance("Airbase", "Airbase.AN225");
            dynamic instanceAN225 = handleAN225.Unwrap();
            instanceAN225.Uptakeoff();

            ObjectHandle handleOplot = Domain.CreateInstance("Hangar", "Hangar.Oplot");
            dynamic instanceOplot = handleOplot.Unwrap();
            instanceOplot.Start();


            Console.ReadLine();

        }
    }
}
