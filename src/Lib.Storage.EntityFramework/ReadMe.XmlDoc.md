<a name='assembly'></a>
# Lib.Storage.EntityFramework

## Contents

- [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory')
- [DbContextFactory\`1](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory`1 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory`1')
- [IDbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory')
  - [CreateDbContext()](#M-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory-CreateDbContext 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory.CreateDbContext')
- [IDbContextFactory\`1](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory`1 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory`1')
  - [CreateAppDbContext()](#M-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory`1-CreateAppDbContext 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory`1.CreateAppDbContext')
- [Inclusion\`2](#T-Semantica-Storage-EntityFramework-DataStores-Inclusion`2 'Semantica.Storage.EntityFramework.DataStores.Inclusion`2')
  - [#ctor(inclusionPrototype,previousInclusion)](#M-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-#ctor-Semantica-Storage-EntityFramework-DataStores-InclusionPrototype{`0,`1},Semantica-Storage-IInclusion{`0}- 'Semantica.Storage.EntityFramework.DataStores.Inclusion`2.#ctor(Semantica.Storage.EntityFramework.DataStores.InclusionPrototype{`0,`1},Semantica.Storage.IInclusion{`0})')
  - [_Storables](#F-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-_Storables 'Semantica.Storage.EntityFramework.DataStores.Inclusion`2._Storables')
  - [Dispose()](#M-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-Dispose 'Semantica.Storage.EntityFramework.DataStores.Inclusion`2.Dispose')
- [Module](#T-Semantica-Storage-EntityFramework-Module 'Semantica.Storage.EntityFramework.Module')
- [ModuleExtensions](#T-Semantica-Storage-EntityFramework-ModuleExtensions 'Semantica.Storage.EntityFramework.ModuleExtensions')
  - [RegisterDbContextFactory\`\`1(serviceCollection)](#M-Semantica-Storage-EntityFramework-ModuleExtensions-RegisterDbContextFactory``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Semantica.Storage.EntityFramework.ModuleExtensions.RegisterDbContextFactory``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [RegisterDefaultDbContextFactory(serviceCollection)](#M-Semantica-Storage-EntityFramework-ModuleExtensions-RegisterDefaultDbContextFactory-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Semantica.Storage.EntityFramework.ModuleExtensions.RegisterDefaultDbContextFactory(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [PropertyBuilderExtensions](#T-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions')
  - [HasOwnedColumnName\`\`1()](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasOwnedColumnName``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0},System-String,System-String- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.HasOwnedColumnName``1(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0},System.String,System.String)')
  - [HasOwnedColumnName\`\`3()](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasOwnedColumnName``3-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0},System-Linq-Expressions-Expression{System-Func{``2,``1}},System-String- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.HasOwnedColumnName``3(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{``0},System.Linq.Expressions.Expression{System.Func{``2,``1}},System.String)')
  - [HasPrecision()](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasPrecision-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-Nullable{System-Decimal}},System-Int32,System-Int32- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.HasPrecision(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.Nullable{System.Decimal}},System.Int32,System.Int32)')
  - [IsCharEnum(unicode)](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsCharEnum-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String},System-Boolean- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.IsCharEnum(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String},System.Boolean)')
  - [IsCharEnumSet(maxValues,unicode)](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsCharEnumSet-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String},System-Int32,System-Boolean- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.IsCharEnumSet(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String},System.Int32,System.Boolean)')
  - [IsDateOnly()](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsDateOnly-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-DateTime}- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.IsDateOnly(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.DateTime})')
  - [IsDateOnly()](#M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsDateOnly-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-Nullable{System-DateTime}}- 'Semantica.Storage.EntityFramework.Config.PropertyBuilderExtensions.IsDateOnly(Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.Nullable{System.DateTime}})')
- [QueryableExtensions](#T-Semantica-Storage-EntityFramework-QueryableExtensions 'Semantica.Storage.EntityFramework.QueryableExtensions')
  - [ToReadOnlyListAsync\`\`1(source,cancellationToken)](#M-Semantica-Storage-EntityFramework-QueryableExtensions-ToReadOnlyListAsync``1-System-Linq-IQueryable{``0},System-Threading-CancellationToken- 'Semantica.Storage.EntityFramework.QueryableExtensions.ToReadOnlyListAsync``1(System.Linq.IQueryable{``0},System.Threading.CancellationToken)')

<a name='T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory'></a>
## DbContextFactory `type`

##### Namespace

Semantica.Storage.EntityFramework.DbContexts

##### Summary

*Inherit from parent.*

##### Remarks

Dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being injected.

Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.

<a name='T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory`1'></a>
## DbContextFactory\`1 `type`

##### Namespace

Semantica.Storage.EntityFramework.DbContexts

##### Summary

*Inherit from parent.*

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDbContext | Type inheriting from [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext'). Must have a constructor with a single argument of type
[DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1'). |

##### Remarks

Dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being injected.

Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.

<a name='T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory'></a>
## IDbContextFactory `type`

##### Namespace

Semantica.Storage.EntityFramework.DbContexts

##### Summary

Used to create instances of [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext').

<a name='M-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory-CreateDbContext'></a>
### CreateDbContext() `method`

##### Summary

Creates the appropriate [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext').

##### Returns

The application's [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext').

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory`1'></a>
## IDbContextFactory\`1 `type`

##### Namespace

Semantica.Storage.EntityFramework.DbContexts

##### Summary

Used to create instances of `TDbContext`.

<a name='M-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory`1-CreateAppDbContext'></a>
### CreateAppDbContext() `method`

##### Summary

Creates the appropriate application specific [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext').

##### Returns

A new instance of the application's `TDbContext`.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-EntityFramework-DataStores-Inclusion`2'></a>
## Inclusion\`2 `type`

##### Namespace

Semantica.Storage.EntityFramework.DataStores

<a name='M-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-#ctor-Semantica-Storage-EntityFramework-DataStores-InclusionPrototype{`0,`1},Semantica-Storage-IInclusion{`0}-'></a>
### #ctor(inclusionPrototype,previousInclusion) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inclusionPrototype | [Semantica.Storage.EntityFramework.DataStores.InclusionPrototype{\`0,\`1}](#T-Semantica-Storage-EntityFramework-DataStores-InclusionPrototype{`0,`1} 'Semantica.Storage.EntityFramework.DataStores.InclusionPrototype{`0,`1}') |  |
| previousInclusion | [Semantica.Storage.IInclusion{\`0}](#T-Semantica-Storage-IInclusion{`0} 'Semantica.Storage.IInclusion{`0}') |  |

<a name='F-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-_Storables'></a>
### _Storables `constants`

##### Summary

StorageModels worden alleen opgeslagen in de eerste/diepste inclusion. Een inclusion heeft dus nooit een List van
storables én een [PreviousInclusion](#P-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-PreviousInclusion 'Semantica.Storage.EntityFramework.DataStores.Inclusion`2.PreviousInclusion').

<a name='M-Semantica-Storage-EntityFramework-DataStores-Inclusion`2-Dispose'></a>
### Dispose() `method`

##### Summary

Bij de dispose van de inclusion wordt in alle geregistreerde storage models de navigation property van de inclusion weer op null gezet.
    Dat betekent niet dat de verwijzing naar dat entity wordt verwijdert, maar wel dat er geen onbedoelde inserts worden gedaan bij een update op de entity.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-EntityFramework-Module'></a>
## Module `type`

##### Namespace

Semantica.Storage.EntityFramework

##### Summary

Module that registers implementations of:

The module is dependent on implementations in the [](#N-Semantica-Storage 'Semantica.Storage').[](#N-Semantica-Storage-Data 'Semantica.Storage.Data')
assembly.

<a name='T-Semantica-Storage-EntityFramework-ModuleExtensions'></a>
## ModuleExtensions `type`

##### Namespace

Semantica.Storage.EntityFramework

<a name='M-Semantica-Storage-EntityFramework-ModuleExtensions-RegisterDbContextFactory``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterDbContextFactory\`\`1(serviceCollection) `method`

##### Summary

Registers the [DbContextFactory\`1](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory`1 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory`1') using the provided `TDbContext`
as implementation for both the generic and base type [IDbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Container/[ServiceCollection](#T-Microsoft-Extensions-DependencyInjection-ServiceCollection 'Microsoft.Extensions.DependencyInjection.ServiceCollection') to add the registrations to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDbContext | Implmentation of [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') to register. |

##### Remarks

Registration is done with [Scoped](#F-Microsoft-Extensions-DependencyInjection-ServiceLifetime-Scoped 'Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped')[ServiceLifetime](#T-Microsoft-Extensions-DependencyInjection-ServiceLifetime 'Microsoft.Extensions.DependencyInjection.ServiceLifetime').

The [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory') implementation is dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being
registered. Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.

<a name='M-Semantica-Storage-EntityFramework-ModuleExtensions-RegisterDefaultDbContextFactory-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### RegisterDefaultDbContextFactory(serviceCollection) `method`

##### Summary

Registers the untyped [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory') as implementation for the base type
[IDbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-IDbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.IDbContextFactory').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceCollection | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Container/[ServiceCollection](#T-Microsoft-Extensions-DependencyInjection-ServiceCollection 'Microsoft.Extensions.DependencyInjection.ServiceCollection') to add the registrations to. |

##### Remarks

Registration is done with [Scoped](#F-Microsoft-Extensions-DependencyInjection-ServiceLifetime-Scoped 'Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped')[ServiceLifetime](#T-Microsoft-Extensions-DependencyInjection-ServiceLifetime 'Microsoft.Extensions.DependencyInjection.ServiceLifetime').

The [DbContextFactory](#T-Semantica-Storage-EntityFramework-DbContexts-DbContextFactory 'Semantica.Storage.EntityFramework.DbContexts.DbContextFactory') implementation is dependent on [DbContextOptions\`1](#T-Microsoft-EntityFrameworkCore-DbContextOptions`1 'Microsoft.EntityFrameworkCore.DbContextOptions`1') being
registered. Registration of that dependency in the DI container would by typically done by calling
[AddDbContext\`\`1](#M-Microsoft-Extensions-DependencyInjection-EntityFrameworkServiceCollectionExtensions-AddDbContext``1-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-DependencyInjection-ServiceLifetime,Microsoft-Extensions-DependencyInjection-ServiceLifetime- 'Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)')
, or one of it's overloads.

<a name='T-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions'></a>
## PropertyBuilderExtensions `type`

##### Namespace

Semantica.Storage.EntityFramework.Config

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasOwnedColumnName``1-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0},System-String,System-String-'></a>
### HasOwnedColumnName\`\`1() `method`

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasOwnedColumnName``3-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{``0},System-Linq-Expressions-Expression{System-Func{``2,``1}},System-String-'></a>
### HasOwnedColumnName\`\`3() `method`

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-HasPrecision-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-Nullable{System-Decimal}},System-Int32,System-Int32-'></a>
### HasPrecision() `method`

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsCharEnum-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String},System-Boolean-'></a>
### IsCharEnum(unicode) `method`

##### Summary

Configures the column as a nchar(1) or char(1) column, so it can store a single unicode or ascii character. An enum type
that is defined as a ushort can be assigned char values. Use [CharEnumConverter](#T-Semantica-Storage-CharEnums-CharEnumConverter 'Semantica.Storage.CharEnums.CharEnumConverter') to
convert between enum values to string values.

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| unicode | [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String}](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String} 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String}') | Optional. If `true`, the column supports unicode, otherwise only ASCII. |

##### Remarks

If you want to use different cased characters for different enum values, make sure either the database does case
sensitive string comparison, or add appropriate
.

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsCharEnumSet-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String},System-Int32,System-Boolean-'></a>
### IsCharEnumSet(maxValues,unicode) `method`

##### Summary

Configures the column as a nchar() or char() column, so it can store a number of unicode or ascii character. An enum
type that is defined as a ushort can be assigned char values. Use [CharEnumConverter](#T-Semantica-Storage-CharEnums-CharEnumConverter 'Semantica.Storage.CharEnums.CharEnumConverter') to
convert between enum values to string values.

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxValues | [Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String}](#T-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-String} 'Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder{System.String}') | The maximum amount of enum values that can be stored in the column. |
| unicode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Optional. If `true`, the column supports unicode, otherwise only ASCII. |

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsDateOnly-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-DateTime}-'></a>
### IsDateOnly() `method`

##### Summary

Configureert een DateTime property als een date-only veld.
    Voor gebruik in FluentAPI configuratie.

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-EntityFramework-Config-PropertyBuilderExtensions-IsDateOnly-Microsoft-EntityFrameworkCore-Metadata-Builders-PropertyBuilder{System-Nullable{System-DateTime}}-'></a>
### IsDateOnly() `method`

##### Summary

Configureert een DateTime property als een date-only veld.
    Voor gebruik in FluentAPI configuratie.

##### Returns

The same builder instance so that multiple configuration calls can be chained.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-EntityFramework-QueryableExtensions'></a>
## QueryableExtensions `type`

##### Namespace

Semantica.Storage.EntityFramework

<a name='M-Semantica-Storage-EntityFramework-QueryableExtensions-ToReadOnlyListAsync``1-System-Linq-IQueryable{``0},System-Threading-CancellationToken-'></a>
### ToReadOnlyListAsync\`\`1(source,cancellationToken) `method`

##### Summary

Asynchronously creates a [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') from an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') by enumerating it
    asynchronously, and casting it to a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1').

##### Returns

A task that represents the asynchronous operation.
    The task result contains a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains elements from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') to create a list from. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while waiting for the task to complete. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of the elements of `source`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `source` is `null`. |
| [System.OperationCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.OperationCanceledException 'System.OperationCanceledException') | If the [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') is canceled. |

##### Remarks

Multiple active operations on the same context instance are not supported. Use `await` to ensure
        that any asynchronous operations have completed before calling another method on this context.
        See  for more information.

See  for more information.
