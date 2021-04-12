using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            //Employee emp = new Employee();
            //emp.Name = "Saumendra";
            //emp.EmployeeType = 1;
            //emp.BirthDate = Convert.ToDateTime("10/10/2019");
            //emp.Salary = 1000.00M;

            //DbContext.InsertEmployee(emp);
            //Employee emp1 = new Employee();
            //emp1.Name = "Saumendra P";
            //emp1.EmployeeType = 2;
            //emp1.BirthDate = Convert.ToDateTime("10/10/2019");
            //emp1.Salary = 1000.00M;

            //DbContext.InsertEmployee(emp1);
            APIResponse response = new APIResponse();
            

            return DbContext.GetEmployees();
        }

        [HttpGet]
        [Route("GetEmployeeDetails")]
        public APIResponse GetEmployeeDetails(int EmpId)
        {
            APIResponse response = new APIResponse();
            response.Result = DbContext.GetEmployees();

            return response;
        }
        [HttpPost]
        [Route("AddUser")]
        public APIResponse AddUser(Employee emp)
        {
            APIResponse response = new APIResponse();
            if (DbContext.InsertEmployee(emp) == 1)
            {
                response.Message = "Inserted successfully.";
            }
            return response;
        }
    }
}
