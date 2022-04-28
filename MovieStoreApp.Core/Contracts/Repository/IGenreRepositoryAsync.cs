using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IGenreRepositoryAsync: IRepositoryAsync<Genre> {
        Task<IEnumerable<Genre>> ListOfPopularGenresAsync();

    }
}