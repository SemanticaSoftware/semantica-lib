# Semantica.Lib.Types
This package is part of the core packages of Semantica.Lib.

### Summary

A library that provides several value types and extensions for those types. This includes but is not limited to
``DateSpan``, ``EmailAddress``, ``Hash``, ``Link``, ``RouteValues``. These simple stucts can make your models and
method signatures more readable/expressive, and be useful to write extensions.       

Includes ``Converters.TypeConverterRestistrations``, a helper that can dynamically add typeconverter attributes to
types, eliminating the requirement to have your typeconverter classes in the same project as the types they can 
convert, acting on the ``IRunTimeTypeConverter`` interface. 

Provides types and helpers for code keys, a compact, human-readable encoding of integers. 

## Dependencies

- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Extensions
- Semantica.Lib.Linq
- Semantica.Lib.Patterns
- Semantica.Lib.Patterns.Converters
