using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Core.Providers;

namespace Semantica.Core;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IDateTimeProvider"/></item>
/// <item><see cref="ISnapshotDateTimeProvider"/></item>
/// </list>
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IDateTimeProvider, DateTimeProvider>();
        serviceCollection.AddScoped<ISnapshotDateTimeProvider, SnapshotDateTimeProvider>();
    }
}
