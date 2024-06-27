using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Checks;
using Semantica.Domain;

namespace Semantica.Storage.EntityFramework;

[System.Diagnostics.DebuggerNonUserCode]
public class UnitOfWork : IUnitOfWork
{
    private DbContext? _dataContext;
    private readonly Action<bool> _onCompleted;
    private bool _completed;

    public UnitOfWork(DbContext dataContext, Action<bool> onCompleted)
    {
        _onCompleted = onCompleted;
        _dataContext = dataContext;
        _completed = false;
    }

    public virtual async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        Guard.State(Check.NotNull(_dataContext));
        if (_completed)
        {
            throw new InvalidOperationException("A unit of work cannot be completed twice.");
        }
        try
        {
            _completed = true;
            await _dataContext!.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            _onCompleted.Invoke(false);
            throw;
        }
        _onCompleted.Invoke(true);
    }
    
    public void Dispose()
    {
        if (_dataContext == null)
        {
            return;
        }
        
        try
        {
            if (! _completed)
            {
                _completed = true;
                _dataContext.ChangeTracker.Clear();
            }
        }
        finally
        {
            _dataContext = null;
            _onCompleted.Invoke(false);
            GC.SuppressFinalize(this);
        }
    }
}
