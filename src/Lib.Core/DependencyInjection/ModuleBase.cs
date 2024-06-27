using System.Reflection;
using System.Xml.Schema;
using Microsoft.Extensions.DependencyInjection;

namespace Semantica.Core.DependencyInjection;

/// <summary>
/// <para>
/// Provides a neat way of organising DI registrations per project and within a project.
/// </para>
/// <para>
/// Assemblies containing dependencies are registered by overriding <see cref="GetDependencyAssemblies"/>. Individual modules
/// containing dependencies can be registered by overriding <see cref="GetDependencyModules"/>.  
/// </para>
/// <para>
/// When <see cref="Register"/> is called, all classes in all relevant assemblies that inherit from
/// <see cref="ModuleBase{TContainer}"/> with a compatible container are recursively instantiated and called. 
/// </para>
/// <remarks>
/// Note that <see cref="Register"/> only needs to be called on one module within the top-level assembly.
/// </remarks>
/// </summary>
/// <typeparam name="TContainer">The type of the used CI container or builder.</typeparam>
public abstract class ModuleBase<TContainer>
{
    private static IEnumerable<ModuleBase<T>> EnumerateAssemblyModules<T>(Assembly assembly, ISet<Assembly> assemblySet)
    {
        foreach (var module in EnumerateModules<T>(assembly))
        {
            foreach (var dependencyModule in module.EnumerateDependencyModules<T>(assemblySet))
            {
                yield return dependencyModule;
            }

            yield return module;
        }
    }

    private IEnumerable<ModuleBase<T>> EnumerateDependencyModules<T>(ISet<Assembly> assemblySet)
    {
        return GetDependencyAssemblies().Where(assemblySet.Add)
                                        .SelectMany(assembly => EnumerateAssemblyModules<T>(assembly, assemblySet));
    }

    private static IEnumerable<Type> EnumerateModuleTypes<T>(Assembly assembly)
    {
        return assembly.GetTypes()
                       .Where(type => typeof(ModuleBase<T>).IsAssignableFrom(type) && !type.IsAbstract);
    }

    private static IEnumerable<ModuleBase<T>> EnumerateModules<T>(Assembly assembly, Type? typeToExclude = null)
    {
        var enumerable = EnumerateModuleTypes<T>(assembly);
        if (typeToExclude != null)
        {
            enumerable = enumerable.Where(t => t != typeToExclude);
        }
        return enumerable.Select(configType => (ModuleBase<T>?)Activator.CreateInstance(configType))
                         .Where(mod => mod != null)
                         .Cast<ModuleBase<T>>();
    }
    
    /// <summary>
    /// Override if this module has dependencies within other assemblies. This method should yield all Assemblies containing
    /// dependencies once.
    /// </summary>
    public virtual IEnumerable<Assembly> GetDependencyAssemblies() => Enumerable.Empty<Assembly>();

    /// <summary>
    /// Override if this module has dependencies within other modules. This method provides more granular dependency paths than
    /// by using <see cref="GetDependencyAssemblies"/>, when a single assembly has multiple modules.
    /// </summary>
    public virtual IEnumerable<ModuleBase<TContainer>> GetDependencyModules() => Enumerable.Empty<ModuleBase<TContainer>>();
    
    /// <summary>
    /// Override if this module has dependencies within other modules. This method provides more granular dependency paths than
    /// by using <see cref="GetDependencyAssemblies"/>, when a single assembly has multiple modules. Only use if
    /// <see cref="ToMicrosoftDependencyInjectionAbstractions"/> is overridden. 
    /// </summary>
    public virtual IEnumerable<ModuleBase<IServiceCollection>> GetMicrosoftDependencyInjectionModules() => Enumerable.Empty<ModuleBase<IServiceCollection>>();
    
