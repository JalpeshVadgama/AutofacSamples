using Autofac;
using System;
namespace Ordering
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama"
            };

            Employee secondEmployee = new Employee
            {
                EmployeeId = 2,
                FirstName = "Vishal",
                LastName = "Vadgama"
            };

            Console.WriteLine("Default Behaviour");
            DefaultBehaviour(firstEmployee, secondEmployee);

            Console.WriteLine("\n\nAnother Behaviour");
            AnotherBehaviour(firstEmployee, secondEmployee);

        }

        static void DefaultBehaviour(Employee firstEmployee, Employee secondEmployee)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance<Employee>(firstEmployee);
            builder.RegisterInstance<Employee>(secondEmployee);

            var container = builder.Build();
            var employee = container.Resolve<Employee>();

            PrintEmployee(employee);

        }

        static void AnotherBehaviour(Employee firstEmployee, Employee secondEmployee)
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance<Employee>(firstEmployee);
            builder.RegisterInstance<Employee>(secondEmployee).PreserveExistingDefaults();

            var container = builder.Build();
            var employee = container.Resolve<Employee>();

            PrintEmployee(employee);
        }

        static void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Print Employee");
            Console.WriteLine(string.Format("Id :{0}", employee.EmployeeId));
            Console.WriteLine(string.Format("First Name :{0}", employee.FirstName));
            Console.WriteLine(string.Format("Last Name :{0}", employee.EmployeeId));

        }

    }
}
