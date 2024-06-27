namespace Semantica.Domain.Electives;

[Flags]
public enum LoadKind : byte
{
    /// <summary>
    /// Flag that indicates whether the elective property has been assigned (loaded).
    /// </summary>
    Loaded = 1,
    /// <summary>
    /// Flag that indicates whether the elective collection contains all associated elements from the system, and is not
    /// additionally filtered. 
    /// </summary>
    Unfiltered = 1 << 1,
}
