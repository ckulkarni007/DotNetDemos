using LINQTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPINextDemos.Controllers
{
    public class NewEmployeeController : ApiController
    {
        public List<OfficeEmployee> Get()
        {
            return OfficeEmployee.GetEmployeeDetails();
        }
    }
}
