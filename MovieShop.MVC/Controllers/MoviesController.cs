using MovieShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET http:loaclhost:/Movies/Index
        private IMovieService _movieService;
        public MoviesController()
        {
            _movieService = new MovieService();
        }

            [HttpGet]
        public ActionResult Index()
        {
            //call service layer to get top 20 revenue movies
            var movies = _movieService.GetTopGrossingMovies();
            return View(movies);
        }
    }
}