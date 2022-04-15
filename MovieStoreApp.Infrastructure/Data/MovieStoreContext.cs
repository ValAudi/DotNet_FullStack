using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Entity;


namespace MovieStoreApp.Infrastructure.Data
{
    public class MovieStoreContext: DbContext {
        public MovieStoreContext(DbContextOptions<MovieStoreContext> option):base (option)
        {
            
        }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieUser> MovieUsers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Trailer> Trailers{ get; set; }

    }    
}

