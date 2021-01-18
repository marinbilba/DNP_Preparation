using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeWebService.Repository;

namespace EmployeeWebService.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> FilterEmployeesBasedOnOvertime(bool hasOvertime)
        {
            List<Employee> employees = await _employeeRepository.GetAllEmpl();
            List<Employee> tempEmployees = new List<Employee>();
            foreach (var emp in employees)
            {
                switch (hasOvertime)
                {
                    case true:
                        if (emp.HasOvertime())
                        {
                            tempEmployees.Add(emp);
                        }

                        break;
                    case false:
                        if (!emp.HasOvertime())
                        {
                            tempEmployees.Add(emp);
                        }

                        break;
                }
            }

            return tempEmployees;
        }

        public async Task<double> GetTotalMonthlyExpense(bool hasOvertime)
        {
            List<Employee> employees = await _employeeRepository.GetAllEmpl();
            double total = 0;
            foreach (var emp in employees)
            {
                switch (hasOvertime)
                {
                    case true:
                        if (emp.HasOvertime())
                        {
                            total += emp.GetMonthlyPay();
                        }

                        break;
                    case false:
                        if (!emp.HasOvertime())
                        {
                            total += emp.GetMonthlyPay();
                        }

                        break;
                }
            }

            return total;
        }
    }
}