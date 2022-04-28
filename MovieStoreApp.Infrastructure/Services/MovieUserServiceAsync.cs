using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class MovieUserServiceAsync: IMovieUserServiceAsync {
        IMovieUserRepositoryAsync movieUserRepository;
        public MovieUserServiceAsync(IMovieUserRepositoryAsync _u)
        {
            movieUserRepository = _u;
        }

        public async Task<IEnumerable<MovieUser>> MostFrequentUsersAsync() {
            List<MovieUser> movieUserList = new List<MovieUser>();
            var result = await movieUserRepository.MostFrequentUsersAsync();
            foreach (var item in result) {
                MovieUser movieUserFields = new MovieUser();
                movieUserFields.UserId = item.UserId;
                movieUserFields.FirstName = item.FirstName;
                movieUserFields.LastName = item.LastName;
                movieUserFields.DateOfBirth = item.DateOfBirth;
                movieUserFields.email = item.email;
                movieUserFields.HashedPassword = item.HashedPassword;
                movieUserFields.salt = item.salt;
                movieUserFields.PhoneNumber = item.PhoneNumber;
                movieUserFields.TwoFactorEnabled = item.TwoFactorEnabled;
                movieUserFields.LockoutEndDate = item.LockoutEndDate;
                movieUserFields.LastLoginDateTime = item.LastLoginDateTime;
                movieUserFields.isLocked = item.isLocked;
                movieUserFields.AccessFailedCount = item.AccessFailedCount;
                movieUserList.Add(movieUserFields);            
            }
            return movieUserList;
        }

        public async Task<IEnumerable<MovieUser>> MovieUserRegionsAsync () {
            List<MovieUser> movieUserList = new List<MovieUser>();
            var result = await movieUserRepository.MostFrequentUsersAsync();
            foreach (var item in result) {
                MovieUser movieUserFields = new MovieUser();
                movieUserFields.UserId = item.UserId;
                movieUserFields.FirstName = item.FirstName;
                movieUserFields.LastName = item.LastName;
                movieUserFields.DateOfBirth = item.DateOfBirth;
                movieUserFields.email = item.email;
                movieUserFields.HashedPassword = item.HashedPassword;
                movieUserFields.salt = item.salt;
                movieUserFields.PhoneNumber = item.PhoneNumber;
                movieUserFields.TwoFactorEnabled = item.TwoFactorEnabled;
                movieUserFields.LockoutEndDate = item.LockoutEndDate;
                movieUserFields.LastLoginDateTime = item.LastLoginDateTime;
                movieUserFields.isLocked = item.isLocked;
                movieUserFields.AccessFailedCount = item.AccessFailedCount;
                movieUserList.Add(movieUserFields);            
            }
            return movieUserList;
        }

    }
}