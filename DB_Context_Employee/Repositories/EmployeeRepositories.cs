using DB_Context_Employee.Interfaces;
using DB_Context_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        private readonly App_DBContext_employee _app_DBContext_employee;


        public EmployeeRepositories(App_DBContext_employee app_DBContext_employee)
        {
            _app_DBContext_employee = app_DBContext_employee;
        }

        public int AddEmployee(Employee employee)
        {
            _app_DBContext_employee.Employee.Add(employee);
            return _app_DBContext_employee.SaveChanges();
        }
        public List<Employee> GetAllEmployee()
        {
            return _app_DBContext_employee.Employee.ToList();
        }

        public Employee? GetEmployeeById(int id)
        {
            return _app_DBContext_employee.Employee.FirstOrDefault(s => s.EmployeeId == id);
        }

        public List<Employee> GetEmployeeBySalary(decimal salary)
        {
            return _app_DBContext_employee.Employee.Where(s => s.Salary > salary).ToList();
        }

        public List<Employee> GetEmployeesBySalary(decimal salary)
        {
            return _app_DBContext_employee.Employee
                .Where(s => s.Salary > salary)
                .ToList();
        }
        public bool UpdateEmployee(Employee employee) 
        {
          Employee? existingEmployee = _app_DBContext_employee.Employee.FirstOrDefault(s => s.EmployeeId == employee.EmployeeId);

            if (existingEmployee == null) 
                return false;

            existingEmployee.Name = employee.Name;
            existingEmployee.IdNationalNumber = employee.IdNationalNumber;
            existingEmployee.TheJob = employee.TheJob;
            existingEmployee.EmployeeId = employee.EmployeeId;
            existingEmployee.email = employee.email;
             _app_DBContext_employee.SaveChanges();

            return true;
        }
        public bool DeleteEmployee(int id)
        {
            Employee? existingEmployee = _app_DBContext_employee.Employee.FirstOrDefault(s => s.EmployeeId == id);

            if (existingEmployee == null)
                return false;

            _app_DBContext_employee.Employee.Remove(existingEmployee);
            _app_DBContext_employee.SaveChanges();
            return true;
        }
    }
}
