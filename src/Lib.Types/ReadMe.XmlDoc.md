<a name='assembly'></a>
# Lib.Types

## Contents

- [DateSpan](#T-Semantica-Types-DateSpan 'Semantica.Types.DateSpan')
  - [_value](#F-Semantica-Types-DateSpan-_value 'Semantica.Types.DateSpan._value')
- [EmailAddressExtensions](#T-Semantica-Types-EmailAddressExtensions 'Semantica.Types.EmailAddressExtensions')
  - [IsValid()](#M-Semantica-Types-EmailAddressExtensions-IsValid-Semantica-Types-EmailAddress- 'Semantica.Types.EmailAddressExtensions.IsValid(Semantica.Types.EmailAddress)')
- [IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2')
- [LinkExtensions](#T-Semantica-Types-LinkExtensions 'Semantica.Types.LinkExtensions')
  - [IsValid()](#M-Semantica-Types-LinkExtensions-IsValid-Semantica-Types-Link- 'Semantica.Types.LinkExtensions.IsValid(Semantica.Types.Link)')
- [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate')
  - [#ctor(year,month,day)](#M-Semantica-Types-PartitionDate-#ctor-System-Int32,System-Int32,System-Int32- 'Semantica.Types.PartitionDate.#ctor(System.Int32,System.Int32,System.Int32)')
  - [#ctor(year,month,day)](#M-Semantica-Types-PartitionDate-#ctor-System-Int16,System-Byte,System-Byte- 'Semantica.Types.PartitionDate.#ctor(System.Int16,System.Byte,System.Byte)')
  - [Day](#P-Semantica-Types-PartitionDate-Day 'Semantica.Types.PartitionDate.Day')
  - [Month](#P-Semantica-Types-PartitionDate-Month 'Semantica.Types.PartitionDate.Month')
  - [Year](#P-Semantica-Types-PartitionDate-Year 'Semantica.Types.PartitionDate.Year')
  - [GetDay()](#M-Semantica-Types-PartitionDate-GetDay 'Semantica.Types.PartitionDate.GetDay')
  - [GetMonth()](#M-Semantica-Types-PartitionDate-GetMonth 'Semantica.Types.PartitionDate.GetMonth')
  - [GetYear()](#M-Semantica-Types-PartitionDate-GetYear 'Semantica.Types.PartitionDate.GetYear')
  - [HasDay()](#M-Semantica-Types-PartitionDate-HasDay 'Semantica.Types.PartitionDate.HasDay')
  - [HasMonth()](#M-Semantica-Types-PartitionDate-HasMonth 'Semantica.Types.PartitionDate.HasMonth')
  - [HasYear()](#M-Semantica-Types-PartitionDate-HasYear 'Semantica.Types.PartitionDate.HasYear')
- [PartitionDateExtensions](#T-Semantica-Types-PartitionDateExtensions 'Semantica.Types.PartitionDateExtensions')
  - [AsDateOnly(value)](#M-Semantica-Types-PartitionDateExtensions-AsDateOnly-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.AsDateOnly(Semantica.Types.PartitionDate)')
  - [AsDateTime(value,dateTimeKind)](#M-Semantica-Types-PartitionDateExtensions-AsDateTime-Semantica-Types-PartitionDate,System-DateTimeKind- 'Semantica.Types.PartitionDateExtensions.AsDateTime(Semantica.Types.PartitionDate,System.DateTimeKind)')
  - [AsNullableDateOnly(value)](#M-Semantica-Types-PartitionDateExtensions-AsNullableDateOnly-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.AsNullableDateOnly(Semantica.Types.PartitionDate)')
  - [AsNullableDateTime(value,dateTimeKind)](#M-Semantica-Types-PartitionDateExtensions-AsNullableDateTime-Semantica-Types-PartitionDate,System-DateTimeKind- 'Semantica.Types.PartitionDateExtensions.AsNullableDateTime(Semantica.Types.PartitionDate,System.DateTimeKind)')
  - [AsPartitionDate(value)](#M-Semantica-Types-PartitionDateExtensions-AsPartitionDate-System-DateOnly- 'Semantica.Types.PartitionDateExtensions.AsPartitionDate(System.DateOnly)')
  - [AsPartitionDate(value)](#M-Semantica-Types-PartitionDateExtensions-AsPartitionDate-System-DateTime- 'Semantica.Types.PartitionDateExtensions.AsPartitionDate(System.DateTime)')
  - [HasValidDay(value)](#M-Semantica-Types-PartitionDateExtensions-HasValidDay-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.HasValidDay(Semantica.Types.PartitionDate)')
  - [HasValidMonth(value)](#M-Semantica-Types-PartitionDateExtensions-HasValidMonth-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.HasValidMonth(Semantica.Types.PartitionDate)')
  - [HasValidYear(value)](#M-Semantica-Types-PartitionDateExtensions-HasValidYear-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.HasValidYear(Semantica.Types.PartitionDate)')
  - [IsValidDate(value)](#M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.IsValidDate(Semantica.Types.PartitionDate)')
  - [TryAsDateOnly(value,dateOnly)](#M-Semantica-Types-PartitionDateExtensions-TryAsDateOnly-Semantica-Types-PartitionDate,System-DateOnly@- 'Semantica.Types.PartitionDateExtensions.TryAsDateOnly(Semantica.Types.PartitionDate,System.DateOnly@)')
  - [TryAsDateTime(value,dateTime,dateTimeKind)](#M-Semantica-Types-PartitionDateExtensions-TryAsDateTime-Semantica-Types-PartitionDate,System-DateTime@,System-DateTimeKind- 'Semantica.Types.PartitionDateExtensions.TryAsDateTime(Semantica.Types.PartitionDate,System.DateTime@,System.DateTimeKind)')
- [PartitionDateTypeConverter](#T-Semantica-Types-Converters-PartitionDateTypeConverter 'Semantica.Types.Converters.PartitionDateTypeConverter')
  - [Deserialize(str)](#M-Semantica-Types-Converters-PartitionDateTypeConverter-Deserialize-System-String- 'Semantica.Types.Converters.PartitionDateTypeConverter.Deserialize(System.String)')
  - [Serialize(value)](#M-Semantica-Types-Converters-PartitionDateTypeConverter-Serialize-Semantica-Types-PartitionDate- 'Semantica.Types.Converters.PartitionDateTypeConverter.Serialize(Semantica.Types.PartitionDate)')
- [TypeConverterRegistrations](#T-Semantica-Types-Converters-TypeConverterRegistrations 'Semantica.Types.Converters.TypeConverterRegistrations')
  - [AddTypeConverterAttribute(valueType,converterType)](#M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttribute-System-Type,System-Type- 'Semantica.Types.Converters.TypeConverterRegistrations.AddTypeConverterAttribute(System.Type,System.Type)')
  - [AddTypeConverterAttributes(types)](#M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttributes-System-Collections-Generic-IEnumerable{System-Type}- 'Semantica.Types.Converters.TypeConverterRegistrations.AddTypeConverterAttributes(System.Collections.Generic.IEnumerable{System.Type})')
  - [AddTypeConverterAttributesInAssembly(assemblies)](#M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttributesInAssembly-System-Reflection-Assembly[]- 'Semantica.Types.Converters.TypeConverterRegistrations.AddTypeConverterAttributesInAssembly(System.Reflection.Assembly[])')

<a name='T-Semantica-Types-DateSpan'></a>
## DateSpan `type`

##### Namespace

Semantica.Types

##### Summary

Represents a difference between two dates, considering months and days separately.

<a name='F-Semantica-Types-DateSpan-_value'></a>
### _value `constants`

##### Summary

Value holding the number of days (5 bits: 1-5), the total number of months (17 bits: 6-22) the amount of days till
the end of the month in case of month-rollover (5 bits: 23-27), difference in weekday (3 bits: 28-30) and the sign
(bit 31), and whether or not the span was constructed as a full difference (bit 32).

<a name='T-Semantica-Types-EmailAddressExtensions'></a>
## EmailAddressExtensions `type`

##### Namespace

Semantica.Types

##### Summary

Provides extension methods for [EmailAddress](#T-Semantica-Types-EmailAddress 'Semantica.Types.EmailAddress').

<a name='M-Semantica-Types-EmailAddressExtensions-IsValid-Semantica-Types-EmailAddress-'></a>
### IsValid() `method`

##### Summary

Checks technical validity of the email, using System.Net.Mail.[MailAddress](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Mail.MailAddress 'System.Net.Mail.MailAddress').

##### Parameters

This method has no parameters.

##### Remarks

from

<a name='T-Semantica-Types-IRuntimeTypeConverter`2'></a>
## IRuntimeTypeConverter\`2 `type`

##### Namespace

Semantica.Types

##### Summary

Interface that provides standardizes a method to dynamically add a [TypeConverterAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverterAttribute 'System.ComponentModel.TypeConverterAttribute') for a
value type, that can be put on the typeconverter for that type. The default implementation should always suffice.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (value-)type the the typeconverter can convert. |
| TConverter | Type of the typeconverter |

##### Remarks

This interface can be used for using type converters for value types that are in a different assembly than the
corresponding typeconverter.

The [AddTypeConverterAttribute](#M-Semantica-Types-IRuntimeTypeConverter`2-AddTypeConverterAttribute 'Semantica.Types.IRuntimeTypeConverter`2.AddTypeConverterAttribute') method can be called at runtime for each custom type converter, or alternativly
use [TypeConverterRegistrations](#T-Semantica-Types-Converters-TypeConverterRegistrations 'Semantica.Types.Converters.TypeConverterRegistrations') to search for all type converters implementing this interface in
provided assemblies.

<a name='T-Semantica-Types-LinkExtensions'></a>
## LinkExtensions `type`

##### Namespace

Semantica.Types

##### Summary

Provides extension methods for [Link](#T-Semantica-Types-Link 'Semantica.Types.Link').

<a name='M-Semantica-Types-LinkExtensions-IsValid-Semantica-Types-Link-'></a>
### IsValid() `method`

##### Summary

Checks technical validity of the email, using System.[Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri').

##### Parameters

This method has no parameters.

<a name='T-Semantica-Types-PartitionDate'></a>
## PartitionDate `type`

##### Namespace

Semantica.Types

##### Summary

Represents a date. Each part of the date is optional and can be empty (0). No validation is done on the values, but each part has a maximum amount of digits and cannot be negative.

##### Remarks

The value is only considered empty if all three parts are empty.

<a name='M-Semantica-Types-PartitionDate-#ctor-System-Int32,System-Int32,System-Int32-'></a>
### #ctor(year,month,day) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A positive year value smaller or equal to [YearMax](#F-Semantica-Types-PartitionDate-YearMax 'Semantica.Types.PartitionDate.YearMax'). |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A positive month value smaller than [MonthMax](#F-Semantica-Types-PartitionDate-MonthMax 'Semantica.Types.PartitionDate.MonthMax'). |
| day | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A positive day value smaller than [DayMax](#F-Semantica-Types-PartitionDate-DayMax 'Semantica.Types.PartitionDate.DayMax'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') | throws if `year` cannot be cast to `ushort`, or `month`, `day` cannot be cast to `byte`. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | throws if `year` is greater than , `month` is greater than ,
`day` is greater than . |

<a name='M-Semantica-Types-PartitionDate-#ctor-System-Int16,System-Byte,System-Byte-'></a>
### #ctor(year,month,day) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | A year value smaller or equal to [YearMax](#F-Semantica-Types-PartitionDate-YearMax 'Semantica.Types.PartitionDate.YearMax'). |
| month | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | A month value smaller than [MonthMax](#F-Semantica-Types-PartitionDate-MonthMax 'Semantica.Types.PartitionDate.MonthMax'). |
| day | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | A day value smaller than [DayMax](#F-Semantica-Types-PartitionDate-DayMax 'Semantica.Types.PartitionDate.DayMax'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | throws if `year` is greater than , `month` is greater than ,
`day` is greater than . |

<a name='P-Semantica-Types-PartitionDate-Day'></a>
### Day `property`

<a name='P-Semantica-Types-PartitionDate-Month'></a>
### Month `property`

<a name='P-Semantica-Types-PartitionDate-Year'></a>
### Year `property`

<a name='M-Semantica-Types-PartitionDate-GetDay'></a>
### GetDay() `method`

##### Parameters

This method has no parameters.

<a name='M-Semantica-Types-PartitionDate-GetMonth'></a>
### GetMonth() `method`

##### Parameters

This method has no parameters.

<a name='M-Semantica-Types-PartitionDate-GetYear'></a>
### GetYear() `method`

##### Parameters

This method has no parameters.

<a name='M-Semantica-Types-PartitionDate-HasDay'></a>
### HasDay() `method`

##### Returns

`true` if the day-part of the date is not 0.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Types-PartitionDate-HasMonth'></a>
### HasMonth() `method`

##### Returns

`true` if the month-part of the date is not 0.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Types-PartitionDate-HasYear'></a>
### HasYear() `method`

##### Returns

`true` if the year-part of the date is not 0.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Types-PartitionDateExtensions'></a>
## PartitionDateExtensions `type`

##### Namespace

Semantica.Types

##### Summary

Provides additional functionality for to [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') values.

<a name='M-Semantica-Types-PartitionDateExtensions-AsDateOnly-Semantica-Types-PartitionDate-'></a>
### AsDateOnly(value) `method`

##### Summary

Conversts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly').

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | Date value to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

<a name='M-Semantica-Types-PartitionDateExtensions-AsDateTime-Semantica-Types-PartitionDate,System-DateTimeKind-'></a>
### AsDateTime(value,dateTimeKind) `method`

##### Summary

Conversts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') instance, with the time part set at midnight.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | Date value to convert. |
| dateTimeKind | [System.DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') | Optional. [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') used in the created DateTime. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

<a name='M-Semantica-Types-PartitionDateExtensions-AsNullableDateOnly-Semantica-Types-PartitionDate-'></a>
### AsNullableDateOnly(value) `method`

##### Summary

Conversts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly').
If input is invalid then null is returned (see [IsValidDate](#M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.IsValidDate(Semantica.Types.PartitionDate)').

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') instance; no value when invalid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | Date value to convert. |

<a name='M-Semantica-Types-PartitionDateExtensions-AsNullableDateTime-Semantica-Types-PartitionDate,System-DateTimeKind-'></a>
### AsNullableDateTime(value,dateTimeKind) `method`

##### Summary

Converts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').
If input is invalid then null is returned (see [IsValidDate](#M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.IsValidDate(Semantica.Types.PartitionDate)').

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') instance; no value when invalid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | Date value to convert. |
| dateTimeKind | [System.DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') | Optional. [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') used in the created value. |

<a name='M-Semantica-Types-PartitionDateExtensions-AsPartitionDate-System-DateOnly-'></a>
### AsPartitionDate(value) `method`

##### Summary

Converts a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value to [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate').

##### Returns

A [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value to convert. |

<a name='M-Semantica-Types-PartitionDateExtensions-AsPartitionDate-System-DateTime-'></a>
### AsPartitionDate(value) `method`

##### Summary

Converts a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate'). The time part is ignored.

##### Returns

A [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to convert. |

<a name='M-Semantica-Types-PartitionDateExtensions-HasValidDay-Semantica-Types-PartitionDate-'></a>
### HasValidDay(value) `method`

##### Summary

Determines if the [Day](#P-Semantica-Types-PartitionDate-Day 'Semantica.Types.PartitionDate.Day') part of the input has a valid value. The combination of all parts can
still be invalid.

##### Returns

`true` if the day part is valid (in the range of 1-31); `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to evaluate the day part of. |

<a name='M-Semantica-Types-PartitionDateExtensions-HasValidMonth-Semantica-Types-PartitionDate-'></a>
### HasValidMonth(value) `method`

##### Summary

Determines if the [Month](#P-Semantica-Types-PartitionDate-Month 'Semantica.Types.PartitionDate.Month') part of the input has a valid value. The combination of all parts
can still be invalid.

##### Returns

`true` if the month part is valid (in the range of 1-12); `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to evaluate the month part of. |

<a name='M-Semantica-Types-PartitionDateExtensions-HasValidYear-Semantica-Types-PartitionDate-'></a>
### HasValidYear(value) `method`

##### Summary

Determines if the [Year](#P-Semantica-Types-PartitionDate-Year 'Semantica.Types.PartitionDate.Year') part of the input has a valid value. The combination of all parts can
still be invalid.

##### Returns

`true` if the year part is valid (in the range of 1-9999); `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to evaluate the year part of. |

<a name='M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate-'></a>
### IsValidDate(value) `method`

##### Summary

Determines whether `value` contains a valid date.

##### Returns

`true` if date is convertable to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to convert |

<a name='M-Semantica-Types-PartitionDateExtensions-TryAsDateOnly-Semantica-Types-PartitionDate,System-DateOnly@-'></a>
### TryAsDateOnly(value,dateOnly) `method`

##### Summary

Converts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') and returns whether conversion succeeded.
Fails when the value is an invalid date (see [IsValidDate](#M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.IsValidDate(Semantica.Types.PartitionDate)')).

##### Returns

`true` if `dateOnly` has been set; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to convert. |
| dateOnly | [System.DateOnly@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly@ 'System.DateOnly@') | Out parameter that will contain the [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value if succeeded. |

<a name='M-Semantica-Types-PartitionDateExtensions-TryAsDateTime-Semantica-Types-PartitionDate,System-DateTime@,System-DateTimeKind-'></a>
### TryAsDateTime(value,dateTime,dateTimeKind) `method`

##### Summary

Converts a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value to [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') and returns whether conversion succeeded.
Fails when the value is an invalid date (see [IsValidDate](#M-Semantica-Types-PartitionDateExtensions-IsValidDate-Semantica-Types-PartitionDate- 'Semantica.Types.PartitionDateExtensions.IsValidDate(Semantica.Types.PartitionDate)')).

##### Returns

`true` if `dateTime` has been set; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') to convert. |
| dateTime | [System.DateTime@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime@ 'System.DateTime@') | Out parameter that will contain the [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value if succeeded. |
| dateTimeKind | [System.DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') | Optional. [DateTimeKind](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeKind 'System.DateTimeKind') used in the created value. |

<a name='T-Semantica-Types-Converters-PartitionDateTypeConverter'></a>
## PartitionDateTypeConverter `type`

##### Namespace

Semantica.Types.Converters

##### Summary

TypeConverter for [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate')

<a name='M-Semantica-Types-Converters-PartitionDateTypeConverter-Deserialize-System-String-'></a>
### Deserialize(str) `method`

##### Summary

Deserializes a string to a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value. Will accept any string that has exactly two '|' chars in
it, and at least one of the parts can be parsed to a [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') (year) or [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') (day/month).

##### Returns

A [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value containing all valid parts of the parsed string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to parse, "yyyy|MM|dd". |

<a name='M-Semantica-Types-Converters-PartitionDateTypeConverter-Serialize-Semantica-Types-PartitionDate-'></a>
### Serialize(value) `method`

##### Summary

Serializes a [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value representing the input value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Semantica.Types.PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') | A [PartitionDate](#T-Semantica-Types-PartitionDate 'Semantica.Types.PartitionDate') value. |

<a name='T-Semantica-Types-Converters-TypeConverterRegistrations'></a>
## TypeConverterRegistrations `type`

##### Namespace

Semantica.Types.Converters

##### Summary

Provides functionality to dynamically add [TypeConverterAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverterAttribute 'System.ComponentModel.TypeConverterAttribute') to types, so this can be used when the
converter and the value type are in different assemblies. Converter classes have to implement
[IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2') to be recognised.[AddTypeConverterAttributesInAssembly](#M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttributesInAssembly-System-Reflection-Assembly[]- 'Semantica.Types.Converters.TypeConverterRegistrations.AddTypeConverterAttributesInAssembly(System.Reflection.Assembly[])') is the main entry method.

<a name='M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttribute-System-Type,System-Type-'></a>
### AddTypeConverterAttribute(valueType,converterType) `method`

##### Summary

Adds a [TypeConverterAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverterAttribute 'System.ComponentModel.TypeConverterAttribute') to `valueType`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| valueType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Value type to add the attribute to. |
| converterType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Converter type to use as the attribute argument. |

<a name='M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttributes-System-Collections-Generic-IEnumerable{System-Type}-'></a>
### AddTypeConverterAttributes(types) `method`

##### Summary

Filters the supplied types to ones that implement [IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2'). Adds
[TypeConverterAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverterAttribute 'System.ComponentModel.TypeConverterAttribute') for the found types.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| types | [System.Collections.Generic.IEnumerable{System.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Type}') | An enumeration of types that include the typeconverter types. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Types.Converters.TypeConverterRegistrations.TypeConverterRegistrationsException](#T-Semantica-Types-Converters-TypeConverterRegistrations-TypeConverterRegistrationsException 'Semantica.Types.Converters.TypeConverterRegistrations.TypeConverterRegistrationsException') | Throws if two converters are found for the same type. Throws if the converter type attribute of the
[IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2') interface is not the converter type itself. |

<a name='M-Semantica-Types-Converters-TypeConverterRegistrations-AddTypeConverterAttributesInAssembly-System-Reflection-Assembly[]-'></a>
### AddTypeConverterAttributesInAssembly(assemblies) `method`

##### Summary

Main entry method. Finds all classes that implement [IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2') in the supplied
assemblies. Adds [TypeConverterAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.TypeConverterAttribute 'System.ComponentModel.TypeConverterAttribute') for the found types.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assemblies | [System.Reflection.Assembly[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly[] 'System.Reflection.Assembly[]') | Assemblies to look for typeconverters in. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Types.Converters.TypeConverterRegistrations.TypeConverterRegistrationsException](#T-Semantica-Types-Converters-TypeConverterRegistrations-TypeConverterRegistrationsException 'Semantica.Types.Converters.TypeConverterRegistrations.TypeConverterRegistrationsException') | Throws if two converters are found for the same type. Throws if the converter type attribute of the
[IRuntimeTypeConverter\`2](#T-Semantica-Types-IRuntimeTypeConverter`2 'Semantica.Types.IRuntimeTypeConverter`2') interface is not the converter type itself. |
