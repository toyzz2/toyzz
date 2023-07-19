using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Accounts;

public class Role : EntityBase
{
    private string Name { get; set; }

    private string Description { get; set; }

    public List<Permission> Permissions { get; set; }

    public int UserId { get; set; }
}