using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Semantica.Storage.EntityFramework.Config;

public abstract class OwnedConfigBase<TOwner, TOwned>
    where TOwner : class
    where TOwned : class
{
    protected OwnedConfigBase(Expression<Func<TOwner, TOwned?>> navigationExpression)
    {
        NavigationExpression = navigationExpression;
    }

    protected OwnedNavigationBuilder<TOwner, TOwned> Builder { get; private set; } = null!;

    public Expression<Func<TOwner, TOwned?>> NavigationExpression { get; }

    public virtual void Configure(OwnedNavigationBuilder<TOwner, TOwned> modelBuilder)
    {
        Builder = modelBuilder;
        OnModelBuilding();
    }

    protected abstract void OnModelBuilding();
}