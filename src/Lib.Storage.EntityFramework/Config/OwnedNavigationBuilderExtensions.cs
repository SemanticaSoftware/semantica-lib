using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Semantica.Extensions;

namespace Semantica.Storage.EntityFramework.Config;

public static class OwnedNavigationBuilderExtensions
{
    public static ReferenceCollectionBuilder<TReference, TOwned> HasOneToManyOwned<TReference, TKey, TOwned, TOwner>(
            this OwnedNavigationBuilder<TOwner, TOwned> builder,
            Expression<Func<TOwned, TReference?>> referenceExpression,
            Expression<Func<TOwned, TKey>> keyExpression,
            Expression<Func<TOwner, TOwned>> navigationExpression
        )
        where TOwned : class
        where TOwner : class
        where TReference : class
    {
        var propertyName = keyExpression.GetPropertyName();
        builder.Property(keyExpression)
               .HasOwnedColumnName(navigationExpression.GetPropertyName(), propertyName);
        return builder.HasOne(referenceExpression)
                      .WithMany()
                      .HasForeignKey(propertyName);
    }

    public static OwnedNavigationBuilder<TOwnerParent, TOwner> OwnsOneConfigured<TOwnerParent, TOwner, TOwned>(
            this OwnedNavigationBuilder<TOwnerParent, TOwner> builder,
            OwnedConfigBase<TOwner, TOwned> config
        )
        where TOwned : class
        where TOwner : class
        where TOwnerParent : class
    {
        return builder.OwnsOne(config.NavigationExpression, config.Configure);
    }

    public static PropertyBuilder<TProp> PropertyOwned<TProp, TOwned, TOwner>(
            this OwnedNavigationBuilder<TOwner, TOwned> builder,
            Expression<Func<TOwned, TProp>> propertyExpression,
            Expression<Func<TOwner, TOwned>> navigationExpression
        )
        where TOwned : class
        where TOwner : class
    {
        return builder.Property(propertyExpression)
                      .HasOwnedColumnName(navigationExpression, propertyExpression.GetPropertyName());
    }
}