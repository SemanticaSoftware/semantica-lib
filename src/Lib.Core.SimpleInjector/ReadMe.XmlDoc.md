<a name='assembly'></a>
# Lib.Core.SimpleInjector

## Contents

- [ModuleExtensions](#T-Semantica-Core-SimpleInjector-ModuleExtensions 'Semantica.Core.SimpleInjector.ModuleExtensions')
  - [RegisterTransientDisposable\`\`2()](#M-Semantica-Core-SimpleInjector-ModuleExtensions-RegisterTransientDisposable``2-SimpleInjector-Container,System-String- 'Semantica.Core.SimpleInjector.ModuleExtensions.RegisterTransientDisposable``2(SimpleInjector.Container,System.String)')
- [ServiceCollectionContainer](#T-Semantica-Core-SimpleInjector-ServiceCollectionContainer 'Semantica.Core.SimpleInjector.ServiceCollectionContainer')
  - [#ctor(container,serviceProviderLocator,forEnumeration)](#M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-#ctor-SimpleInjector-Container,System-Func{System-IServiceProvider},System-Boolean- 'Semantica.Core.SimpleInjector.ServiceCollectionContainer.#ctor(SimpleInjector.Container,System.Func{System.IServiceProvider},System.Boolean)')
  - [Add()](#M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-Add-Microsoft-Extensions-DependencyInjection-ServiceDescriptor- 'Semantica.Core.SimpleInjector.ServiceCollectionContainer.Add(Microsoft.Extensions.DependencyInjection.ServiceDescriptor)')
  - [GetContainer()](#M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-GetContainer 'Semantica.Core.SimpleInjector.ServiceCollectionContainer.GetContainer')
  - [ToLifestyle()](#M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-ToLifestyle-Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Semantica.Core.SimpleInjector.ServiceCollectionContainer.ToLifestyle(Microsoft.Extensions.DependencyInjection.ServiceLifetime)')

<a name='T-Semantica-Core-SimpleInjector-ModuleExtensions'></a>
## ModuleExtensions `type`

##### Namespace

Semantica.Core.SimpleInjector

<a name='M-Semantica-Core-SimpleInjector-ModuleExtensions-RegisterTransientDisposable``2-SimpleInjector-Container,System-String-'></a>
### RegisterTransientDisposable\`\`2() `method`

##### Summary

Registers `TImplementation` as [Transient](#F-SimpleInjector-Lifestyle-Transient 'SimpleInjector.Lifestyle.Transient') implementation of
`TInterface`. Use when the system that will create the instance is always going to be responsible for
disposing it.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Core-SimpleInjector-ServiceCollectionContainer'></a>
## ServiceCollectionContainer `type`

##### Namespace

Semantica.Core.SimpleInjector

##### Summary

Implementation of [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection'), so the modules can be built up using the extensions provided by
[ServiceCollectionServiceExtensions](#T-Microsoft-Extensions-DependencyInjection-ServiceCollectionServiceExtensions 'Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions'), but using [](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector').[Container](#T-SimpleInjector-Container 'SimpleInjector.Container') as the
actual implementation.

##### Remarks

Registrations are done to [](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector').[Container](#T-SimpleInjector-Container 'SimpleInjector.Container'), so they follow all it's restrictions.  
If [](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector') specific functionality is required, cast the [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to
[ServiceCollectionContainer](#T-Semantica-Core-SimpleInjector-ServiceCollectionContainer 'Semantica.Core.SimpleInjector.ServiceCollectionContainer') to retrieve the actual [Container](#T-SimpleInjector-Container 'SimpleInjector.Container').

<a name='M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-#ctor-SimpleInjector-Container,System-Func{System-IServiceProvider},System-Boolean-'></a>
### #ctor(container,serviceProviderLocator,forEnumeration) `constructor`

##### Summary

Instantiate when calling the root [ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1') implementation's
[Register](#M-Semantica-Core-DependencyInjection-ModuleBase`1-Register-`0,System-Boolean- 'Semantica.Core.DependencyInjection.ModuleBase`1.Register(`0,System.Boolean)') method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SimpleInjector.Container](#T-SimpleInjector-Container 'SimpleInjector.Container') | The [](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector').[Container](#T-SimpleInjector-Container 'SimpleInjector.Container') instance used in the application. |
| serviceProviderLocator | [System.Func{System.IServiceProvider}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.IServiceProvider}') | A function that can produce a [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to be used with
[ImplementationFactory](#P-Microsoft-Extensions-DependencyInjection-ServiceDescriptor-ImplementationFactory 'Microsoft.Extensions.DependencyInjection.ServiceDescriptor.ImplementationFactory'). |
| forEnumeration | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | When `true`, all added [ServiceDescriptor](#T-Microsoft-Extensions-DependencyInjection-ServiceDescriptor 'Microsoft.Extensions.DependencyInjection.ServiceDescriptor') are stored in a separate collection to provide
extra [IList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList`1 'System.Collections.Generic.IList`1') functionality. |

##### Remarks

The locator can be omitted (`null`), but only if all Factory-registrations don't use the
[IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') argument. Determining this is the responsibility of the implementor.

<a name='M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-Add-Microsoft-Extensions-DependencyInjection-ServiceDescriptor-'></a>
### Add() `method`

##### Summary

Registrations are done to the [](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector').[Container](#T-SimpleInjector-Container 'SimpleInjector.Container'), so they follow all it's restrictions.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-GetContainer'></a>
### GetContainer() `method`

##### Summary

[](#N-Semantica-Core-SimpleInjector 'Semantica.Core.SimpleInjector').[Container](#T-SimpleInjector-Container 'SimpleInjector.Container').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-SimpleInjector-ServiceCollectionContainer-ToLifestyle-Microsoft-Extensions-DependencyInjection-ServiceLifetime-'></a>
### ToLifestyle() `method`

##### Summary

Converts [ServiceLifetime](#T-Microsoft-Extensions-DependencyInjection-ServiceLifetime 'Microsoft.Extensions.DependencyInjection.ServiceLifetime') to the equivalent [Lifestyle](#T-SimpleInjector-Lifestyle 'SimpleInjector.Lifestyle').

##### Parameters

This method has no parameters.
