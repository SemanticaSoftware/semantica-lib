# Semantica.Lib.Domain.Data
This package is part of the design packages of Semantica.Lib.

### Summary

Provides (base class) implementations of the repository interfaces from **Semantica.Lib.Domain**. These implementations generally 
assume a strict separation between the domain-level entity models and storable counterparts used in the storage (persistence) 
layer. For this, the repository base classes are dependent on injected implementations of the converter interfaces also provided
in this package. The repository base is also dependent on an injected ``IDataStore`` for the entity's storage type, and a 
``IPropertyAnalyser`` which is used to identify immutable properties on the storable model. Those properties will be ignored 
when doing replaces/updates using the default implementations. The package provides a default implementation for this interface
that utilizes the ``ImmutableAttribute`` from the ``Semantica.Lib.Storage.Attributes`` namespace.

The repository base classes will implement all standard ``IRepository`` members, while additional required custom members can be
easily added.  

### Usage

For each storable entity in your system, a repository is probably wanted. 

If this separation is unwanted, there is a generic implementation ``DomainIsStorageConverter`` that just passes the input back 
to the output.

## Dependencies

- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Domain
- Semantica.Lib.Extensions
- Semantica.Lib.Linq
- Semantica.Lib.Patterns
- Semantica.Lib.Patterns.Converters
- Semantiva.Lib.Storage
