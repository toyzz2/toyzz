using Toyzz.Domain.AggregatesModel.Blogs;

namespace Toyzz.Infrastructure.Repositories;

public class BlogRepository : Repository<Blog>, IBlogRepository
{
    public BlogRepository(BlogContext dbContext) : base(dbContext)
    {
    }

    public async Task<Blog?> GetBlog(int id)
    {
        return await FindById(id);
    }

    public Task<Blog> GetBlogWithPost(int id)
    {
        throw new NotImplementedException();
    }
}