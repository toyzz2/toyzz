using Microsoft.EntityFrameworkCore;
using Toyzz.Domain.AggregatesModel.Accounts;
using Toyzz.Domain.AggregatesModel.Blogs;
using Toyzz.Domain.AggregatesModel.Posts;
using Toyzz.Infrastructure.EntityConfigurations;

namespace Toyzz.Infrastructure;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<User> Accounts { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BlogConfiguration());
    }
}