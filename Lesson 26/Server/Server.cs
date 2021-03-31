using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";


            

            using (ServiceHost host = new ServiceHost(typeof(Service)))
            {

                Uri addressSum = new Uri("http://localhost:10/IContract");
                Uri addressReceipt = new Uri("http://localhost:20/IContract");

                BasicHttpBinding binding = new BasicHttpBinding();
                Type contract = typeof(IContract);
                host.AddServiceEndpoint(contract, binding, addressSum);
                host.AddServiceEndpoint(contract, binding, addressReceipt);

                host.Opened += Host_Opened;
                host.Open();
               
                Console.WriteLine();
             
                Console.ReadKey();
                host.Close();
            }



            void Host_Opened(object sender, EventArgs e)
            {
                Console.WriteLine("Сервер работает");
            }





        }
    }
}
