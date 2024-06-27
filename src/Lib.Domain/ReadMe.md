# Semantica.Lib.Domain
This package is part of the design packages of Semantica.Lib.

### Summary

Provides a number of interfaces, types and attributes that can be used to make your domain-level entity classes more expressive.
Also defines a number of interfaces that provide a unitofwork/repository pattern. This package contains only the types that 
represent the highest level of abstraction, making it possible to hide your storage layer models and interfaces from your 
domain-level logic.

### Usage

This package is meant to be used in tandem with the implementations that are provided in the **Semantica.Lib.Domain.Data**
package, which in turn is dependent on the abstractions provided in the interfaces for a storage layer provided in the 
**Semantica.Lib.Storage** package. 

The **Semantica.Lib.Storage.Data** and **Semantica.Lib.Storage.EntityFramework** provide implementations of the storage
interfaces, thus completely hiding the specifics of your storage layer to your domain layer, making it completely independent.

It's possible to a different ORM-framework than EntityFramework by making an implementation of the ``IDataStore`` interface 
for your framework/provider of choice, and have zero impact on the domain layer of your application. 

## Dependencies

- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Extensions
- Semantica.Lib.Linq
- Semantica.Lib.Patterns
- Semantica.Lib.Patterns.Converters
