using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository 
{
    public class ReportRepository: BaseRepository<Review> {
        public ReportRepository(MovieStoreContext _db):base(_db)
        {
            
        }
    }
}