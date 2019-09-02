using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIDemo.Filters
{
    public class ActionFilterDemo : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Debug.Write(actionContext.RequestContext.Url.Request.RequestUri.AbsoluteUri);
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }




        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    var authPara = actionContext.Request.Headers.Authorization.Parameter;
        //    string credentials =  Encoding.UTF8.GetString(Convert.FromBase64String(authPara));
        //    actionContext.Request.Headers.TryGetValues("username", out IEnumerable<string> userNames);
        //    actionContext.Request.Headers.TryGetValues("authorization", out IEnumerable<string> passwords);

        //    string userName = ""; string password = "";
        //    if (userNames != null && passwords != null)
        //    {
        //        userName = userNames.FirstOrDefault();
        //        password = passwords.FirstOrDefault();
        //    }
        //    else
        //    {
        //        var credSplit = credentials.Split(':');
        //        userName = credSplit[0];
        //        password = credSplit[1];
        //    }

        //    if(userName != "chaitanya" && password != "Newuser123")
        //    {
        //        actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
        //        actionContext.Response.Content = new StringContent("You are not authorize for this webapi");
        //    }

        //    //Debug.Write($"you want to know the url you are hitting  - {actionContext.Request.RequestUri}");
        //}

        //public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        //{
        //    var results = actionExecutedContext.Response.Content.ReadAsStringAsync().Result;
        //    Debug.Write($"the results are - {results}");

        //}
    }
}