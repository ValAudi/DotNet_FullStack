using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface ITrailerServiceAsync {
        Task<IEnumerable<Trailer>> ListOfTrailersReleasedByYear();
    }

}