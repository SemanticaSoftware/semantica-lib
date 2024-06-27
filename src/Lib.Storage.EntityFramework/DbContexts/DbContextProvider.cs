using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework.DbContexts;

public class DbContextProvider : IDbContextProvider
{
    private readonly IDbContextFactory _dbContextFactory;
    private Lazy<DbContext> _dataContextLazy = null!;

    public DbContextProvider(IDbContextFactory dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
        SetNewLazyContext();
    }

    public DbContext ActiveContext => _dataContextLazy.Value;

    public void ResetContext()
    {
        DisposeContext();
        SetNewLazyContext();
    }

    public void Dispose()
    {
        DisposeContext();
        GC.SuppressFinalize(this);
    }

    private void DisposeContext()
    {
        if (_dataContextLazy.IsValueCreated) ActiveContext?.Dispose();
    }

    private void SetNewLazyContext()
    {
        _dataContextLazy = new Lazy<DbContext>(_dbContextFactory.CreateDbContext);
    }
}