using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Routing;

namespace WebAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            #region Routes
            //     // Web API configuration and services
            //     var constraintProvider = new DefaultInlineConstraintResolver();
            //     constraintProvider.ConstraintMap.Add("validateId", typeof(IdValueConstraint));
            //     // Web API routes
            //     config.MapHttpAttributeRoutes(constraintProvider);

            //     config.Routes.MapHttpRoute(
            //         name: "category",
            //         routeTemplate: "api/{category}",
            //         defaults: new { controller = "employee", category = "product" }
            //      );

            //     config.Routes.MapHttpRoute(
            //    name: "DefaultAPiWithoutParam",
            //    routeTemplate: "api/{controller}"
            //); 
            // RouteTemplate
            // config.Routes.MapHttpRoute(
            //    name: "ActionApi",
            //    routeTemplate: "api/{controller}/{action}"
            //);
            config.MapHttpAttributeRoutes();

            #endregion
            // RouteTemplate
            config.Routes.MapHttpRoute(
               name: "ActionApi",
               routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "mynewAssignment/version/1.0/api/{controller}/{id}",
                  defaults: new { id = RouteParameter.Optional }
            );


            // config.Formatters.Remove(config.Formatters.JsonFormatter);
            //config.Formatters.Add(new CustomJsonFormatter());

        }
    }

    //class CustomJsonFormatter : JsonMediaTypeFormatter
    //{
    //    public CustomJsonFormatter()
    //    {
    //        this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
    //    }
    //    public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
    //    {
    //        base.SetDefaultContentHeaders(type, headers, mediaType);
    //        headers.ContentType = new MediaTypeHeaderValue("application/json");
    //    }
    //}

    //class IdValueConstraint : IHttpRouteConstraint
    //{
    //    public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
    //    {
    //        if (values.TryGetValue(parameterName, out object parsedValue) && parsedValue != null)
    //        {
    //            int para = Convert.ToInt32(parsedValue);
    //            if (para > 3)
    //                return true;
    //            return false;
    //        }
    //        return false;
    //    }
    //}
}

//Formating and casing
//config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
//          config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
//config.Formatters.Remove(config.Formatters.XmlFormatter);
//config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));