using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IRoleRepositoryAsync: IRepositoryAsync<Role> {
        Task<IEnumerable<Role>> MostActedRolesAsync();
    }
}