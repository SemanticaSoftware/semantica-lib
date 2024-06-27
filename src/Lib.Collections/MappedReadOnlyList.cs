using System.Collections;

namespace Semantica.Collections;

public class MappedReadOnlyList<TIn, TOut> : IReadOnlyList<TOut>
{
    private readonly Func<TIn, TOut> _mapFunc;
    private readonly IReadOnlyList<TIn> _list;

    public MappedReadOnlyList(IReadOnlyList<TIn> list, Func<TIn, TOut> mapFunc)
    {
        _list = list;
        _mapFunc = mapFunc;
    }

    public TOut this[int index] => _mapFunc(_list[index]);

    public int Count => _list.Count;

    public IEnumerator<TOut> GetEnumerator()
    {
        return _list.Select(_mapFunc).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}