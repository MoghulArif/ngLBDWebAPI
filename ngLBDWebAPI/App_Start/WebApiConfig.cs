using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
//Using Microsoft.AspNet.WebApi.Cors;
using System.Web.Http.Cors;

namespace ngLBDWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new 
                MediaTypeHeaderValue("text/html"));

            //EnableCorsAttribute cors = new EnableCorsAttribute("http://localhost:80/DemoApp/WebForm1.aspx", "*", "GET,POST");
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "GET,POST");
            config.EnableCors(cors);
            //config.EnableCors();

            

            //var corsAttr = new EnableCorsAttribute("http://example.com", "*", "*");


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
