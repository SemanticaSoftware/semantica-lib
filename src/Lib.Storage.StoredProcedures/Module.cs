using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;

namespace Semantica.Storage.StoredProcedures;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IUnitOfWorkProcedureManager"/></item>
/// </list>
/// The module is dependent on implementations in the <see cref="Semantica.Storage"/>.<see cref="Semantica.Storage.EntityFramework"/>
/// assembly.
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override IEnumerable<Assembly> GetDependencyAssemblies()
    {
        yield return typeof(Semantica.Storage.Data.Module).Assembly;
    }

    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWorkProcedureManager, UnitOfWorkProcedureManager>();
    }
}