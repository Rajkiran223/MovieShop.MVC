using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class CastController : Controller
    {
        // GET: Cast
        public ActionResult Index()
        {
            return View();
        }

        // step 1 Create a action method that returs empty view to enter Cast Information
        
            //cast/create HTTP Get
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string castname, string profilePath, string gender, string tmdbUrl)
        {
            // save this information tocast Table
            return View();
        }
    }
}