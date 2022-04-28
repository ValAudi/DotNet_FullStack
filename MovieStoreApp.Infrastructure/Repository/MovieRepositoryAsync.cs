using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;


namespace MovieStoreApp.Infrastructure.Repository 
{
    public class MovieRepositoryAsync: BaseRepositoryAsync<Movie>, IMovieRepositoryAsync {
        MovieStoreContext db;
        public MovieRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync() {
            return await db.Movies.OrderByDescending(x => x.Id).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync() {
            return await db.Movies.OrderByDescending(x => x.Id).Take(3).ToListAsync();
        }
    }
}