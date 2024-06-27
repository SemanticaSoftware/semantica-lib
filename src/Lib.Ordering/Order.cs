using System.Linq.Expressions;

namespace Semantica.Order;

public readonly struct Order<TStorage, TProp>
    where TStorage: class
    where TProp: IComparable<TProp>
{
    public Order(Expression<Func<TStorage, TProp>> func, bool orderDescending)
    {
        Func = func;
        OrderDescending = orderDescending;
    }

    public Expression<Func<TStorage, TProp>> Func { get; }
        
    public bool OrderDescending { get; }

    public bool None => Func == null;

    public Order<TStorage, TProp> Descending()
    {
        return new Order<TStorage, TProp>(Func, true);
    }
}

public static class Order
{
    public static Order<TStorage, TProp> By<TStorage, TProp>(Expression<Func<TStorage, TProp>> func)
        where TStorage : class
        where TProp : IComparable<TProp>
    {
        return new Order<TStorage, TProp>(func, false);
    }
}
