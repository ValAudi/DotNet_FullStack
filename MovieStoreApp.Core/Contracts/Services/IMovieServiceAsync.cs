using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IMovieServiceAsync {
        Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync();
        Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync();
    }

}