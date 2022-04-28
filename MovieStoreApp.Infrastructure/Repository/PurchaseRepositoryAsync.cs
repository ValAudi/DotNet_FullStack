using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;


namespace MovieStoreApp.Infrastructure.Repository 
{
    public class PurchaseRepositoryAsync: BaseRepositoryAsync<Purchase>, IPurchaseRepositoryAsync {
        MovieStoreContext db;
        public PurchaseRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Purchase>> Top10PurchasesByYearAsync() {
            return await db.Purchases.OrderByDescending(x => x.PurchaseId).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<Purchase>> AllTimePurchasesAsync() {
            return await db.Purchases.OrderByDescending(x => x.PurchaseId).Take(3).ToListAsync();
        }   
    }
}
