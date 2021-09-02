using System;
using System.Collections.Generic;
using System.Text;

namespace MyTutorial
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServiceCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added with SQL");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added with Oracle.");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class CustomerManager
    {
        public void Add(List<ICustomerDal> customerDals)
        {
            foreach (var customer in customerDals)
            {
                customer.Add();
            }
        }
    }
}
