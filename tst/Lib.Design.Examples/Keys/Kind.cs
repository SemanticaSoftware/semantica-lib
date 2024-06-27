namespace Semantica.Lib.Tests.Design.Examples.Keys;

/// <summary>
/// The kinds of <see cref="Layered.Domain.Models.Composite"/> entity elements that can exist for each
/// <see cref="Layered.Domain.Models.SimpleRoot"/> entity elements. It is part of the primary key for that entity.
/// </summary>
public enum Kind : ushort
{
    KindA = 'A',
    KindB = 'B'
}