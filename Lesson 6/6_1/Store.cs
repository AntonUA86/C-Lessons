using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1.Дан массив товаров(Товар это класс)….Дан массив покупателей (Покупатель это
класс)…Каждый покупатель просссматривает массив товаров и ложит себе в корзину товар
на который хватает денег…(и конечно у покупателя денежка уменьшается)…В конце
вывести инофрмацию о каждом покупателе…на какую сумму скупился и что купил.*/
namespace ConsoleApp1
{
    class Store 
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            Clients clients = new Clients();
            Product product = new Product();
            Products products = new Products();
        
            client.PrintClients(clients.clients);
            product.PrintPorducts(products.products);
           
            client.buy(products.products, clients.clients);
            client.PrintClients(clients.clients);




            Console.ReadLine();
        }
     
    }
}