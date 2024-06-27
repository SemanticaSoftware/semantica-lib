using System.Linq;
using Semantica.Checks;

namespace Semantica.Storage;

public static class QueryableInclusionExtensions
{
    public static IQueryable<TStorage> Include<TStorage>(this IQueryable<TStorage> queryable, IInclusion<TStorage> inclusion)
        where TStorage : class
    {
        Check.NotNull(inclusion).Contract();
        return inclusion.AddIncludesTo(queryable);
    }

    public static IQueryable<TStorage> IncludeIfNotNull<TStorage>(this IQueryable<TStorage> queryable, IInclusion<TStorage>? inclusion)
        where TStorage : class
    {
        return inclusion == null ? queryable : inclusion.AddIncludesTo(queryable);
    }
}
