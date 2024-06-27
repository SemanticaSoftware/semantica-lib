using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage.Attributes;
using Semantica.Storage.EntityFramework.Config;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.ComplexTypes;

public class OwnedEntity
{
    public int? OwnedId { get; set; }
    
    public int OwnedProp { get; set; }

    [Immutable]
    public int ImmutableOwnedProp { get; set; }

    [NotMapped]
    public int NotMappedOwnedProp { get; set; }

    public ValueType Values { get; set; }

    public sealed class Config : OwnedConfigBase<Root, OwnedEntity>
    {
        public Config(Expression<Func<Root, OwnedEntity>> navigationExpression) : base(navigationExpression)
        {
        }

        protected override void OnModelBuilding()
        {
            Builder.OwnsOneConfigured(new ValueType.Config<OwnedEntity>(addendum => addendum.Values)
                .HasData(
                        new ValueType {
                            ValueTypeProp = $"{nameof(OwnedEntity)}-{nameof(ValueType.ValueTypeProp)}"
                        }
                    ));
            Builder.HasData(
                    new OwnedEntity() {
                        OwnedId = Root.Config.Ids[0],
                        OwnedProp = 21,
                        ImmutableOwnedProp = 42,
                    }
                );
        }
    }
}