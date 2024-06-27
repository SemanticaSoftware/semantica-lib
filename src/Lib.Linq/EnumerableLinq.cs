using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using JetBrains.Annotations;
using Semantica.Checks;
using Semantica.Core;

namespace Semantica.Linq;

/// <summary> Provides additional functionality to <see cref="IEnumerable{T}"/> collections. </summary>
public static partial class EnumerableLinq
{
    /// <summary> Determines whether all elements of a non-empty sequence satisfy a condition. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to check. </param>
    /// <param name="predicate"> A function to test each element for a condition. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="source"/> contains at least one element and
    /// <paramref name="predicate"/> returns <see langword="true"/> for all elements; <see langword="false"/> otherwise.
    /// </returns>
    public static bool AnyAndAll<T>([InstantHandle] this IEnumerable<T> source, [InstantHandle] Func<T, bool> predicate)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return false;
            }
            do
            {
                if (!predicate(enumerator.Current))
                {
                    return false;
                }
            } while (enumerator.MoveNext());
            return true;
        }
    }

    /// <summary>
    /// Returns an enumerable as a <see cref="IReadOnlyCollection{T}"/>. If the passed class can be, it will be cast, otherwise
    /// the enumeration is converted to a new collection. 
    /// </summary>
    /// <param name="source"> A sequence of elements. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> A <see cref="IReadOnlyCollection{T}"/> that is a new instance only if it cannot be cast. </returns>
    public static IReadOnlyCollection<T> AsReadOnlyCollection<T>([InstantHandle] this IEnumerable<T> source)
    {
        return source switch {
            IReadOnlyCollection<T> collection => collection,
            _ => source.ToReadOnlyList()
        };
    }

    /// <summary>
    /// Returns an enumerable as a <see cref="IReadOnlyList{T}"/>. If the passed class can be, it will be cast, otherwise
    /// the enumeration is converted to a new list. 
    /// </summary>
    /// <param name="source"> A sequence of elements. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> A <see cref="IReadOnlyList{T}"/> that is a new instance only if it cannot be cast. </returns>
    public static IReadOnlyList<T> AsReadOnlyList<T>([InstantHandle] this IEnumerable<T> source)
    {
        return source switch {
            IReadOnlyList<T> collection => collection,
            _ => source.ToReadOnlyList()
        };
    }
    
    /// <summary>
    /// Just enumerates all elements of the IEnumerable without doing or returning anything.
    /// </summary>
    public static void Enumerate<T>([InstantHandle] this IEnumerable<T> source)
    {
        using (var enumerator = source.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
            }
        }
    }

    /// <summary>
    /// Returns the first element that satisfies a condition in a projection of the collection.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to project and find. </param>
    /// <param name="selector"> A transform function to apply to each element. </param>
    /// <param name="predicate"> A function to test each element of the projection for a condition. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the projection. </typeparam>
    /// <returns>
    /// A tuple that contains the first element that satisfies <paramref name="predicate"/> in a list of items selected by
    /// <paramref name="selector"/>, and the associated element in <paramref name="source"/>. If no elements match
    /// <paramref name="predicate"/>, returns a tuple with a default value.
    /// </returns>
    public static (TOut?, T?) FirstOrDefaultOfFirst<T, TOut>([InstantHandle] this IEnumerable<T> source,
        [InstantHandle] Func<T, IEnumerable<TOut>> selector,
        [InstantHandle] Func<TOut, bool> predicate)
    {
        foreach (var element in source)
        {
            var subItems = selector(element);
            foreach (var item in subItems)
            {
                if (predicate(item))
                {
                    return (item, element);
                }
            }
        }
        return (default, default);
    }

    /// <summary>
    /// Determines if the provided booleans follow from <paramref name="if"/> [<paramref name="if"/> -&gt;
    /// <paramref name="source"/>].
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> of <see langword="bool"/> values. </param>
    /// <param name="if"> The <see langword="bool"/> parameter to be tested. </param>
    /// <returns>
    /// <see langword="true"/> if either <paramref name="if"/> is <see langword="false"/>, or <paramref name="if"/> and all
    /// elements of <paramref name="source"/> are <see langword="true"/>.
    /// </returns>
    public static bool FollowFrom([InstantHandle] this IEnumerable<bool> source, bool @if)
    {
        return !@if || source.All(StaticSelectors.Self);
    }

    /// <summary>
    /// Determines if the provided booleans follow from <paramref name="if"/>
    /// [<paramref name="if"/> -&gt; <paramref name="predicate"/>(<paramref name="source"/>)].
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> of elements to evaluate. </param>
    /// <param name="predicate"> The predicate used to evaluate the elements of <paramref name="source"/>. </param>
    /// <param name="if"> The <see langword="bool"/> parameter to be tested. </param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <returns>
    /// <see langword="true"/> if either <paramref name="if"/> is <see langword="false"/>, or <paramref name="if"/> and all
    /// <paramref name="source"/> pass <paramref name="predicate"/>.
    /// </returns>
    public static bool FollowFrom<T>([InstantHandle] this IEnumerable<T> source,
        [InstantHandle] Func<T, bool> predicate,
        bool @if)
    {
        return !@if || source.All(predicate);
    }

    /// <summary>
    /// Determines whether the sequence contains exactly <paramref name="count"/> elements.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to count. </param>
    /// <param name="count">The expected number of elements in <paramref name="source"/>.</param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="source"/> contains exactly <paramref name="count"/> elements;
    /// otherwise, if <paramref name="source"/> contains less or more elements, returns <see langword="false"/>.
    /// </returns>
    public static bool HasCount<T>([InstantHandle] this IEnumerable<T> source, int count)
    {
        Check.NotNegative(count).Guard();
        using (var enumerator = source.GetEnumerator())
        {
            for (var i = count; i > 0; --i)
            {
                if (!enumerator.MoveNext())
                {
                    return false;
                }
            }

            return !enumerator.MoveNext();
        }
    }

    /// <summary>
    /// Determines whether the sequence contains exactly <paramref name="count"/> elements that satisfy a condition.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to count. </param>
    /// <param name="count"> The expected number of elements in <paramref name="source"/>. </param>
    /// <param name="predicate"> A function to test each element for a condition. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="source"/> contains exactly <paramref name="count"/> elements for which
    /// <paramref name="predicate"/> returns <see langword="true"/>; <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasCount<T>([InstantHandle] this IEnumerable<T> source,
        int count,
        [InstantHandle] Func<T, bool> predicate)
    {
        return source.Where(predicate).HasCount(count);
    }

    /// <summary>
    /// Determines whether the enumeration contains either no elements, or exactly one element.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/>. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the input contains exactly zero or one elements; <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasNoneOrOne<T>([InstantHandle] this IEnumerable<T> source)
    {
        using (var enumerator = source.GetEnumerator())
        {
            return !enumerator.MoveNext() || !enumerator.MoveNext();
        }
    }

    /// <summary>
    /// Determines whether the enumeration contains either no elements, or exactly one element for which
    /// <paramref name="predicate"/> evaluates to <see langword="true"/>.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/>. </param>
    /// <param name="predicate"> A predicate that accepts an element of type <typeparamref name="T"/>. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the input contains exactly zero or one elements that satisfy the predicate;
    /// <see langword="false"/> otherwise.
    /// </returns>
    public static bool HasNoneOrOne<T>([InstantHandle] this IEnumerable<T> source, [InstantHandle] Func<T, bool> predicate)
    {
        return source.Where(predicate).HasNoneOrOne();
    }

    /// <summary>
    /// The one element of the input sequence, or default( <typeparamref name="T"/>) if the sequence contains no elements or
    /// more than one element.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/>. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <remarks>
    /// Note that <see cref="Enumerable.SingleOrDefault{T}(IEnumerable{T})"/> will throw when the sequence contains more than
    /// one element, whereas this extension will return <see langword="default"/>.
    /// </remarks>
    public static T? OneOrDefault<T>([InstantHandle] this IEnumerable<T> source)
    {
        using (var enumerator = source.GetEnumerator())
        {
            return enumerator.TryMoveNext(out var firstElement) && !enumerator.MoveNext() ? firstElement : default;
        }
    }

    /// <summary>
    /// The one element of the input sequence, or default(<typeparamref name="T"/>) if the sequence contains no elements or
    /// more than one element that satisfy <paramref name="predicate"/>.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/>. </param>
    /// <param name="predicate"> A predicate that accepts an element of type <typeparamref name="T"/>. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    public static T? OneOrDefault<T>([InstantHandle] this IEnumerable<T> source, [InstantHandle] Func<T, bool> predicate)
    {
        return source.Where(predicate).OneOrDefault();
    }

    /// <summary> Computes the sum of a sequence of <see cref="short"/> values. </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> of <see cref="short"/> values to calculate the sum of.
    /// </param>
    /// <exception cref="OverflowException"> The sum of values exceeds <see cref="short.MaxValue"/>. </exception>
    /// <returns> The sum of values in <paramref name="source"/>. </returns>
    public static short Sum([InstantHandle] this IEnumerable<short> source)
    {
        var sum = source.Select(Convert.ToInt32).Sum();
        if (sum > Int16.MaxValue)
        {
            throw new OverflowException("Sum of shorts exceeds short.MaxValue");
        }

        return (short)sum;
    }

