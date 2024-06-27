using System.Diagnostics.Contracts;

namespace Semantica.Core;

/// <summary>
/// Provides a number of static methods used for comparison of instances of types implementing <see cref="IComparable{T}"/>. 
/// </summary>
[Pure]
public static class Comparable
{
    /// <summary>
    /// Used to easily chain comparisons in a <see cref="IComparable{T}.CompareTo"/> implementation where there are multiple
    /// <see cref="IComparable{T}"/> properties used for comparison, utilizing the <c>??</c> operator.
    /// </summary>
    /// <param name="this">
    /// A <see cref="IComparable{T}"/> instance. (typically the property of <see langword="this"/>).
    /// </param>
    /// <param name="other">
    /// A <see cref="IComparable{T}"/> instance. (typically the property of <see langword="other"/>).
    /// </param>
    /// <example>
    /// <code>
    /// class MyClass: IComparable{MyClass} {
    ///     double A;
    ///     double B;
    ///
    ///     int Compare(MyClass other) {
    ///         return Comparable.CompareOrNull(A, other.A) ?? B.CompareTo(other.B); 
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <returns>
    /// <see langword="default(int?)"/> if both arguments are compared as equal, otherwise the result of the evaluation of
    /// <see cref="IComparable{T}.CompareTo"/> .
    /// </returns>
    public static int? CompareOrNull<T>(T @this, T other)
        where T: IComparable<T>
    {
        var compare = @this.CompareTo(other);                
        return compare == 0 ? default(int?) : compare;
    }

    /// <summary>
    /// Compares all arguments and returns the one that comes after all the others.
    /// </summary>
    /// <param name="array"> Any number of instances to evaluate. </param>
    /// <typeparam name="T"> Any type implementing <see cref="IComparable{T}"/>. </typeparam>
    /// <remarks> If multiple instances could be ordered last, the first one that was encountered would be returned. </remarks>
    /// <returns> The maximal instance: the one that becomes after all the others if they would be ordered. </returns>
    public static T Max<T>(params T[] array)
        where T : IComparable<T>
    {
        return array.Skip(1).Aggregate(array[0], (prev, next) => prev.CompareTo(next) > 0 ? prev : next);
    }

    /// <summary>
    /// Compares both arguments and returns the one that comes after the other.
    /// </summary>
    /// <param name="left"> First instance to evaluate. </param>
    /// <param name="right"> Second instance to evaluate. </param>
    /// <remarks> If the instances are ordered equal, <paramref name="left"/> is returned. </remarks>
    /// <typeparam name="T"> Any type implementing <see cref="IComparable{T}"/>. </typeparam>
    /// <returns> The maximal instance: the one that becomes after the other if they would be ordered. </returns>
    public static T Max<T>(T left, T right)
        where T : IComparable<T>
    {
        return left.CompareTo(right) < 0 ? right : left;
    }

    /// <summary>
    /// Compares all arguments and returns the one that comes before all the others.
    /// </summary>
    /// <param name="array"> Any number of instances to evaluate. </param>
    /// <typeparam name="T"> Any type implementing <see cref="IComparable{T}"/>. </typeparam>
    /// <remarks> If multiple instances could be ordered first, the first one that was encountered would be returned. </remarks>
    /// <returns> The minimal instance: the one that becomes before all the others if they would be ordered. </returns>
    public static T Min<T>(params T[] array)
        where T : IComparable<T>
    {
        return array.Skip(1).Aggregate(array[0], (prev, next) => prev.CompareTo(next) < 0 ? prev : next);
    }

    /// <summary>
    /// Compares both arguments and returns the one that comes before the other.
    /// </summary>
    /// <param name="left"> First instance to evaluate. </param>
    /// <param name="right"> Second instance to evaluate. </param>
    /// <remarks> If the instances are ordered equal, <paramref name="left"/> is returned. </remarks>
    /// <typeparam name="T"> Any type implementing <see cref="IComparable{T}"/>. </typeparam>
    /// <returns> The minimal instance: the one that becomes before the other if they would be ordered. </returns>
    public static T Min<T>(T left, T right)
        where T : IComparable<T>
    {
        return left.CompareTo(right) > 0 ? right : left;
    }

    /// <summary>
    /// Used to implement comparisons in a <see cref="IComparable{T}.CompareTo"/> implementation where the properties used for
    /// comparison do not always have values.  
    /// </summary>
    /// <param name="thisHasValue">
    /// <see langword="bool"/> indicating whether the left argument has a value (typically the value of <see langword="this"/>).
    /// </param>
    /// <param name="otherHasValue">
    /// <see langword="bool"/> indicating whether the right argument has a value (typically the value of other).
    /// </param>
    /// <param name="val"> Out parameter containing the comparison result. </param>
    /// <param name="noValueIsBigger">
    /// When <see langword="true"/>, a value is always considered smaller than no value. Default <see langword="false"/>.
    /// </param>
    /// <example>
    /// <code>
    /// class MyClass: IComparable{MyClass} {
    ///     double? A;
    ///
    ///     int Compare(MyClass other) {
    ///         return Comparable.TryCompareValue(A.HasValue, other.A.HasValue, out int val) ? val : A.Value.CompareTo(other.A.Value); 
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <returns>
    /// <see langword="true"/> if the comparison can be made on the basis of <see cref="Nullable{T}.HasValue"/> alone.
    /// <see langword="false"/> if both arguments have values, and the comparison has to be made on the actual values.
    /// </returns>
    public static bool TryCompareHasValue(bool thisHasValue, bool otherHasValue, out int val, bool noValueIsBigger = false)
    {
        if (thisHasValue)
        {
            if (otherHasValue)
            {
                val = 0;
                return false;
            }
            
            val = noValueIsBigger ? 1 : -1;
        }
        else if (otherHasValue)
        {
            val = noValueIsBigger ? -1 : 1;
        }
        else
        {
            val = 0;
        }
        return true;
    }
    
    /// <summary>
    /// Used to implement comparisons in a <see cref="IComparable{T}.CompareTo"/> implementation where the properties used for
    /// comparison can be empty.  
    /// </summary>
    /// <param name="thisIsEmpty">
    /// <see langword="bool"/> indicating whether the left argument is empty (typically the value of <see langword="this"/>).
    /// </param>
    /// <param name="otherIsEmpty">
    /// <see langword="bool"/> indicating whether the right argument is empty (typically the value of other).
    /// </param>
    /// <param name="val"> Out parameter containing the comparison result. </param>
    /// <param name="emptyIsSmaller">
    /// When <see langword="false"/>, an empty value is always considered larger than no value. Default <see langword="true"/>.
    /// </param>
    /// <example>
    /// <code>
    /// class MyClass: IComparable{MyClass} {
    ///     string A;
    ///
    ///     int Compare(MyClass other) {
    ///         return Comparable.TryCompareValue(string.IsNullOrEmpty(A), string.IsNullOrEmpty(other.A), out int val) ? val : A.CompareTo(other.A); 
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <returns>
    /// <see langword="true"/> if the comparison can be made on the basis of empty/not empty alone.
    /// <see langword="false"/> if both have values, and the comparison has to be made on the actual values.
    /// </returns>
    public static bool TryCompareIsEmpty(bool thisIsEmpty, bool otherIsEmpty, out int val, bool emptyIsSmaller = true)
    {
        return TryCompareHasValue(!thisIsEmpty, !otherIsEmpty, out val, !emptyIsSmaller);
    }
}