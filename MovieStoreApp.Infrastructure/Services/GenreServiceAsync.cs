using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class GenreServiceAsync: IGenreServiceAsync {
        IGenreRepositoryAsync genreRepository;

        public GenreServiceAsync(IGenreRepositoryAsync _g)
        {
            genreRepository = _g;
        }

        public async Task<IEnumerable<Genre>> ListOfPopularGenresAsync() {
            List<Genre> genreList = new List<Genre>();
            var result = await genreRepository.GetAllAsync();
            foreach (var item in result) {
                Genre genreFields = new Genre();
                genreFields.GenreId = item.GenreId;
                genreFields.GenreName = item.GenreName;
                genreList.Add(genreFields);
            }
            return genreList;
        }
    }
}
