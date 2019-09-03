using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebAPIDemo.Filters
{
    public class MessageHandler : DelegatingHandler
    {
        //protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        //{
        //     base.SendAsync(request, cancellationToken);
        //    Debug.WriteLine("I been excuted");
        //    return Task.FromResult<HttpResponseMessage>(new HttpResponseMessage() { Content = new StringContent("Hell") });
        //}
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