using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class GenreService: IGenreService {
        IGenreRepository genreRepository;

        public GenreService(IGenreRepository _g)
        {
            genreRepository = _g;
        }
    }
}
