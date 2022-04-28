using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class ReviewServiceAsync: IReviewServiceAsync {
        IReviewRepositoryAsync reviewRepository;
        public ReviewServiceAsync(IReviewRepositoryAsync _r)
        {
            reviewRepository = _r;
        }

        public async Task<IEnumerable<Review>> MostReviewedMoviesByYearAsync() {
            List<Review> ReviewList = new List<Review>();
            var result = await reviewRepository.MostReviewedMoviesByYearAsync();
            foreach (var item in result) {
                Review reviewFields = new Review();
                reviewFields.MovieId = item.MovieId;
                reviewFields.UserId = item.UserId;
                reviewFields.Rating = item.Rating;
                reviewFields.ReviewText = item.ReviewText;
                ReviewList.Add(reviewFields);
            }
            return ReviewList;
        }
    }
}