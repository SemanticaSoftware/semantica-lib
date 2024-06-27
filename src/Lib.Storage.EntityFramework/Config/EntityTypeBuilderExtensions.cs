using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Semantica.Extensions;
using Semantica.Extensions.Flags;

namespace Semantica.Storage.EntityFramework.Config;

public static class EntityTypeBuilderExtensions
{
    public static EntityTypeBuilder<TOwner> OwnsOneConfigured<TOwner, TOwned>(this EntityTypeBuilder<TOwner> builder, OwnedConfigBase<TOwner, TOwned> configBase)
        where TOwner : class
        where TOwned : class
    {
        return builder.OwnsOne(configBase.NavigationExpression, configBase.Configure);
    }

    public static PropertyBuilder<TProperty> PropertyCamelCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().Decapitalize());

    public static PropertyBuilder<TProperty> PropertyKebabCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().ToKebabCase());

    public static PropertyBuilder<TProperty> PropertyKebabCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression, CasingStyle style)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().ToKebabCase(style));
    
    public static PropertyBuilder<TProperty> PropertyLowerCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().ToLower());
    
    public static PropertyBuilder<TProperty> PropertySnakeCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().ToSnakeCase());
    
    public static PropertyBuilder<TProperty> PropertySnakeCase<TStorable, TProperty>(this EntityTypeBuilder<TStorable> builder, Expression<Func<TStorable, TProperty>> propertyExpression, CasingStyle style)
        where TStorable : class
        => builder.Property(propertyExpression)
                  .HasColumnName(propertyExpression.GetPropertyName().ToSnakeCase(style));
}
