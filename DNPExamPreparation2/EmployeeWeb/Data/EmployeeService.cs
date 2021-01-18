using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using EmployeeWebService.Service;

namespace EmployeeWeb.Data
{
    
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient client;
        private readonly string uri = " https://localhost:5001";

        public EmployeeService()
        {
            client = new HttpClient();
        }

        public async Task AddEmp(Employee employee)
        {
            var childSerialized = JsonSerializer.Serialize(employee);
            var content = new StringContent(childSerialized, Encoding.UTF8, "application/json");
            await client.PostAsync(uri + "/employees", content);
        }

        public async Task<List<Employee>> GetAllEmpl()
        {
            var message = await client.GetStringAsync(uri + "/allEmployees");
            var result = JsonSerializer.Deserialize<List<Employee>>(message);
            return result;
        }

        public async Task<double> GetPayments(bool hasOvertime)
        {
            var uriBuilder = new UriBuilder($"{uri}/payments");

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["hasOvertime"] = hasOvertime.ToString();
            uriBuilder.Query = query.ToString();
            var longurl = uriBuilder.ToString();
            
            // 1. Send GET request

            var response = await client.GetStringAsync(longurl);
         
            return Convert.ToDouble(response);
        }

        public async Task<IList<Employee>> GetFilterEmployeesBasedOnOvertimeAsync(bool hasOvertime)
        {
            var uriBuilder = new UriBuilder($"{uri}/employees");

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["hasOvertime"] = hasOvertime.ToString();
            uriBuilder.Query = query.ToString();
            var longurl = uriBuilder.ToString();
            
            // 1. Send GET request

              var response = await client.GetStringAsync(longurl);
              var result = JsonSerializer.Deserialize<IList<Employee>>(response);
              return result;

        }
    }
}