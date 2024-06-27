using System.Collections;

namespace Semantica.Collections;

public class EmptyList<T> : IReadOnlyList<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        yield break;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => 0;

    public T this[int index] => throw new ArgumentOutOfRangeException(nameof(index));        
}
