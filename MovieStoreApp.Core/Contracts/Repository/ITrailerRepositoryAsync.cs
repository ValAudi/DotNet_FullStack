using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface ITrailerRepositoryAsync: IRepositoryAsync<Trailer> {
        Task<IEnumerable<Trailer>> ListOfTrailersReleasedByYear();
    }
}