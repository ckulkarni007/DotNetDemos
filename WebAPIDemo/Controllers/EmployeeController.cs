using LINQTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Filters;

namespace WebAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public EmployeeController()
        {
            OfficeEmployee.GetEmployeeDetails();
        }
        [ActionFilterDemo]
        public List<OfficeEmployee> GetAllEmployees()
        {
            return OfficeEmployee.GetEmployeeDetails();
        }

        public OfficeEmployee GetEmployee(int id)
        {
            return OfficeEmployee.GetEmployeeById(id);
        }

        [HttpGet]
       // [ActionFilterDemo]
        public HttpResponseMessage Search(int id)
        {

            var employee = OfficeEmployee.GetEmployeeById(id);
            if (employee == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, new Exception("No Employee Available"));
            else
                return Request.CreateResponse(HttpStatusCode.OK, employee);
        }


        [HttpGet]
        public IHttpActionResult SearchEmployee(int id)
        {

            var employee = OfficeEmployee.GetEmployeeById(id);
            if (employee == null)
                return NotFound();
            else
                return Ok(employee);
        }



        public IHttpActionResult Put(int id, string name)
        {
            OfficeEmployee.GetEmployeeById(id).Name = name;
            return Ok(name);
        }

        public IHttpActionResult PutComplex(int id, OfficeEmployee officeEmployee)
        {
            var empResult = OfficeEmployee.GetEmployeeById(id);
            if (empResult == null)
            {
                return NotFound();
            }
            else
            {
                empResult.Name = officeEmployee.Name;
                empResult.Salary = officeEmployee.Salary;

                return Ok(empResult);
            }
        }

        public string Post(OfficeEmployee officeEmployee)
        {
            OfficeEmployee.AddEmployee(officeEmployee);
            return "Employee added sucessfully";
        }
    }
}
