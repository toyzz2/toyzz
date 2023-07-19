using System.Linq.Expressions;

namespace Toyzz.Domain.SeedWork;

public interface IRepository<T> where T : class
{
    Task<T?> FindById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> expression);

    Task Add(T entity);
    Task AddRange(IEnumerable<T> entities);

    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}