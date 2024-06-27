namespace Semantica.Domain;

public sealed class DomainModelComparer<TDomainModel, TKey> : IEqualityComparer<TDomainModel>
    where TDomainModel: IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    public bool Equals(TDomainModel? x, TDomainModel? y)
    {
        return y == null ? x == null : x?.Key.Equals(y.Key) ?? false;
    }

    public int GetHashCode(TDomainModel obj)
    {
        return obj.Key.GetHashCode();
    }
}