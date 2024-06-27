using System.Linq.Expressions;
using JetBrains.Annotations;

namespace Semantica.Linq;

/// <summary>
/// Provides additional functionality for LINQ queries.
/// </summary>
public static class QueryableLinq
{
    /// <summary>
    /// Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
    /// condition is met.
    /// </summary>
    /// <param name="queryable">An <see cref="IQueryable{T}"/>.</param>
    /// <param name="condition">A value that determines whether the skip is applied.</param>
    /// <param name="count">
    /// The number of elements to skip before returning the remaining elements, or <see langword="null"/>.
    /// </param>
    /// <typeparam name="T">The type of elements in <paramref name="queryable"/>.</typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IQueryable{T}"/> that contains the elements
    /// that occur after the specified index in the input sequence; otherwise, returns the input sequence unchanged.
    /// </returns>    
    [LinqTunnel]
    public static IQueryable<T> ConditionalSkip<T>(this IQueryable<T> queryable, bool condition, int count)
    {
        return condition ? queryable.Skip(count) : queryable;
    }

    /// <summary>
    /// Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
    /// count has a value.
    /// </summary>
    /// <param name="queryable">An <see cref="IQueryable{T}"/>.</param>
    /// <param name="count">
    /// The number of elements to skip before returning the remaining elements, or <see langword="null"/>.
    /// </param>
    /// <typeparam name="T">The type of elements in <paramref name="queryable"/>.</typeparam>
    /// <returns>
    /// If <paramref name="count"/> has a value, an <see cref="IQueryable{T}"/> that contains the elements that occur after the
    /// specified index in the input sequence; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> ConditionalSkip<T>(this IQueryable<T> queryable, int? count)
    {
        return count.HasValue ? queryable.Skip(count.Value) : queryable;
    }
    
    /// <summary> Filters a query based on a predicate, if the specified condition is met. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="queryable"/>. </typeparam>
    /// <param name="queryable"> An <see cref="IQueryable{T}"/> that contains the elements to filter. </param>
    /// <param name="condition">A value that determines whether the filter is applied.</param>
    /// <param name="predicate"> A function to test each element for a condition. </param>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IQueryable{T}"/> that contains elements from
    /// the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> ConditionalWhere<T>(this IQueryable<T> queryable, bool condition,
        Expression<Func<T, bool>> predicate)
    {
        return condition ? queryable.Where(predicate) : queryable;
    }
    
    /// <summary> Filters a query based on a predicate, if the specified condition is met. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="queryable"/>. </typeparam>
    /// <param name="queryable"> An <see cref="IQueryable{T}"/> that contains the elements to filter. </param>
    /// <param name="predicate"> A function to test each element for a condition, or null. </param>
    /// <returns>
    /// If <paramref name="predicate"/> is not <see langword="null"/>, an <see cref="IQueryable{T}"/> that contains elements from
    /// the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> ConditionalWhere<T>(this IQueryable<T> queryable, Expression<Func<T, bool>>? predicate)
    {
        return predicate != null ? queryable.Where(predicate) : queryable;
    }

    /// <summary> Filters a query based on a predicate, if the specified condition is met. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="queryable"/>. </typeparam>
    /// <param name="queryable"> An <see cref="IQueryable{T}"/> that contains the elements to filter. </param>
    /// <param name="condition"> A value that determines whether the filter is applied. </param>
    /// <param name="predicateFunc">
    /// A function that will return another function used to test each element. Only evaluated when <paramref name="condition"/>
    /// evaluates to <see langword="true"/>
    /// </param>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IQueryable{T}"/> that contains elements from
    /// the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> ConditionalWhere<T>(this IQueryable<T> queryable, bool condition, Func<Expression<Func<T, bool>>> predicateFunc)
    {
        return condition ? queryable.Where(predicateFunc.Invoke()) : queryable;
    }

    /// <summary>Filters a query based on a series of parameterised predicates, if the specified condition is met.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="queryable"/>.</typeparam>
    /// <typeparam name="TParam">The type of the parameter to generate the predicates.</typeparam>
    /// <param name="queryable">An <see cref="IQueryable{T}"/> that contains the elements to filter.</param>
    /// <param name="condition">A value that determines whether the filter is applied.</param>
    /// <param name="predicateFunc">
    /// A function that will return another function used to test each element, used to generate a predicate for each element in
    /// <paramref name="params"/>.
    /// </param>
    /// <param name="params">A sequence of parameters with which to generate predicates.</param>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IQueryable{T}"/> that contains elements from
    /// the input sequence that satisfy all the generated predicates; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> ConditionalWhereParameter<T, TParam>(this IQueryable<T> queryable, bool condition,
        Func<TParam, Expression<Func<T, bool>>> predicateFunc, [InstantHandle] IEnumerable<TParam> @params)
    {
        return condition ? queryable.WhereParameter(predicateFunc, @params) : queryable;
    }

    /// <summary>Filters a query based on a series of parameterised predicates.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="queryable"/>.</typeparam>
    /// <typeparam name="TParam">The type of the parameter to generate the predicates.</typeparam>
    /// <param name="queryable">An <see cref="IQueryable{T}"/> that contains the elements to filter.</param>
    /// <param name="predicateFunc">
    /// A function that will return another function used to test each element, used to generate a predicate for each element in
    /// <paramref name="params"/>.
    /// </param>
    /// <param name="params">A sequence of parameters with which to generate predicates.</param>
    /// <returns>
    /// An <see cref="IQueryable{T}"/> that contains elements from the input sequence that satisfy all the generated predicates.
    /// </returns>
    [LinqTunnel]
    public static IQueryable<T> WhereParameter<T, TParam>(this IQueryable<T> queryable,
        Func<TParam, Expression<Func<T, bool>>> predicateFunc, [InstantHandle] IEnumerable<TParam> @params)
    {
        foreach (var param in @params)
        {
            queryable = queryable.Where(predicateFunc.Invoke(param));
        }
        return queryable;
    }
}
