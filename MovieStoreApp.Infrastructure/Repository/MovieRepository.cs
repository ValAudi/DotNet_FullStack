using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class MovieRepository: BaseRepository<Movie>, IMovieRepository {
        MovieStoreContext db;
        public MovieRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}