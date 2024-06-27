# Semantica.Lib.Storage
This package is part of the design packages of Semantica.Lib.

### Summary

Provides interfaces and types for usage with your storage models, as well as abstractions used to build on the 
patterns included in **Semantica.Lib.Domain** and base classes from **Semantica.Lib.Domain.Data**. This package is independent 
of those packages, so can be included in a storage layer that can be completely independent of your domain layer. 
The abstractions are also independent of a specific ORM-framework, but were designed with EntityFramework in mind.

Implementations for the abstractions provided in this package are provided in the **Semantica.Lib.Storage.Data** and
**Semantica.Lib.Storage.EntityFramework** packages.

## Dependencies

- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Extensions
- Semantica.Lib.Linq
- Semantica.Lib.Ordering
- Semantica.Lib.Patterns
