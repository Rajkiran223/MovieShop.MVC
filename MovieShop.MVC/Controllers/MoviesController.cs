using MovieShop.Services;
using System.Web.Mvc;

namespace MovieShop.MVC.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : Controller
    {
        // GET http:loaclhost:/Movies/Index
        private IMovieService _movieService;
        public MoviesController()
        {
            _movieService = new MovieService();
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var movies = _movieService.GetTopGrossingMovies();
            return View(movies);
        }

        
        [HttpGet]
        [Route("genres/{genreId}")]
        public ActionResult GenreMovies(int genreId)
        {
            //take genre id from url and then call movie service to get a list of movies belonging to that genre.
            //return movies to the view and display as ImageTags inside the bootstrap card with image urls as postUrl from Movie tabl column
            //Create GetMoviesByGenre(int genreId) inside IMovieService and implement that method call Movies Repository to get movies of that genre
            return View();
        }

    }
}