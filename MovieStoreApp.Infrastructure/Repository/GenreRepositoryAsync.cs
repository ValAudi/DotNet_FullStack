using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class GenreRepositoryAsync: BaseRepositoryAsync<Genre>, IGenreRepositoryAsync {
        MovieStoreContext db;
        public GenreRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }

        public async Task<IEnumerable<Genre>> ListOfPopularGenresAsync() {
            return await db.Genres.OrderByDescending(x => x.GenreId).Take(10).ToListAsync();
        }
    }
}