using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Filters;

namespace WebAPIDemo.Controllers
{
    [ExceptionFilterDemo]
    public class ProductController : ApiController
    {
       
        [HttpGet]
        public List<string> FindProduct()
        {
            throw new Exception("tehis i stest");
            return new List<string> { "hotel", "flight", "car" };
        }
    }
}
