using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class PurchaseRepository: BaseRepository<Review> {
        public PurchaseRepository(MovieStoreContext _db):base(_db)
        {
            
        }
    }
}