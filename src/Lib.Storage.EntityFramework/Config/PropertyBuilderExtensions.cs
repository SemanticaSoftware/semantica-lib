using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Semantica.Extensions;

namespace Semantica.Storage.EntityFramework.Config;

public static class PropertyBuilderExtensions
{
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<TProp> HasOwnedColumnName<TProp, TOwned, TOwner>(this PropertyBuilder<TProp> builder,
        Expression<Func<TOwner, TOwned>> navigationExpression, string propertyName)
    {
        return builder.HasColumnName(ColumnNameHelper.MakeName(navigationExpression.GetPropertyName(), propertyName));
    }

    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<TProp> HasOwnedColumnName<TProp>(this PropertyBuilder<TProp> builder,
        string ownerPropertyName, string propertyName)
    {
        return builder.HasColumnName(ColumnNameHelper.MakeName(ownerPropertyName, propertyName));
    }

    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<decimal?> HasPrecision(this PropertyBuilder<decimal?> builder, int precision, int scale)
    {
        return builder.HasColumnType(ConfigTypes.Decimal(precision, scale));
    }

    /// <summary>
    /// Configures the column as a nchar(1) or char(1) column, so it can store a single unicode or ascii character. An enum type
    /// that is defined as a ushort can be assigned char values. Use <see cref="Storage.CharEnums.CharEnumConverter"/> to
    /// convert between enum values to string values.
    /// </summary>
    /// <param name="unicode">Optional. If <see langword="true"/>, the column supports unicode, otherwise only ASCII.</param>
    /// <remarks>
    /// If you want to use different cased characters for different enum values, make sure either the database does case
    /// sensitive string comparison, or add appropriate
    /// <a href="https://learn.microsoft.com/en-us/ef/core/miscellaneous/collations-and-case-sensitivity">collation</a>. 
    /// </remarks>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<string?> IsCharEnum(this PropertyBuilder<string?> builder, bool unicode = true)
    {
        return builder.HasMaxLength(1)
                      .IsUnicode(unicode)
                      .IsFixedLength();
    }

    /// <summary>
    /// Configures the column as a nchar() or char() column, so it can store a number of unicode or ascii character. An enum
    /// type that is defined as a ushort can be assigned char values. Use <see cref="Storage.CharEnums.CharEnumConverter"/> to
    /// convert between enum values to string values.
    /// </summary>
    /// <param name="maxValues">The maximum amount of enum values that can be stored in the column.</param>
    /// <param name="unicode">Optional. If <see langword="true"/>, the column supports unicode, otherwise only ASCII.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<string?> IsCharEnumSet(this PropertyBuilder<string?> builder,
        int maxValues, bool unicode = true)
    {
        return builder.HasMaxLength(maxValues)
                      .IsUnicode(unicode);
    }

    /// <summary>
    ///     Configureert een DateTime property als een date-only veld.
    ///     Voor gebruik in FluentAPI configuratie.
    /// </summary>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<DateTime> IsDateOnly(this PropertyBuilder<DateTime> builder)
    {
        return builder.HasColumnType(ConfigTypes.Date()).IsRequired();
    }

    /// <summary>
    ///     Configureert een DateTime property als een date-only veld.
    ///     Voor gebruik in FluentAPI configuratie.
    /// </summary>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public static PropertyBuilder<DateTime?> IsDateOnly(this PropertyBuilder<DateTime?> builder)
    {
        return builder.HasColumnType(ConfigTypes.Date());
    }
}
