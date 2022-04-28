using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IRoleServiceAsync {
        Task<IEnumerable<Role>> MostActedRolesAsync();
    }

}