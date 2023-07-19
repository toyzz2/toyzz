using Toyzz.Domain.AggregatesModel.Blogs;
using Toyzz.Domain.SeedWork;

namespace Toyzz.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly BlogContext _context;

    public UnitOfWork(BlogContext context)
    {
        _context = context;
        Blogs = new BlogRepository(context);
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IBlogRepository Blogs { get; }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }
}