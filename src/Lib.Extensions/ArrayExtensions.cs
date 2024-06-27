using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional methods for arrays.
/// </summary>
[Pure]
public static class ArrayExtensions
{
    public static int[] BitClone(this int[] array)
    {
        var result = new int[array.Length];
        Buffer.BlockCopy(array, 0, result, 0, array.Length * sizeof(int));
        return result;
    }
}
