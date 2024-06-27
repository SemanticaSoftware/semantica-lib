# Semantica.Lib.Storage.EntityFramework
This package is part of the design packages of Semantica.Lib.

### Summary

Provides implementations for the abstractions provided by **Semantica.Lib.Storage** that are dependent on EntityFramework. 
Has implementations for ``IDataStore`` (as base classes) for entities with or without simple keys, ``IInclusion``, and
``IUnitOfWork``. To use the datastore base classes, implementations of ``IPredicateProvider`` and ``IKeyConverter`` will have
to be provided for the entity. For the other dependencies the provided standard implementations can be used.

The provided ``Module`` can be used to register all generic implementations. The ``RegisterDbContextFactory()`` extension method
can be used to register the application's ``DbContext``.

Also contains extensions for EntityTypeBuilder and PropertyBuilder to help with EntityFramework configuration. 

## Dependencies

- Microsoft.EntityFrameworkCore
- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Domain
- Semantica.Lib.Extensions
- Semantica.Lib.Linq
- Semantica.Lib.Ordering
- Semantica.Lib.Patterns
- Semantica.Lib.Storage
- Semantica.Lib.Storage.Data
- StoredProcedureEFCore
