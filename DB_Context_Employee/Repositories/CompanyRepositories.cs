using DB_Context_Employee.Interfaces;
using DB_Context_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Repositories
{
    public class CompanyRepositories : ICompanyRepositories
    {
        private readonly App_DBContext_employee _app_DBContext_employee;


        public CompanyRepositories(App_DBContext_employee app_DBContext_employee)
        {
            _app_DBContext_employee = app_DBContext_employee;
        }

        public int AddCompany(Company company)
        {
            _app_DBContext_employee.Company.Add(company);
            return _app_DBContext_employee.SaveChanges();
        }
    }
}
