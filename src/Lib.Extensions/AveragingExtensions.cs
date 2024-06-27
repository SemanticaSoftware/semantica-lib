using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

public static class AveragingExtensions
{
    /// <summary>
    /// Partitions the given list around a pivot element such that all elements on left of pivot are &lt;= pivot
    /// and the ones at thr right are > pivot. This method can be used for sorting, N-order statistics such as
    /// as median finding algorithms.
    /// Pivot is selected randomly if random number generator is supplied else its selected as last element in the list.
    /// Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 171
    /// </summary>
    private static int Partition<T>(this IList<T> list, int start, int end, Random? rnd = null)
        where T : IComparable<T>
    {
        if (rnd != null)
        {
            list.Swap(end, rnd.Next(start, end + 1));
        }

        var pivot = list[end];
        var lastLow = start - 1;
        for (var i = start; i < end; i++)
        {
            if (list[i].CompareTo(pivot) <= 0)
            {
                list.Swap(i, ++lastLow);
            }
        }
        list.Swap(end, ++lastLow);
        return lastLow;
    }

    /// <summary>
    /// Returns Nth smallest element from the list. Here n starts from 0 so that n=0 returns minimum, n=1 returns 2nd smallest element etc.
    /// Note: specified list would be mutated in the process.
    /// Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 216
    /// </summary>
    public static T NthOrderStatistic<T>(this IList<T> list, int n, Random? rnd = null)
        where T : IComparable<T>
    {
        return list.NthOrderStatistic(n, 0, list.Count - 1, rnd);
    }

    private static T NthOrderStatistic<T>(this IList<T> list, int n, int start, int end, Random? rnd)
        where T : IComparable<T>
    {
        while (true)
        {
            var pivotIndex = list.Partition(start, end, rnd);
            if (pivotIndex == n)
            {
                return list[pivotIndex];
            }

            if (n < pivotIndex)
            {
                end = pivotIndex - 1;
            }
            else
            {
                start = pivotIndex + 1;
            }
        }
    }

    public static void Swap<T>(this IList<T> list, int i, int j)
    {
        if (i == j)   //This check is not required but Partition function may make many calls so its for perf reason
        {
            return;
        }
        (list[i], list[j]) = (list[j], list[i]);
    }

    /// <summary>
    /// Note: specified list would be mutated in the process.
    /// </summary>
    public static T? Median<T>(this IList<T> list) 
        where T : IComparable<T>
    {
        if (list.Count == 0)
        {
            return default;
        }
        return list.NthOrderStatistic((list.Count - 1) / 2);
    }

    [Pure]
    public static T? Median<T>(this IEnumerable<T> enumerable)
        where T : IComparable<T>
    {
        IList<T> list = enumerable.ToList();
        return list.Median();
    }

    [Pure]
    public static TValue? Median<T, TValue>(this IEnumerable<T> enumerable, Func<T, TValue> valueFunc)
        where TValue : IComparable<TValue>
    {
        IList<TValue> list = enumerable.Select(valueFunc).ToList();
        return list.Median();
    }

    [Pure]
    public static T? Median<T>(this IReadOnlyList<T> sourceList)
        where T : IComparable<T>
    {
        var count = sourceList.Count;
        if (count == 0)
        {
            return default;
        }
        var array = new T[count];
        for (var i = 0; i < sourceList.Count; ++i)
        {
            array[i] = sourceList[i];
        }        
        return Median((IList<T>)array);
    }

    [Pure]
    public static TValue? Median<T, TValue>(this IReadOnlyList<T> sourceList, Func<T, TValue> valueFunc)
        where TValue : IComparable<TValue>
    {
        var count = sourceList.Count;
        if (count == 0)
        {
            return default;
        }        
        var array = new TValue[count];
        for (var i = 0; i < sourceList.Count; ++i)
        {
            array[i] = valueFunc(sourceList[i]);
        }
        return Median((IList<TValue>)array);
    }
}
