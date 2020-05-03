using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.MVC.Filters
{
    public class MovieShopExceptionFilter : HandleErrorAttribute 
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var controllerName = (string)filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];

            //create a Model for HandleErrorInfo which is already built-in MVC
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

            var dateTimeExceptionHappened = DateTime.Now.TimeOfDay.ToString();

            var stackTrace = filterContext.Exception.StackTrace;
            var exceptionMessage = filterContext.Exception.Message;
            var innerException = filterContext.Exception.InnerException;

            filterContext.Result = new ViewResult
            {
                ViewName = View,
                MasterName = Master,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData = filterContext.Controller.TempData
            };
            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;
            // Http Status Code 500 should be used when and exception happens
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
            // Now use NLog to log above details to the Text Files.
            //Send out Emails to the Dev Team
            // To send emails in C# Mailkit download from Nuget
            base.OnException(filterContext);
        }
    }
}