using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class PurchaseService: IPurchaseService {
        IPurchaseRepository purchaseRepository;

        public PurchaseService(IPurchaseRepository _p)
        {
            purchaseRepository = _p;
        }
    }
}