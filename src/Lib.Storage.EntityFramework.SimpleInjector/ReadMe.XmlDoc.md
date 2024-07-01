<a name='assembly'></a>
# Lib.Storage.EntityFramework.SimpleInjector

## Contents

- [ModuleExtensions](#T-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions 'Semantica.Storage.EntityFramework.SimpleInjector.ModuleExtensions')
  - [RegisterDbContextFactory\`\`1(container)](#M-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions-RegisterDbContextFactory``1-SimpleInjector-Container- 'Semantica.Storage.EntityFramework.SimpleInjector.ModuleExtensions.RegisterDbContextFactory``1(SimpleInjector.Container)')
  - [RegisterDefaultDbContextFactory(container)](#M-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions-RegisterDefaultDbContextFactory-SimpleInjector-Container- 'Semantica.Storage.EntityFramework.SimpleInjector.ModuleExtensions.RegisterDefaultDbContextFactory(SimpleInjector.Container)')

<a name='T-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions'></a>
## ModuleExtensions `type`

##### Namespace

Semantica.Storage.EntityFramework.SimpleInjector

<a name='M-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions-RegisterDbContextFactory``1-SimpleInjector-Container-'></a>
### RegisterDbContextFactory\`\`1(container) `method`

##### Summary

Registers the [DbContextFactory\`1](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory`1 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory`1') using the provided `TDbContext`
as implementation for both the generic and base type [IDbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SimpleInjector.Container](#T-SimpleInjector-Container 'SimpleInjector.Container') | [Container](#T-SimpleInjector-Container 'SimpleInjector.Container') to add the registrations to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDbContext | Implementation of [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') to register. |

##### Remarks

Registration is done with [Scoped](#F-SimpleInjector-Lifestyle-Scoped 'SimpleInjector.Lifestyle.Scoped')[Lifestyle](#T-SimpleInjector-Lifestyle 'SimpleInjector.Lifestyle').

The [DbContextFactory\`1](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory`1 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory`1') implementation is dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being registered.
Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.

<a name='M-Semantica-Storage-EntityFramework-SimpleInjector-ModuleExtensions-RegisterDefaultDbContextFactory-SimpleInjector-Container-'></a>
### RegisterDefaultDbContextFactory(container) `method`

##### Summary

Registers the untyped [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory') as implementation for the base type
[IDbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SimpleInjector.Container](#T-SimpleInjector-Container 'SimpleInjector.Container') | [Container](#T-SimpleInjector-Container 'SimpleInjector.Container') to add the registrations to. |

##### Remarks

Registration is done with [Scoped](#F-SimpleInjector-Lifestyle-Scoped 'SimpleInjector.Lifestyle.Scoped')[Lifestyle](#T-SimpleInjector-Lifestyle 'SimpleInjector.Lifestyle').

The [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory') implementation is dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being
registered. Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.
