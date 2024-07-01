<a name='assembly'></a>
# Lib.Collections

## Contents

- [ArrayDictionary\`2](#T-Semantica-Collections-ArrayDictionary`2 'Semantica.Collections.ArrayDictionary`2')
  - [System#Collections#Generic#IDictionary{TKey,TValue}#Item](#P-Semantica-Collections-ArrayDictionary`2-System#Collections#Generic#IDictionary{TKey,TValue}#Item-`0- 'Semantica.Collections.ArrayDictionary`2.System#Collections#Generic#IDictionary{TKey,TValue}#Item(`0)')
  - [Add()](#M-Semantica-Collections-ArrayDictionary`2-Add-System-Collections-Generic-KeyValuePair{`0,`1}- 'Semantica.Collections.ArrayDictionary`2.Add(System.Collections.Generic.KeyValuePair{`0,`1})')
  - [Add()](#M-Semantica-Collections-ArrayDictionary`2-Add-`0,`1- 'Semantica.Collections.ArrayDictionary`2.Add(`0,`1)')
  - [Clear()](#M-Semantica-Collections-ArrayDictionary`2-Clear 'Semantica.Collections.ArrayDictionary`2.Clear')
  - [Contains()](#M-Semantica-Collections-ArrayDictionary`2-Contains-System-Collections-Generic-KeyValuePair{`0,`1}- 'Semantica.Collections.ArrayDictionary`2.Contains(System.Collections.Generic.KeyValuePair{`0,`1})')
  - [Remove()](#M-Semantica-Collections-ArrayDictionary`2-Remove-System-Collections-Generic-KeyValuePair{`0,`1}- 'Semantica.Collections.ArrayDictionary`2.Remove(System.Collections.Generic.KeyValuePair{`0,`1})')
  - [Remove()](#M-Semantica-Collections-ArrayDictionary`2-Remove-`0- 'Semantica.Collections.ArrayDictionary`2.Remove(`0)')
- [CollectionExtensions](#T-Semantica-Collections-CollectionExtensions 'Semantica.Collections.CollectionExtensions')
  - [ToArrayDictionary\`\`2(enumerable,keyFunc)](#M-Semantica-Collections-CollectionExtensions-ToArrayDictionary``2-System-Collections-Generic-IEnumerable{``1},System-Func{``1,``0}- 'Semantica.Collections.CollectionExtensions.ToArrayDictionary``2(System.Collections.Generic.IEnumerable{``1},System.Func{``1,``0})')
  - [ToArrayDictionary\`\`3(enumerable,keyFunc,valueFunc)](#M-Semantica-Collections-CollectionExtensions-ToArrayDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}- 'Semantica.Collections.CollectionExtensions.ToArrayDictionary``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Func{``0,``2})')
- [IRetrievalCollection\`1](#T-Semantica-Collections-IRetrievalCollection`1 'Semantica.Collections.IRetrievalCollection`1')
  - [Retrieve(predicate)](#M-Semantica-Collections-IRetrievalCollection`1-Retrieve-System-Func{`0,System-Boolean}- 'Semantica.Collections.IRetrievalCollection`1.Retrieve(System.Func{`0,System.Boolean})')
  - [RetrieveFirstOrDefault(predicate)](#M-Semantica-Collections-IRetrievalCollection`1-RetrieveFirstOrDefault-System-Func{`0,System-Boolean}- 'Semantica.Collections.IRetrievalCollection`1.RetrieveFirstOrDefault(System.Func{`0,System.Boolean})')
- [RetrievalCollection\`1](#T-Semantica-Collections-RetrievalCollection`1 'Semantica.Collections.RetrievalCollection`1')

<a name='T-Semantica-Collections-ArrayDictionary`2'></a>
## ArrayDictionary\`2 `type`

##### Namespace

Semantica.Collections

##### Summary

Simple implementation for IReadOnlyDictionary that's cheap to create but more expensive to query.
    Does not enforce uniqueness of keys. In case of multiple equal keys, the value belonging to the first instance of the key is returned.
    Use for cases where the dictionary interface is convenient for the code, but building a hash-based dictionary would be overkill.
    Use when individual items are not retrieved more then a couple of times.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of key |
| TValue | Type of values |

##### Remarks

Most of the IDictionary methods are intentionally unimplemented or delegated.
If the Dictionary functionality is needed, a regular Dictionary can be used.
This exist, for example, to enumerate over KeyValuePairs or lookup each item once in small lists.

<a name='P-Semantica-Collections-ArrayDictionary`2-System#Collections#Generic#IDictionary{TKey,TValue}#Item-`0-'></a>
### System#Collections#Generic#IDictionary{TKey,TValue}#Item `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | The set is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Add-System-Collections-Generic-KeyValuePair{`0,`1}-'></a>
### Add() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Add-`0,`1-'></a>
### Add() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Clear'></a>
### Clear() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Contains-System-Collections-Generic-KeyValuePair{`0,`1}-'></a>
### Contains() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Remove-System-Collections-Generic-KeyValuePair{`0,`1}-'></a>
### Remove() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='M-Semantica-Collections-ArrayDictionary`2-Remove-`0-'></a>
### Remove() `method`

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') | This IDictionary method is intentionally unimplemented. |

##### Remarks

If the Dictionary functionality is needed, a regular Dictionary can be used.

<a name='T-Semantica-Collections-CollectionExtensions'></a>
## CollectionExtensions `type`

##### Namespace

Semantica.Collections

<a name='M-Semantica-Collections-CollectionExtensions-ToArrayDictionary``2-System-Collections-Generic-IEnumerable{``1},System-Func{``1,``0}-'></a>
### ToArrayDictionary\`\`2(enumerable,keyFunc) `method`

##### Summary

Zet de enumerable om in een [ArrayDictionary\`2](#T-Semantica-Collections-ArrayDictionary`2 'Semantica.Collections.ArrayDictionary`2').
    Duplicate keys worden niet verworpen, en niet geretourneerd.

##### Returns

An ArrayDictionary implementation of an IReadOnlyDictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | An enumerable of type `TValue` |
| keyFunc | [System.Func{\`\`1,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,``0}') | Function that can retrieve a `TKey` from an
    `TValue` |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the dictionary's keys. |
| TValue | The type of the dictionary's values. The generic type of the elements of the enumerable. |

<a name='M-Semantica-Collections-CollectionExtensions-ToArrayDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}-'></a>
### ToArrayDictionary\`\`3(enumerable,keyFunc,valueFunc) `method`

##### Summary

Zet de enumerable om in een ArrayDictionary[ArrayDictionary\`2](#T-Semantica-Collections-ArrayDictionary`2 'Semantica.Collections.ArrayDictionary`2')
    Duplicate keys worden niet verworpen, en niet geretourneerd.

##### Returns

An ArrayDictionary implementation of an IReadOnlyDictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumerable of type `TIn`TIn |
| keyFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function that can retrieve a `TKey` from an
    `TIn` |
| valueFunc | [System.Func{\`\`0,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2}') | Function that can retrieve a `TValue` from an
    `TIn` |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The generic type of the elements of the enumerable. |
| TKey | The type of the dictionary's keys. |
| TValue | The type of the dictionary's values. |

<a name='T-Semantica-Collections-IRetrievalCollection`1'></a>
## IRetrievalCollection\`1 `type`

##### Namespace

Semantica.Collections

##### Summary

Low overhead data structure to pour a collection of items in, in order to find and retrieve each item at most once.

<a name='M-Semantica-Collections-IRetrievalCollection`1-Retrieve-System-Func{`0,System-Boolean}-'></a>
### Retrieve(predicate) `method`

##### Summary

Finds elements that match the predicate, and removes them from the collection as it returns them.
    Elements are not removed until they are enumerated over.

##### Returns

An enumerable of matching elements, or an emty enumeration if no matching elements are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| predicate | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Predicate to check the elements with. |

<a name='M-Semantica-Collections-IRetrievalCollection`1-RetrieveFirstOrDefault-System-Func{`0,System-Boolean}-'></a>
### RetrieveFirstOrDefault(predicate) `method`

##### Summary

Finds the first element that matches the predicate, returns it, and removes it from the collection

##### Returns

The found item or default

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| predicate | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Predicate to check the elements with. |

<a name='T-Semantica-Collections-RetrievalCollection`1'></a>
## RetrievalCollection\`1 `type`

##### Namespace

Semantica.Collections

##### Summary

*Inherit from parent.*
