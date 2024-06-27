using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Trees.Builders;
using Semantica.Trees.Converters;

namespace Semantica.Trees;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IPartialTreeConverter{T,T}"/></item>
/// <item><see cref="ITreeBuilder{T}"/></item>
/// <item><see cref="ITreeConverter{T,T}"/></item>
/// </list>
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient(typeof(IPartialTreeConverter<,>), typeof(PartialTreeConverter<,>));
        serviceCollection.AddTransient(typeof(ITreeBuilder<>), typeof(TreeBuilder<>));
        serviceCollection.AddTransient(typeof(ITreeConverter<,>), typeof(TreeConverter<,>));
    }
}
