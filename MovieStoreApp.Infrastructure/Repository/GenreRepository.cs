using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class GenreRepository: BaseRepository<Genre>, IGenreRepository {
        MovieStoreContext db;
        public GenreRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}