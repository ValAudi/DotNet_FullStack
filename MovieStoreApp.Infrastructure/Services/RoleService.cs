using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class RoleService: IRoleService {
        IRoleRepository roleRepository;
        public RoleService(IRoleRepository _rr)
        {
            roleRepository = _rr;
        }
    }
}