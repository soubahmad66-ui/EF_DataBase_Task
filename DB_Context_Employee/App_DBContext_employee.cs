using System;
using System.Collections.Generic;
using System.Text;
using DB_Context_Employee.Models;
using Microsoft.EntityFrameworkCore;
namespace DB_Context_Employee
{
    public class App_DBContext_employee : DbContext
    {
        public App_DBContext_employee() { }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

        public App_DBContext_employee(DbContextOptions<App_DBContext_employee> options)
           : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuldir)
        {

            optionsBuldir.UseSqlServer("Server=.;Database=DB_Employee;Integrated Security=true;TrustServerCertificate=true;");

        }
    }




}
