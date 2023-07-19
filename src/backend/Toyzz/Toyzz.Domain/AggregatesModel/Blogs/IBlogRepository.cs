using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Blogs;

public interface IBlogRepository : IRepository<Blog>
{
    public Task<Blog?> GetBlog(int id);

    public Task<Blog> GetBlogWithPost(int id);
}