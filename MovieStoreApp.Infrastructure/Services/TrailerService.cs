using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class TrailerService: ITrailerService {
        ITrailerRepository trailerRepository;
        public TrailerService(ITrailerRepository _t)
        {
            trailerRepository = _t;
        }

        public IEnumerable<Trailer> TrailerList () {
            List<Trailer> trailerList = new List<Trailer>();
            var fetched = trailerRepository.GetAll();
            foreach (var item in fetched) {
                Trailer TrailerFields = new Trailer();
                TrailerFields.TrailerId = item.TrailerId;
                TrailerFields.TrailerName = item.TrailerName;
                TrailerFields.TrailerUrl = item.TrailerUrl;
                trailerList.Add(TrailerFields);
            }
            return trailerList;
        }
        

    }
}