    /// <summary>
    /// Applies all registrations for the module, other modules in the same assembly, and modules in dependent assemblies.
    /// Ensures modules are only used once, even if there are multiple paths to a dependency assembly.  
    /// </summary>
    /// <remarks>
    /// <para>
    /// If <typeparamref name="TContainer"/> is not <see cref="IServiceCollection"/>,
    /// and <see cref="ToMicrosoftDependencyInjectionAbstractions"/> is overridden and doesn't return <see langword="null"/>,
    /// modules that implement <see cref="ModuleBase{T}"/> of type <see cref="IServiceCollection"/> are also searched for. 
    /// </para>
    /// <para>
    /// Registrations are done in order:
    /// <list type="bullet">
    /// <item>
    /// <description> modules in dependency assemblies for <see cref="IServiceCollection"/> (when applicable). </description>
    /// </item>
    /// <item><description> modules in dependency assemblies for <typeparamref name="TContainer"/>. </description></item>
    /// <item>
    /// <description> other modules for <see cref="IServiceCollection"/> in this assembly (when applicable). </description>
    /// </item>
    /// <item><description> other modules for <typeparamref name="TContainer"/> in this assembly. </description></item>
    /// <item><description> this module. </description></item>
    /// </list>
    /// Module order within the assemblies is determined by <see cref="Assembly.GetTypes"/>.  
    /// </para>
    /// </remarks>
    /// <param name="container">The CI container or builder instance used to do all registrations.</param>
    /// <param name="findOtherModulesInSameAssembly">
    /// If <see langword="true"/>, the current assembly will be searched for other implementations of
    /// <see cref="ModuleBase{TContainer}"/>, and not just assemblies referenced in .   
    /// </param>
    public void Register(TContainer container, bool findOtherModulesInSameAssembly = true)
    {
        RegisterInternal(container, new HashSet<Assembly>(), new HashSet<Type>(), findOtherModulesInSameAssembly);
    }

    private void RegisterInternal(
        TContainer container, ISet<Assembly> assemblySet, ISet<Type> moduleSet, bool findOtherModulesInSameAssembly = false)
    {
        var thisModuleType = GetType();
        foreach (var module in GetDependencyModules())
        {
            module.RegisterInternal(container, assemblySet, moduleSet);
        }
        var serviceCollection = ToMicrosoftDependencyInjectionAbstractions(container);
        var findServiceCollectionModules = typeof(TContainer) != typeof(IServiceCollection) && serviceCollection != null;
        if (findServiceCollectionModules)
        {
            foreach (var module in GetMicrosoftDependencyInjectionModules())
            {
                module.RegisterInternal(serviceCollection!, assemblySet, moduleSet);
            }
            RegisterDependencyModules(serviceCollection, assemblySet, moduleSet);
        }
        RegisterDependencyModules(container, assemblySet, moduleSet);
        if (findOtherModulesInSameAssembly)
        {
            if (findServiceCollectionModules)
            {
                foreach (var otherModulesInAssembly 
                         in EnumerateModules<IServiceCollection>(thisModuleType.Assembly, thisModuleType))
                {
                    otherModulesInAssembly.RegisterInternal(serviceCollection!, assemblySet, moduleSet);
                }
            }
            foreach (var otherModulesInAssembly 
                     in EnumerateModules<TContainer>(thisModuleType.Assembly, thisModuleType))
            {
                otherModulesInAssembly.RegisterInternal(container, assemblySet, moduleSet);
            }
        }
        try
        {
            if (moduleSet.Add(thisModuleType))
            {
                RegisterModuleImplementations(container);
            }
        }
        catch (Exception e)
        {
            throw new ModuleException($"Exception while applying registrations for module: {GetType().FullName}", e);
        }
    }

    private void RegisterDependencyModules<T>(T container, ISet<Assembly> assemblySet, ISet<Type> moduleSet)
    {
        foreach (var module in EnumerateDependencyModules<T>(assemblySet))
        {
            module.RegisterInternal(container, assemblySet, moduleSet);
        }
    }

    public abstract void RegisterModuleImplementations(TContainer serviceCollection);

    /// <summary>
    /// Override this method if at any point in the Dependency Assemblies, there are modules that are defined using
    /// <see cref="IServiceCollection"/> instead of a third party DI framework.
    /// <see cref="Microsoft"/>.<see cref="Microsoft.Extensions.DependencyInjection"/>. 
    /// </summary>
    /// <remarks>
    /// This will only work if the modules using <see cref="IServiceCollection"/> do only registrations in a manner that is
    /// compatible to the third party <paramref name="container"/>.
    /// </remarks>
    /// <param name="container">
    /// The container of type <typeparamref name="TContainer"/> used for third party registrations.
    /// </param>
    /// <returns>
    /// A wrapper around <paramref name="container"/> that implements at least the <see cref="ICollection{T}.Add(T)"/> method from
    /// <see cref="IServiceCollection"/>.
    /// </returns>
    protected virtual IServiceCollection? ToMicrosoftDependencyInjectionAbstractions(TContainer container)
    {
        return null;
    }
}
