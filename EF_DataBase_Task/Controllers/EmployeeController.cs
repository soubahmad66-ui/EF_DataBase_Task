using DB_Context_Employee.Interfaces;
using DB_Context_Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_DataBase_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepositories _employeeRepositories;

        public EmployeeController(IEmployeeRepositories employeeRepositories)
        {
            _employeeRepositories = employeeRepositories;
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            int result = _employeeRepositories.AddEmployee(employee);
            if(result > 0)
            {
                return Ok(" Employee Added Successfully ");
            }
            else
            {
                return BadRequest(" Faild To Employee ");
            }
        }

        [HttpGet("GetAllEmployee")]
        public IActionResult  GetAllEmployee()
        {
            List<Employee> employees = _employeeRepositories.GetAllEmployee();
            return Ok(employees);
        }

        [HttpGet("GetEmployeesBySalary/{salary}")]
        public IActionResult GetEmployeeBySalary(decimal salary)
        {
            List<Employee> employees = _employeeRepositories.GetEmployeesBySalary(salary).ToList();
            return Ok(employees);
        }

        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee? employee =_employeeRepositories.GetEmployeeById(id);
            if (employee == null)
                return NotFound(" Employee Not Found ");
            return Ok(employee);
        }
        [HttpPut("Update")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            bool result = _employeeRepositories.UpdateEmployee(employee);
            if (result)
                return Ok(" Employee Successful Updated ");
            else 
                return BadRequest(" Faild To Update Employee ");

        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {

            bool result = _employeeRepositories.DeleteEmployee(id);
            if (result)
                return Ok(" Employee Successful Deleted ");
            else
                return BadRequest(" Faild To Delete Employee ");
        }
    }


}

 
