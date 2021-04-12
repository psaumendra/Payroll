using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class DbContext
    {
        public static List<Employee> employees = new List<Employee>();

        public static List<Employee> GetEmployees()
        {
            return employees;
        }

        public static Employee GetEmployeeDetails(Int64 empId)
        {
            return employees.Where(x => x.EmployeeId == empId).FirstOrDefault();
        }

        public static Int64 GetUniqeEmpId()
        {
            return employees.Any() ? employees.OrderByDescending(x => x.EmployeeId).First().EmployeeId + 1 : 1;
        }
        public static Employee GetEmployeeDetails(int EmpId = 0)
        {
            return employees.Where(x => x.EmployeeId == EmpId).FirstOrDefault();
        }

        public static int InsertEmployee(Employee emp)
        {
            try
            {
                emp.EmployeeId = GetUniqeEmpId();
                employees.Add(emp);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteEmployee(int empId)
        {
            try
            {
                employees.Remove(employees.Single(x => x.EmployeeId == empId));
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
