using ConstructorInjection.Model;
using ConstructorInjection.Repository;

namespace ConstructorInjection.Service
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeerRepository)
        {
            _employeeRepository = employeerRepository;
        }

        public void Print(Employee employee)
        {
            _employeeRepository.Print(employee);
        }
    }
}
