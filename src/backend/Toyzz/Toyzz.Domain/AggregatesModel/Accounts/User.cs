namespace Toyzz.Domain.AggregatesModel.Accounts;

public class User
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public List<Role> Roles { get; private set; } = new();
    public List<Permission> Permissions { get; private set; } = new();

    /// <summary>
    /// 修改密码
    /// </summary>
    /// <param name="oldPassword"></param>
    /// <param name="newPassword"></param>
    /// <exception cref="Exception"></exception>
    public void changepassword(string oldPassword, string newPassword)
    {
        if (oldPassword != Password) throw new Exception("Old password is incorrect");

        Password = newPassword;
    }
}