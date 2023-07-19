using Toyzz.Domain.SeedWork;

namespace Toyzz.Domain.AggregatesModel;

/// <summary>
/// 菜单
/// </summary>
public class Menu : EntityBase
{
    public string Name { get; set; }
    public string Url { get; set; }
    public int ParentId { get; set; }

    public string Icon { get; set; }

    public int Sort { get; set; }

    public Menu AddMenu(string name, string url, string icon, int sort, int parentId = 0)
    {
        var menu = new Menu
        {
            Name = name,
            Url = url,
            ParentId = parentId,
            Icon = icon,
            Sort = sort
        };
        return menu;
    }


    public void UpdateMenu(string name, string url, string icon, int sort, int parentId = 0)
    {
        Name = name;
        Url = url;
        ParentId = parentId;
        Icon = icon;
        Sort = sort;
    }
}