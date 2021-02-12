using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void GetList(Customer customer)
        {
            Console.WriteLine("Müşteri " + customer.CustomerName);
        }
    }
}
