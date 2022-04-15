namespace MovieStoreApp.Core.Contracts.Repository 
{
    public interface IRepository<T> where T:class {
        int insert(T entity);
        int update(T entity);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}