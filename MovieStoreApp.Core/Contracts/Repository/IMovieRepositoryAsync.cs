using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IMovieRepositoryAsync: IRepositoryAsync<Movie> {
        Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync();
        Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync();
    }
}