using System.Collections;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

public static class GetEnumeratorHelperExtensions
{
    public static IEnumerable<T> ActGetEnumeratorGeneric<T>(this IEnumerable<T> enumerable)
    {
        using (var enumerator = enumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }
    }
        
    public static IEnumerable<T> ActGetEnumeratorNonGeneric<T>(this IEnumerable<T> enumerable)
    {
        var enumerator = ((IEnumerable) enumerable).GetEnumerator();
        while (enumerator.MoveNext())
        {
            yield return (T)enumerator.Current;
        }
    }
}