using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class {
        MovieStoreContext db;
        public BaseRepository(MovieStoreContext _db)
        {
            db = _db;
        }
        public int insert(T entity){
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return 1;
        }
        public int update(T entity){
            db.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return 1;
        }
        public int Delete(int id){
            var entity = db.Set<T>().Find(id);
            if (entity != null) {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
        public IEnumerable<T> GetAll(){
            return db.Set<T>();
        }
        public T Get(int id){
            return db.Set<T>().Find(id);
        }

    }
}