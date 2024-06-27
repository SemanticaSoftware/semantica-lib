using Semantica.Checks;
using Semantica.Domain;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework;

public class UnitOfWorkManager : IUnitOfWorkManager
{
    protected readonly IDbContextProvider DbContextProvider;
    
    protected readonly List<Action> OnWorkCompletedObservers;
    protected bool WorkCompleted;

    public UnitOfWorkManager(IDbContextProvider dbContextProvider)
    {
        DbContextProvider = dbContextProvider;
        OnWorkCompletedObservers = new List<Action>();
        WorkCompleted = true;
    }

    public IUnitOfWork StartNew()
    {
        Guard.State(WorkCompleted, "A new UnitOfWork cannot be started before the previous was completed.", nameof(WorkCompleted));

        WorkCompleted = false;
        return CreateUnitOfWork();
    }
    public virtual void AttachWorkCompletedObserver(Action onCompletedAction)
    {
        OnWorkCompletedObservers.Add(onCompletedAction);
    }

    protected virtual IUnitOfWork CreateUnitOfWork()
    {
        return new UnitOfWork(DbContextProvider.ActiveContext, NotifyWorkComplete);
    }

    protected virtual void NotifyWorkComplete(bool wasSuccessfullyCompleted)
    {
        if (! WorkCompleted)
        {
            WorkCompleted = true;
            DbContextProvider.ResetContext();
            if (wasSuccessfullyCompleted)
            {
                foreach (var observer in OnWorkCompletedObservers)
                {
                    observer.Invoke();
                }
            }
        }
    }
}