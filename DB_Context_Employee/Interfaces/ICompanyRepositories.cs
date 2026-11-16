using DB_Context_Employee.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Interfaces
{
    public interface ICompanyRepositories
    {
        int AddCompany(Company company);

    }
}
