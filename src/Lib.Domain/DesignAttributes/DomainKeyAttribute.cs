using Semantica.Checks;

namespace Semantica.Domain.DesignAttributes;

/// <summary>
/// Indicates a key struct for the domain. If used, the primaryKeyKind argument on the DomainModel attributes that
/// use the key can be omitted, as long as the interface <see cref="IDomainModel{TKey}"/> is implemented by the type.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
public class DomainKeyAttribute : Attribute
{
    public DomainKeyAttribute(KeyKind keyKind)
    {
        Guard.Contract(!keyKind.HasFlag(KeyKind.Foreign));
        KeyKind = keyKind | KeyKind.Unique;
    }

    public KeyKind KeyKind { get; } 
}
