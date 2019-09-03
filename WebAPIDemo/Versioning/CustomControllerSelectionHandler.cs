using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace WebAPIDemo.Versioning
{
    public class CustomControllerSelectionHandler : DefaultHttpControllerSelector
    {
        public CustomControllerSelectionHandler(HttpConfiguration configuration) : base(configuration)
        {
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var routeData = request.GetRouteData();
            var controllerName = routeData.Values["controller"];

            var queryString = HttpUtility.ParseQueryString(request.RequestUri.Query);

            if (queryString["v"] == "1")
                controllerName += "V1";

            if (queryString["v"] == "2")
                controllerName += "V2";

            var controllers = GetControllerMapping();
            controllers.TryGetValue(controllerName.ToString(), out HttpControllerDescriptor httpControllerDescriptor);

            return httpControllerDescriptor;
        }
    }
}