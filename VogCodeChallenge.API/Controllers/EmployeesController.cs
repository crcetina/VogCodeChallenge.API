using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Business;
using VogCodeChallenge.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        #region PROPERTIES


        private ManagmentEmployees _Employees;

        public ManagmentEmployees Employees
        {
            get { return _Employees = new ManagmentEmployees(); }
            set { _Employees = value; }
        }
        #endregion




        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var employees = Employees.list_Employees();
                return Ok(employees);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        // GET api/<EmployeesController>/department/5
        [HttpGet("department/{departmentId}")]
        public ActionResult Get(int departmentId)
        {
            try
            {
                var departments = Employees.list_Departments_Filter(departmentId);
                return Ok(departments);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        // GET: api/<EmployeesController>
        [HttpGet("GetAll")]
        public IEnumerable<Employee> GetAll()
        {

            try
            {
                return Employees.GetAll();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        // GET: api/<EmployeesController>
        [HttpGet("ListAll")]
        public IList<Employee> ListAll()
        {
            try
            {
                return Employees.ListAll();
            }
            catch (Exception ex)
            {

                return null;
            }


        }



        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
