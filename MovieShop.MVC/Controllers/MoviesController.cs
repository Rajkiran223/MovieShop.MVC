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
        // Routing
        // DI with Constructor Injection

        //private readonly int x;

        private readonly IMovieService _movieService;
        // MVC 5 requires Parameterless Contructor
        //For IMovieService movieService, we need to inject an implemented
        // we can pass any object/nstance that implements IMovieServices Interface
        //In our project MovieService class is implementing IMovieService Interface
        //IOC should inject instance of MovieService for Constructor
        //.Net Framework there are no built-in IOC, we ned to download 3rd party IOC
        //Popular 3rd party IOC's like Ninject, Autfac, Unity etc.
        //In .Net Cre or ASP.NET Core Dependency Injection is builtin, so we don't need any 3rd party IOC.
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        //public MoviesController()
        //{

        //}

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {

            //All Url's always map to controler and Action Method
            //They don't map to View 
            // Every Http Request (Get Post PUT DELETE) they always go
            // TO Controler first, then action method, then Action method needs to return view

            //call service layer to get top 20 revenue movies
            var movies = _movieService.GetTopGrossingMovies();
            return View("TopGrossMovie", movies);
        }

        //take genre id from url and then call movie service to get list of movie
    }
}