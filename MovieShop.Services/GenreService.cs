using MovieShop.Data;
using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieShop.Data.GenreRepository;

namespace MovieShop.Services
{
    public class GenreService : IGenreService
    {
        private GenreRepository _genreRepository;

        public GenreService()
        {
            _genreRepository = new GenreRepository(new MovieShopDbContext());
        }

        public IEnumerable<Genre> GetAllGenre()
        {
            return _genreRepository.GetAll();
        }

    }

    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenre();
    }
}
