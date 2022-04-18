using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class MovieService: IMovieService {
        IMovieRepository movieRepository;

        public MovieService(IMovieRepository _m)
        {
            movieRepository = _m;
        }
        
    }
}