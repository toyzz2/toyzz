using Toyzz.Domain.AggregatesModel.Blogs;

namespace Toyzz.Domain.SeedWork;

public interface IUnitOfWork : IDisposable
{
    // Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    // Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);

    IBlogRepository Blogs { get; }

    Task<int> Complete();
}