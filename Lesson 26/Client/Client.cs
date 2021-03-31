using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{

  

    class Client
    {
        static void Main(string[] args)
        {
        
            Console.Title = "CLIENT";

            Uri addressSum = new Uri("http://localhost:10/IContract");
            Uri addressReceipt = new Uri("http://localhost:20/IContract");

            BasicHttpBinding binding = new BasicHttpBinding();
      

      
            ChannelFactory<IContract> MethodSum = new ChannelFactory<IContract>(binding, new EndpointAddress(addressSum));
            ChannelFactory<IContract> MethodReceipt = new ChannelFactory<IContract>(binding, new EndpointAddress(addressReceipt));

            IContract ChannelSum = MethodSum.CreateChannel();
            IContract ChannelReceipt = MethodReceipt.CreateChannel();



            int responseSum = ChannelSum.Sum(new Product(3), new Product(3));
            int responseReceipt = ChannelReceipt.Receipt(GetProducts());




            Console.WriteLine($"Сумма {responseSum}");
            Console.WriteLine($"Чек {responseReceipt}");


            Console.ReadKey();

        }

        static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1));
            products.Add(new Product(22));
            products.Add(new Product(3));
            return products;

        }
    }
}
