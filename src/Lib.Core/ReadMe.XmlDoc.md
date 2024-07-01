<a name='assembly'></a>
# Lib.Core

## Contents

- [Base\`2](#T-Semantica-Core-Json-JsonConverterBase-Base`2 'Semantica.Core.Json.JsonConverterBase.Base`2')
  - [FromUnderlyingType(underlyingValue)](#M-Semantica-Core-Json-JsonConverterBase-Base`2-FromUnderlyingType-`1- 'Semantica.Core.Json.JsonConverterBase.Base`2.FromUnderlyingType(`1)')
  - [GetDefault()](#M-Semantica-Core-Json-JsonConverterBase-Base`2-GetDefault 'Semantica.Core.Json.JsonConverterBase.Base`2.GetDefault')
  - [ToUnderlyingType(value)](#M-Semantica-Core-Json-JsonConverterBase-Base`2-ToUnderlyingType-`0- 'Semantica.Core.Json.JsonConverterBase.Base`2.ToUnderlyingType(`0)')
- [Boolean\`1](#T-Semantica-Core-Json-JsonConverterBase-Boolean`1 'Semantica.Core.Json.JsonConverterBase.Boolean`1')
- [Byte\`1](#T-Semantica-Core-Json-JsonConverterBase-Byte`1 'Semantica.Core.Json.JsonConverterBase.Byte`1')
- [Comparable](#T-Semantica-Core-Comparable 'Semantica.Core.Comparable')
  - [CompareOrNull\`\`1(this,other)](#M-Semantica-Core-Comparable-CompareOrNull``1-``0,``0- 'Semantica.Core.Comparable.CompareOrNull``1(``0,``0)')
  - [Max\`\`1(array)](#M-Semantica-Core-Comparable-Max``1-``0[]- 'Semantica.Core.Comparable.Max``1(``0[])')
  - [Max\`\`1(left,right)](#M-Semantica-Core-Comparable-Max``1-``0,``0- 'Semantica.Core.Comparable.Max``1(``0,``0)')
  - [Min\`\`1(array)](#M-Semantica-Core-Comparable-Min``1-``0[]- 'Semantica.Core.Comparable.Min``1(``0[])')
  - [Min\`\`1(left,right)](#M-Semantica-Core-Comparable-Min``1-``0,``0- 'Semantica.Core.Comparable.Min``1(``0,``0)')
  - [TryCompareHasValue(thisHasValue,otherHasValue,val,noValueIsBigger)](#M-Semantica-Core-Comparable-TryCompareHasValue-System-Boolean,System-Boolean,System-Int32@,System-Boolean- 'Semantica.Core.Comparable.TryCompareHasValue(System.Boolean,System.Boolean,System.Int32@,System.Boolean)')
  - [TryCompareIsEmpty(thisIsEmpty,otherIsEmpty,val,emptyIsSmaller)](#M-Semantica-Core-Comparable-TryCompareIsEmpty-System-Boolean,System-Boolean,System-Int32@,System-Boolean- 'Semantica.Core.Comparable.TryCompareIsEmpty(System.Boolean,System.Boolean,System.Int32@,System.Boolean)')
- [DateOnly\`1](#T-Semantica-Core-Json-JsonConverterBase-DateOnly`1 'Semantica.Core.Json.JsonConverterBase.DateOnly`1')
- [DateTimeConstants](#T-Semantica-Core-DateTimeConstants 'Semantica.Core.DateTimeConstants')
  - [DaysPer100Years](#F-Semantica-Core-DateTimeConstants-DaysPer100Years 'Semantica.Core.DateTimeConstants.DaysPer100Years')
  - [DaysPer400Years](#F-Semantica-Core-DateTimeConstants-DaysPer400Years 'Semantica.Core.DateTimeConstants.DaysPer400Years')
  - [DaysPer4Years](#F-Semantica-Core-DateTimeConstants-DaysPer4Years 'Semantica.Core.DateTimeConstants.DaysPer4Years')
  - [DaysPerYear](#F-Semantica-Core-DateTimeConstants-DaysPerYear 'Semantica.Core.DateTimeConstants.DaysPerYear')
  - [DaysToMonth365](#F-Semantica-Core-DateTimeConstants-DaysToMonth365 'Semantica.Core.DateTimeConstants.DaysToMonth365')
  - [DaysToMonth366](#F-Semantica-Core-DateTimeConstants-DaysToMonth366 'Semantica.Core.DateTimeConstants.DaysToMonth366')
  - [MillisPerDay](#F-Semantica-Core-DateTimeConstants-MillisPerDay 'Semantica.Core.DateTimeConstants.MillisPerDay')
  - [MillisPerHour](#F-Semantica-Core-DateTimeConstants-MillisPerHour 'Semantica.Core.DateTimeConstants.MillisPerHour')
  - [MillisPerMinute](#F-Semantica-Core-DateTimeConstants-MillisPerMinute 'Semantica.Core.DateTimeConstants.MillisPerMinute')
  - [MillisPerSecond](#F-Semantica-Core-DateTimeConstants-MillisPerSecond 'Semantica.Core.DateTimeConstants.MillisPerSecond')
  - [TicksPerDay](#F-Semantica-Core-DateTimeConstants-TicksPerDay 'Semantica.Core.DateTimeConstants.TicksPerDay')
  - [TicksPerHour](#F-Semantica-Core-DateTimeConstants-TicksPerHour 'Semantica.Core.DateTimeConstants.TicksPerHour')
  - [TicksPerMillisecond](#F-Semantica-Core-DateTimeConstants-TicksPerMillisecond 'Semantica.Core.DateTimeConstants.TicksPerMillisecond')
  - [TicksPerMinute](#F-Semantica-Core-DateTimeConstants-TicksPerMinute 'Semantica.Core.DateTimeConstants.TicksPerMinute')
  - [TicksPerSecond](#F-Semantica-Core-DateTimeConstants-TicksPerSecond 'Semantica.Core.DateTimeConstants.TicksPerSecond')
  - [DaysInMonth365](#P-Semantica-Core-DateTimeConstants-DaysInMonth365 'Semantica.Core.DateTimeConstants.DaysInMonth365')
  - [DaysInMonth366](#P-Semantica-Core-DateTimeConstants-DaysInMonth366 'Semantica.Core.DateTimeConstants.DaysInMonth366')
  - [GetDaysInMonth()](#M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-Int32,System-Int32- 'Semantica.Core.DateTimeConstants.GetDaysInMonth(System.Int32,System.Int32)')
  - [GetDaysInMonth()](#M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-DateOnly- 'Semantica.Core.DateTimeConstants.GetDaysInMonth(System.DateOnly)')
  - [GetDaysInMonth()](#M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-DateTime- 'Semantica.Core.DateTimeConstants.GetDaysInMonth(System.DateTime)')
  - [MonthNumberAfter(month)](#M-Semantica-Core-DateTimeConstants-MonthNumberAfter-System-Int32- 'Semantica.Core.DateTimeConstants.MonthNumberAfter(System.Int32)')
  - [MonthNumberBefore(month)](#M-Semantica-Core-DateTimeConstants-MonthNumberBefore-System-Int32- 'Semantica.Core.DateTimeConstants.MonthNumberBefore(System.Int32)')
- [DateTimeOffset\`1](#T-Semantica-Core-Json-JsonConverterBase-DateTimeOffset`1 'Semantica.Core.Json.JsonConverterBase.DateTimeOffset`1')
- [DateTime\`1](#T-Semantica-Core-Json-JsonConverterBase-DateTime`1 'Semantica.Core.Json.JsonConverterBase.DateTime`1')
- [Decimal\`1](#T-Semantica-Core-Json-JsonConverterBase-Decimal`1 'Semantica.Core.Json.JsonConverterBase.Decimal`1')
- [Double\`1](#T-Semantica-Core-Json-JsonConverterBase-Double`1 'Semantica.Core.Json.JsonConverterBase.Double`1')
- [Guid\`1](#T-Semantica-Core-Json-JsonConverterBase-Guid`1 'Semantica.Core.Json.JsonConverterBase.Guid`1')
- [IDateTimeProvider](#T-Semantica-Core-Providers-IDateTimeProvider 'Semantica.Core.Providers.IDateTimeProvider')
  - [ConvertLocalToOffset(dateTime)](#M-Semantica-Core-Providers-IDateTimeProvider-ConvertLocalToOffset-System-DateTime- 'Semantica.Core.Providers.IDateTimeProvider.ConvertLocalToOffset(System.DateTime)')
  - [ConvertUtcToOffset(dateTime)](#M-Semantica-Core-Providers-IDateTimeProvider-ConvertUtcToOffset-System-DateTime- 'Semantica.Core.Providers.IDateTimeProvider.ConvertUtcToOffset(System.DateTime)')
  - [MidnightToday()](#M-Semantica-Core-Providers-IDateTimeProvider-MidnightToday 'Semantica.Core.Providers.IDateTimeProvider.MidnightToday')
  - [MidnightTodayOffset()](#M-Semantica-Core-Providers-IDateTimeProvider-MidnightTodayOffset 'Semantica.Core.Providers.IDateTimeProvider.MidnightTodayOffset')
  - [Now()](#M-Semantica-Core-Providers-IDateTimeProvider-Now 'Semantica.Core.Providers.IDateTimeProvider.Now')
  - [NowOffset()](#M-Semantica-Core-Providers-IDateTimeProvider-NowOffset 'Semantica.Core.Providers.IDateTimeProvider.NowOffset')
  - [Offset(dateTime)](#M-Semantica-Core-Providers-IDateTimeProvider-Offset-System-DateTime- 'Semantica.Core.Providers.IDateTimeProvider.Offset(System.DateTime)')
  - [OffsetKind()](#M-Semantica-Core-Providers-IDateTimeProvider-OffsetKind 'Semantica.Core.Providers.IDateTimeProvider.OffsetKind')
  - [Time()](#M-Semantica-Core-Providers-IDateTimeProvider-Time 'Semantica.Core.Providers.IDateTimeProvider.Time')
  - [TimeZoneInfo()](#M-Semantica-Core-Providers-IDateTimeProvider-TimeZoneInfo 'Semantica.Core.Providers.IDateTimeProvider.TimeZoneInfo')
  - [Today()](#M-Semantica-Core-Providers-IDateTimeProvider-Today 'Semantica.Core.Providers.IDateTimeProvider.Today')
  - [UtcMidnightToday()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcMidnightToday 'Semantica.Core.Providers.IDateTimeProvider.UtcMidnightToday')
  - [UtcMidnightTodayOffset()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcMidnightTodayOffset 'Semantica.Core.Providers.IDateTimeProvider.UtcMidnightTodayOffset')
  - [UtcNow()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcNow 'Semantica.Core.Providers.IDateTimeProvider.UtcNow')
  - [UtcNowOffset()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcNowOffset 'Semantica.Core.Providers.IDateTimeProvider.UtcNowOffset')
  - [UtcTime()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcTime 'Semantica.Core.Providers.IDateTimeProvider.UtcTime')
  - [UtcToday()](#M-Semantica-Core-Providers-IDateTimeProvider-UtcToday 'Semantica.Core.Providers.IDateTimeProvider.UtcToday')
- [ISnapshotDateTimeProvider](#T-Semantica-Core-Providers-ISnapshotDateTimeProvider 'Semantica.Core.Providers.ISnapshotDateTimeProvider')
  - [Reset()](#M-Semantica-Core-Providers-ISnapshotDateTimeProvider-Reset 'Semantica.Core.Providers.ISnapshotDateTimeProvider.Reset')
- [Int16\`1](#T-Semantica-Core-Json-JsonConverterBase-Int16`1 'Semantica.Core.Json.JsonConverterBase.Int16`1')
- [Int32\`1](#T-Semantica-Core-Json-JsonConverterBase-Int32`1 'Semantica.Core.Json.JsonConverterBase.Int32`1')
- [Int64\`1](#T-Semantica-Core-Json-JsonConverterBase-Int64`1 'Semantica.Core.Json.JsonConverterBase.Int64`1')
- [JsonConverterBase](#T-Semantica-Core-Json-JsonConverterBase 'Semantica.Core.Json.JsonConverterBase')
- [Logic](#T-Semantica-Core-Logic 'Semantica.Core.Logic')
  - [ExactlyOne(bools)](#M-Semantica-Core-Logic-ExactlyOne-System-Boolean[]- 'Semantica.Core.Logic.ExactlyOne(System.Boolean[])')
  - [Follows(if,bools)](#M-Semantica-Core-Logic-Follows-System-Boolean,System-Boolean[]- 'Semantica.Core.Logic.Follows(System.Boolean,System.Boolean[])')
  - [None(bools)](#M-Semantica-Core-Logic-None-System-Boolean[]- 'Semantica.Core.Logic.None(System.Boolean[])')
  - [NoneOrOne(bools)](#M-Semantica-Core-Logic-NoneOrOne-System-Boolean[]- 'Semantica.Core.Logic.NoneOrOne(System.Boolean[])')
- [Module](#T-Semantica-Core-Module 'Semantica.Core.Module')
- [ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1')
  - [GetDependencyAssemblies()](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyAssemblies 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyAssemblies')
  - [GetDependencyModules()](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyModules 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyModules')
  - [GetMicrosoftDependencyInjectionModules()](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetMicrosoftDependencyInjectionModules 'Semantica.Core.DependencyInjection.ModuleBase`1.GetMicrosoftDependencyInjectionModules')
  - [Register(container,findOtherModulesInSameAssembly)](#M-Semantica-Core-DependencyInjection-ModuleBase`1-Register-`0,System-Boolean- 'Semantica.Core.DependencyInjection.ModuleBase`1.Register(`0,System.Boolean)')
  - [ToMicrosoftDependencyInjectionAbstractions(container)](#M-Semantica-Core-DependencyInjection-ModuleBase`1-ToMicrosoftDependencyInjectionAbstractions-`0- 'Semantica.Core.DependencyInjection.ModuleBase`1.ToMicrosoftDependencyInjectionAbstractions(`0)')
- [ModuleException](#T-Semantica-Core-DependencyInjection-ModuleException 'Semantica.Core.DependencyInjection.ModuleException')
- [SByte\`1](#T-Semantica-Core-Json-JsonConverterBase-SByte`1 'Semantica.Core.Json.JsonConverterBase.SByte`1')
- [Single\`1](#T-Semantica-Core-Json-JsonConverterBase-Single`1 'Semantica.Core.Json.JsonConverterBase.Single`1')
- [StaticSelectors](#T-Semantica-Core-StaticSelectors 'Semantica.Core.StaticSelectors')
  - [SelfNotNull\`\`1(t)](#M-Semantica-Core-StaticSelectors-SelfNotNull``1-System-Nullable{``0}- 'Semantica.Core.StaticSelectors.SelfNotNull``1(System.Nullable{``0})')
  - [SelfNotNull\`\`1(t)](#M-Semantica-Core-StaticSelectors-SelfNotNull``1-``0- 'Semantica.Core.StaticSelectors.SelfNotNull``1(``0)')
  - [Self\`\`1(t)](#M-Semantica-Core-StaticSelectors-Self``1-``0- 'Semantica.Core.StaticSelectors.Self``1(``0)')
- [StringJsonConverterBase\`1](#T-Semantica-Core-Json-StringJsonConverterBase`1 'Semantica.Core.Json.StringJsonConverterBase`1')
  - [Default](#P-Semantica-Core-Json-StringJsonConverterBase`1-Default 'Semantica.Core.Json.StringJsonConverterBase`1.Default')
  - [DefaultOnEmpty](#P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnEmpty 'Semantica.Core.Json.StringJsonConverterBase`1.DefaultOnEmpty')
  - [DefaultOnNull](#P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnNull 'Semantica.Core.Json.StringJsonConverterBase`1.DefaultOnNull')
  - [DoTrim](#P-Semantica-Core-Json-StringJsonConverterBase`1-DoTrim 'Semantica.Core.Json.StringJsonConverterBase`1.DoTrim')
  - [FromString(str)](#M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.StringJsonConverterBase`1.FromString(System.String)')
  - [GetDefaultOnParseException(e)](#M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnParseException-System-Exception- 'Semantica.Core.Json.StringJsonConverterBase`1.GetDefaultOnParseException(System.Exception)')
  - [GetDefaultOnUnexpectedTokenType(e)](#M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnUnexpectedTokenType-System-Exception- 'Semantica.Core.Json.StringJsonConverterBase`1.GetDefaultOnUnexpectedTokenType(System.Exception)')
  - [ToString(value)](#M-Semantica-Core-Json-StringJsonConverterBase`1-ToString-`0- 'Semantica.Core.Json.StringJsonConverterBase`1.ToString(`0)')
- [StringTypeConverterBase\`1](#T-Semantica-Core-StringTypeConverterBase`1 'Semantica.Core.StringTypeConverterBase`1')
  - [Default](#P-Semantica-Core-StringTypeConverterBase`1-Default 'Semantica.Core.StringTypeConverterBase`1.Default')
  - [DefaultOnEmpty](#P-Semantica-Core-StringTypeConverterBase`1-DefaultOnEmpty 'Semantica.Core.StringTypeConverterBase`1.DefaultOnEmpty')
  - [DefaultOnNull](#P-Semantica-Core-StringTypeConverterBase`1-DefaultOnNull 'Semantica.Core.StringTypeConverterBase`1.DefaultOnNull')
  - [DoTrim](#P-Semantica-Core-StringTypeConverterBase`1-DoTrim 'Semantica.Core.StringTypeConverterBase`1.DoTrim')
  - [FromString(str)](#M-Semantica-Core-StringTypeConverterBase`1-FromString-System-String- 'Semantica.Core.StringTypeConverterBase`1.FromString(System.String)')
  - [GetDefaultOnParseException(e)](#M-Semantica-Core-StringTypeConverterBase`1-GetDefaultOnParseException-System-Exception- 'Semantica.Core.StringTypeConverterBase`1.GetDefaultOnParseException(System.Exception)')
  - [ToString(value)](#M-Semantica-Core-StringTypeConverterBase`1-ToString-`0- 'Semantica.Core.StringTypeConverterBase`1.ToString(`0)')
- [UInt16\`1](#T-Semantica-Core-Json-JsonConverterBase-UInt16`1 'Semantica.Core.Json.JsonConverterBase.UInt16`1')
- [UInt32\`1](#T-Semantica-Core-Json-JsonConverterBase-UInt32`1 'Semantica.Core.Json.JsonConverterBase.UInt32`1')
- [UInt64\`1](#T-Semantica-Core-Json-JsonConverterBase-UInt64`1 'Semantica.Core.Json.JsonConverterBase.UInt64`1')

<a name='T-Semantica-Core-Json-JsonConverterBase-Base`2'></a>
## Base\`2 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Don't use this base class, but use one of the specific type base classes.

<a name='M-Semantica-Core-Json-JsonConverterBase-Base`2-FromUnderlyingType-`1-'></a>
### FromUnderlyingType(underlyingValue) `method`

##### Summary

Implementation of the conversion to `T`.

##### Returns

An instance of `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| underlyingValue | [\`1](#T-`1 '`1') | Value to convert. |

<a name='M-Semantica-Core-Json-JsonConverterBase-Base`2-GetDefault'></a>
### GetDefault() `method`

##### Summary

Returns default(T?) (`null`). Override if a different value to should be returned when reading of
the underlying type value fails.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Json-JsonConverterBase-Base`2-ToUnderlyingType-`0-'></a>
### ToUnderlyingType(value) `method`

##### Summary

Implementation of the conversion of `T` to the underlying type.

##### Returns

A representation of the input as [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') of the underlying type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value of `T` to convert. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Boolean`1'></a>
## Boolean\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to boolean. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Byte`1'></a>
## Byte\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to byte. |

<a name='T-Semantica-Core-Comparable'></a>
## Comparable `type`

##### Namespace

Semantica.Core

##### Summary

Provides a number of static methods used for comparison of instances of types implementing [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1').

<a name='M-Semantica-Core-Comparable-CompareOrNull``1-``0,``0-'></a>
### CompareOrNull\`\`1(this,other) `method`

##### Summary

Used to easily chain comparisons in a [CompareTo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1.CompareTo 'System.IComparable`1.CompareTo(`0)') implementation where there are multiple
 [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') properties used for comparison, utilizing the `??` operator.

##### Returns

`default(int?)` if both arguments are compared as equal, otherwise the result of the evaluation of
 [CompareTo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1.CompareTo 'System.IComparable`1.CompareTo(`0)') .

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [\`\`0](#T-``0 '``0') | A [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') instance. (typically the property of `this`). |
| other | [\`\`0](#T-``0 '``0') | A [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') instance. (typically the property of `other`). |

##### Example

```
 class MyClass: IComparable{MyClass} {
     double A;
     double B;
     int Compare(MyClass other) {
         return Comparable.CompareOrNull(A, other.A) ?? B.CompareTo(other.B); 
     }
 }
 
```

<a name='M-Semantica-Core-Comparable-Max``1-``0[]-'></a>
### Max\`\`1(array) `method`

##### Summary

Compares all arguments and returns the one that comes after all the others.

##### Returns

The maximal instance: the one that becomes after all the others if they would be ordered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Any number of instances to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type implementing [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'). |

##### Remarks

If multiple instances could be ordered last, the first one that was encountered would be returned.

<a name='M-Semantica-Core-Comparable-Max``1-``0,``0-'></a>
### Max\`\`1(left,right) `method`

##### Summary

Compares both arguments and returns the one that comes after the other.

##### Returns

The maximal instance: the one that becomes after the other if they would be ordered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | First instance to evaluate. |
| right | [\`\`0](#T-``0 '``0') | Second instance to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type implementing [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'). |

##### Remarks

If the instances are ordered equal, `left` is returned.

<a name='M-Semantica-Core-Comparable-Min``1-``0[]-'></a>
### Min\`\`1(array) `method`

##### Summary

Compares all arguments and returns the one that comes before all the others.

##### Returns

The minimal instance: the one that becomes before all the others if they would be ordered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Any number of instances to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type implementing [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'). |

##### Remarks

If multiple instances could be ordered first, the first one that was encountered would be returned.

<a name='M-Semantica-Core-Comparable-Min``1-``0,``0-'></a>
### Min\`\`1(left,right) `method`

##### Summary

Compares both arguments and returns the one that comes before the other.

##### Returns

The minimal instance: the one that becomes before the other if they would be ordered.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | First instance to evaluate. |
| right | [\`\`0](#T-``0 '``0') | Second instance to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type implementing [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'). |

##### Remarks

If the instances are ordered equal, `left` is returned.

<a name='M-Semantica-Core-Comparable-TryCompareHasValue-System-Boolean,System-Boolean,System-Int32@,System-Boolean-'></a>
### TryCompareHasValue(thisHasValue,otherHasValue,val,noValueIsBigger) `method`

##### Summary

Used to implement comparisons in a [CompareTo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1.CompareTo 'System.IComparable`1.CompareTo(`0)') implementation where the properties used for
 comparison do not always have values.

##### Returns

`true` if the comparison can be made on the basis of [HasValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1.HasValue 'System.Nullable`1.HasValue') alone.
 `false` if both arguments have values, and the comparison has to be made on the actual values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| thisHasValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` indicating whether the left argument has a value (typically the value of `this`). |
| otherHasValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` indicating whether the right argument has a value (typically the value of other). |
| val | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Out parameter containing the comparison result. |
| noValueIsBigger | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | When `true`, a value is always considered smaller than no value. Default `false`. |

##### Example

```
 class MyClass: IComparable{MyClass} {
     double? A;
     int Compare(MyClass other) {
         return Comparable.TryCompareValue(A.HasValue, other.A.HasValue, out int val) ? val : A.Value.CompareTo(other.A.Value); 
     }
 }
 
```

<a name='M-Semantica-Core-Comparable-TryCompareIsEmpty-System-Boolean,System-Boolean,System-Int32@,System-Boolean-'></a>
### TryCompareIsEmpty(thisIsEmpty,otherIsEmpty,val,emptyIsSmaller) `method`

##### Summary

Used to implement comparisons in a [CompareTo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1.CompareTo 'System.IComparable`1.CompareTo(`0)') implementation where the properties used for
 comparison can be empty.

##### Returns

`true` if the comparison can be made on the basis of empty/not empty alone.
 `false` if both have values, and the comparison has to be made on the actual values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| thisIsEmpty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` indicating whether the left argument is empty (typically the value of `this`). |
| otherIsEmpty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` indicating whether the right argument is empty (typically the value of other). |
| val | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Out parameter containing the comparison result. |
| emptyIsSmaller | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | When `false`, an empty value is always considered larger than no value. Default `true`. |

##### Example

```
 class MyClass: IComparable{MyClass} {
     string A;
     int Compare(MyClass other) {
         return Comparable.TryCompareValue(string.IsNullOrEmpty(A), string.IsNullOrEmpty(other.A), out int val) ? val : A.CompareTo(other.A); 
     }
 }
 
```

<a name='T-Semantica-Core-Json-JsonConverterBase-DateOnly`1'></a>
## DateOnly\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to dateonly. |

##### Remarks

DateOnly is currently not supported by System.Text.Json, so an extra conversion to and from DateTime is used.

<a name='T-Semantica-Core-DateTimeConstants'></a>
## DateTimeConstants `type`

##### Namespace

Semantica.Core

##### Summary

Contains many useful constants used in date/time calculations, that are private in [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

<a name='F-Semantica-Core-DateTimeConstants-DaysPer100Years'></a>
### DaysPer100Years `constants`

<a name='F-Semantica-Core-DateTimeConstants-DaysPer400Years'></a>
### DaysPer400Years `constants`

<a name='F-Semantica-Core-DateTimeConstants-DaysPer4Years'></a>
### DaysPer4Years `constants`

<a name='F-Semantica-Core-DateTimeConstants-DaysPerYear'></a>
### DaysPerYear `constants`

<a name='F-Semantica-Core-DateTimeConstants-DaysToMonth365'></a>
### DaysToMonth365 `constants`

<a name='F-Semantica-Core-DateTimeConstants-DaysToMonth366'></a>
### DaysToMonth366 `constants`

<a name='F-Semantica-Core-DateTimeConstants-MillisPerDay'></a>
### MillisPerDay `constants`

<a name='F-Semantica-Core-DateTimeConstants-MillisPerHour'></a>
### MillisPerHour `constants`

<a name='F-Semantica-Core-DateTimeConstants-MillisPerMinute'></a>
### MillisPerMinute `constants`

<a name='F-Semantica-Core-DateTimeConstants-MillisPerSecond'></a>
### MillisPerSecond `constants`

<a name='F-Semantica-Core-DateTimeConstants-TicksPerDay'></a>
### TicksPerDay `constants`

<a name='F-Semantica-Core-DateTimeConstants-TicksPerHour'></a>
### TicksPerHour `constants`

<a name='F-Semantica-Core-DateTimeConstants-TicksPerMillisecond'></a>
### TicksPerMillisecond `constants`

<a name='F-Semantica-Core-DateTimeConstants-TicksPerMinute'></a>
### TicksPerMinute `constants`

<a name='F-Semantica-Core-DateTimeConstants-TicksPerSecond'></a>
### TicksPerSecond `constants`

<a name='P-Semantica-Core-DateTimeConstants-DaysInMonth365'></a>
### DaysInMonth365 `property`

<a name='P-Semantica-Core-DateTimeConstants-DaysInMonth366'></a>
### DaysInMonth366 `property`

<a name='M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-Int32,System-Int32-'></a>
### GetDaysInMonth() `method`

##### Summary

Returns the number of days in the month represented by that `month` and `year`.

##### Returns

A `byte` value between 28 and 31.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-DateOnly-'></a>
### GetDaysInMonth() `method`

##### Summary

Returns the number of days in the month that `date` is in.

##### Returns

A `byte` value between 28 and 31.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DateTimeConstants-GetDaysInMonth-System-DateTime-'></a>
### GetDaysInMonth() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DateTimeConstants-MonthNumberAfter-System-Int32-'></a>
### MonthNumberAfter(month) `method`

##### Summary

Returns the monthnumber of the month that follows `month`. If the input value is invalid, the
output is invalid too.

##### Returns

A month number (1-12).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A month number (1-12). |

<a name='M-Semantica-Core-DateTimeConstants-MonthNumberBefore-System-Int32-'></a>
### MonthNumberBefore(month) `method`

##### Summary

Returns the monthnumber of the month that precedes `month`. If the input value is invalid, the
output is invalid too.

##### Returns

A month number (1-12).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A month number (1-12). |

<a name='T-Semantica-Core-Json-JsonConverterBase-DateTimeOffset`1'></a>
## DateTimeOffset\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to datetime offset. |

<a name='T-Semantica-Core-Json-JsonConverterBase-DateTime`1'></a>
## DateTime\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to datetime. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Decimal`1'></a>
## Decimal\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Decimal\`1](#T-Semantica-Core-Json-JsonConverterBase-Decimal`1 'Semantica.Core.Json.JsonConverterBase.Decimal`1').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to decimal. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Double`1'></a>
## Double\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to double. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Guid`1'></a>
## Guid\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to guid. |

<a name='T-Semantica-Core-Providers-IDateTimeProvider'></a>
## IDateTimeProvider `type`

##### Namespace

Semantica.Core.Providers

##### Summary

Provides methods to get the current date and time.

##### Remarks

The implementation is just a wrapper around the [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime')'s static [Now](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime.Now 'System.DateTime.Now'),
[UtcNow](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime.UtcNow 'System.DateTime.UtcNow') and [Today](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime.Today 'System.DateTime.Today') members in order to be able to mock it in tests.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-ConvertLocalToOffset-System-DateTime-'></a>
### ConvertLocalToOffset(dateTime) `method`

##### Summary

Will convert a non-UTC datetime to [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') with an explicit offset of the local timezone.

##### Returns

A local [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Input (non-UTC) [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') to convert [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | If the kind of the input is [Utc](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Utc 'System.DateTimeKind.Utc') and local timezone is not. |

<a name='M-Semantica-Core-Providers-IDateTimeProvider-ConvertUtcToOffset-System-DateTime-'></a>
### ConvertUtcToOffset(dateTime) `method`

##### Summary

Will convert a UTC datetime to the local timezone, and return it as a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Returns

A local [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Input UTC [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') to adjust to local time. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | If the kind of the input is not [Utc](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Utc 'System.DateTimeKind.Utc'). |

<a name='M-Semantica-Core-Providers-IDateTimeProvider-MidnightToday'></a>
### MidnightToday() `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') representing the current date. The date part of the returned value is the current date,
and the time-of-day part of the returned value is zero (midnight).

##### Parameters

This method has no parameters.

##### Remarks

The value wil have [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind').[Local](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Local 'System.DateTimeKind.Local').

<a name='M-Semantica-Core-Providers-IDateTimeProvider-MidnightTodayOffset'></a>
### MidnightTodayOffset() `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') representing the current date. The date part of the returned value is the current date,
and the time-of-day part of the returned value is zero (midnight).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-Now'></a>
### Now() `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') representing the current date and time.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer. The value wil have
[DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind').[Local](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Local 'System.DateTimeKind.Local'), unless [OffsetKind](#M-Semantica-Core-Providers-IDateTimeProvider-OffsetKind 'Semantica.Core.Providers.IDateTimeProvider.OffsetKind') is overridden.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-NowOffset'></a>
### NowOffset() `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') representing the current date and time.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-Offset-System-DateTime-'></a>
### Offset(dateTime) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') containing the local offset compared to UTC. Non-constant for locations that have
daylight-savings time (DST).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date and time for wich the offset needs to be determined, according to the [TimeZoneInfo](#M-Semantica-Core-Providers-IDateTimeProvider-TimeZoneInfo 'Semantica.Core.Providers.IDateTimeProvider.TimeZoneInfo'). |

##### Remarks

Override this or [TimeZoneInfo](#M-Semantica-Core-Providers-IDateTimeProvider-TimeZoneInfo 'Semantica.Core.Providers.IDateTimeProvider.TimeZoneInfo') to make methods return non-local time. When doing so,
[OffsetKind](#M-Semantica-Core-Providers-IDateTimeProvider-OffsetKind 'Semantica.Core.Providers.IDateTimeProvider.OffsetKind') should also be overridden to return [Unspecified](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Unspecified 'System.DateTimeKind.Unspecified').

<a name='M-Semantica-Core-Providers-IDateTimeProvider-OffsetKind'></a>
### OffsetKind() `method`

##### Summary

Returns the [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') used for all DateTimes returned.

##### Parameters

This method has no parameters.

##### Remarks

[Local](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Local 'System.DateTimeKind.Local'), unless the default implementation is overridden.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-Time'></a>
### Time() `method`

##### Summary

Returns a [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') representing the current time of day.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-TimeZoneInfo'></a>
### TimeZoneInfo() `method`

##### Summary

Returns the [TimeZoneInfo](#M-Semantica-Core-Providers-IDateTimeProvider-TimeZoneInfo 'Semantica.Core.Providers.IDateTimeProvider.TimeZoneInfo') used for all non-utc methods.

##### Parameters

This method has no parameters.

##### Remarks

Will use the local timezone unless overridden. When doing so, [OffsetKind](#M-Semantica-Core-Providers-IDateTimeProvider-OffsetKind 'Semantica.Core.Providers.IDateTimeProvider.OffsetKind') should also be overridden to
return [Unspecified](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Unspecified 'System.DateTimeKind.Unspecified').

<a name='M-Semantica-Core-Providers-IDateTimeProvider-Today'></a>
### Today() `method`

##### Summary

Returns a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') representing the current date.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcMidnightToday'></a>
### UtcMidnightToday() `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') representing the current date in Utc-time. The date part of the returned value is the
current date, and the time-of-day part of the returned value is zero (midnight).

##### Parameters

This method has no parameters.

##### Remarks

The value wil have [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind').[Utc](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Utc 'System.DateTimeKind.Utc').

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcMidnightTodayOffset'></a>
### UtcMidnightTodayOffset() `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') representing the current date in Utc-time. The date part of the returned value is the
current date, and the time-of-day part of the returned value is zero (midnight).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcNow'></a>
### UtcNow() `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') representing the current date and time in Utc-time.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer. The value wil have
[DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind').[Utc](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind.Utc 'System.DateTimeKind.Utc').

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcNowOffset'></a>
### UtcNowOffset() `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') representing the current date and time in Utc-time.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcTime'></a>
### UtcTime() `method`

##### Summary

Returns a [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') representing the current time of day in Utc-time.

##### Parameters

This method has no parameters.

##### Remarks

The resolution of the returned value depends on the system timer.

<a name='M-Semantica-Core-Providers-IDateTimeProvider-UtcToday'></a>
### UtcToday() `method`

##### Summary

Returns a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') representing the current date in Utc-time.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Core-Providers-ISnapshotDateTimeProvider'></a>
## ISnapshotDateTimeProvider `type`

##### Namespace

Semantica.Core.Providers

##### Summary

Provides methods to get the current date and time. Contrary to the normal [IDateTimeProvider](#T-Semantica-Core-Providers-IDateTimeProvider 'Semantica.Core.Providers.IDateTimeProvider'), the first time
the current date or time is retrieved in the current scope, this value is always returned until [Reset](#M-Semantica-Core-Providers-ISnapshotDateTimeProvider-Reset 'Semantica.Core.Providers.ISnapshotDateTimeProvider.Reset') is
called.

##### Remarks

When the implementation is registered with a scoped lifetime, this can be used to ensure that all multiple calls utilize the
same time, even when there is some process delaying parts of the execution by a significant amount of time.

<a name='M-Semantica-Core-Providers-ISnapshotDateTimeProvider-Reset'></a>
### Reset() `method`

##### Summary

Resets the stored date/time value for this scope. The next call to get the date/time will set the value to the exact
current date/time value at the moment of calling.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Core-Json-JsonConverterBase-Int16`1'></a>
## Int16\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to short. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Int32`1'></a>
## Int32\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to int. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Int64`1'></a>
## Int64\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to long. |

<a name='T-Semantica-Core-Json-JsonConverterBase'></a>
## JsonConverterBase `type`

##### Namespace

Semantica.Core.Json

##### Summary

Provides base classes inheriting from [JsonConverter\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverter`1 'System.Text.Json.Serialization.JsonConverter`1') for value types that hold a single underlying value
type (`struct`) that is supported by System.Text.Json.

##### Remarks

For conversions from the underlying type, override [GetDefault](#M-Semantica-Core-Json-JsonConverterBase-Base`2-GetDefault 'Semantica.Core.Json.JsonConverterBase.Base`2.GetDefault') if a value
different to default(T?) (`null`) should be returned when reading of the underlying type fails.

<a name='T-Semantica-Core-Logic'></a>
## Logic `type`

##### Namespace

Semantica.Core

##### Summary

Provides a number of static methods used for logic ([Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean')) operations that are not natively supported.

<a name='M-Semantica-Core-Logic-ExactlyOne-System-Boolean[]-'></a>
### ExactlyOne(bools) `method`

##### Summary

Determines if of the provided booleans, exactly one is `true`.

##### Returns

`true` if and only if one of the parameters is `true`, and all others are
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bools | [System.Boolean[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean[] 'System.Boolean[]') | Any number of `bool` parameters. |

<a name='M-Semantica-Core-Logic-Follows-System-Boolean,System-Boolean[]-'></a>
### Follows(if,bools) `method`

##### Summary

Determines if the provided booleans follow from `if`
[`if` -> `bools`].

##### Returns

`true` if either `if` is `false`, or `if` and all
`bools` are `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| if | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The `bool` parameter to be tested. |
| bools | [System.Boolean[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean[] 'System.Boolean[]') | Any number of `bool` parameters. |

<a name='M-Semantica-Core-Logic-None-System-Boolean[]-'></a>
### None(bools) `method`

##### Summary

Determines if of the provided booleans, all are `false`.

##### Returns

`true` if and only if all of the parameters are `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bools | [System.Boolean[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean[] 'System.Boolean[]') | Any number of `bool` parameters. |

##### Remarks

Logically equivalent to `! param1 && ! param2 && (...)`.

<a name='M-Semantica-Core-Logic-NoneOrOne-System-Boolean[]-'></a>
### NoneOrOne(bools) `method`

##### Summary

Determines if of the provided booleans, none or exactly one is `true`.

##### Returns

`true` if and only if zero or one of the parameters are `true`, and all others are
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bools | [System.Boolean[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean[] 'System.Boolean[]') | Any number of `bool` parameters. |

<a name='T-Semantica-Core-Module'></a>
## Module `type`

##### Namespace

Semantica.Core

##### Summary

Module that registers implementations of:

<a name='T-Semantica-Core-DependencyInjection-ModuleBase`1'></a>
## ModuleBase\`1 `type`

##### Namespace

Semantica.Core.DependencyInjection

##### Summary

Provides a neat way of organising DI registrations per project and within a project.

Assemblies containing dependencies are registered by overriding [GetDependencyAssemblies](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyAssemblies 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyAssemblies'). Individual modules
containing dependencies can be registered by overriding [GetDependencyModules](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyModules 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyModules').

When [Register](#M-Semantica-Core-DependencyInjection-ModuleBase`1-Register-`0,System-Boolean- 'Semantica.Core.DependencyInjection.ModuleBase`1.Register(`0,System.Boolean)') is called, all classes in all relevant assemblies that inherit from
[ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1') with a compatible container are recursively instantiated and called.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TContainer | The type of the used CI container or builder. |

<a name='M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyAssemblies'></a>
### GetDependencyAssemblies() `method`

##### Summary

Override if this module has dependencies within other assemblies. This method should yield all Assemblies containing
dependencies once.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyModules'></a>
### GetDependencyModules() `method`

##### Summary

Override if this module has dependencies within other modules. This method provides more granular dependency paths than
by using [GetDependencyAssemblies](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyAssemblies 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyAssemblies'), when a single assembly has multiple modules.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DependencyInjection-ModuleBase`1-GetMicrosoftDependencyInjectionModules'></a>
### GetMicrosoftDependencyInjectionModules() `method`

##### Summary

Override if this module has dependencies within other modules. This method provides more granular dependency paths than
by using [GetDependencyAssemblies](#M-Semantica-Core-DependencyInjection-ModuleBase`1-GetDependencyAssemblies 'Semantica.Core.DependencyInjection.ModuleBase`1.GetDependencyAssemblies'), when a single assembly has multiple modules. Only use if
[ToMicrosoftDependencyInjectionAbstractions](#M-Semantica-Core-DependencyInjection-ModuleBase`1-ToMicrosoftDependencyInjectionAbstractions-`0- 'Semantica.Core.DependencyInjection.ModuleBase`1.ToMicrosoftDependencyInjectionAbstractions(`0)') is overridden.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Core-DependencyInjection-ModuleBase`1-Register-`0,System-Boolean-'></a>
### Register(container,findOtherModulesInSameAssembly) `method`

##### Summary

Applies all registrations for the module, other modules in the same assembly, and modules in dependent assemblies.
Ensures modules are only used once, even if there are multiple paths to a dependency assembly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [\`0](#T-`0 '`0') | The CI container or builder instance used to do all registrations. |
| findOtherModulesInSameAssembly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `true`, the current assembly will be searched for other implementations of
[ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1'), and not just assemblies referenced in . |

##### Remarks

If `TContainer` is not [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection'),
and [ToMicrosoftDependencyInjectionAbstractions](#M-Semantica-Core-DependencyInjection-ModuleBase`1-ToMicrosoftDependencyInjectionAbstractions-`0- 'Semantica.Core.DependencyInjection.ModuleBase`1.ToMicrosoftDependencyInjectionAbstractions(`0)') is overridden and doesn't return `null`,
modules that implement [ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1') of type [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') are also searched for.

Registrations are done in order:

Module order within the assemblies is determined by [GetTypes](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly.GetTypes 'System.Reflection.Assembly.GetTypes').

<a name='M-Semantica-Core-DependencyInjection-ModuleBase`1-ToMicrosoftDependencyInjectionAbstractions-`0-'></a>
### ToMicrosoftDependencyInjectionAbstractions(container) `method`

##### Summary

Override this method if at any point in the Dependency Assemblies, there are modules that are defined using
[IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instead of a third party DI framework.
[](#N-Microsoft 'Microsoft').[](#N-Microsoft-Extensions-DependencyInjection 'Microsoft.Extensions.DependencyInjection').

##### Returns

A wrapper around `container` that implements at least the [Add](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1.Add 'System.Collections.Generic.ICollection`1.Add(`0)') method from
[IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [\`0](#T-`0 '`0') | The container of type `TContainer` used for third party registrations. |

##### Remarks

This will only work if the modules using [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') do only registrations in a manner that is
compatible to the third party `container`.

<a name='T-Semantica-Core-DependencyInjection-ModuleException'></a>
## ModuleException `type`

##### Namespace

Semantica.Core.DependencyInjection

##### Summary

Represents errors that occur during DI registrations using [ModuleBase\`1](#T-Semantica-Core-DependencyInjection-ModuleBase`1 'Semantica.Core.DependencyInjection.ModuleBase`1').

<a name='T-Semantica-Core-Json-JsonConverterBase-SByte`1'></a>
## SByte\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to sbyte. |

<a name='T-Semantica-Core-Json-JsonConverterBase-Single`1'></a>
## Single\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to float. |

<a name='T-Semantica-Core-StaticSelectors'></a>
## StaticSelectors `type`

##### Namespace

Semantica.Core

##### Summary

Provides predefined selector functions.

<a name='M-Semantica-Core-StaticSelectors-SelfNotNull``1-System-Nullable{``0}-'></a>
### SelfNotNull\`\`1(t) `method`

##### Summary

Returns the value of the element itself. Throws if element has no value.

##### Returns

`t`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of element to select. |

<a name='M-Semantica-Core-StaticSelectors-SelfNotNull``1-``0-'></a>
### SelfNotNull\`\`1(t) `method`

##### Summary

Returns the element itself.

##### Returns

`t`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`\`0](#T-``0 '``0') | The source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of element to select. |

<a name='M-Semantica-Core-StaticSelectors-Self``1-``0-'></a>
### Self\`\`1(t) `method`

##### Summary

Returns the element itself.

##### Returns

`t`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`\`0](#T-``0 '``0') | The source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of element to select. |

<a name='T-Semantica-Core-Json-StringJsonConverterBase`1'></a>
## StringJsonConverterBase\`1 `type`

##### Namespace

Semantica.Core.Json

##### Summary

Base class that inherits from [JsonConverter\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverter`1 'System.Text.Json.Serialization.JsonConverter`1'), meant for conversions of `T` from and to
`string`. Only [FromString](#M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.StringJsonConverterBase`1.FromString(System.String)') and [ToString](#M-Semantica-Core-Json-StringJsonConverterBase`1-ToString-`0- 'Semantica.Core.Json.StringJsonConverterBase`1.ToString(`0)') abstract methods need to be implemented.

For conversions from string, exceptions are thrown by default when an unexpected token is encountered. Override
[GetDefaultOnUnexpectedTokenType](#M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnUnexpectedTokenType-System-Exception- 'Semantica.Core.Json.StringJsonConverterBase`1.GetDefaultOnUnexpectedTokenType(System.Exception)') to change this behaviour. When [FromString](#M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.StringJsonConverterBase`1.FromString(System.String)') throws a
(parse-)exception, this exception is caught and rethrown in [GetDefaultOnParseException](#M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnParseException-System-Exception- 'Semantica.Core.Json.StringJsonConverterBase`1.GetDefaultOnParseException(System.Exception)'). Override this method
to change that behaviour. Override [DefaultOnNull](#P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnNull 'Semantica.Core.Json.StringJsonConverterBase`1.DefaultOnNull') or [DefaultOnEmpty](#P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnEmpty 'Semantica.Core.Json.StringJsonConverterBase`1.DefaultOnEmpty') when a special default value
(and not default(T)) is needed on null or empty input respectively. Overriding [Default](#P-Semantica-Core-Json-StringJsonConverterBase`1-Default 'Semantica.Core.Json.StringJsonConverterBase`1.Default') if these situations
require the same value.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to convert to and from [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

##### Remarks

Like the base [JsonConverter\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverter`1 'System.Text.Json.Serialization.JsonConverter`1'), if the property type is a class, or [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') and the input is
null, the value of null is assigned directly unless [HandleNull](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverter`1.HandleNull 'System.Text.Json.Serialization.JsonConverter`1.HandleNull') is overriden.

<a name='P-Semantica-Core-Json-StringJsonConverterBase`1-Default'></a>
### Default `property`

##### Summary

Returns default(T). Override if a different value to should be returned when a default value is needed. Override
If both other default properties are overriden, this property is no longer used.

<a name='P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnEmpty'></a>
### DefaultOnEmpty `property`

##### Summary

This property is called by [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') to get the value that's used when the input is an empty string (or
whitespace if [DoTrim](#P-Semantica-Core-Json-StringJsonConverterBase`1-DoTrim 'Semantica.Core.Json.StringJsonConverterBase`1.DoTrim') is true).

<a name='P-Semantica-Core-Json-StringJsonConverterBase`1-DefaultOnNull'></a>
### DefaultOnNull `property`

##### Summary

This property is called by [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') to get the value that's used when the input is `null`.

<a name='P-Semantica-Core-Json-StringJsonConverterBase`1-DoTrim'></a>
### DoTrim `property`

##### Summary

Returns `false` unless overriden. When `true`, the read string is trimmed before
evaluating whether it's empty, and passing it to [FromString](#M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.StringJsonConverterBase`1.FromString(System.String)').

<a name='M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String-'></a>
### FromString(str) `method`

##### Summary

Implementation of the conversion to `T`.

##### Returns

An instance of `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value to convert. |

<a name='M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnParseException-System-Exception-'></a>
### GetDefaultOnParseException(e) `method`

##### Summary

Rethrows the passed exception `e`. Called by [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') when an exception occured during
[FromString](#M-Semantica-Core-Json-StringJsonConverterBase`1-FromString-System-String- 'Semantica.Core.Json.StringJsonConverterBase`1.FromString(System.String)') (i.e. parsing). Override this method to make [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') return a default value rather
than throwing when this happens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The previously caught parse exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Re-)throws always. |

<a name='M-Semantica-Core-Json-StringJsonConverterBase`1-GetDefaultOnUnexpectedTokenType-System-Exception-'></a>
### GetDefaultOnUnexpectedTokenType(e) `method`

##### Summary

Rethrows the passed exception `e`. Called by [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') when an unexpected token type is
encountered. Override this method to make [Read](#M-Semantica-Core-Json-StringJsonConverterBase`1-Read-System-Text-Json-Utf8JsonReader@,System-Type,System-Text-Json-JsonSerializerOptions- 'Semantica.Core.Json.StringJsonConverterBase`1.Read(System.Text.Json.Utf8JsonReader@,System.Type,System.Text.Json.JsonSerializerOptions)') return a default value rather than throwing when this
happens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The previously caught token exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Re-)throws always. |

<a name='M-Semantica-Core-Json-StringJsonConverterBase`1-ToString-`0-'></a>
### ToString(value) `method`

##### Summary

Implementation of the conversion of `T` to string.

##### Returns

An string representation of the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value of `T` to convert. |

<a name='T-Semantica-Core-StringTypeConverterBase`1'></a>
## StringTypeConverterBase\`1 `type`

##### Namespace

Semantica.Core

##### Summary

Base class that inherits from [TypeConverter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverter 'System.ComponentModel.TypeConverter'), meant for conversions of `T` from and to
`string`. Only [FromString](#M-Semantica-Core-StringTypeConverterBase`1-FromString-System-String- 'Semantica.Core.StringTypeConverterBase`1.FromString(System.String)') and [ToString](#M-Semantica-Core-StringTypeConverterBase`1-ToString-`0- 'Semantica.Core.StringTypeConverterBase`1.ToString(`0)') abstract methods need to be implemented.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to convert to and from [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

##### Remarks

For conversions from string, override [DefaultOnNull](#P-Semantica-Core-StringTypeConverterBase`1-DefaultOnNull 'Semantica.Core.StringTypeConverterBase`1.DefaultOnNull') if a value different to default(T) should be returned on a
`null` value.

<a name='P-Semantica-Core-StringTypeConverterBase`1-Default'></a>
### Default `property`

##### Summary

Returns default(T). Override if a different value to should be returned when a default value is needed. Override
If both other default properties are overriden, this property is no longer used.

<a name='P-Semantica-Core-StringTypeConverterBase`1-DefaultOnEmpty'></a>
### DefaultOnEmpty `property`

##### Summary

This property is called by [ConvertTo](#M-Semantica-Core-StringTypeConverterBase`1-ConvertTo-System-ComponentModel-ITypeDescriptorContext,System-Globalization-CultureInfo,System-Object,System-Type- 'Semantica.Core.StringTypeConverterBase`1.ConvertTo(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object,System.Type)') to get the value that's used when the input is an empty string (or
whitespace if [DoTrim](#P-Semantica-Core-StringTypeConverterBase`1-DoTrim 'Semantica.Core.StringTypeConverterBase`1.DoTrim') is true).

<a name='P-Semantica-Core-StringTypeConverterBase`1-DefaultOnNull'></a>
### DefaultOnNull `property`

##### Summary

This property is called by [ConvertFrom](#M-Semantica-Core-StringTypeConverterBase`1-ConvertFrom-System-ComponentModel-ITypeDescriptorContext,System-Globalization-CultureInfo,System-Object- 'Semantica.Core.StringTypeConverterBase`1.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object)') to get the value that's used when the input is
`null`, or cannot be cast to a string.

<a name='P-Semantica-Core-StringTypeConverterBase`1-DoTrim'></a>
### DoTrim `property`

##### Summary

Returns `false` unless overriden. When `true`, the read string is trimmed before
evaluating whether it's empty, and passing it to [FromString](#M-Semantica-Core-StringTypeConverterBase`1-FromString-System-String- 'Semantica.Core.StringTypeConverterBase`1.FromString(System.String)').

<a name='M-Semantica-Core-StringTypeConverterBase`1-FromString-System-String-'></a>
### FromString(str) `method`

##### Summary

Implementation of the conversion to `T`.

##### Returns

An instance of `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String value to convert. |

<a name='M-Semantica-Core-StringTypeConverterBase`1-GetDefaultOnParseException-System-Exception-'></a>
### GetDefaultOnParseException(e) `method`

##### Summary

Rethrows the passed exception `e`. Called by [ConvertFrom](#M-Semantica-Core-StringTypeConverterBase`1-ConvertFrom-System-ComponentModel-ITypeDescriptorContext,System-Globalization-CultureInfo,System-Object- 'Semantica.Core.StringTypeConverterBase`1.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object)') when an exception occured during
[FromString](#M-Semantica-Core-StringTypeConverterBase`1-FromString-System-String- 'Semantica.Core.StringTypeConverterBase`1.FromString(System.String)') (i.e. parsing). Override this method to make [ConvertFrom](#M-Semantica-Core-StringTypeConverterBase`1-ConvertFrom-System-ComponentModel-ITypeDescriptorContext,System-Globalization-CultureInfo,System-Object- 'Semantica.Core.StringTypeConverterBase`1.ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object)') return a default value
rather than throwing when this happens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The previously caught parse exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Re-)throws always. |

<a name='M-Semantica-Core-StringTypeConverterBase`1-ToString-`0-'></a>
### ToString(value) `method`

##### Summary

Implementation of the conversion of `T` to string.

##### Returns

An string representation of the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | Value of `T` to convert. |

<a name='T-Semantica-Core-Json-JsonConverterBase-UInt16`1'></a>
## UInt16\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to ushort. |

<a name='T-Semantica-Core-Json-JsonConverterBase-UInt32`1'></a>
## UInt32\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to uint. |

<a name='T-Semantica-Core-Json-JsonConverterBase-UInt64`1'></a>
## UInt64\`1 `type`

##### Namespace

Semantica.Core.Json.JsonConverterBase

##### Summary

Use for value types that can be represented as a [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to convert from or to ulong. |
