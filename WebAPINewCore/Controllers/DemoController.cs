using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebAPINewCore.Controllers
{
    [Route("api/demo")]
    public class DemoController : ControllerBase
    {
        [Route("Get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpGet("{id}")]
        //public HttpResponseMessage BringMyName(int id)
        //{
        //    // Find employee by id
        //    //if not found
        //   // return  NotFound("employee not found");

        //    //


        //    return Ok(id);
        //}

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"{value} is added successfully");
        }

        [HttpPut]
        [Route("{id}")]
        // PUT api/values/5
        public IActionResult Put(int id, [FromQuery] Employee value)
        {
            return Ok("Update successfully - " + value);
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
