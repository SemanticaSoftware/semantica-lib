<a name='assembly'></a>
# Lib.Checks

## Contents

- [Check](#T-Semantica-Checks-Check 'Semantica.Checks.Check')
  - [None](#F-Semantica-Checks-Check-None 'Semantica.Checks.Check.None')
  - [AreEqual\`\`1(left,right,leftExpression,rightExpression)](#M-Semantica-Checks-Check-AreEqual``1-``0,``0,System-String,System-String- 'Semantica.Checks.Check.AreEqual``1(``0,``0,System.String,System.String)')
  - [Fails(description)](#M-Semantica-Checks-Check-Fails-System-String- 'Semantica.Checks.Check.Fails(System.String)')
  - [IsDefined(value,name)](#M-Semantica-Checks-Check-IsDefined-System-Double,System-String- 'Semantica.Checks.Check.IsDefined(System.Double,System.String)')
  - [IsDefined(value,name)](#M-Semantica-Checks-Check-IsDefined-System-Nullable{System-Double},System-String- 'Semantica.Checks.Check.IsDefined(System.Nullable{System.Double},System.String)')
  - [IsDefined\`\`1(value,name)](#M-Semantica-Checks-Check-IsDefined``1-``0,System-String- 'Semantica.Checks.Check.IsDefined``1(``0,System.String)')
  - [IsDefined\`\`1(value,name)](#M-Semantica-Checks-Check-IsDefined``1-System-Nullable{``0},System-String- 'Semantica.Checks.Check.IsDefined``1(System.Nullable{``0},System.String)')
  - [IsDetermined\`\`1(value,name)](#M-Semantica-Checks-Check-IsDetermined``1-``0,System-String- 'Semantica.Checks.Check.IsDetermined``1(``0,System.String)')
  - [IsDetermined\`\`1(value,name)](#M-Semantica-Checks-Check-IsDetermined``1-System-Nullable{``0},System-String- 'Semantica.Checks.Check.IsDetermined``1(System.Nullable{``0},System.String)')
  - [MaxLength(value,maxLength,name)](#M-Semantica-Checks-Check-MaxLength-System-String,System-Int32,System-String- 'Semantica.Checks.Check.MaxLength(System.String,System.Int32,System.String)')
  - [MinLength(value,minLength,name)](#M-Semantica-Checks-Check-MinLength-System-String,System-Int32,System-String- 'Semantica.Checks.Check.MinLength(System.String,System.Int32,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Int32,System-String- 'Semantica.Checks.Check.NonZero(System.Int32,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Int16,System-String- 'Semantica.Checks.Check.NonZero(System.Int16,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Int64,System-String- 'Semantica.Checks.Check.NonZero(System.Int64,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Single,System-String- 'Semantica.Checks.Check.NonZero(System.Single,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Double,System-String- 'Semantica.Checks.Check.NonZero(System.Double,System.String)')
  - [NonZero(value,name)](#M-Semantica-Checks-Check-NonZero-System-Decimal,System-String- 'Semantica.Checks.Check.NonZero(System.Decimal,System.String)')
  - [Not(condition,expression)](#M-Semantica-Checks-Check-Not-System-Boolean,System-String- 'Semantica.Checks.Check.Not(System.Boolean,System.String)')
  - [NotDefault\`\`1(value,name)](#M-Semantica-Checks-Check-NotDefault``1-``0,System-String- 'Semantica.Checks.Check.NotDefault``1(``0,System.String)')
  - [NotEmpty(value,name)](#M-Semantica-Checks-Check-NotEmpty-System-Guid,System-String- 'Semantica.Checks.Check.NotEmpty(System.Guid,System.String)')
  - [NotEmpty(value,name)](#M-Semantica-Checks-Check-NotEmpty-System-Nullable{System-Guid},System-String- 'Semantica.Checks.Check.NotEmpty(System.Nullable{System.Guid},System.String)')
  - [NotEmpty(value,name)](#M-Semantica-Checks-Check-NotEmpty-System-String,System-String- 'Semantica.Checks.Check.NotEmpty(System.String,System.String)')
  - [NotEmpty\`\`1(collection,name)](#M-Semantica-Checks-Check-NotEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0},System-String- 'Semantica.Checks.Check.NotEmpty``1(System.Collections.Generic.IReadOnlyCollection{``0},System.String)')
  - [NotEmpty\`\`1(collection,name)](#M-Semantica-Checks-Check-NotEmpty``1-System-Collections-Generic-IReadOnlyList{``0},System-String- 'Semantica.Checks.Check.NotEmpty``1(System.Collections.Generic.IReadOnlyList{``0},System.String)')
  - [NotEmpty\`\`1(value,name)](#M-Semantica-Checks-Check-NotEmpty``1-``0,System-String- 'Semantica.Checks.Check.NotEmpty``1(``0,System.String)')
  - [NotEmpty\`\`1(value,name)](#M-Semantica-Checks-Check-NotEmpty``1-System-Nullable{``0},System-String- 'Semantica.Checks.Check.NotEmpty``1(System.Nullable{``0},System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Int32,System-String- 'Semantica.Checks.Check.NotNegative(System.Int32,System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Int16,System-String- 'Semantica.Checks.Check.NotNegative(System.Int16,System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Int64,System-String- 'Semantica.Checks.Check.NotNegative(System.Int64,System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Single,System-String- 'Semantica.Checks.Check.NotNegative(System.Single,System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Double,System-String- 'Semantica.Checks.Check.NotNegative(System.Double,System.String)')
  - [NotNegative(value,name)](#M-Semantica-Checks-Check-NotNegative-System-Decimal,System-String- 'Semantica.Checks.Check.NotNegative(System.Decimal,System.String)')
  - [NotNullOrDefault\`\`1(value,name)](#M-Semantica-Checks-Check-NotNullOrDefault``1-``0,System-String- 'Semantica.Checks.Check.NotNullOrDefault``1(``0,System.String)')
  - [NotNull\`\`1(value,name)](#M-Semantica-Checks-Check-NotNull``1-``0,System-String- 'Semantica.Checks.Check.NotNull``1(``0,System.String)')
  - [NotNull\`\`1(value,name)](#M-Semantica-Checks-Check-NotNull``1-System-Nullable{``0},System-String- 'Semantica.Checks.Check.NotNull``1(System.Nullable{``0},System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Int32,System-String- 'Semantica.Checks.Check.StrictPositive(System.Int32,System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Int16,System-String- 'Semantica.Checks.Check.StrictPositive(System.Int16,System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Int64,System-String- 'Semantica.Checks.Check.StrictPositive(System.Int64,System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Single,System-String- 'Semantica.Checks.Check.StrictPositive(System.Single,System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Double,System-String- 'Semantica.Checks.Check.StrictPositive(System.Double,System.String)')
  - [StrictPositive(value,name)](#M-Semantica-Checks-Check-StrictPositive-System-Decimal,System-String- 'Semantica.Checks.Check.StrictPositive(System.Decimal,System.String)')
  - [That(condition,expression)](#M-Semantica-Checks-Check-That-System-Boolean,System-String- 'Semantica.Checks.Check.That(System.Boolean,System.String)')
  - [WhenNotEmpty\`\`1(value,check)](#M-Semantica-Checks-Check-WhenNotEmpty``1-``0,Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Check.WhenNotEmpty``1(``0,Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [WhenNotEmpty\`\`1(value,check)](#M-Semantica-Checks-Check-WhenNotEmpty``1-System-Nullable{``0},Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Check.WhenNotEmpty``1(System.Nullable{``0},Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [WhenNotNull\`\`1(value,check)](#M-Semantica-Checks-Check-WhenNotNull``1-System-Nullable{``0},Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Check.WhenNotNull``1(System.Nullable{``0},Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [WhenNotNull\`\`1(value,check)](#M-Semantica-Checks-Check-WhenNotNull``1-``0,Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Check.WhenNotNull``1(``0,Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
- [CheckExtensions](#T-Semantica-Checks-CheckExtensions 'Semantica.Checks.CheckExtensions')
  - [Contract(check)](#M-Semantica-Checks-CheckExtensions-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.CheckExtensions.Contract(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [Contract(check,description)](#M-Semantica-Checks-CheckExtensions-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.CheckExtensions.Contract(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [Guard(check)](#M-Semantica-Checks-CheckExtensions-Guard-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.CheckExtensions.Guard(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [Guard(check,description)](#M-Semantica-Checks-CheckExtensions-Guard-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.CheckExtensions.Guard(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [Out(check,chk)](#M-Semantica-Checks-CheckExtensions-Out-Semantica-Checks-Chk{Semantica-Checks-CheckKind},Semantica-Checks-Chk{Semantica-Checks-CheckKind}@- 'Semantica.Checks.CheckExtensions.Out(Semantica.Checks.Chk{Semantica.Checks.CheckKind},Semantica.Checks.Chk{Semantica.Checks.CheckKind}@)')
  - [State(check)](#M-Semantica-Checks-CheckExtensions-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.CheckExtensions.State(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [State(check,description)](#M-Semantica-Checks-CheckExtensions-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.CheckExtensions.State(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
- [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk')
  - [Fail](#P-Semantica-Checks-Chk-Fail 'Semantica.Checks.Chk.Fail')
  - [IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined')
  - [Pass](#P-Semantica-Checks-Chk-Pass 'Semantica.Checks.Chk.Pass')
  - [Fails(failReason)](#M-Semantica-Checks-Chk-Fails-System-String- 'Semantica.Checks.Chk.Fails(System.String)')
  - [Fails\`\`1(payload)](#M-Semantica-Checks-Chk-Fails``1-``0- 'Semantica.Checks.Chk.Fails``1(``0)')
  - [Fails\`\`1(failReason,payload)](#M-Semantica-Checks-Chk-Fails``1-System-String,``0- 'Semantica.Checks.Chk.Fails``1(System.String,``0)')
  - [If(result)](#M-Semantica-Checks-Chk-If-System-Boolean- 'Semantica.Checks.Chk.If(System.Boolean)')
  - [If\`\`1(result)](#M-Semantica-Checks-Chk-If``1-System-Boolean- 'Semantica.Checks.Chk.If``1(System.Boolean)')
  - [Passes(passReason)](#M-Semantica-Checks-Chk-Passes-System-String- 'Semantica.Checks.Chk.Passes(System.String)')
  - [Passes\`\`1(payload)](#M-Semantica-Checks-Chk-Passes``1-``0- 'Semantica.Checks.Chk.Passes``1(``0)')
  - [Passes\`\`1(passReason,payload)](#M-Semantica-Checks-Chk-Passes``1-System-String,``0- 'Semantica.Checks.Chk.Passes``1(System.String,``0)')
  - [SplitReasons()](#M-Semantica-Checks-Chk-SplitReasons 'Semantica.Checks.Chk.SplitReasons')
  - [ToString()](#M-Semantica-Checks-Chk-ToString 'Semantica.Checks.Chk.ToString')
  - [WithPld\`\`1(payload)](#M-Semantica-Checks-Chk-WithPld``1-``0- 'Semantica.Checks.Chk.WithPld``1(``0)')
  - [WithRsn(reason)](#M-Semantica-Checks-Chk-WithRsn-System-String- 'Semantica.Checks.Chk.WithRsn(System.String)')
  - [op_BitwiseAnd(left,right)](#M-Semantica-Checks-Chk-op_BitwiseAnd-Semantica-Checks-Chk,Semantica-Checks-Chk- 'Semantica.Checks.Chk.op_BitwiseAnd(Semantica.Checks.Chk,Semantica.Checks.Chk)')
  - [op_BitwiseOr(left,right)](#M-Semantica-Checks-Chk-op_BitwiseOr-Semantica-Checks-Chk,Semantica-Checks-Chk- 'Semantica.Checks.Chk.op_BitwiseOr(Semantica.Checks.Chk,Semantica.Checks.Chk)')
  - [op_False()](#M-Semantica-Checks-Chk-op_False-Semantica-Checks-Chk- 'Semantica.Checks.Chk.op_False(Semantica.Checks.Chk)')
  - [op_LogicalNot()](#M-Semantica-Checks-Chk-op_LogicalNot-Semantica-Checks-Chk- 'Semantica.Checks.Chk.op_LogicalNot(Semantica.Checks.Chk)')
  - [op_True()](#M-Semantica-Checks-Chk-op_True-Semantica-Checks-Chk- 'Semantica.Checks.Chk.op_True(Semantica.Checks.Chk)')
- [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1')
  - [Fail](#F-Semantica-Checks-Chk`1-Fail 'Semantica.Checks.Chk`1.Fail')
  - [Pass](#F-Semantica-Checks-Chk`1-Pass 'Semantica.Checks.Chk`1.Pass')
  - [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload')
  - [Fails(failReason)](#M-Semantica-Checks-Chk`1-Fails-System-String- 'Semantica.Checks.Chk`1.Fails(System.String)')
  - [Fails(payload)](#M-Semantica-Checks-Chk`1-Fails-`0- 'Semantica.Checks.Chk`1.Fails(`0)')
  - [Fails(failReason,payload)](#M-Semantica-Checks-Chk`1-Fails-System-String,`0- 'Semantica.Checks.Chk`1.Fails(System.String,`0)')
  - [Passes(passReason)](#M-Semantica-Checks-Chk`1-Passes-System-String- 'Semantica.Checks.Chk`1.Passes(System.String)')
  - [Passes(payload)](#M-Semantica-Checks-Chk`1-Passes-`0- 'Semantica.Checks.Chk`1.Passes(`0)')
  - [Passes(passReason,payload)](#M-Semantica-Checks-Chk`1-Passes-System-String,`0- 'Semantica.Checks.Chk`1.Passes(System.String,`0)')
  - [Simplify()](#M-Semantica-Checks-Chk`1-Simplify 'Semantica.Checks.Chk`1.Simplify')
  - [Simplify(payload)](#M-Semantica-Checks-Chk`1-Simplify-`0@- 'Semantica.Checks.Chk`1.Simplify(`0@)')
  - [SplitReasons()](#M-Semantica-Checks-Chk`1-SplitReasons 'Semantica.Checks.Chk`1.SplitReasons')
  - [ToString()](#M-Semantica-Checks-Chk`1-ToString 'Semantica.Checks.Chk`1.ToString')
  - [op_BitwiseAnd(left,right)](#M-Semantica-Checks-Chk`1-op_BitwiseAnd-Semantica-Checks-Chk{`0},Semantica-Checks-Chk{`0}- 'Semantica.Checks.Chk`1.op_BitwiseAnd(Semantica.Checks.Chk{`0},Semantica.Checks.Chk{`0})')
  - [op_BitwiseAnd(left,right)](#M-Semantica-Checks-Chk`1-op_BitwiseAnd-Semantica-Checks-Chk{`0},Semantica-Checks-Chk- 'Semantica.Checks.Chk`1.op_BitwiseAnd(Semantica.Checks.Chk{`0},Semantica.Checks.Chk)')
  - [op_BitwiseOr(left,right)](#M-Semantica-Checks-Chk`1-op_BitwiseOr-Semantica-Checks-Chk{`0},Semantica-Checks-Chk{`0}- 'Semantica.Checks.Chk`1.op_BitwiseOr(Semantica.Checks.Chk{`0},Semantica.Checks.Chk{`0})')
  - [op_BitwiseOr(left,right)](#M-Semantica-Checks-Chk`1-op_BitwiseOr-Semantica-Checks-Chk{`0},Semantica-Checks-Chk- 'Semantica.Checks.Chk`1.op_BitwiseOr(Semantica.Checks.Chk{`0},Semantica.Checks.Chk)')
  - [op_False()](#M-Semantica-Checks-Chk`1-op_False-Semantica-Checks-Chk{`0}- 'Semantica.Checks.Chk`1.op_False(Semantica.Checks.Chk{`0})')
  - [op_LogicalNot()](#M-Semantica-Checks-Chk`1-op_LogicalNot-Semantica-Checks-Chk{`0}- 'Semantica.Checks.Chk`1.op_LogicalNot(Semantica.Checks.Chk{`0})')
  - [op_True()](#M-Semantica-Checks-Chk`1-op_True-Semantica-Checks-Chk{`0}- 'Semantica.Checks.Chk`1.op_True(Semantica.Checks.Chk{`0})')
- [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-ContractArgumentException-#ctor-System-String- 'Semantica.Checks.Exceptions.ContractArgumentException.#ctor(System.String)')
  - [#ctor()](#M-Semantica-Checks-Exceptions-ContractArgumentException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.ContractArgumentException.#ctor(System.String,System.String)')
- [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-ContractArgumentNullException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.ContractArgumentNullException.#ctor(System.String,System.String)')
- [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException.#ctor(System.String,System.String)')
- [ContractException](#T-Semantica-Checks-Exceptions-ContractException 'Semantica.Checks.Exceptions.ContractException')
  - [Make()](#M-Semantica-Checks-Exceptions-ContractException-Make-System-String- 'Semantica.Checks.Exceptions.ContractException.Make(System.String)')
  - [Make()](#M-Semantica-Checks-Exceptions-ContractException-Make-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.Make(System.String,System.String)')
  - [MakeEmpty()](#M-Semantica-Checks-Exceptions-ContractException-MakeEmpty-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeEmpty(System.String)')
  - [MakeEmpty()](#M-Semantica-Checks-Exceptions-ContractException-MakeEmpty-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeEmpty(System.String,System.String)')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-ContractException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Exceptions.ContractException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-ContractException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Exceptions.ContractException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [MakeNonNegative()](#M-Semantica-Checks-Exceptions-ContractException-MakeNonNegative-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNonNegative(System.String)')
  - [MakeNonNegative()](#M-Semantica-Checks-Exceptions-ContractException-MakeNonNegative-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNonNegative(System.String,System.String)')
  - [MakeNonZero()](#M-Semantica-Checks-Exceptions-ContractException-MakeNonZero-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNonZero(System.String)')
  - [MakeNonZero()](#M-Semantica-Checks-Exceptions-ContractException-MakeNonZero-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNonZero(System.String,System.String)')
  - [MakeNull()](#M-Semantica-Checks-Exceptions-ContractException-MakeNull-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNull(System.String)')
  - [MakeNull()](#M-Semantica-Checks-Exceptions-ContractException-MakeNull-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeNull(System.String,System.String)')
  - [MakeStrictPositive()](#M-Semantica-Checks-Exceptions-ContractException-MakeStrictPositive-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeStrictPositive(System.String)')
  - [MakeStrictPositive()](#M-Semantica-Checks-Exceptions-ContractException-MakeStrictPositive-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeStrictPositive(System.String,System.String)')
  - [MakeUndefined()](#M-Semantica-Checks-Exceptions-ContractException-MakeUndefined-System-String- 'Semantica.Checks.Exceptions.ContractException.MakeUndefined(System.String)')
  - [MakeUndefined()](#M-Semantica-Checks-Exceptions-ContractException-MakeUndefined-System-String,System-String- 'Semantica.Checks.Exceptions.ContractException.MakeUndefined(System.String,System.String)')
- [Guard](#T-Semantica-Checks-Guard 'Semantica.Checks.Guard')
  - [Contract(check,expression)](#M-Semantica-Checks-Guard-Contract-System-Boolean,System-String- 'Semantica.Checks.Guard.Contract(System.Boolean,System.String)')
  - [Contract(check,description,argumentName)](#M-Semantica-Checks-Guard-Contract-System-Boolean,System-String,System-String- 'Semantica.Checks.Guard.Contract(System.Boolean,System.String,System.String)')
  - [Contract(check)](#M-Semantica-Checks-Guard-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Guard.Contract(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [Contract(check,description)](#M-Semantica-Checks-Guard-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Guard.Contract(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [For(check,expression)](#M-Semantica-Checks-Guard-For-System-Boolean,System-String- 'Semantica.Checks.Guard.For(System.Boolean,System.String)')
  - [For(check,description,argumentName)](#M-Semantica-Checks-Guard-For-System-Boolean,System-String,System-String- 'Semantica.Checks.Guard.For(System.Boolean,System.String,System.String)')
  - [For(check)](#M-Semantica-Checks-Guard-For-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Guard.For(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [For(check,description)](#M-Semantica-Checks-Guard-For-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Guard.For(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [For\`\`1(check)](#M-Semantica-Checks-Guard-For``1-System-Boolean- 'Semantica.Checks.Guard.For``1(System.Boolean)')
  - [Index(index,end)](#M-Semantica-Checks-Guard-Index-System-Int32,System-Int32- 'Semantica.Checks.Guard.Index(System.Int32,System.Int32)')
  - [Index(index,start,end)](#M-Semantica-Checks-Guard-Index-System-Int32,System-Int32,System-Int32- 'Semantica.Checks.Guard.Index(System.Int32,System.Int32,System.Int32)')
  - [State(check,expression)](#M-Semantica-Checks-Guard-State-System-Boolean,System-String- 'Semantica.Checks.Guard.State(System.Boolean,System.String)')
  - [State(check,description,fieldName)](#M-Semantica-Checks-Guard-State-System-Boolean,System-String,System-String- 'Semantica.Checks.Guard.State(System.Boolean,System.String,System.String)')
  - [State(check)](#M-Semantica-Checks-Guard-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Guard.State(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [State(check,description)](#M-Semantica-Checks-Guard-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Guard.State(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
- [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-GuardArgumentException-#ctor-System-String- 'Semantica.Checks.Exceptions.GuardArgumentException.#ctor(System.String)')
  - [#ctor()](#M-Semantica-Checks-Exceptions-GuardArgumentException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.GuardArgumentException.#ctor(System.String,System.String)')
- [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-GuardArgumentNullException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.GuardArgumentNullException.#ctor(System.String,System.String)')
- [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException-#ctor-System-String,System-String- 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException.#ctor(System.String,System.String)')
- [GuardException](#T-Semantica-Checks-Exceptions-GuardException 'Semantica.Checks.Exceptions.GuardException')
  - [Make()](#M-Semantica-Checks-Exceptions-GuardException-Make-System-String- 'Semantica.Checks.Exceptions.GuardException.Make(System.String)')
  - [Make()](#M-Semantica-Checks-Exceptions-GuardException-Make-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.Make(System.String,System.String)')
  - [MakeEmpty()](#M-Semantica-Checks-Exceptions-GuardException-MakeEmpty-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeEmpty(System.String)')
  - [MakeEmpty()](#M-Semantica-Checks-Exceptions-GuardException-MakeEmpty-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeEmpty(System.String,System.String)')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-GuardException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Exceptions.GuardException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-GuardException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Exceptions.GuardException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [MakeIndex()](#M-Semantica-Checks-Exceptions-GuardException-MakeIndex-System-Int32,System-Int32- 'Semantica.Checks.Exceptions.GuardException.MakeIndex(System.Int32,System.Int32)')
  - [MakeMaxValue()](#M-Semantica-Checks-Exceptions-GuardException-MakeMaxValue-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeMaxValue(System.String)')
  - [MakeMaxValue()](#M-Semantica-Checks-Exceptions-GuardException-MakeMaxValue-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeMaxValue(System.String,System.String)')
  - [MakeNonNegative()](#M-Semantica-Checks-Exceptions-GuardException-MakeNonNegative-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNonNegative(System.String)')
  - [MakeNonNegative()](#M-Semantica-Checks-Exceptions-GuardException-MakeNonNegative-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNonNegative(System.String,System.String)')
  - [MakeNonZero()](#M-Semantica-Checks-Exceptions-GuardException-MakeNonZero-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNonZero(System.String)')
  - [MakeNonZero()](#M-Semantica-Checks-Exceptions-GuardException-MakeNonZero-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNonZero(System.String,System.String)')
  - [MakeNull()](#M-Semantica-Checks-Exceptions-GuardException-MakeNull-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNull(System.String)')
  - [MakeNull()](#M-Semantica-Checks-Exceptions-GuardException-MakeNull-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeNull(System.String,System.String)')
  - [MakeStrictPositive()](#M-Semantica-Checks-Exceptions-GuardException-MakeStrictPositive-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeStrictPositive(System.String)')
  - [MakeStrictPositive()](#M-Semantica-Checks-Exceptions-GuardException-MakeStrictPositive-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeStrictPositive(System.String,System.String)')
  - [MakeUndefined()](#M-Semantica-Checks-Exceptions-GuardException-MakeUndefined-System-String- 'Semantica.Checks.Exceptions.GuardException.MakeUndefined(System.String)')
  - [MakeUndefined()](#M-Semantica-Checks-Exceptions-GuardException-MakeUndefined-System-String,System-String- 'Semantica.Checks.Exceptions.GuardException.MakeUndefined(System.String,System.String)')
- [IChk](#T-Semantica-Checks-IChk 'Semantica.Checks.IChk')
  - [Failed](#P-Semantica-Checks-IChk-Failed 'Semantica.Checks.IChk.Failed')
  - [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed')
  - [Reason](#P-Semantica-Checks-IChk-Reason 'Semantica.Checks.IChk.Reason')
  - [HasFailed()](#M-Semantica-Checks-IChk-HasFailed 'Semantica.Checks.IChk.HasFailed')
  - [HasPassed()](#M-Semantica-Checks-IChk-HasPassed 'Semantica.Checks.IChk.HasPassed')
- [Pld](#T-Semantica-Checks-Chk-Pld 'Semantica.Checks.Chk.Pld')
  - [ForFail\`\`1(payload)](#M-Semantica-Checks-Chk-Pld-ForFail``1-``0- 'Semantica.Checks.Chk.Pld.ForFail``1(``0)')
  - [ForFail\`\`1(payload,reason)](#M-Semantica-Checks-Chk-Pld-ForFail``1-``0,System-String- 'Semantica.Checks.Chk.Pld.ForFail``1(``0,System.String)')
  - [ForPass\`\`1(payload)](#M-Semantica-Checks-Chk-Pld-ForPass``1-``0- 'Semantica.Checks.Chk.Pld.ForPass``1(``0)')
  - [ForPass\`\`1(payload,reason)](#M-Semantica-Checks-Chk-Pld-ForPass``1-``0,System-String- 'Semantica.Checks.Chk.Pld.ForPass``1(``0,System.String)')
- [Rsn](#T-Semantica-Checks-Chk-Rsn 'Semantica.Checks.Chk.Rsn')
- [Rsn](#T-Semantica-Checks-Chk`1-Rsn 'Semantica.Checks.Chk`1.Rsn')
  - [Fail](#P-Semantica-Checks-Chk-Rsn-Fail 'Semantica.Checks.Chk.Rsn.Fail')
  - [Pass](#P-Semantica-Checks-Chk-Rsn-Pass 'Semantica.Checks.Chk.Rsn.Pass')
  - [Fail](#P-Semantica-Checks-Chk`1-Rsn-Fail 'Semantica.Checks.Chk`1.Rsn.Fail')
  - [Pass](#P-Semantica-Checks-Chk`1-Rsn-Pass 'Semantica.Checks.Chk`1.Rsn.Pass')
  - [ForFail(reason)](#M-Semantica-Checks-Chk-Rsn-ForFail-System-String- 'Semantica.Checks.Chk.Rsn.ForFail(System.String)')
  - [ForFail\`\`1(reason)](#M-Semantica-Checks-Chk-Rsn-ForFail``1-System-String- 'Semantica.Checks.Chk.Rsn.ForFail``1(System.String)')
  - [ForPass(reason)](#M-Semantica-Checks-Chk-Rsn-ForPass-System-String- 'Semantica.Checks.Chk.Rsn.ForPass(System.String)')
  - [ForPass\`\`1(reason)](#M-Semantica-Checks-Chk-Rsn-ForPass``1-System-String- 'Semantica.Checks.Chk.Rsn.ForPass``1(System.String)')
- [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException')
  - [#ctor()](#M-Semantica-Checks-Exceptions-StateException-#ctor-System-String- 'Semantica.Checks.Exceptions.StateException.#ctor(System.String)')
  - [Make()](#M-Semantica-Checks-Exceptions-StateException-Make-System-String- 'Semantica.Checks.Exceptions.StateException.Make(System.String)')
  - [Make()](#M-Semantica-Checks-Exceptions-StateException-Make-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.Make(System.String,System.String)')
  - [MakeEmpty()](#M-Semantica-Checks-Exceptions-StateException-MakeEmpty-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeEmpty(System.String,System.String)')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-StateException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Exceptions.StateException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [MakeFor()](#M-Semantica-Checks-Exceptions-StateException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Exceptions.StateException.MakeFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [MakeNonNegative()](#M-Semantica-Checks-Exceptions-StateException-MakeNonNegative-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeNonNegative(System.String,System.String)')
  - [MakeNonZero()](#M-Semantica-Checks-Exceptions-StateException-MakeNonZero-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeNonZero(System.String,System.String)')
  - [MakeNull()](#M-Semantica-Checks-Exceptions-StateException-MakeNull-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeNull(System.String,System.String)')
  - [MakeStrictPositive()](#M-Semantica-Checks-Exceptions-StateException-MakeStrictPositive-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeStrictPositive(System.String,System.String)')
  - [MakeUndefined()](#M-Semantica-Checks-Exceptions-StateException-MakeUndefined-System-String,System-String- 'Semantica.Checks.Exceptions.StateException.MakeUndefined(System.String,System.String)')
- [Throw](#T-Semantica-Checks-Throw 'Semantica.Checks.Throw')
  - [Contract(expression)](#M-Semantica-Checks-Throw-Contract-System-String- 'Semantica.Checks.Throw.Contract(System.String)')
  - [Contract(description,argumentName)](#M-Semantica-Checks-Throw-Contract-System-String,System-String- 'Semantica.Checks.Throw.Contract(System.String,System.String)')
  - [ContractFor(check)](#M-Semantica-Checks-Throw-ContractFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Throw.ContractFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [ContractFor(description,check)](#M-Semantica-Checks-Throw-ContractFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Throw.ContractFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [Guard(expression)](#M-Semantica-Checks-Throw-Guard-System-String- 'Semantica.Checks.Throw.Guard(System.String)')
  - [Guard(description,argumentName)](#M-Semantica-Checks-Throw-Guard-System-String,System-String- 'Semantica.Checks.Throw.Guard(System.String,System.String)')
  - [GuardFor(check)](#M-Semantica-Checks-Throw-GuardFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}- 'Semantica.Checks.Throw.GuardFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind})')
  - [GuardFor(description,check)](#M-Semantica-Checks-Throw-GuardFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Throw.GuardFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')
  - [State(expression)](#M-Semantica-Checks-Throw-State-System-String- 'Semantica.Checks.Throw.State(System.String)')
  - [State(description,fieldName)](#M-Semantica-Checks-Throw-State-System-String,System-String- 'Semantica.Checks.Throw.State(System.String,System.String)')
  - [StateFor(check,fieldName)](#M-Semantica-Checks-Throw-StateFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String- 'Semantica.Checks.Throw.StateFor(Semantica.Checks.Chk{Semantica.Checks.CheckKind},System.String)')

<a name='T-Semantica-Checks-Check'></a>
## Check `type`

##### Namespace

Semantica.Checks

##### Summary

Provides a number of standard checks that can be used for guards. The [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind')[Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload')
indicates the type of check that has failed, so a proper exception(-message) can be constructed. The
[Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') will contain the expression passed on failure.

<a name='F-Semantica-Checks-Check-None'></a>
### None `constants`

##### Summary

A passing [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind').

<a name='M-Semantica-Checks-Check-AreEqual``1-``0,``0,System-String,System-String-'></a>
### AreEqual\`\`1(left,right,leftExpression,rightExpression) `method`

##### Summary

Makes a check that passes if the `left` and the `right` are equal; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | The `bool` result of a condition. |
| right | [\`\`0](#T-``0 '``0') | The `bool` result of a condition. |
| leftExpression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The left expression to be added as reason on fail. |
| rightExpression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The right expression to be added as reason on fail. |

<a name='M-Semantica-Checks-Check-Fails-System-String-'></a>
### Fails(description) `method`

##### Summary

Creates a failed check reason that can be `||`'d onto an actual check in order to make the evaluation of the
reason only evaluated if the check fails using short-circuit mechanisms.

##### Returns

A [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') with the provided `description`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description of the failed check. |

<a name='M-Semantica-Checks-Check-IsDefined-System-Double,System-String-'></a>
### IsDefined(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is a valid value for
double; and fails if the value is `double.NaN` or `double.Infinity`.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-IsDefined-System-Nullable{System-Double},System-String-'></a>
### IsDefined(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is a valid value for
double; and fails if the value is `double.NaN` or `double.Infinity`.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Double}') | The value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-IsDefined``1-``0,System-String-'></a>
### IsDefined\`\`1(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is a valid value for enum
`T`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the enum value to check. |

<a name='M-Semantica-Checks-Check-IsDefined``1-System-Nullable{``0},System-String-'></a>
### IsDefined\`\`1(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is a valid value for enum
`T`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the enum value to check. |

<a name='M-Semantica-Checks-Check-IsDetermined``1-``0,System-String-'></a>
### IsDetermined\`\`1(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is determined;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable') type of instance to check. |

<a name='M-Semantica-Checks-Check-IsDetermined``1-System-Nullable{``0},System-String-'></a>
### IsDetermined\`\`1(value,name) `method`

##### Summary

Makes a check of kind [Defined](#F-Semantica-Checks-CheckKind-Defined 'Semantica.Checks.CheckKind.Defined') that passes if `value` is determined;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable') type of instance to check. |

<a name='M-Semantica-Checks-Check-MaxLength-System-String,System-Int32,System-String-'></a>
### MaxLength(value,maxLength,name) `method`

##### Summary

Makes a check that passes if `value` is at most `maxLength` characters in length; and
fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') instance to check. |
| maxLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximal valid length for the input. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-MinLength-System-String,System-Int32,System-String-'></a>
### MinLength(value,minLength,name) `method`

##### Summary

Makes a check that passes if `value` is not `null` and at least
`minLength` characters in length; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') instance to check. |
| minLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimal valid length for the input. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Int32,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The `int` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Int16,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The `short` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Int64,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The `long` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Single,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The `float` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Double,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The `double` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NonZero-System-Decimal,System-String-'></a>
### NonZero(value,name) `method`

##### Summary

Makes a check of kind [NonZero](#F-Semantica-Checks-CheckKind-NonZero 'Semantica.Checks.CheckKind.NonZero') that passes if `value` is not zero; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The `decimal` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-Not-System-Boolean,System-String-'></a>
### Not(condition,expression) `method`

##### Summary

Makes a check that passes if `condition` is `false`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The `bool` result of a condition. |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expression to be added as reason on fail. |

<a name='M-Semantica-Checks-Check-NotDefault``1-``0,System-String-'></a>
### NotDefault\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotNull](#F-Semantica-Checks-CheckKind-NotNull 'Semantica.Checks.CheckKind.NotNull') that passes if `value` is not equal to
`default`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [IEquatable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IEquatable`1 'System.IEquatable`1') type of instance to check. |

<a name='M-Semantica-Checks-Check-NotEmpty-System-Guid,System-String-'></a>
### NotEmpty(value,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `value` is not
`Guid.Empty`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotEmpty-System-Nullable{System-Guid},System-String-'></a>
### NotEmpty(value,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `value` is not
`Guid.Empty`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Guid}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Guid}') | The [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotEmpty-System-String,System-String-'></a>
### NotEmpty(value,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `value` is not
`null` or an empty string; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0},System-String-'></a>
### NotEmpty\`\`1(collection,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `collection` is not
`null` and has at least one element; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the collection field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [IReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection`1 'System.Collections.Generic.IReadOnlyCollection`1') type of instance to check. |

<a name='M-Semantica-Checks-Check-NotEmpty``1-System-Collections-Generic-IReadOnlyList{``0},System-String-'></a>
### NotEmpty\`\`1(collection,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `collection` is not
`null` and has at least one element; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The collection instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the collection field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') type of instance to check. |

<a name='M-Semantica-Checks-Check-NotEmpty``1-``0,System-String-'></a>
### NotEmpty\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `value` is not empty; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') type of instance to check. |

<a name='M-Semantica-Checks-Check-NotEmpty``1-System-Nullable{``0},System-String-'></a>
### NotEmpty\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotEmpty](#F-Semantica-Checks-CheckKind-NotEmpty 'Semantica.Checks.CheckKind.NotEmpty') that passes if `value` is not empty; and fails
otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') type of instance to check. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Int32,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The `int` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Int16,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The `short` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Int64,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The `long` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Single,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The `float` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Double,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The `double` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNegative-System-Decimal,System-String-'></a>
### NotNegative(value,name) `method`

##### Summary

Makes a check of kind [NonNegative](#F-Semantica-Checks-CheckKind-NonNegative 'Semantica.Checks.CheckKind.NonNegative') that passes if `value` is not negative;
and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The `decimal` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-NotNullOrDefault``1-``0,System-String-'></a>
### NotNullOrDefault\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotNull](#F-Semantica-Checks-CheckKind-NotNull 'Semantica.Checks.CheckKind.NotNull') that passes if `value` is not
`default`, using de default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1'); and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The reference type of instance to check. |

<a name='M-Semantica-Checks-Check-NotNull``1-``0,System-String-'></a>
### NotNull\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotNull](#F-Semantica-Checks-CheckKind-NotNull 'Semantica.Checks.CheckKind.NotNull') that passes if `value` is not
`null`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The reference type of instance to check. |

<a name='M-Semantica-Checks-Check-NotNull``1-System-Nullable{``0},System-String-'></a>
### NotNull\`\`1(value,name) `method`

##### Summary

Makes a check of kind [NotNull](#F-Semantica-Checks-CheckKind-NotNull 'Semantica.Checks.CheckKind.NotNull') that passes if `value` is not
`null`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The instance to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') value type of instance to check. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Int32,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The `int` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Int16,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The `short` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Int64,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The `long` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Single,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The `float` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Double,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The `double` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-StrictPositive-System-Decimal,System-String-'></a>
### StrictPositive(value,name) `method`

##### Summary

Makes a check of kind [StrictPositive](#F-Semantica-Checks-CheckKind-StrictPositive 'Semantica.Checks.CheckKind.StrictPositive') that passes if `value` is greater than
zero; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The `decimal` value to check. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name/expression of the value field, argument or property to check. Added as [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') on failure. |

<a name='M-Semantica-Checks-Check-That-System-Boolean,System-String-'></a>
### That(condition,expression) `method`

##### Summary

Makes a check that passes if `condition` is `true`; and fails otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The `bool` result of a condition. |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expression to be added as reason on fail. |

<a name='M-Semantica-Checks-Check-WhenNotEmpty``1-``0,Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### WhenNotEmpty\`\`1(value,check) `method`

##### Summary

Checks if `value` is not empty and only then returns `check`;
returns a passed test otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') instance to check. |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | The check to return if `value` is not empty. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') type of instance to check. |

<a name='M-Semantica-Checks-Check-WhenNotEmpty``1-System-Nullable{``0},Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### WhenNotEmpty\`\`1(value,check) `method`

##### Summary

Checks if `value` is not `null` or empty and only then returns `check`;
returns a passed test otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The nullable [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') instance to check. |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | The check to return if `value` is not empty. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty') type of instance to check. |

<a name='M-Semantica-Checks-Check-WhenNotNull``1-System-Nullable{``0},Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### WhenNotNull\`\`1(value,check) `method`

##### Summary

Checks if `value` is not `null` and only then returns `check`;
returns a passed test otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | The [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') instance to check. |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | The check to return if `value` is not null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [Nullable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable`1 'System.Nullable`1') type of instance to check. |

<a name='M-Semantica-Checks-Check-WhenNotNull``1-``0,Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### WhenNotNull\`\`1(value,check) `method`

##### Summary

Checks if `value` is not `null` and only then returns `check`;
returns a passed test otherwise.

##### Returns

A new [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') when conditions are met.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The instance to check. |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | The check to return if `value` is not null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The reference type of instance to check. |

<a name='T-Semantica-Checks-CheckExtensions'></a>
## CheckExtensions `type`

##### Namespace

Semantica.Checks

##### Summary

Provides extension methods on [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind') that can be used for guarding of all three types
[ContractException](#T-Semantica-Checks-Exceptions-ContractException 'Semantica.Checks.Exceptions.ContractException'), [GuardException](#T-Semantica-Checks-Exceptions-GuardException 'Semantica.Checks.Exceptions.GuardException') and [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

<a name='M-Semantica-Checks-CheckExtensions-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### Contract(check) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes when it's failed. |

<a name='M-Semantica-Checks-CheckExtensions-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### Contract(check,description) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes when it's failed. |

<a name='M-Semantica-Checks-CheckExtensions-Guard-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### Guard(check) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes when it's failed. |

<a name='M-Semantica-Checks-CheckExtensions-Guard-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### Guard(check,description) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes when it's failed. |

<a name='M-Semantica-Checks-CheckExtensions-Out-Semantica-Checks-Chk{Semantica-Checks-CheckKind},Semantica-Checks-Chk{Semantica-Checks-CheckKind}@-'></a>
### Out(check,chk) `method`

##### Summary

Assigns the input `check` to the out parameter `chk`, and also returns it.

##### Returns

The input.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Input [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') of [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind'). |
| chk | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}@](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind}@ 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}@') | Out parameter that will contain a copy of `check`. |

##### Remarks

This method can be used to assign the result of a check to a variable an in-line, making it more compact to use it in
an if and it's then-statement.

<a name='M-Semantica-Checks-CheckExtensions-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### State(check) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws when `check` failed. |

<a name='M-Semantica-Checks-CheckExtensions-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### State(check,description) `method`

##### Summary

Throws if the check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws when `check` failed. |

<a name='T-Semantica-Checks-Chk'></a>
## Chk `type`

##### Namespace

Semantica.Checks

##### Summary

Represents the result of a (`bool`) check, with an optional [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason').

##### Remarks

Instances of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') can be used just as booleans. Short-circuiting is supported for operators `&&`
and `||`. The [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') is always associated with a certain outcome ([Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') or
[Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed')). When two instances are combined with an operator, only the reasons that are associated with the
outcome will be present in the result. Multiple applicable reasons are concatenated. [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') is
[IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable'). An undetermined instance has the meaning of _only_ being a reason associated to a specific
outcome, and it's value will never influence a binary operator's outcome.

<a name='P-Semantica-Checks-Chk-Fail'></a>
### Fail `property`

##### Summary

A [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') instance.

<a name='P-Semantica-Checks-Chk-IsDetermined'></a>
### IsDetermined `property`

##### Summary

`true` for an actual check outcome. `false` if the instance is only a reason associated
to a specific outcome. The value will never influence a binary operator's outcome.

<a name='P-Semantica-Checks-Chk-Pass'></a>
### Pass `property`

##### Summary

A [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') instance.

<a name='M-Semantica-Checks-Chk-Fails-System-String-'></a>
### Fails(failReason) `method`

##### Summary

Makes an instance with a new value for [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'), but only if the check already [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed').

##### Returns

A new instance of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') containing `failReason` if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'), otherwise
[Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') |

<a name='M-Semantica-Checks-Chk-Fails``1-``0-'></a>
### Fails\`\`1(payload) `method`

##### Summary

Makes an instance with a new value for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'), but only if the check already
[Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `payload` if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'), otherwise the
[Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | The type of the payload. |

<a name='M-Semantica-Checks-Chk-Fails``1-System-String,``0-'></a>
### Fails\`\`1(failReason,payload) `method`

##### Summary

Makes an instance with new values for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') and [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'), but only if the
check already [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `failReason` and `payload` if
[Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'), otherwise the [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`, and
[Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'). |
| payload | [\`\`0](#T-``0 '``0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | The type of the payload. |

<a name='M-Semantica-Checks-Chk-If-System-Boolean-'></a>
### If(result) `method`

##### Summary

A new instance of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') that [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') if `result` is `true`.

##### Returns

A new instance of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') with no specified reason.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of some check. |

<a name='M-Semantica-Checks-Chk-If``1-System-Boolean-'></a>
### If\`\`1(result) `method`

##### Summary

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') that [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') if `result` is
`true`.

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') with no specified reason or payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of some check. |

<a name='M-Semantica-Checks-Chk-Passes-System-String-'></a>
### Passes(passReason) `method`

##### Summary

Makes an instance with a new value for [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'), but only if the check already [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `passReason` if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), otherwise
[Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'). |

<a name='M-Semantica-Checks-Chk-Passes``1-``0-'></a>
### Passes\`\`1(payload) `method`

##### Summary

Makes an instance with a value for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'), but only if the check already
[Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `payload` if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), otherwise the
[Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | The type of the payload. |

<a name='M-Semantica-Checks-Chk-Passes``1-System-String,``0-'></a>
### Passes\`\`1(passReason,payload) `method`

##### Summary

Makes an instance with new values for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') and [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'), but only if the
check already [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `passReason` and `payload` if
[Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), otherwise the [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`, and
[Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'). |
| payload | [\`\`0](#T-``0 '``0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | The type of the payload. |

<a name='M-Semantica-Checks-Chk-SplitReasons'></a>
### SplitReasons() `method`

##### Summary

If multiple reasons were previously combined, this method can split up these reasons.

##### Returns

A `string[]` containing all the reasons associated with the outcome.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk-ToString'></a>
### ToString() `method`

##### Summary

Returns a descriptive version of the value of the instance.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk-WithPld``1-``0-'></a>
### WithPld\`\`1(payload) `method`

##### Summary

Makes an instance with new values for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'), regardless if the check [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed')
or [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `payload`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | The type of the payload. |

<a name='M-Semantica-Checks-Chk-WithRsn-System-String-'></a>
### WithRsn(reason) `method`

##### Summary

Makes an instance with a new value for [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'), regardless if the check [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') or
[Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed').

##### Returns

A new instance of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') containing `reason`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason'). |

<a name='M-Semantica-Checks-Chk-op_BitwiseAnd-Semantica-Checks-Chk,Semantica-Checks-Chk-'></a>
### op_BitwiseAnd(left,right) `method`

##### Summary

And-operator for two [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') if `left` *and* `right` both [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The left operand. |
| right | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a fail reason [Fail](#P-Semantica-Checks-Chk-Rsn-Fail 'Semantica.Checks.Chk.Rsn.Fail') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined') is
`false`) |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'), only reasons of [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') inputs are retained in the output.
If the outcome is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), only reasons of [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') inputs are retained in the output.

<a name='M-Semantica-Checks-Chk-op_BitwiseOr-Semantica-Checks-Chk,Semantica-Checks-Chk-'></a>
### op_BitwiseOr(left,right) `method`

##### Summary

Or-operator for two [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') if `left` *or* `right` have [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The left operand. |
| right | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a pass reason [Pass](#P-Semantica-Checks-Chk-Rsn-Pass 'Semantica.Checks.Chk.Rsn.Pass') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined') is
`false`). |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed'), only reasons of [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') inputs are retained in the output.
If the outcome is [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed'), only reasons of [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') inputs are retained in the output.

<a name='M-Semantica-Checks-Chk-op_False-Semantica-Checks-Chk-'></a>
### op_False() `method`

##### Summary

Determines false-value of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instance.

##### Parameters

This method has no parameters.

##### Remarks

Required for short-circuiting.

<a name='M-Semantica-Checks-Chk-op_LogicalNot-Semantica-Checks-Chk-'></a>
### op_LogicalNot() `method`

##### Summary

Not-operator.

##### Parameters

This method has no parameters.

##### Remarks

Required for short-circuiting.

<a name='M-Semantica-Checks-Chk-op_True-Semantica-Checks-Chk-'></a>
### op_True() `method`

##### Summary

Determines true-value of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instance.

##### Parameters

This method has no parameters.

##### Remarks

Required for short-circuiting.

<a name='T-Semantica-Checks-Chk`1'></a>
## Chk\`1 `type`

##### Namespace

Semantica.Checks

##### Summary

Represents the result of a (`bool`) check, with an optional [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') and [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload')
of type `T`.

##### Remarks

Instances of [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') can be used just as booleans. Short-circuiting is supported for operators `&&`
and `||`. The [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') and [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') are always associated with a certain outcome
([Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') or [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed')). When two instances are combined with an operator, only the reasons that are
associated with the outcome will be present in the result. Multiple applicable reasons are concatenated.
[Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') is [IDeterminable](#T-Semantica-Patterns-IDeterminable 'Semantica.Patterns.IDeterminable'). An undetermined instance has the meaning of _only_
being a reason or payload associated to a specific outcome, and it's value will never influence a binary operator's outcome.

<a name='F-Semantica-Checks-Chk`1-Fail'></a>
### Fail `constants`

##### Summary

A [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') instance.

<a name='F-Semantica-Checks-Chk`1-Pass'></a>
### Pass `constants`

##### Summary

A [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') instance.

<a name='P-Semantica-Checks-Chk`1-Payload'></a>
### Payload `property`

##### Summary

A payload of type `T` associated with this check's [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') or [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed')
value.

<a name='M-Semantica-Checks-Chk`1-Fails-System-String-'></a>
### Fails(failReason) `method`

##### Summary

Makes an instance with a new value for [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason'), but only if the check already [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `failReason` if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), otherwise
[Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'). |

<a name='M-Semantica-Checks-Chk`1-Fails-`0-'></a>
### Fails(payload) `method`

##### Summary

Makes an instance with a new value for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'), but only if the check already [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `payload` if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), otherwise the
[Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0](#T-`0 '`0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'). |

<a name='M-Semantica-Checks-Chk`1-Fails-System-String,`0-'></a>
### Fails(failReason,payload) `method`

##### Summary

Makes an instance with new values for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') and [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason'), but only if the check already
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `failReason` and `payload` if
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), otherwise the [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`, and [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') is
retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'). |
| payload | [\`0](#T-`0 '`0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'). |

<a name='M-Semantica-Checks-Chk`1-Passes-System-String-'></a>
### Passes(passReason) `method`

##### Summary

Makes an instance with a new value for [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason'), but only if the check already [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `passReason` if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise
[Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') is retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'). |

<a name='M-Semantica-Checks-Chk`1-Passes-`0-'></a>
### Passes(payload) `method`

##### Summary

Makes an instance with a value for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'), but only if the check already [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `payload` if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise the
[Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0](#T-`0 '`0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'). |

<a name='M-Semantica-Checks-Chk`1-Passes-System-String,`0-'></a>
### Passes(passReason,payload) `method`

##### Summary

Makes an instance with new values for [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') and [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason'), but only if the check already
[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed').

##### Returns

A new instance of [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') containing `passReason` and `payload` if
[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise the [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') is `default`, and [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') is
retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| passReason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new value of [Reason](#P-Semantica-Checks-Chk`1-Reason 'Semantica.Checks.Chk`1.Reason') if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'). |
| payload | [\`0](#T-`0 '`0') | The value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') if [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'). |

<a name='M-Semantica-Checks-Chk`1-Simplify'></a>
### Simplify() `method`

##### Summary

Drops the payload and returns the non-generic [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk').

##### Returns

[Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') with only value and reason retained.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk`1-Simplify-`0@-'></a>
### Simplify(payload) `method`

##### Summary

Drops the payload and returns the non-generic [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk'), and [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') as out-parameter.

##### Returns

[Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') with only value and reason retained.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0@](#T-`0@ '`0@') | Out-parameter contains the value of [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload'). |

<a name='M-Semantica-Checks-Chk`1-SplitReasons'></a>
### SplitReasons() `method`

##### Summary

If multiple reasons were previously combined, this method can split up these reasons.

##### Returns

A `string[]` containing all the reasons associated with the outcome.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk`1-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk`1-op_BitwiseAnd-Semantica-Checks-Chk{`0},Semantica-Checks-Chk{`0}-'></a>
### op_BitwiseAnd(left,right) `method`

##### Summary

And-operator for two [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') if `left` *and* `right` both [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The left operand. |
| right | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a fail reason or payloads [Fail](#P-Semantica-Checks-Chk`1-Rsn-Fail 'Semantica.Checks.Chk`1.Rsn.Fail') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined')
is `false`). |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), only reasons or payloads of [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') inputs are retained in the
output. If the outcome is [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), only reasons or payloads of [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') inputs are retained in
the output.

<a name='M-Semantica-Checks-Chk`1-op_BitwiseAnd-Semantica-Checks-Chk{`0},Semantica-Checks-Chk-'></a>
### op_BitwiseAnd(left,right) `method`

##### Summary

And-operator for two [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') if `left` *and* `right` both [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The left operand. |
| right | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a fail reason or payloads [Fail](#P-Semantica-Checks-Chk-Rsn-Fail 'Semantica.Checks.Chk.Rsn.Fail') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined') is
`false`). |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), only reasons or payloads of [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') inputs are retained in the
output. If the outcome is [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), only reasons or payloads of [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') inputs are retained in
the output. Cannot be used as short-circuiting operator (`&&`).

<a name='M-Semantica-Checks-Chk`1-op_BitwiseOr-Semantica-Checks-Chk{`0},Semantica-Checks-Chk{`0}-'></a>
### op_BitwiseOr(left,right) `method`

##### Summary

Or-operator for two [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') if `left` *or* `right` have [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The left operand. |
| right | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a pass reason or payloads [Pass](#P-Semantica-Checks-Chk`1-Rsn-Pass 'Semantica.Checks.Chk`1.Rsn.Pass') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined')
is `false`) |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), only reasons or payloads of [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') inputs are retained in the
output. If the outcome is [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), only reasons or payloads of [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') inputs are retained in
the output.

<a name='M-Semantica-Checks-Chk`1-op_BitwiseOr-Semantica-Checks-Chk{`0},Semantica-Checks-Chk-'></a>
### op_BitwiseOr(left,right) `method`

##### Summary

Or-operator for two [Chk\`1](#T-Semantica-Checks-Chk`1 'Semantica.Checks.Chk`1') instances.

##### Returns

[Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') if `left` *or* `right` have [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), otherwise
[Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Semantica.Checks.Chk{\`0}](#T-Semantica-Checks-Chk{`0} 'Semantica.Checks.Chk{`0}') | The left operand. |
| right | [Semantica.Checks.Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') | The right operand. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | When a pass reason or payloads [Pass](#P-Semantica-Checks-Chk`1-Rsn-Pass 'Semantica.Checks.Chk`1.Rsn.Pass') is used as right operand ([IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined')
is `false`) |

##### Remarks

If the outcome is [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed'), only reasons or payloads of [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') inputs are retained in the
output. If the outcome is [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed'), only reasons or payloads of [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') inputs are retained in
the output. Cannot be used as short-circuiing operator (`||`).

<a name='M-Semantica-Checks-Chk`1-op_False-Semantica-Checks-Chk{`0}-'></a>
### op_False() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk`1-op_LogicalNot-Semantica-Checks-Chk{`0}-'></a>
### op_LogicalNot() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Chk`1-op_True-Semantica-Checks-Chk{`0}-'></a>
### op_True() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Semantica-Checks-Exceptions-ContractArgumentException'></a>
## ContractArgumentException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'), meant to be thrown when a contract guard on the arguments of a method fails.

<a name='M-Semantica-Checks-Exceptions-ContractArgumentException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractArgumentException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-ContractArgumentNullException'></a>
## ContractArgumentNullException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException'), meant to be thrown when a contract guard on the arguments of a method
fails.

<a name='M-Semantica-Checks-Exceptions-ContractArgumentNullException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException'></a>
## ContractArgumentOutOfRangeException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException'), meant to be thrown when a contract guard on the arguments of a
method fails.

<a name='M-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-ContractException'></a>
## ContractException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

Provides a number of static methods that create exception instances to be thrown when contract guards fail.

<a name='M-Semantica-Checks-Exceptions-ContractException-Make-System-String-'></a>
### Make() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-Make-System-String,System-String-'></a>
### Make() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeEmpty-System-String-'></a>
### MakeEmpty() `method`

##### Summary

Makes a new [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeEmpty-System-String,System-String-'></a>
### MakeEmpty() `method`

##### Summary

Makes a new [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### MakeFor() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException'), [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException') or
[ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException'), depending on the `check`'s [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### MakeFor() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException'), [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException') or
[ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException'), depending on the `check`'s [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNonNegative-System-String-'></a>
### MakeNonNegative() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNonNegative-System-String,System-String-'></a>
### MakeNonNegative() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNonZero-System-String-'></a>
### MakeNonZero() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNonZero-System-String,System-String-'></a>
### MakeNonZero() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNull-System-String-'></a>
### MakeNull() `method`

##### Summary

Makes a new [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeNull-System-String,System-String-'></a>
### MakeNull() `method`

##### Summary

Makes a new [ContractArgumentNullException](#T-Semantica-Checks-Exceptions-ContractArgumentNullException 'Semantica.Checks.Exceptions.ContractArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeStrictPositive-System-String-'></a>
### MakeStrictPositive() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeStrictPositive-System-String,System-String-'></a>
### MakeStrictPositive() `method`

##### Summary

Makes a new [ContractArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-ContractArgumentOutOfRangeException 'Semantica.Checks.Exceptions.ContractArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeUndefined-System-String-'></a>
### MakeUndefined() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-ContractException-MakeUndefined-System-String,System-String-'></a>
### MakeUndefined() `method`

##### Summary

Makes a new [ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException').

##### Parameters

This method has no parameters.

<a name='T-Semantica-Checks-Guard'></a>
## Guard `type`

##### Namespace

Semantica.Checks

##### Summary

Provides static functions for guarding of all three types [ContractException](#T-Semantica-Checks-Exceptions-ContractException 'Semantica.Checks.Exceptions.ContractException'), [GuardException](#T-Semantica-Checks-Exceptions-GuardException 'Semantica.Checks.Exceptions.GuardException') and
[StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

<a name='M-Semantica-Checks-Guard-Contract-System-Boolean,System-String-'></a>
### Contract(check,expression) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expression to be added as description of failure. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-Contract-System-Boolean,System-String,System-String-'></a>
### Contract(check,description,argumentName) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| argumentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the argument that violates the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### Contract(check) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes when it's failed. |

<a name='M-Semantica-Checks-Guard-Contract-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### Contract(check,description) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes when it's failed. |

<a name='M-Semantica-Checks-Guard-For-System-Boolean,System-String-'></a>
### For(check,expression) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expression to be added as description of failure. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-For-System-Boolean,System-String,System-String-'></a>
### For(check,description,argumentName) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| argumentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the argument that violates the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-For-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### For(check) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes when it's failed. |

<a name='M-Semantica-Checks-Guard-For-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### For(check,description) `method`

##### Summary

Throws if the argument check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes when it's failed. |

<a name='M-Semantica-Checks-Guard-For``1-System-Boolean-'></a>
### For\`\`1(check) `method`

##### Summary

Throws if the state check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-Index-System-Int32,System-Int32-'></a>
### Index(index,end) `method`

##### Summary

Throws if the index is not in range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value of the index to check. |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The exclusive end of the valid range. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') | Throws when index is less than `0`, or greater than or equal to `end`. |

<a name='M-Semantica-Checks-Guard-Index-System-Int32,System-Int32,System-Int32-'></a>
### Index(index,start,end) `method`

##### Summary

Throws if the index is not in range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Value of the index to check. |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The inclusive start of the valid range. |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The exclusive end of the valid range. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') | Throws when index is less than `start`, or greater than or equal to
`end`. |

<a name='M-Semantica-Checks-Guard-State-System-Boolean,System-String-'></a>
### State(check,expression) `method`

##### Summary

Throws if the state check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expression to be added as description of failure. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-State-System-Boolean,System-String,System-String-'></a>
### State(check,description,fieldName) `method`

##### Summary

Throws if the state check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `bool` result of a check. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| fieldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the field that indicates the unexpected state. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws if `check` is `false`. |

<a name='M-Semantica-Checks-Guard-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### State(check) `method`

##### Summary

Throws if the state check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws if `check` has failed. |

<a name='M-Semantica-Checks-Guard-State-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### State(check,description) `method`

##### Summary

Throws if the state check failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws if `check` has failed. |

<a name='T-Semantica-Checks-Exceptions-GuardArgumentException'></a>
## GuardArgumentException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'), meant to be thrown when a guard on the arguments of a method fails.

<a name='M-Semantica-Checks-Exceptions-GuardArgumentException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardArgumentException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-GuardArgumentNullException'></a>
## GuardArgumentNullException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException'), meant to be thrown when a guard on the arguments of a method fails.

<a name='M-Semantica-Checks-Exceptions-GuardArgumentNullException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException'></a>
## GuardArgumentOutOfRangeException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException'), meant to be thrown when a guard on the arguments of a method fails.

<a name='M-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException-#ctor-System-String,System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Checks-Exceptions-GuardException'></a>
## GuardException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

Provides a number of static methods that create exception instances to be thrown when argument guards fail.

<a name='M-Semantica-Checks-Exceptions-GuardException-Make-System-String-'></a>
### Make() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-Make-System-String,System-String-'></a>
### Make() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeEmpty-System-String-'></a>
### MakeEmpty() `method`

##### Summary

Makes a new [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeEmpty-System-String,System-String-'></a>
### MakeEmpty() `method`

##### Summary

Makes a new [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### MakeFor() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException'), [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException') or
[GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException'), depending on the `check`'s [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### MakeFor() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException'), [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException') or
[GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException'), depending on the `check`'s [CheckKind](#T-Semantica-Checks-CheckKind 'Semantica.Checks.CheckKind').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeIndex-System-Int32,System-Int32-'></a>
### MakeIndex() `method`

##### Summary

Makes a new [IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException')

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeMaxValue-System-String-'></a>
### MakeMaxValue() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeMaxValue-System-String,System-String-'></a>
### MakeMaxValue() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNonNegative-System-String-'></a>
### MakeNonNegative() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNonNegative-System-String,System-String-'></a>
### MakeNonNegative() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNonZero-System-String-'></a>
### MakeNonZero() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNonZero-System-String,System-String-'></a>
### MakeNonZero() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNull-System-String-'></a>
### MakeNull() `method`

##### Summary

Makes a new [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeNull-System-String,System-String-'></a>
### MakeNull() `method`

##### Summary

Makes a new [GuardArgumentNullException](#T-Semantica-Checks-Exceptions-GuardArgumentNullException 'Semantica.Checks.Exceptions.GuardArgumentNullException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeStrictPositive-System-String-'></a>
### MakeStrictPositive() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeStrictPositive-System-String,System-String-'></a>
### MakeStrictPositive() `method`

##### Summary

Makes a new [GuardArgumentOutOfRangeException](#T-Semantica-Checks-Exceptions-GuardArgumentOutOfRangeException 'Semantica.Checks.Exceptions.GuardArgumentOutOfRangeException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeUndefined-System-String-'></a>
### MakeUndefined() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-GuardException-MakeUndefined-System-String,System-String-'></a>
### MakeUndefined() `method`

##### Summary

Makes a new [GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException').

##### Parameters

This method has no parameters.

<a name='T-Semantica-Checks-IChk'></a>
## IChk `type`

##### Namespace

Semantica.Checks

##### Summary

Represents the result of a (`bool`) check, with an optional [Reason](#P-Semantica-Checks-IChk-Reason 'Semantica.Checks.IChk.Reason').

<a name='P-Semantica-Checks-IChk-Failed'></a>
### Failed `property`

##### Summary

Not [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed'). Always use [HasFailed](#M-Semantica-Checks-IChk-HasFailed 'Semantica.Checks.IChk.HasFailed') for control flow.

<a name='P-Semantica-Checks-IChk-Passed'></a>
### Passed `property`

##### Summary

Indicates if the [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') has passed or failed, or if the [Reason](#P-Semantica-Checks-IChk-Reason 'Semantica.Checks.IChk.Reason') is associated with passing or
failing. Always use [HasPassed](#M-Semantica-Checks-IChk-HasPassed 'Semantica.Checks.IChk.HasPassed') for control flow.

<a name='P-Semantica-Checks-IChk-Reason'></a>
### Reason `property`

##### Summary

The `string` reason associated with this check's [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed') or [Failed](#P-Semantica-Checks-IChk-Failed 'Semantica.Checks.IChk.Failed') value.

<a name='M-Semantica-Checks-IChk-HasFailed'></a>
### HasFailed() `method`

##### Summary

Has the check [Failed](#P-Semantica-Checks-IChk-Failed 'Semantica.Checks.IChk.Failed') or is it not [IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined'). Use to check the outcome in control
flow for safety.

##### Returns

`true` if either [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed') or [IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined') are `false`.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-IChk-HasPassed'></a>
### HasPassed() `method`

##### Summary

Has the check [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed') and [IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined'). Use to check the outcome in control flow for
safety.

##### Returns

`true` only if [Passed](#P-Semantica-Checks-IChk-Passed 'Semantica.Checks.IChk.Passed') and [IsDetermined](#P-Semantica-Checks-Chk-IsDetermined 'Semantica.Checks.Chk.IsDetermined') are both `true`.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Checks-Chk-Pld'></a>
## Pld `type`

##### Namespace

Semantica.Checks.Chk

##### Summary

Provides static functionality to create [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instances with undetermined outcome. These instances are only
a [Payload](#P-Semantica-Checks-Chk`1-Payload 'Semantica.Checks.Chk`1.Payload') and possibly a [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') associated with a specific eventual outcome.

<a name='M-Semantica-Checks-Chk-Pld-ForFail``1-``0-'></a>
### ForFail\`\`1(payload) `method`

##### Summary

An undetermined value with a fail reason that can be `||`-attached to a determined check, so this expression
will only be evaluated if needed.

##### Returns

Undetermined Failed Chk Payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload for failing. |

<a name='M-Semantica-Checks-Chk-Pld-ForFail``1-``0,System-String-'></a>
### ForFail\`\`1(payload,reason) `method`

##### Summary

An undetermined value with a payload and a fail reason that can be `||`-attached to a determined check, so
this expression will only be evaluated if needed.

##### Returns

Undetermined Failed Chk Payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload for failing. |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The reason for failing. |

<a name='M-Semantica-Checks-Chk-Pld-ForPass``1-``0-'></a>
### ForPass\`\`1(payload) `method`

##### Summary

An undetermined value with a pass reason that can be `&&`-attached to a determined check, so this
expression will only be evaluated if needed.

##### Returns

Undetermined Passed Chk Payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload for passing. |

<a name='M-Semantica-Checks-Chk-Pld-ForPass``1-``0,System-String-'></a>
### ForPass\`\`1(payload,reason) `method`

##### Summary

An undetermined value with a payload and a pass reason that can be `&&`-attached to a determined check,
so this expression will only be evaluated if needed

##### Returns

Undetermined Passed Chk Payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload for passing. |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The reason for passing. |

<a name='T-Semantica-Checks-Chk-Rsn'></a>
## Rsn `type`

##### Namespace

Semantica.Checks.Chk

##### Summary

Provides static functionality to create [Chk](#T-Semantica-Checks-Chk 'Semantica.Checks.Chk') instances with undetermined outcome.
These instances are only a [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') associated with a specific eventual outcome.

<a name='T-Semantica-Checks-Chk`1-Rsn'></a>
## Rsn `type`

##### Namespace

Semantica.Checks.Chk`1

##### Summary

*Inherit from parent.*

<a name='P-Semantica-Checks-Chk-Rsn-Fail'></a>
### Fail `property`

##### Summary

An undetermined [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') instance.

<a name='P-Semantica-Checks-Chk-Rsn-Pass'></a>
### Pass `property`

##### Summary

An undetermined [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') instance.

<a name='P-Semantica-Checks-Chk`1-Rsn-Fail'></a>
### Fail `property`

##### Summary

An undetermined [Failed](#P-Semantica-Checks-Chk`1-Failed 'Semantica.Checks.Chk`1.Failed') instance.

<a name='P-Semantica-Checks-Chk`1-Rsn-Pass'></a>
### Pass `property`

##### Summary

An undetermined [Passed](#P-Semantica-Checks-Chk`1-Passed 'Semantica.Checks.Chk`1.Passed') instance.

<a name='M-Semantica-Checks-Chk-Rsn-ForFail-System-String-'></a>
### ForFail(reason) `method`

##### Summary

An undetermined value with a failure reason that can be `||`-attached to a determined check, so this
expression will only be evaluated if needed, and short-circuited if not.

##### Returns

Undetermined [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') for failure. |

<a name='M-Semantica-Checks-Chk-Rsn-ForFail``1-System-String-'></a>
### ForFail\`\`1(reason) `method`

##### Summary

An undetermined value with a failure reason that can be `||`-attached to a determined check, so this
expression will only be evaluated if needed, and short-circuited if not.

##### Returns

Undetermined [Failed](#P-Semantica-Checks-Chk-Failed 'Semantica.Checks.Chk.Failed') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') for failure |

<a name='M-Semantica-Checks-Chk-Rsn-ForPass-System-String-'></a>
### ForPass(reason) `method`

##### Summary

An undetermined value with a pass reason that can be `&&`-attached to a determined check, so this
expression will only be evaluated if needed, and short-circuited if not.

##### Returns

Undetermined [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') for passing. |

<a name='M-Semantica-Checks-Chk-Rsn-ForPass``1-System-String-'></a>
### ForPass\`\`1(reason) `method`

##### Summary

An undetermined value with a pass reason that can be `&&`-attached to a determined check, so this
expression will only be evaluated if needed, and short-circuited if not.

##### Returns

Undetermined [Passed](#P-Semantica-Checks-Chk-Passed 'Semantica.Checks.Chk.Passed') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [Reason](#P-Semantica-Checks-Chk-Reason 'Semantica.Checks.Chk.Reason') for passing. |

<a name='T-Semantica-Checks-Exceptions-StateException'></a>
## StateException `type`

##### Namespace

Semantica.Checks.Exceptions

##### Summary

A subtype of [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException'), meant to be thrown when a guard on the state when calling an instance
method fails.

Also provides a number of static methods that create exception instances.

<a name='M-Semantica-Checks-Exceptions-StateException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-Make-System-String-'></a>
### Make() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-Make-System-String,System-String-'></a>
### Make() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeEmpty-System-String,System-String-'></a>
### MakeEmpty() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### MakeFor() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### MakeFor() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeNonNegative-System-String,System-String-'></a>
### MakeNonNegative() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeNonZero-System-String,System-String-'></a>
### MakeNonZero() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeNull-System-String,System-String-'></a>
### MakeNull() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeStrictPositive-System-String,System-String-'></a>
### MakeStrictPositive() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Checks-Exceptions-StateException-MakeUndefined-System-String,System-String-'></a>
### MakeUndefined() `method`

##### Summary

Makes a new [StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException').

##### Parameters

This method has no parameters.

<a name='T-Semantica-Checks-Throw'></a>
## Throw `type`

##### Namespace

Semantica.Checks

##### Summary

Static helper methods that always throw an exception

<a name='M-Semantica-Checks-Throw-Contract-System-String-'></a>
### Contract(expression) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Expression that violated the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException') | Throws always. |

<a name='M-Semantica-Checks-Throw-Contract-System-String,System-String-'></a>
### Contract(description,argumentName) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| argumentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the argument that violates the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.ContractArgumentException](#T-Semantica-Checks-Exceptions-ContractArgumentException 'Semantica.Checks.Exceptions.ContractArgumentException') | Throws always. |

<a name='M-Semantica-Checks-Throw-ContractFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### ContractFor(check) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes. |

<a name='M-Semantica-Checks-Throw-ContractFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### ContractFor(description,check) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Description added to the thrown exception. |
| check | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Check result, optionally containing the kind of check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the contract-subtypes. |

<a name='M-Semantica-Checks-Throw-Guard-System-String-'></a>
### Guard(expression) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Expression that violated the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException') | Throws always. |

<a name='M-Semantica-Checks-Throw-Guard-System-String,System-String-'></a>
### Guard(description,argumentName) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| argumentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the argument that violates the code contract. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.GuardArgumentException](#T-Semantica-Checks-Exceptions-GuardArgumentException 'Semantica.Checks.Exceptions.GuardArgumentException') | Throws always. |

<a name='M-Semantica-Checks-Throw-GuardFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind}-'></a>
### GuardFor(check) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes. |

<a name='M-Semantica-Checks-Throw-GuardFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### GuardFor(description,check) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Description added to the thrown exception. |
| check | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Check result, optionally containing the kind of check. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Depending on the kind of check, throws one of the guard-subtypes. |

<a name='M-Semantica-Checks-Throw-State-System-String-'></a>
### State(expression) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Expression that failed the state guard. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws always. |

<a name='M-Semantica-Checks-Throw-State-System-String,System-String-'></a>
### State(description,fieldName) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Description added to the thrown exception. |
| fieldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the field that indicates the unexpected state. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws always. |

<a name='M-Semantica-Checks-Throw-StateFor-Semantica-Checks-Chk{Semantica-Checks-CheckKind},System-String-'></a>
### StateFor(check,fieldName) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| check | [Semantica.Checks.Chk{Semantica.Checks.CheckKind}](#T-Semantica-Checks-Chk{Semantica-Checks-CheckKind} 'Semantica.Checks.Chk{Semantica.Checks.CheckKind}') | Check result, optionally containing the kind of check and/or description. |
| fieldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the field that indicates the unexpected state. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Checks.Exceptions.StateException](#T-Semantica-Checks-Exceptions-StateException 'Semantica.Checks.Exceptions.StateException') | Throws always. |
