using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Toyzz.Domain.SeedWork;

namespace Toyzz.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly BlogContext DbContext;

    public Repository(BlogContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<T?> FindById(int id)
    {
        return await DbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await DbContext.Set<T>().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> expression)
    {
        return await DbContext.Set<T>().Where(expression).ToListAsync();
    }

    public async Task Add(T entity)
    {
        await DbContext.Set<T>().AddAsync(entity);
    }

    public async Task AddRange(IEnumerable<T> entities)
    {
        await DbContext.Set<T>().AddRangeAsync(entities);
    }

    public void Remove(T entity)
    {
        DbContext.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        DbContext.Set<T>().RemoveRange(entities);
    }
}