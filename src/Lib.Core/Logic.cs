using System.Diagnostics.Contracts;

namespace Semantica.Core;

/// <summary>
/// Provides a number of static methods used for logic (<see cref="Boolean"/>) operations that are not natively supported. 
/// </summary>
[Pure]
public static class Logic
{
    /// <summary>
    /// Determines if of the provided booleans, exactly one is <see langword="true"/>.
    /// </summary>
    /// <param name="bools"> Any number of <see langword="bool"/> parameters. </param>
    /// <returns>
    /// <see langword="true"/> if and only if one of the parameters is <see langword="true"/>, and all others are
    /// <see langword="false"/>.
    /// </returns>
    public static bool ExactlyOne(params bool[] bools)
    {
        var foundOne = false;
        foreach (var b in bools)
        {
            if (foundOne && b)
            {
                return false;
            }
            foundOne |= b;
        }
        return foundOne;
    }

    /// <summary>
    /// Determines if of the provided booleans, all are <see langword="false"/>.
    /// </summary>
    /// <param name="bools"> Any number of <see langword="bool"/> parameters. </param>
    /// <remarks> Logically equivalent to <c>! param1 &amp;&amp; ! param2 &amp;&amp; (...)</c>. </remarks>
    /// <returns> <see langword="true"/> if and only if all of the parameters are <see langword="false"/>. </returns>
    public static bool None(params bool[] bools)
    {
        return bools.All(b => !b);
    }

    /// <summary>
    /// Determines if of the provided booleans, none or exactly one is <see langword="true"/>.
    /// </summary>
    /// <param name="bools"> Any number of <see langword="bool"/> parameters. </param>
    /// <returns>
    /// <see langword="true"/> if and only if zero or one of the parameters are <see langword="true"/>, and all others are
    /// <see langword="false"/>.
    /// </returns>
    public static bool NoneOrOne(params bool[] bools)
    {
        var foundOne = false;
        foreach (var b in bools)
        {
            if (foundOne && b)
            {
                return false;
            }
            foundOne |= b;
        }
        return true;
    }

    /// <summary>
    /// Determines if the provided booleans follow from <paramref name="if"/>
    /// [<paramref name="if"/> -&gt; <paramref name="bools"/>].
    /// </summary>
    /// <param name="if"> The <see langword="bool"/> parameter to be tested. </param>
    /// <param name="bools"> Any number of <see langword="bool"/> parameters. </param>
    /// <returns>
    /// <see langword="true"/> if either <paramref name="if"/> is <see langword="false"/>, or <paramref name="if"/> and all
    /// <paramref name="bools"/> are <see langword="true"/>.
    /// </returns>
    public static bool Follows(bool @if, params bool[] bools)
    {
        return !@if || bools.All(b => b);
    }
}
