using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.CustomerId = 1;
            customer.CitizenId = "12345678901";
            customer.CustomerName = "Engin";
            customer.CustomerSurname = "Demiroğ";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.GetList(customer);

        }
    }
}
