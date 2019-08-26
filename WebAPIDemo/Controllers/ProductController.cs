using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ProductController : ApiController
    {
        public List<string> FindProduct()
        {
            return new List<string> { "hotel", "flight", "car" };
        }
    }
}
