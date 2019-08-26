using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebAPIDemo.Filters
{
    public class ExceptionFilterDemo : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Debug.Write(actionExecutedContext.Exception.Message);
        }
    }
}