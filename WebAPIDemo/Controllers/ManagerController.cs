using LINQTutorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ManagerController : ApiController
    {
        public string GetmanagerByIdAndName(int id, string name)
        {
            return $"{id.ToString()} - {name}";
        }

        public string GetmanagerByIdAndName(int id, string name, decimal salary)
        {
            return $"{id.ToString()} - {name} - {salary}";
        }

        public string PostManagerDetails(int id, string name, decimal salary)
        {
            return $"Data successfully posted - {id} - {name}";
        }

        public string PostManagerDetailsWithRequestBody(int id, Manager manager)
        {
            return $"Data successfully posted - {id} - {manager.Name}";
        }

        public string PostManagerDetailsWithURI(int id, [FromUri]Manager manager)
        {
            return $"Data successfully posted - {id} - {manager.Name}";
        }

        public string PostManagerDetailsWithURIAndIdInBody([FromBody]int id, [FromUri]Manager manager)
        {
            return $"Data successfully posted - {id} - {manager.Gender}";
        }
    }
}
