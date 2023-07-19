using Toyzz.Infrastructure;
using Toyzz.Infrastructure.Repositories;

namespace Toyzz.Domain.AggregatesModel.Accounts;

internal class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(BlogContext dbContext) : base(dbContext)
    {
    }


    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="id"></param>
    /// <param name="oldPassword"></param>
    /// <param name="newPassword"></param>
    /// <returns></returns>
    public async Task ChangePassword(int id, string oldPassword, string newPassword)
    {
        var user = await FindById(id);
        user.changepassword(oldPassword, newPassword);
        Update(user);
    }
}