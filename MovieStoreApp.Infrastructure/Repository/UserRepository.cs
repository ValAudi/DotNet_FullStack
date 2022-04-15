using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class UserRepository: BaseRepository<Review> {
        public UserRepository(MovieStoreContext _db):base(_db)
        {
            
        }
    }
}