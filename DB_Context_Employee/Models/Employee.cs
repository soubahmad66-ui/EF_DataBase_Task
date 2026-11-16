using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DB_Context_Employee.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "National number is required")]
        [Range(1000, 999999999, ErrorMessage = "National number must be between 1000 and 999999999")]
        public int IdNationalNumber { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Job title must be between 2 and 50 characters")]
        public string? TheJob { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; } = string.Empty;

         
        public int EmployeeId { get; set; }

        public string Department_employee { get; set; }

        public Company? Company { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string email { get; set; } 

        [Required(ErrorMessage = "Salary is required")]
        [Range(100, 100000, ErrorMessage = "Salary must be between 100 and 100000")]
        [Precision(18, 2)]
        public decimal Salary { get; set; }
    }
}