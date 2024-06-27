using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using SimpleInjector;

namespace Semantica.Core.SimpleInjector;

/// <summary>
/// Implementation of <see cref="IServiceCollection"/>, so the modules can be built up using the extensions provided by
/// <see cref="ServiceCollectionServiceExtensions"/>, but using <see cref="SimpleInjector"/>.<see cref="Container"/> as the
/// actual implementation.
/// </summary>
/// <remarks>
/// Registrations are done to <see cref="SimpleInjector"/>.<see cref="Container"/>, so they follow all it's restrictions.  
/// If <see cref="SimpleInjector"/> specific functionality is required, cast the <see cref="IServiceCollection"/> to
/// <see cref="ServiceCollectionContainer"/> to retrieve the actual <see cref="Container"/>.
/// </remarks>
public class ServiceCollectionContainer : IServiceCollection
{
    private readonly Lazy<IServiceProvider>? _serviceProviderLazy;
    private readonly IList<ServiceDescriptor>? _descriptors;
    private readonly Container _container;

    /// <summary>
    /// Instantiate when calling the root <see cref="ModuleBase{IServiceCollection}"/> implementation's
    /// <see cref="ModuleBase{T}.Register"/> method.
    /// </summary>
    /// <remarks>
    /// The locator can be omitted (<see langword="null"/>), but only if all Factory-registrations don't use the
    /// <see cref="IServiceProvider"/> argument. Determining this is the responsibility of the implementor. 
    /// </remarks>
    /// <param name="container">
    /// The <see cref="SimpleInjector"/>.<see cref="Container"/> instance used in the application.
    /// </param>
    /// <param name="serviceProviderLocator">
    /// A function that can produce a <see cref="IServiceCollection"/> to be used with
    /// <see cref="ServiceDescriptor.ImplementationFactory"/>.
    /// </param>
    /// <param name="forEnumeration">
    /// When <see langword="true"/>, all added <see cref="ServiceDescriptor"/> are stored in a separate collection to provide
    /// extra <see cref="IList{T}"/> functionality.
    /// </param>
    public ServiceCollectionContainer(
        Container container, Func<IServiceProvider>? serviceProviderLocator = null, bool forEnumeration = false)
    {
        _container = container;
        _serviceProviderLazy = serviceProviderLocator == null 
            ? null 
            : new Lazy<IServiceProvider>(serviceProviderLocator);
        _descriptors = forEnumeration ? new List<ServiceDescriptor>() : null;
    }

    /// <summary> <see cref="SimpleInjector"/>.<see cref="Container"/>. </summary>
    public Container GetContainer() => _container;

    /// <summary>
    /// Registrations are done to the <see cref="SimpleInjector"/>.<see cref="Container"/>, so they follow all it's restrictions.
    /// </summary>
    public void Add(ServiceDescriptor descriptor)
    {
        ArgumentNullException.ThrowIfNull(descriptor);
        if (descriptor.ImplementationType != null)
        {
            GetContainer().Register(descriptor.ServiceType, descriptor.ImplementationType, ToLifestyle(descriptor.Lifetime));
        }
        else if (descriptor.ImplementationFactory != null)
        {
            GetContainer().Register(
                descriptor.ServiceType, 
                Factory(descriptor.ImplementationFactory!),
                ToLifestyle(descriptor.Lifetime));
        }
        else if (descriptor.ImplementationInstance != null)
        {
            if (descriptor.Lifetime != ServiceLifetime.Singleton)
            {
                throw new ArgumentException($"{nameof(descriptor.ImplementationInstance)} can only be used with {nameof(ServiceLifetime.Singleton)} {nameof(ServiceLifetime)}");
            }
            GetContainer().RegisterInstance(descriptor.ServiceType, descriptor.ImplementationInstance);
        }
        else
        {
            throw new ArgumentException("no implementation", nameof(descriptor));
        }
    }
    
    private Func<object> Factory(Func<IServiceProvider?, object> providerFactory)
    {
        return _serviceProviderLazy == null 
            ? () => providerFactory(null) 
            : () => providerFactory(_serviceProviderLazy.Value);
    }

    /// <summary>
    /// Converts <see cref="ServiceLifetime"/> to the equivalent <see cref="Lifestyle"/>.
    /// </summary>
    public static Lifestyle ToLifestyle(ServiceLifetime lifetime)
    {
        return lifetime switch {
            ServiceLifetime.Singleton => Lifestyle.Singleton,
            ServiceLifetime.Scoped => Lifestyle.Scoped,
            ServiceLifetime.Transient => Lifestyle.Transient,
            _ => throw new ArgumentOutOfRangeException(nameof(lifetime), lifetime, null)
        };
    }

    public bool IsReadOnly => GetContainer().IsLocked;

    public void Insert(int index, ServiceDescriptor item)
    {
        Add(item);
        _descriptors?.Insert(index, item);
    }
    
    #region IList<ServiceDescriptor> members that cannot be implemented
    
    public void Clear()
    {
        throw new InvalidOperationException($"Registrations cannot be removed from {nameof(Container)}");
    }

    public bool Remove(ServiceDescriptor item)
    {
        throw new InvalidOperationException($"Registrations cannot be removed from {nameof(Container)}");
    }

    public void RemoveAt(int index)
    {
        throw new InvalidOperationException($"Registrations cannot be removed from {nameof(Container)}");
    }

    #endregion
    #region IList<ServiceDescriptor> members only usable if constructed with forEnumeration

    public bool Contains(ServiceDescriptor item) => _descriptors?.Contains(item) ?? throw InvalidOperation();

    public void CopyTo(ServiceDescriptor[] array, int arrayIndex)
    {
        if (_descriptors == null) throw InvalidOperation();
        _descriptors.CopyTo(array, arrayIndex);
    }

    public int Count => _descriptors?.Count ?? throw InvalidOperation();

    public IEnumerator<ServiceDescriptor> GetEnumerator() => _descriptors?.GetEnumerator() ?? throw InvalidOperation();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable?)_descriptors)?.GetEnumerator() ?? throw InvalidOperation();

    public int IndexOf(ServiceDescriptor item) => _descriptors?.IndexOf(item) ?? throw InvalidOperation();

    public ServiceDescriptor this[int index]
    {
        get => _descriptors?[index] ?? throw InvalidOperation();
        set
        {
            if (_descriptors == null) throw InvalidOperation();
            if (_descriptors[index].ServiceType != value.ServiceType)
            {
                throw new ArgumentException(
                    $"can only replace a registration with a registration of the same type ({_descriptors[index].ServiceType.FullName} expected, {value.ServiceType.FullName} encountered)",
                    nameof(value));
            }
            GetContainer().Options.AllowOverridingRegistrations = true;
            Add(value);
            GetContainer().Options.AllowOverridingRegistrations = false;
            _descriptors[index] = value;
        }
    }

    private static InvalidOperationException InvalidOperation()
    {
        throw new InvalidOperationException("Not constructed with forEnumeration=true");
    }

    #endregion
}
