using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class UserController : ApiController
    {
        [Authorize]
        public List<string> GetUserRoles()
        {
            List<string> userroles = new List<string>();
            userroles.Add(User.Identity.Name);
            userroles.Add(User.Identity.IsAuthenticated.ToString());
            userroles.Add(User.Identity.AuthenticationType);
            return userroles;
        }
    }
}
