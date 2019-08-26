using ADO.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
  
    public class YoungEmployeeController : ApiController
    {
        [Route("api/employee/details/all")]
        public List<Employee> GetEmployeesFromDB()
        {
            return ADOHelper.SQLReaderWithDataTable();
        }

       // [Route("{id:validateId}/name")]
        public string GetEmployeesFromDB(int id)
        {
            return ADOHelper.SQLReaderWithDataTable().Find(x => x.ID.Equals(id)).FirstName;
        }
    }
}
