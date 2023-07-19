namespace Toyzz.Infrastructure.Extensions;

public class TreeItem<T>
{
    public T Item { get; set; } = default!;
    public IEnumerable<TreeItem<T>> Children { get; set; } = new List<TreeItem<T>>();
}