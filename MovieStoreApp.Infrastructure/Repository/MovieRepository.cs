using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class MovieRepository: BaseRepository<Review> {
        public MovieRepository(MovieStoreContext _db):base(_db)
        {
            
        }
    }
}