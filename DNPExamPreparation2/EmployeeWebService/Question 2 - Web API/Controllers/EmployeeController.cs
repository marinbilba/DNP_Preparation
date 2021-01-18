using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using EmployeeWebService.Repository;
using EmployeeWebService.Service;
using Microsoft.AspNetCore.Mvc;
using Employee = EmployeeWebService.Service.Employee;

namespace EmployeeWebService.Controllers
{    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeService employeeService, IEmployeeRepository employeeRepository)
        {
            this.employeeService = employeeService;
            this._employeeRepository = employeeRepository;

        }
        
        [HttpGet]
        [Route("/allEmployees")]
        public async Task<ActionResult<IList<Employee>>> GetAllEmployeesAsync([FromQuery] bool hasOvertime)
        {
            try
            {
                IList<Employee> filterEmployees=await _employeeRepository.GetAllEmpl();
                var json = JsonSerializer.Serialize(filterEmployees);
                return Ok(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet]
        [Route("/employees")]
        public async Task<ActionResult<IList<Employee>>> GetFilterEmployeesBasedOnOvertimeAsync([FromQuery] bool hasOvertime)
        {
            try
            {
                var filterEmployees = await employeeService.FilterEmployeesBasedOnOvertime(hasOvertime);
                var json = JsonSerializer.Serialize(filterEmployees);
                return Ok(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost]
        [Route("/employees")]
        public async Task PostEmplAsync([FromBody] Employee employee)
        {
            await _employeeRepository.AddEmp(employee);
        }
        [HttpGet]
        [Route("/payments")]
        public async Task<ActionResult<IList<Employee>>> GetPayments(bool hasOvertime){
            try
            {
                var expenses = await employeeService.GetTotalMonthlyExpense( hasOvertime);
                var json = JsonSerializer.Serialize(expenses);
                return Ok(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}