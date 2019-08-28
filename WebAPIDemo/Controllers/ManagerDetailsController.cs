using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    [RoutePrefix("api/managers")]
    public class ManagerDetailsController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<string> BringMetheListOfManagerrs()
        {
            return new List<string> { "Bob", "Simon", "Rachael" };
        }


        [Route("{id:alpha}/employees")]
        public string GetManagerById(int id, [FromBody]string name)
        {
            return "employee records for id " + id;
        }
    }
}
