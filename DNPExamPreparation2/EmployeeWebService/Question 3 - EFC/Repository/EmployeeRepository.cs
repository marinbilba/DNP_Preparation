using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebService.DataContext;
using EmployeeWebService.Service;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebService.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeesContext ctx;

        public EmployeeRepository()
        {
            ctx=new EmployeesContext();
            
        }

        public async Task AddEmp(Employee employee)
        {
            await ctx.Employees.AddAsync(employee);
            ctx.Entry(employee).State = EntityState.Added;
            await ctx.SaveChangesAsync();
        
        }

        public async Task<List<Employee>> GetAllEmpl()
        {
            return ctx.Employees.ToList();
        }
    }
}