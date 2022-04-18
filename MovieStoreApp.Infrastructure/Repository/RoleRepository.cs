using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class RoleRepository: BaseRepository<Role>, IRoleRepository {
        MovieStoreContext db;
        public RoleRepository(MovieStoreContext _db):base(_db)
        {
            db = _db;
        }
    }
}