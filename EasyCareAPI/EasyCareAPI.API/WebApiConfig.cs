using System.Web.Http;
using System.Web.Http.Cors;

namespace EasyCareAPI.API
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "user", action = "hello", id = RouteParameter.Optional }
            );
        }
    }
}