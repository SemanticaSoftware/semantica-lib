using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Semantica.Mvc.Conventions;

/// <summary>
/// Provides several extension methods for use during the <see cref="Microsoft.AspNetCore.Builder.WebApplicationBuilder"/> step
/// of the Program.cs.
/// </summary>
public static class ControllerConventionExtensions
{
    /// <summary>
    /// Adds services for controllers to the specified IServiceCollection. Adds a <see cref="RouteTokenTransformerConvention"/>
    /// to the conventions collection that transforms route tokens to lower case. This method will not register services used
    /// for views or pages.
    /// </summary>
    /// <inheritdoc cref="MvcServiceCollectionExtensions.AddControllers(IServiceCollection,Action{MvcOptions}?)"/>
    public static IMvcBuilder AddControllersLowerCase(this IServiceCollection services, Action<MvcOptions>? configure = null)
    {
        return services.AddControllers(
            options =>
            {
                options.Conventions.AddRouteTransformer<RouteTransformer>();
                configure?.Invoke(options);
            });
    }

    /// <summary>
    /// Adds services for controllers to the specified IServiceCollection. Adds a <see cref="RouteTokenTransformerConvention"/>
    /// to the conventions collection that transforms route tokens from pascal case to kebab case. This method will not register
    /// services used for views or pages.
    /// </summary>
    /// <inheritdoc cref="MvcServiceCollectionExtensions.AddControllers(IServiceCollection,Action{MvcOptions}?)"/>
    public static IMvcBuilder AddControllersKebabCase(this IServiceCollection services, Action<MvcOptions>? configure = null)
    {
        return services.AddControllers(
            options =>
            {
                options.Conventions.AddRouteTransformer<KebabCaseRouteTransformer>();
                configure?.Invoke(options);
            });
    }

    /// <summary>
    /// Adds services for controllers to the specified IServiceCollection. Adds a <see cref="RouteTokenTransformerConvention"/>
    /// to the conventions collection that transforms route tokens from pascal case to snake case. This method will not register
    /// services used for views or pages.
    /// </summary>
    /// <inheritdoc cref="MvcServiceCollectionExtensions.AddControllers(IServiceCollection,Action{MvcOptions}?)"/>
    public static IMvcBuilder AddControllersSnakeCase(this IServiceCollection services, Action<MvcOptions>? configure = null)
    {
        return services.AddControllers(
            options =>
            {
                options.Conventions.AddRouteTransformer<SnakeCaseRouteTransformer>();
                configure?.Invoke(options);
            });
    }

    /// <summary>
    /// Adds an instance of <typeparamref name="TTransformer"/> as <see cref="RouteTokenTransformerConvention"/> to the
    /// conventions collection.
    /// </summary>
    /// <param name="conventions">The <see cref="MvcOptions.Conventions"/> collection of the <see cref="MvcOptions"/>.</param>
    /// <typeparam name="TTransformer">A type implementing <see cref="IOutboundParameterTransformer"/>.</typeparam>
    /// <returns><paramref name="conventions"/>, for FluentAPI syntax.</returns>
    public static IList<IApplicationModelConvention> AddRouteTransformer<TTransformer>(
        this IList<IApplicationModelConvention> conventions)
        where TTransformer : IOutboundParameterTransformer, new()
    {
        conventions.Add(new RouteTokenTransformerConvention(new TTransformer()));
        return conventions;
    }
}
