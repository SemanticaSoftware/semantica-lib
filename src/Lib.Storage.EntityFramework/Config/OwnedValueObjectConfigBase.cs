using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Semantica.Storage.EntityFramework.Config;

[ExcludeFromCodeCoverage]
public abstract class OwnedValueObjectConfigBase<TOwner, TOwnedType>
    : OwnedConfigBase<TOwner, TOwnedType>
    where TOwner : class
    where TOwnedType : class
{
        
    private TOwnedType[]? _seedDataTyped;
    private object[]? _seedDataObjects;
        
    protected OwnedValueObjectConfigBase(Expression<Func<TOwner, TOwnedType?>> navigationExpression) : base(navigationExpression)
    {
    }

    public override void Configure(OwnedNavigationBuilder<TOwner, TOwnedType> modelBuilder)
    {
        base.Configure(modelBuilder);
        if (_seedDataTyped != null)
        {
            Builder.HasData(_seedDataTyped);
        }
        if (_seedDataObjects != null)
        {
            Builder.HasData(_seedDataObjects);
        }
    }

    public OwnedValueObjectConfigBase<TOwner, TOwnedType> HasData(params TOwnedType[] seedDataTyped)
    {
        _seedDataTyped = seedDataTyped;
        return this;
    }

    public OwnedValueObjectConfigBase<TOwner, TOwnedType> HasData(params object[] seedDataObjects)
    {
        _seedDataObjects = seedDataObjects;
        return this;
    }
}