using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class TrailerServiceAsync: ITrailerServiceAsync {
        ITrailerRepositoryAsync trailerRepository;
        public TrailerServiceAsync(ITrailerRepositoryAsync _t)
        {
            trailerRepository = _t;
        }

        public async Task<IEnumerable<Trailer>> ListOfTrailersReleasedByYear() {
            List<Trailer> trailerList = new List<Trailer>();
            var fetched = await trailerRepository.GetAllAsync();
            foreach (var item in fetched) {
                Trailer TrailerFields = new Trailer();
                TrailerFields.TrailerId = item.TrailerId;
                TrailerFields.MovieId = item.MovieId;
                TrailerFields.TrailerUrl = item.TrailerUrl;
                TrailerFields.TrailerName = item.TrailerName;
                trailerList.Add(TrailerFields);
            }
            return trailerList;
        }
            
    }
}