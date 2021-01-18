using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeWebService.Service;

namespace EmployeeWeb.Data
{
    public interface IEmployeeService
    {
        Task AddEmp(Employee employee);

        Task<List<Employee>> GetAllEmpl();

        Task<double> GetPayments(bool hasOvertime);

        Task<IList<Employee>> GetFilterEmployeesBasedOnOvertimeAsync(bool hasOvertime);
    }
}