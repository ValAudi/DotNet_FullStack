using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class CastService: ICastService {
        ICastRepository castRepository;

        public CastService(ICastRepository _c)
        {
            castRepository = _c;
        }
    }
}