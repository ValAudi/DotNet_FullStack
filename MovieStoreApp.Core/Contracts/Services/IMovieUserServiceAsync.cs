using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IMovieUserServiceAsync {
        Task<IEnumerable<MovieUser>> MostFrequentUsersAsync();
        Task<IEnumerable<MovieUser>> MovieUserRegionsAsync();
    }

}