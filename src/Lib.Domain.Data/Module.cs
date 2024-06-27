using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Domain.Data.Repositories;

namespace Semantica.Domain.Data;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IPropertyAnalyser"/></item>
/// <item><see cref="IPropertyIdentifier"/></item>
/// </list>
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IPropertyAnalyser, PropertyAnalyser>();
        serviceCollection.AddScoped<IPropertyIdentifier, PropertyIdentifier>();
    }
}
