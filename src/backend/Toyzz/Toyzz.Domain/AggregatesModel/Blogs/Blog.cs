using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Blogs;

public class Blog:EntityBase
{
    /// <summary>
    ///     博客名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     加入时间
    /// </summary>
    public DateTime JoinDate { get; set; }

    /// <summary>
    ///     博客地址
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    ///     头像
    /// </summary>
    public string HeadPortrait { get; set; } = string.Empty;
}