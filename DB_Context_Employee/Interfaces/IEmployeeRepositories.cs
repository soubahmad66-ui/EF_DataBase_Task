using DB_Context_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Interfaces
{
    public interface IEmployeeRepositories 
    {
         int  AddEmployee(Employee employee);
        List<Employee> GetAllEmployee();

        Employee? GetEmployeeById(int id);

        List<Employee> GetEmployeesBySalary(decimal salary); 
        bool UpdateEmployee(Employee employee);

        bool DeleteEmployee(int id);
    }
}
