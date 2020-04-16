using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Data;
using MovieShop.Entities;
using static MovieShop.Services.CastService;

namespace MovieShop.Services
{
    public class CastService: ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService()
        {
            _castRepository = new CastRepository(new MovieShopDbContext());
        }

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public Cast GetCastDetails(int castId)
        {
            var cast = _castRepository.GetCastWithMovies(castId);
            return cast;
        }

        public interface ICastService
        {
            Cast GetCastDetails(int Id);
        }
    }
}
