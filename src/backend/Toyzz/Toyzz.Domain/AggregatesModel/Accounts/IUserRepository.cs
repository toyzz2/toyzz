using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel.Accounts;

public interface IUserRepository : IRepository<User>
{
    public Task ChangePassword(int id, string oldPassword, string newPassword);
}