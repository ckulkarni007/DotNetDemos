using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebAPIDemo.Filters
{
    public class ExceptionFilterDemo : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Debug.Write(actionExecutedContext.Exception.Message);
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
            actionExecutedContext.Response.Content = new StringContent("Everything is fine...we are just working out on some solutions");

        }
    }
}