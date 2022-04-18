using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class MovieUserService: IMovieUserService {
        IMovieUserRepository movieUserRepository;
        public MovieUserService(IMovieUserRepository _u)
        {
            movieUserRepository = _u;
        }
    }
}