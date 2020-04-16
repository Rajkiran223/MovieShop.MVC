using MovieShop.Data;
using MovieShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new MovieShopDbContext())
            //{
            // var genres = db.Genres.ToList();
            //var movies = db.Movies.Where(m => m.Title.StartsWith("a")).ToList();
            //var movies = db.Movies.ToList().Where(m => m.Title.StartsWith("a")).ToList();
            //}
                //var movieService = new MovieService();

                //var movie = movieService.GetMovieDetails(1);

            var castservice = new CastService();
            var cast = castservice.GetCastDetails(1);

            //Console.WriteLine(movie.Id + movie.Title);
            Console.WriteLine(cast.Id);

                Console.ReadLine();
                 
            
            
        } 
    }
}
