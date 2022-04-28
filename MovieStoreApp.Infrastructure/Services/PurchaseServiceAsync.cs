using MovieStoreApp.Core.Contracts.Services;
using MovieStoreApp.Core.Contracts.Repository;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Infrastructure.Service 
{
    public class PurchaseServiceAsync: IPurchaseServiceAsync {
        IPurchaseRepositoryAsync purchaseRepository;

        public PurchaseServiceAsync(IPurchaseRepositoryAsync _p)
        {
            purchaseRepository = _p;
        }

        public async Task<IEnumerable<Purchase>> Top10PurchasesByYearAsync() {
            List<Purchase> purchasesList = new List<Purchase>();
            var result = await purchaseRepository.Top10PurchasesByYearAsync();
            foreach (var item in result) {
                Purchase purchaseFields = new Purchase();
                purchaseFields.PurchaseId = item.PurchaseId;
                purchaseFields.UserId = item.UserId;
                purchaseFields.PurchaseNumber = item.PurchaseNumber;
                purchaseFields.TotalPrice = item.TotalPrice;
                purchaseFields.MovieId = item.MovieId;
                purchasesList.Add(purchaseFields);            
            }
            return purchasesList;
        }

        public async Task<IEnumerable<Purchase>> AllTimePurchasesAsync() {
            List<Purchase> purchasesList = new List<Purchase>();
            var result = await purchaseRepository.AllTimePurchasesAsync();
            foreach (var item in result) {
                Purchase purchaseFields = new Purchase();
                purchaseFields.PurchaseId = item.PurchaseId;
                purchaseFields.UserId = item.UserId;
                purchaseFields.PurchaseNumber = item.PurchaseNumber;
                purchaseFields.TotalPrice = item.TotalPrice;
                purchaseFields.MovieId = item.MovieId;
                purchasesList.Add(purchaseFields);            
            }
            return purchasesList; 
        }  
    }
}