namespace Semantica.Patterns;

#if NET7_0_OR_GREATER
[Obsolete]
#endif
public static class ArithmaticExtensions
{
    public static T Sum<T>(this IEnumerable<T> enumerable)
        where T : struct, IArithmatic<T>
    {
        using (var enumerator = enumerable.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return default(T);
            }

            var result = enumerator.Current;
            while (enumerator.MoveNext())
            {
                result = result.Add(enumerator.Current);
            }

            return result;
        }
    }
}
