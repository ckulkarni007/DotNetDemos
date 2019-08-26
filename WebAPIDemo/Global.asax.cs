using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebAPIDemo.Filters;

namespace WebAPIDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
           // GlobalConfiguration.Configuration.Filters.Add(new ActionFilterDemo());
        }
    }
}
