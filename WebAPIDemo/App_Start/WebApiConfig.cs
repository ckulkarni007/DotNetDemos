using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Routing;
using System.Web.Http.Dispatcher;
using WebAPIDemo.Versioning;

namespace WebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Register the custom constraint in default resolver.
            var constraintProvider = new DefaultInlineConstraintResolver();
            constraintProvider.ConstraintMap.Add("validateId", typeof(IdValueConstraint));
            // Web API routes
            config.MapHttpAttributeRoutes(constraintProvider);

            // RouteTemplate
            config.Routes.MapHttpRoute(
               name: "ActionApi",
               routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                //handler: new MyCustomMessageHandler(),
                //constraints: new { },
                 defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IHttpControllerSelector), new CustomControllerSelectionHandler(config));

            //Formating and casing
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            //Adding CamelCasing as a default serialization Setting.
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //To Remove any existing formatter
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            //To Add custom Formatter
            //config.Formatters.Add(new CustomJsonFormatter());

            //To support any new media type.
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            EnableCorsAttribute enableCorsAttribute = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(enableCorsAttribute);

           
        }
    }


    //class MyCustomMessageHandler : HttpMessageHandler
    //{
    //    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    //    {
    //        Debug.Write("My Custome route handle");
    //    }
    //}
}


