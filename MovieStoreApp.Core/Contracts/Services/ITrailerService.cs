using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface ITrailerService {
        IEnumerable<Trailer> TrailerList ();
    }

}