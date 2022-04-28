using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class CastServiceAsync: ICastServiceAsync {
        ICastRepositoryAsync castRepository;

        public CastServiceAsync(ICastRepositoryAsync _c)
        {
            castRepository = _c;
        }

        public async Task<IEnumerable<Cast>> AllTimeCastRankingAsync() {
            List<Cast> castList = new List<Cast>();
            var fetched = await castRepository.GetAllAsync();
            foreach (var item in fetched) {
                Cast castFields = new Cast();
                castFields.Id = item.Id;
                castFields.Name = item.Name;
                castFields.Gender = item.Gender;
                castFields.ProfilePath = item.ProfilePath;
                castFields.TmdbUrl = item.TmdbUrl;
                castList.Add(castFields);
            }
            return castList;
        }
        public async Task<IEnumerable<Cast>> BestCastCrewbyYearAsync() {
            List<Cast> castList = new List<Cast>();
            var fetched = await castRepository.GetAllAsync();
            foreach (var item in fetched) {
                Cast castFields = new Cast();
                castFields.Id = item.Id;
                castFields.Name = item.Name;
                castFields.Gender = item.Gender;
                castFields.ProfilePath = item.ProfilePath;
                castFields.TmdbUrl = item.TmdbUrl;
                castList.Add(castFields);
            }
            return castList;
        }
    }
}