using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Posts;

public class Post : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public int BlogId { get; set; }
}