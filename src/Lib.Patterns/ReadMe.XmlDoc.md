<a name='assembly'></a>
# Lib.Patterns

## Contents

- [CanBeEmptyCollectionExtensions](#T-Semantica-Patterns-CanBeEmptyCollectionExtensions 'Semantica.Patterns.CanBeEmptyCollectionExtensions')
  - [FirstNonEmpty\`\`1(enumerable)](#M-Semantica-Patterns-CanBeEmptyCollectionExtensions-FirstNonEmpty``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Patterns.CanBeEmptyCollectionExtensions.FirstNonEmpty``1(System.Collections.Generic.IEnumerable{``0})')
  - [GetValue\`\`2(dictionary,key)](#M-Semantica-Patterns-CanBeEmptyCollectionExtensions-GetValue``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1},``0- 'Semantica.Patterns.CanBeEmptyCollectionExtensions.GetValue``2(System.Collections.Generic.IReadOnlyDictionary{``0,``1},``0)')
  - [WhereNotEmpty\`\`1(enumerable)](#M-Semantica-Patterns-CanBeEmptyCollectionExtensions-WhereNotEmpty``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Patterns.CanBeEmptyCollectionExtensions.WhereNotEmpty``1(System.Collections.Generic.IEnumerable{``0})')
- [CanBeEmptyExtensions](#T-Semantica-Patterns-CanBeEmptyExtensions 'Semantica.Patterns.CanBeEmptyExtensions')
  - [CanBeEmptyToNullable\`\`1(value)](#M-Semantica-Patterns-CanBeEmptyExtensions-CanBeEmptyToNullable``1-``0- 'Semantica.Patterns.CanBeEmptyExtensions.CanBeEmptyToNullable``1(``0)')
  - [IfNotEmpty\`\`2(value,transformFunc)](#M-Semantica-Patterns-CanBeEmptyExtensions-IfNotEmpty``2-``0,System-Func{``0,``1}- 'Semantica.Patterns.CanBeEmptyExtensions.IfNotEmpty``2(``0,System.Func{``0,``1})')
  - [IfNotEmpty\`\`2(value,transformFunc)](#M-Semantica-Patterns-CanBeEmptyExtensions-IfNotEmpty``2-``0,System-Func{``0,System-Nullable{``1}}- 'Semantica.Patterns.CanBeEmptyExtensions.IfNotEmpty``2(``0,System.Func{``0,System.Nullable{``1}})')
  - [NullOnEmpty\`\`1(canBeEmpty,val)](#M-Semantica-Patterns-CanBeEmptyExtensions-NullOnEmpty``1-Semantica-Patterns-ICanBeEmpty,``0- 'Semantica.Patterns.CanBeEmptyExtensions.NullOnEmpty``1(Semantica.Patterns.ICanBeEmpty,``0)')
  - [NullOnEmpty\`\`1(canBeEmpty,val)](#M-Semantica-Patterns-CanBeEmptyExtensions-NullOnEmpty``1-Semantica-Patterns-ICanBeEmpty,System-Nullable{``0}- 'Semantica.Patterns.CanBeEmptyExtensions.NullOnEmpty``1(Semantica.Patterns.ICanBeEmpty,System.Nullable{``0})')
- [CanBeEmptyExtensionsX](#T-Semantica-Patterns-CanBeEmptyExtensionsX 'Semantica.Patterns.CanBeEmptyExtensionsX')
  - [IfNotEmpty\`\`2(value,transformFunc)](#M-Semantica-Patterns-CanBeEmptyExtensionsX-IfNotEmpty``2-``0,System-Func{``0,``1}- 'Semantica.Patterns.CanBeEmptyExtensionsX.IfNotEmpty``2(``0,System.Func{``0,``1})')
- [DeterminableCollectionExtensions](#T-Semantica-Patterns-DeterminableCollectionExtensions 'Semantica.Patterns.DeterminableCollectionExtensions')
  - [WhereDetermined\`\`1(enumerable)](#M-Semantica-Patterns-DeterminableCollectionExtensions-WhereDetermined``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Patterns.DeterminableCollectionExtensions.WhereDetermined``1(System.Collections.Generic.IEnumerable{``0})')
- [DeterminableExtensions](#T-Semantica-Patterns-DeterminableExtensions 'Semantica.Patterns.DeterminableExtensions')
  - [DeterminableToNullable\`\`1(value)](#M-Semantica-Patterns-DeterminableExtensions-DeterminableToNullable``1-``0- 'Semantica.Patterns.DeterminableExtensions.DeterminableToNullable``1(``0)')
- [IApproximable\`1](#T-Semantica-Patterns-IApproximable`1 'Semantica.Patterns.IApproximable`1')
  - [IsApproximateTo(other)](#M-Semantica-Patterns-IApproximable`1-IsApproximateTo-`0- 'Semantica.Patterns.IApproximable`1.IsApproximateTo(`0)')
- [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty')
  - [IsEmpty()](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty')
- [ICanSerialize](#T-Semantica-Patterns-ICanSerialize 'Semantica.Patterns.ICanSerialize')
  - [Serialize()](#M-Semantica-Patterns-ICanSerialize-Serialize 'Semantica.Patterns.ICanSerialize.Serialize')
- [ICanSerialize\`1](#T-Semantica-Patterns-ICanSerialize`1 'Semantica.Patterns.ICanSerialize`1')
  - [Deserialize(str)](#M-Semantica-Patterns-ICanSerialize`1-Deserialize-System-String- 'Semantica.Patterns.ICanSerialize`1.Deserialize(System.String)')
- [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable')
  - [IsDetermined](#P-Semantica-Patterns-IDeterminable-IsDetermined 'Semantica.Patterns.IDeterminable.IsDetermined')
- [ISimpleKey\`2](#T-Semantica-Patterns-Domain-ISimpleKey`2 'Semantica.Patterns.Domain.ISimpleKey`2')
  - [AsNullableId()](#M-Semantica-Patterns-Domain-ISimpleKey`2-AsNullableId 'Semantica.Patterns.Domain.ISimpleKey`2.AsNullableId')
- [ISubKey\`1](#T-Semantica-Patterns-Domain-ISubKey`1 'Semantica.Patterns.Domain.ISubKey`1')

<a name='T-Semantica-Patterns-CanBeEmptyCollectionExtensions'></a>
## CanBeEmptyCollectionExtensions `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides additional functionality for collections of [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') elements.

<a name='M-Semantica-Patterns-CanBeEmptyCollectionExtensions-FirstNonEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### FirstNonEmpty\`\`1(enumerable) `method`

##### Summary

Returns the first non-empty element in the enumeration.

##### Returns

A non-empty element from the enumeration, or default if there is no non-empty element.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of elements that implements [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `enumerable`. |

<a name='M-Semantica-Patterns-CanBeEmptyCollectionExtensions-GetValue``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1},``0-'></a>
### GetValue\`\`2(dictionary,key) `method`

##### Summary

Retrieves the value for any non-empty key in a dictionary, or the default of `TValue` if the key is empty.

##### Returns

The value corresponding to `key`, or default of the key is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [System.Collections.Generic.IReadOnlyDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{``0,``1}') | A [IReadOnlyDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary`2 'System.Collections.Generic.IReadOnlyDictionary`2') to perform the lookup in. |
| key | [\`\`0](#T-``0 '``0') | The key to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of keys in the read-only dictionary that implement [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |
| TValue | The type of values in the read-only dictionary. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Collections.Generic.KeyNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException') | When a non-empty `key` cannot be found in the dictionary. |

<a name='M-Semantica-Patterns-CanBeEmptyCollectionExtensions-WhereNotEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### WhereNotEmpty\`\`1(enumerable) `method`

##### Summary

Yields all non-empty elements in the enumeration.

##### Returns

A [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') what yields only the non-empty elements from `enumerable`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of elements that implement [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `enumerable`. |

<a name='T-Semantica-Patterns-CanBeEmptyExtensions'></a>
## CanBeEmptyExtensions `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides additional functionality for types that implement [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty').

<a name='M-Semantica-Patterns-CanBeEmptyExtensions-CanBeEmptyToNullable``1-``0-'></a>
### CanBeEmptyToNullable\`\`1(value) `method`

##### Summary

Returns the value as a [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable'), or the default [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable') of `T` value if it is empty.

##### Returns

`value` as a [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable'), or the default if `value` is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of value implementing [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |

<a name='M-Semantica-Patterns-CanBeEmptyExtensions-IfNotEmpty``2-``0,System-Func{``0,``1}-'></a>
### IfNotEmpty\`\`2(value,transformFunc) `method`

##### Summary

Applies a transform function to a [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') value, if the value is not empty.

##### Returns

A [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') with no value if the input is empty, otherwise the output of the transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to evaluate. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The transformation function. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type that implements [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |
| TOut | The output type of the transformation. |

<a name='M-Semantica-Patterns-CanBeEmptyExtensions-IfNotEmpty``2-``0,System-Func{``0,System-Nullable{``1}}-'></a>
### IfNotEmpty\`\`2(value,transformFunc) `method`

##### Summary

Applies a transform function to a [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') value, if the value is not empty.

##### Returns

A [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') with no value if the input is empty, otherwise the output of the transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to evaluate. |
| transformFunc | [System.Func{\`\`0,System.Nullable{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Nullable{``1}}') | The transformation function. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type that implements [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |
| TOut | The output type of the transformation. |

<a name='M-Semantica-Patterns-CanBeEmptyExtensions-NullOnEmpty``1-Semantica-Patterns-ICanBeEmpty,``0-'></a>
### NullOnEmpty\`\`1(canBeEmpty,val) `method`

##### Summary

If `canBeEmpty` is empty, returns `null`, otherwise returns `val`.
This overload is used when `T` is a `class` type.

##### Returns

`null` if `canBeEmpty` is empty; otherwise .

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| canBeEmpty | [Semantica.Patterns.ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') | The instance to evaluate [IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') on. |
| val | [\`\`0](#T-``0 '``0') | The value to return if `canBeEmpty` is not empty. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Return type and type of `val`. |

<a name='M-Semantica-Patterns-CanBeEmptyExtensions-NullOnEmpty``1-Semantica-Patterns-ICanBeEmpty,System-Nullable{``0}-'></a>
### NullOnEmpty\`\`1(canBeEmpty,val) `method`

##### Summary

If `canBeEmpty` is empty, returns `default`, otherwise returns `val`.
This overload is used when `T` is a `struct` type.

##### Returns

`default` if `canBeEmpty` is empty; otherwise .

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| canBeEmpty | [Semantica.Patterns.ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') | The instance to evaluate [IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') on. |
| val | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The value to return if `canBeEmpty` is not empty. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Return type and type of `val`. |

<a name='T-Semantica-Patterns-CanBeEmptyExtensionsX'></a>
## CanBeEmptyExtensionsX `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides additional functionality for [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') in electives, that cannot be part of
[CanBeEmptyExtensions](#T-Semantica-Patterns-CanBeEmptyExtensions 'Semantica.Patterns.CanBeEmptyExtensions') because of signature overlap.

##### Remarks

The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
are on a separate class, so this weird thing has to exist.

<a name='M-Semantica-Patterns-CanBeEmptyExtensionsX-IfNotEmpty``2-``0,System-Func{``0,``1}-'></a>
### IfNotEmpty\`\`2(value,transformFunc) `method`

##### Summary

Applies a transform function to a [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') value, if the value is not empty.

##### Returns

A [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') with no value if the input is empty, otherwise the output of the transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to evaluate. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The transformation function. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type that implements [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'). |
| TOut | The output type of the transformation. |

<a name='T-Semantica-Patterns-DeterminableCollectionExtensions'></a>
## DeterminableCollectionExtensions `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides additional functionality for collections of [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable') elements.

<a name='M-Semantica-Patterns-DeterminableCollectionExtensions-WhereDetermined``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### WhereDetermined\`\`1(enumerable) `method`

##### Summary

yields all determined elements in the enumeration.

##### Returns

Only detemined elements from `enumerable`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of elements that implement [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable'). |

<a name='T-Semantica-Patterns-DeterminableExtensions'></a>
## DeterminableExtensions `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides additional functionality for types that implement [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable').

<a name='M-Semantica-Patterns-DeterminableExtensions-DeterminableToNullable``1-``0-'></a>
### DeterminableToNullable\`\`1(value) `method`

##### Summary

Returns the value as a [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable'), with the value `null` if `value` is not determined.

##### Returns

`value` as a [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable'), or `null` if `value` is not determined.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to be evaluated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of `value`. |

<a name='T-Semantica-Patterns-IApproximable`1'></a>
## IApproximable\`1 `type`

##### Namespace

Semantica.Patterns

##### Summary

Provides functionality for types that represent values that can be approximately

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Semantica-Patterns-IApproximable`1-IsApproximateTo-`0-'></a>
### IsApproximateTo(other) `method`

##### Summary

Determines if `other` is approximate to `this`.

##### Returns

True if the value of `this` is approximately the same as other's value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [\`0](#T-`0 '`0') | Instance to compare this to. |

<a name='T-Semantica-Patterns-ICanBeEmpty'></a>
## ICanBeEmpty `type`

##### Namespace

Semantica.Patterns

##### Summary

A struct or class can implement [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') when there is some (inescapable) default value that can be thought of as empty.

<a name='M-Semantica-Patterns-ICanBeEmpty-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

Determines whether the object is empty.

##### Returns

`true` if the represented value is empty (or default); otherwise, `false`.

##### Parameters

This method has no parameters.

##### Example

In most cases, the following implementation should suffice:

```
=&gt; Equals(default(T))
```

<a name='T-Semantica-Patterns-ICanSerialize'></a>
## ICanSerialize `type`

##### Namespace

Semantica.Patterns

##### Summary

A struct or class can implement [ICanSerialize](#T-Semantica-Patterns-ICanSerialize 'Semantica.Patterns.ICanSerialize') when it can be serialized to a string without losing any relevant information.

<a name='M-Semantica-Patterns-ICanSerialize-Serialize'></a>
### Serialize() `method`

##### Summary

Serializes the instance to a `string`.

##### Returns

Een string-representation of the instance.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Patterns-ICanSerialize`1'></a>
## ICanSerialize\`1 `type`

##### Namespace

Semantica.Patterns

##### Summary

A struct or class can implement [ICanSerialize\`1](#T-Semantica-Patterns-ICanSerialize`1 'Semantica.Patterns.ICanSerialize`1') when it can be serialized to a string without losing any relevant information.  
In principal for any instance of a type implementing [ICanSerialize\`1](#T-Semantica-Patterns-ICanSerialize`1 'Semantica.Patterns.ICanSerialize`1') this should evaluate to `true`:
instance.[Deserialize](#M-Semantica-Patterns-ICanSerialize`1-Deserialize-System-String- 'Semantica.Patterns.ICanSerialize`1.Deserialize(System.String)')(instance.[Serialize](#M-Semantica-Patterns-ICanSerialize-Serialize 'Semantica.Patterns.ICanSerialize.Serialize')()).[Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.Equals 'System.Object.Equals(System.Object)')(instance)

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type deserialization returns, generally the instance type that this interface is applied to. |

<a name='M-Semantica-Patterns-ICanSerialize`1-Deserialize-System-String-'></a>
### Deserialize(str) `method`

##### Summary



##### Returns

A new instance of `T`, equivalent to `str`, or `default`(T) if deserialization failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | serialized `string` representation of an instance of `T`. |

<a name='T-Semantica-Patterns-IDeterminable'></a>
## IDeterminable `type`

##### Namespace

Semantica.Patterns

##### Summary

A struct or class can implement [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable') when it has no clear undetermined state, but there is need for one.
This can be particularly useful for value types when an explicit undetermined state is more clear than or functionally useful besides having a [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable') or `null` value.

<a name='P-Semantica-Patterns-IDeterminable-IsDetermined'></a>
### IsDetermined `property`

##### Summary

Indicates whether the instance's value has been determined.

<a name='T-Semantica-Patterns-Domain-ISimpleKey`2'></a>
## ISimpleKey\`2 `type`

##### Namespace

Semantica.Patterns.Domain

<a name='M-Semantica-Patterns-Domain-ISimpleKey`2-AsNullableId'></a>
### AsNullableId() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

##### Example

In most cases, the following implementation should suffice:

```
=&gt; IsEmpty() ? default(T?) : Id
```

<a name='T-Semantica-Patterns-Domain-ISubKey`1'></a>
## ISubKey\`1 `type`

##### Namespace

Semantica.Patterns.Domain

##### Summary

A key that is a subkey has only one property, which is the inner key. The identity of the sub-entity is always the same as
the principal, although not every key of the principal wil be a valid subkey. Use subkeys when other entities can reference
the sub-entity, but are not valid for the main entity when it's not also a sub-entity.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of the key of the principal entity. |
