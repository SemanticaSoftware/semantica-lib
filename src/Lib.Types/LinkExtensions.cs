namespace Semantica.Types;

/// <summary>
/// Provides extension methods for <see cref="Link"/>.
/// </summary>
public static class LinkExtensions
{
    /// <summary>
    /// Checks technical validity of the email, using System.<see cref="Uri"/>.
    /// </summary>
    public static bool IsValid(this Link link)
    {
        var value = link.Value.Trim();
        try
        {
            return ((Uri)link).AbsoluteUri == value;
        }
        catch
        {
            return false;
        }
    }
}
