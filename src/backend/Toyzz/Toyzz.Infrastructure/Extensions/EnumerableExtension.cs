namespace Toyzz.Infrastructure.Extensions;

public static class EnumerableExtension
{
    public static IEnumerable<TreeItem<T>> GenerateTree<T, K>(
        this IEnumerable<T> collection,
        Func<T, K> idSelector,
        Func<T, K> parentIdSelector,
        K? rootId = default)
    {
        var enumerable = collection.ToList();
        foreach (var c in enumerable.Where(c => EqualityComparer<K>.Default.Equals(parentIdSelector(c), rootId)))
            yield return new TreeItem<T>
            {
                Item = c,
                Children = enumerable.GenerateTree(idSelector, parentIdSelector, idSelector(c))
            };
    }
}