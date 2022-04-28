using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IPurchaseRepositoryAsync: IRepositoryAsync<Purchase> {
        Task<IEnumerable<Purchase>> Top10PurchasesByYearAsync();
        Task<IEnumerable<Purchase>> AllTimePurchasesAsync();
    }
}