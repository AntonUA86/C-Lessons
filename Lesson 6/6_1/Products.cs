using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product
    {
       
        protected string model;
        protected int cost;
        protected int maxCost;

        public void print()
        {
            Console.WriteLine($"Model = {Model}   Cost = {Cost}");
        }
   



        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int MaxCost
        {
            get { return maxCost; }
            set { maxCost = value; }
        }
        public Product(string model, int cost)
        {
            
            this.Model = model;
            this.Cost = cost;
        }

        public Product() {}

        public void PrintPorducts(Product[] products)
        {
            foreach(Product product in products)
            {
                Console.WriteLine($" Model : {product.Model} Cost :   {product.Cost}");
            }
        }
        
        public int maxCostProduct(Product[] products)
        {
            foreach(Product product in products)
            {
           
                if (MaxCost < product.Cost)
                    MaxCost = product.Cost;
            }
            return maxCost;
        }

        


    }
    class Products
    {
        public Product[] products =
         {
            new Product {Model = "Acer Aspire 5 A515-55G", Cost = 19999},
            new Product {Model = "Asus ROG Strix G15", Cost = 37999},
            new Product {Model = "HP Notebook 15s", Cost = 18499},
            new Product {Model = "Lenovo IdeaPad L3", Cost = 16999},
            new Product {Model = "HP Pavilion Notebook 15-cw", Cost = 19499},
            new Product {Model = "MSI Modern 14 B4MW", Cost = 17999}
        };

        
        

    }
}
