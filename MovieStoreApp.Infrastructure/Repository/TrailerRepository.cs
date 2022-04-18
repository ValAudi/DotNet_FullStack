using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class TrailerRepository: BaseRepository<Trailer>, ITrailerRepository {
        MovieStoreContext db;
        public TrailerRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}