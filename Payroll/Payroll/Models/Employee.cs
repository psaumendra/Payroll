using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Employee
    {
        [Key]
        public Int64 EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string TIN { get; set; }
        public int EmployeeType { get; set; }
        public decimal Salary { get; set; }
    }

    public enum EmployeeTypes
    {
        Regular = 1,
        Contractual = 2
    }

    public class APIResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
