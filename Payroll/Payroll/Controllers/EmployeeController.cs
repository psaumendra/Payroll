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
            APIResponse response = new APIResponse();

            return DbContext.GetEmployees(); ;
        }

        [HttpGet]
        [Route("GetEmployeeDetails")]
        public APIResponse GetEmployeeDetails(int EmpId)
        {
            APIResponse response = new APIResponse();
            try
            {
                response.Result = DbContext.GetEmployees();
            }
            catch (Exception ex)
            {
                response.Message = "Erro occored." + ex.Message;
                response.Error = true;
            }
            return response;
        }
        [HttpPost]
        [Route("AddUser")]
        public APIResponse AddUser(Employee emp)
        {
            APIResponse response = new APIResponse();
            try
            {

                if (DbContext.InsertEmployee(emp) == 1)
                {
                    response.Message = "Inserted successfully.";
                }
            }
            catch(Exception ex)
            {
                response.Message = "Error occorred: "+ex.Message;
                response.Error = true;
            }
            return response;
        }
    }
}
