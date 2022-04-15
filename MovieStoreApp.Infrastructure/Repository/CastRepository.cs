using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class CastRepository: BaseRepository<Review> {
        public CastRepository(MovieStoreContext _db):base(_db)
        {
            
        }
    }
}