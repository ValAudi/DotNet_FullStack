using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface ICastRepositoryAsync: IRepositoryAsync<Cast> {
        Task<IEnumerable<Cast>> AllTimeCastRankingAsync();
        Task<IEnumerable<Cast>> BestCastCrewbyYearAsync();
    }
}