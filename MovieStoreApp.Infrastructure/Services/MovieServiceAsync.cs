using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class MovieServiceAsync: IMovieServiceAsync {
        IMovieRepositoryAsync movieRepository;

        public MovieServiceAsync(IMovieRepositoryAsync _m)
        {
            movieRepository = _m;
        }
        
        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync() {
            List<Movie> MovieList = new List<Movie>();
            var result = await movieRepository.GetTop10RevenueMoviesAsync();
            foreach (var item in result) {
                Movie movieFields = new Movie();
                movieFields.Id = item.Id;
                movieFields.Title = item.Title;
                movieFields.Overview = item.Overview;
                movieFields.Tagline = item.Tagline;
                movieFields.Budget = item.Budget;
                movieFields.Revenue = item.Revenue;
                movieFields.ImdbUrl = item.ImdbUrl;
                movieFields.TmdbUrl = item.TmdbUrl;
                movieFields.PosterUrl = item.PosterUrl;
                movieFields.BackdropUrl = item.BackdropUrl;
                movieFields.OriginalLanguage = item.OriginalLanguage;
                movieFields.ReleaseDate = item.ReleaseDate;
                movieFields.Runtime = item.Runtime;
                movieFields.Price = item.Price;
                movieFields.CreatedDate = item.CreatedDate;
                movieFields.UpdatedDate = item.UpdatedDate;
                movieFields.CreatedBy = item.CreatedBy;
                movieFields.UpdatedBy = item.UpdatedBy;
                MovieList.Add(movieFields);
            }

            return MovieList;
        }

        public async Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync() {
            List<Movie> MovieList = new List<Movie>();
            var result = await movieRepository.GetTop10RevenueMoviesAsync();
            foreach (var item in result) {
                Movie movieFields = new Movie();
                movieFields.Id = item.Id;
                movieFields.Title = item.Title;
                movieFields.Overview = item.Overview;
                movieFields.Tagline = item.Tagline;
                movieFields.Budget = item.Budget;
                movieFields.Revenue = item.Revenue;
                movieFields.ImdbUrl = item.ImdbUrl;
                movieFields.TmdbUrl = item.TmdbUrl;
                movieFields.PosterUrl = item.PosterUrl;
                movieFields.BackdropUrl = item.BackdropUrl;
                movieFields.OriginalLanguage = item.OriginalLanguage;
                movieFields.ReleaseDate = item.ReleaseDate;
                movieFields.Runtime = item.Runtime;
                movieFields.Price = item.Price;
                movieFields.CreatedDate = item.CreatedDate;
                movieFields.UpdatedDate = item.UpdatedDate;
                movieFields.CreatedBy = item.CreatedBy;
                movieFields.UpdatedBy = item.UpdatedBy;
                MovieList.Add(movieFields);
            }

            return MovieList;
        }
    }
}