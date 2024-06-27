namespace Semantica.Order;

public static class ListOrderExtensions
{
    public static IReadOnlyList<T> OrderByConditional<T, TOrderProp>(this IReadOnlyList<T> list, Order<T, TOrderProp> orderBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
    {
        return orderBy.None ? list : list.OrderBy(orderBy).ToList();
    }

    public static IReadOnlyList<T> OrderByThenByConditional<T, TOrderProp, TThenProp>(this IReadOnlyList<T> list, Order<T, TOrderProp> orderBy, Order<T, TThenProp> thenBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>
    {
        return orderBy.None ? list : thenBy.None ? list.OrderBy(orderBy).ToList() : list.OrderBy(orderBy).ThenBy(thenBy).ToList();
    }
}
