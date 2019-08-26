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

        [HttpGet]
       // [ActionFilterDemo]
        public HttpResponseMessage Search(int id)
        {

            var employee = OfficeEmployee.GetEmployeeById(id);
            if (employee == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, new Exception("Incorrect employee", new Exception("this is innerException")));
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



        public string Put(int id, string name)
        {
            OfficeEmployee.GetEmployeeById(id).Name = name;
            return "name updated successfully";
        }

        public string Post(OfficeEmployee officeEmployee)
        {
            OfficeEmployee.AddEmployee(officeEmployee);
            return "Employee added sucessfully";
        }
    }
}
