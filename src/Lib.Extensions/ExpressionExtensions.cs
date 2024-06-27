using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Reflection;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for lambda expressions.
/// </summary>
[Pure]
public static class ExpressionExtensions
{
    /// <summary>
    /// Returns the property that is accessed in the lambda expression.
    /// </summary>
    /// <typeparam name="TSource">The type of source element in the expression.</typeparam>
    /// <typeparam name="TTarget">
    /// The type of property accessed in the expression.
    /// </typeparam>
    /// <param name="expression">The expression to inspect.</param>
    /// <returns>
    /// A <see cref="PropertyInfo"/> that represents the property being accessed
    /// in <paramref name="expression"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="expression"/> does not represent a property being accessed.
    /// </exception>
    public static PropertyInfo GetPropertyInfo<TSource, TTarget>(this Expression<Func<TSource, TTarget>> expression)
    {
        if (expression.Body is not MemberExpression member)
        {
            throw new ArgumentException($@"Expression '{expression}' refers to a method. Expected a property.", nameof(expression));
        }

        if (member.Member is not PropertyInfo propertyInfo)
        {
            throw new ArgumentException($@"Expression '{expression}' refers to a field. Expected a property.", nameof(expression));
        }

        return propertyInfo;
    }

    /// <summary>
    /// Returns the name of the property that is accessed in the lambda expression.
    /// </summary>
    /// <typeparam name="TSource">The type of source element in the expression.</typeparam>
    /// <typeparam name="TTarget">
    /// The type of property accessed in the expression.
    /// </typeparam>
    /// <param name="expression">The expression to inspect.</param>
    /// <returns>The name of the property being accessed in <paramref name="expression"/>.</returns>
    public static string GetPropertyName<TSource, TTarget>(this Expression<Func<TSource, TTarget>> expression)
    {
        return expression.GetPropertyInfo().Name;
    }

    /// <summary>
    /// Returns the first custom attribute applied to the field or property
    /// being accessed in the lambda expression.
    /// </summary>
    /// <typeparam name="TIn">The type of source element in the expression.</typeparam>
    /// <typeparam name="TOut">The type of field or property in the expression.</typeparam>
    /// <typeparam name="TAttribute">The type of custom attribute to find.</typeparam>
    /// <param name="expression">The expression to inspect.</param>
    /// <returns>
    /// A <typeparamref name="TAttribute"/> that represents the first custom
    /// attribute applied to the member accessed in <paramref
    /// name="expression"/>, or <see langword="null"/> if it has no custom
    /// attributes of the specified type.
    /// </returns>
    public static TAttribute? GetAttribute<TIn, TOut, TAttribute>(this Expression<Func<TIn, TOut>> expression)
        where TAttribute : Attribute
    {
        var memberExpression = expression.Body as MemberExpression;
        var attributes = memberExpression?.Member.GetCustomAttributes(typeof(TAttribute), true);
        return attributes != null && attributes.Length > 0 ? attributes[0] as TAttribute : null;
    }
}
