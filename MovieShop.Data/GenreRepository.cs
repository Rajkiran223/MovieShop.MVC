using MovieShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieShop.Data.GenreRepository;

namespace MovieShop.Data
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieShopDbContext context) : base(context)
        {

        }

        public IEnumerable<Genre> GetActionMovies(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            throw new NotImplementedException();
        }



        public interface IGenreRepository : IRepository<Genre>
        {
            IEnumerable<Genre> GetAllGenres();
            IEnumerable<Genre> GetActionMovies(int genreId);
        }
    }
}
