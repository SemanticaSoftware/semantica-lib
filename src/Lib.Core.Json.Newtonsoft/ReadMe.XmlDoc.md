<a name='assembly'></a>
# Lib.Core.Json.Newtonsoft

## Contents

- [Base\`2](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Base`2')
  - [FromUnderlyingType(underlyingValue)](#M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-FromUnderlyingType-`1- 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Base`2.FromUnderlyingType(`1)')
  - [GetDefault()](#M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-GetDefault 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Base`2.GetDefault')
  - [ToUnderlyingType(value)](#M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-ToUnderlyingType-`0- 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Base`2.ToUnderlyingType(`0)')
- [Boolean\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Boolean`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Boolean`1')
- [DateOnly\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateOnly`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.DateOnly`1')
- [DateTimeOffset\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateTimeOffset`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.DateTimeOffset`1')
- [DateTime\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateTime`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.DateTime`1')
- [Decimal\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Decimal`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Decimal`1')
- [Double\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Double`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Double`1')
- [Guid\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Guid`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Guid`1')
- [Int\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Int`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Int`1')
- [JsonConverterBase](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase 'Semantica.Core.Json.Newtonsoft.JsonConverterBase')
- [StringJsonConverterBase\`1](#T-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1')
  - [UseDefaultOnNull](#P-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-UseDefaultOnNull 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.UseDefaultOnNull')
  - [FromString(str)](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.FromString(System.String)')
  - [GetDefault()](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-GetDefault 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.GetDefault')
  - [ToString(value)](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-ToString-`0- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.ToString(`0)')

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2'></a>
## Base\`2 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Don't use this base class, but use one of the specific type

<a name='M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-FromUnderlyingType-`1-'></a>
### FromUnderlyingType(underlyingValue) `method`

##### Summary

Implementation of the conversion to `T`.

##### Returns

An instance of `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| underlyingValue | [\`1](#T-`1 '`1') | Value to convert. |

<a name='M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-GetDefault'></a>
### GetDefault() `method`

##### Summary

Returns default(T?) (`null`). Override if a different value to should be returned when reading of
the underlying type value fails.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-ToUnderlyingType-`0-'></a>
### ToUnderlyingType(value) `method`

##### Summary

Implementation of the conversion of `T` to the underlying type.

##### Returns

A representation of the input as [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') of the underlying type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value of `T` to convert. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Boolean`1'></a>
## Boolean\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to boolean. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateOnly`1'></a>
## DateOnly\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to dateonly. |

##### Remarks

DateOnly is currently not supported by Newtonsoft.Json, so an extra conversion to and from DateTime is used.

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateTimeOffset`1'></a>
## DateTimeOffset\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to datetime offset. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-DateTime`1'></a>
## DateTime\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to datetime. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Decimal`1'></a>
## Decimal\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Decimal\`1](#T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Decimal`1 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Decimal`1').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to decimal. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Double`1'></a>
## Double\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to double. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Guid`1'></a>
## Guid\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to guid. |

##### Remarks

Guid is currently not supported by Newtonsoft.Json, so an extra conversion to and from Guid is used.

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Int`1'></a>
## Int\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to int. |

<a name='T-Semantica-Core-Json-Newtonsoft-JsonConverterBase'></a>
## JsonConverterBase `type`

##### Namespace

Semantica.Core.Json.Newtonsoft

##### Summary

Provides base JsonConverter classes for value types that hold a single underlying value (`struct`) type that is
supported by System.Text.Json.

##### Remarks

For conversions from the underlying type, override [GetDefault](#M-Semantica-Core-Json-Newtonsoft-JsonConverterBase-Base`2-GetDefault 'Semantica.Core.Json.Newtonsoft.JsonConverterBase.Base`2.GetDefault') if a value
different to default(T?) (`null`) should be returned when reading of the underlying type fails.

<a name='T-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1'></a>
## StringJsonConverterBase\`1 `type`

##### Namespace

Semantica.Core.Json.Newtonsoft

##### Summary

Base class that inherits from [JsonConverter\`1](#T-Newtonsoft-Json-JsonConverter`1 'Newtonsoft.Json.JsonConverter`1'), meant for conversions of `T` from and to
`string`. Only [FromString](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.FromString(System.String)') and [ToString](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-ToString-`0- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.ToString(`0)') abstract methods need to be implemented.

For conversions from string, override [GetDefault](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-GetDefault 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.GetDefault') if a value different to default(T) should be returned on a
`null` value, or override [UseDefaultOnNull](#P-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-UseDefaultOnNull 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.UseDefaultOnNull') to return `false` if
`null` values should be handled by [FromString](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.FromString(System.String)'). When not overriden, [FromString](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.FromString(System.String)')
will never be called with `null`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to convert to and from [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='P-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-UseDefaultOnNull'></a>
### UseDefaultOnNull `property`

##### Summary

When `true`, the output of [GetDefault](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-GetDefault 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.GetDefault') is returned on a string input of
`null`. Override and return `false` if `null` values should be handled
by [FromString](#M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.FromString(System.String)').

<a name='M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-FromString-System-String-'></a>
### FromString(str) `method`

##### Summary

Implementation of the conversion to `T`.

##### Returns

An instance of `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value to convert. Never `null` unless [UseDefaultOnNull](#P-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-UseDefaultOnNull 'Semantica.Core.Json.Newtonsoft.StringJsonConverterBase`1.UseDefaultOnNull') is overriden and returns
`false`. |

<a name='M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-GetDefault'></a>
### GetDefault() `method`

##### Summary

Returns default(T). Override if a different value to should be returned on a `null` value.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Json-Newtonsoft-StringJsonConverterBase`1-ToString-`0-'></a>
### ToString(value) `method`

##### Summary

Implementation of the conversion of `T` to string.

##### Returns

An string representation of the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value of `T` to convert. |
