using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Emirhan", "Emre", "Yunus", "Engin" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names = new string[5];
            //names[4] = "SONRADAN EKLENEN";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);



            List<string> names2 = new List<string> { "Emirhan", "Emre", "Yunus", "Engin" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            Console.WriteLine("----------------");

            names2.Add("Ahmet");
            Console.WriteLine(names2[4]);

        }
    }
}
