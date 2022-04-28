using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface ICastServiceAsync {
        Task<IEnumerable<Cast>> AllTimeCastRankingAsync();
        Task<IEnumerable<Cast>> BestCastCrewbyYearAsync();
    }

}