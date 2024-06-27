using System.Diagnostics.CodeAnalysis;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for lists.
/// </summary>
public static class ListExtensions
{
    /// <summary>
    /// Adds an item to the end of the list if it is not <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"> The type of items in <paramref name="list"/>. </typeparam>
    /// <param name="list"> The list to add to. </param>
    /// <param name="item"> The item to add. </param>
    /// <returns>
    /// <see langword="true"/> if the item was added; <see langword="false"/> if <paramref name="item"/> was
    /// <see langword="null"/>.
    /// </returns>
    public static bool AddIfNotNull<T>(this List<T> list, [NotNullWhen(true)] T? item)
    {
        if (item.IsNullOrDefault())
        {
            return false;
        }

        list.Add(item);
        return true;
    }
    
    /// <summary>
    /// Adds an item to the end of the list if it is not <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"> The type of items in <paramref name="list"/>. </typeparam>
    /// <param name="list"> The list to add to. </param>
    /// <param name="item"> The item to add. </param>
    /// <returns>
    /// <see langword="true"/> if the item was added; <see langword="false"/> if <paramref name="item"/> was
    /// <see langword="null"/>.
    /// </returns>
    public static bool AddIfNotNull<T>(this List<T> list, [NotNullWhen(true)] T? item)
        where T: struct
    {
        if (! item.HasValue)
        {
            return false;
        }

        list.Add(item.Value);
        return true;
    }

    /// <summary>
    /// Adds an enumeration of items to a <see cref="IList{T}"/>
    /// </summary>
    /// <typeparam name="T"> The type of items in <paramref name="list"/>. </typeparam>
    /// <param name="list"> The list to add to. </param>
    /// <param name="enumerable"> The items to add. </param>
    public static void AddRange<T>(this IList<T> list, IEnumerable<T> enumerable)
    {
        foreach (var item in enumerable)
        {
            list.Add(item);
        }
    }
}
