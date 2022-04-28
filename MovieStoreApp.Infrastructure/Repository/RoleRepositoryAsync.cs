using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;
using Microsoft.EntityFrameworkCore;


namespace MovieStoreApp.Infrastructure.Repository 
{
    public class RoleRepositoryAsync: BaseRepositoryAsync<Role>, IRoleRepositoryAsync {
        MovieStoreContext db;
        public RoleRepositoryAsync(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
        public async Task<IEnumerable<Role>> MostActedRolesAsync() {
            return await db.Roles.OrderByDescending(x => x.RoleId).Take(10).ToListAsync();
        }
    }
}