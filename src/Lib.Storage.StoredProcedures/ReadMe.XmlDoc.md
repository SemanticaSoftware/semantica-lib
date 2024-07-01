<a name='assembly'></a>
# Lib.Storage.StoredProcedures

## Contents

- [DbContextExtention](#T-Semantica-Storage-StoredProcedures-DbContextExtention 'Semantica.Storage.StoredProcedures.DbContextExtention')
- [IProcedureOfWork\`1](#T-Semantica-Storage-StoredProcedures-IProcedureOfWork`1 'Semantica.Storage.StoredProcedures.IProcedureOfWork`1')
- [IProcedureParameters](#T-Semantica-Storage-StoredProcedures-IProcedureParameters 'Semantica.Storage.StoredProcedures.IProcedureParameters')
- [IUnitOfWorkProcedureManager](#T-Semantica-Storage-StoredProcedures-IUnitOfWorkProcedureManager 'Semantica.Storage.StoredProcedures.IUnitOfWorkProcedureManager')
- [IWorkProcedureCall](#T-Semantica-Storage-StoredProcedures-IWorkProcedureCall 'Semantica.Storage.StoredProcedures.IWorkProcedureCall')
- [Module](#T-Semantica-Storage-StoredProcedures-Module 'Semantica.Storage.StoredProcedures.Module')
- [ProcedureDefinition\`2](#T-Semantica-Storage-StoredProcedures-ProcedureDefinition`2 'Semantica.Storage.StoredProcedures.ProcedureDefinition`2')
- [ProcedureOfWork\`2](#T-Semantica-Storage-StoredProcedures-ProcedureOfWork`2 'Semantica.Storage.StoredProcedures.ProcedureOfWork`2')
- [StoredProcBuilderExtensions](#T-Semantica-Storage-StoredProcedures-StoredProcBuilderExtensions 'Semantica.Storage.StoredProcedures.StoredProcBuilderExtensions')
- [UnitOfWorkProcedureManager](#T-Semantica-Storage-StoredProcedures-UnitOfWorkProcedureManager 'Semantica.Storage.StoredProcedures.UnitOfWorkProcedureManager')
- [WorkProcedureCallBase\`2](#T-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2 'Semantica.Storage.StoredProcedures.WorkProcedureCallBase`2')
  - [CheckSetParams()](#M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-CheckSetParams 'Semantica.Storage.StoredProcedures.WorkProcedureCallBase`2.CheckSetParams')
  - [GetParams()](#M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-GetParams 'Semantica.Storage.StoredProcedures.WorkProcedureCallBase`2.GetParams')
  - [ProcessResults()](#M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-ProcessResults-System-Collections-Generic-IReadOnlyList{Semantica-Storage-WorkResult}- 'Semantica.Storage.StoredProcedures.WorkProcedureCallBase`2.ProcessResults(System.Collections.Generic.IReadOnlyList{Semantica.Storage.WorkResult})')
- [WorkProcedureDefinition\`1](#T-Semantica-Storage-StoredProcedures-WorkProcedureDefinition`1 'Semantica.Storage.StoredProcedures.WorkProcedureDefinition`1')

<a name='T-Semantica-Storage-StoredProcedures-DbContextExtention'></a>
## DbContextExtention `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-IProcedureOfWork`1'></a>
## IProcedureOfWork\`1 `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-IProcedureParameters'></a>
## IProcedureParameters `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-IUnitOfWorkProcedureManager'></a>
## IUnitOfWorkProcedureManager `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-IWorkProcedureCall'></a>
## IWorkProcedureCall `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Summary

Interfaces that inherit from this Interface should add some kind of SetParameters method that set all required procedure parameters in domain types

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-Module'></a>
## Module `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Summary

Module that registers implementations of:

The module is dependent on implementations in the [](#N-Semantica-Storage 'Semantica.Storage').[](#N-Semantica-Storage-EntityFramework 'Semantica.Storage.EntityFramework')
assembly.

<a name='T-Semantica-Storage-StoredProcedures-ProcedureDefinition`2'></a>
## ProcedureDefinition\`2 `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-ProcedureOfWork`2'></a>
## ProcedureOfWork\`2 `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-StoredProcBuilderExtensions'></a>
## StoredProcBuilderExtensions `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-UnitOfWorkProcedureManager'></a>
## UnitOfWorkProcedureManager `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='T-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2'></a>
## WorkProcedureCallBase\`2 `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Summary

Types that inherit from this base class should contain the logic that transforms domain types into the database types of

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCall | The proper type of the work procedure call |
| TParams | The type of the work procedure parameter object |

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.

<a name='M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-CheckSetParams'></a>
### CheckSetParams() `method`

##### Summary

Call this method from the custom SetParameter method of the base class, or from the constructor if there are no parameters.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-GetParams'></a>
### GetParams() `method`

##### Summary

In the implementation of this method the parameters

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Semantica-Storage-StoredProcedures-WorkProcedureCallBase`2-ProcessResults-System-Collections-Generic-IReadOnlyList{Semantica-Storage-WorkResult}-'></a>
### ProcessResults() `method`

##### Summary

Override to add custom processing of results.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Storage-StoredProcedures-WorkProcedureDefinition`1'></a>
## WorkProcedureDefinition\`1 `type`

##### Namespace

Semantica.Storage.StoredProcedures

##### Remarks

This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
