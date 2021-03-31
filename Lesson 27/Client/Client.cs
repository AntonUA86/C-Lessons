using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{

  

    class Client
    {
        static IServiceContractDuplex proxy;
        static void Main(string[] args)
        {
        
            Console.Title = "CLIENT";

            InstanceContext context = new InstanceContext(new CallbackHandler());

    
            DuplexChannelFactory<IServiceContractDuplex> factory =
              new DuplexChannelFactory<IServiceContractDuplex>(context, new NetTcpBinding(),
                  "net.tcp://localhost:9000/Service");

            proxy = factory.CreateChannel();
            Console.WriteLine("Нажмите Enter для вызова метода на сервере.");
            Console.ReadKey();


            PrintNum();



            Console.ReadKey();

        }

      static void PrintNum()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Клиент работает {i}");
                if (i == 2)
                {
                    proxy.ServiceFactorial();
                }
                Thread.Sleep(3000);
            }
        }
    }
}
