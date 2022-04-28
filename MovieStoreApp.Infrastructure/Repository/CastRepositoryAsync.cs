using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class CastRepositoryAsync: BaseRepositoryAsync<Cast>, ICastRepositoryAsync {
        MovieStoreContext db;
        public CastRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Cast>> AllTimeCastRankingAsync() {
            return await db.Casts.OrderByDescending(x => x.Id).Take(10).ToListAsync();
        }
        public async Task<IEnumerable<Cast>> BestCastCrewbyYearAsync() {
            return await db.Casts.OrderByDescending(x => x.Id).Take(3).ToListAsync();
        }
    }
}