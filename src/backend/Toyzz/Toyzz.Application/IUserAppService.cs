namespace Toyzz.Application;

public interface IUserAppService : IAppService
{
    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="id"></param>
    /// <param name="oldPassword"></param>
    /// <param name="newPassword"></param>
    void ChangePassword(int id, string oldPassword, string newPassword);
}