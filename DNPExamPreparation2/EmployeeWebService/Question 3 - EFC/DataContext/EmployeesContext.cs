using EmployeeWebService.Service;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebService.DataContext
{
    public class EmployeesContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation2\EmployeeWebService\Employees.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
        }
    }
}