using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Toyzz.Domain.AggregatesModel.Blogs;

namespace Toyzz.Infrastructure.EntityConfigurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.HasData(Enumerable.Range(1, 10).Select(x => new Blog
        {
            Id = x,
            Name = $"name_{x}",
            JoinDate = DateTime.Now,
            Url = $"http://5000:name_{x}",
            HeadPortrait = ""
        }));
    }
}