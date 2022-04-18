using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class TrailerService: ITrailerService {
        ITrailerRepository trailerRepository;
        public TrailerService(ITrailerRepository _t)
        {
            trailerRepository = _t;
        }
    }
}