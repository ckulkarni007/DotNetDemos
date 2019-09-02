using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Versioning
{
    public class StudentV2Controller : ApiController
    {
        public string GetStudentName()
        {
            return "This is V2 Student";
        }
    }
}
