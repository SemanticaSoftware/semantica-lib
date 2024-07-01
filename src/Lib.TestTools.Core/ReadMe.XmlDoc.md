<a name='assembly'></a>
# Lib.TestTools.Core

## Contents

- [ChkAssertExtensions](#T-Semantica-TestTools-Core-Assertions-ChkAssertExtensions 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions')
  - [HasFailed()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasFailed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasFailed(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [HasPassed()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasPassed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasPassed(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [HasPayload\`\`1()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasPayload``1(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.Chk{``0},System.String)')
  - [HasReason()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasReason(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsDetermined()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsDetermined-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsDetermined(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsFail()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFail-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsFail(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsFailPayload\`\`1()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFailPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsFailPayload``1(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.Chk{``0},System.String)')
  - [IsFailReason()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFailReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsFailReason(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsPass()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPass-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsPass(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsPassPayload\`\`1()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPassPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsPassPayload``1(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.Chk{``0},System.String)')
  - [IsPassReason()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPassReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsPassReason(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
  - [IsUndetermined()](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsUndetermined-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.IsUndetermined(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)')
- [ModuleTestBase\`1](#T-Semantica-TestTools-Core-ModuleTestBase`1 'Semantica.TestTools.Core.ModuleTestBase`1')
  - [Sut](#F-Semantica-TestTools-Core-ModuleTestBase`1-Sut 'Semantica.TestTools.Core.ModuleTestBase`1.Sut')
  - [Act()](#M-Semantica-TestTools-Core-ModuleTestBase`1-Act-System-Boolean- 'Semantica.TestTools.Core.ModuleTestBase`1.Act(System.Boolean)')
  - [Assert()](#M-Semantica-TestTools-Core-ModuleTestBase`1-Assert 'Semantica.TestTools.Core.ModuleTestBase`1.Assert')
  - [Initialize()](#M-Semantica-TestTools-Core-ModuleTestBase`1-Initialize 'Semantica.TestTools.Core.ModuleTestBase`1.Initialize')
  - [RegisterAsMock\`\`1()](#M-Semantica-TestTools-Core-ModuleTestBase`1-RegisterAsMock``1 'Semantica.TestTools.Core.ModuleTestBase`1.RegisterAsMock``1')
  - [RegisterInvertedDependencies()](#M-Semantica-TestTools-Core-ModuleTestBase`1-RegisterInvertedDependencies 'Semantica.TestTools.Core.ModuleTestBase`1.RegisterInvertedDependencies')
  - [Register_Verify_DoesNotThrow()](#M-Semantica-TestTools-Core-ModuleTestBase`1-Register_Verify_DoesNotThrow 'Semantica.TestTools.Core.ModuleTestBase`1.Register_Verify_DoesNotThrow')
- [TestDateTimeProvider](#T-Semantica-TestTools-Core-Mocks-TestDateTimeProvider 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider')
  - [#ctor(utcNow)](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.#ctor(System.DateTime)')
  - [#ctor(utcNow,timezoneId)](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-String- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.#ctor(System.DateTime,System.String)')
  - [#ctor(utcNow,fixedOffset)](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-TimeSpan- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.#ctor(System.DateTime,System.TimeSpan)')
  - [#ctor(utcNow,timezone)](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-TimeZoneInfo- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.#ctor(System.DateTime,System.TimeZoneInfo)')
  - [SetUtcNow(dateTime)](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-SetUtcNow-System-DateTime- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.SetUtcNow(System.DateTime)')

<a name='T-Semantica-TestTools-Core-Assertions-ChkAssertExtensions'></a>
## ChkAssertExtensions `type`

##### Namespace

Semantica.TestTools.Core.Assertions

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasFailed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### HasFailed() `method`

##### Summary

Asserts if the `chk` is a determined [Fail](#P-Semantica-Checks-Chk-Fail 'Semantica.Checks.Chk.Fail').

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasPassed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### HasPassed() `method`

##### Summary

Asserts if the `chk` is a determined [Pass](#P-Semantica-Checks-Chk-Pass 'Semantica.Checks.Chk.Pass').

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String-'></a>
### HasPayload\`\`1() `method`

##### Summary

Asserts if the `chk` contains a non-default payload.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### HasReason() `method`

##### Summary

Asserts if the `chk` contains a reason.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsDetermined-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsDetermined() `method`

##### Summary

Asserts if the `chk` is determined.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFail-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsFail() `method`

##### Summary

Asserts if the `chk` is a [Fail](#P-Semantica-Checks-Chk-Fail 'Semantica.Checks.Chk.Fail').

##### Parameters

This method has no parameters.

##### Remarks

Caution! Does not check if the chk is determined. Always use Assert.[HasFailed](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasFailed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasFailed(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)') unless you specifically
do not want the [IsDetermined](#P-Semantica-Patterns-IDeterminable-IsDetermined 'Semantica.Patterns.IDeterminable.IsDetermined') assert.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFailPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String-'></a>
### IsFailPayload\`\`1() `method`

##### Summary

Asserts if the `chk` is an undetermined [Fail](#P-Semantica-Checks-Chk-Fail 'Semantica.Checks.Chk.Fail') with a payload.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsFailReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsFailReason() `method`

##### Summary

Asserts if the `chk` is an undetermined [Fail](#P-Semantica-Checks-Chk-Fail 'Semantica.Checks.Chk.Fail') with a reason.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPass-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsPass() `method`

##### Summary

Asserts if the `chk` is a [Pass](#P-Semantica-Checks-Chk-Pass 'Semantica.Checks.Chk.Pass').

##### Parameters

This method has no parameters.

##### Remarks

Caution! Does not check if the chk is determined. Always use Assert.[HasFailed](#M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-HasFailed-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String- 'Semantica.TestTools.Core.Assertions.ChkAssertExtensions.HasFailed(Microsoft.VisualStudio.TestTools.UnitTesting.Assert,Semantica.Checks.IChk,System.String)') unless you specifically
do not want the [IsDetermined](#P-Semantica-Patterns-IDeterminable-IsDetermined 'Semantica.Patterns.IDeterminable.IsDetermined') assert.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPassPayload``1-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-Chk{``0},System-String-'></a>
### IsPassPayload\`\`1() `method`

##### Summary

Asserts if the `chk` is an undetermined [Pass](#P-Semantica-Checks-Chk-Pass 'Semantica.Checks.Chk.Pass') with a payload.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsPassReason-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsPassReason() `method`

##### Summary

Asserts if the `chk` is an undetermined [Pass](#P-Semantica-Checks-Chk-Pass 'Semantica.Checks.Chk.Pass') with a reason.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-Assertions-ChkAssertExtensions-IsUndetermined-Microsoft-VisualStudio-TestTools-UnitTesting-Assert,Semantica-Checks-IChk,System-String-'></a>
### IsUndetermined() `method`

##### Summary

Asserts if the `chk` is undetermined.

##### Parameters

This method has no parameters.

<a name='T-Semantica-TestTools-Core-ModuleTestBase`1'></a>
## ModuleTestBase\`1 `type`

##### Namespace

Semantica.TestTools.Core

<a name='F-Semantica-TestTools-Core-ModuleTestBase`1-Sut'></a>
### Sut `constants`

##### Summary

System under test. Has to be assigned during construction or initialization of the test class.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-Act-System-Boolean-'></a>
### Act() `method`

##### Summary

Performs the Act part of the generic test. Call from [Register_Verify_DoesNotThrow](#M-Semantica-TestTools-Core-ModuleTestBase`1-Register_Verify_DoesNotThrow 'Semantica.TestTools.Core.ModuleTestBase`1.Register_Verify_DoesNotThrow').

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-Assert'></a>
### Assert() `method`

##### Summary

Performs the Assert parts of the generic test. Call from [Register_Verify_DoesNotThrow](#M-Semantica-TestTools-Core-ModuleTestBase`1-Register_Verify_DoesNotThrow 'Semantica.TestTools.Core.ModuleTestBase`1.Register_Verify_DoesNotThrow').

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the test. Call before [Act](#M-Semantica-TestTools-Core-ModuleTestBase`1-Act-System-Boolean- 'Semantica.TestTools.Core.ModuleTestBase`1.Act(System.Boolean)');

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-RegisterAsMock``1'></a>
### RegisterAsMock\`\`1() `method`

##### Summary

Registers a generic mock to represent a dependency that is always implemented in an upstream module.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDependency | Type to register a generic mock for. |

##### Remarks

Use in the override of the [RegisterInvertedDependencies](#M-Semantica-TestTools-Core-ModuleTestBase`1-RegisterInvertedDependencies 'Semantica.TestTools.Core.ModuleTestBase`1.RegisterInvertedDependencies') method.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-RegisterInvertedDependencies'></a>
### RegisterInvertedDependencies() `method`

##### Summary

Override this method to registers all dependencies that are always implemented in a module that is upstream from the
context of this module. Note that any implementations registered here always have to be registered, otherwise the
runtime (verification) will fail. The registrations added here effectively create unavoidable "blind spots" for the
unit test verification.

##### Parameters

This method has no parameters.

<a name='M-Semantica-TestTools-Core-ModuleTestBase`1-Register_Verify_DoesNotThrow'></a>
### Register_Verify_DoesNotThrow() `method`

##### Summary

Test method to be called by the unittesting framework.

##### Parameters

This method has no parameters.

##### Remarks

Should call [Act](#M-Semantica-TestTools-Core-ModuleTestBase`1-Act-System-Boolean- 'Semantica.TestTools.Core.ModuleTestBase`1.Act(System.Boolean)') and [Assert](#M-Semantica-TestTools-Core-ModuleTestBase`1-Assert 'Semantica.TestTools.Core.ModuleTestBase`1.Assert') for the test to
work.

<a name='T-Semantica-TestTools-Core-Mocks-TestDateTimeProvider'></a>
## TestDateTimeProvider `type`

##### Namespace

Semantica.TestTools.Core.Mocks

##### Summary

Provides an implementation of [IDateTimeProvider](#T-Semantica-Core-Providers-IDateTimeProvider 'Semantica.Core.Providers.IDateTimeProvider') that can be set fixed to a specific time. Can be used as a
mock in other tests.

<a name='M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime-'></a>
### #ctor(utcNow) `constructor`

##### Summary

Initializes [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow') with the provided value, and a fixed timezone "W. Europe Standard Time".

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcNow | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The fixed value for [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow'). |

<a name='M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-String-'></a>
### #ctor(utcNow,timezoneId) `constructor`

##### Summary

Initializes [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow') with the provided value, and a timezone identified by `timezoneId`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcNow | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The fixed value for [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow'). |
| timezoneId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id (an OS-specific identifier string) of the time zone to be used. |

<a name='M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-TimeSpan-'></a>
### #ctor(utcNow,fixedOffset) `constructor`

##### Summary

Initializes [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow') with the provided value, and a fixed timezone offset (no DST).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcNow | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The fixed value for [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow'). |
| fixedOffset | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The fixed value for [Offset](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-Offset-System-DateTime- 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.Offset(System.DateTime)'). |

<a name='M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-#ctor-System-DateTime,System-TimeZoneInfo-'></a>
### #ctor(utcNow,timezone) `constructor`

##### Summary

Initializes [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow') with the provided value, and a provided timezone.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcNow | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The fixed value for [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow'). |
| timezone | [System.TimeZoneInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeZoneInfo 'System.TimeZoneInfo') | An instance of [TimeZoneInfo](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-TimeZoneInfo 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.TimeZoneInfo') to be used. |

<a name='M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-SetUtcNow-System-DateTime-'></a>
### SetUtcNow(dateTime) `method`

##### Summary

Not part of [IDateTimeProvider](#T-Semantica-Core-Providers-IDateTimeProvider 'Semantica.Core.Providers.IDateTimeProvider') interface implementation. Can set Now after construction.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The new value of [UtcNow](#M-Semantica-TestTools-Core-Mocks-TestDateTimeProvider-UtcNow 'Semantica.TestTools.Core.Mocks.TestDateTimeProvider.UtcNow') |
