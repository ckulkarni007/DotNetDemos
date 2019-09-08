using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebAPIDemo.Filters
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            if (actionContext.RequestContext.Principal.IsInRole("admin"))
                return true;
            else
                return false;
        }
    }



    //public class CustomAuthFilter : AuthorizeAttribute
    //{
    //    protected override bool IsAuthorized(HttpActionContext actionContext)
    //    {
    //        var authPara = actionContext.Request.Headers.Authorization.Parameter;
    //        string credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authPara));
    //        IIdentity identity = new GenericIdentity(credentials.Split(':')[0]);
    //        IPrincipal principal = new GenericPrincipal(identity, new string[] {"admin" });
    //        Thread.CurrentPrincipal = principal;
    //    }
    //}
}