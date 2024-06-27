Semantica.Lib.App
====================================================================================

Com.Semantica.App.RouteValues
-----------------------------

- ``Set(String, Object)``
- ``IsEmpty()``
- ``GetEnumerator()``
- ``Create(String, Object)``
- ``Values``
- ``None``

Com.Semantica.App.RouteValuesExtensions
---------------------------------------

- ``SetIf(RouteValues, Boolean, String, Object)``
- ``ToRouteValues(IReadOnlyDictionary`2, String[])``
- ``ToRouteValues(IReadOnlyDictionary`2, IReadOnlyList`1)``
- ``TryToRouteValues(IReadOnlyDictionary`2, RouteValues&, String[])``
- ``ContainsKeys(IReadOnlyDictionary`2, IReadOnlyList`1)``
- ``ContainsKey(RouteValues, String)``


Semantica.Lib.Contracts
==========================================================================================

Com.Semantica.Contracts.Check
-----------------------------

- ``That(Boolean)``
- ``Not(Boolean)``
- ``NotNull(T)``
- ``WhenNotNull(Nullable`1, Check)``
- ``WhenNotNull(T, Check)``
- ``NotNull(Nullable`1)``
- ``NotNullOrDefault(T)``
- ``NotDefault(T)``
- ``NotEmpty(IReadOnlyCollection`1)``
- ``NotEmpty(IReadOnlyList`1)``
- ``NotEmpty(Guid)``
- ``NotEmpty(String)``
- ``IsDefined(T)``
- ``IsDefined(Double)``
- ``NonZero(Int32)``
- ``NonZero(Int16)``
- ``NonZero(Int64)``
- ``NonZero(Single)``
- ``NonZero(Double)``
- ``NonZero(Decimal)``
- ``NotNegative(Int32)``
- ``NotNegative(Int16)``
- ``NotNegative(Int64)``
- ``NotNegative(Single)``
- ``NotNegative(Double)``
- ``NotNegative(Decimal)``
- ``StrictPositive(Int32)``
- ``StrictPositive(Int16)``
- ``StrictPositive(Int64)``
- ``StrictPositive(Single)``
- ``StrictPositive(Double)``
- ``StrictPositive(Decimal)``
- ``MinLength(String, Int32)``
- ``MaxLength(String, Int32)``
- ``.ctor(Boolean, CheckKind)``
- ``Kind``
- ``IsValid``
- ``None``
- ``CheckKind``

Com.Semantica.Contracts.Contract
--------------------------------

- ``Requires(Check&, String)``

Com.Semantica.Contracts.State
-----------------------------

- ``ShouldBe(Boolean, String)``
- ``ShouldBe(Boolean, String, String)``
- ``ShouldNotBe(Boolean, String)``
- ``ShouldNotBe(Boolean, String, String)``

Com.Semantica.Contracts.Exceptions.ContractException
----------------------------------------------------

- ``.ctor(String)``

Com.Semantica.Contracts.Exceptions.ContractArgumentException
------------------------------------------------------------

- ``.ctor(String, String)``

Com.Semantica.Contracts.Exceptions.ContractArgumentNullException
----------------------------------------------------------------

- ``.ctor(String, String)``

Com.Semantica.Contracts.Exceptions.ContractArgumentOutOfRangeException
----------------------------------------------------------------------

- ``.ctor(String, String)``

Com.Semantica.Contracts.Exceptions.InvalidStateException
--------------------------------------------------------

- ``.ctor(String)``

Com.Semantica.Contracts.Check+CheckKind
---------------------------------------

- ``Bool``
- ``Defined``
- ``NotNull``
- ``NotEmpty``
- ``NonZero``
- ``NonNegative``
- ``StrictPositive``


Semantica.Lib.Linq
=====================================================================================

Com.Semantica.Linq.CollectionExtensions
---------------------------------------

- ``NullIfEmpty(IReadOnlyCollection`1)``
- ``IsNullOrEmpty(IReadOnlyCollection`1)``
- ``SelectArray(IReadOnlyCollection`1, Func`2)``
- ``SelectArray(IReadOnlyCollection`1, Func`3)``
- ``SelectArraySkipLast(IReadOnlyCollection`1, Func`2, Int32)``

Com.Semantica.Linq.EnumerableExtensions
---------------------------------------

- ``AnyAndAll(IEnumerable`1, Func`2)``
- ``Enumerate(IEnumerable`1)``
- ``FirstOrDefaultOfFirst(IEnumerable`1, Func`2, Func`2)``
- ``HasCount(IEnumerable`1, Int32)``
- ``HasCount(IEnumerable`1, Int32, Func`2)``
- ``OneOrDefault(IEnumerable`1)``
- ``Sum(IEnumerable`1)``
- ``TryFirst(IEnumerable`1, T&)``
- ``TryPrevious(IEnumerable`1, Func`2, T&)``
- ``TrySingle(IEnumerable`1, T&)``

Com.Semantica.Linq.EnumerableForEachExtensions
----------------------------------------------

- ``ForEach(IEnumerable`1, Action`1)``
- ``ForEachAsync(IEnumerable`1, Func`2)``
- ``ForEachAndPass(IEnumerable`1, Action`2, TParam)``
- ``ForEachWithNext(IEnumerable`1, Action`2, Boolean)``

Com.Semantica.Linq.EnumerableLinqExtensions
-------------------------------------------

- ``Append(IEnumerable`1, T[])``
- ``ConcatWhenNotNull(IEnumerable`1, IEnumerable`1)``
- ``ConditionalConcat(IEnumerable`1, Boolean, IEnumerable`1)``
- ``ConditionalIntersect(IEnumerable`1, Boolean, IEnumerable`1)``
- ``ConditionalIntersect(IEnumerable`1, Boolean, IEnumerable`1, IEqualityComparer`1)``
- ``ConditionalIntersectBy(IEnumerable`1, Boolean, IEnumerable`1, Func`2)``
- ``ConditionalIntersectBy(IEnumerable`1, Boolean, IEnumerable`1, Func`2, IEqualityComparer`1)``
- ``ConditionalWhere(IEnumerable`1, Boolean, Func`2)``
- ``Exclude(IEnumerable`1, IReadOnlyCollection`1)``
- ``PrecedeBy(IEnumerable`1, T)``
- ``Prepend(IEnumerable`1, T[])``
- ``WhereNot(IEnumerable`1, Func`2)``
- ``WhereNotIn(IEnumerable`1, IReadOnlyCollection`1)``
- ``WhereNotNull(IEnumerable`1)``
- ``WhereNotNull(IEnumerable`1)``
- ``WhereNotNull(IEnumerable`1)``
- ``WhereNotNullOrEmpty(IEnumerable`1)``

Com.Semantica.Linq.EnumerableSelectExtensions
---------------------------------------------

- ``Select(IEnumerable`1, Func`4)``
- ``SelectAndPass(IEnumerable`1, Func`3, TParam)``
- ``SelectAndPass(IEnumerable`1, Func`4, TParam1, TParam2)``
- ``SelectArray(IEnumerable`1, Int32, Func`2)``
- ``SelectArray(IEnumerable`1, Int32, Func`3)``
- ``SelectArrayAndPass(IEnumerable`1, Int32, Func`3, TParam)``
- ``SelectMany(IEnumerable`1)``
- ``SelectManyTuples(IEnumerable`1)``
- ``SelectWithNext(IEnumerable`1, Func`3)``
- ``SelectWithNext(IEnumerable`1, Func`3, Boolean)``
- ``SelectWithPrevious(IEnumerable`1, Func`3)``

Com.Semantica.Linq.EnumerableToExtensions
-----------------------------------------

- ``AnyToArray(IEnumerable`1, T[]&)``
- ``AnyToList(IEnumerable`1, List`1&)``
- ``AnyToReadOnlyList(IEnumerable`1, IReadOnlyList`1&)``
- ``ToArray(IEnumerable`1, Int32)``
- ``ToArray(IEnumerable`1, Int32, T)``
- ``ToArrayOrNull(IEnumerable`1)``
- ``ToListOrNull(IEnumerable`1)``
- ``ToReadOnlyListOrNull(IEnumerable`1)``
- ``ToReadOnlyDictionary(IEnumerable`1, Func`2, Func`2)``
- ``ToReadOnlyList(IEnumerable`1)``
- ``ToReadOnlyList(IEnumerable`1, Int32)``

Com.Semantica.Linq.EnumeratorExtensions
---------------------------------------

- ``TryMoveNext(IEnumerator`1, T&)``

Com.Semantica.Linq.QueryableExtensions
--------------------------------------

- ``ConditionalWhere(IQueryable`1, Boolean, Expression`1)``

Com.Semantica.Linq.ReadOnlyDictionaryExtensions
-----------------------------------------------

- ``IsNullOrEmpty(IReadOnlyDictionary`2)``

Com.Semantica.Linq.ReadOnlyListExtensions
-----------------------------------------

- ``AreDistinct(IReadOnlyList`1, Func`2, EqualityComparer`1)``
- ``AreDistinct(IReadOnlyList`1, Func`2)``
- ``AreDistinctOrDefault(IReadOnlyList`1, Func`2, EqualityComparer`1)``
- ``AreDistinctOrDefault(IReadOnlyList`1, Func`2)``
- ``ConcatArray(IReadOnlyList`1, IReadOnlyList`1)``
- ``CopyTo(IReadOnlyList`1, T[], Int32)``
- ``ForEach(IReadOnlyList`1, Action`1)``
- ``ForEach(IReadOnlyList`1, Action`2)``
- ``GetOrDefault(IReadOnlyList`1, Int32)``
- ``IsNullOrEmpty(IReadOnlyList`1)``
- ``NullIfEmpty(IReadOnlyList`1)``
- ``SkipLast(IReadOnlyList`1, Int32)``
- ``ToReadOnlyList(List`1)``
- ``ToReadOnlyList(T[])``
- ``ToReadOnlyList(IReadOnlyList`1)``
- ``ToBucketArrayDictionary(IReadOnlyList`1, IReadOnlyList`1, Func`2)``

Com.Semantica.Linq.ReadOnlyListLinqExtensions
---------------------------------------------

- ``Any(IReadOnlyList`1)``
- ``ElementAtOrDefault(IReadOnlyList`1, Int32)``
- ``First(IReadOnlyList`1)``
- ``IndexOf(IReadOnlyList`1, T)``
- ``IndexOf(IReadOnlyList`1, Func`2)``
- ``Last(IReadOnlyList`1)``
- ``LastIndexOf(IReadOnlyList`1, Func`2)``
- ``Reverse(IReadOnlyList`1)``
- ``ToArray(IReadOnlyList`1)``

