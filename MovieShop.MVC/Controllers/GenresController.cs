using MovieShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class GenresController : Controller
    {
        private IGenreService _genreService;
        // GET: Genres
        public GenresController()
        {
            _genreService = new GenreService();
        }
        public ActionResult Index()
        {
            var genres = _genreService.GetAllGenre().OrderBy(g => g.Name).ToList(); 
            return PartialView("GenreView", genres);
            //return View();
        }
    }
}