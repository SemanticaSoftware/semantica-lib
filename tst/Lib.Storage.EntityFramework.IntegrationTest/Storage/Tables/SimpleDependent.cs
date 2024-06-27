using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

public class SimpleDependent
{
    [Key]
    public int Id { get; set; }

    public int RootId { get; set; }

    public bool DependentProp { get; set; }

    public virtual Root Root { get; set; }

    public sealed class Config : IEntityTypeConfiguration<SimpleDependent>
    {
        public static IReadOnlyList<int> Ids = new[] { 101, 102, 103 };
            
        public void Configure(EntityTypeBuilder<SimpleDependent> builder) 
        { 
            builder.HasData(
                    new {
                        Id = Ids[0],
                        RootId = Tables.Root.Config.Ids[0],
                        DependentProp = true
                    },
                    new {
                        Id = Ids[1],
                        RootId = Tables.Root.Config.Ids[1],
                        DependentProp = false
                    },
                    new {
                        Id = Ids[2],
                        RootId = Tables.Root.Config.Ids[1],
                        DependentProp = true
                    }
                );
        }
    }
}