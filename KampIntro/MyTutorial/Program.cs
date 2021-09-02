using System;
using System.Collections.Generic;

namespace MyTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Add( new List<ICustomerDal> { new OracleCustomerDal(), new SqlServiceCustomerDal()});
            
            
            
            
        }
    }
}
