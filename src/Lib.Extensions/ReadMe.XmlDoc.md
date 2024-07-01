<a name='assembly'></a>
# Lib.Extensions

## Contents

- [ArrayExtensions](#T-Semantica-Extensions-ArrayExtensions 'Semantica.Extensions.ArrayExtensions')
- [AttributeExtensions](#T-Semantica-Extensions-AttributeExtensions 'Semantica.Extensions.AttributeExtensions')
  - [GetAttribute\`\`2(enum)](#M-Semantica-Extensions-AttributeExtensions-GetAttribute``2-``1- 'Semantica.Extensions.AttributeExtensions.GetAttribute``2(``1)')
  - [GetAttribute\`\`2(enum,enumFieldInfos)](#M-Semantica-Extensions-AttributeExtensions-GetAttribute``2-``1,System-Collections-Generic-IEnumerable{System-Reflection-FieldInfo}- 'Semantica.Extensions.AttributeExtensions.GetAttribute``2(``1,System.Collections.Generic.IEnumerable{System.Reflection.FieldInfo})')
  - [HasAttribute\`\`2(enum)](#M-Semantica-Extensions-AttributeExtensions-HasAttribute``2-``1- 'Semantica.Extensions.AttributeExtensions.HasAttribute``2(``1)')
- [AveragingExtensions](#T-Semantica-Extensions-AveragingExtensions 'Semantica.Extensions.AveragingExtensions')
  - [Median\`\`1()](#M-Semantica-Extensions-AveragingExtensions-Median``1-System-Collections-Generic-IList{``0}- 'Semantica.Extensions.AveragingExtensions.Median``1(System.Collections.Generic.IList{``0})')
  - [NthOrderStatistic\`\`1()](#M-Semantica-Extensions-AveragingExtensions-NthOrderStatistic``1-System-Collections-Generic-IList{``0},System-Int32,System-Random- 'Semantica.Extensions.AveragingExtensions.NthOrderStatistic``1(System.Collections.Generic.IList{``0},System.Int32,System.Random)')
  - [Partition\`\`1()](#M-Semantica-Extensions-AveragingExtensions-Partition``1-System-Collections-Generic-IList{``0},System-Int32,System-Int32,System-Random- 'Semantica.Extensions.AveragingExtensions.Partition``1(System.Collections.Generic.IList{``0},System.Int32,System.Int32,System.Random)')
- [BooleanExtensions](#T-Semantica-Extensions-BooleanExtensions 'Semantica.Extensions.BooleanExtensions')
  - [IsExplicitFalse(nullableBln)](#M-Semantica-Extensions-BooleanExtensions-IsExplicitFalse-System-Nullable{System-Boolean}- 'Semantica.Extensions.BooleanExtensions.IsExplicitFalse(System.Nullable{System.Boolean})')
- [CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle')
  - [PreserveCasing](#F-Semantica-Extensions-Flags-CasingStyle-PreserveCasing 'Semantica.Extensions.Flags.CasingStyle.PreserveCasing')
  - [PreserveUnderscores](#F-Semantica-Extensions-Flags-CasingStyle-PreserveUnderscores 'Semantica.Extensions.Flags.CasingStyle.PreserveUnderscores')
  - [ToUpperCase](#F-Semantica-Extensions-Flags-CasingStyle-ToUpperCase 'Semantica.Extensions.Flags.CasingStyle.ToUpperCase')
  - [UnderscoresAsBoundaries](#F-Semantica-Extensions-Flags-CasingStyle-UnderscoresAsBoundaries 'Semantica.Extensions.Flags.CasingStyle.UnderscoresAsBoundaries')
- [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer')
  - [#ctor(Input,Separator,RestIndex)](#M-Semantica-Extensions-Tokenizer-CharTokenizer-#ctor-System-String,System-Char,System-Int32- 'Semantica.Extensions.Tokenizer.CharTokenizer.#ctor(System.String,System.Char,System.Int32)')
  - [Input](#P-Semantica-Extensions-Tokenizer-CharTokenizer-Input 'Semantica.Extensions.Tokenizer.CharTokenizer.Input')
  - [RestIndex](#P-Semantica-Extensions-Tokenizer-CharTokenizer-RestIndex 'Semantica.Extensions.Tokenizer.CharTokenizer.RestIndex')
  - [Separator](#P-Semantica-Extensions-Tokenizer-CharTokenizer-Separator 'Semantica.Extensions.Tokenizer.CharTokenizer.Separator')
- [ComparableExtensions](#T-Semantica-Extensions-ComparableExtensions 'Semantica.Extensions.ComparableExtensions')
  - [MaxByOrNull\`\`2(enumerable,valueFunc)](#M-Semantica-Extensions-ComparableExtensions-MaxByOrNull``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}- 'Semantica.Extensions.ComparableExtensions.MaxByOrNull``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})')
  - [MaxBy\`\`3(enumerable,selector,predicate,tiebreaker)](#M-Semantica-Extensions-ComparableExtensions-MaxBy``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``1,System-Boolean},System-Func{``0,``2}- 'Semantica.Extensions.ComparableExtensions.MaxBy``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Func{``1,System.Boolean},System.Func{``0,``2})')
  - [MaxOrNull\`\`1(enumerable)](#M-Semantica-Extensions-ComparableExtensions-MaxOrNull``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Extensions.ComparableExtensions.MaxOrNull``1(System.Collections.Generic.IEnumerable{``0})')
- [DateOnlyExtensions](#T-Semantica-Extensions-DateOnlyExtensions 'Semantica.Extensions.DateOnlyExtensions')
  - [FirstOfMonth(date)](#M-Semantica-Extensions-DateOnlyExtensions-FirstOfMonth-System-DateOnly- 'Semantica.Extensions.DateOnlyExtensions.FirstOfMonth(System.DateOnly)')
  - [FloorToMonth(date)](#M-Semantica-Extensions-DateOnlyExtensions-FloorToMonth-System-DateOnly- 'Semantica.Extensions.DateOnlyExtensions.FloorToMonth(System.DateOnly)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateOnly- 'Semantica.Extensions.DateOnlyExtensions.IsSameMonth(System.DateOnly,System.DateOnly)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateTimeOffset- 'Semantica.Extensions.DateOnlyExtensions.IsSameMonth(System.DateOnly,System.DateTimeOffset)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateTime- 'Semantica.Extensions.DateOnlyExtensions.IsSameMonth(System.DateOnly,System.DateTime)')
  - [ToDateTime(dateOnly)](#M-Semantica-Extensions-DateOnlyExtensions-ToDateTime-System-DateOnly- 'Semantica.Extensions.DateOnlyExtensions.ToDateTime(System.DateOnly)')
  - [ToDateTime()](#M-Semantica-Extensions-DateOnlyExtensions-ToDateTime-System-Nullable{System-DateOnly}- 'Semantica.Extensions.DateOnlyExtensions.ToDateTime(System.Nullable{System.DateOnly})')
- [DateTimeExtensions](#T-Semantica-Extensions-DateTimeExtensions 'Semantica.Extensions.DateTimeExtensions')
  - [FirstOfMonth(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FirstOfMonth-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FirstOfMonth(System.DateTime)')
  - [FloorToDay(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToDay-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToDay(System.DateTime)')
  - [FloorToHour(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToHour-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToHour(System.DateTime)')
  - [FloorToMillisecond(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToMillisecond-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToMillisecond(System.DateTime)')
  - [FloorToMinute(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToMinute-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToMinute(System.DateTime)')
  - [FloorToMonth(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToMonth-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToMonth(System.DateTime)')
  - [FloorToSecond(datetime)](#M-Semantica-Extensions-DateTimeExtensions-FloorToSecond-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToSecond(System.DateTime)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateOnly- 'Semantica.Extensions.DateTimeExtensions.IsSameMonth(System.DateTime,System.DateOnly)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateTimeOffset- 'Semantica.Extensions.DateTimeExtensions.IsSameMonth(System.DateTime,System.DateTimeOffset)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateTime- 'Semantica.Extensions.DateTimeExtensions.IsSameMonth(System.DateTime,System.DateTime)')
  - [ToDateOnly(dateTime)](#M-Semantica-Extensions-DateTimeExtensions-ToDateOnly-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.ToDateOnly(System.DateTime)')
  - [ToDateOnly()](#M-Semantica-Extensions-DateTimeExtensions-ToDateOnly-System-Nullable{System-DateTime}- 'Semantica.Extensions.DateTimeExtensions.ToDateOnly(System.Nullable{System.DateTime})')
  - [ToTimeOnly(dateTime)](#M-Semantica-Extensions-DateTimeExtensions-ToTimeOnly-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.ToTimeOnly(System.DateTime)')
  - [ToTimeOnly()](#M-Semantica-Extensions-DateTimeExtensions-ToTimeOnly-System-Nullable{System-DateTime}- 'Semantica.Extensions.DateTimeExtensions.ToTimeOnly(System.Nullable{System.DateTime})')
- [DateTimeOffsetExtensions](#T-Semantica-Extensions-DateTimeOffsetExtensions 'Semantica.Extensions.DateTimeOffsetExtensions')
  - [FirstOfMonth(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FirstOfMonth-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FirstOfMonth(System.DateTimeOffset)')
  - [FloorToDay(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToDay-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToDay(System.DateTimeOffset)')
  - [FloorToHour(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToHour-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToHour(System.DateTimeOffset)')
  - [FloorToMillisecond(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMillisecond-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToMillisecond(System.DateTimeOffset)')
  - [FloorToMinute(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMinute-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToMinute(System.DateTimeOffset)')
  - [FloorToMonth(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMonth-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToMonth(System.DateTimeOffset)')
  - [FloorToSecond(datetimeOffset)](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToSecond-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToSecond(System.DateTimeOffset)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateOnly- 'Semantica.Extensions.DateTimeOffsetExtensions.IsSameMonth(System.DateTimeOffset,System.DateOnly)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateTime- 'Semantica.Extensions.DateTimeOffsetExtensions.IsSameMonth(System.DateTimeOffset,System.DateTime)')
  - [IsSameMonth(left,right)](#M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.IsSameMonth(System.DateTimeOffset,System.DateTimeOffset)')
  - [ToDateOnly(dateTime)](#M-Semantica-Extensions-DateTimeOffsetExtensions-ToDateOnly-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.ToDateOnly(System.DateTimeOffset)')
  - [ToDateOnly()](#M-Semantica-Extensions-DateTimeOffsetExtensions-ToDateOnly-System-Nullable{System-DateTimeOffset}- 'Semantica.Extensions.DateTimeOffsetExtensions.ToDateOnly(System.Nullable{System.DateTimeOffset})')
  - [ToTimeOnly(dateTime)](#M-Semantica-Extensions-DateTimeOffsetExtensions-ToTimeOnly-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.ToTimeOnly(System.DateTimeOffset)')
  - [ToTimeOnly()](#M-Semantica-Extensions-DateTimeOffsetExtensions-ToTimeOnly-System-Nullable{System-DateTimeOffset}- 'Semantica.Extensions.DateTimeOffsetExtensions.ToTimeOnly(System.Nullable{System.DateTimeOffset})')
- [DecimalExtensions](#T-Semantica-Extensions-DecimalExtensions 'Semantica.Extensions.DecimalExtensions')
  - [IntegerAbove(value)](#M-Semantica-Extensions-DecimalExtensions-IntegerAbove-System-Decimal- 'Semantica.Extensions.DecimalExtensions.IntegerAbove(System.Decimal)')
  - [IntegerBelow(value)](#M-Semantica-Extensions-DecimalExtensions-IntegerBelow-System-Decimal- 'Semantica.Extensions.DecimalExtensions.IntegerBelow(System.Decimal)')
- [DictionaryExtensions](#T-Semantica-Extensions-DictionaryExtensions 'Semantica.Extensions.DictionaryExtensions')
  - [GetValueOrNull\`\`2(dict,key)](#M-Semantica-Extensions-DictionaryExtensions-GetValueOrNull``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1},``0- 'Semantica.Extensions.DictionaryExtensions.GetValueOrNull``2(System.Collections.Generic.IReadOnlyDictionary{``0,``1},``0)')
- [DoubleExtensions](#T-Semantica-Extensions-DoubleExtensions 'Semantica.Extensions.DoubleExtensions')
  - [IntegerAbove(value)](#M-Semantica-Extensions-DoubleExtensions-IntegerAbove-System-Double- 'Semantica.Extensions.DoubleExtensions.IntegerAbove(System.Double)')
  - [IntegerBelow(value)](#M-Semantica-Extensions-DoubleExtensions-IntegerBelow-System-Double- 'Semantica.Extensions.DoubleExtensions.IntegerBelow(System.Double)')
- [EnumExtensions](#T-Semantica-Extensions-EnumExtensions 'Semantica.Extensions.EnumExtensions')
  - [EnumerateFlagValues\`\`1(flags)](#M-Semantica-Extensions-EnumExtensions-EnumerateFlagValues``1-``0- 'Semantica.Extensions.EnumExtensions.EnumerateFlagValues``1(``0)')
  - [IsNullOrDefault\`\`1(values)](#M-Semantica-Extensions-EnumExtensions-IsNullOrDefault``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Extensions.EnumExtensions.IsNullOrDefault``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [IsNullOrDefault\`\`1(values)](#M-Semantica-Extensions-EnumExtensions-IsNullOrDefault``1-System-Collections-Generic-IReadOnlyList{System-Nullable{``0}}- 'Semantica.Extensions.EnumExtensions.IsNullOrDefault``1(System.Collections.Generic.IReadOnlyList{System.Nullable{``0}})')
- [ExpressionExtensions](#T-Semantica-Extensions-ExpressionExtensions 'Semantica.Extensions.ExpressionExtensions')
  - [GetAttribute\`\`3(expression)](#M-Semantica-Extensions-ExpressionExtensions-GetAttribute``3-System-Linq-Expressions-Expression{System-Func{``0,``1}}- 'Semantica.Extensions.ExpressionExtensions.GetAttribute``3(System.Linq.Expressions.Expression{System.Func{``0,``1}})')
  - [GetPropertyInfo\`\`2(expression)](#M-Semantica-Extensions-ExpressionExtensions-GetPropertyInfo``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}- 'Semantica.Extensions.ExpressionExtensions.GetPropertyInfo``2(System.Linq.Expressions.Expression{System.Func{``0,``1}})')
  - [GetPropertyName\`\`2(expression)](#M-Semantica-Extensions-ExpressionExtensions-GetPropertyName``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}- 'Semantica.Extensions.ExpressionExtensions.GetPropertyName``2(System.Linq.Expressions.Expression{System.Func{``0,``1}})')
- [Extensions](#T-Semantica-Extensions-Extensions 'Semantica.Extensions.Extensions')
  - [AsNullable\`\`1(value)](#M-Semantica-Extensions-Extensions-AsNullable``1-``0- 'Semantica.Extensions.Extensions.AsNullable``1(``0)')
  - [IsDefault\`\`1(value)](#M-Semantica-Extensions-Extensions-IsDefault``1-``0- 'Semantica.Extensions.Extensions.IsDefault``1(``0)')
  - [IsNotDefault\`\`1(value)](#M-Semantica-Extensions-Extensions-IsNotDefault``1-``0- 'Semantica.Extensions.Extensions.IsNotDefault``1(``0)')
  - [IsNullOrDefault\`\`1(value)](#M-Semantica-Extensions-Extensions-IsNullOrDefault``1-``0- 'Semantica.Extensions.Extensions.IsNullOrDefault``1(``0)')
  - [TryValue\`\`1(nullableValue,value)](#M-Semantica-Extensions-Extensions-TryValue``1-System-Nullable{``0},``0@- 'Semantica.Extensions.Extensions.TryValue``1(System.Nullable{``0},``0@)')
- [ExtensionsX](#T-Semantica-Extensions-ExtensionsX 'Semantica.Extensions.ExtensionsX')
- [GuidExtensions](#T-Semantica-Extensions-GuidExtensions 'Semantica.Extensions.GuidExtensions')
  - [IsEmpty(guid)](#M-Semantica-Extensions-GuidExtensions-IsEmpty-System-Guid- 'Semantica.Extensions.GuidExtensions.IsEmpty(System.Guid)')
  - [NullOnEmpty(guid)](#M-Semantica-Extensions-GuidExtensions-NullOnEmpty-System-Guid- 'Semantica.Extensions.GuidExtensions.NullOnEmpty(System.Guid)')
- [HashSetExtensions](#T-Semantica-Extensions-HashSetExtensions 'Semantica.Extensions.HashSetExtensions')
  - [AddRange\`\`1(set,itemsEnumerable)](#M-Semantica-Extensions-HashSetExtensions-AddRange``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0}- 'Semantica.Extensions.HashSetExtensions.AddRange``1(System.Collections.Generic.HashSet{``0},System.Collections.Generic.IEnumerable{``0})')
  - [AddRange\`\`1(set,itemsEnumerable,duplicates)](#M-Semantica-Extensions-HashSetExtensions-AddRange``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-ICollection{``0}- 'Semantica.Extensions.HashSetExtensions.AddRange``1(System.Collections.Generic.HashSet{``0},System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.ICollection{``0})')
  - [Intersect\`\`1()](#M-Semantica-Extensions-HashSetExtensions-Intersect``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0}- 'Semantica.Extensions.HashSetExtensions.Intersect``1(System.Collections.Generic.HashSet{``0},System.Collections.Generic.IEnumerable{``0})')
  - [ToArrayOrNull\`\`1(collection)](#M-Semantica-Extensions-HashSetExtensions-ToArrayOrNull``1-System-Collections-Generic-HashSet{``0}- 'Semantica.Extensions.HashSetExtensions.ToArrayOrNull``1(System.Collections.Generic.HashSet{``0})')
  - [ToArray\`\`1(collection)](#M-Semantica-Extensions-HashSetExtensions-ToArray``1-System-Collections-Generic-HashSet{``0}- 'Semantica.Extensions.HashSetExtensions.ToArray``1(System.Collections.Generic.HashSet{``0})')
  - [ToReadOnlyListOrNull\`\`1(collection)](#M-Semantica-Extensions-HashSetExtensions-ToReadOnlyListOrNull``1-System-Collections-Generic-HashSet{``0}- 'Semantica.Extensions.HashSetExtensions.ToReadOnlyListOrNull``1(System.Collections.Generic.HashSet{``0})')
  - [ToReadOnlyList\`\`1(collection)](#M-Semantica-Extensions-HashSetExtensions-ToReadOnlyList``1-System-Collections-Generic-HashSet{``0}- 'Semantica.Extensions.HashSetExtensions.ToReadOnlyList``1(System.Collections.Generic.HashSet{``0})')
- [IntExtensions](#T-Semantica-Extensions-IntExtensions 'Semantica.Extensions.IntExtensions')
  - [DivideRoundingUp(divident,divisor)](#M-Semantica-Extensions-IntExtensions-DivideRoundingUp-System-Int32,System-Int32- 'Semantica.Extensions.IntExtensions.DivideRoundingUp(System.Int32,System.Int32)')
  - [IsPowerOfTwo(value)](#M-Semantica-Extensions-IntExtensions-IsPowerOfTwo-System-Int32- 'Semantica.Extensions.IntExtensions.IsPowerOfTwo(System.Int32)')
  - [Modulo(numerator,denominator)](#M-Semantica-Extensions-IntExtensions-Modulo-System-Int32,System-Int32- 'Semantica.Extensions.IntExtensions.Modulo(System.Int32,System.Int32)')
- [ListExtensions](#T-Semantica-Extensions-ListExtensions 'Semantica.Extensions.ListExtensions')
  - [AddIfNotNull\`\`1(list,item)](#M-Semantica-Extensions-ListExtensions-AddIfNotNull``1-System-Collections-Generic-List{``0},``0- 'Semantica.Extensions.ListExtensions.AddIfNotNull``1(System.Collections.Generic.List{``0},``0)')
  - [AddIfNotNull\`\`1(list,item)](#M-Semantica-Extensions-ListExtensions-AddIfNotNull``1-System-Collections-Generic-List{``0},System-Nullable{``0}- 'Semantica.Extensions.ListExtensions.AddIfNotNull``1(System.Collections.Generic.List{``0},System.Nullable{``0})')
  - [AddRange\`\`1(list,enumerable)](#M-Semantica-Extensions-ListExtensions-AddRange``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IEnumerable{``0}- 'Semantica.Extensions.ListExtensions.AddRange``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IEnumerable{``0})')
- [MethodInfoExtensions](#T-Semantica-Extensions-MethodInfoExtensions 'Semantica.Extensions.MethodInfoExtensions')
  - [CreateDelegate\`\`1(method)](#M-Semantica-Extensions-MethodInfoExtensions-CreateDelegate``1-System-Reflection-MethodInfo- 'Semantica.Extensions.MethodInfoExtensions.CreateDelegate``1(System.Reflection.MethodInfo)')
- [PropertyInfoExtensions](#T-Semantica-Extensions-PropertyInfoExtensions 'Semantica.Extensions.PropertyInfoExtensions')
  - [HasAttribute\`\`1(propertyInfo)](#M-Semantica-Extensions-PropertyInfoExtensions-HasAttribute``1-System-Reflection-PropertyInfo- 'Semantica.Extensions.PropertyInfoExtensions.HasAttribute``1(System.Reflection.PropertyInfo)')
- [StringBuilderExtensions](#T-Semantica-Extensions-StringBuilderExtensions 'Semantica.Extensions.StringBuilderExtensions')
  - [ToStringNoNewLine(stringBuilder)](#M-Semantica-Extensions-StringBuilderExtensions-ToStringNoNewLine-System-Text-StringBuilder- 'Semantica.Extensions.StringBuilderExtensions.ToStringNoNewLine(System.Text.StringBuilder)')
- [StringExtensions](#T-Semantica-Extensions-StringExtensions 'Semantica.Extensions.StringExtensions')
  - [Capitalize(str)](#M-Semantica-Extensions-StringExtensions-Capitalize-System-String- 'Semantica.Extensions.StringExtensions.Capitalize(System.String)')
  - [Capitalize(str)](#M-Semantica-Extensions-StringExtensions-Capitalize-System-ReadOnlySpan{System-Char}- 'Semantica.Extensions.StringExtensions.Capitalize(System.ReadOnlySpan{System.Char})')
  - [ConditionalTrim(str,trim)](#M-Semantica-Extensions-StringExtensions-ConditionalTrim-System-String,System-Boolean- 'Semantica.Extensions.StringExtensions.ConditionalTrim(System.String,System.Boolean)')
  - [ConditionalTrim(str,trim)](#M-Semantica-Extensions-StringExtensions-ConditionalTrim-System-ReadOnlySpan{System-Char},System-Boolean- 'Semantica.Extensions.StringExtensions.ConditionalTrim(System.ReadOnlySpan{System.Char},System.Boolean)')
  - [Contains(stringToSearch,stringToFind,compareOptions)](#M-Semantica-Extensions-StringExtensions-Contains-System-String,System-ReadOnlySpan{System-Char},System-Globalization-CompareOptions- 'Semantica.Extensions.StringExtensions.Contains(System.String,System.ReadOnlySpan{System.Char},System.Globalization.CompareOptions)')
  - [Contains(stringToSearch,stringToFind,compareOptions)](#M-Semantica-Extensions-StringExtensions-Contains-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Globalization-CompareOptions- 'Semantica.Extensions.StringExtensions.Contains(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.Globalization.CompareOptions)')
  - [Decapitalize(str)](#M-Semantica-Extensions-StringExtensions-Decapitalize-System-String- 'Semantica.Extensions.StringExtensions.Decapitalize(System.String)')
  - [Decapitalize(str)](#M-Semantica-Extensions-StringExtensions-Decapitalize-System-ReadOnlySpan{System-Char}- 'Semantica.Extensions.StringExtensions.Decapitalize(System.ReadOnlySpan{System.Char})')
  - [EmptyOnNull(str,trim)](#M-Semantica-Extensions-StringExtensions-EmptyOnNull-System-String,System-Boolean- 'Semantica.Extensions.StringExtensions.EmptyOnNull(System.String,System.Boolean)')
  - [EnumerateToString(enumerable)](#M-Semantica-Extensions-StringExtensions-EnumerateToString-System-Collections-Generic-IEnumerable{System-Char}- 'Semantica.Extensions.StringExtensions.EnumerateToString(System.Collections.Generic.IEnumerable{System.Char})')
  - [NullOnEmpty(str,trim)](#M-Semantica-Extensions-StringExtensions-NullOnEmpty-System-String,System-Boolean- 'Semantica.Extensions.StringExtensions.NullOnEmpty(System.String,System.Boolean)')
  - [RegexReplace(input,regex,replacement)](#M-Semantica-Extensions-StringExtensions-RegexReplace-System-String,System-Text-RegularExpressions-Regex,System-String- 'Semantica.Extensions.StringExtensions.RegexReplace(System.String,System.Text.RegularExpressions.Regex,System.String)')
  - [RemoveSpecialCharacters(str)](#M-Semantica-Extensions-StringExtensions-RemoveSpecialCharacters-System-String- 'Semantica.Extensions.StringExtensions.RemoveSpecialCharacters(System.String)')
  - [StripIfEndsWith(str,suffix,stringComparison)](#M-Semantica-Extensions-StringExtensions-StripIfEndsWith-System-String,System-String,System-StringComparison- 'Semantica.Extensions.StringExtensions.StripIfEndsWith(System.String,System.String,System.StringComparison)')
  - [TakeMax(str,maxLength)](#M-Semantica-Extensions-StringExtensions-TakeMax-System-String,System-Int32- 'Semantica.Extensions.StringExtensions.TakeMax(System.String,System.Int32)')
  - [ToInt(digits)](#M-Semantica-Extensions-StringExtensions-ToInt-System-Collections-Generic-IEnumerable{System-Char}- 'Semantica.Extensions.StringExtensions.ToInt(System.Collections.Generic.IEnumerable{System.Char})')
  - [ToKebabCase(str)](#M-Semantica-Extensions-StringExtensions-ToKebabCase-System-String- 'Semantica.Extensions.StringExtensions.ToKebabCase(System.String)')
  - [ToKebabCase(str,style)](#M-Semantica-Extensions-StringExtensions-ToKebabCase-System-String,Semantica-Extensions-Flags-CasingStyle- 'Semantica.Extensions.StringExtensions.ToKebabCase(System.String,Semantica.Extensions.Flags.CasingStyle)')
  - [ToSnakeCase(str)](#M-Semantica-Extensions-StringExtensions-ToSnakeCase-System-String- 'Semantica.Extensions.StringExtensions.ToSnakeCase(System.String)')
  - [ToSnakeCase(str,style)](#M-Semantica-Extensions-StringExtensions-ToSnakeCase-System-String,Semantica-Extensions-Flags-CasingStyle- 'Semantica.Extensions.StringExtensions.ToSnakeCase(System.String,Semantica.Extensions.Flags.CasingStyle)')
  - [TransformPascalCase(chars,separator,style)](#M-Semantica-Extensions-StringExtensions-TransformPascalCase-System-Collections-Generic-IEnumerable{System-Char},System-Char,Semantica-Extensions-Flags-CasingStyle- 'Semantica.Extensions.StringExtensions.TransformPascalCase(System.Collections.Generic.IEnumerable{System.Char},System.Char,Semantica.Extensions.Flags.CasingStyle)')
  - [TrimTo(str,maxLength)](#M-Semantica-Extensions-StringExtensions-TrimTo-System-String,System-Int32- 'Semantica.Extensions.StringExtensions.TrimTo(System.String,System.Int32)')
  - [Truncate(str,maxLength,elipsis)](#M-Semantica-Extensions-StringExtensions-Truncate-System-String,System-Int32,System-String- 'Semantica.Extensions.StringExtensions.Truncate(System.String,System.Int32,System.String)')
  - [TryIndexOf(str,chr,index)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-Char,System-Int32@- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.String,System.Char,System.Int32@)')
  - [TryIndexOf(str,chr,index)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-Char,System-Int32@- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.ReadOnlySpan{System.Char},System.Char,System.Int32@)')
  - [TryIndexOf(str,chr,startIndex,index)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-Char,System-Int32,System-Int32@- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.String,System.Char,System.Int32,System.Int32@)')
  - [TryIndexOf(str,value,index,comparisonType)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-String,System-Int32@,System-StringComparison- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.String,System.String,System.Int32@,System.StringComparison)')
  - [TryIndexOf(str,value,index,comparisonType)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Int32@,System-StringComparison- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.Int32@,System.StringComparison)')
  - [TryIndexOf(str,value,startIndex,index,comparisonType)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-String,System-Int32,System-Int32@,System-StringComparison- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.String,System.String,System.Int32,System.Int32@,System.StringComparison)')
  - [TryIndexOf(str,value,startIndex,index,comparisonType)](#M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Int32,System-Int32@,System-StringComparison- 'Semantica.Extensions.StringExtensions.TryIndexOf(System.ReadOnlySpan{System.Char},System.ReadOnlySpan{System.Char},System.Int32,System.Int32@,System.StringComparison)')
  - [TrySplit(str,separator,expectedParts,parts)](#M-Semantica-Extensions-StringExtensions-TrySplit-System-String,System-Char,System-Int32,System-String[]@- 'Semantica.Extensions.StringExtensions.TrySplit(System.String,System.Char,System.Int32,System.String[]@)')
  - [WithLeadingSpace(str)](#M-Semantica-Extensions-StringExtensions-WithLeadingSpace-System-String- 'Semantica.Extensions.StringExtensions.WithLeadingSpace(System.String)')
  - [WithSpace(str)](#M-Semantica-Extensions-StringExtensions-WithSpace-System-String- 'Semantica.Extensions.StringExtensions.WithSpace(System.String)')
- [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer')
  - [#ctor(Input,Separator,RestIndex,StringComparison)](#M-Semantica-Extensions-Tokenizer-StringTokenizer-#ctor-System-String,System-String,System-Int32,System-StringComparison- 'Semantica.Extensions.Tokenizer.StringTokenizer.#ctor(System.String,System.String,System.Int32,System.StringComparison)')
  - [Input](#P-Semantica-Extensions-Tokenizer-StringTokenizer-Input 'Semantica.Extensions.Tokenizer.StringTokenizer.Input')
  - [RestIndex](#P-Semantica-Extensions-Tokenizer-StringTokenizer-RestIndex 'Semantica.Extensions.Tokenizer.StringTokenizer.RestIndex')
  - [Separator](#P-Semantica-Extensions-Tokenizer-StringTokenizer-Separator 'Semantica.Extensions.Tokenizer.StringTokenizer.Separator')
  - [StringComparison](#P-Semantica-Extensions-Tokenizer-StringTokenizer-StringComparison 'Semantica.Extensions.Tokenizer.StringTokenizer.StringComparison')
- [TimeSpanExtensions](#T-Semantica-Extensions-TimeSpanExtensions 'Semantica.Extensions.TimeSpanExtensions')
  - [FloorToDays(timespan)](#M-Semantica-Extensions-TimeSpanExtensions-FloorToDays-System-TimeSpan- 'Semantica.Extensions.TimeSpanExtensions.FloorToDays(System.TimeSpan)')
  - [FloorToHours(timespan)](#M-Semantica-Extensions-TimeSpanExtensions-FloorToHours-System-TimeSpan- 'Semantica.Extensions.TimeSpanExtensions.FloorToHours(System.TimeSpan)')
  - [FloorToMilliseconds(timespan)](#M-Semantica-Extensions-TimeSpanExtensions-FloorToMilliseconds-System-TimeSpan- 'Semantica.Extensions.TimeSpanExtensions.FloorToMilliseconds(System.TimeSpan)')
  - [FloorToMinutes(timespan)](#M-Semantica-Extensions-TimeSpanExtensions-FloorToMinutes-System-TimeSpan- 'Semantica.Extensions.TimeSpanExtensions.FloorToMinutes(System.TimeSpan)')
  - [FloorToSeconds(timespan)](#M-Semantica-Extensions-TimeSpanExtensions-FloorToSeconds-System-TimeSpan- 'Semantica.Extensions.TimeSpanExtensions.FloorToSeconds(System.TimeSpan)')
- [TokenizeExtensions](#T-Semantica-Extensions-TokenizeExtensions 'Semantica.Extensions.TokenizeExtensions')
  - [Next(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Next(Semantica.Extensions.Tokenizer.CharTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [Next(tokenizer,separator,token)](#M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-CharTokenizer,System-Char,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Next(Semantica.Extensions.Tokenizer.CharTokenizer,System.Char,System.ReadOnlySpan{System.Char}@)')
  - [Next(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Next(Semantica.Extensions.Tokenizer.StringTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [Next(tokenizer,separator,token)](#M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-StringTokenizer,System-String,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Next(Semantica.Extensions.Tokenizer.StringTokenizer,System.String,System.ReadOnlySpan{System.Char}@)')
  - [NextOptional(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.NextOptional(Semantica.Extensions.Tokenizer.CharTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [NextOptional(tokenizer,separator,token)](#M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-CharTokenizer,System-Char,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.NextOptional(Semantica.Extensions.Tokenizer.CharTokenizer,System.Char,System.ReadOnlySpan{System.Char}@)')
  - [NextOptional(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.NextOptional(Semantica.Extensions.Tokenizer.StringTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [NextOptional(tokenizer,separator,token)](#M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-StringTokenizer,System-String,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.NextOptional(Semantica.Extensions.Tokenizer.StringTokenizer,System.String,System.ReadOnlySpan{System.Char}@)')
  - [Rest(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-Rest-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Rest(Semantica.Extensions.Tokenizer.CharTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [Rest(tokenizer,token)](#M-Semantica-Extensions-TokenizeExtensions-Rest-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Rest(Semantica.Extensions.Tokenizer.StringTokenizer,System.ReadOnlySpan{System.Char}@)')
  - [Tokenize(input,separator,token)](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-Char,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.Char,System.ReadOnlySpan{System.Char}@)')
  - [Tokenize(input,separator,token,stringComparison)](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-String,System-ReadOnlySpan{System-Char}@,System-StringComparison- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.String,System.ReadOnlySpan{System.Char}@,System.StringComparison)')
  - [Try(tokenizer)](#M-Semantica-Extensions-TokenizeExtensions-Try-Semantica-Extensions-Tokenizer-CharTokenizer- 'Semantica.Extensions.TokenizeExtensions.Try(Semantica.Extensions.Tokenizer.CharTokenizer)')
  - [Try(tokenizer)](#M-Semantica-Extensions-TokenizeExtensions-Try-Semantica-Extensions-Tokenizer-StringTokenizer- 'Semantica.Extensions.TokenizeExtensions.Try(Semantica.Extensions.Tokenizer.StringTokenizer)')
- [UriExtensions](#T-Semantica-Extensions-UriExtensions 'Semantica.Extensions.UriExtensions')
  - [Combine(uri,path)](#M-Semantica-Extensions-UriExtensions-Combine-System-Uri,System-String- 'Semantica.Extensions.UriExtensions.Combine(System.Uri,System.String)')

<a name='T-Semantica-Extensions-ArrayExtensions'></a>
## ArrayExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional methods for arrays.

<a name='T-Semantica-Extensions-AttributeExtensions'></a>
## AttributeExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional methods for retrieving custom attributes.

<a name='M-Semantica-Extensions-AttributeExtensions-GetAttribute``2-``1-'></a>
### GetAttribute\`\`2(enum) `method`

##### Summary

Returns the first custom attribute applied to the enum value.

##### Returns

The first custom attribute of the specified type that is applied to
`enum`, or `null` if none match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enum | [\`\`1](#T-``1 '``1') | The enum value whose custom attributes to find. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAttribute | The type of the custom attribute to return. |
| TEnum | The type of the enum value whose custom attributes to find. |

<a name='M-Semantica-Extensions-AttributeExtensions-GetAttribute``2-``1,System-Collections-Generic-IEnumerable{System-Reflection-FieldInfo}-'></a>
### GetAttribute\`\`2(enum,enumFieldInfos) `method`

##### Summary

Returns the first custom attribute applied to the enum value.

##### Returns

The first custom attribute of the specified type that is applied to
`enum`, or `null` if none match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enum | [\`\`1](#T-``1 '``1') | The enum value whose custom attributes to find. |
| enumFieldInfos | [System.Collections.Generic.IEnumerable{System.Reflection.FieldInfo}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Reflection.FieldInfo}') | A collection of fields representing the values in the enum. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAttribute | The type of the custom attribute to retrieve. |
| TEnum | The type of enum. |

<a name='M-Semantica-Extensions-AttributeExtensions-HasAttribute``2-``1-'></a>
### HasAttribute\`\`2(enum) `method`

##### Summary

Determines whether the enum value has any custom attributes applied to it.

##### Returns

`true` if `enum` has a `TAttribute` applied to it; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enum | [\`\`1](#T-``1 '``1') | The enum value whose custom attributes to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAttribute | The type of the custom attribute to check. |
| TEnum | The type of enum. |

<a name='T-Semantica-Extensions-AveragingExtensions'></a>
## AveragingExtensions `type`

##### Namespace

Semantica.Extensions

<a name='M-Semantica-Extensions-AveragingExtensions-Median``1-System-Collections-Generic-IList{``0}-'></a>
### Median\`\`1() `method`

##### Summary

Note: specified list would be mutated in the process.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Extensions-AveragingExtensions-NthOrderStatistic``1-System-Collections-Generic-IList{``0},System-Int32,System-Random-'></a>
### NthOrderStatistic\`\`1() `method`

##### Summary

Returns Nth smallest element from the list. Here n starts from 0 so that n=0 returns minimum, n=1 returns 2nd smallest element etc.
Note: specified list would be mutated in the process.
Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 216

##### Parameters

This method has no parameters.

<a name='M-Semantica-Extensions-AveragingExtensions-Partition``1-System-Collections-Generic-IList{``0},System-Int32,System-Int32,System-Random-'></a>
### Partition\`\`1() `method`

##### Summary

Partitions the given list around a pivot element such that all elements on left of pivot are <= pivot
and the ones at thr right are > pivot. This method can be used for sorting, N-order statistics such as
as median finding algorithms.
Pivot is selected randomly if random number generator is supplied else its selected as last element in the list.
Reference: Introduction to Algorithms 3rd Edition, Corman et al, pp 171

##### Parameters

This method has no parameters.

<a name='T-Semantica-Extensions-BooleanExtensions'></a>
## BooleanExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for Boolean values.

<a name='M-Semantica-Extensions-BooleanExtensions-IsExplicitFalse-System-Nullable{System-Boolean}-'></a>
### IsExplicitFalse(nullableBln) `method`

##### Summary

Determines whether the Boolean value is `false` but not
`null`.

##### Returns

`true` if the Boolean value is `false`;
if the Boolean value is `true` or `null`, returns `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nullableBln | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | The nullable Boolean value to check. |

<a name='T-Semantica-Extensions-Flags-CasingStyle'></a>
## CasingStyle `type`

##### Namespace

Semantica.Extensions.Flags

##### Summary

Used to control conversion of PascalCase identifiers.

<a name='F-Semantica-Extensions-Flags-CasingStyle-PreserveCasing'></a>
### PreserveCasing `constants`

##### Summary

When set, all current casing is preserved, and the conversion will only add characters at word boundaries.

<a name='F-Semantica-Extensions-Flags-CasingStyle-PreserveUnderscores'></a>
### PreserveUnderscores `constants`

##### Summary

When set, the transformation will keep all existing underscores.

<a name='F-Semantica-Extensions-Flags-CasingStyle-ToUpperCase'></a>
### ToUpperCase `constants`

##### Summary

When set (and [PreserveCasing](#F-Semantica-Extensions-Flags-CasingStyle-PreserveCasing 'Semantica.Extensions.Flags.CasingStyle.PreserveCasing') is not set), all characters are converted to uppercase instead of lowercase.

<a name='F-Semantica-Extensions-Flags-CasingStyle-UnderscoresAsBoundaries'></a>
### UnderscoresAsBoundaries `constants`

##### Summary

When set, the transformation will treat an underscore the same as a word boundary.

##### Remarks

The transformation detects a word boundary when it encounters an uppercase character, and the preceding character is
lowercase.

<a name='T-Semantica-Extensions-Tokenizer-CharTokenizer'></a>
## CharTokenizer `type`

##### Namespace

Semantica.Extensions.Tokenizer

##### Summary

Struct that contains the intermediate result of a
[Tokenize](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-Char,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.Char,System.ReadOnlySpan{System.Char}@)') call, on which the fluentAPI-like
extensions are based.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Input | [T:Semantica.Extensions.Tokenizer.CharTokenizer](#T-T-Semantica-Extensions-Tokenizer-CharTokenizer 'T:Semantica.Extensions.Tokenizer.CharTokenizer') | String that's being tokenized. |

<a name='M-Semantica-Extensions-Tokenizer-CharTokenizer-#ctor-System-String,System-Char,System-Int32-'></a>
### #ctor(Input,Separator,RestIndex) `constructor`

##### Summary

Struct that contains the intermediate result of a
[Tokenize](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-Char,System-ReadOnlySpan{System-Char}@- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.Char,System.ReadOnlySpan{System.Char}@)') call, on which the fluentAPI-like
extensions are based.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String that's being tokenized. |
| Separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | Separator char that was previously searched for. |
| RestIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Index of the character in `Input` directly after the previously found separator. A value of 0 means that
a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped. |

<a name='P-Semantica-Extensions-Tokenizer-CharTokenizer-Input'></a>
### Input `property`

##### Summary

String that's being tokenized.

<a name='P-Semantica-Extensions-Tokenizer-CharTokenizer-RestIndex'></a>
### RestIndex `property`

##### Summary

Index of the character in `Input` directly after the previously found separator. A value of 0 means that
a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped.

<a name='P-Semantica-Extensions-Tokenizer-CharTokenizer-Separator'></a>
### Separator `property`

##### Summary

Separator char that was previously searched for.

<a name='T-Semantica-Extensions-ComparableExtensions'></a>
## ComparableExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for types implementing [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable').

<a name='M-Semantica-Extensions-ComparableExtensions-MaxByOrNull``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}-'></a>
### MaxByOrNull\`\`2(enumerable,valueFunc) `method`

##### Summary

Finds the maximum value in an enumeration of values and returns it.
Returns null if the enumeration was empty.

##### Returns

null if enumerable is empty, otherwise the max value of the enumerable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumerable of type `T` |
| valueFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A projection function used to select the value to compare and return. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Has to be struct and [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') |
| TOut | The type of value selected by `valueFunc`. |

<a name='M-Semantica-Extensions-ComparableExtensions-MaxBy``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``1,System-Boolean},System-Func{``0,``2}-'></a>
### MaxBy\`\`3(enumerable,selector,predicate,tiebreaker) `method`

##### Summary

Returns the maximum value in a collection according to the specified
selector function and predicate, using a tiebreaker function for values
that would otherwise be considered equal.

##### Returns

The maximum value in `enumerable` according to the
specified `selector`, `predicate` and
`tiebreaker` functions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection whose maximum to determine. |
| selector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function that selects the value used in comparisons. |
| predicate | [System.Func{\`\`1,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,System.Boolean}') | A function that determines which values are included in comparisons. |
| tiebreaker | [System.Func{\`\`0,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2}') | A function that selects a secondary value used in comparisons when the
`selector` function results in equal comparisons. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `enumerable` and the type of
value to return. |
| TValue | The type of values to compare elements by. |
| TValue2 | The type of values to compare by in tie breakers. |

<a name='M-Semantica-Extensions-ComparableExtensions-MaxOrNull``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### MaxOrNull\`\`1(enumerable) `method`

##### Summary

Finds the maximum value in an enumeration of values and returns it.
Returns null if the enumeration was empty.

##### Returns

null if enumerable is empty, otherwise the max value of the enumerable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumerable of type `T` |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Has to be struct and [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') |

<a name='T-Semantica-Extensions-DateOnlyExtensions'></a>
## DateOnlyExtensions `type`

##### Namespace

Semantica.Extensions

<a name='M-Semantica-Extensions-DateOnlyExtensions-FirstOfMonth-System-DateOnly-'></a>
### FirstOfMonth(date) `method`

##### Summary

Returns a new [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') representing the first day of the month and year that the input represents.
Effectively an alias to [FloorToMonth](#M-Semantica-Extensions-DateOnlyExtensions-FloorToMonth-System-DateOnly- 'Semantica.Extensions.DateOnlyExtensions.FloorToMonth(System.DateOnly)')

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value that is always the first of the month.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | The [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value to use the month and year from. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-FloorToMonth-System-DateOnly-'></a>
### FloorToMonth(date) `method`

##### Summary

Returns a new [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') representing the first day of the month and year that the input represents.

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value that is always the first of the month.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | The [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value to use the month and year from. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateOnly-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Left side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |
| right | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Right side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateTimeOffset-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Left side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |
| right | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Right side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-IsSameMonth-System-DateOnly,System-DateTime-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Left side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |
| right | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Right side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-ToDateTime-System-DateOnly-'></a>
### ToDateTime(dateOnly) `method`

##### Summary

Returns the the input as a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. The time part is set to midnight.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the same value as the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateOnly | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | The [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value to convert. |

<a name='M-Semantica-Extensions-DateOnlyExtensions-ToDateTime-System-Nullable{System-DateOnly}-'></a>
### ToDateTime() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Semantica-Extensions-DateTimeExtensions'></a>
## DateTimeExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for dates and times.

<a name='M-Semantica-Extensions-DateTimeExtensions-FirstOfMonth-System-DateTime-'></a>
### FirstOfMonth(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the first day of the
month. Effectively an alias to [FloorToMonth](#M-Semantica-Extensions-DateTimeExtensions-FloorToMonth-System-DateTime- 'Semantica.Extensions.DateTimeExtensions.FloorToMonth(System.DateTime)').

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the year and month value equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToDay-System-DateTime-'></a>
### FloorToDay(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the day.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the date value equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToHour-System-DateTime-'></a>
### FloorToHour(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the hour.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the date and hour value equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToMillisecond-System-DateTime-'></a>
### FloorToMillisecond(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the millisecond.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the date and time value down to the millisecond equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToMinute-System-DateTime-'></a>
### FloorToMinute(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the minute.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the date and time value down to the minute equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToMonth-System-DateTime-'></a>
### FloorToMonth(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the first day of the
month.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the year and month value equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-FloorToSecond-System-DateTime-'></a>
### FloorToSecond(datetime) `method`

##### Summary

Returns a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that is based on `datetime` rounded down to the second.

##### Returns

A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value with the date and time value down to the second equal to `datetime`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to floor. |

<a name='M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateOnly-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Left side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |
| right | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Right side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |

<a name='M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateTimeOffset-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Left side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |
| right | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Right side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |

<a name='M-Semantica-Extensions-DateTimeExtensions-IsSameMonth-System-DateTime,System-DateTime-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Left side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |
| right | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Right side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |

<a name='M-Semantica-Extensions-DateTimeExtensions-ToDateOnly-System-DateTime-'></a>
### ToDateOnly(dateTime) `method`

##### Summary

Returns the date part of the input as a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value.

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value with the same date value as the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to convert. |

<a name='M-Semantica-Extensions-DateTimeExtensions-ToDateOnly-System-Nullable{System-DateTime}-'></a>
### ToDateOnly() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Extensions-DateTimeExtensions-ToTimeOnly-System-DateTime-'></a>
### ToTimeOnly(dateTime) `method`

##### Summary

Returns the time part of the input as a [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') value.

##### Returns

A [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') value with the same date value as the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to convert. |

<a name='M-Semantica-Extensions-DateTimeExtensions-ToTimeOnly-System-Nullable{System-DateTime}-'></a>
### ToTimeOnly() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Semantica-Extensions-DateTimeOffsetExtensions'></a>
## DateTimeOffsetExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') instances.

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FirstOfMonth-System-DateTimeOffset-'></a>
### FirstOfMonth(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the first day of the
month. Effectively an alias to [FloorToMonth](#M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMonth-System-DateTimeOffset- 'Semantica.Extensions.DateTimeOffsetExtensions.FloorToMonth(System.DateTimeOffset)')

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the year and month value equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToDay-System-DateTimeOffset-'></a>
### FloorToDay(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the day.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the date value equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToHour-System-DateTimeOffset-'></a>
### FloorToHour(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the hour.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the date and hour value equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMillisecond-System-DateTimeOffset-'></a>
### FloorToMillisecond(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the minute.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the date and time value down to the millisecond equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMinute-System-DateTimeOffset-'></a>
### FloorToMinute(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the minute.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the date and time value down to the minute equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToMonth-System-DateTimeOffset-'></a>
### FloorToMonth(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the first day of the
month.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the year and month value equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-FloorToSecond-System-DateTimeOffset-'></a>
### FloorToSecond(datetimeOffset) `method`

##### Summary

Returns a [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value that is based on `datetimeOffset` rounded down to the second.

##### Returns

A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value with the date and time value down to the second equal to `datetimeOffset`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datetimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to floor. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateOnly-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Left side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |
| right | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Right side [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateTime-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Left side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |
| right | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Right side [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-IsSameMonth-System-DateTimeOffset,System-DateTimeOffset-'></a>
### IsSameMonth(left,right) `method`

##### Summary

Determines if the two input are within the same month and year.

##### Returns

`true` if the two compared values are within the same month and year.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Left side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |
| right | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Right side [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-ToDateOnly-System-DateTimeOffset-'></a>
### ToDateOnly(dateTime) `method`

##### Summary

Returns the date part of the input as a [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value.

##### Returns

A [DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') value with the same date value as the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to convert. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-ToDateOnly-System-Nullable{System-DateTimeOffset}-'></a>
### ToDateOnly() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-ToTimeOnly-System-DateTimeOffset-'></a>
### ToTimeOnly(dateTime) `method`

##### Summary

Returns the time part of the input as a [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') value.

##### Returns

A [TimeOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeOnly 'System.TimeOnly') value with the same date value as the input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') value to convert. |

<a name='M-Semantica-Extensions-DateTimeOffsetExtensions-ToTimeOnly-System-Nullable{System-DateTimeOffset}-'></a>
### ToTimeOnly() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Semantica-Extensions-DecimalExtensions'></a>
## DecimalExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for decimal numbers.

<a name='M-Semantica-Extensions-DecimalExtensions-IntegerAbove-System-Decimal-'></a>
### IntegerAbove(value) `method`

##### Summary

Returns the nearest integer that is greater than or equal to this
decimal number.

##### Returns

An integer whose value is greater than or equal to `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The decimal number to round up. |

<a name='M-Semantica-Extensions-DecimalExtensions-IntegerBelow-System-Decimal-'></a>
### IntegerBelow(value) `method`

##### Summary

Returns the nearest integer that is less than or equal to this
decimal number.

##### Returns

An integer whose value is less than or equal to `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The decimal number to round down. |

<a name='T-Semantica-Extensions-DictionaryExtensions'></a>
## DictionaryExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for dictionary types.

<a name='M-Semantica-Extensions-DictionaryExtensions-GetValueOrNull``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1},``0-'></a>
### GetValueOrNull\`\`2(dict,key) `method`

##### Summary

Returns the value that is associated with the specified key.

##### Returns

The value associated with the specified key, or a default value if the
dictionary does not contain the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dict | [System.Collections.Generic.IReadOnlyDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{``0,``1}') | The dictionary to search. |
| key | [\`\`0](#T-``0 '``0') | The key to find. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of keys in the dictionary. |
| TValue | The type of values in the dictionary. |

<a name='T-Semantica-Extensions-DoubleExtensions'></a>
## DoubleExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for double-precision floating-point numbers.

<a name='M-Semantica-Extensions-DoubleExtensions-IntegerAbove-System-Double-'></a>
### IntegerAbove(value) `method`

##### Summary

Returns the nearest integer that is greater than or equal to this
`double`.

##### Returns

An integer whose value is greater than or equal to `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The `double` to round up. |

<a name='M-Semantica-Extensions-DoubleExtensions-IntegerBelow-System-Double-'></a>
### IntegerBelow(value) `method`

##### Summary

Returns the nearest integer that is less than or equal to this `double`.

##### Returns

An integer whose value is less than or equal to `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The `double` to round down. |

<a name='T-Semantica-Extensions-EnumExtensions'></a>
## EnumExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for enumerations.

<a name='M-Semantica-Extensions-EnumExtensions-EnumerateFlagValues``1-``0-'></a>
### EnumerateFlagValues\`\`1(flags) `method`

##### Summary

Enumerates all defined value members of TEnum that are present in `flags`. Note
that if the enum has an explicit entry for `0`, that value is _always_ returned, since flags.HasFlag(0) is always
true.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the flags which are set on `flags`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flags | [\`\`0](#T-``0 '``0') | The value whose flags to enumerate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnum | Type of enum with [FlagsAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FlagsAttribute 'System.FlagsAttribute'). |

<a name='M-Semantica-Extensions-EnumExtensions-IsNullOrDefault``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### IsNullOrDefault\`\`1(values) `method`

##### Summary

Determines whether the list is `null`, empty or contains only the default value.

##### Returns

`true` if `values` is `null`, empty or contains only the default value
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list of values to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of enum in `values`. |

##### Example

The ASP.MVC modelbinder wil set the value of a property `MyEnum[] EnumProp {get;set;}` to an array with one
element of value `default(MyEnum)` when the request has `EnumProp=` in the querystring.

<a name='M-Semantica-Extensions-EnumExtensions-IsNullOrDefault``1-System-Collections-Generic-IReadOnlyList{System-Nullable{``0}}-'></a>
### IsNullOrDefault\`\`1(values) `method`

##### Summary

Determines whether the list is `null`, empty or contains only the default value.

##### Returns

`true` if `values` is `null`, empty or contains only the default value
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IReadOnlyList{System.Nullable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{System.Nullable{``0}}') | The list of values to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of enum in `values`. |

##### Example

The ASP.MVC modelbinder wil set the value of a property `MyEnum[] EnumProp {get;set;}` to an array with one
element of value `default(MyEnum)` when the request has `EnumProp=` in the querystring.

<a name='T-Semantica-Extensions-ExpressionExtensions'></a>
## ExpressionExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for lambda expressions.

<a name='M-Semantica-Extensions-ExpressionExtensions-GetAttribute``3-System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>
### GetAttribute\`\`3(expression) `method`

##### Summary

Returns the first custom attribute applied to the field or property
being accessed in the lambda expression.

##### Returns

A `TAttribute` that represents the first custom
attribute applied to the member accessed in `expression`, or `null` if it has no custom
attributes of the specified type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1}}') | The expression to inspect. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of source element in the expression. |
| TOut | The type of field or property in the expression. |
| TAttribute | The type of custom attribute to find. |

<a name='M-Semantica-Extensions-ExpressionExtensions-GetPropertyInfo``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>
### GetPropertyInfo\`\`2(expression) `method`

##### Summary

Returns the property that is accessed in the lambda expression.

##### Returns

A [PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') that represents the property being accessed
in `expression`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1}}') | The expression to inspect. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of source element in the expression. |
| TTarget | The type of property accessed in the expression. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `expression` does not represent a property being accessed. |

<a name='M-Semantica-Extensions-ExpressionExtensions-GetPropertyName``2-System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>
### GetPropertyName\`\`2(expression) `method`

##### Summary

Returns the name of the property that is accessed in the lambda expression.

##### Returns

The name of the property being accessed in `expression`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1}}') | The expression to inspect. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of source element in the expression. |
| TTarget | The type of property accessed in the expression. |

<a name='T-Semantica-Extensions-Extensions'></a>
## Extensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for classes/structs.

<a name='M-Semantica-Extensions-Extensions-AsNullable``1-``0-'></a>
### AsNullable\`\`1(value) `method`

##### Summary

Returns the value typed as [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') if not default. If the value is default, the nullable returned has
no value ("`null`").

##### Returns

`value`, or `null` if `value` equals
`default`(`T`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A value type. |

<a name='M-Semantica-Extensions-Extensions-IsDefault``1-``0-'></a>
### IsDefault\`\`1(value) `method`

##### Summary

Uses de default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1') to check if the struct is equal to it's default. This method should
avoid boxing, so is more efficient than using [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').[Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.Equals 'System.Object.Equals(System.Object)').

##### Returns

`true` if the `value` equals `default`(`T`);
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | `struct` value to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A value type. |

<a name='M-Semantica-Extensions-Extensions-IsNotDefault``1-``0-'></a>
### IsNotDefault\`\`1(value) `method`

##### Summary

Uses de default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1') to check if the struct is not equal to it's default. This method
should avoid boxing, so is more efficient than using [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').[Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.Equals 'System.Object.Equals(System.Object)').

##### Returns

`true` if `value` does not equal to
`default`(`T`); `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | `struct` value to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A value type. |

<a name='M-Semantica-Extensions-Extensions-IsNullOrDefault``1-``0-'></a>
### IsNullOrDefault\`\`1(value) `method`

##### Summary

Uses de default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1') to check if the value is equal to it's default or null.

##### Returns

`true` if the `value` equals `default`(`T`) if
`T` is a value type, or `null` if it's a reference type; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the value to check for null or default. |

<a name='M-Semantica-Extensions-Extensions-TryValue``1-System-Nullable{``0},``0@-'></a>
### TryValue\`\`1(nullableValue,value) `method`

##### Summary

Outputs the (non nullable) value of a nullable type instance, and returns whether that value existed or not.

##### Returns

`true` if the `nullableValue` has a value ; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nullableValue | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | A nullable value to check. |
| value | [\`\`0@](#T-``0@ '``0@') | Out parameter that will contain the input as non-nullable. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Value type. |

<a name='T-Semantica-Extensions-ExtensionsX'></a>
## ExtensionsX `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for classes/structs, that cannot be part of [Extensions](#T-Semantica-Extensions-Extensions 'Semantica.Extensions.Extensions') because of signature
overlap.

##### Remarks

The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
are on a separate class, so this weird thing has to exist.

<a name='T-Semantica-Extensions-GuidExtensions'></a>
## GuidExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for GUIDs.

<a name='M-Semantica-Extensions-GuidExtensions-IsEmpty-System-Guid-'></a>
### IsEmpty(guid) `method`

##### Summary

Determines whether the specified GUID is the empty GUID.

##### Returns

`true` if `guid` is the empty GUID;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The GUID to check. |

<a name='M-Semantica-Extensions-GuidExtensions-NullOnEmpty-System-Guid-'></a>
### NullOnEmpty(guid) `method`

##### Summary

Converts a regular [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') into a [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1'). [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') will be interpreted
as no value.

##### Returns

A [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') of [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The guid to convert. |

<a name='T-Semantica-Extensions-HashSetExtensions'></a>
## HashSetExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for [HashSet\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet`1 'System.Collections.Generic.HashSet`1') objects.

<a name='M-Semantica-Extensions-HashSetExtensions-AddRange``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### AddRange\`\`1(set,itemsEnumerable) `method`

##### Summary

Adds the specified items to the set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| set | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The set to add items to. |
| itemsEnumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The items to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of items in `set`. |

<a name='M-Semantica-Extensions-HashSetExtensions-AddRange``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-ICollection{``0}-'></a>
### AddRange\`\`1(set,itemsEnumerable,duplicates) `method`

##### Summary

Adds the specified items to the set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| set | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The set to add items to. |
| itemsEnumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The items to add. |
| duplicates | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | A collection to which duplicate items should be added. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of items in `set`. |

##### Remarks

Items that already exist in `set` are added to
`duplicates`.

<a name='M-Semantica-Extensions-HashSetExtensions-Intersect``1-System-Collections-Generic-HashSet{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### Intersect\`\`1() `method`

##### Summary

Returns elements of `other` if they are also present in
`collection`

##### Parameters

This method has no parameters.

<a name='M-Semantica-Extensions-HashSetExtensions-ToArrayOrNull``1-System-Collections-Generic-HashSet{``0}-'></a>
### ToArrayOrNull\`\`1(collection) `method`

##### Summary

Returns a new array containing the items in the set, or `null` if the set is empty.

##### Returns

A new array of `T` with the items from `collection`, or `null` if the set is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The collection whose items to copy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `collection`. |

<a name='M-Semantica-Extensions-HashSetExtensions-ToArray``1-System-Collections-Generic-HashSet{``0}-'></a>
### ToArray\`\`1(collection) `method`

##### Summary

Returns a new array containing the items in the set.

##### Returns

A new array of `T` with the items from `collection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The collection whose items to copy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `collection`. |

<a name='M-Semantica-Extensions-HashSetExtensions-ToReadOnlyListOrNull``1-System-Collections-Generic-HashSet{``0}-'></a>
### ToReadOnlyListOrNull\`\`1(collection) `method`

##### Summary

Returns a new read-only collection of elements in the set, or `null` if the set is empty.

##### Returns

A new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') with the items from `collection`, or `null` if the set is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The collection whose items to copy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `collection`. |

<a name='M-Semantica-Extensions-HashSetExtensions-ToReadOnlyList``1-System-Collections-Generic-HashSet{``0}-'></a>
### ToReadOnlyList\`\`1(collection) `method`

##### Summary

Returns a new read-only collection of elements in the set.

##### Returns

A new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') with the items from `collection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.HashSet{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.HashSet 'System.Collections.Generic.HashSet{``0}') | The collection whose items to copy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `collection`. |

<a name='T-Semantica-Extensions-IntExtensions'></a>
## IntExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for integers.

<a name='M-Semantica-Extensions-IntExtensions-DivideRoundingUp-System-Int32,System-Int32-'></a>
### DivideRoundingUp(divident,divisor) `method`

##### Summary

Divides the number by another integer and returns the result rounded
up towards the nearest integer.

##### Returns

The result of the division rounded up towards the nearest integer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| divident | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to divide. |
| divisor | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to divide by. |

<a name='M-Semantica-Extensions-IntExtensions-IsPowerOfTwo-System-Int32-'></a>
### IsPowerOfTwo(value) `method`

##### Summary

Determines whether the integer is a power of two.

##### Returns

`true` if `value` is a power of two;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The integer to check. |

<a name='M-Semantica-Extensions-IntExtensions-Modulo-System-Int32,System-Int32-'></a>
### Modulo(numerator,denominator) `method`

##### Summary

Returns the positive remainder of a division.

##### Returns

The remainder of the division. This value is made positive, even if
`numerator` is negative.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numerator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to divide. |
| denominator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to divide by. |

<a name='T-Semantica-Extensions-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for lists.

<a name='M-Semantica-Extensions-ListExtensions-AddIfNotNull``1-System-Collections-Generic-List{``0},``0-'></a>
### AddIfNotNull\`\`1(list,item) `method`

##### Summary

Adds an item to the end of the list if it is not `null`.

##### Returns

`true` if the item was added; `false` if `item` was
`null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') | The list to add to. |
| item | [\`\`0](#T-``0 '``0') | The item to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of items in `list`. |

<a name='M-Semantica-Extensions-ListExtensions-AddIfNotNull``1-System-Collections-Generic-List{``0},System-Nullable{``0}-'></a>
### AddIfNotNull\`\`1(list,item) `method`

##### Summary

Adds an item to the end of the list if it is not `null`.

##### Returns

`true` if the item was added; `false` if `item` was
`null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') | The list to add to. |
| item | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The item to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of items in `list`. |

<a name='M-Semantica-Extensions-ListExtensions-AddRange``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### AddRange\`\`1(list,enumerable) `method`

##### Summary

Adds an enumeration of items to a [IList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList`1 'System.Collections.Generic.IList`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list to add to. |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The items to add. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of items in `list`. |

<a name='T-Semantica-Extensions-MethodInfoExtensions'></a>
## MethodInfoExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for method metadata.

<a name='M-Semantica-Extensions-MethodInfoExtensions-CreateDelegate``1-System-Reflection-MethodInfo-'></a>
### CreateDelegate\`\`1(method) `method`

##### Summary

Creates a delegate of the specified type to represent the method.

##### Returns

A `T` delegate that represents `method`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.Reflection.MethodInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo 'System.Reflection.MethodInfo') | The method to represent. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of delegate to create. |

<a name='T-Semantica-Extensions-PropertyInfoExtensions'></a>
## PropertyInfoExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for property metadata.

<a name='M-Semantica-Extensions-PropertyInfoExtensions-HasAttribute``1-System-Reflection-PropertyInfo-'></a>
### HasAttribute\`\`1(propertyInfo) `method`

##### Summary

Determines whether the property contains a custom attribute of the
specified type.

##### Returns

`true` if the property contains a `TAttr` attribute; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyInfo | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') | The property metadata whose attributes to search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAttr | The type of attribute to search for. |

<a name='T-Semantica-Extensions-StringBuilderExtensions'></a>
## StringBuilderExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') objects.

<a name='M-Semantica-Extensions-StringBuilderExtensions-ToStringNoNewLine-System-Text-StringBuilder-'></a>
### ToStringNoNewLine(stringBuilder) `method`

##### Summary

Converts the value of this instance to a `string`,
ignoring the last trailing line ending, if any.

##### Returns

A string whose value is the same as the string builder, excluding the
last trailing line ending, if it has any.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringBuilder | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | The [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') whose value to convert. |

<a name='T-Semantica-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for strings.

<a name='M-Semantica-Extensions-StringExtensions-Capitalize-System-String-'></a>
### Capitalize(str) `method`

##### Summary

Returns the string with the first character converted to its uppercase equivalent using the invariant culture.

##### Returns

A new string, based on this string, with its first character converted to uppercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to capitalize. |

<a name='M-Semantica-Extensions-StringExtensions-Capitalize-System-ReadOnlySpan{System-Char}-'></a>
### Capitalize(str) `method`

##### Summary

Returns the string with the first character converted to its uppercase equivalent using the invariant culture.

##### Returns

A new string, based on this string, with its first character converted to uppercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to capitalize. |

<a name='M-Semantica-Extensions-StringExtensions-ConditionalTrim-System-String,System-Boolean-'></a>
### ConditionalTrim(str,trim) `method`

##### Summary

Trims the input string, only if the argument is `true`.

##### Returns

The trimmed input, or the plain input if `trim` is `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to conditionally trim. |
| trim | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that determines if trim is applied. |

<a name='M-Semantica-Extensions-StringExtensions-ConditionalTrim-System-ReadOnlySpan{System-Char},System-Boolean-'></a>
### ConditionalTrim(str,trim) `method`

##### Summary

Trims the input string, only if the argument is `true`.

##### Returns

The trimmed input, or the plain input if `trim` is `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to conditionally trim. |
| trim | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that determines if trim is applied. |

<a name='M-Semantica-Extensions-StringExtensions-Contains-System-String,System-ReadOnlySpan{System-Char},System-Globalization-CompareOptions-'></a>
### Contains(stringToSearch,stringToFind,compareOptions) `method`

##### Summary

Determines whether this string contains the specified string, optionally specifying additional comparison options.

##### Returns

`true` if this string contains `stringToFind`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search in. |
| stringToFind | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to find. |
| compareOptions | [System.Globalization.CompareOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CompareOptions 'System.Globalization.CompareOptions') | A value specifying how the search should be searched for. |

<a name='M-Semantica-Extensions-StringExtensions-Contains-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Globalization-CompareOptions-'></a>
### Contains(stringToSearch,stringToFind,compareOptions) `method`

##### Summary

Determines whether this string contains the specified string, optionally specifying additional comparison options.

##### Returns

`true` if this string contains `stringToFind`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringToSearch | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to search in. |
| stringToFind | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to find. |
| compareOptions | [System.Globalization.CompareOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.CompareOptions 'System.Globalization.CompareOptions') | A value specifying how the search should be searched for. |

<a name='M-Semantica-Extensions-StringExtensions-Decapitalize-System-String-'></a>
### Decapitalize(str) `method`

##### Summary

Returns the string with the first character converted to its lowercase equivalent using the invariant culture.

##### Returns

A new string, based on this string, with its first character converted to lowercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to decapitalize. |

<a name='M-Semantica-Extensions-StringExtensions-Decapitalize-System-ReadOnlySpan{System-Char}-'></a>
### Decapitalize(str) `method`

##### Summary

Returns the string with the first character converted to its lowercase equivalent using the invariant culture.

##### Returns

A new string, based on this string, with its first character converted to lowercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to decapitalize. |

<a name='M-Semantica-Extensions-StringExtensions-EmptyOnNull-System-String,System-Boolean-'></a>
### EmptyOnNull(str,trim) `method`

##### Summary

Returns this string instance, or the empty string if it is `null`, optionally removing leading and
trailing white space.

##### Returns

The string, optionally trimmed, or the empty string if it is `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to return. |
| trim | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to remove leading and trailing white space from the string. |

<a name='M-Semantica-Extensions-StringExtensions-EnumerateToString-System-Collections-Generic-IEnumerable{System-Char}-'></a>
### EnumerateToString(enumerable) `method`

##### Summary

Converts the enumeration of chars to a string.

##### Returns

A string containing all chars in `enumerable`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Char}') | An enumaration of [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char'). |

<a name='M-Semantica-Extensions-StringExtensions-NullOnEmpty-System-String,System-Boolean-'></a>
### NullOnEmpty(str,trim) `method`

##### Summary

Returns this string instance, or `null` if it is empty,
optionally removing leading and trailing white space.

##### Returns

The string, optionally trimmed, or `null` if the result
would be empty or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to return. |
| trim | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to remove leading and trailing white space from
the string. |

##### Remarks

If `trim` is `true` and the string only
consists of white-space characters, this method also returns `null`.

<a name='M-Semantica-Extensions-StringExtensions-RegexReplace-System-String,System-Text-RegularExpressions-Regex,System-String-'></a>
### RegexReplace(input,regex,replacement) `method`

##### Summary

In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement
string. Uses [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex').[Replace](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex.Replace 'System.Text.RegularExpressions.Regex.Replace(System.String,System.String)').

##### Returns

A new string that is identical to the input string, except that the replacement string takes the place of each matched
string. If the regular expression pattern is not matched in the current instance, the method returns the current
instance unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search for a match. |
| regex | [System.Text.RegularExpressions.Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex') | The regex instance to use. |
| replacement | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The replacement string. |

<a name='M-Semantica-Extensions-StringExtensions-RemoveSpecialCharacters-System-String-'></a>
### RemoveSpecialCharacters(str) `method`

##### Summary

Removes all characters other than letters or digits from the string.

##### Returns

A new string containing only the letters and digits from the string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to clean. |

<a name='M-Semantica-Extensions-StringExtensions-StripIfEndsWith-System-String,System-String,System-StringComparison-'></a>
### StripIfEndsWith(str,suffix,stringComparison) `method`

##### Summary

Returns a string that does not end with the specified string.

##### Returns

A new string with `suffix` removed from its end, or the
same string instance if it does not end with `suffix`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to return. |
| suffix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to remove from the end of `str`. |
| stringComparison | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | Determines how the string is searched. |

<a name='M-Semantica-Extensions-StringExtensions-TakeMax-System-String,System-Int32-'></a>
### TakeMax(str,maxLength) `method`

##### Summary

Returns a string whose length does not exceed the specified maximum.

##### Returns

A string whose length does not exceed `maxLength`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string whose length to limit. |
| maxLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum length of the string to return. |

<a name='M-Semantica-Extensions-StringExtensions-ToInt-System-Collections-Generic-IEnumerable{System-Char}-'></a>
### ToInt(digits) `method`

##### Summary

Converts the characters representing a number to the equivalent integer.

##### Returns

A 32-bit integer that contains the number represented by `digits`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| digits | [System.Collections.Generic.IEnumerable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Char}') | A collection of characters representing the digits to convert. |

<a name='M-Semantica-Extensions-StringExtensions-ToKebabCase-System-String-'></a>
### ToKebabCase(str) `method`

##### Summary

Transforms an input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with a Pascal-case identifier into a Kebab-case identifier. The default
[CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle') is used, which will preserve underscores.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the input converted into Kebab Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier to transform. |

<a name='M-Semantica-Extensions-StringExtensions-ToKebabCase-System-String,Semantica-Extensions-Flags-CasingStyle-'></a>
### ToKebabCase(str,style) `method`

##### Summary

Transforms an input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with a Pascal-case identifier into a Kebab-case identifier. The default
[CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle') is used, which will double up existing underscores.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the input converted into Kebab Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier to transform. |
| style | [Semantica.Extensions.Flags.CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle') | Controls the style of the transformation. |

<a name='M-Semantica-Extensions-StringExtensions-ToSnakeCase-System-String-'></a>
### ToSnakeCase(str) `method`

##### Summary

Transforms an input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with a Pascal-case identifier into a Snake-case identifier.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the input converted into Kebab Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier to transform. |

<a name='M-Semantica-Extensions-StringExtensions-ToSnakeCase-System-String,Semantica-Extensions-Flags-CasingStyle-'></a>
### ToSnakeCase(str,style) `method`

##### Summary

Transforms an input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with a Pascal-case identifier into a Snake-case identifier.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the input converted into Kebab Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The identifier to transform. |
| style | [Semantica.Extensions.Flags.CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle') | Controls the style of the transformation. |

<a name='M-Semantica-Extensions-StringExtensions-TransformPascalCase-System-Collections-Generic-IEnumerable{System-Char},System-Char,Semantica-Extensions-Flags-CasingStyle-'></a>
### TransformPascalCase(chars,separator,style) `method`

##### Summary

Transforms an input [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with a Pascal-case identifier into a Snake-case identifier.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with the input converted into Kebab Case.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chars | [System.Collections.Generic.IEnumerable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Char}') | The identifier to transform. |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The seperator character to insert on a word boundary. |
| style | [Semantica.Extensions.Flags.CasingStyle](#T-Semantica-Extensions-Flags-CasingStyle 'Semantica.Extensions.Flags.CasingStyle') | Controls the style of the transformation. |

<a name='M-Semantica-Extensions-StringExtensions-TrimTo-System-String,System-Int32-'></a>
### TrimTo(str,maxLength) `method`

##### Summary

Limits the string to the specified maximum length.

##### Returns

This string if it is under the maximum length; otherwise, the string is cut off at `maxLength`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string whose length to limit. |
| maxLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum number of characters to take from the string. |

<a name='M-Semantica-Extensions-StringExtensions-Truncate-System-String,System-Int32,System-String-'></a>
### Truncate(str,maxLength,elipsis) `method`

##### Summary

Limits the string to the specified maximum length, optionally specifying a string to append to indicate the string was
truncated.

##### Returns

This string if it is under the maximum length; otherwise, the string is cut off at `maxLength` followed
by `elipsis`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string whose length to limit. |
| maxLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum number of characters to take from the string. |
| elipsis | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to append if a string has been truncated. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-Char,System-Int32@-'></a>
### TryIndexOf(str,chr,index) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `chr`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search in. |
| chr | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to find. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `chr` in the string, or -1 if it is not
found. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-Char,System-Int32@-'></a>
### TryIndexOf(str,chr,index) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `chr`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to search in. |
| chr | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to find. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `chr` in the string, or -1 if it is not
found. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-Char,System-Int32,System-Int32@-'></a>
### TryIndexOf(str,chr,startIndex,index) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `chr`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search in. |
| chr | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to find. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The search starting position. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `chr` in the string, or -1 if it is not
found. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-String,System-Int32@,System-StringComparison-'></a>
### TryIndexOf(str,value,index,comparisonType) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `value`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search in. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The character to find. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `value` in the string, or -1 if it is not
found. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the enumeration values that specifies the rules of the search. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Int32@,System-StringComparison-'></a>
### TryIndexOf(str,value,index,comparisonType) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `value`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to search in. |
| value | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The character to find. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `value` in the string, or -1 if it is not
found. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the enumeration values that specifies the rules of the search. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-String,System-String,System-Int32,System-Int32@,System-StringComparison-'></a>
### TryIndexOf(str,value,startIndex,index,comparisonType) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `value`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to search in. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The character to find. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The search starting position. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `value` in the string, or -1 if it is not
found. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the enumeration values that specifies the rules of the search. |

<a name='M-Semantica-Extensions-StringExtensions-TryIndexOf-System-ReadOnlySpan{System-Char},System-ReadOnlySpan{System-Char},System-Int32,System-Int32@,System-StringComparison-'></a>
### TryIndexOf(str,value,startIndex,index,comparisonType) `method`

##### Summary

Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
whether it was found.

##### Returns

`true` if the string contained `value`; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The string to search in. |
| value | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The character to find. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The search starting position. |
| index | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | When this method returns, contains the zero-based index of `value` in the string, or -1 if it is not
found. |
| comparisonType | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | One of the enumeration values that specifies the rules of the search. |

<a name='M-Semantica-Extensions-StringExtensions-TrySplit-System-String,System-Char,System-Int32,System-String[]@-'></a>
### TrySplit(str,separator,expectedParts,parts) `method`

##### Summary

Splits a string into substrings based on the specified separator character and returns a value indicating whether the
result contains the expected number of substrings.

##### Returns

`true` if `parts` contains the expected number of substrings; otherwise,
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to split. |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to split the string on. |
| expectedParts | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The expected number of substrings after the string is split. |
| parts | [System.String[]@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[]@ 'System.String[]@') | When this method returns, contains the substrings. |

<a name='M-Semantica-Extensions-StringExtensions-WithLeadingSpace-System-String-'></a>
### WithLeadingSpace(str) `method`

##### Summary

Returns this string, followed by a space if it ends with a non-space character.

##### Returns

The string, followed by a space if the string is not empty and does not already end in white space.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to return. |

<a name='M-Semantica-Extensions-StringExtensions-WithSpace-System-String-'></a>
### WithSpace(str) `method`

##### Summary

Returns this string, followed by a space if it ends with a non-space character.

##### Returns

The string, followed by a space if the string is not empty and does not already end in white space.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to return. |

<a name='T-Semantica-Extensions-Tokenizer-StringTokenizer'></a>
## StringTokenizer `type`

##### Namespace

Semantica.Extensions.Tokenizer

##### Summary

Struct that contains the intermediate result of a
[Tokenize](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-String,System-ReadOnlySpan{System-Char}@,System-StringComparison- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.String,System.ReadOnlySpan{System.Char}@,System.StringComparison)') call, on which the
fluentAPI-like extensions are based.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Input | [T:Semantica.Extensions.Tokenizer.StringTokenizer](#T-T-Semantica-Extensions-Tokenizer-StringTokenizer 'T:Semantica.Extensions.Tokenizer.StringTokenizer') | String that's being tokenized. |

<a name='M-Semantica-Extensions-Tokenizer-StringTokenizer-#ctor-System-String,System-String,System-Int32,System-StringComparison-'></a>
### #ctor(Input,Separator,RestIndex,StringComparison) `constructor`

##### Summary

Struct that contains the intermediate result of a
[Tokenize](#M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-String,System-ReadOnlySpan{System-Char}@,System-StringComparison- 'Semantica.Extensions.TokenizeExtensions.Tokenize(System.String,System.String,System.ReadOnlySpan{System.Char}@,System.StringComparison)') call, on which the
fluentAPI-like extensions are based.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String that's being tokenized. |
| Separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Separator string that was previously searched for. |
| RestIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Index of the character in `Input` directly after the previously found separator. A value of 0 means that
a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped. |
| StringComparison | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | Specifies the rules for the search. |

<a name='P-Semantica-Extensions-Tokenizer-StringTokenizer-Input'></a>
### Input `property`

##### Summary

String that's being tokenized.

<a name='P-Semantica-Extensions-Tokenizer-StringTokenizer-RestIndex'></a>
### RestIndex `property`

##### Summary

Index of the character in `Input` directly after the previously found separator. A value of 0 means that
a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped.

<a name='P-Semantica-Extensions-Tokenizer-StringTokenizer-Separator'></a>
### Separator `property`

##### Summary

Separator string that was previously searched for.

<a name='P-Semantica-Extensions-Tokenizer-StringTokenizer-StringComparison'></a>
### StringComparison `property`

##### Summary

Specifies the rules for the search.

<a name='T-Semantica-Extensions-TimeSpanExtensions'></a>
## TimeSpanExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for timespans.

<a name='M-Semantica-Extensions-TimeSpanExtensions-FloorToDays-System-TimeSpan-'></a>
### FloorToDays(timespan) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value that is based on `timespan` rounded down to the day.

##### Returns

A [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value with the days value equal to `timespan`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value to floor. |

<a name='M-Semantica-Extensions-TimeSpanExtensions-FloorToHours-System-TimeSpan-'></a>
### FloorToHours(timespan) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value that is based on `timespan` rounded down to the hour.

##### Returns

A [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value with the days and hours values equal to `timespan`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value to floor. |

<a name='M-Semantica-Extensions-TimeSpanExtensions-FloorToMilliseconds-System-TimeSpan-'></a>
### FloorToMilliseconds(timespan) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value that is based on `timespan` rounded down to the millisecond.

##### Returns

A [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value with the days, hours, minutes, second and millisecond values equal to `timespan`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value to floor. |

<a name='M-Semantica-Extensions-TimeSpanExtensions-FloorToMinutes-System-TimeSpan-'></a>
### FloorToMinutes(timespan) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value that is based on `timespan` rounded down to the minute.

##### Returns

A [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value with the days, hours and minutes values equal to `timespan`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value to floor. |

<a name='M-Semantica-Extensions-TimeSpanExtensions-FloorToSeconds-System-TimeSpan-'></a>
### FloorToSeconds(timespan) `method`

##### Summary

Returns a [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value that is based on `timespan` rounded down to the second.

##### Returns

A [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value with the days, hours, minutes and seconds values equal to `timespan`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The [TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') value to floor. |

<a name='T-Semantica-Extensions-TokenizeExtensions'></a>
## TokenizeExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

A number of extension methods used for tokenizing/splitting strings into [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1'), using a fluent
syntax. The methods cause no heap allocations.

<a name='M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### Next(tokenizer,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of the separator char in the input string, and outputs the part of the
input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If separator is
not found subsequent searches are skipped.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-CharTokenizer,System-Char,System-ReadOnlySpan{System-Char}@-'></a>
### Next(tokenizer,separator,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of a different separator char in the input string, and outputs the part
of the input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If
separator is not found subsequent searches are skipped.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The new separator char to search for. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### Next(tokenizer,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of the separator string in the input string, and outputs the part of the
input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If separator is
not found subsequent searches are skipped.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Next-Semantica-Extensions-Tokenizer-StringTokenizer,System-String,System-ReadOnlySpan{System-Char}@-'></a>
### Next(tokenizer,separator,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of a different separator string in the input string, and outputs the
part of the input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If
separator is not found subsequent searches are skipped.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new separator string to search for. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### NextOptional(tokenizer,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of the separator char in the input string, and outputs the part of the
input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If separator is
not found subsequent searches are not affected.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-CharTokenizer,System-Char,System-ReadOnlySpan{System-Char}@-'></a>
### NextOptional(tokenizer,separator,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of a different separator char in the input string, and outputs the part
of the input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If
separator is not found subsequent searches are not affected.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The new separator char to search for. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### NextOptional(tokenizer,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of the separator string in the input string, and outputs the part of the
input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If separator is
not found subsequent searches are not affected.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-NextOptional-Semantica-Extensions-Tokenizer-StringTokenizer,System-String,System-ReadOnlySpan{System-Char}@-'></a>
### NextOptional(tokenizer,separator,token) `method`

##### Summary

Tokenizer method that finds the next occurrence of a different separator string in the input string, and outputs the
part of the input between the found and the previously found separator as a [ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. If
separator is not found subsequent searches are not affected.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new separator string to search for. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the next token if the separator is found. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Rest-Semantica-Extensions-Tokenizer-CharTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### Rest(tokenizer,token) `method`

##### Summary

Tokenizer method that outputs the part of the input string after the last found separator.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the last token. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Rest-Semantica-Extensions-Tokenizer-StringTokenizer,System-ReadOnlySpan{System-Char}@-'></a>
### Rest(tokenizer,token) `method`

##### Summary

Tokenizer method that outputs the part of the input string after the last found separator.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the last token. |

<a name='M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-Char,System-ReadOnlySpan{System-Char}@-'></a>
### Tokenize(input,separator,token) `method`

##### Summary

Finds the part of the input string up until the first occurrence of the separator char, and outputs it as a
[ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. Returns a [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance to facilitate retrieval of
subsequent tokens.

##### Returns

A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') instance that should be used as input for the subsequent tokenizer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input string to tokenize. |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The separator char to find. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the first token if the separator is found. |

##### Example

```
if (input.Tokenize(',', out var token1).Next(out var token2).Rest(out var token3).Try())
```

<a name='M-Semantica-Extensions-TokenizeExtensions-Tokenize-System-String,System-String,System-ReadOnlySpan{System-Char}@,System-StringComparison-'></a>
### Tokenize(input,separator,token,stringComparison) `method`

##### Summary

Finds the part of the input string up until the first occurrence of the separator string, and outputs it as a
[ReadOnlySpan\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan`1 'System.ReadOnlySpan`1') of chars. Returns a [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance to facilitate retrieval of
subsequent tokens.

##### Returns

A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') instance that subsequent tokenizer methods can be called on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The input string to tokenize. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The separator string to find. |
| token | [System.ReadOnlySpan{System.Char}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}@') | Out paramater containing the first token if the separator is found. |
| stringComparison | [System.StringComparison](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison 'System.StringComparison') | Specifies the rules for the search. |

##### Example

```
if (input.Tokenize("--", out var token1).Next(out var token2).Rest(out var token3).Try())
```

<a name='M-Semantica-Extensions-TokenizeExtensions-Try-Semantica-Extensions-Tokenizer-CharTokenizer-'></a>
### Try(tokenizer) `method`

##### Summary

Tokenizer finalizer method that determines if all previously searched (non-optional) tokens have been found, and the
rest of the input does not contain any more of the last searched separator.

##### Returns

`true` if all expected (non-optional) tokens have been found, and the rest does not contain more
separators; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer') | A [CharTokenizer](#T-Semantica-Extensions-Tokenizer-CharTokenizer 'Semantica.Extensions.Tokenizer.CharTokenizer'). |

<a name='M-Semantica-Extensions-TokenizeExtensions-Try-Semantica-Extensions-Tokenizer-StringTokenizer-'></a>
### Try(tokenizer) `method`

##### Summary

Tokenizer finalizer method that determines if all previously searched (non-optional) tokens have been found, and the
rest of the input does not contain any more of the last searched separator.

##### Returns

`true` if all expected (non-optional) tokens have been found, and the rest does not contain more
separators; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenizer | [Semantica.Extensions.Tokenizer.StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer') | A [StringTokenizer](#T-Semantica-Extensions-Tokenizer-StringTokenizer 'Semantica.Extensions.Tokenizer.StringTokenizer'). |

<a name='T-Semantica-Extensions-UriExtensions'></a>
## UriExtensions `type`

##### Namespace

Semantica.Extensions

##### Summary

Provides additional functionality for dates and times.

<a name='M-Semantica-Extensions-UriExtensions-Combine-System-Uri,System-String-'></a>
### Combine(uri,path) `method`

##### Summary

Combines a [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') with an additional path. Differs from the Uri constructor by appending the path even if the
the Uri's path doesn't end with a slash. A slash is inserted in this case.

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') with `path` appended to the input's path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The input with the path to be expanded. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path-part to be added. If null, the original uri is returned. |
