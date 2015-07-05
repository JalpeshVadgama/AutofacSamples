using System;
using Autofac;

namespace KeyedRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var containerBuilder = new ContainerBuilder();
            Customer keyCustomer = new Customer();
            containerBuilder.RegisterType<Customer>().Keyed<Customer>(keyCustomer);
            var container = containerBuilder.Build();

            var customer = container.ResolveKeyed<Customer>(keyCustomer);
            customer.CustomerId = 1;
            customer.FirstName = "Jalpesh";
            customer.LastName="Vadgama";
            customer.City ="Ahmedabad";

            PrintCustomer(customer);

        }
        static void PrintCustomer(Customer customer)
        {
            Console.WriteLine("Printing Customer");
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.City);
        }
    }
}
