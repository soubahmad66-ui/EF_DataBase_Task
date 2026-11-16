using System;
using System.Collections.Generic;
using System.Text;

namespace DB_Context_Employee.Models
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }

    }
}
