<a name='assembly'></a>
# Lib.Domain.Data

## Contents

- [AddRemoveRepositoryBase\`4](#T-Semantica-Domain-Data-Repositories-AddRemoveRepositoryBase`4 'Semantica.Domain.Data.Repositories.AddRemoveRepositoryBase`4')
- [DomainIsStorageConverter\`2](#T-Semantica-Domain-Data-DomainStorageConverters-DomainIsStorageConverter`2 'Semantica.Domain.Data.DomainStorageConverters.DomainIsStorageConverter`2')
- [IAddRemoveReadConverter\`3](#T-Semantica-Domain-Data-DomainStorageConverters-IAddRemoveReadConverter`3 'Semantica.Domain.Data.DomainStorageConverters.IAddRemoveReadConverter`3')
- [IAddRemoveReadConverter\`4](#T-Semantica-Domain-Data-DomainStorageConverters-IAddRemoveReadConverter`4 'Semantica.Domain.Data.DomainStorageConverters.IAddRemoveReadConverter`4')
- [IAggregationStorageConverter\`2](#T-Semantica-Domain-Data-DomainStorageConverters-IAggregationStorageConverter`2 'Semantica.Domain.Data.DomainStorageConverters.IAggregationStorageConverter`2')
  - [ToAggregation()](#M-Semantica-Domain-Data-DomainStorageConverters-IAggregationStorageConverter`2-ToAggregation-`0- 'Semantica.Domain.Data.DomainStorageConverters.IAggregationStorageConverter`2.ToAggregation(`0)')
- [ICommonPropertyDomainConverter\`2](#T-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyDomainConverter`2 'Semantica.Domain.Data.DomainStorageConverters.ICommonPropertyDomainConverter`2')
  - [SetCommonDomainProperties(domainModel,storageModel)](#M-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyDomainConverter`2-SetCommonDomainProperties-`1,`0- 'Semantica.Domain.Data.DomainStorageConverters.ICommonPropertyDomainConverter`2.SetCommonDomainProperties(`1,`0)')
- [ICommonPropertyStorageConverter\`2](#T-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyStorageConverter`2 'Semantica.Domain.Data.DomainStorageConverters.ICommonPropertyStorageConverter`2')
  - [SetCommonStorageProperties(storageModel,domainModel)](#M-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyStorageConverter`2-SetCommonStorageProperties-`0,`1- 'Semantica.Domain.Data.DomainStorageConverters.ICommonPropertyStorageConverter`2.SetCommonStorageProperties(`0,`1)')
- [IDomainConverter\`2](#T-Semantica-Domain-Data-DomainStorageConverters-IDomainConverter`2 'Semantica.Domain.Data.DomainStorageConverters.IDomainConverter`2')
  - [ToStorage()](#M-Semantica-Domain-Data-DomainStorageConverters-IDomainConverter`2-ToStorage-`1- 'Semantica.Domain.Data.DomainStorageConverters.IDomainConverter`2.ToStorage(`1)')
- [IDomainStorageConverter\`3](#T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`3 'Semantica.Domain.Data.DomainStorageConverters.IDomainStorageConverter`3')
- [IDomainStorageConverter\`4](#T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`4 'Semantica.Domain.Data.DomainStorageConverters.IDomainStorageConverter`4')
- [IDomainStorageConverter\`5](#T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`5 'Semantica.Domain.Data.DomainStorageConverters.IDomainStorageConverter`5')
- [IPropertyAnalyser](#T-Semantica-Domain-Data-Repositories-IPropertyAnalyser 'Semantica.Domain.Data.Repositories.IPropertyAnalyser')
  - [GetOrAnalyse\`\`1()](#M-Semantica-Domain-Data-Repositories-IPropertyAnalyser-GetOrAnalyse``1 'Semantica.Domain.Data.Repositories.IPropertyAnalyser.GetOrAnalyse``1')
- [IPropertyIdentifier](#T-Semantica-Domain-Data-Repositories-IPropertyIdentifier 'Semantica.Domain.Data.Repositories.IPropertyIdentifier')
- [IStorageConverter\`3](#T-Semantica-Domain-Data-DomainStorageConverters-IStorageConverter`3 'Semantica.Domain.Data.DomainStorageConverters.IStorageConverter`3')
  - [ToDomain()](#M-Semantica-Domain-Data-DomainStorageConverters-IStorageConverter`3-ToDomain-`0- 'Semantica.Domain.Data.DomainStorageConverters.IStorageConverter`3.ToDomain(`0)')
- [IStorageReplicator\`2](#T-Semantica-Domain-Data-DomainStorageConverters-IStorageReplicator`2 'Semantica.Domain.Data.DomainStorageConverters.IStorageReplicator`2')
  - [Replicate(storageModel,newKey)](#M-Semantica-Domain-Data-DomainStorageConverters-IStorageReplicator`2-Replicate-`0,System-Nullable{`1}- 'Semantica.Domain.Data.DomainStorageConverters.IStorageReplicator`2.Replicate(`0,System.Nullable{`1})')
- [Module](#T-Semantica-Domain-Data-Module 'Semantica.Domain.Data.Module')
- [PropertyAnalyser](#T-Semantica-Domain-Data-Repositories-PropertyAnalyser 'Semantica.Domain.Data.Repositories.PropertyAnalyser')
- [PropertyAnalysisResult](#T-Semantica-Domain-Data-Repositories-PropertyAnalysisResult 'Semantica.Domain.Data.Repositories.PropertyAnalysisResult')
  - [ImmutableProperties](#P-Semantica-Domain-Data-Repositories-PropertyAnalysisResult-ImmutableProperties 'Semantica.Domain.Data.Repositories.PropertyAnalysisResult.ImmutableProperties')
- [PropertyIdentifier](#T-Semantica-Domain-Data-Repositories-PropertyIdentifier 'Semantica.Domain.Data.Repositories.PropertyIdentifier')
- [ReadRepositoryBase\`3](#T-Semantica-Domain-Data-Repositories-ReadRepositoryBase`3 'Semantica.Domain.Data.Repositories.ReadRepositoryBase`3')
- [RepositoryBase\`3](#T-Semantica-Domain-Data-Repositories-RepositoryBase`3 'Semantica.Domain.Data.Repositories.RepositoryBase`3')
- [RepositoryBase\`4](#T-Semantica-Domain-Data-Repositories-RepositoryBase`4 'Semantica.Domain.Data.Repositories.RepositoryBase`4')
- [RepositoryBase\`5](#T-Semantica-Domain-Data-Repositories-RepositoryBase`5 'Semantica.Domain.Data.Repositories.RepositoryBase`5')

<a name='T-Semantica-Domain-Data-Repositories-AddRemoveRepositoryBase`4'></a>
## AddRemoveRepositoryBase\`4 `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

*Inherit from parent.*

##### Summary

Base class that provides default implementations for all methods of
[IAddRemoveRepository\`3](#T-Semantica-Domain-Repositories-IAddRemoveRepository`3 'Semantica.Domain.Repositories.IAddRemoveRepository`3').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class used to represent the entity or value object. |

##### Remarks

Use when different model types are used for add and read methods.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-DomainIsStorageConverter`2'></a>
## DomainIsStorageConverter\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Generic implementation for [IDomainStorageConverter\`3](#T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`3 'Semantica.Domain.Data.DomainStorageConverters.IDomainStorageConverter`3'), used when TStorage and TDomain are
the same type (i.e., the storage type is also used as domain type). The implementation requires injecting a
[IKeyConverter\`2](#T-Semantica-Storage-IKeyConverter`2 'Semantica.Storage.IKeyConverter`2').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | Model type used for storage and domain. |
| TKey | Primary key type for the entity or value object in domain. |

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IAddRemoveReadConverter`3'></a>
## IAddRemoveReadConverter\`3 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models and back of one entity or
value object. This is the full interface required by [AddRemoveRepositoryBase\`4](#T-Semantica-Domain-Data-Repositories-AddRemoveRepositoryBase`4 'Semantica.Domain.Data.Repositories.AddRemoveRepositoryBase`4')
base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomain | Domain model type. |
| TKey | Primary key type for the entity or value object in domain. |

##### Remarks

Use when the same model type is used for add and read methods.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IAddRemoveReadConverter`4'></a>
## IAddRemoveReadConverter\`4 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models and back of one entity or
value object. This is the full interface required by [AddRemoveRepositoryBase\`4](#T-Semantica-Domain-Data-Repositories-AddRemoveRepositoryBase`4 'Semantica.Domain.Data.Repositories.AddRemoveRepositoryBase`4')
base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomainOut | Domain model type. |
| TDomainAdd | Domain model type used for creation. |
| TKey | Primary key type for the entity or value object in domain. |

##### Remarks

Use when different model types are used for add and read methods.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IAggregationStorageConverter`2'></a>
## IAggregationStorageConverter\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface to convert storage models to domain models of one entity or value object. The domain model type is the
type used as the aggregation domain model. i.e. a model type with properties that reference other domain model types, and
is not used in the repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomain | Aggregation domain model type. |

##### Remarks

Implement this interface on a domain storage converter when you have an aggregation model type, and use it in your
aggregators.

<a name='M-Semantica-Domain-Data-DomainStorageConverters-IAggregationStorageConverter`2-ToAggregation-`0-'></a>
### ToAggregation() `method`

##### Summary

Converts a storage model instance to its domain model representation.

##### Returns

Domain model instance.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyDomainConverter`2'></a>
## ICommonPropertyDomainConverter\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface that is not directly used by repository base classes, but can be helpful as a way to standarize common
property assignment in converters when multiple ToStorage implementations are needed.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model. |
| TDomainCommon | Domain base class/interface that has the common properties. |

<a name='M-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyDomainConverter`2-SetCommonDomainProperties-`1,`0-'></a>
### SetCommonDomainProperties(domainModel,storageModel) `method`

##### Summary

Sets the properties on `domainModel` that can be accessed through the
`TDomainCommon` type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainModel | [\`1](#T-`1 '`1') | Domain model instance (as base type) to set the properties on. |
| storageModel | [\`0](#T-`0 '`0') | Storage model instance to get the values from. |

<a name='T-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyStorageConverter`2'></a>
## ICommonPropertyStorageConverter\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface that is not directly used by repository base classes, but can be helpful as a way to standarize common
property assignment in converters when multiple ToStorage implementations are needed.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model. |
| TDomainCommon | Domain base class/interface that has the common properties. |

<a name='M-Semantica-Domain-Data-DomainStorageConverters-ICommonPropertyStorageConverter`2-SetCommonStorageProperties-`0,`1-'></a>
### SetCommonStorageProperties(storageModel,domainModel) `method`

##### Summary

Sets the properties on `storageModel` that can be accessed through the
`TDomainCommon` type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| storageModel | [\`0](#T-`0 '`0') | Storage model instance to set the properties on. |
| domainModel | [\`1](#T-`1 '`1') | Domain model instance (as base type) to get the values from. |

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IDomainConverter`2'></a>
## IDomainConverter\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert domain models to storage models of one entity or value object.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomain | Domain model type. |

<a name='M-Semantica-Domain-Data-DomainStorageConverters-IDomainConverter`2-ToStorage-`1-'></a>
### ToStorage() `method`

##### Summary

Converts a domain model instance to its storage model representation.

##### Returns

Storage model instance.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`3'></a>
## IDomainStorageConverter\`3 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models and back of one entity or
value object. This is the full interface required by
[RepositoryBase\`3](#T-Semantica-Domain-Data-Repositories-RepositoryBase`3 'Semantica.Domain.Data.Repositories.RepositoryBase`3') base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type |
| TDomain | Confined domain model type |
| TKey | Primary key type for entity/model |

##### Remarks

Use when the same model type is used for add, replace and read methods.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`4'></a>
## IDomainStorageConverter\`4 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models and back of one entity or
value object. This is the full interface required by
[RepositoryBase\`4](#T-Semantica-Domain-Data-Repositories-RepositoryBase`4 'Semantica.Domain.Data.Repositories.RepositoryBase`4') base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomainAdd | Domain model type for creating. |
| TDomain | Domain model type. |
| TKey | Primary key type for the entity or value object in domain. |

##### Remarks

Use when one model type is used for adds and another for replace and read methods.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IDomainStorageConverter`5'></a>
## IDomainStorageConverter\`5 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models and back of one entity or
value object. This is the full interface required by
[RepositoryBase\`5](#T-Semantica-Domain-Data-Repositories-RepositoryBase`5 'Semantica.Domain.Data.Repositories.RepositoryBase`5') base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomainOut | Domain model type |
| TDomainAdd | Domain model type for creating. |
| TDomainReplace | Domain model type used for replacing. |
| TKey | Primary key type for the entity or value object in domain. |

##### Remarks

Use when different model types are used for add, replace and read methods.

<a name='T-Semantica-Domain-Data-Repositories-IPropertyAnalyser'></a>
## IPropertyAnalyser `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

Interface for functionality to analyse properties of a storage model type, in order to identify immutable properties. Used
by repositories for replace methods.

<a name='M-Semantica-Domain-Data-Repositories-IPropertyAnalyser-GetOrAnalyse``1'></a>
### GetOrAnalyse\`\`1() `method`

##### Summary

Analyse type `T` for immutable properties.

##### Returns

A newly generated or cached [PropertyAnalysisResult](#T-Semantica-Domain-Data-Repositories-PropertyAnalysisResult 'Semantica.Domain.Data.Repositories.PropertyAnalysisResult') for the provided type.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type to analyse. |

<a name='T-Semantica-Domain-Data-Repositories-IPropertyIdentifier'></a>
## IPropertyIdentifier `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

Can identify an immutable storage property using its [PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo'). Used in the default implementation of
[IPropertyAnalyser](#T-Semantica-Domain-Data-Repositories-IPropertyAnalyser 'Semantica.Domain.Data.Repositories.IPropertyAnalyser'). Register/inject custom implementations of this interface to use a different method of
identifying immutable properties than the (default) [ImmutableAttribute](#T-Semantica-Storage-Attributes-ImmutableAttribute 'Semantica.Storage.Attributes.ImmutableAttribute').

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IStorageConverter`3'></a>
## IStorageConverter\`3 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

Converter interface used by the base repository to convert storage models to domain models of one entity or value object.
This is the full interface required by [ReadRepositoryBase\`3](#T-Semantica-Domain-Data-Repositories-ReadRepositoryBase`3 'Semantica.Domain.Data.Repositories.ReadRepositoryBase`3') base class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type. |
| TDomain | Domain model type. |
| TKey | Primary key type for the entity or value object in domain. |

<a name='M-Semantica-Domain-Data-DomainStorageConverters-IStorageConverter`3-ToDomain-`0-'></a>
### ToDomain() `method`

##### Summary

Converts a storage model instance to its domain model representation.

##### Returns

Domain model instance.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-Data-DomainStorageConverters-IStorageReplicator`2'></a>
## IStorageReplicator\`2 `type`

##### Namespace

Semantica.Domain.Data.DomainStorageConverters

##### Summary

A converter interface used to make replicates (copies) of a storage model. Replicating creates a new instance (key is not
copied), with the same values as the original, that can be added using the datastore. If the primary key is generated in
the storage system (e.g. database) itself, new key value should not be provided, otherwise it should.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model. |
| TKey | Primary key type for the entity or value object in domain. |

<a name='M-Semantica-Domain-Data-DomainStorageConverters-IStorageReplicator`2-Replicate-`0,System-Nullable{`1}-'></a>
### Replicate(storageModel,newKey) `method`

##### Summary

Makes a copy of `storageModel`. Primary key is not copied.

##### Returns

A new storage model instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| storageModel | [\`0](#T-`0 '`0') | Storage model instance to copy. |
| newKey | [System.Nullable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{`1}') | Optional. Primary key value for the new instance. Omit iff storage system generates the new id. |

<a name='T-Semantica-Domain-Data-Module'></a>
## Module `type`

##### Namespace

Semantica.Domain.Data

##### Summary

Module that registers implementations of:

<a name='T-Semantica-Domain-Data-Repositories-PropertyAnalyser'></a>
## PropertyAnalyser `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

Default implementation of [IPropertyAnalyser](#T-Semantica-Domain-Data-Repositories-IPropertyAnalyser 'Semantica.Domain.Data.Repositories.IPropertyAnalyser'), that uses the injected [IPropertyIdentifier](#T-Semantica-Domain-Data-Repositories-IPropertyIdentifier 'Semantica.Domain.Data.Repositories.IPropertyIdentifier') to
determine immutable properties for any analysed model type. The [PropertyAnalysisResult](#T-Semantica-Domain-Data-Repositories-PropertyAnalysisResult 'Semantica.Domain.Data.Repositories.PropertyAnalysisResult') is stored statically
for each analysed type, so the analysis is only done once.

<a name='T-Semantica-Domain-Data-Repositories-PropertyAnalysisResult'></a>
## PropertyAnalysisResult `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

Holdings the result of property analysis of a single type. Used in [PropertyAnalyser](#T-Semantica-Domain-Data-Repositories-PropertyAnalyser 'Semantica.Domain.Data.Repositories.PropertyAnalyser').

<a name='P-Semantica-Domain-Data-Repositories-PropertyAnalysisResult-ImmutableProperties'></a>
### ImmutableProperties `property`

##### Summary

A list of all immutable properties of the analysed type.

<a name='T-Semantica-Domain-Data-Repositories-PropertyIdentifier'></a>
## PropertyIdentifier `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

Default implementation for [IPropertyIdentifier](#T-Semantica-Domain-Data-Repositories-IPropertyIdentifier 'Semantica.Domain.Data.Repositories.IPropertyIdentifier'), detecting the [ImmutableAttribute](#T-Semantica-Storage-Attributes-ImmutableAttribute 'Semantica.Storage.Attributes.ImmutableAttribute') on properties
to determine mutability.

<a name='T-Semantica-Domain-Data-Repositories-ReadRepositoryBase`3'></a>
## ReadRepositoryBase\`3 `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

*Inherit from parent.*

##### Summary

Base class that provides default implementations for all methods of [IReadRepository\`2](#T-Semantica-Domain-Repositories-IReadRepository`2 'Semantica.Domain.Repositories.IReadRepository`2').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class used to represent the entity or value object. |

<a name='T-Semantica-Domain-Data-Repositories-RepositoryBase`3'></a>
## RepositoryBase\`3 `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

*Inherit from parent.*

##### Summary

Base class that provides default implementations for all methods of [IRepository\`2](#T-Semantica-Domain-Repositories-IRepository`2 'Semantica.Domain.Repositories.IRepository`2').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class used to represent the entity or value object. |

##### Remarks

Use when the same model type is used for add, replace and read methods.

<a name='T-Semantica-Domain-Data-Repositories-RepositoryBase`4'></a>
## RepositoryBase\`4 `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

*Inherit from parent.*

##### Summary

Base class that provides default implementations for all methods of [IRepository\`3](#T-Semantica-Domain-Repositories-IRepository`3 'Semantica.Domain.Repositories.IRepository`3').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class used to represent the entity or value object. |

##### Remarks

Use when one model type is used for adds and another for replace and read methods.

<a name='T-Semantica-Domain-Data-Repositories-RepositoryBase`5'></a>
## RepositoryBase\`5 `type`

##### Namespace

Semantica.Domain.Data.Repositories

##### Summary

*Inherit from parent.*

##### Summary

Base class that provides default implementations for all methods of
[IRepository\`4](#T-Semantica-Domain-Repositories-IRepository`4 'Semantica.Domain.Repositories.IRepository`4').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class used to represent the entity or value object. |

##### Remarks

Use when different model types are used for add, replace and read methods.
