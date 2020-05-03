using MovieShop.MVC.Filters;
using MovieShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.MVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public IMovieService _movieService;
        public HomeController()
        {
            _movieService = new MovieService();
        }

        //[LogActionFilter ]

        public ActionResult Index()
        {
            //get top revenue and show them in the main home page
            //use same Moviecard as you did for genre movies
            var topGrossingMovies = _movieService.GetTopGrossingMovies();
            return View(topGrossingMovies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}