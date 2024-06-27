namespace Semantica.Core.Providers;

public class SnapshotDateTimeProvider : DateTimeProvider, ISnapshotDateTimeProvider
{
    public SnapshotDateTimeProvider() 
    {
        Reset();
    }

    protected Lazy<DateTime> InstanceNowLazyUtc { get; private set; } = null!;

    protected virtual DateTime GetUtcNow() => DateTime.UtcNow;

    public void Reset() => InstanceNowLazyUtc = new Lazy<DateTime>(GetUtcNow);

    public override DateTime UtcNow() => InstanceNowLazyUtc.Value;
}
