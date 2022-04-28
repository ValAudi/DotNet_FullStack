using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Contracts.Services  
{
    public interface IPurchaseServiceAsync {
        Task<IEnumerable<Purchase>> Top10PurchasesByYearAsync();
        Task<IEnumerable<Purchase>> AllTimePurchasesAsync();
    }

}