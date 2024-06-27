using Semantica.Domain.DesignAttributes;

namespace Semantica.Lib.Tests.Design.Examples.Keys;

[DomainKey(KeyKind.Primary | KeyKind.Composite)]
public readonly record struct CompositeKey(SimpleRootKey ForeignKey, Kind Kind)
{ }