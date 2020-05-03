using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieShop.MVC.Filters
{
    //ActionFilter
    //ExceptionFilter
    //AuthorizationFilter
    //AuthorizationFilter

    // Creating a custom Filter to log some information about user
    //like his/her browser, type of request, url he is accessing
    public class LogActionFilter : ActionFilterAttribute 
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogSomeInformation("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogSomeInformation("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogSomeInformation("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogSomeInformation("OnResultExecuted", filterContext.RouteData);
        }

        private void LogSomeInformation(string methodName, RouteData routeData)
        {
            // We can log this info to any text file using any logging 3rd party framework
            // such as Nlog, serilog, log4net.
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
        }
    }
}