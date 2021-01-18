using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeWebService.Service
{
    public class Employee
    {
     
        [JsonPropertyName("Id")]   public long Id { get; set; }
        [JsonPropertyName("Name")]  public String Name { get; set; }
        [JsonPropertyName("HourlyWage")]   public double HourlyWage { get; set; }
        [JsonPropertyName("HoursPerMonth")]  public double HoursPerMonth { get; set; }
       
        public double GetMonthlyPay()
        {
            if (HasOvertime())
            {
                var overtime = HoursPerMonth - 150;
                var increasedHourlyWage = HourlyWage * 1.5;
                var overtimeMoney = overtime * increasedHourlyWage;
                return overtimeMoney + ((HoursPerMonth - overtime) * HourlyWage);
            }
            return HourlyWage * HoursPerMonth;
        }

        public bool HasOvertime()
        {
            return HoursPerMonth > 150;
        }
    }
}