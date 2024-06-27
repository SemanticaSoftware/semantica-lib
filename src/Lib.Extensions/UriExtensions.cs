using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for dates and times.
/// </summary>
[Pure]
public static class UriExtensions
{
    /// <summary>
    /// Combines a <see cref="Uri"/> with an additional path. Differs from the Uri constructor by appending the path even if the
    /// the Uri's path doesn't end with a slash. A slash is inserted in this case. 
    /// </summary>
    /// <param name="uri"> The input with the path to be expanded. </param>
    /// <param name="path"> The path-part to be added. If null, the original uri is returned. </param>
    /// <returns> A <see cref="Uri"/> with <paramref name="path"/> appended to the input's path. </returns>
    public static Uri Combine(this Uri uri, string? path)
    {
        if (path == null)
            return uri;
        if (uri.LocalPath.EndsWith('/'))
            return new Uri(uri, path);

        var builder = new UriBuilder(uri);
        builder.Path = $"{builder.Path}/{path}";
        return builder.Uri;
    }
}
