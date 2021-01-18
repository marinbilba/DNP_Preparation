using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeWebService.Service
{
    public interface IEmployeeService
    {
          Task<List<Employee>> FilterEmployeesBasedOnOvertime( bool hasOvertime);
         Task<double> GetTotalMonthlyExpense(bool hasOvertime);
    }
}