using Semantica.Checks;

namespace Semantica.Order;

public static class QueryableOrderExtensions
{


    public static IOrderedQueryable<TStorage> OrderBy<TStorage, TOrderProp>(this IQueryable<TStorage> queryable, Order<TStorage, TOrderProp> orderBy)
        where TStorage : class
        where TOrderProp : IComparable<TOrderProp>
    {
        Check.Not(orderBy.None).Contract("Kan geen orderBy aangeven op orderBy.None");
        return orderBy.OrderDescending ? queryable.OrderByDescending(orderBy.Func) : queryable.OrderBy(orderBy.Func);
    }

    public static IOrderedQueryable<TStorage> ThenBy<TStorage, TOrderProp>(this IOrderedQueryable<TStorage> queryable, Order<TStorage, TOrderProp> orderBy)
        where TStorage : class
        where TOrderProp : IComparable<TOrderProp>
    {
        Check.Not(orderBy.None).Contract("Kan geen orderBy aangeven op orderBy.None");
        return orderBy.OrderDescending ? queryable.ThenByDescending(orderBy.Func) : queryable.ThenBy(orderBy.Func);
    }

    public static IQueryable<TStorage> OrderByConditional<TStorage, TOrderProp>(this IQueryable<TStorage> queryable, Order<TStorage, TOrderProp> orderBy)
        where TStorage : class
        where TOrderProp : IComparable<TOrderProp>
    {
        return orderBy.None ? queryable : queryable.OrderBy(orderBy);
    }

    public static IQueryable<TStorage> OrderByThenByConditional<TStorage, TOrderProp, TThenProp>(this IQueryable<TStorage> queryable, Order<TStorage, TOrderProp> orderBy, Order<TStorage, TThenProp> thenBy)
        where TStorage : class
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>
    {
        return orderBy.None ? queryable : thenBy.None ? queryable.OrderBy(orderBy) : queryable.OrderBy(orderBy).ThenBy(thenBy);
    }
}