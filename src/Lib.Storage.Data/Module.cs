using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Storage.DataStores;

namespace Semantica.Storage.Data;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IStorageCache{T,T}"/></item>
/// </list>
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped(typeof(IStorageCache<,>), typeof(StorageCache<,>));
    }
}
