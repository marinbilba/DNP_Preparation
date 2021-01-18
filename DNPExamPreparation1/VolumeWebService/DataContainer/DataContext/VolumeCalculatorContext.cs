using Microsoft.EntityFrameworkCore;

namespace WebApplicationTEST.DataContainer.DataContext
{
    public class VolumeCalculatorContext :DbContext
    {
        public DbSet<VolumeResult> VolumeResults { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWebService\VolumeDatabase.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VolumeResult>().HasKey(x => x.Id);
        }
    }
}