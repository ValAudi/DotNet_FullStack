using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IGenreServiceAsync {
        Task<IEnumerable<Genre>> ListOfPopularGenresAsync();
    }

}