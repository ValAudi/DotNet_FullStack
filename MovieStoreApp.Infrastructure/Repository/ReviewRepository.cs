using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class ReviewRepository: BaseRepository<Review>, IReviewRepository {
        MovieStoreContext db;
        public ReviewRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}