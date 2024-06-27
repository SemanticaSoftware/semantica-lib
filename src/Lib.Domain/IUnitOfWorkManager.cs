namespace Semantica.Domain;

public interface IUnitOfWorkManager
{
    void AttachWorkCompletedObserver(Action onCompletedAction);

    IUnitOfWork StartNew();
}