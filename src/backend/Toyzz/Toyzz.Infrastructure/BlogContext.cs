using Microsoft.EntityFrameworkCore;
using Toyzz.Domain.AggregatesModel.Blogs;
using Toyzz.Infrastructure.EntityConfigurations;

namespace Toyzz.Infrastructure;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BlogConfiguration());
    }
}