Com.Semantica.Linq.ReadOnlyListSelectExtensions
-----------------------------------------------

- ``SelectArray(IReadOnlyList`1, Func`2)``
- ``SelectArray(IReadOnlyList`1, Func`3)``
- ``SelectArray(IReadOnlyList`1, Func`4)``
- ``SelectArrayAsync(IReadOnlyList`1, Func`2)``
- ``SelectArrayAsync(IReadOnlyList`1, Func`3)``
- ``SelectArrayAndPass(IReadOnlyList`1, Func`3, TParam)``
- ``SelectArrayAndPass(IReadOnlyList`1, Func`4, TParam, TParam2)``
- ``SelectArrayOrNull(IReadOnlyList`1, Func`2)``
- ``SelectArraySkipLast(IReadOnlyList`1, Func`2)``
- ``SelectArraySkipLast(IReadOnlyList`1, Func`2, Int32)``

Com.Semantica.Linq.StaticSelectors
----------------------------------

- ``Self(T)``


Semantica.Lib.Patterns
=========================================================================================

Com.Semantica.Patterns.CanBeEmptyCollectionExtensions
-----------------------------------------------------

- ``GetValue(IReadOnlyDictionary`2, TKey)``
- ``WhereNotEmpty(IEnumerable`1)``

Com.Semantica.Patterns.CanBeEmptyExtensions
-------------------------------------------

- ``CanBeEmptyToNullable(T)``
- ``FirstNonEmpty(IEnumerable`1)``
- ``NullOnEmpty(ICanBeEmpty, T)``
- ``NullOnEmpty(ICanBeEmpty, Nullable`1)``

Com.Semantica.Patterns.DeterminableCollectionExtensions
-------------------------------------------------------

