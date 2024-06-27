using JetBrains.Annotations;
using Semantica.Patterns;

namespace Semantica.Domain;

public static class DomainModelExtensions
{
    public static TModel FirstModel<TModel, TKey>([InstantHandle] this IEnumerable<TModel> enumerable, TKey key)
        where TModel : IDomainModel<TKey>
        where TKey : struct, IEquatable<TKey>, ICanBeEmpty
    {
        return key.IsEmpty() 
            ? throw new InvalidOperationException("Unexpected empty key.") 
            : enumerable.First(model => key.Equals(model.Key));
    }
    
    public static TModel? FirstOrDefaultModel<TModel, TKey>([InstantHandle] this IEnumerable<TModel> enumerable, TKey key)
        where TModel : IDomainModel<TKey>
        where TKey : struct, IEquatable<TKey>, ICanBeEmpty
    {
        return key.IsEmpty() ? default : enumerable.FirstOrDefault(model => key.Equals(model.Key));
    }

    [LinqTunnel]
    public static IEnumerable<TKey> SelectKeys<TKey>(this IEnumerable<IDomainModel<TKey>> sourceList)
        where TKey : struct, IEquatable<TKey>
    {
        return sourceList.Select(static model => model.Key);
    }

    [LinqTunnel]
    public static IEnumerable<TModel> SelectModels<TModel, TKey>(this IEnumerable<TKey> keys, IReadOnlyCollection<TModel> models)
        where TModel : class, IDomainModel<TKey>
        where TKey : struct, IEquatable<TKey>, ICanBeEmpty
    {
        return keys.Select(models.FirstOrDefaultModel<TModel, TKey>).WhereNotNull();
    }

    public static TKey[] ToKeyArray<TKey>([InstantHandle] this IEnumerable<IDomainModel<TKey>> models)
        where TKey : struct, IEquatable<TKey>
    {
        return models.Select(static model => model.Key).ToArray();
    }

    public static TKey[] ToKeyArray<TKey>(this IReadOnlyCollection<IDomainModel<TKey>> models)
        where TKey : struct, IEquatable<TKey>
    {
        return models.SelectArray(static model => model.Key);
    }

    public static IReadOnlyDictionary<TKey, TModel> ToKeyDictionary<TKey, TModel>([InstantHandle] this IEnumerable<TModel> models)
        where TModel : IDomainModel<TKey>
        where TKey : struct, IEquatable<TKey>
    {
        return models.ToDictionary(static model => model.Key);
    }
}
