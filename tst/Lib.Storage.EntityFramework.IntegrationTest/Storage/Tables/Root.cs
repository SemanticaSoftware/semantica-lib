using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.ComplexTypes;
using Semantica.Storage;
using Semantica.Storage.Attributes;
using Semantica.Storage.EntityFramework.Config;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

public class Root : IIdentity<int>
{
    [Key]
    public int Id { get; set; }

    public string Prop { get; set; }

    [Immutable]
    public string ImmutableProp { get; set; }

    public string NotMappedProp { get; set; }

    public ValueType Values { get; set; }

    // public Addendum Addendum { get; set; }

    public virtual ICollection<SimpleDependent> SimpleDependents { get; set; }

    public sealed class Config : IEntityTypeConfiguration<Root>
    {
        public static readonly IReadOnlyList<int> Ids = new[] { 1, 2 };

        public void Configure(EntityTypeBuilder<Root> builder) 
        { 
            builder.HasKey(e => e.Id);
            builder.Property(t => t.Prop)
                            .HasMaxLength(64);
            builder.Property(t => t.ImmutableProp)
                            .HasMaxLength(64);
            var config = new ValueType.Config<Root>(sm => sm.Values);
            builder.OwnsOneConfigured(config);
            // Builder.OwnsOneConfigured(new Addendum.Config(sm => sm.Addendum));

            // Seed Data
            builder.HasData(
                    new {
                        Id = Ids[0],
                        Prop = $"{nameof(Root.Prop)}-1",
                        ImmutableProp = $"{nameof(Root.ImmutableProp)}-1",
                        NotMappedProp = "AS",
                    },
                    new {
                        Id = Ids[1],
                        Prop = $"{nameof(Root.Prop)}-2",
                        ImmutableProp = $"{nameof(Root.ImmutableProp)}-2",
                        NotMappedProp = "DASAS",
                    }
                );
            config.HasData(
                    new {
                        RootId = Ids[0],
                        ValueTypeProp = $"{nameof(Root)}-{nameof(ValueType.ValueTypeProp)}"
                    }
                );
        }

    }
}