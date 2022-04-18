using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class MovieUserRepository: BaseRepository<MovieUser>, IMovieUserRepository {
        MovieStoreContext db;
        public MovieUserRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}