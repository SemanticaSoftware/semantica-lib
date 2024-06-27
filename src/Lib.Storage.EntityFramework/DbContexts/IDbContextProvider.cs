using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework.DbContexts;

public interface IDbContextProvider : IDisposable
{
    DbContext ActiveContext { get; }

    void ResetContext();
}