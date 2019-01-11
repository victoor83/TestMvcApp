using System.Web.Mvc;
using System.Web.Routing;

namespace TestMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //#learning
            //specifies that any URL that starts with domainName/students, must be handled by StudentController.
            routes.MapRoute(
            name: "Student",      
            url: "students/{id}",
            defaults: new { controller = "Student", action = "Index" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
