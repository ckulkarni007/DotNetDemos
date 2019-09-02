using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Routing;

namespace WebAPIDemo
{
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

    class IdValueConstraint : IHttpRouteConstraint
    {
        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            if (values.TryGetValue(parameterName, out object parsedValue) && parsedValue != null)
            {
                int para = Convert.ToInt32(parsedValue);
                if (para > 3)
                    return true;
                return false;
            }
            return false;
        }
    }
}

//Formating and casing
//config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
//          config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
//config.Formatters.Remove(config.Formatters.XmlFormatter);
//config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));