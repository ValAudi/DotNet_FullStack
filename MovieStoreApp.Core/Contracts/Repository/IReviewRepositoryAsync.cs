using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IReviewRepositoryAsync: IRepositoryAsync<Review> {
        Task<IEnumerable<Review>> MostReviewedMoviesByYearAsync();
    }
}