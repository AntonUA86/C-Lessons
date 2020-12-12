using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*1.Дан массив товаров(Товар это класс)….Дан массив покупателей (Покупатель это
класс)…Каждый покупатель просссматривает массив товаров и ложит себе в корзину товар
на который хватает денег…(и конечно у покупателя денежка уменьшается)…В конце
вывести инофрмацию о каждом покупателе…на какую сумму скупился и что купил.*/
    class Client
    {

        public string name;
        private int money;
        private string basket;

        public Client() { }

        public void buy(Product[] products, Client[] clients)
        {
            foreach(Product product in products)
            {
                foreach (Client person in clients)
                {
                    if (person.Money > product.Cost)
                    {
                        person.Basket = product.Model;
                        person.Money -= product.Cost;
                    }
                        
                }
            }
        }
       
        public void PrintClients(Client[] clients)
        {
            foreach(Client person in clients)
            {
                Console.WriteLine($"Имя : {person.Name} Кол-во денег: {person.Money} Корзина :{person.Basket}");
            }
        }


        public Client(string name,int money, string basket)
        {
            this.Name = name;
            this.Money = money;
            this.Basket = basket;
        }
        

        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

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

        public string Basket
        {
            get
            {
                return basket;
            }
            set
            {
                basket = value;
            }
        }

        
    }
    class Clients 
    {
        
        public Client[] clients ={
            new Client{Name = "Anton" ,  Money = 20000, Basket = "" },
            new Client{Name = "Olha" ,   Money = 41550, Basket = ""},
            new Client{Name = "Emma" ,   Money = 21550, Basket = ""},
            new Client{Name = "Igor",    Money = 31550,  Basket = ""}
        };

        

};
            

    }


