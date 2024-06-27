# Semantica.Lib.Core
This package is part of the core packages of Semantica.Lib.

### Summary

Contains many basic helpers and base classes, useful in most C#.NET Framework projects. Including an injectable
``DateTimeProvider``, base classes for compact type converters and json converters, and a generic dependency 
injection module base class to streamline splitting your registrations per module. 

## Contents

### Statics

#### Comparable 
A collection of methods for types that implement ``IComparable<T>``, or to aide in the implementation of ``Compare`` methods of
a ``IComparable<T>`` or ``IComparer<T>``implementation.

#### DateTimeConstant
Exposes many constants that exists only as privates on the native ``DateTime``, like the amount of ticks for certain units of
time, the amount of days in each month, etc. Also provides a few basic methods for date calculations.

#### Logic
Provides a number of methods that implement logical operators on a variable number of (boolean) parameters.

#### StaticSelectors
A few simple selector functions used elsewhere in the library.

### Base classes

#### StringTypeConverterBase
A base class used to streamline making TypeConverter classes for simple value types that map to a single string-based value. 
Having a TypeConverter for your value type means that you can use that type in AspMvc route or querystring parameters. 

Semantica.Lib.Types.Converter.TypeConverterRegistration can be used to add the TypeConverterAttribute to a type 
programmatically, which removes the necessity to have the TypeConverter in the same project as the type, and allows for adding
TypeConverters for external types.

#### DependencyInjection.ModuleBase<T>
A base class for defining dependency injection module classes in your projects. An implementation of this module can define the
assemblies and/or modules it's dependent on, and the registrations that the implementations that the code module provides. The
container type is the generic parameter for the base class, making it possible to use it with any DI-container package that
supports code-based registrations, as well as the standard ``IServiceCollection``.

#### DependencyInjection.ServiceCollectionExtensions
An extension method for IServiceCollection, typically used in a Program.cs, that adds all registrations of an implemetation of 
``ModuleBase<IServiceCollection>``, as well as those in all of the modules it depends on.

#### Json.JsonConverterBase
Contains a number of nested abstract classes used to streamline making JsonConverter classes for simple value types that map to
a single json value. There is a generic base class, as well as a specific base class for each value type System.Text.Json 
supports reading/writing.

#### Json.StringConverterBase
A base class to streamline making JsonConverter classes for value types that are representable as a string value.is a generic
base class, as well as a specific base class for each value type System.Text.Json supports reading/writing.

### Injectables

#### Providers.IDateTimeProvider
Provides a number of methods that are usually called as static methods on ``DateTime``, ``DateTimeOffset`` or ``DateOnly``, 
such as ``Now()``, ``Today()``, etc. Using an injected interface for this rather than the static methods makes it possible to
make much better unit tests.

#### Providers.DateTimeProvider
A default implementation of ``IDateTimeProvider``. Implementations depend on each other as much as possible, making it possible
to make a custom implementation that used this as a base class, and by only overriding the TimeZoneInfo method all other methods
will use a different timezone than the default ``System.TimeZoneInfo.Local``, or override ``UtcNow()`` to make all methods use a
different (remote) time.
Core.Module can be used to register the implementation with the``IServiceCollection``.
**Semantica.Lib.TestTools.Core** package contains an implementation that can be set to a datetime value on instantiation, for
unittesting purposes. 

#### Providers.ISnapshotDateTimeProvider
Inherits from ``IDateTimeProvider``, and adds a single reset-method. 

#### Providers.SnapshotDateTimeProvider
Provides the same functionality as ``DateTimeProvider``, but will remember the time that a method that uses the 
current time is first called. All subsequent calls will use that remembered time when calculating their output, until the Reset 
method is called. This can be used to make sure all methods requiring the current time use the exact same value without needing
to pass that value around between them.
Core.Module can be used to register the implementation with the``IServiceCollection`` as a Scoped registration.
