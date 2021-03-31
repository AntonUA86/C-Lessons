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
            ServiceHost host = new ServiceHost(typeof(Service));



            host.AddServiceEndpoint(typeof(IServiceContractDuplex), new NetTcpBinding(),
            "net.tcp://localhost:9000/Service");
            IServiceContractDuplex serviceContractDuplex = new Service();
           
         
            host.Open();

            Console.WriteLine("Нажмите Enter для вызова метода на клиенте.");
            Console.ReadKey();


            Console.ReadKey();
            host.Close();
        }
       
    }
}
