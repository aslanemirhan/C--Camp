using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Asus";
            product1.ProductValue = 8900;

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Casper";
            product2.ProductValue = 9200;

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "HP";
            product3.ProductValue = 11000;

            Product[] products = new Product[] { product1, product2, product3};

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i].ProductName + " : " + products[i].ProductValue);
            //}

            Console.WriteLine("------------------FOR Döngüsü Sonu-----------------------");

            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductValue);

                i++;
            }

            Console.WriteLine("------------------WHİLE Döngüsü Sonu-----------------------");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductValue);
            }

            Console.WriteLine("------------------FOREACH Döngüsü Sonu-----------------------");



        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductValue { get; set; }
    }
}
