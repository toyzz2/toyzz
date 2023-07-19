using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Accounts;

/// <summary>
/// 权限
/// </summary>
public class Permission : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Permission(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public Permission()
    {
    }
}