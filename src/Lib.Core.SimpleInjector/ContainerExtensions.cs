using Semantica.Core.DependencyInjection;
using SimpleInjector;

namespace Semantica.Core.SimpleInjector;

public static class ContainerExtensions
{
    
    public static Container AddModuleRegistrations<TModule>(this Container container, bool findOtherModulesInSameAssembly = false)
        where TModule : ModuleBase<Container>, new()
    {
        new TModule().Register(container, findOtherModulesInSameAssembly);
        return container;
    }    
}
