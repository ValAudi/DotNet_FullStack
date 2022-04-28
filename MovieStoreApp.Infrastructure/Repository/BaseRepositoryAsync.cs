using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class {
        MovieStoreContext db;
        public BaseRepositoryAsync(MovieStoreContext _db)
        {
            db = _db;
        }
        public async Task<int> insertAsync(T entity){
            await db.Set<T>().AddAsync(entity);
            await db.SaveChangesAsync();
            return 1;
        }
        public async Task<int> updateAsync(T entity){
            db.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await db.SaveChangesAsync();
            return 1;
        }
        public async Task<int> DeleteAsync(int id){
            var entity = await db.Set<T>().FindAsync(id);
            if (entity != null) {
                db.Set<T>().Remove(entity);
                await db.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<IEnumerable<T>> GetAllAsync(){
            return await db.Set<T>().ToListAsync();
        }
        public async Task<T> GetAsync(int id){
            return await db.Set<T>().FindAsync(id);
        }

    }
}