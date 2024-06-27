using Semantica.Checks;

namespace Semantica.Order;

public static class EnumerableOrderExtensions
{
    public static IOrderedEnumerable<T> OrderBy<T, TOrderProp>(this IEnumerable<T> enumerable, Order<T, TOrderProp> orderBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
    {
        Check.Not(orderBy.None).Guard("Kan geen orderBy aangeven op orderBy.None");
        return orderBy.OrderDescending ? enumerable.OrderByDescending(orderBy.Func.Compile()) : enumerable.OrderBy(orderBy.Func.Compile());
    }

    public static IOrderedEnumerable<T> ThenBy<T, TOrderProp>(this IOrderedEnumerable<T> enumerable, Order<T, TOrderProp> orderBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
    {
        Check.Not(orderBy.None).Guard("Kan geen orderBy aangeven op orderBy.None");
        return orderBy.OrderDescending ? enumerable.ThenByDescending(orderBy.Func.Compile()) : enumerable.ThenBy(orderBy.Func.Compile());
    }

    public static IEnumerable<T> OrderByConditional<T, TOrderProp>(this IEnumerable<T> enumerable, Order<T, TOrderProp> orderBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
    {
        return orderBy.None ? enumerable : enumerable.OrderBy(orderBy);
    }

    public static IEnumerable<T> OrderByThenByConditional<T, TOrderProp, TThenProp>(this IEnumerable<T> enumerable, Order<T, TOrderProp> orderBy, Order<T, TThenProp> thenBy)
        where T : class
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>
    {
        return orderBy.None ? enumerable : thenBy.None ? enumerable.OrderBy(orderBy) : enumerable.OrderBy(orderBy).ThenBy(thenBy);
    }
}
