using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class PurchaseRepository: BaseRepository<Purchase>, IPurchaseRepository {
        MovieStoreContext db;
        public PurchaseRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}
