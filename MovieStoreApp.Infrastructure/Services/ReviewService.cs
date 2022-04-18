using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class ReviewService: IReviewService {
        IReviewRepository reviewRepository;
        public ReviewService(IReviewRepository _r)
        {
            reviewRepository = _r;
        }
    }
}