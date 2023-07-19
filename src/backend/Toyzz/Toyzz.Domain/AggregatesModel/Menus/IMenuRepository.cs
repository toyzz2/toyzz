using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel;

public interface IMenuRepository : IRepository<Menu>
{
    /// <summary>
    /// 获取菜单列表
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task<IEnumerable<Menu>> GetMenuList();
}