using Semantica.Storage.EntityFramework;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation;

public class SimpleUnitOfWorkManager : UnitOfWorkManager
{
    public SimpleUnitOfWorkManager(IDbContextProvider dbContextProvider) : base(dbContextProvider)
    {
    }

    protected override void NotifyWorkComplete(bool wasSuccessfullyCompleted)
    {
        WorkCompleted = true;
        if (wasSuccessfullyCompleted) foreach (var observer in OnWorkCompletedObservers)
        {
            observer.Invoke();
        }
    }
}