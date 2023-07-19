using Toyzz.Infrastructure;
using Toyzz.Infrastructure.Repositories;

namespace Toyzz.Domain.AggregatesModel;

internal class MenuRepository : Repository<Menu>, IMenuRepository
{
    public MenuRepository(BlogContext dbContext) : base(dbContext)
    {
    }

    public async Task<Menu> GetMenuByIdAsync(int id)
    {
        return await FindById(id);
    }

    public async Task<IEnumerable<Menu>> GetMenuList()
    {
        return await GetAll();
    }
}