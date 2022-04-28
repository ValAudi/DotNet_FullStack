using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IMovieUserRepositoryAsync: IRepositoryAsync<MovieUser> {
        Task<IEnumerable<MovieUser>> MostFrequentUsersAsync();
        Task<IEnumerable<MovieUser>> MovieUserRegionsAsync();
    }
}