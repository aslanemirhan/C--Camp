using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitPrice = 10;

            Console.WriteLine(product1.ProductName);
            Console.WriteLine("------------------");

            Product product2 = new Product() { Id=2, CategoryId = 1, ProductName = "Camera", UnitPrice = 2100, UnitInStock = 2};
            Console.WriteLine(product2.ProductName);
            Console.WriteLine("------------------");

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Delete(product2);
            Console.WriteLine("------------------");

            productManager.Topla2(3,6);
            Console.WriteLine("------------------");

            int totalResult = productManager.Topla(3,2);
            Console.WriteLine(totalResult * 0.21);
            Console.WriteLine("------------------");


        }
    }
}
