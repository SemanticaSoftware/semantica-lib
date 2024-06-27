using Semantica.Patterns;
using Semantica.Patterns.Domain;

namespace Semantica.Domain;

public static class IdKeyExtensions
{

    public static IEnumerable<TId> SelectId<T, TId>(this IEnumerable<T> keys)
        where T : IIdKey<TId>
        where TId : struct, IEquatable<TId>
    {
        return keys.Select(static key => key.Id);
    }

    public static IReadOnlyList<TId> ToFilteredIdArray<T, TId>(this IEnumerable<T> keys)
        where T : IIdKey<TId>, ICanBeEmpty
        where TId : struct, IEquatable<TId>
    {
        return keys.WhereNotEmpty()
                   .SelectId<T, TId>()
                   .ToReadOnlyList();
    }

    public static IReadOnlyList<int> ToFilteredIdArray<T>(this IEnumerable<T> keys)
        where T : IIdKey<int>, ICanBeEmpty
    {
        return keys.ToFilteredIdArray<T, int>();
    }

    public static TId[] ToIdArray<T, TId>(this IReadOnlyCollection<T> keys)
        where T : IIdKey<TId> 
        where TId : struct, IEquatable<TId>
    {
        return keys.SelectArray(static key => key.Id);
    }
    
    public static int[] ToIdArray<T>(this IReadOnlyCollection<T> keys)
        where T : IIdKey<int>
    {
        return keys.ToIdArray<T, int>();
    }
}
