# Semantica.Lib.Checks
This package is part of the core packages of Semantica.Lib.

### Summary

A library that provides types and statics to streamline guards and validations. The ``Chk`` and ``Chk<T>`` value types provide
boolean-like behaviour but can be combined with a reason and/or a payload. ``Guard`` static methods throws exceptions when 
checks fail.

## Contents

### *type* Chk

Contains the ``Chk`` and ``Chk<T>`` types. These types can be thought of and manipulated as boolean types, but can also contain 
a (string) Reason, and in the case of the generic version, a Payload. Chk is used to streamline sequential checks by leveraging 
short-circuiting of boolean operators. This results in more elegant and consistently structured validation methods. The Reason 
can be used for either feedback or debugging purposes to make apparent why validation fails when there are multiple checks done.
Payload can be used to return other types of additional information such as associated keys. There is also a non-determined 
outcome of Chk that is only a reason (``Chk.Rsn``) and/or a payload (``Chk.Pld``) associated with either a pass or a fail, that 
can be &&-ed or ||-ed onto a determined Pass/Fail. Through that mechanism reason and payload-creation can also be skipped using
short-circuiting when not applicable.

``Chk`` and ``Chk<T>`` can be implicitly cast to each other, although obviously payload will be lost when casting to the 
non-generic version. This can be done explicitly with the ``Simplify()`` method, or ``Simplify(out T)`` if you want to use the
payload locally. There are operator overloads for and/or where the left operand is ``Chk`` and the right operand and result are
``Chk<T>``, but short-circuiting is only possible in C# when both operands are of the same type, so can only be used as the 
bitwise, non short-circuit operators.

Using a non-determined (``IsDetermined=false``) instance with reason or payloads as the right hand side of and/or operators will
result in an exception when the wrong operator is used for the wrong Pass-value. i.e. Fail reasons can only be or-ed, Pass
reasons can only be and-ed.

As an optional safety feature, ``HasPassed()`` and ``HasFailed()`` can be used when evaluating the validation. The boolean value
of an undetermined reason for pass will still be true (as will the ``Pass`` property), but ``HasPassed()`` will only return 
true when ``Pass`` and ``IsDetermined`` are true. ``HasFailed()`` will also return true when ``IsDetermined`` is false. This is
for safety concerns, so a check will not pass when a non-determined instance is accidentally returned.  

### *static* Guard & Check

Provide more elegant method of implementing guards in your methods. The ``Guard`` static methods throws exceptions if a guard is
not satisfied. By using the ``Check`` static methods that return ``Chk<CheckKind>`` values, a more comprehensive error message 
is generated than with the standard if/throw ArgumentException.

## Examples

### Chk
Most basic validation with short circuiting - condition 2 is only evaluated if condition 1 is true.

```csharp
Chk validation = Chk.If(condition1) && Chk.If(condition2)
if (validation.HasPassed()) 
{
    //do work
}
```

Validation with basic reason.

```csharp
Chk validation = Chk.If(condition1).Fails("condition 1 was not satisfied.")
if (validation.HasPassed()) 
{
    //do work
}
else return Conflict(validation.Reason);
```

Validation with reason short-cicuiting.

```csharp
Chk validation = Chk.If(condition1) || Chk.Rsn.ForFail($"condition 1 on entity {(await GetEntity(key)).Name} was not satisfied.")
if (validation.HasPassed()) 
{
    //do work
}
else return Conflict(validation.Reason);
```

Name validation that returns the matching key.

```csharp
public Chk<Key> ValidateName(string name) 
{
    var entity = await GetEntityByName(name);
    Chk validation = Chk.If(entity != null).Fails($"No entity with name '{name}' not found.")
        && Chk.If(entity.IsActive).Fails($"Entity with key {entity.Key} that matches name '{name}' is not active.");
    return Chk.WithPld(entity.Key);
}
```

Same name validation, but where the payload is only retrieved if previous validations passed.

```csharp
public Chk<Key> ValidateName(string name) 
{
    var entity = await GetEntityByName(name);
    Chk<Key> validation = Chk.If(entity != null).Fails($"No entity with name '{name}' not found.");
    return validation && Chk.Pld.ForPass(await GetAssociatedEntityKey(entity));
}
```

Subsequent validation chaining with payload reuse

```csharp
var validation = ValidateName(name).Simplify(out Key key) && ValidateSystemState(key);
if (validation.HasFailed()) 
    return Conflict(validation.Reason);
    
//do work
```
