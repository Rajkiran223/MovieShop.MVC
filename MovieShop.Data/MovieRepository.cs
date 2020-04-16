using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Data
{

    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private MovieShopDbContext movieShopDbContext;

        public MovieRepository(MovieShopDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Movie> GetMoviesByGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetTopGrossingMovies()
        {
            // Top 20 movies by revenue
            var movies = _context.Movies.OrderByDescending(m => m.Revenue).Take(20).ToList();
            return movies;
        }

        public override Movie GetById(int id)
        {
            // Get Movie by Id and also include Average Rating of that Movie.
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            
            //Get average rating also later
            return movie;
        }
    }

    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetTopGrossingMovies();
        IEnumerable<Movie> GetMoviesByGenre(int genreId);
    }
}
