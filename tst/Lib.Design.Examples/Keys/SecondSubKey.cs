using Semantica.Domain.DesignAttributes;
using Semantica.Patterns;
using Semantica.Patterns.Domain;

namespace Semantica.Lib.Tests.Design.Examples.Keys;

[DomainKey(KeyKind.ForeignId)]
public readonly record struct SecondSubKey(SimpleRootKey Key) : ICanBeEmpty, ISubKey<SimpleRootKey>
{
    public bool IsEmpty() => Key.IsEmpty();
}
