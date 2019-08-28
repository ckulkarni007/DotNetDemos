using ADO.Net;
using LINQTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace EmployeeManagementAPI.Controllers
{
    public class EmployeeManagementController : ApiController
    {
        public List<OfficeEmployee> GetAllEMployees()
        {
           var employees= OfficeEmployee.GetEmployeeDetails();
            return employees;
        }

        [HttpGet]
        public OfficeEmployee FindEmployeeById(int id)
        {
            return OfficeEmployee.GetEmployeeById(id);
        }


        [HttpGet]
        public List<MediaTypeFormatter> GetFormatters()
        {
            return Configuration.Formatters.ToList();
        }

    }
}
