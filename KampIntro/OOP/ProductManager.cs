using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine( product.ProductName + " added.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " deleted.");
        }

        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }
        public void Topla2(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
