namespace Semantica.Extensions.Flags;

/// <summary>
/// Used to control conversion of PascalCase identifiers. 
/// </summary>
[Flags]
public enum CasingStyle
{
    /// <summary>
    /// When set, the transformation will keep all existing underscores.
    /// </summary>
    PreserveUnderscores = 1,
    /// <summary>
    /// When set, the transformation will treat an underscore the same as a word boundary.
    /// </summary>
    /// <remarks>
    /// The transformation detects a word boundary when it encounters an uppercase character, and the preceding character is
    /// lowercase.
    /// </remarks>
    UnderscoresAsBoundaries = 1 << 1,
    /// <summary>
    /// When set, all current casing is preserved, and the conversion will only add characters at word boundaries.
    /// </summary>
    PreserveCasing = 1 << 2,
    /// <summary>
    /// When set (and <see cref="PreserveCasing"/> is not set), all characters are converted to uppercase instead of lowercase.
    /// </summary>
    ToUpperCase = 1 << 3
}
