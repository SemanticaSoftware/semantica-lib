# Semantica.Lib.TestTools.Core
This package is part of the testing packages of Semantica.Lib.

### Summary

Provides a set of specific MSTest.Assert extensions (``Assert.That.``), to facilitate more compact assertions, and more
comprehensive fail messages. Assertions include epsilon-checking for floating point types, default/empty checking for enums, 
strings, ``ICanBeEmpty``, etc., DateOnly/DateTime part assertions, as well as assertions for the **Semantica.Lib.Checks.Chk** 
type.
Also contains a convenient mock for ``Semantica.Lib.Core.Providers.IDateTimeProvider``, and ``ModuleTestBase``, an abstract base
class to facilitate making unit tests for DI modules based on ``Semantica.Lib.Core.DependencyInjection.ModuleBase``.

## Contents

### ModuleTestBase

This abstract base class is just a framework to make a generic unittest base class. Two expansions of this base class have been
provided in **Semantica.Lib.TestTools.SimpleInjector** that leverage SimpleInjector to verify registrations that are done with
either ``SimpleInjector.Container`` or ``System.Extensions.DependencyInjection.IServiceCollection`` (or a mix of both). When
using a different DI container, it could be helpful to base your unit test base class on that code.     

## Dependencies

- Moq
- MSTest.TestFramework
- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Extensions
- Semantica.Lib.Patterns
- Semantica.Lib.Types
