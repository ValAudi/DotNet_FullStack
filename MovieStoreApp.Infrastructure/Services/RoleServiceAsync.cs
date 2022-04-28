using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class RoleServiceAsync: IRoleServiceAsync {
        IRoleRepositoryAsync roleRepository;
        public RoleServiceAsync(IRoleRepositoryAsync _rr)
        {
            roleRepository = _rr;
        }

        public async Task<IEnumerable<Role>> MostActedRolesAsync() {
            List<Role> RoleList = new List<Role>();
            var result = await roleRepository.MostActedRolesAsync();
            foreach (var item in result) {
                Role roleFields = new Role();
                roleFields.RoleId = item.RoleId;
                roleFields.RoleName = item.RoleName;
                RoleList.Add(roleFields);
            }
            return RoleList;
        }
    }
}