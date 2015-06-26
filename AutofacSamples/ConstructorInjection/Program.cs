using Autofac;
using ConstructorInjection.Model;
using ConstructorInjection.Repository;
using ConstructorInjection.Service;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var employeeService = container.Resolve<EmployeeService>();
            Employee employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama",
                Designation = "Technical Architect"
            };
            employeeService.Print(employee);

        }
        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<EmployeeService>();
            return builder.Build();
        }
    }
}
