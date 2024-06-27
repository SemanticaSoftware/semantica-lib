using Microsoft.Extensions.DependencyInjection;

namespace Semantica.Core.DependencyInjection;

public static class ServiceCollectionExtensions
{
    
    public static IServiceCollection AddModuleRegistrations<TModule>(this IServiceCollection container, bool findOtherModulesInSameAssembly = false)
        where TModule : ModuleBase<IServiceCollection>, new()
    {
        new TModule().Register(container, findOtherModulesInSameAssembly);
        return container;
    }    
}
