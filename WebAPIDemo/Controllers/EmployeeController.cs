using LINQTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public OfficeEmployee Get()
        {
            
            return OfficeEmployee.GetEmployeeDetails().First();
        }

        public HttpResponseMessage Post(OfficeEmployee officeEmployee)
        {

            return Request.CreateResponse(HttpStatusCode.Accepted, "success");
        }
    }
}