- ``WhereDetermined(IEnumerable`1)``

Com.Semantica.Patterns.DeterminableExtensions
---------------------------------------------

- ``DeterminableToNullable(T)``

Com.Semantica.Patterns.ICanBeEmpty
----------------------------------

- ``IsEmpty()``

Com.Semantica.Patterns.IDateTimeEquivalent
------------------------------------------

- ``AsDateTime()``
- ``AsNullableDateTime()``

Com.Semantica.Patterns.IDeterminable
------------------------------------

- ``IsDetermined``

Com.Semantica.Patterns.PatternCheck
-----------------------------------

- ``NotEmpty(T)``
- ``IsDetermined(T)``


Semantica.Lib.Checks
=======================================================================================

Com.Semantica.Checks.Chk
------------------------

- ``HasFailed()``
- ``HasPassed()``
- ``SplitReasons()``
- ``ToString()``
- ``WithPld(TPayload)``
- ``WithFailPld(TPayload)``
- ``WithPassPld(TPayload)``
- ``op_BitwiseAnd(Chk, Chk)``
- ``op_BitwiseOr(Chk, Chk)``
- ``op_LogicalNot(Chk)``
- ``op_True(Chk)``
- ``op_False(Chk)``
- ``If(Boolean)``
- ``If(Boolean, String, String)``
- ``If(Boolean, TPayload)``
- ``If(Boolean, TPayload, String)``
- ``If(Boolean, String, TPayload)``
- ``IfFail(Boolean, String)``
- ``IfPass(Boolean, String)``
- ``Passed``
- ``Failed``
- ``IsDetermined``
- ``Reason``
- ``Fail``
- ``Pass``
- ``Rsn``
- ``Pld``

Com.Semantica.Checks.Chk`1
--------------------------

- ``HasFailed()``
- ``HasPassed()``
- ``Simplify()``
- ``Simplify(T&)``
- ``SplitReasons()``
- ``ToString()``
- ``op_BitwiseAnd(Chk`1, Chk`1)``
- ``op_BitwiseAnd(Chk`1, Chk)``
- ``op_BitwiseOr(Chk`1, Chk`1)``
- ``op_BitwiseOr(Chk`1, Chk)``
- ``op_LogicalNot(Chk`1)``
- ``op_True(Chk`1)``
- ``op_False(Chk`1)``
- ``.ctor(Chk, T)``
- ``Passed``
- ``Failed``
- ``Reason``
- ``Payload``
- ``Fail``
- ``Pass``
- ``Rsn``

Com.Semantica.Checks.IChk
-------------------------

- ``HasFailed()``
- ``HasPassed()``
- ``Passed``
- ``Failed``
- ``Reason``

Com.Semantica.Checks.Chk+Rsn
----------------------------

- ``Combine(Chk, Chk)``
- ``ForFail(String)``
- ``ForFail(String)``
- ``ForPass(String)``
- ``ForPass(String)``
- ``Split(String)``
- ``Fail``
- ``Pass``

Com.Semantica.Checks.Chk+Pld
----------------------------

- ``ForFail(TPayload)``
- ``ForFail(TPayload, String)``
- ``ForPass(TPayload)``
- ``ForPass(TPayload, String)``
- ``If(Chk, TPayload, TPayload)``
- ``If(Boolean, TPayload, TPayload)``
- ``IfFail(Chk, TPayload)``
- ``IfFail(Boolean, String)``
- ``IfFail(Boolean, TPayload)``
- ``IfFail(Boolean, TPayload, String)``
- ``IfPass(Chk, TPayload)``
- ``IfPass(Boolean, String)``
- ``IfPass(Boolean, TPayload)``
- ``IfPass(Boolean, TPayload, String)``

Com.Semantica.Checks.Chk`1+Rsn
------------------------------

- ``Fail``
- ``Pass``


Semantica.Lib.Collections
============================================================================================

Com.Semantica.Core.Collections.ArrayDictionary`2
------------------------------------------------

- ``ContainsKey(TKey)``
- ``TryGetValue(TKey, TValue&)``
- ``GetEnumerator()``
- ``CopyTo(KeyValuePair`2[], Int32)``
- ``Add(KeyValuePair`2)``
- ``Clear()``
- ``Contains(KeyValuePair`2)``
- ``Remove(KeyValuePair`2)``
- ``Add(TKey, TValue)``
- ``Remove(TKey)``
- ``<.ctor>g__ToPair|2_0(Object[], Int32)``
- ``.ctor(IEnumerable`1)``
- ``.ctor(Object[][])``
- ``Count``
- ``IsReadOnly``
- ``Keys``
- ``Values``
- ``Item``

Com.Semantica.Core.Collections.CollectionExtensions
---------------------------------------------------

- ``SelectMapped(IReadOnlyList`1, Func`2)``
- ``ToRetrievalCollection(IEnumerable`1)``
- ``ToArrayDictionary(IEnumerable`1, Func`2)``
- ``ToArrayDictionary(IEnumerable`1, Func`2, Func`2)``

Com.Semantica.Core.Collections.EmptyList`1
------------------------------------------

- ``GetEnumerator()``
- ``.ctor()``
- ``Count``
- ``Item``

Com.Semantica.Core.Collections.IRetrievalCollection`1
-----------------------------------------------------

- ``RetrieveFirstOrDefault(Func`2)``
- ``Retrieve(Func`2)``
- ``Count``

Com.Semantica.Core.Collections.MappedReadOnlyList`2
---------------------------------------------------

- ``GetEnumerator()``
- ``.ctor(IReadOnlyList`1, Func`2)``
- ``Item``
- ``Count``

Com.Semantica.Core.Collections.RetrievalCollection`1
----------------------------------------------------

- ``RetrieveFirstOrDefault(Func`2)``
- ``Retrieve(Func`2)``
- ``IsEmpty()``
- ``GetEnumerator()``
- ``.ctor(IEnumerable`1)``
- ``Count``

Com.Semantica.Core.Collections.SingleItemList`1
-----------------------------------------------

- ``Contains(T)``
- ``IndexOf(T)``
- ``Add(T)``
- ``Clear()``
- ``CopyTo(T[], Int32)``
- ``Remove(T)``
- ``Insert(Int32, T)``
- ``RemoveAt(Int32)``
- ``GetEnumerator()``
- ``.ctor(T, Int32, Int32)``
- ``Count``
- ``IsReadOnly``
- ``Item``


Semantica.Lib.Core
=====================================================================================

Com.Semantica.Core.ValidatedResult
----------------------------------

- ``IsValid()``
- ``As(TResult)``
- ``Invalid(String)``
- ``op_Addition(ValidatedResult, ValidatedResult)``
- ``op_LogicalNot(ValidatedResult)``
- ``From(Boolean, String)``
- ``Test(Func`1[])``
- ``Message``
- ``Valid``

Com.Semantica.Core.ValidatedResult`1
------------------------------------

- ``IsValid()``
- ``Simplify()``
- ``As()``
- ``As(TResult)``
- ``op_LogicalNot(ValidatedResult`1)``
- ``Valid(T)``
- ``Invalid(String, T)``
- ``Message``
- ``Content``

Com.Semantica.Core.Providers.BaseDateProvider
---------------------------------------------

- ``Now()``
- ``Today()``
- ``InstanceNow()``
- ``InstanceToday()``
- ``UnixEpoch()``
- ``ResetInstance()``
- ``.ctor()``
- ``_instanceNow``

Com.Semantica.Core.Providers.EnumValueProvider
----------------------------------------------

- ``GetValueAttributes()``
- ``EnumerateValues()``

Com.Semantica.Core.Providers.IBaseDateProvider
----------------------------------------------

- ``InstanceNow()``
- ``InstanceToday()``
- ``Now()``
- ``ResetInstance()``
- ``Today()``
- ``UnixEpoch()``

Com.Semantica.Core.Patterns.ArithmaticExtensions
------------------------------------------------

- ``Sum(IEnumerable`1)``

Com.Semantica.Core.Patterns.IApproximable`1
-------------------------------------------

- ``IsApproximateTo(T)``

Com.Semantica.Core.Patterns.IArithmatic`1
-----------------------------------------

- ``Add(T)``
- ``Subtract(T)``
- ``Multiply(Int32)``

Com.Semantica.Core.Operations.AveragingExtensions
-------------------------------------------------

- ``NthOrderStatistic(IList`1, Int32, Random)``
- ``Swap(IList`1, Int32, Int32)``
- ``Median(IList`1)``
- ``Median(IEnumerable`1)``
- ``Median(IEnumerable`1, Func`2)``
- ``Median(IReadOnlyList`1)``
- ``Median(IReadOnlyList`1, Func`2)``

Com.Semantica.Core.Operations.Comparable
----------------------------------------

- ``CompareOrNull(IComparable, IComparable)``
- ``CompareOrNull(TValue, TValue)``
- ``Max(T[])``
- ``Max(T, T)``
- ``Min(T[])``
- ``Min(T, T)``
- ``TryCompareHasValue(Boolean, Boolean, Int32&, Boolean)``
- ``TryCompareIsEmpty(Boolean, Boolean, Int32&, Boolean)``

Com.Semantica.Core.Operations.Logic
-----------------------------------

- ``ExactlyOne(Boolean[])``
- ``None(Boolean[])``
- ``OneOrNone(Boolean[])``
- ``Follows(Boolean, Boolean[])``

Com.Semantica.Domain.IIdentityKey
---------------------------------

- ``AsNullable()``

Com.Semantica.Domain.IIdentityKey`1
-----------------------------------

- ``Id``


Semantica.Lib.Extensions
===========================================================================================

Com.Semantica.Extensions.ArrayExtensions
----------------------------------------

- ``BitClone(Int32[])``

Com.Semantica.Extensions.AttributeExtensions
--------------------------------------------

- ``GetAttribute(TEnum)``
- ``GetAttribute(TEnum, IEnumerable`1)``
- ``HasAttribute(TEnum)``

Com.Semantica.Extensions.BooleanExtensions
------------------------------------------

- ``IsExplicitFalse(Nullable`1)``

Com.Semantica.Extensions.ComparableExtensions
---------------------------------------------

- ``MaxBy(IEnumerable`1, Func`2, Func`2, Func`2)``
- ``MaxOrNull(IEnumerable`1)``
- ``MaxByOrNull(IEnumerable`1, Func`2)``

Com.Semantica.Extensions.DateTimeExtensions
-------------------------------------------

- ``FloorToDay(DateTime)``
- ``FloorToDays(TimeSpan)``
- ``FloorToMinute(DateTime)``
- ``FloorToMinutes(TimeSpan)``

Com.Semantica.Extensions.DecimalExtensions
------------------------------------------

- ``IntegerAbove(Decimal)``
- ``IntegerBelow(Decimal)``

Com.Semantica.Extensions.DictionaryExtensions
---------------------------------------------

- ``GetValueOrNull(IReadOnlyDictionary`2, TKey)``

Com.Semantica.Extensions.DoubleExtensions
-----------------------------------------

- ``IntegerAbove(Double)``
- ``IntegerBelow(Double)``

Com.Semantica.Extensions.EnumerablExtensions
--------------------------------------------

- ``SelectIfDictionaryContains(IEnumerable`1, Func`2, IReadOnlyDictionary`2)``
- ``SelectIfDictionaryContains(IEnumerable`1, IReadOnlyDictionary`2)``
- ``WhereNotEnumDefault(IEnumerable`1)``

Com.Semantica.Extensions.EnumExtensions
---------------------------------------

- ``EnumerateFlagValues(TEnum)``
- ``AsNullable(T)``
- ``IsDefault(T)``
- ``IsNotDefault(T)``
- ``IsNullOrDefault(IReadOnlyList`1)``
- ``IsValid(T)``

Com.Semantica.Extensions.ExpressionExtensions
---------------------------------------------

- ``GetPropertyInfo(Expression`1)``
- ``GetPropertyName(Expression`1)``
- ``GetAttribute(Expression`1)``

Com.Semantica.Extensions.GuidExtensions
---------------------------------------

- ``IsEmpty(Guid)``

Com.Semantica.Extensions.HashSetExtensions
------------------------------------------

- ``AddRange(HashSet`1, IEnumerable`1)``
- ``AddRange(HashSet`1, IEnumerable`1, ICollection`1)``
- ``Intersect(HashSet`1, IEnumerable`1)``
- ``ToArray(HashSet`1)``
- ``ToArrayOrNull(HashSet`1)``
- ``ToReadOnlyList(HashSet`1)``
- ``ToReadOnlyListOrNull(HashSet`1)``

Com.Semantica.Extensions.IntegerExtensions
------------------------------------------

- ``DivideRoundingUp(Int32, Int32)``

Com.Semantica.Extensions.IntExtensions
--------------------------------------

- ``Modulo(Int32, Int32)``
- ``IsPowerOfTwo(Int32)``

Com.Semantica.Extensions.ListExtensions
---------------------------------------

- ``AddIfNotNull(List`1, T)``

Com.Semantica.Extensions.MethodInfoExtensions
---------------------------------------------

- ``CreateDelegate(MethodInfo)``

Com.Semantica.Extensions.PropertyInfoExtensions
-----------------------------------------------

- ``HasAttribute(PropertyInfo)``

Com.Semantica.Extensions.StringBuilderExtensions
------------------------------------------------

- ``ToStringNoNewLine(StringBuilder)``

Com.Semantica.Extensions.StringExtensions
-----------------------------------------

- ``NullOnEmpty(String, Boolean)``
- ``EmptyOnNull(String, Boolean)``
- ``TryIndexOf(String, Char, Int32&)``
- ``Contains(String, String, CompareOptions)``
- ``TakeMax(String, Int32)``
- ``Truncate(String, Int32, String)``
- ``RemoveSpecialCharacters(String)``
- ``GetDigits(String)``
- ``ToInt(IEnumerable`1)``
- ``GetTinyNumber(String)``
- ``GetFirstLetterLowerCase(String)``
- ``Capitalize(String)``
- ``Decapitalize(String)``
- ``WithSpace(String)``
- ``IsCapitalizedLatinChar(Char)``
- ``StripIfEndsWith(String, String, StringComparison)``
- ``TrimToNull(String)``
- ``TrySplit(String, Char, Int32, String[]&)``


Semantica.Lib.Core.SimpleInjector
====================================================================================================

Com.Semantica.Core.SimpleInjector.CoreModule
--------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``RegisterDateProviderScoped(Container)``
- ``.ctor()``


Semantica.Lib.DI
===================================================================================

Com.Semantica.Core.DI.IModule`1
-------------------------------

- ``EnumerateDependencyModules()``
- ``Register(TContainer)``
- ``RegisterModuleImplementation(TContainer)``
- ``SetDependencyPath(IEnumerable`1)``

Com.Semantica.Core.DI.ModuleBase`1
----------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(TContainer)``
- ``get__Empty()``
- ``SetDependencyPath(IEnumerable`1)``
- ``EnumerateDependencyModules()``
- ``Register(TContainer)``
- ``.ctor()``
- ``_Empty``

Com.Semantica.Core.DI.ModuleException
-------------------------------------

- ``.ctor(String)``
- ``.ctor(String, Exception)``


Semantica.Lib.Types
======================================================================================

Com.Semantica.Dates.DateDay
---------------------------

- ``AsNullableDateTime()``
- ``AsDateTime()``
- ``Serialize()``
- ``Deserialize(String)``
- ``CompareTo(DateDay)``
- ``Equals(DateDay)``
- ``ToString(String, IFormatProvider)``
- ``ToString()``
- ``Equals(Object)``
- ``GetHashCode()``
- ``IsEmpty()``
- ``op_Equality(DateDay, DateDay)``
- ``op_Inequality(DateDay, DateDay)``
- ``op_LessThan(DateDay, DateDay)``
- ``op_GreaterThan(DateDay, DateDay)``
- ``op_LessThanOrEqual(DateDay, DateDay)``
- ``op_GreaterThanOrEqual(DateDay, DateDay)``
- ``FromNullable(Nullable`1)``
- ``FromString(String)``
- ``.ctor(Int32, Int32, Int32)``
- ``.ctor(DateTime)``
- ``Empty``
- ``MaxValue``
- ``SerializationFormat``

Com.Semantica.Dates.DateExtensions
----------------------------------

- ``AsDateMinute(DateDay)``
- ``AsDateMinute(DateDay, TimeSpan)``
- ``AsDateMillisecond(DateDay)``
- ``AsDateMillisecond(DateMinute)``
- ``AsDateMillisecond(DateDay, TimeSpan)``
- ``FloorToDay(DateMinute)``
- ``FloorToDay(DateMillisecond)``
- ``FloorToMinute(DateMillisecond)``

Com.Semantica.Dates.DateMillisecond
-----------------------------------

- ``AsNullableDateTime()``
- ``AsDateTime()``
- ``IsEmpty()``
- ``Serialize()``
- ``Deserialize(String)``
- ``CompareTo(DateMillisecond)``
- ``Equals(DateMillisecond)``
- ``ToString(String, IFormatProvider)``
- ``ToString()``
- ``Equals(Object)``
- ``GetHashCode()``
- ``op_Equality(DateMillisecond, DateMillisecond)``
- ``op_Inequality(DateMillisecond, DateMillisecond)``
- ``op_LessThan(DateMillisecond, DateMillisecond)``
- ``op_GreaterThan(DateMillisecond, DateMillisecond)``
- ``op_LessThanOrEqual(DateMillisecond, DateMillisecond)``
- ``op_GreaterThanOrEqual(DateMillisecond, DateMillisecond)``
- ``FromNullable(Nullable`1)``
- ``FromString(String)``
- ``.ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32)``
- ``.ctor(DateTime)``
- ``Empty``

Com.Semantica.Dates.DateMinute
------------------------------

- ``AsNullableDateTime()``
- ``AsDateTime()``
- ``Serialize()``
- ``Deserialize(String)``
- ``CompareTo(DateMinute)``
- ``Equals(DateMinute)``
- ``ToString(String, IFormatProvider)``
- ``ToString()``
- ``Equals(Object)``
- ``GetHashCode()``
- ``IsEmpty()``
- ``op_Equality(DateMinute, DateMinute)``
- ``op_Inequality(DateMinute, DateMinute)``
- ``op_LessThan(DateMinute, DateMinute)``
- ``op_GreaterThan(DateMinute, DateMinute)``
- ``op_LessThanOrEqual(DateMinute, DateMinute)``
- ``op_GreaterThanOrEqual(DateMinute, DateMinute)``
- ``FromNullable(Nullable`1)``
- ``FromString(String)``
- ``.ctor(Int32, Int32, Int32, Int32, Int32)``
- ``.ctor(DateTime)``
- ``Value``
- ``Empty``
- ``SerializationFormat``

Com.Semantica.Dates.DateProvider
--------------------------------

- ``CurrentDateMinute()``
- ``CurrentDateMillisecond()``
- ``CurrentDateDay()``
- ``InstanceCurrentDateMinute()``
- ``InstanceCurrentDateMillisecond()``
- ``InstanceCurrentDateDay()``
- ``.ctor()``

Com.Semantica.Dates.IDateProvider
---------------------------------

- ``CurrentDateDay()``
- ``CurrentDateMinute()``
- ``CurrentDateMillisecond()``
- ``InstanceCurrentDateMinute()``
- ``InstanceCurrentDateMillisecond()``
- ``InstanceCurrentDateDay()``

Com.Semantica.Dates.PartitionDate
---------------------------------

- ``Serialize()``
- ``IsEmpty()``
- ``Equals(PartitionDate)``
- ``Equals(Object)``
- ``GetHashCode()``
- ``ToString()``
- ``op_Equality(PartitionDate, PartitionDate)``
- ``op_Inequality(PartitionDate, PartitionDate)``
- ``Deserialize(String)``
- ``.ctor(Int32, Int32, Int32)``
- ``.ctor(PartitionDate)``
- ``.ctor(DateTime)``
- ``Year``
- ``Month``
- ``Day``
- ``HasYear``
- ``HasMonth``
- ``HasDay``
- ``Empty``

Com.Semantica.Dates.PartitionDateExtensions
-------------------------------------------

- ``AsDateTime(PartitionDate)``
- ``AsNullableDateTime(PartitionDate)``
- ``CalculateWholeYearsDifference(PartitionDate, PartitionDate)``
- ``CalculateWholeMonthsDifference(PartitionDate, PartitionDate)``
- ``CalculateTotalMonthsDifference(PartitionDate, PartitionDate)``


Semantica.Lib.Patterns.CanSerialize
======================================================================================================

Com.Semantica.Patterns.ICanSerialize
------------------------------------

- ``Serialize()``

Com.Semantica.Patterns.ICanSerialize`1
--------------------------------------

- ``Deserialize(String)``

Com.Semantica.Patterns.TypeConverters.CanSerializeOneWayTypeConverter`1
-----------------------------------------------------------------------

- ``CanConvertFrom(ITypeDescriptorContext, Type)``
- ``CanConvertTo(ITypeDescriptorContext, Type)``
- ``ConvertTo(ITypeDescriptorContext, CultureInfo, Object, Type)``
- ``.ctor()``

Com.Semantica.Patterns.TypeConverters.CanSerializeTypeConverter`1
-----------------------------------------------------------------

- ``CanConvertFrom(ITypeDescriptorContext, Type)``
- ``ConvertFrom(ITypeDescriptorContext, CultureInfo, Object)``
- ``.ctor()``

Com.Semantica.Patterns.JsonConverters.CanSerializeJsonConverter`1
-----------------------------------------------------------------

- ``Read(Utf8JsonReader&, Type, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Patterns.JsonConverters.CanSerializeJsonConverterFactory
----------------------------------------------------------------------

- ``CanConvert(Type)``
- ``CreateConverter(Type, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Patterns.JsonConverters.CanSerializeOneWayJsonConverter`1
-----------------------------------------------------------------------

- ``Read(Utf8JsonReader&, Type, JsonSerializerOptions)``
- ``Write(Utf8JsonWriter, TSerializable, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Patterns.Exceptions.DeserializationException
----------------------------------------------------------

- ``.ctor(Type, String)``
- ``.ctor(Type, String, String)``

Com.Semantica.Patterns.Exceptions.JsonDeserializationException
--------------------------------------------------------------

- ``.ctor(Type, String)``


Semantica.Lib.Types.SimpleInjector
=====================================================================================================

Com.Semantica.Dates.SimpleInjector.DateModule
---------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``RegisterDateProviderScoped(Container)``
- ``.ctor()``


Semantica.Lib.DI.SimpleInjector
==================================================================================================

Com.Semantica.Core.DI.ModuleExtensions
--------------------------------------

- ``RegisterTransientDisposable(Container, String)``


Semantica.Lib.Domain
=======================================================================================

Com.Semantica.Domain.DomainModelComparer`2
------------------------------------------

- ``Equals(TDomainModel, TDomainModel)``
- ``GetHashCode(TDomainModel)``
- ``.ctor()``

Com.Semantica.Domain.DomainModelExtensions
------------------------------------------

- ``FirstOrDefaultModel(IEnumerable`1, TKey)``
- ``SelectKeys(IEnumerable`1)``
- ``SelectModels(IEnumerable`1, IReadOnlyList`1)``
- ``ToKeyArray(IEnumerable`1)``
- ``ToKeyArray(IReadOnlyList`1)``
- ``ToKeyDictionary(IEnumerable`1)``

Com.Semantica.Domain.IDomainModel`1
-----------------------------------

- ``Key``

Com.Semantica.Domain.ValueTypes.EmailAddress
--------------------------------------------

- ``.ctor(String)``
- ``Value``

Com.Semantica.Domain.ValueTypes.FullName
----------------------------------------

- ``IsEmpty()``
- ``Equals(FullName)``
- ``Serialize()``
- ``Deserialize(String)``
- ``Equals(Object)``
- ``GetHashCode()``
- ``ToString()``
- ``FromString(String)``
- ``Create(String, String, String)``
- ``op_Equality(FullName, FullName)``
- ``op_Inequality(FullName, FullName)``
- ``.ctor(FullName)``
- ``Last``
- ``First``
- ``PrefixLast``
- ``Separator``

Com.Semantica.Domain.ValueTypes.Hash
------------------------------------

- ``GetValue()``
- ``IsEmpty()``
- ``ToString()``
- ``GetFirstNCharacters(Int32)``
- ``Equals(Hash)``
- ``Equals(Object)``
- ``GetHashCode()``
- ``<GetFirstNCharacters>g__SetChar|8_0(Byte, Int32, <>c__DisplayClass8_0&)``
- ``.ctor(Byte[])``
- ``Value``

Com.Semantica.Domain.UnitOfWork.IProcedureOfWork`1
--------------------------------------------------

- ``Call``

Com.Semantica.Domain.UnitOfWork.IUnitOfWork
-------------------------------------------

- ``CompleteAsync()``

Com.Semantica.Domain.UnitOfWork.IUnitOfWorkManager
--------------------------------------------------

- ``AttachWorkCompletedObserver(Action)``
- ``StartNew()``
- ``StartWorkProcedure(TCall)``

Com.Semantica.Domain.UnitOfWork.IWorkProcedureCall
--------------------------------------------------

- ``GetErrorMessages()``
- ``IsReady``
- ``IsExecuted``
- ``IsSuccess``

Com.Semantica.Domain.Repositories.IReadRepository`2
---------------------------------------------------

- ``Contains(TKey)``
- ``ContainsAsync(TKey)``
- ``GetAsync(TKey)``
- ``GetListAsync(IReadOnlyList`1)``
- ``GetListAsync(IEnumerable`1)``
- ``GetListInMatchingOrderAsync(IReadOnlyList`1)``
- ``GetListInMatchingOrderAsync(IEnumerable`1)``

Com.Semantica.Domain.Repositories.IRepository`4
-----------------------------------------------

- ``Replace(TDomainReplace)``
- ``ReplaceRange(IEnumerable`1)``

Com.Semantica.Domain.Repositories.ISimpleRepository`3
-----------------------------------------------------

- ``Add(TDomainAdd)``
- ``AddRange(IReadOnlyList`1)``
- ``AddRange(IEnumerable`1)``
- ``Remove(TKey)``
- ``RemoveRange(IEnumerable`1)``


Semantica.Lib.Domain.Data
============================================================================================

Com.Semantica.Domain.Data.Repositories.IPropertyAnalyser
--------------------------------------------------------

- ``GetOrAnalyse()``

Com.Semantica.Domain.Data.Repositories.IPropertyIdentifier
----------------------------------------------------------

- ``IsImmutableProperty(PropertyInfo)``

Com.Semantica.Domain.Data.Repositories.Implementations.PropertyAnalyser
-----------------------------------------------------------------------

- ``GetOrAnalyse()``
- ``.ctor(IPropertyIdentifier)``

Com.Semantica.Domain.Data.Repositories.Implementations.PropertyAnalysisResult
-----------------------------------------------------------------------------

- ``.ctor(IEnumerable`1)``
- ``ImmutableProperties``

Com.Semantica.Domain.Data.Repositories.Implementations.PropertyIdentifier
-------------------------------------------------------------------------

- ``IsImmutableProperty(PropertyInfo)``
- ``.ctor()``

Com.Semantica.Domain.Data.Repositories.Base.ReadRepositoryBase`3
----------------------------------------------------------------

- ``get__DataStore()``
- ``get__Converter()``
- ``Contains(TKey)``
- ``ContainsAsync(TKey)``
- ``GetAsync(TKey)``
- ``GetListAsync(IReadOnlyList`1)``
- ``GetListAsync(IEnumerable`1)``
- ``GetListInMatchingOrderAsync(IReadOnlyList`1)``
- ``GetListInMatchingOrderAsync(IEnumerable`1)``
- ``.ctor(IDataStore`2, IReadDomainStorageConverter`3)``
- ``_DataStore``
- ``_Converter``

Com.Semantica.Domain.Data.Repositories.Base.RepositoryBase`3
------------------------------------------------------------

- ``.ctor(IDataStore`2, ISeggregationDomainStorageConverter`6, IPropertyAnalyser)``

Com.Semantica.Domain.Data.Repositories.Base.RepositoryBase`6
------------------------------------------------------------

- ``get__Converter()``
- ``Replace(TDomainUpdate)``
- ``ReplaceRange(IEnumerable`1)``
- ``.ctor(IDataStore`2, ISeggregationDomainStorageConverter`6, IPropertyAnalyser)``
- ``_Converter``

Com.Semantica.Domain.Data.Repositories.Base.SimpleRepositoryBase`4
------------------------------------------------------------------

- ``get__PropertyNames()``
- ``get__Converter()``
- ``Add(TDomainAdd)``
- ``AddRange(IReadOnlyList`1)``
- ``AddRange(IEnumerable`1)``
- ``Remove(TKey)``
- ``RemoveRange(IEnumerable`1)``
- ``.ctor(IDataStore`2, ISimpleDomainStorageConverter`4, IPropertyAnalyser)``
- ``_PropertyNames``
- ``_Converter``

Com.Semantica.Domain.Data.DomainStorageConverters.ConverterExtensions
---------------------------------------------------------------------

- ``ToStorage(ISeggregationDomainStorageConverter`3, TDomainConfined)``

Com.Semantica.Domain.Data.DomainStorageConverters.IAggregationDomainStorageConverter`2
--------------------------------------------------------------------------------------

- ``ToAggregation(TStorage)``

Com.Semantica.Domain.Data.DomainStorageConverters.IAggregationExpansionConverter`3
----------------------------------------------------------------------------------

- ``ToAggregationExpansion(TStorage)``
- ``SetCommonModelProperties(TExpansionBase, TStorage)``

Com.Semantica.Domain.Data.DomainStorageConverters.IExpansionConverter`3
-----------------------------------------------------------------------

- ``ToExpansion(TStorage)``
- ``ToAddendum(TSegregationExpansion)``

Com.Semantica.Domain.Data.DomainStorageConverters.IReadDomainStorageConverter`3
-------------------------------------------------------------------------------

- ``ToSegregation(TStorage)``

Com.Semantica.Domain.Data.DomainStorageConverters.ISeggregationDomainStorageConverter`6
---------------------------------------------------------------------------------------

- ``ToStorage(TDomainReplace)``
- ``SetStorageProperties(TStorage, TDomainBase)``

Com.Semantica.Domain.Data.DomainStorageConverters.ISimpleDomainStorageConverter`4
---------------------------------------------------------------------------------

- ``ToStorage(TDomainAdd)``

Com.Semantica.Domain.Data.DomainStorageConverters.IStorageDuplicator`1
----------------------------------------------------------------------

- ``ToCopy(TStorage)``


Semantica.Lib.Order
======================================================================================

Com.Semantica.Order.EnumerableOrderExtensions
---------------------------------------------

- ``OrderBy(IEnumerable`1, Order`2)``
- ``ThenBy(IOrderedEnumerable`1, Order`2)``
- ``OrderByConditional(IEnumerable`1, Order`2)``
- ``OrderByThenByConditional(IEnumerable`1, Order`2, Order`2)``

Com.Semantica.Order.ListOrderExtensions
---------------------------------------

- ``OrderByConditional(IReadOnlyList`1, Order`2)``
- ``OrderByThenByConditional(IReadOnlyList`1, Order`2, Order`2)``

Com.Semantica.Order.Order`2
---------------------------

- ``Descending()``
- ``.ctor(Expression`1, Boolean)``
- ``Func``
- ``OrderDescending``
- ``None``

Com.Semantica.Order.Order
-------------------------

- ``By(Expression`1)``

Com.Semantica.Order.QueryableOrderExtensions
--------------------------------------------

- ``OrderBy(IQueryable`1, Order`2)``
- ``ThenBy(IOrderedQueryable`1, Order`2)``
- ``OrderByConditional(IQueryable`1, Order`2)``
- ``OrderByThenByConditional(IQueryable`1, Order`2, Order`2)``


Semantica.Lib.Storage
========================================================================================

Com.Semantica.Storage.IKeyConverter`2
-------------------------------------

- ``ToKey(TStorage)``
- ``ToBlankStorageModel(TKey)``

Com.Semantica.Storage.Models.IAddendum`1
----------------------------------------

- ``Exists``
- ``OwnerId``

Com.Semantica.Storage.Models.IAddendum`2
----------------------------------------

- ``Owner``

Com.Semantica.Storage.Models.IIdentity`1
----------------------------------------

- ``Id``

Com.Semantica.Storage.Models.Base.AddendumBase`1
------------------------------------------------

- ``.ctor()``

Com.Semantica.Storage.Models.Base.AddendumBase`2
------------------------------------------------

- ``.ctor()``
- ``Exists``
- ``OwnerId``
- ``Owner``

Com.Semantica.Storage.Inclusions.IInclusion`1
---------------------------------------------

- ``AddIncludesTo(IQueryable`1)``
- ``RegisterQueryResult(TStorage)``
- ``RegisterQueryResult(IEnumerable`1)``
- ``NextInclusion``
- ``QueryResults``

Com.Semantica.Storage.Inclusions.QueryableInclusionExtensions
-------------------------------------------------------------

- ``Include(IQueryable`1, IInclusion`1)``
- ``IncludeIfNotNull(IQueryable`1, IInclusion`1)``

Com.Semantica.Storage.DataStores.IAggregateDataStore`2
------------------------------------------------------

- ``RetrieveAggregationAsync(TAggregateKey)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1)``
- ``RetrieveManyAggregationAsync(IReadOnlyList`1)``
- ``RetrieveManyAggregationAsync(IReadOnlyList`1, IInclusion`1)``

Com.Semantica.Storage.DataStores.IAggregateDataStoreInternal`2
--------------------------------------------------------------

- ``RetrieveAggregationAsync(TAggregateKey, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, Order`2, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1, Order`2, Order`2)``

Com.Semantica.Storage.DataStores.IAggregatePredicateProvider`2
--------------------------------------------------------------

- ``MatchesAggregateKey(TAggregateKey)``
- ``MatchesAnyAggregateKey(IReadOnlyList`1)``

Com.Semantica.Storage.DataStores.IDataStore`2
---------------------------------------------

- ``Exists(TKey)``
- ``ExistsAsync(TKey)``
- ``Retrieve(TKey)``
- ``Retrieve(TKey, IInclusion`1)``
- ``Retrieve(Expression`1)``
- ``Retrieve(Expression`1, IInclusion`1)``
- ``RetrieveAsync(TKey)``
- ``RetrieveAsync(TKey, IInclusion`1)``
- ``RetrieveAsync(Expression`1)``
- ``RetrieveAsync(Expression`1, IInclusion`1)``
- ``RetrieveManyAsync(IReadOnlyList`1)``
- ``RetrieveManyAsync(IReadOnlyList`1, IInclusion`1)``
- ``Insert(TStorage)``
- ``InsertMany(IEnumerable`1)``
- ``Update(TStorage)``
- ``Update(TStorage, IEnumerable`1)``
- ``UpdateColumns(TStorage, IEnumerable`1)``
- ``Delete(TKey)``
- ``Delete(TStorage)``
- ``ExecuteProcedureAsync(IProcedure`2, TIn)``
- ``ExecuteProcedure(IProcedure`2, TIn)``
- ``UpdateColumns(TStorage, String, String[])``

Com.Semantica.Storage.DataStores.IIdentityPredicateProvider`2
-------------------------------------------------------------

- ``MatchesAny(IReadOnlyList`1)``

Com.Semantica.Storage.DataStores.IPredicateProvider`2
-----------------------------------------------------

- ``IsMatch(TKey)``

Com.Semantica.Storage.DataStores.IProcedure`2
---------------------------------------------

- ``Name``

Com.Semantica.Storage.DataStores.IStorageCache`2
------------------------------------------------

- ``TryGet(TKey, TStorage&)``
- ``Cache(TKey, TStorage)``
- ``Flush()``
- ``Invalidate(TKey)``

Com.Semantica.Storage.DataStores.WorkResult
-------------------------------------------

- ``.ctor()``
- ``Success``
- ``Message``
- ``AffectedId``

Com.Semantica.Storage.Attributes.ImmutableAttribute
---------------------------------------------------

- ``.ctor()``


Semantica.Lib.Domain.Data.SimpleInjector
===========================================================================================================

Com.Semantica.Domain.Data.SimpleInjector.DomainModule
-----------------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``.ctor()``


Semantica.Lib.Intervals
==========================================================================================

Com.Semantica.Intervals.EmptyUnbindsInterval`1
----------------------------------------------

- ``IsEmpty()``
- ``IsLeftBounded()``
- ``IsRightBounded()``
- ``.ctor(T, T)``
- ``.ctor(IInterval`1)``

Com.Semantica.Intervals.HalfOpenInterval`1
------------------------------------------

- ``IsDegenerate()``
- ``IsEmpty()``
- ``IsLeftBounded()``
- ``IsLeftOpen()``
- ``IsRightBounded()``
- ``IsRightOpen()``
- ``ToString()``
- ``Equals(IInterval`1)``
- ``Equals(Object)``
- ``GetHashCode()``
- ``Make(T, T)``
- ``.ctor(T, T)``
- ``.ctor(T, T, Boolean)``
- ``.ctor(IInterval`1)``
- ``Left``
- ``Right``

Com.Semantica.Intervals.IInterval`1
-----------------------------------

- ``IsDegenerate()``
- ``IsLeftBounded()``
- ``IsLeftOpen()``
- ``IsRightBounded()``
- ``IsRightOpen()``
- ``Left``
- ``Right``

Com.Semantica.Intervals.IntervalDictionary`2
--------------------------------------------

- ``IntervalsAscending()``
- ``IntervalsDescending()``
- ``TryGet(TKey, TValue&)``
- ``TryGetInterval(TKey, IInterval`1&)``
- ``Add(IInterval`1, TValue)``
- ``.ctor()``
- ``.ctor(IEnumerable`1)``
- ``.ctor(IEnumerable`1)``
- ``Intervals``
- ``Values``
- ``Item``
- ``Item``

Com.Semantica.Intervals.IntervalDictionaryExtensions
----------------------------------------------------

- ``GetIntervalWithLeft(IReadOnlyIntervalDictionary`2, TKey)``
- ``TryGetIntervalWithLeft(IReadOnlyIntervalDictionary`2, TKey, IInterval`1&)``

Com.Semantica.Intervals.IntervalEnumerationExtensions
-----------------------------------------------------

- ``AggregateIntervals(IEnumerable`1)``
- ``AddIntervals(IEnumerable`1)``
- ``ToLowerboundIntervalPairs(IEnumerable`1, Func`2, TKey)``
- ``ToLowerboundIntervalTuples(IEnumerable`1, Func`2, TKey)``
- ``ToLowerboundIntervalTuples(IEnumerable`1, Func`3, Func`2, TKey)``

Com.Semantica.Intervals.IntervalExtensions
------------------------------------------

- ``Convert(IInterval`1, Func`2)``
- ``Equals(IInterval`1, IInterval`1)``
- ``Extend(IInterval`1, IInterval`1)``
- ``IsAnyLeftOf(IInterval`1, IInterval`1)``
- ``IsAnyLeftOf(IInterval`1, TValue)``
- ``IsAnyRightOf(IInterval`1, IInterval`1)``
- ``IsAnyRightOf(IInterval`1, TValue)``
- ``IsLeftOf(TValue, IInterval`1)``
- ``IsLeftOf(IInterval`1, IInterval`1)``
- ``IsRightOf(TValue, IInterval`1)``
- ``IsRightOf(IInterval`1, IInterval`1)``
- ``IsWithin(TValue, IInterval`1)``
- ``IsWithin(IInterval`1, IInterval`1)``
- ``Overlaps(IInterval`1, IInterval`1)``
- ``TryDegenerateValue(IInterval`1, T&)``
- ``SpansDomain(IInterval`1)``
- ``Extend(IEnumerable`1)``
- ``ToIntervalDictionary(IEnumerable`1)``

Com.Semantica.Intervals.IReadOnlyIntervalDictionary`2
-----------------------------------------------------

- ``IntervalsAscending()``
- ``IntervalsDescending()``
- ``Intervals``
- ``Values``
- ``Item``
- ``Item``

Com.Semantica.Intervals.IIntervalDictionary`2
---------------------------------------------

- ``TryGet(TKey, TValue&)``
- ``TryGetInterval(TKey, IInterval`1&)``

Com.Semantica.Intervals.TargetInterval`1
----------------------------------------

- ``IsEmpty()``
- ``IsDegenerate()``
- ``IsLeftBounded()``
- ``IsLeftOpen()``
- ``IsRightBounded()``
- ``IsRightOpen()``
- ``.ctor(T, T)``
- ``IsDetermined``
- ``TargetValue``
- ``Margin``
- ``Left``
- ``Right``


Semantica.Lib.Mvc
====================================================================================

Com.Semantica.Mvc.Types.CheapDictionary
---------------------------------------

- ``GetEnumerator()``
- ``Add(KeyValuePair`2)``
- ``Clear()``
- ``Contains(KeyValuePair`2)``
- ``CopyTo(KeyValuePair`2[], Int32)``
- ``Remove(KeyValuePair`2)``
- ``ContainsKey(String)``
- ``Add(String, Object)``
- ``Remove(String)``
- ``TryGetValue(String, Object&)``
- ``.ctor(IReadOnlyList`1)``
- ``Count``
- ``IsReadOnly``
- ``Item``
- ``Item``
- ``Keys``
- ``Values``

Com.Semantica.Mvc.Types.CssClass
--------------------------------

- ``ToString()``
- ``IsEmpty()``
- ``op_Addition(CssClass, CssClass)``
- ``op_Addition(CssClass, Nullable`1)``
- ``op_Addition(CssClass, String)``
- ``Add(String)``
- ``.ctor(String[])``
- ``Length``
- ``Classes``
- ``Empty``

Com.Semantica.Mvc.Types.DataAttr
--------------------------------

- ``Contains(String)``
- ``ToString()``
- ``IsEmpty()``
- ``op_Addition(DataAttr, DataAttr)``
- ``Make(String, Object)``
- ``DataNameToAttribute(String)``
- ``ToDataAttribute(KeyValuePair`2)``
- ``.ctor(String, Object)``
- ``Length``
- ``Values``
- ``Empty``

Com.Semantica.Mvc.Extensions.RouteValuesExtensions
--------------------------------------------------

- ``ToDictionary(RouteValues)``

Com.Semantica.Mvc.Extensions.SelectListExtensions
-------------------------------------------------

- ``WithBlankOption(IEnumerable`1, String)``
- ``ToSelectList(IEnumerable`1, T)``
- ``ToOptionTag(SelectListItem)``
- ``<ToSelectList>g__GetKeySerialized|1_1(T)``

Com.Semantica.Mvc.ActionFilters.BadRequestOnInvalidModelAttribute
-----------------------------------------------------------------

- ``OnActionExecuting(ActionExecutingContext)``
- ``.ctor()``

Com.Semantica.Mvc.ActionFilters.Extensions.FilterRegistrationExtensions
-----------------------------------------------------------------------

- ``AddBadRequestOnInvalidModel(FilterCollection)``


Semantica.Lib.Storage.Data
=============================================================================================

Com.Semantica.Storage.Data.StorageCache`2
-----------------------------------------

- ``TryGet(TKey, TEntity&)``
- ``Cache(TKey, TEntity)``
- ``Flush()``
- ``Invalidate(TKey)``
- ``.ctor(IUnitOfWorkManager)``


Semantica.Lib.Storage.Data.SimpleInjector
============================================================================================================

Com.Semantica.Storage.Data.SimpleInjector.StorageModule
-------------------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``.ctor()``


Semantica.Lib.Storage.EntityFramework
========================================================================================================

Com.Semantica.Storage.EntityFramework.Procedures.IProcedureParameters
---------------------------------------------------------------------

- ``AddParams``

Com.Semantica.Storage.EntityFramework.Procedures.ProcedureDefinition`2
----------------------------------------------------------------------

- ``.ctor(ProcedureId)``
- ``Id``
- ``Name``

Com.Semantica.Storage.EntityFramework.Procedures.ProcedureId
------------------------------------------------------------

- ``IsEmpty()``
- ``ToString()``
- ``Equals(ProcedureId)``
- ``Equals(Object)``
- ``GetHashCode()``
- ``.ctor(String, String, String)``
- ``Name``
- ``Namespace``
- ``Schema``

Com.Semantica.Storage.EntityFramework.Procedures.WorkProcedureDefinition`1
--------------------------------------------------------------------------

- ``.ctor(ProcedureId)``

Com.Semantica.Storage.EntityFramework.Procedures.Extensions.StoredProcBuilderExtensions
---------------------------------------------------------------------------------------

- ``AddParams``

Com.Semantica.Storage.EntityFramework.Procedures.Base.WorkProcedureCallBase`2
-----------------------------------------------------------------------------

- ``GetDefinition()``
- ``GetParams()``
- ``CheckSetParams()``
- ``ProcessResults(IReadOnlyList`1)``
- ``ExecuteOnContextAsync(DbContext)``
- ``ExecuteOnContext(DbContext)``
- ``GetErrorMessages()``
- ``CreateProcedureOfWork(DbContext, Action)``
- ``.ctor()``
- ``IsReady``
- ``IsExecuted``
- ``IsSuccess``

Com.Semantica.Storage.EntityFramework.Inclusions.InclusionPrototype`2
---------------------------------------------------------------------

- ``MakeInclusion()``
- ``MakeInclusion(IInclusion`1)``
- ``.ctor(Expression`1, Action`1)``
- ``IncludeExpression``
- ``NullAssignmentAction``

Com.Semantica.Storage.EntityFramework.Implementations.UnitOfWork.UnitOfWorkManager
----------------------------------------------------------------------------------

- ``StartNew()``
- ``StartWorkProcedure(TCall)``
- ``AttachWorkCompletedObserver(Action)``
- ``NotifyWorkComplete()``
- ``.ctor(IDbContextProvider)``
- ``_onWorkCompletedObservers``
- ``_workCompleted``

Com.Semantica.Storage.EntityFramework.Implementations.DataStores.AggregateDataStore`2
-------------------------------------------------------------------------------------

- ``get__Cache()``
- ``get__PredicateProvider()``
- ``get__DbSet()``
- ``get__Query()``
- ``RetrieveAggregationAsync(TAggregateKey)``
- ``RetrieveAggregationAsync(TAggregateKey, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, Order`2, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1, Order`2)``
- ``RetrieveAggregationAsync(TAggregateKey, IInclusion`1, Order`2, Order`2)``
- ``RetrieveManyAggregationAsync(IReadOnlyList`1)``
- ``RetrieveManyAggregationAsync(IReadOnlyList`1, IInclusion`1)``
- ``.ctor(IDbContextProvider, IStorageCache`2, IAggregatePredicateProvider`2)``
- ``_Cache``
- ``_PredicateProvider``
- ``_DbSet``
- ``_Query``

Com.Semantica.Storage.EntityFramework.Implementations.DataStores.DataStore`2
----------------------------------------------------------------------------

- ``get__Cache()``
- ``get__KeyConverter()``
- ``get__PredicateProvider()``
- ``get__DbSet()``
- ``get__Query()``
- ``Exists(TKey)``
- ``ExistsAsync(TKey)``
- ``Retrieve(TKey)``
- ``Retrieve(TKey, IInclusion`1)``
- ``Retrieve(Expression`1)``
- ``Retrieve(Expression`1, IInclusion`1)``
- ``RetrieveAsync(TKey)``
- ``RetrieveAsync(TKey, IInclusion`1)``
- ``RetrieveAsync(Expression`1)``
- ``RetrieveAsync(Expression`1, IInclusion`1)``
- ``RetrieveManyAsync(IReadOnlyList`1)``
- ``RetrieveManyAsync(IReadOnlyList`1, IInclusion`1)``
- ``Insert(TStorage)``
- ``InsertMany(IEnumerable`1)``
- ``Update(TStorage)``
- ``Update(TStorage, IEnumerable`1)``
- ``UpdateColumns(TStorage, IEnumerable`1)``
- ``UpdateColumns(TStorage, String, String[])``
- ``Delete(TKey)``
- ``Delete(TStorage)``
- ``ExecuteProcedureAsync(IProcedure`2, TIn)``
- ``ExecuteProcedure(IProcedure`2, TIn)``
- ``SetPropertyModifiedState(TStorage, IEnumerable`1, Boolean)``
- ``.ctor(IDbContextProvider, IStorageCache`2, IKeyConverter`2, IPredicateProvider`2)``
- ``_Cache``
- ``_KeyConverter``
- ``_PredicateProvider``
- ``_DbSet``
- ``_Query``

Com.Semantica.Storage.EntityFramework.Implementations.DataStores.IdentityDataStore`2
------------------------------------------------------------------------------------

- ``get__IdentityPredicateProvider()``
- ``RetrieveManyAsync(IReadOnlyList`1)``
- ``RetrieveManyAsync(IReadOnlyList`1, IInclusion`1)``
- ``.ctor(IDbContextProvider, IStorageCache`2, IKeyConverter`2, IIdentityPredicateProvider`2)``
- ``_IdentityPredicateProvider``

Com.Semantica.Storage.EntityFramework.Implementations.Context.DbContextFactory
------------------------------------------------------------------------------

- ``CreateDbContext()``
- ``.ctor(DbContextOptions`1)``

Com.Semantica.Storage.EntityFramework.Implementations.Context.DbContextFactory`1
--------------------------------------------------------------------------------

- ``CreateAppDbContext()``
- ``CreateDbContext()``
- ``.ctor(DbContextOptions`1)``

Com.Semantica.Storage.EntityFramework.Implementations.Context.DbContextProvider
-------------------------------------------------------------------------------

- ``ResetContext()``
- ``Dispose()``
- ``.ctor(IDbContextFactory)``
- ``ActiveContext``

Com.Semantica.Storage.EntityFramework.Extensions.DbContextExtention
-------------------------------------------------------------------

- ``ExecuteProcedureAsync(DbContext, IProcedure`2, TIn)``
- ``ExecuteProcedure(DbContext, IProcedure`2, TIn)``

Com.Semantica.Storage.EntityFramework.Context.IDbContextFactory
---------------------------------------------------------------

- ``CreateDbContext()``

Com.Semantica.Storage.EntityFramework.Context.IDbContextFactory`1
-----------------------------------------------------------------

- ``CreateAppDbContext()``

Com.Semantica.Storage.EntityFramework.Context.IDbContextProvider
----------------------------------------------------------------

- ``ResetContext()``
- ``ActiveContext``

Com.Semantica.Storage.EntityFramework.Context.Base.DbContextBase
----------------------------------------------------------------

- ``GetStorageModelAssembly()``
- ``OnModelCreating(ModelBuilder)``
- ``.ctor(DbContextOptions)``

Com.Semantica.Storage.EntityFramework.Config.ColumnNameHelper
-------------------------------------------------------------

- ``MakeName(String, String)``

Com.Semantica.Storage.EntityFramework.Config.ConfigTypes
--------------------------------------------------------

- ``Decimal(Int32, Int32)``
- ``Date()``

Com.Semantica.Storage.EntityFramework.Config.StorageEntityConfiguration
-----------------------------------------------------------------------

- ``ConfigureStorageModels(ModelBuilder, Assembly)``

Com.Semantica.Storage.EntityFramework.Config.Extensions.EntityTypeBuilderExtensions
-----------------------------------------------------------------------------------

- ``OwnsOneConfigured(EntityTypeBuilder`1, OwnedConfigBase`2)``

Com.Semantica.Storage.EntityFramework.Config.Extensions.OwnedNavigationBuilderExtensions
----------------------------------------------------------------------------------------

- ``HasOneToManyOwned(OwnedNavigationBuilder`2, Expression`1, Expression`1, Expression`1)``
- ``OwnsOneConfigured(OwnedNavigationBuilder`2, OwnedConfigBase`2)``
- ``PropertyOwned(OwnedNavigationBuilder`2, Expression`1, Expression`1)``

Com.Semantica.Storage.EntityFramework.Config.Extensions.PropertyBuilderExtensions
---------------------------------------------------------------------------------

- ``HasOwnedColumnName(PropertyBuilder`1, Expression`1, String)``
- ``HasOwnedColumnName(PropertyBuilder`1, String, String)``
- ``HasPrecision(PropertyBuilder`1, Int32, Int32)``
- ``HasPrecision(PropertyBuilder`1, Byte, Byte)``
- ``IsDateOnly(PropertyBuilder`1)``
- ``IsDateOnly(PropertyBuilder`1)``

Com.Semantica.Storage.EntityFramework.Config.Base.AddendumConfigBase`2
----------------------------------------------------------------------

- ``Configure(OwnedNavigationBuilder`2)``
- ``.ctor(Expression`1)``

Com.Semantica.Storage.EntityFramework.Config.Base.EntityConfigBase`1
--------------------------------------------------------------------

- ``get__Builder()``
- ``Configure(EntityTypeBuilder`1)``
- ``OnModelBuilding()``
- ``.ctor()``
- ``_Builder``

Com.Semantica.Storage.EntityFramework.Config.Base.IdentityAddendumConfigBase`2
------------------------------------------------------------------------------

- ``Configure(OwnedNavigationBuilder`2)``
- ``.ctor(Expression`1)``

Com.Semantica.Storage.EntityFramework.Config.Base.NestedAddendumConfigBase`2
----------------------------------------------------------------------------

- ``Configure(OwnedNavigationBuilder`2)``
- ``.ctor(Expression`1)``

Com.Semantica.Storage.EntityFramework.Config.Base.OwnedConfigBase`2
-------------------------------------------------------------------

- ``get__Builder()``
- ``Configure(OwnedNavigationBuilder`2)``
- ``OnModelBuilding()``
- ``.ctor(Expression`1)``
- ``_Builder``
- ``NavigationExpression``

Com.Semantica.Storage.EntityFramework.Config.Base.OwnedTypeConfigBase`2
-----------------------------------------------------------------------

- ``Configure(OwnedNavigationBuilder`2)``
- ``HasData(TOwnedType[])``
- ``HasData(Object[])``
- ``.ctor(Expression`1)``


Semantica.Lib.Storage.EntityFramework.SimpleInjector
=======================================================================================================================

Com.Semantica.Storage.EntityFramework.SimpleInjector.ModuleExtensions
---------------------------------------------------------------------

- ``RegisterDbContext(Container)``
- ``RegisterDbContextFactory(Container)``
- ``RegisterDefaultDbContextFactory(Container)``

Com.Semantica.Storage.EntityFramework.SimpleInjector.StorageEntityFrameworkModule
---------------------------------------------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``.ctor()``


Semantica.Lib.TestTools.Core
===============================================================================================

Com.Semantica.TestTools.Core.ValueTypes.ComparableCanBeEmpty
------------------------------------------------------------

- ``IsEmpty()``
- ``CompareTo(ComparableCanBeEmpty)``
- ``.ctor(Nullable`1)``

Com.Semantica.TestTools.Core.Assertions.AssertExtensions
--------------------------------------------------------

- ``AreWithinEpsilon``
- ``AreWithinEpsilon``
- ``AreWithinEpsilon``
- ``AreWithinEpsilon``
- ``AreCorrectBounds``
- ``IsEmpty``
- ``IsNotEmpty``
- ``StartsWith``
- ``AreEqual``
- ``AreNotEqual``

Com.Semantica.TestTools.Core.Assertions.CheckAssertExtensions
-------------------------------------------------------------

- ``IsOfKind``
- ``IsNotValid``
- ``IsValid``

Com.Semantica.TestTools.Core.Assertions.ValueTypeAssertExtensions
-----------------------------------------------------------------

- ``AreEqualValue``
- ``AreEqualValue``
- ``AreEqualValue``


Semantica.Lib.TestTools.SimpleInjector
=========================================================================================================

Com.Semantica.TestTools.Core.SimpleInjector.Tests.ModuleTest`1
--------------------------------------------------------------

- ``RegisterInvertedDependencies()``
- ``Init()``
- ``Register_Verify_DoesNotThrow()``
- ``RegisterAsMock()``
- ``.ctor()``
- ``_Sut``
- ``_Container``


Semantica.Lib.Trees
======================================================================================

Com.Semantica.Trees.IArrayTreeNode`1
------------------------------------

- ``ChildIndices``
- ``Index``
- ``ParentIndex``
- ``OffspringCount``

Com.Semantica.Trees.IAscendantTreeNode`1
----------------------------------------

- ``GetOffspringCount()``
- ``ChildNodes``

Com.Semantica.Trees.IDescendantTreeNode`1
-----------------------------------------

- ``GetAncestorCount()``
- ``IsRoot()``
- ``ParentNode``

Com.Semantica.Trees.IGrowingTree`1
----------------------------------

- ``AddChildNode(ITreeNode`1, T)``

Com.Semantica.Trees.IMorphologicTree`1
--------------------------------------

- ``RootNode``

Com.Semantica.Trees.IPartialTreeNode`1
--------------------------------------

- ``Owner``

Com.Semantica.Trees.IReadOnlyTreePath`1
---------------------------------------

- ``Depth``
- ``Nodes``
- ``RootNode``
- ``UltimateNode``

Com.Semantica.Trees.ITreeNode`1
-------------------------------

- ``Owner``

Com.Semantica.Trees.ITreeNodeProperties`1
-----------------------------------------

- ``IsLeaf()``
- ``Payload``
- ``Level``

Com.Semantica.Trees.ITreePathNode`1
-----------------------------------

- ``Owner``
- ``NextNode``

Com.Semantica.Trees.TreeConverterAddition
-----------------------------------------

- ``ConvertTree(IReadOnlyTree`1, Func`2, Func`2)``
- ``<ConvertTree>g__AddChildNodesRecursive|0_0(ITreeNode`1, ITreeNode`1, <>c__DisplayClass0_0`2&)``

Com.Semantica.Trees.JsonConverters.MorphologicTreeJsonConverter`2
-----------------------------------------------------------------

- ``Read(Utf8JsonReader&, Type, JsonSerializerOptions)``
- ``Write(Utf8JsonWriter, IReadOnlyMorphologicTree`2, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Trees.JsonConverters.PartialTreeJsonConverter`1
-------------------------------------------------------------

- ``Read(Utf8JsonReader&, Type, JsonSerializerOptions)``
- ``Write(Utf8JsonWriter, IReadOnlyPartialTree`1, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Trees.JsonConverters.TreeJsonConverter`1
------------------------------------------------------

- ``Read(Utf8JsonReader&, Type, JsonSerializerOptions)``
- ``Write(Utf8JsonWriter, IReadOnlyTree`1, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Trees.JsonConverters.TreeJsonConverterFactory
-----------------------------------------------------------

- ``CanConvert(Type)``
- ``CreateConverter(Type, JsonSerializerOptions)``
- ``.ctor()``

Com.Semantica.Trees.Implementations.GrowingTree`1
-------------------------------------------------

- ``AddChildNode(ITreeNode`1, T)``
- ``IsEmpty()``
- ``GetEnumerator()``
- ``CopyToNew(Func`2)``
- ``.ctor(T, Int32)``
- ``RootNode``
- ``Count``
- ``Item``

Com.Semantica.Trees.Implementations.PartialTree`1
-------------------------------------------------

- ``IsEmpty()``
- ``GetEnumerator()``
- ``CopyToNew(Func`2)``
- ``.ctor(IReadOnlyList`1)``
- ``.ctor(IEnumerable`1, Int32)``
- ``RootNode``
- ``Count``
- ``Item``

Com.Semantica.Trees.Implementations.PartialTreeNode`1
-----------------------------------------------------

- ``GetAncestorCount()``
- ``GetOffspringCount()``
- ``IsLeaf()``
- ``IsRoot()``
- ``DuplicateFor(Func`2)``
- ``.ctor(IReadOnlyPartialTree`1, IArrayTreeNode`1)``
- ``ChildIndices``
- ``ChildNodes``
- ``Index``
- ``Level``
- ``OffspringCount``
- ``ParentIndex``
- ``Payload``
- ``Owner``
- ``ParentNode``

Com.Semantica.Trees.Implementations.TreeNode`1
----------------------------------------------

- ``GetAncestorCount()``
- ``GetOffspringCount()``
- ``IsLeaf()``
- ``IsRoot()``
- ``get_Index()``
- ``get_ParentIndex()``
- ``get_ChildIndices()``
- ``Unleaf(Int32)``
- ``DuplicateFor(GrowingTree`1, TOut)``
- ``.ctor(IReadOnlyTree`1, T, Int32, Int32, Int32)``
- ``Owner``
- ``Payload``
- ``ChildNodes``
- ``Level``
- ``ParentNode``
- ``Index``
- ``ParentIndex``
- ``ChildIndices``

Com.Semantica.Trees.Implementations.TreePath`1
----------------------------------------------

- ``GetEnumerator()``
- ``MakePathFromTreeNode(TNode)``
- ``.ctor(IReadOnlyList`1)``
- ``Depth``
- ``Count``
- ``Nodes``
- ``RootNode``
- ``UltimateNode``
- ``Item``

Com.Semantica.Trees.Implementations.TreePathNode`1
--------------------------------------------------

- ``GetAncestorCount()``
- ``IsLeaf()``
- ``IsRoot()``
- ``IsUltimate()``
- ``GetEnumerator()``
- ``.ctor(TreePath`1, Int32, T, Boolean)``
- ``Index``
- ``IsLeafNode``
- ``Owner``
- ``Payload``
- ``Level``
- ``IsRootNode``
- ``NextNode``
- ``ParentNode``

Com.Semantica.Trees.Extensions.TreeExtensions
---------------------------------------------

- ``TryFind(IMorphologicTree`1, Func`2, TNode&)``
- ``Find(IMorphologicTree`1, Func`2)``
- ``EnumerateDepthFirst(IMorphologicTree`1)``

Com.Semantica.Trees.Extensions.TreeNodeExtensions
-------------------------------------------------

- ``EnumerateAncestors(TNode)``
- ``EnumerateOffspring(TNode)``
- ``EnumerateOffspring(TNode, Func`2)``
- ``EnumerateOffspringUntil(TNode, Func`2)``
- ``EnumerateOffspringWhere(TNode, Func`2)``
- ``IndexOf(TNode)``
- ``IsLeaf(TNode)``
- ``IsRoot(TNode)``
- ``MakeTreePath(ITreeNode`1)``
- ``Payloads(IEnumerable`1)``
- ``SiblingCount(ITreeNode`1)``

Com.Semantica.Trees.Extensions.TreePathExtensions
-------------------------------------------------

- ``FirstNonDefaultFromUltimate(IReadOnlyTreePath`1, Func`2)``
- ``FirstOrDefaultFromUltimate(IReadOnlyTreePath`1, Func`2)``

Com.Semantica.Trees.Converter.IPartialTreeConverter`2
-----------------------------------------------------

- ``Convert(IReadOnlyPartialTree`1)``

Com.Semantica.Trees.Converter.IPayloadConverter`2
-------------------------------------------------

- ``ConvertPayload(TNode)``

Com.Semantica.Trees.Converter.ITreeConverter`2
----------------------------------------------

- ``Convert(IReadOnlyTree`1)``

Com.Semantica.Trees.Converter.PartialTreeConverter`2
----------------------------------------------------

- ``Convert(IReadOnlyPartialTree`1)``
- ``ConvertTree(IReadOnlyPartialTree`1, Func`2)``
- ``.ctor(IPayloadConverter`2)``

Com.Semantica.Trees.Converter.TreeConverter`2
---------------------------------------------

- ``Convert(IReadOnlyTree`1)``
- ``ConvertTree(IReadOnlyTree`1, Func`2)``
- ``.ctor(IPayloadConverter`2)``

Com.Semantica.Trees.Builder.ITreeBuilder`1
------------------------------------------

- ``GrowTree(IRetrievalCollection`1)``

Com.Semantica.Trees.Builder.ITreeBuildPredicateProvider`1
---------------------------------------------------------

- ``IsRoot(T)``
- ``IsChildOf(T, T)``
- ``UseOrdering()``
- ``OrderChildrenBy(T)``

Com.Semantica.Trees.Builder.PartialTreeBuilder
----------------------------------------------

- ``MakeSubTree(TNode, Int32, Func`2)``
- ``<MakeSubTree>g__TraverseChildNodesRecursive|0_0(TNode, Int32, <>c__DisplayClass0_0`3&)``
- ``ProtoNode`1``

Com.Semantica.Trees.Builder.TreeBuilder`1
-----------------------------------------

- ``GrowTree(IRetrievalCollection`1)``
- ``GrowTree(IRetrievalCollection`1, Func`2, Func`3)``
- ``GrowTree(IRetrievalCollection`1, Func`2, Func`3, Func`2)``
- ``.ctor(ITreeBuildPredicateProvider`1)``

Com.Semantica.Trees.Builder.TreeBuilderException
------------------------------------------------

- ``.ctor(String, Exception)``
- ``.ctor(String)``


Semantica.Lib.Trees.SimpleInjector
=====================================================================================================

Com.Semantica.Trees.SimpleInjector.TreeModule
---------------------------------------------

- ``GetDependencyAssemblies()``
- ``RegisterModuleImplementation(Container)``
- ``.ctor()``


