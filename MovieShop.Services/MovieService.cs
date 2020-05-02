using MovieShop.Data;
using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Services
{
    public class MovieService : IMovieService
    {
        private MovieRepository _movieRepository;
        public MovieService()
        {
            _movieRepository = new MovieRepository(new MovieShopDbContext());
        }
        public Movie GetMovieDetails(int id)
        {
            var movie = _movieRepository.GetById(id);
            return movie;
        }

        public IEnumerable<Movie> GetMoviesByGenre(int genreId)
        {
            return _movieRepository.GetMoviesByGenre(genreId);
        }

        public IEnumerable<Movie> GetTopGrossingMovies()
        {
            return _movieRepository.GetTopGrossingMovies();
        }

        public object GetMovieDetails()
        {
            throw new NotImplementedException();
        }
    }

    public interface IMovieService
    {
        IEnumerable<Movie> GetTopGrossingMovies();
        IEnumerable<Movie> GetMoviesByGenre(int genreId);
        Movie GetMovieDetails(int id);
    }
}
