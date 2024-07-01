<a name='assembly'></a>
# Lib.Storage

## Contents

- [IIdentity\`1](#T-Semantica-Storage-IIdentity`1 'Semantica.Storage.IIdentity`1')
  - [Id](#P-Semantica-Storage-IIdentity`1-Id 'Semantica.Storage.IIdentity`1.Id')
- [IKeyConverter\`2](#T-Semantica-Storage-IKeyConverter`2 'Semantica.Storage.IKeyConverter`2')
  - [ToBlankStorageModel()](#M-Semantica-Storage-IKeyConverter`2-ToBlankStorageModel-`1- 'Semantica.Storage.IKeyConverter`2.ToBlankStorageModel(`1)')
  - [ToKey()](#M-Semantica-Storage-IKeyConverter`2-ToKey-`0- 'Semantica.Storage.IKeyConverter`2.ToKey(`0)')
- [KeyConverter\`2](#T-Semantica-Storage-KeyConverter`2 'Semantica.Storage.KeyConverter`2')

<a name='T-Semantica-Storage-IIdentity`1'></a>
## IIdentity\`1 `type`

##### Namespace

Semantica.Storage

##### Summary



##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId |  |

<a name='P-Semantica-Storage-IIdentity`1-Id'></a>
### Id `property`

##### Summary

Primary key of the entity

<a name='T-Semantica-Storage-IKeyConverter`2'></a>
## IKeyConverter\`2 `type`

##### Namespace

Semantica.Storage

##### Summary

Generic converter used by the base repository to convert keys into storage models and back.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Storage model type |
| TKey | Primary key type for entity |

<a name='M-Semantica-Storage-IKeyConverter`2-ToBlankStorageModel-`1-'></a>
### ToBlankStorageModel() `method`

##### Summary

Creates an empty storage model with only key properties set. Used for removing entities.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-IKeyConverter`2-ToKey-`0-'></a>
### ToKey() `method`

##### Summary

Makes a key from a storage model.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-KeyConverter`2'></a>
## KeyConverter\`2 `type`

##### Namespace

Semantica.Storage

##### Summary

Generic implementation of [IKeyConverter\`2](#T-Semantica-Storage-IKeyConverter`2 'Semantica.Storage.IKeyConverter`2') that can be instantiated with delegate functions to
provide the conversions.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStorage | Type of the storage model class. |
| TKey | Primary key type for the entity or value object in domain. |
