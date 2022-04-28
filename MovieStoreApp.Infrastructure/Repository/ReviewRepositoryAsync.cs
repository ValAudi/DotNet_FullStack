using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;


namespace MovieStoreApp.Infrastructure.Repository 
{
    public class ReviewRepositoryAsync: BaseRepositoryAsync<Review>, IReviewRepositoryAsync {
        MovieStoreContext db;
        public ReviewRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Review>> MostReviewedMoviesByYearAsync() {
            return await db.Reviews.OrderByDescending(x => x.Rating).Take(10).ToListAsync();
        }
    }
}