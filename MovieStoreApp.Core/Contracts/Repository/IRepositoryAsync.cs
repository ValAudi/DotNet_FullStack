namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IRepositoryAsync<T> where T:class {
        Task<int> insertAsync(T entity);
        Task<int> updateAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
    }
}