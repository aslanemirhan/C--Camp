using System;

namespace ConstructorIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Customer customer2 = new Customer(2,"Emirhan","Aslan","Istanbul");
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Ali";
            Console.WriteLine(customer3.FirstName);

        }
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public Customer()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
