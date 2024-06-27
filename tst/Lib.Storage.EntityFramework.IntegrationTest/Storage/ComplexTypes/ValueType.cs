using System;
using System.Linq.Expressions;
using Semantica.Storage.EntityFramework.Config;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.ComplexTypes;

public class ValueType
{
    public string ValueTypeProp { get; set; }

    public sealed class Config<TOwner> : OwnedValueObjectConfigBase<TOwner, ValueType>
        where TOwner : class, new()
    {
        public Config(Expression<Func<TOwner, ValueType>> navigationExpression) : base(navigationExpression)
        {
        }

        protected override void OnModelBuilding()
        {
            Builder.Property(t => t.ValueTypeProp)
                   .HasMaxLength(32);
        }
    }
}