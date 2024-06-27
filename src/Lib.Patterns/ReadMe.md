# Semantica.Lib.Patterns
This package is part of the core packages of Semantica.Lib.

### Summary

Contains several basic interfaces generally usable for value types or data structure classes. 
Also contains a collection of extensions that work on (collections of) those interfaces. 

## Contents

### IApproximable
A struct or class can implement ``IApproximable`` when it's sometimes useful to know if different values are approximate, but
other situations require a more strict concept of equality.

### IArithmatic
A struct or class can implement ``IArithmatic`` when it's possible to have basic arithmatic operations on instances. 
.NET 7 introduced static interfaces for the same purpose, so this interface will become obsolete when .NET 6 gets deprecated. 

### ICanBeEmpty
A struct or class can implement ``ICanBeEmpty`` when there is some (inescapable) default value that can be thought of
as empty. Because many, many simple types or data structures have this inherit empty value, having a universal method to 
assertain that (By implementing/using a ``bool IsEmpty()`` method) can be very useful. Also, this allows for   

### ICanSerialize
A struct or class can implement ``ICanSerialize`` when it can be serialized to a string without losing any relevant information.
If a type also supports deserialization, use the generic ``ICanSerialize<TSelf>``.
The package **Semantica.Lib.Patterns.Converters** contains JsonConverters and TypeConverters that will be able to generically
convert any type implementing these interfaces.

### IDeterminable
A struct or class can implement ``IDeterminable`` when it has no clear undetermined state, but there is need for one.
This can be particularly useful for value types when an explicit undetermined state is more clear than or functionally useful
besides having a System.Nullable or null value.   

## Domain (key) interfaces

These interfaces should be used on simple value types (readonly structs) that represent a (unique) key of some entity.
A typical simple key would be a database generated id (integer), or a guid. By wrapping your keys in a simple struct types for
each of your entities, you can make your method signatures much clearer, and it will be much easier to change the key later on.
The (Simple-) datastore implementations in Semantica.Lib.Storage.Data do not require these interfaces to be present on key 
types, but the conditions for using them are the same (having simple keys: 
[Wiki: Unique key](https://en.wikipedia.org/wiki/Unique_key)).  


### Domain.IIdKey&lt;T&gt;
A struct (or class) can implement ``IIdKey`` when the key consists of one property with the name ``Id``. The type of the 
property is generic, and can be any ``IEquatable<T>`` ``struct``. While the interface obviously is unable to enforce this, the
idea is that it's only used for simple keys. 

### Domain.IIdentityKey
A struct (or class) can implement ``IIdentityKey`` when it's an ``IdKey``, and the type of the ``Id`` property is integer.
Typically representing an auto-incrementing primary key. 

### Domain.ISimpleKey&lt;T, TSelf&gt;
A struct can implement ``ISimpleKey`` when it is the same as ``IdKey``, but adds ``AsNullableId`` and ``FromNullableId`` conversion
methods.

### Domain.IIdentityKey&lt;TSelf&gt;
A struct (or class) can implement ``IIdentityKey<TSelf>`` when it's a ``ISimpleKey``, and the type of the ``Id`` property is
integer.

### Domain.ISubKey&lt;TKey&gt;
A key that is a subkey has only one property, the inner key. The identity of the sub-entity is always the same as
the principal, although not every key of the principal wil be a valid subkey. 
Subkeys are used for dependent entities with a 0..1 to 1 relationship to their principle, that have a primary key which is also
the foreign key. 

## Extensions

Several extension method classes that provide generic functionality for types that implement the pattern interfaces.

### CanBeEmptyExtensions
A set of extension methods that work for any instance of a type that implements ``ICanBeEmpty``.

#### CanBeEmptyToNullable
Returns a (struct) value as a ``Nullable<T>``, having the default (null-equivalent) value when it's empty. 

#### IfNotEmpty
Applies a transform function to a ``ICanBeEmpty`` value, if the value is not empty. There are several overloads of this method
to handle struct/class nullablity of the output types correctly.

#### NullOnEmpty
If the value is empty, returns null, otherwise returns the second provided value. There are several overloads of this method
to handle struct/class nullablity of the output types correctly.

### CanBeEmptyCollectionExtensions
A set of extension methods that work for collenctions of instances of a type that implements ``ICanBeEmpty``.

#### FirstNonEmpty
For ``IEnumerable<T>`` where T implements ``ICanBeEmpty``. Returns the first non-empty element in the enumeration.

#### GetValue
For ``IReadOnlyDictionary<TKey,TValue>`` where TKey implements ``ICanBeEmpty``. Returns ``default(TValue)`` if the provided key 
is empty. Will attempt to retrieve the value normally from the dictionary if not. Throws if a non-empty key is not found. 

#### WhereNotEmpty
For ``IEnumerable<T>`` where T implements ``ICanBeEmpty``. Yields all non-empty elements in the enumeration.
