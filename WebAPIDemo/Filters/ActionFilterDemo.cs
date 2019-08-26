using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIDemo.Filters
{
    public class ActionFilterDemo : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Debug.Write($"you want to know the url you are hitting  - {actionContext.Request.RequestUri}");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var results = actionExecutedContext.Response.Content.ReadAsStringAsync().Result;
            Debug.Write($"the results are - {results}");
           
        }
    }
}