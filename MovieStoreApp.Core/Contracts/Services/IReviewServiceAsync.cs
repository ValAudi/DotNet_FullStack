using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IReviewServiceAsync {
        Task<IEnumerable<Review>> MostReviewedMoviesByYearAsync();
    }

}