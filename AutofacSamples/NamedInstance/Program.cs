using System;
using System.Linq;
using Autofac;

namespace NamedInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Customer>().Named<Customer>("FirstCustomer");

            var container = builder.Build();
            var firstCustomer = container.ResolveNamed<Customer>("FirstCustomer");
            firstCustomer.CustomerId = 1;
            firstCustomer.FirstName = "Jalpesh";
            firstCustomer.LastName="Vadgama";
            firstCustomer.City ="Ahmedabad";
           
        }

        static void PrintCustomer(Customer customer)
        {
            Console.WriteLine("Printing Customer");
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.City);
        }
    }
}
