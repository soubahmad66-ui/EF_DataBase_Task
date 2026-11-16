using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
