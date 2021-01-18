using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeWebService.Service;

namespace EmployeeWebService.Repository
{
    public interface IEmployeeRepository
    {
        Task AddEmp(Employee employee);

        Task<List<Employee>> GetAllEmpl();
    }
}