using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;


namespace MovieStoreApp.Infrastructure.Repository 
{
    public class MovieUserRepositoryAsync: BaseRepositoryAsync<MovieUser>, IMovieUserRepositoryAsync {
        MovieStoreContext db;
        public MovieUserRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<MovieUser>> MostFrequentUsersAsync() {
            return await db.MovieUsers.OrderByDescending(x => x.UserId).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<MovieUser>> MovieUserRegionsAsync () {
            return await db.MovieUsers.OrderByDescending(x => x.UserId).Take(3).ToListAsync();
        }

        
        
    }
}