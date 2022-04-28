using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class TrailerRepositoryAsync: BaseRepositoryAsync<Trailer>, ITrailerRepositoryAsync {
        MovieStoreContext db;
        public TrailerRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Trailer>> ListOfTrailersReleasedByYear() {
            return await db.Trailers.OrderByDescending(x => x.MovieId).Take(10).ToListAsync();
        }
    }
}