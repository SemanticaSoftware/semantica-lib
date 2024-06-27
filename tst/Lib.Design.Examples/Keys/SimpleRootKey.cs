using Semantica.Domain.DesignAttributes;
using Semantica.Patterns.Domain;

namespace Semantica.Lib.Tests.Design.Examples.Keys;

[DomainKey(KeyKind.Id)]
public readonly record struct SimpleRootKey(int Id) : IIdentityKey<SimpleRootKey>
{
    public bool IsEmpty() => Equals(default);

    public int? AsNullableId() => IsEmpty() ? default(int?) : Id;

    public static SimpleRootKey FromNullableId(int? id) => id.HasValue ? new(id.Value) : default;
}