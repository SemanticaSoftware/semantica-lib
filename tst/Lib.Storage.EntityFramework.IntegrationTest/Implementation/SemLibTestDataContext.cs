using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation;

public class SemLibTestDataContext : DbContext
{
    public static readonly InMemoryDatabaseRoot InMemoryDatabaseRoot = new InMemoryDatabaseRoot();

    public SemLibTestDataContext(DbContextOptions<SemLibTestDataContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString(), InMemoryDatabaseRoot)
                          .EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SemLibTestDataContext).Assembly);
    }
}