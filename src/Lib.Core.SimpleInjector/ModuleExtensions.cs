using System;
using System.Diagnostics.CodeAnalysis;
using SimpleInjector;
using SimpleInjector.Diagnostics;

namespace Semantica.Core.SimpleInjector;

[ExcludeFromCodeCoverage]
public static class ModuleExtensions
{
    /// <summary>
    /// Registers <typeparamref name="TImplementation"/> as <see cref="Lifestyle.Transient"/> implementation of
    /// <typeparamref name="TInterface"/>. Use when the system that will create the instance is always going to be responsible for
    /// disposing it.
    /// </summary>
    public static void RegisterTransientDisposable<TInterface, TImplementation>(this Container container, string reason)
        where TInterface : class
        where TImplementation : class, TInterface, IDisposable
    {
        container.Register<TInterface, TImplementation>();
        var registration = container.GetRegistration(typeof(TInterface))?.Registration;
        registration?.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent, reason);
    }
}