#if NET7_0_OR_GREATER
    /// <summary>Computes the sum of a sequence of <typeparamref name="T"/> values.</summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/> of values to calculate the sum of.</param>
    /// <returns>The sum of values in <paramref name="source"/>.</returns>
    public static T? Sum<T>([InstantHandle] this IEnumerable<T> source)
        where T: IAdditionOperators<T, T, T>
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return default(T);
            }

            var result = enumerator.Current;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }

            return result;
        }
    }

    /// <summary>Computes the sum of a sequence of <typeparamref name="TSource"/> elements.</summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/> of values to calculate the sum of.</param>
    /// <param name="selector">A function that selects the <typeparamref name="TValue"/> value from an element.</param>
    /// <returns>The sum of values selected from <paramref name="source"/>.</returns>
    public static TValue? Sum<TSource, TValue>([InstantHandle] this IEnumerable<TSource> source, Func<TSource, TValue> selector)
        where TValue: IAdditionOperators<TValue, TValue, TValue>
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return default(TValue);
            }

            var result = selector(enumerator.Current);
            while (enumerator.MoveNext())
            {
                result += selector(enumerator.Current);
            }

            return result;
        }
    } 
    
#endif
    /// <summary>
    /// Gets the first element of the enumerable and puts it in the out parameter. Returns false if the enumerable had no
    /// elements.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the item to find. </param>
    /// <param name="first">
    /// When this method returns <see langword="true"/>, contains the first item in <paramref name="source"/>.
    /// </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="source"/> contains at least one item; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TryFirst<T>([InstantHandle] this IEnumerable<T> source, [NotNullWhen(returnValue: true)] out T? first)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (enumerator.MoveNext())
            {
                first = enumerator.Current!;
                return true;
            }
        }

        first = default;
        return false;
    }

    /// <summary>
    /// Retrieves the element that precedes the first element that satisfies a condition, and returns a value indicating
    /// whether such an element exists.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the items to find. </param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="element">
    /// When this method returns <see langword="true"/>, contains the item that precedes the first item for which
    /// <paramref name="predicate"/> returns <see langword="true"/>.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="predicate"/> returned <see langword="true"/> for an element in
    /// <paramref name="source"/>; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TryPrevious<T>([InstantHandle] this IEnumerable<T> source,
        [InstantHandle] Func<T, bool> predicate,
        [NotNullWhen(returnValue: true)] out T? element)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (enumerator.MoveNext())
            {
                var previous = enumerator.Current;
                while (enumerator.MoveNext())
                {
                    if (predicate(enumerator.Current))
                    {
                        element = previous!;
                        return true;
                    }

                    previous = enumerator.Current;
                }
            }
            element = default;
            return false;
        }
    }

    /// <summary>
    /// Retrieves the only element in the sequence, and returns a value indicating whether the operation succeeded.
    /// </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that may or may not contain a single item. </param>
    /// <param name="matchedElement">
    /// When this method returns <see langword="true"/>, contains the only item in <paramref name="source"/>.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="source"/> only contains one item; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TrySingle<T>([InstantHandle] this IEnumerable<T> source, [NotNullWhen(returnValue: true)] out T? matchedElement)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                matchedElement = default;
                return false;
            }

            matchedElement = enumerator.Current;
            return !enumerator.MoveNext();
        }
    }
}
