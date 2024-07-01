<a name='assembly'></a>
# Lib.Intervals

## Contents

- [EmptyUnbindsInterval\`1](#T-Semantica-Intervals-EmptyUnbindsInterval`1 'Semantica.Intervals.EmptyUnbindsInterval`1')
- [IIntervalDictionary\`2](#T-Semantica-Intervals-IIntervalDictionary`2 'Semantica.Intervals.IIntervalDictionary`2')
- [IIntervalDictionary\`3](#T-Semantica-Intervals-IIntervalDictionary`3 'Semantica.Intervals.IIntervalDictionary`3')
  - [Item](#P-Semantica-Intervals-IIntervalDictionary`3-Item-`1- 'Semantica.Intervals.IIntervalDictionary`3.Item(`1)')
  - [Add(keyInterval,value)](#M-Semantica-Intervals-IIntervalDictionary`3-Add-`1,`2- 'Semantica.Intervals.IIntervalDictionary`3.Add(`1,`2)')
  - [Contains(interval)](#M-Semantica-Intervals-IIntervalDictionary`3-Contains-`1- 'Semantica.Intervals.IIntervalDictionary`3.Contains(`1)')
  - [TryGet(key,value)](#M-Semantica-Intervals-IIntervalDictionary`3-TryGet-`0,`2@- 'Semantica.Intervals.IIntervalDictionary`3.TryGet(`0,`2@)')
  - [TryGetInterval(key,interval)](#M-Semantica-Intervals-IIntervalDictionary`3-TryGetInterval-`0,`1@- 'Semantica.Intervals.IIntervalDictionary`3.TryGetInterval(`0,`1@)')
- [IInterval\`1](#T-Semantica-Intervals-IInterval`1 'Semantica.Intervals.IInterval`1')
- [IReadOnlyIntervalDictionary\`2](#T-Semantica-Intervals-IReadOnlyIntervalDictionary`2 'Semantica.Intervals.IReadOnlyIntervalDictionary`2')
- [IReadOnlyIntervalDictionary\`3](#T-Semantica-Intervals-IReadOnlyIntervalDictionary`3 'Semantica.Intervals.IReadOnlyIntervalDictionary`3')
  - [Intervals](#P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Intervals 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.Intervals')
  - [Item](#P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Item-`0- 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.Item(`0)')
  - [Values](#P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Values 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.Values')
  - [Contains(key)](#M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Contains-`0- 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.Contains(`0)')
  - [IntervalsAscending()](#M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-IntervalsAscending 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.IntervalsAscending')
  - [IntervalsDescending()](#M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-IntervalsDescending 'Semantica.Intervals.IReadOnlyIntervalDictionary`3.IntervalsDescending')
- [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1')
  - [BoundKind](#P-Semantica-Intervals-IReadOnlyInterval`1-BoundKind 'Semantica.Intervals.IReadOnlyInterval`1.BoundKind')
  - [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left')
  - [OpenKind](#P-Semantica-Intervals-IReadOnlyInterval`1-OpenKind 'Semantica.Intervals.IReadOnlyInterval`1.OpenKind')
  - [Right](#P-Semantica-Intervals-IReadOnlyInterval`1-Right 'Semantica.Intervals.IReadOnlyInterval`1.Right')
  - [IsDegenerate()](#M-Semantica-Intervals-IReadOnlyInterval`1-IsDegenerate 'Semantica.Intervals.IReadOnlyInterval`1.IsDegenerate')
- [Interval](#T-Semantica-Intervals-Interval 'Semantica.Intervals.Interval')
  - [DetermineBoundKind(isLeftUnbound,isRightUnbound)](#M-Semantica-Intervals-Interval-DetermineBoundKind-System-Boolean,System-Boolean- 'Semantica.Intervals.Interval.DetermineBoundKind(System.Boolean,System.Boolean)')
  - [DetermineDegenerateEmpty\`\`1(left,right,openKind,boundKind)](#M-Semantica-Intervals-Interval-DetermineDegenerateEmpty``1-``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval.DetermineDegenerateEmpty``1(``0,``0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind)')
  - [DetermineOpenKind(isLeftOpen,isRightOpen,boundKind)](#M-Semantica-Intervals-Interval-DetermineOpenKind-System-Boolean,System-Boolean,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval.DetermineOpenKind(System.Boolean,System.Boolean,Semantica.Intervals.IntervalBoundKind)')
  - [Empty\`\`1()](#M-Semantica-Intervals-Interval-Empty``1 'Semantica.Intervals.Interval.Empty``1')
  - [Equals\`\`1(x,y)](#M-Semantica-Intervals-Interval-Equals``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.Interval.Equals``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [Guard\`\`1(left,right,boundKind)](#M-Semantica-Intervals-Interval-Guard``1-``0,``0,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval.Guard``1(``0,``0,Semantica.Intervals.IntervalBoundKind)')
  - [MakeDegenerate\`\`1(degenerateValue)](#M-Semantica-Intervals-Interval-MakeDegenerate``1-``0- 'Semantica.Intervals.Interval.MakeDegenerate``1(``0)')
  - [MakeHalfOpen\`\`1(left,right)](#M-Semantica-Intervals-Interval-MakeHalfOpen``1-``0,``0- 'Semantica.Intervals.Interval.MakeHalfOpen``1(``0,``0)')
  - [MakeHalfOpen\`\`1(left,right,unboundPredicate)](#M-Semantica-Intervals-Interval-MakeHalfOpen``1-``0,``0,System-Func{``0,System-Boolean}- 'Semantica.Intervals.Interval.MakeHalfOpen``1(``0,``0,System.Func{``0,System.Boolean})')
  - [MakeLeftUnbound\`\`1(right,openKind)](#M-Semantica-Intervals-Interval-MakeLeftUnbound``1-``0,Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.Interval.MakeLeftUnbound``1(``0,Semantica.Intervals.IntervalOpenKind)')
  - [MakeRightUnbound\`\`1(left,openKind)](#M-Semantica-Intervals-Interval-MakeRightUnbound``1-``0,Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.Interval.MakeRightUnbound``1(``0,Semantica.Intervals.IntervalOpenKind)')
  - [Make\`\`1(left,right,openKind,boundKind)](#M-Semantica-Intervals-Interval-Make``1-``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval.Make``1(``0,``0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind)')
  - [Make\`\`1(left,right,openKind,unboundPredicate)](#M-Semantica-Intervals-Interval-Make``1-``0,``0,Semantica-Intervals-IntervalOpenKind,System-Func{``0,System-Boolean}- 'Semantica.Intervals.Interval.Make``1(``0,``0,Semantica.Intervals.IntervalOpenKind,System.Func{``0,System.Boolean})')
  - [ToStringTryFormat\`\`1(interval,format,formatProvider)](#M-Semantica-Intervals-Interval-ToStringTryFormat``1-Semantica-Intervals-IReadOnlyInterval{``0},System-String,System-IFormatProvider- 'Semantica.Intervals.Interval.ToStringTryFormat``1(Semantica.Intervals.IReadOnlyInterval{``0},System.String,System.IFormatProvider)')
  - [ToString\`\`1(interval)](#M-Semantica-Intervals-Interval-ToString``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.Interval.ToString``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [ToString\`\`1(interval,format,formatProvider)](#M-Semantica-Intervals-Interval-ToString``1-Semantica-Intervals-IReadOnlyInterval{``0},System-String,System-IFormatProvider- 'Semantica.Intervals.Interval.ToString``1(Semantica.Intervals.IReadOnlyInterval{``0},System.String,System.IFormatProvider)')
  - [ToString\`\`1(left,right,isEmpty,openKind,boundKind,format,formatProvider)](#M-Semantica-Intervals-Interval-ToString``1-``0,``0,System-Boolean,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,System-String,System-IFormatProvider- 'Semantica.Intervals.Interval.ToString``1(``0,``0,System.Boolean,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind,System.String,System.IFormatProvider)')
- [IntervalBase\`1](#T-Semantica-Intervals-IntervalBase`1 'Semantica.Intervals.IntervalBase`1')
  - [#ctor(left,right,boundKind)](#M-Semantica-Intervals-IntervalBase`1-#ctor-`0,`0,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalBase`1.#ctor(`0,`0,Semantica.Intervals.IntervalBoundKind)')
  - [#ctor(interval)](#M-Semantica-Intervals-IntervalBase`1-#ctor-Semantica-Intervals-IReadOnlyInterval{`0}- 'Semantica.Intervals.IntervalBase`1.#ctor(Semantica.Intervals.IReadOnlyInterval{`0})')
  - [#ctor(interval)](#M-Semantica-Intervals-IntervalBase`1-#ctor-System-ValueTuple{`0,`0}- 'Semantica.Intervals.IntervalBase`1.#ctor(System.ValueTuple{`0,`0})')
  - [IsLeftOpen](#P-Semantica-Intervals-IntervalBase`1-IsLeftOpen 'Semantica.Intervals.IntervalBase`1.IsLeftOpen')
  - [IsLeftUnbound](#P-Semantica-Intervals-IntervalBase`1-IsLeftUnbound 'Semantica.Intervals.IntervalBase`1.IsLeftUnbound')
  - [IsRightOpen](#P-Semantica-Intervals-IntervalBase`1-IsRightOpen 'Semantica.Intervals.IntervalBase`1.IsRightOpen')
  - [IsRightUnbound](#P-Semantica-Intervals-IntervalBase`1-IsRightUnbound 'Semantica.Intervals.IntervalBase`1.IsRightUnbound')
  - [TypeName](#P-Semantica-Intervals-IntervalBase`1-TypeName 'Semantica.Intervals.IntervalBase`1.TypeName')
- [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind')
- [IntervalDictionaryExtensions](#T-Semantica-Intervals-IntervalDictionaryExtensions 'Semantica.Intervals.IntervalDictionaryExtensions')
  - [GetIntervalWithLeft\`\`3(dictionary,left)](#M-Semantica-Intervals-IntervalDictionaryExtensions-GetIntervalWithLeft``3-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2},``0- 'Semantica.Intervals.IntervalDictionaryExtensions.GetIntervalWithLeft``3(Semantica.Intervals.IReadOnlyIntervalDictionary{``0,``1,``2},``0)')
  - [TryGetIntervalWithLeft\`\`3(dictionary,left,interval)](#M-Semantica-Intervals-IntervalDictionaryExtensions-TryGetIntervalWithLeft``3-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2},``0,``1@- 'Semantica.Intervals.IntervalDictionaryExtensions.TryGetIntervalWithLeft``3(Semantica.Intervals.IReadOnlyIntervalDictionary{``0,``1,``2},``0,``1@)')
- [IntervalDictionary\`2](#T-Semantica-Intervals-IntervalDictionary`2 'Semantica.Intervals.IntervalDictionary`2')
  - [#ctor()](#M-Semantica-Intervals-IntervalDictionary`2-#ctor 'Semantica.Intervals.IntervalDictionary`2.#ctor')
  - [#ctor()](#M-Semantica-Intervals-IntervalDictionary`2-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{Semantica-Intervals-IInterval{`0},`1}}- 'Semantica.Intervals.IntervalDictionary`2.#ctor(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{Semantica.Intervals.IInterval{`0},`1}})')
  - [#ctor()](#M-Semantica-Intervals-IntervalDictionary`2-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{Semantica-Intervals-IInterval{`0},`1}}- 'Semantica.Intervals.IntervalDictionary`2.#ctor(System.Collections.Generic.IEnumerable{System.ValueTuple{Semantica.Intervals.IInterval{`0},`1}})')
- [IntervalDictionary\`3](#T-Semantica-Intervals-IntervalDictionary`3 'Semantica.Intervals.IntervalDictionary`3')
  - [#ctor()](#M-Semantica-Intervals-IntervalDictionary`3-#ctor 'Semantica.Intervals.IntervalDictionary`3.#ctor')
  - [#ctor(pairs)](#M-Semantica-Intervals-IntervalDictionary`3-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{`1,`2}}- 'Semantica.Intervals.IntervalDictionary`3.#ctor(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{`1,`2}})')
  - [#ctor(tuples)](#M-Semantica-Intervals-IntervalDictionary`3-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{`1,`2}}- 'Semantica.Intervals.IntervalDictionary`3.#ctor(System.Collections.Generic.IEnumerable{System.ValueTuple{`1,`2}})')
- [IntervalEnumerationExtensions](#T-Semantica-Intervals-IntervalEnumerationExtensions 'Semantica.Intervals.IntervalEnumerationExtensions')
  - [Extend\`\`1(intervals)](#M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``1-System-Collections-Generic-IEnumerable{Semantica-Intervals-EmptyUnbindsInterval{``0}}- 'Semantica.Intervals.IntervalEnumerationExtensions.Extend``1(System.Collections.Generic.IEnumerable{Semantica.Intervals.EmptyUnbindsInterval{``0}})')
  - [Extend\`\`1(intervals)](#M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``1-System-Collections-Generic-IEnumerable{Semantica-Intervals-Interval{``0}}- 'Semantica.Intervals.IntervalEnumerationExtensions.Extend``1(System.Collections.Generic.IEnumerable{Semantica.Intervals.Interval{``0}})')
  - [Extend\`\`2(intervals,factory)](#M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``2-System-Collections-Generic-IEnumerable{``1},System-Func{``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,``1}- 'Semantica.Intervals.IntervalEnumerationExtensions.Extend``2(System.Collections.Generic.IEnumerable{``1},System.Func{``0,``0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind,``1})')
  - [ToIntervalDictionary\`\`2(enumerable)](#M-Semantica-Intervals-IntervalEnumerationExtensions-ToIntervalDictionary``2-System-Collections-Generic-IEnumerable{System-ValueTuple{Semantica-Intervals-IInterval{``0},``1}}- 'Semantica.Intervals.IntervalEnumerationExtensions.ToIntervalDictionary``2(System.Collections.Generic.IEnumerable{System.ValueTuple{Semantica.Intervals.IInterval{``0},``1}})')
  - [ToIntervalDictionary\`\`3(enumerable)](#M-Semantica-Intervals-IntervalEnumerationExtensions-ToIntervalDictionary``3-System-Collections-Generic-IEnumerable{System-ValueTuple{``1,``2}}- 'Semantica.Intervals.IntervalEnumerationExtensions.ToIntervalDictionary``3(System.Collections.Generic.IEnumerable{System.ValueTuple{``1,``2}})')
  - [ToLowerboundIntervalPairs\`\`2(values,leftFunc,finalRight)](#M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalPairs``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},``1- 'Semantica.Intervals.IntervalEnumerationExtensions.ToLowerboundIntervalPairs``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},``1)')
  - [ToLowerboundIntervalTuples\`\`2(values,leftFunc,finalRight)](#M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalTuples``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},``1- 'Semantica.Intervals.IntervalEnumerationExtensions.ToLowerboundIntervalTuples``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},``1)')
  - [ToLowerboundIntervalTuples\`\`3(values,intervalFactory,leftFunc,finalRight)](#M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalTuples``3-System-Collections-Generic-IEnumerable{``0},System-Func{``1,``1,``2},System-Func{``0,``1},``1- 'Semantica.Intervals.IntervalEnumerationExtensions.ToLowerboundIntervalTuples``3(System.Collections.Generic.IEnumerable{``0},System.Func{``1,``1,``2},System.Func{``0,``1},``1)')
- [IntervalExtensions](#T-Semantica-Intervals-IntervalExtensions 'Semantica.Intervals.IntervalExtensions')
  - [Convert\`\`2(interval,convertFunc)](#M-Semantica-Intervals-IntervalExtensions-Convert``2-Semantica-Intervals-IReadOnlyInterval{``0},System-Func{``0,``1}- 'Semantica.Intervals.IntervalExtensions.Convert``2(Semantica.Intervals.IReadOnlyInterval{``0},System.Func{``0,``1})')
  - [Extend\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-Extend``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.Extend``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsAnyLeftOf\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-IsAnyLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsAnyLeftOf``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsAnyLeftOf\`\`1(interval,value)](#M-Semantica-Intervals-IntervalExtensions-IsAnyLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},``0- 'Semantica.Intervals.IntervalExtensions.IsAnyLeftOf``1(Semantica.Intervals.IReadOnlyInterval{``0},``0)')
  - [IsAnyRightOf\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-IsAnyRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsAnyRightOf``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsAnyRightOf\`\`1(interval,value)](#M-Semantica-Intervals-IntervalExtensions-IsAnyRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},``0- 'Semantica.Intervals.IntervalExtensions.IsAnyRightOf``1(Semantica.Intervals.IReadOnlyInterval{``0},``0)')
  - [IsLeftOf\`\`1(value,interval)](#M-Semantica-Intervals-IntervalExtensions-IsLeftOf``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsLeftOf``1(``0,Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsLeftOf\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-IsLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsLeftOf``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightOf\`\`1(value,interval)](#M-Semantica-Intervals-IntervalExtensions-IsRightOf``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsRightOf``1(``0,Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightOf\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-IsRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsRightOf``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsWithin\`\`1(value,interval)](#M-Semantica-Intervals-IntervalExtensions-IsWithin``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsWithin``1(``0,Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsWithin\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-IsWithin``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.IsWithin``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [Overlaps\`\`1(interval,otherInterval)](#M-Semantica-Intervals-IntervalExtensions-Overlaps``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalExtensions.Overlaps``1(Semantica.Intervals.IReadOnlyInterval{``0},Semantica.Intervals.IReadOnlyInterval{``0})')
  - [TryDegenerateValue\`\`1(interval,degenerateValue)](#M-Semantica-Intervals-IntervalExtensions-TryDegenerateValue``1-Semantica-Intervals-IReadOnlyInterval{``0},``0@- 'Semantica.Intervals.IntervalExtensions.TryDegenerateValue``1(Semantica.Intervals.IReadOnlyInterval{``0},``0@)')
- [IntervalKindExtensions](#T-Semantica-Intervals-IntervalKindExtensions 'Semantica.Intervals.IntervalKindExtensions')
  - [IsHalfOpen()](#M-Semantica-Intervals-IntervalKindExtensions-IsHalfOpen-Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.IntervalKindExtensions.IsHalfOpen(Semantica.Intervals.IntervalOpenKind)')
  - [IsHalfOpen\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsHalfOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsHalfOpen``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsLeftBounded()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftBounded-Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalKindExtensions.IsLeftBounded(Semantica.Intervals.IntervalBoundKind)')
  - [IsLeftBounded\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftBounded``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsLeftBounded``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsLeftClosed()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftClosed-Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.IntervalKindExtensions.IsLeftClosed(Semantica.Intervals.IntervalOpenKind)')
  - [IsLeftClosed\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftClosed``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsLeftClosed``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsLeftOpen()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftOpen-Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.IntervalKindExtensions.IsLeftOpen(Semantica.Intervals.IntervalOpenKind)')
  - [IsLeftOpen\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsLeftOpen``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsLeftUnbound()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftUnbound-Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalKindExtensions.IsLeftUnbound(Semantica.Intervals.IntervalBoundKind)')
  - [IsLeftUnbound\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsLeftUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsLeftUnbound``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightBounded()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightBounded-Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalKindExtensions.IsRightBounded(Semantica.Intervals.IntervalBoundKind)')
  - [IsRightBounded\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightBounded``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsRightBounded``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightClosed()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightClosed-Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.IntervalKindExtensions.IsRightClosed(Semantica.Intervals.IntervalOpenKind)')
  - [IsRightClosed\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightClosed``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsRightClosed``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightOpen()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightOpen-Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.IntervalKindExtensions.IsRightOpen(Semantica.Intervals.IntervalOpenKind)')
  - [IsRightOpen\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsRightOpen``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsRightUnbound()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightUnbound-Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalKindExtensions.IsRightUnbound(Semantica.Intervals.IntervalBoundKind)')
  - [IsRightUnbound\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsRightUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsRightUnbound``1(Semantica.Intervals.IReadOnlyInterval{``0})')
  - [IsUnbound()](#M-Semantica-Intervals-IntervalKindExtensions-IsUnbound-Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.IntervalKindExtensions.IsUnbound(Semantica.Intervals.IntervalBoundKind)')
  - [IsUnbound\`\`1()](#M-Semantica-Intervals-IntervalKindExtensions-IsUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}- 'Semantica.Intervals.IntervalKindExtensions.IsUnbound``1(Semantica.Intervals.IReadOnlyInterval{``0})')
- [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind')
- [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1')
  - [#ctor(left,right,openKind,boundKind)](#M-Semantica-Intervals-Interval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval`1.#ctor(`0,`0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind)')
  - [#ctor(interval)](#M-Semantica-Intervals-Interval`1-#ctor-Semantica-Intervals-IReadOnlyInterval{`0}- 'Semantica.Intervals.Interval`1.#ctor(Semantica.Intervals.IReadOnlyInterval{`0})')
  - [#ctor()](#M-Semantica-Intervals-Interval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,System-Boolean,System-Boolean- 'Semantica.Intervals.Interval`1.#ctor(`0,`0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind,System.Boolean,System.Boolean)')
  - [_flags](#F-Semantica-Intervals-Interval`1-_flags 'Semantica.Intervals.Interval`1._flags')
- [TargetInterval\`1](#T-Semantica-Intervals-TargetInterval`1 'Semantica.Intervals.TargetInterval`1')
  - [#ctor(targetValue,margin,openKind)](#M-Semantica-Intervals-TargetInterval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind- 'Semantica.Intervals.TargetInterval`1.#ctor(`0,`0,Semantica.Intervals.IntervalOpenKind)')
  - [Margin](#P-Semantica-Intervals-TargetInterval`1-Margin 'Semantica.Intervals.TargetInterval`1.Margin')
  - [TargetValue](#P-Semantica-Intervals-TargetInterval`1-TargetValue 'Semantica.Intervals.TargetInterval`1.TargetValue')

<a name='T-Semantica-Intervals-EmptyUnbindsInterval`1'></a>
## EmptyUnbindsInterval\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

##### Summary

A class implementing [IInterval\`1](#T-Semantica-Intervals-IInterval`1 'Semantica.Intervals.IInterval`1'), where the bounds implement [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'), where if
calling [IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') for a bound returns `true`, that bound is considered unbounded.

<a name='T-Semantica-Intervals-IIntervalDictionary`2'></a>
## IIntervalDictionary\`2 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

##### Summary

A generic collection of [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') of keys and associated values. Intervals are not allowed to
overlap.

<a name='T-Semantica-Intervals-IIntervalDictionary`3'></a>
## IIntervalDictionary\`3 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

##### Summary

A generic collection of intervals of keys and associated values. Intervals are not allowed to overlap.

<a name='P-Semantica-Intervals-IIntervalDictionary`3-Item-`1-'></a>
### Item `property`

##### Summary

`get`: Searches the dictionary for the exact provided `interval` and returns the
associated value.

`set`: If the exact provided `interval` is present in the dictionary the currently
associated value is replaced by `value`. Tries to adds the interval and value otherwise. Throws if
interval partly overlaps with an existing interval.

##### Returns

Value associated with the `interval`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [\`1](#T-`1 '`1') | Interval to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Collections.Generic.KeyNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException') | Throws on `get` if `interval` is not present in the dictionary. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws on `set` if `interval` partly overlaps with any existing interval. |

<a name='M-Semantica-Intervals-IIntervalDictionary`3-Add-`1,`2-'></a>
### Add(keyInterval,value) `method`

##### Summary

Adds an element to the dictionary consisting of the specified key interval and associated value, but only if the
interval does not overlap with a key interval already in the dictionary.

##### Returns

`true` if the element is added; `false` if `keyInterval` overlaps with
any of the key intervals already in the dictionary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyInterval | [\`1](#T-`1 '`1') | The interval of keys associated with the value to add. |
| value | [\`2](#T-`2 '`2') | The value to add. |

<a name='M-Semantica-Intervals-IIntervalDictionary`3-Contains-`1-'></a>
### Contains(interval) `method`

##### Summary

Determines whether the dictionary contains en element with the exact provided interval.

##### Returns

`true` if the dictionary contains the exact `interval`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [\`1](#T-`1 '`1') | Interval to search for. |

<a name='M-Semantica-Intervals-IIntervalDictionary`3-TryGet-`0,`2@-'></a>
### TryGet(key,value) `method`

##### Summary

Searches for an interval containing `key` and returns the associated `TValue`
value as out parameter `value`.

##### Returns

`true` if the dictionary contains an interval has `key` within it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | The key to locate the value for. |
| value | [\`2@](#T-`2@ '`2@') | Value associated with the `key`; or `default` if not found. |

<a name='M-Semantica-Intervals-IIntervalDictionary`3-TryGetInterval-`0,`1@-'></a>
### TryGetInterval(key,interval) `method`

##### Summary

Searches for an interval containing `key` and returns it as out parameter `interval`.

##### Returns

`true` if the dictionary contains an interval has `key` within it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | The key to locate the value for. |
| interval | [\`1@](#T-`1@ '`1@') | Out parameter containing the found interval, or `default` if not found. |

<a name='T-Semantica-Intervals-IInterval`1'></a>
## IInterval\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

<a name='T-Semantica-Intervals-IReadOnlyIntervalDictionary`2'></a>
## IReadOnlyIntervalDictionary\`2 `type`

##### Namespace

Semantica.Intervals

##### Summary

A generic read-only collection of [IInterval\`1](#T-Semantica-Intervals-IInterval`1 'Semantica.Intervals.IInterval`1') of keys and associated values. Intervals are not
allowed to overlap.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of keys and the bounds of the intervals. |
| TValue | Type of values stored in the dictionary. |

<a name='T-Semantica-Intervals-IReadOnlyIntervalDictionary`3'></a>
## IReadOnlyIntervalDictionary\`3 `type`

##### Namespace

Semantica.Intervals

##### Summary

A generic read-only collection of intervals of keys and associated values. Intervals are not allowed to overlap.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of keys and the bounds of the intervals. |
| TInterval | Type of the intervals. |
| TValue | Type of values stored in the dictionary. |

<a name='P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Intervals'></a>
### Intervals `property`

##### Summary

Collection of intervals in the dictionary in no specified order (typically in order they were added).

<a name='P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Item-`0-'></a>
### Item `property`

##### Summary

Searches for an interval containing `key` and returns the associated `TValue` value.

##### Returns

Value associated with the `key`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | The key to locate the interval for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Collections.Generic.KeyNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException') | Throws if `key` is not part of any interval. |

<a name='P-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Values'></a>
### Values `property`

##### Summary

Collection of values in the dictionary in no specified order (typically in order they were added).

<a name='M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-Contains-`0-'></a>
### Contains(key) `method`

##### Summary

Determines whether the dictionary contains an interval that has the specified key within it.

##### Returns

`true` if in interval in dictionary contains `key`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | Key to search for. |

<a name='M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-IntervalsAscending'></a>
### IntervalsAscending() `method`

##### Summary

Enumerates all intervals in the dictionary in ascending logical order of values.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IReadOnlyIntervalDictionary`3-IntervalsDescending'></a>
### IntervalsDescending() `method`

##### Summary

Enumerates all intervals in the dictionary in descending logical order of values.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Intervals-IReadOnlyInterval`1'></a>
## IReadOnlyInterval\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

Represents an interval of values. The interval is considered empty if it has either no, or a single value (a degenerate
interval).

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Remarks

Implementations have to guarantee that [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left') is not greater than [Right](#P-Semantica-Intervals-IReadOnlyInterval`1-Right 'Semantica.Intervals.IReadOnlyInterval`1.Right').
Obviously, when T is not immutable this cannot be guaranteed after creation.

<a name='P-Semantica-Intervals-IReadOnlyInterval`1-BoundKind'></a>
### BoundKind `property`

##### Summary

Indicates if the interval is fully bound, or left- and/or right-unbound.

##### Remarks

When a side is unbound, that boundary's property are never used for comparisons.

<a name='P-Semantica-Intervals-IReadOnlyInterval`1-Left'></a>
### Left `property`

<a name='P-Semantica-Intervals-IReadOnlyInterval`1-OpenKind'></a>
### OpenKind `property`

##### Summary

Indicates if the interval is closed on both sides, or left- and/or right-open.

<a name='P-Semantica-Intervals-IReadOnlyInterval`1-Right'></a>
### Right `property`

<a name='M-Semantica-Intervals-IReadOnlyInterval`1-IsDegenerate'></a>
### IsDegenerate() `method`

##### Summary

`true` if the interval has only a single element.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Intervals-Interval'></a>
## Interval `type`

##### Namespace

Semantica.Intervals

##### Summary

Provides static methods used with [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') and [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1').

<a name='M-Semantica-Intervals-Interval-DetermineBoundKind-System-Boolean,System-Boolean-'></a>
### DetermineBoundKind(isLeftUnbound,isRightUnbound) `method`

##### Summary

Determines the appropriate [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') value from two boolean values indicating if a side is
unbound.

##### Returns

[IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating an intervals bound/unbound value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isLeftUnbound | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the left side is unbound. |
| isRightUnbound | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the right side is unbound. |

<a name='M-Semantica-Intervals-Interval-DetermineDegenerateEmpty``1-``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind-'></a>
### DetermineDegenerateEmpty\`\`1(left,right,openKind,boundKind) `method`

##### Summary

Determines if parameter values would constitute an empty or degenerate interval.

##### Returns

A tuple `(bool isDegenerate, bool isEmpty)` with two values where `true` indicates
if the interval would be degenerate or empty respectively. Both values can never be `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating if any bounds are open. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating whether sides are bound or unbound. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval-DetermineOpenKind-System-Boolean,System-Boolean,Semantica-Intervals-IntervalBoundKind-'></a>
### DetermineOpenKind(isLeftOpen,isRightOpen,boundKind) `method`

##### Summary

Determines the appropriate [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') value from two boolean values indicating if a bound is open.
If a `boundKind` is provided, guarantees a side that is unbound is always open.

##### Returns

[IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating an intervals open/closed bounds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| isLeftOpen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the left bound is open. |
| isRightOpen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the right bound is open. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | Optional [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind'). |

<a name='M-Semantica-Intervals-Interval-Empty``1'></a>
### Empty\`\`1() `method`

##### Summary

Makes an empty [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1'). Equivalent to using `default`.

##### Returns

An empty [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval-Equals``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### Equals\`\`1(x,y) `method`

##### Summary

Determines whether two intervals are equal.

##### Returns

`true` if the specified intervals are equal; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The first [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |
| y | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval-Guard``1-``0,``0,Semantica-Intervals-IntervalBoundKind-'></a>
### Guard\`\`1(left,right,boundKind) `method`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating whether sides are bound or unbound. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if [Left](#P-Semantica-Intervals-IntervalBase`1-Left 'Semantica.Intervals.IntervalBase`1.Left') is greater than [Right](#P-Semantica-Intervals-IntervalBase`1-Right 'Semantica.Intervals.IntervalBase`1.Right'). |

<a name='M-Semantica-Intervals-Interval-MakeDegenerate``1-``0-'></a>
### MakeDegenerate\`\`1(degenerateValue) `method`

##### Summary

Constructs a degenerate interval.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| degenerateValue | [\`\`0](#T-``0 '``0') | Value used for both boundaries of the interval. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval-MakeHalfOpen``1-``0,``0-'></a>
### MakeHalfOpen\`\`1(left,right) `method`

##### Summary

Constructs a bound, half open interval ([RightOpen](#F-Semantica-Intervals-IntervalOpenKind-RightOpen 'Semantica.Intervals.IntervalOpenKind.RightOpen')).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if `left` is greater than `right`. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-MakeHalfOpen``1-``0,``0,System-Func{``0,System-Boolean}-'></a>
### MakeHalfOpen\`\`1(left,right,unboundPredicate) `method`

##### Summary

Constructs a half open interval ([RightOpen](#F-Semantica-Intervals-IntervalOpenKind-RightOpen 'Semantica.Intervals.IntervalOpenKind.RightOpen')). Determines
[BoundKind](#P-Semantica-Intervals-Interval`1-BoundKind 'Semantica.Intervals.Interval`1.BoundKind') by evaluating `unboundPredicate` for both bounds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| unboundPredicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Function that is called for each bound to determine if it's unbound. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if `left` is greater than `right`. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-MakeLeftUnbound``1-``0,Semantica-Intervals-IntervalOpenKind-'></a>
### MakeLeftUnbound\`\`1(right,openKind) `method`

##### Summary

Constructs an interval that is left unbound.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') that can indivate if the right bound is closed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-MakeRightUnbound``1-``0,Semantica-Intervals-IntervalOpenKind-'></a>
### MakeRightUnbound\`\`1(left,openKind) `method`

##### Summary

Constructs an interval that is right unbound.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') that can indivate if the right bound is closed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-Make``1-``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind-'></a>
### Make\`\`1(left,right,openKind,boundKind) `method`

##### Summary

Constructs an Interval. Degenerate and Empty flags will be determined using the bounds and kinds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating if any bounds are open. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating whether sides are bound or unbound. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if `left` is greater than `right`. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-Make``1-``0,``0,Semantica-Intervals-IntervalOpenKind,System-Func{``0,System-Boolean}-'></a>
### Make\`\`1(left,right,openKind,unboundPredicate) `method`

##### Summary

Constructs an interval. Degenerate and Empty flags will be determined using the bounds and kinds. Determines
[BoundKind](#P-Semantica-Intervals-Interval`1-BoundKind 'Semantica.Intervals.Interval`1.BoundKind') by evaluating `unboundPredicate` for both bounds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating if any bounds are open. |
| unboundPredicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Function that is called for each bound to determine if it's unbound. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if `left` is greater than `right`. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval-ToStringTryFormat``1-Semantica-Intervals-IReadOnlyInterval{``0},System-String,System-IFormatProvider-'></a>
### ToStringTryFormat\`\`1(interval,format,formatProvider) `method`

##### Summary

Formats the value of the provided interval using the specified format, if bounds implement [IFormattable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormattable 'System.IFormattable').

##### Returns

A string representation of the interval, with formatted boundary values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to format. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
implementation. |
| formatProvider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
locale setting of the operating system. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

##### Remarks

If `T` does not implement [IFormattable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormattable 'System.IFormattable'), default [ToString](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.ToString 'System.Object.ToString') is
used.

<a name='M-Semantica-Intervals-Interval-ToString``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### ToString\`\`1(interval) `method`

##### Summary

Formats the value of the provided interval.

##### Returns

A string representation of the interval.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to format. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval-ToString``1-Semantica-Intervals-IReadOnlyInterval{``0},System-String,System-IFormatProvider-'></a>
### ToString\`\`1(interval,format,formatProvider) `method`

##### Summary

Formats the value of the provided interval using the specified format.

##### Returns

A string representation of the interval, with formatted boundary values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to format. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
implementation. |
| formatProvider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
locale setting of the operating system. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'), [IFormattable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormattable 'System.IFormattable') type. |

<a name='M-Semantica-Intervals-Interval-ToString``1-``0,``0,System-Boolean,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,System-String,System-IFormatProvider-'></a>
### ToString\`\`1(left,right,isEmpty,openKind,boundKind,format,formatProvider) `method`

##### Summary

Formats two value as an interval using the specified format.

##### Returns

A string representation of the interval.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`\`0](#T-``0 '``0') | Left (lower) boundary of the interval. |
| right | [\`\`0](#T-``0 '``0') | Right (upper) boundary of the interval. |
| isEmpty | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if the interval is empty. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating if any bounds are open. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating if sides are bound or unbound. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
implementation. |
| formatProvider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
locale setting of the operating system. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='T-Semantica-Intervals-IntervalBase`1'></a>
## IntervalBase\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

##### Summary

Base implementation of [IInterval\`1](#T-Semantica-Intervals-IInterval`1 'Semantica.Intervals.IInterval`1')

<a name='M-Semantica-Intervals-IntervalBase`1-#ctor-`0,`0,Semantica-Intervals-IntervalBoundKind-'></a>
### #ctor(left,right,boundKind) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`0](#T-`0 '`0') | Left (lower) boundary of the interval. |
| right | [\`0](#T-`0 '`0') | Right (upper) boundary of the interval. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | The [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') used for guarding (not stored!). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | throws if `left` is greater than `right`. |

<a name='M-Semantica-Intervals-IntervalBase`1-#ctor-Semantica-Intervals-IReadOnlyInterval{`0}-'></a>
### #ctor(interval) `constructor`

##### Summary

Does not do left-right comparison because it assumes that was done when `interval` was constructed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`0}](#T-Semantica-Intervals-IReadOnlyInterval{`0} 'Semantica.Intervals.IReadOnlyInterval{`0}') | Tuple with left and right values of type `T`. |

<a name='M-Semantica-Intervals-IntervalBase`1-#ctor-System-ValueTuple{`0,`0}-'></a>
### #ctor(interval) `constructor`

##### Summary

Does not do left-right comparison. Only use if order is already checked, or call [Guard\`\`1](#M-Semantica-Intervals-Interval-Guard``1-``0,``0,Semantica-Intervals-IntervalBoundKind- 'Semantica.Intervals.Interval.Guard``1(``0,``0,Semantica.Intervals.IntervalBoundKind)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [System.ValueTuple{\`0,\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{`0,`0}') | Tuple with left and right values of type `T`. |

<a name='P-Semantica-Intervals-IntervalBase`1-IsLeftOpen'></a>
### IsLeftOpen `property`

##### Summary

`true` if the left bound is open; `false` if it's closed.

<a name='P-Semantica-Intervals-IntervalBase`1-IsLeftUnbound'></a>
### IsLeftUnbound `property`

##### Summary

`true` if the left side is unbound; `false` if it's bound.

<a name='P-Semantica-Intervals-IntervalBase`1-IsRightOpen'></a>
### IsRightOpen `property`

##### Summary

`true` if the right bound is open; `false` if it's closed.

<a name='P-Semantica-Intervals-IntervalBase`1-IsRightUnbound'></a>
### IsRightUnbound `property`

##### Summary

`true` if the right side is unbound; `false` if it's bound.

<a name='P-Semantica-Intervals-IntervalBase`1-TypeName'></a>
### TypeName `property`

<a name='T-Semantica-Intervals-IntervalBoundKind'></a>
## IntervalBoundKind `type`

##### Namespace

Semantica.Intervals

##### Summary

A flags enum that can indicating if an interval is fully bound (default), or left- and/or right-unbound.

<a name='T-Semantica-Intervals-IntervalDictionaryExtensions'></a>
## IntervalDictionaryExtensions `type`

##### Namespace

Semantica.Intervals

##### Summary

Provides extension methods for [IReadOnlyIntervalDictionary\`3](#T-Semantica-Intervals-IReadOnlyIntervalDictionary`3 'Semantica.Intervals.IReadOnlyIntervalDictionary`3').

<a name='M-Semantica-Intervals-IntervalDictionaryExtensions-GetIntervalWithLeft``3-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2},``0-'></a>
### GetIntervalWithLeft\`\`3(dictionary,left) `method`

##### Summary

Retrieves the interval from `dictionary` with [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left') equal to the provided
key.

##### Returns

Interval with [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left') equal to `left`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [Semantica.Intervals.IReadOnlyIntervalDictionary{\`\`0,\`\`1,\`\`2}](#T-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2} 'Semantica.Intervals.IReadOnlyIntervalDictionary{``0,``1,``2}') | Dictionary to search for intervals. |
| left | [\`\`0](#T-``0 '``0') | Key to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of values stored in the dictionary. |
| TKey | Type of the bounds of the intervals. |
| TInterval | Type of the intervals. |

##### Remarks

Note that the interval is returned regardless of the key being within the interval ([IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind')).

<a name='M-Semantica-Intervals-IntervalDictionaryExtensions-TryGetIntervalWithLeft``3-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2},``0,``1@-'></a>
### TryGetIntervalWithLeft\`\`3(dictionary,left,interval) `method`

##### Summary

Searches `dictionary` for the interval with [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left') equal to the provided key.

##### Returns

`true` if such an interval is contained in the dictionary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [Semantica.Intervals.IReadOnlyIntervalDictionary{\`\`0,\`\`1,\`\`2}](#T-Semantica-Intervals-IReadOnlyIntervalDictionary{``0,``1,``2} 'Semantica.Intervals.IReadOnlyIntervalDictionary{``0,``1,``2}') | Dictionary to search for intervals. |
| left | [\`\`0](#T-``0 '``0') | Key to search for. |
| interval | [\`\`1@](#T-``1@ '``1@') | Out parameter that contains the interval with [Left](#P-Semantica-Intervals-IReadOnlyInterval`1-Left 'Semantica.Intervals.IReadOnlyInterval`1.Left') equal to `left` if
found; default otherwise. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of values stored in the dictionary. |
| TKey | Type of the bounds of the intervals. |
| TInterval | Type of the intervals. |

##### Remarks

Note that an interval will match regardless of the key being within the interval ([IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind')).

<a name='T-Semantica-Intervals-IntervalDictionary`2'></a>
## IntervalDictionary\`2 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

<a name='M-Semantica-Intervals-IntervalDictionary`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Intervals-IntervalDictionary`2-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{Semantica-Intervals-IInterval{`0},`1}}-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Intervals-IntervalDictionary`2-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{Semantica-Intervals-IInterval{`0},`1}}-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Intervals-IntervalDictionary`3'></a>
## IntervalDictionary\`3 `type`

##### Namespace

Semantica.Intervals

##### Summary

*Inherit from parent.*

<a name='M-Semantica-Intervals-IntervalDictionary`3-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs an empty instance.

##### Parameters

This constructor has no parameters.

<a name='M-Semantica-Intervals-IntervalDictionary`3-#ctor-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{`1,`2}}-'></a>
### #ctor(pairs) `constructor`

##### Summary

Constucts an instance, adding all pairs of intervals and values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pairs | [System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{\`1,\`2}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{`1,`2}}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [KeyValuePair\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair`2 'System.Collections.Generic.KeyValuePair`2'), where they keys are intervals. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if any of the intervals have a non-empty intersection. |

<a name='M-Semantica-Intervals-IntervalDictionary`3-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{`1,`2}}-'></a>
### #ctor(tuples) `constructor`

##### Summary

Constucts an instance, adding all tuples of intervals and values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tuples | [System.Collections.Generic.IEnumerable{System.ValueTuple{\`1,\`2}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.ValueTuple{`1,`2}}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of tuples of intervals and corresponding values. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throws if any of the intervals have a non-empty intersection. |

<a name='T-Semantica-Intervals-IntervalEnumerationExtensions'></a>
## IntervalEnumerationExtensions `type`

##### Namespace

Semantica.Intervals

##### Summary

Provides extension methods of various types of enumerations pertaining to intervals.

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``1-System-Collections-Generic-IEnumerable{Semantica-Intervals-EmptyUnbindsInterval{``0}}-'></a>
### Extend\`\`1(intervals) `method`

##### Summary

Creates an [EmptyUnbindsInterval\`1](#T-Semantica-Intervals-EmptyUnbindsInterval`1 'Semantica.Intervals.EmptyUnbindsInterval`1') with the left (lower) bound taken from the minimal value in any of the input
intervals, and the right (upper) bound taken from the maximal value in any of the input intervals.

##### Returns

New instance of [EmptyUnbindsInterval\`1](#T-Semantica-Intervals-EmptyUnbindsInterval`1 'Semantica.Intervals.EmptyUnbindsInterval`1') spanning all the values within any of the input intervals, and all values in
between.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| intervals | [System.Collections.Generic.IEnumerable{Semantica.Intervals.EmptyUnbindsInterval{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Semantica.Intervals.EmptyUnbindsInterval{``0}}') | An enumeration of intervals. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``1-System-Collections-Generic-IEnumerable{Semantica-Intervals-Interval{``0}}-'></a>
### Extend\`\`1(intervals) `method`

##### Summary

Creates an [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') with the left (lower) bound taken from the minimal value in any of the input
intervals, and the right (upper) bound taken from the maximal value in any of the input intervals.

##### Returns

New instance of [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') spanning all the values within any of the input intervals, and all values in
between.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| intervals | [System.Collections.Generic.IEnumerable{Semantica.Intervals.Interval{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Semantica.Intervals.Interval{``0}}') | An enumeration of intervals. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-Extend``2-System-Collections-Generic-IEnumerable{``1},System-Func{``0,``0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,``1}-'></a>
### Extend\`\`2(intervals,factory) `method`

##### Summary

Creates an [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') with the left (lower) bound taken from the minimal value in any of the input
intervals, and the right (upper) bound taken from the maximal value in any of the input intervals.

##### Returns

New instance of [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') spanning all the values within any of the input intervals, and all values in
between.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| intervals | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | An enumeration of intervals. |
| factory | [System.Func{\`\`0,\`\`0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0,Semantica.Intervals.IntervalOpenKind,Semantica.Intervals.IntervalBoundKind,``1}') | A function that can create a new interval of the appropriate type. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |
| TInterval | Type of intervals. |

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-ToIntervalDictionary``2-System-Collections-Generic-IEnumerable{System-ValueTuple{Semantica-Intervals-IInterval{``0},``1}}-'></a>
### ToIntervalDictionary\`\`2(enumerable) `method`

##### Summary

Creates a new [IntervalDictionary\`2](#T-Semantica-Intervals-IntervalDictionary`2 'Semantica.Intervals.IntervalDictionary`2') containing the intervals and values from the provided
[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of tuples.

##### Returns

An [IntervalDictionary\`2](#T-Semantica-Intervals-IntervalDictionary`2 'Semantica.Intervals.IntervalDictionary`2')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{System.ValueTuple{Semantica.Intervals.IInterval{\`\`0},\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.ValueTuple{Semantica.Intervals.IInterval{``0},``1}}') | An enumerable of tuples of intervals and values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of the bounds of the intervals. |
| TValue | Type of the values associated with each interval. |

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-ToIntervalDictionary``3-System-Collections-Generic-IEnumerable{System-ValueTuple{``1,``2}}-'></a>
### ToIntervalDictionary\`\`3(enumerable) `method`

##### Summary

Creates a new [IntervalDictionary\`3](#T-Semantica-Intervals-IntervalDictionary`3 'Semantica.Intervals.IntervalDictionary`3') containing the intervals and values from the provided
[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of tuples.

##### Returns

An [IntervalDictionary\`3](#T-Semantica-Intervals-IntervalDictionary`3 'Semantica.Intervals.IntervalDictionary`3')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{System.ValueTuple{\`\`1,\`\`2}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.ValueTuple{``1,``2}}') | An enumerable of tuples of intervals and values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | Type of the bounds of the intervals. |
| TValue | Type of the values associated with each interval. |
| TInterval | Type of the intervals. |

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalPairs``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},``1-'></a>
### ToLowerboundIntervalPairs\`\`2(values,leftFunc,finalRight) `method`

##### Summary

Enumerates `values`, and yields a [KeyValuePair\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyValuePair`2 'System.Collections.Generic.KeyValuePair`2') where each key is an
interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
element in the enumeration using `leftFunc`. The values of the pair are the elements of the
input. The right bound of the last pair is set to `finalRight`;

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of pairs with intervals and values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Enumeration of values. |
| leftFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function used to obtain a bound value from each value. |
| finalRight | [\`\`1](#T-``1 '``1') | Right bound of the interval associated with the last value in the enumeration. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of the values. |
| TKey | Type of the bounds of the intervals. |

##### Remarks

Note that two elements of the input [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') are taken before the first element is
yielded. After that one element is taken for each element yielded.

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalTuples``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},``1-'></a>
### ToLowerboundIntervalTuples\`\`2(values,leftFunc,finalRight) `method`

##### Summary

Enumerates `values`, and yields a tuple of an interval and a value where each key is an
interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
element in the enumeration using `leftFunc`. The values of the tuples are the elements of the
input. The right bound of the last pair is set to `finalRight`;

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of tuples with intervals and values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Enumeration of values. |
| leftFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function used to obtain a bound value from each value. |
| finalRight | [\`\`1](#T-``1 '``1') | Right bound of the interval associated with the last value in the enumeration. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of the values. |
| TKey | Type of the bounds of the intervals. |

##### Remarks

Note that two elements of the input [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') are taken before the first element is
yielded. After that one element is taken for each element yielded.

<a name='M-Semantica-Intervals-IntervalEnumerationExtensions-ToLowerboundIntervalTuples``3-System-Collections-Generic-IEnumerable{``0},System-Func{``1,``1,``2},System-Func{``0,``1},``1-'></a>
### ToLowerboundIntervalTuples\`\`3(values,intervalFactory,leftFunc,finalRight) `method`

##### Summary

Enumerates `values`, and yields a tuple of an interval and a value where each key is an
interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
element in the enumeration using `leftFunc`. The values of the tuples are the elements of the
input. The right bound of the last pair is set to `finalRight`;

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of tuples with intervals and values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Enumeration of values. |
| intervalFactory | [System.Func{\`\`1,\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,``1,``2}') | Function to create the intervals. |
| leftFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function used to obtain a bound value from each value. |
| finalRight | [\`\`1](#T-``1 '``1') | Right bound of the interval associated with the last value in the enumeration. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | Type of the values. |
| TKey | Type of the bounds of the intervals. |
| TInterval | Type of the created intervals. |

##### Remarks

Note that two elements of the input [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') are taken before the first element is
yielded. After that one element is taken for each element yielded.

<a name='T-Semantica-Intervals-IntervalExtensions'></a>
## IntervalExtensions `type`

##### Namespace

Semantica.Intervals

##### Summary

Provides extension methods for [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1').

<a name='M-Semantica-Intervals-IntervalExtensions-Convert``2-Semantica-Intervals-IReadOnlyInterval{``0},System-Func{``0,``1}-'></a>
### Convert\`\`2(interval,convertFunc) `method`

##### Summary

Creates an [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') with the bounds of `interval` converted using provided converter.

##### Returns

New instance of [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') derived from `interval`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to convert. |
| convertFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function to convert the bounds with. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | Type of bounds of the input interval. |
| TOut | Type of bounds of the returned interval. |

<a name='M-Semantica-Intervals-IntervalExtensions-Extend``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### Extend\`\`1(interval,otherInterval) `method`

##### Summary

Creates an [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') with the left (lower) bound taken from the minimal value in either of the inputs
intervals, and the right (upper) bound taken from the maximal value in either of the inputs.

##### Returns

New instance of [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') spanning all the values within either input interval, and all values in
between.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to use. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsAnyLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsAnyLeftOf\`\`1(interval,otherInterval) `method`

##### Summary

Determines if any values in `interval` are left of `otherInterval`.

##### Returns

`true` if `interval` has any values left of `otherInterval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsAnyLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},``0-'></a>
### IsAnyLeftOf\`\`1(interval,value) `method`

##### Summary

Determines if any values in `interval` are left of `value`.

##### Returns

`true` if `interval` has any values left of `value`. Always
`false` if the interval is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to. |
| value | [\`\`0](#T-``0 '``0') | A single value of type `T`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsAnyRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsAnyRightOf\`\`1(interval,otherInterval) `method`

##### Summary

Determines if any values in `interval` are right of `otherInterval`.

##### Returns

`true` if `interval` has any values right of `otherInterval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsAnyRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},``0-'></a>
### IsAnyRightOf\`\`1(interval,value) `method`

##### Summary

Determines if any values in `interval` are right of `value`.

##### Returns

`true` if `interval` has any values right of `value`. Always
`false` if the interval is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to. |
| value | [\`\`0](#T-``0 '``0') | A single value of type `T`. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsLeftOf``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftOf\`\`1(value,interval) `method`

##### Summary

Determines if `value` is left of `interval`.

##### Returns

`true` if `value` is left of `interval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | A single value of type `T` to compare to. |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to the value. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsLeftOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftOf\`\`1(interval,otherInterval) `method`

##### Summary

Determines if all values in `interval` are left of `otherInterval`.

##### Returns

`true` if `interval` is completely left of `otherInterval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsRightOf``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightOf\`\`1(value,interval) `method`

##### Summary

Determines if `value` is right of `interval`.

##### Returns

`true` if `value` is right of `interval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | A single value of type `T` to compare to. |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to the value. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsRightOf``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightOf\`\`1(interval,otherInterval) `method`

##### Summary

Determines if all values in `interval` are right of `otherInterval`.

##### Returns

`true` if `interval` is completely right of `otherInterval`. Always
`false` if either of the intervals are empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsWithin``1-``0,Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsWithin\`\`1(value,interval) `method`

##### Summary

Determines if `value` is within `interval`.

##### Returns

`true` if the `value` is within `interval`. Always
`false` if the interval is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | A single value of type `T` to compare to. |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | The [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare to the value. |

<a name='M-Semantica-Intervals-IntervalExtensions-IsWithin``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsWithin\`\`1(interval,otherInterval) `method`

##### Summary

Determines if all values in `interval` are in `otherInterval`.

##### Returns

`true` if the complete `interval` is within `otherInterval`.
Always `false` if one of the intervals is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-Overlaps``1-Semantica-Intervals-IReadOnlyInterval{``0},Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### Overlaps\`\`1(interval,otherInterval) `method`

##### Summary

Determines if any values in `interval` are in `otherInterval`.

##### Returns

`true` if the intervals overlap. Always `false` if one of the intervals is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | First [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare. |
| otherInterval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | Second [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to compare fo first. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the intervals. |

<a name='M-Semantica-Intervals-IntervalExtensions-TryDegenerateValue``1-Semantica-Intervals-IReadOnlyInterval{``0},``0@-'></a>
### TryDegenerateValue\`\`1(interval,degenerateValue) `method`

##### Summary

Checks interval for degeneracy. Returns the interval's value as out parameter.

##### Returns

`true` if the intervals is degenerate; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`\`0}](#T-Semantica-Intervals-IReadOnlyInterval{``0} 'Semantica.Intervals.IReadOnlyInterval{``0}') | [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') to check. |
| degenerateValue | [\`\`0@](#T-``0@ '``0@') | Out parameter containing the value of the interval. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of bounds of the interval. |

<a name='T-Semantica-Intervals-IntervalKindExtensions'></a>
## IntervalKindExtensions `type`

##### Namespace

Semantica.Intervals

##### Summary

Provides extension methods for [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind'), [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind'), as well as extension
methods for [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1') using those properties.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsHalfOpen-Semantica-Intervals-IntervalOpenKind-'></a>
### IsHalfOpen() `method`

##### Summary

`true` if left closed, and right open.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsHalfOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsHalfOpen\`\`1() `method`

##### Summary

`true` if the left boundary is closed, and the right boundary is open.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftBounded-Semantica-Intervals-IntervalBoundKind-'></a>
### IsLeftBounded() `method`

##### Summary

`true` if left bounded (not infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftBounded``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftBounded\`\`1() `method`

##### Summary

`true` if the left (lower) boundary is considered to be bound (not infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftClosed-Semantica-Intervals-IntervalOpenKind-'></a>
### IsLeftClosed() `method`

##### Summary

`true` if left closed (bound included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftClosed``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftClosed\`\`1() `method`

##### Summary

`true` if the left (lower) boundary is considered to be closed (included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftOpen-Semantica-Intervals-IntervalOpenKind-'></a>
### IsLeftOpen() `method`

##### Summary

`true` if left open (bound not included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftOpen\`\`1() `method`

##### Summary

`true` if the left (lower) boundary is considered to be open (not included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftUnbound-Semantica-Intervals-IntervalBoundKind-'></a>
### IsLeftUnbound() `method`

##### Summary

`true` if left unbounded (infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsLeftUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsLeftUnbound\`\`1() `method`

##### Summary

`true` if the left (lower) boundary is considered to be unbound (infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightBounded-Semantica-Intervals-IntervalBoundKind-'></a>
### IsRightBounded() `method`

##### Summary

`true` if right bounded (not infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightBounded``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightBounded\`\`1() `method`

##### Summary

`true` if the right (upper) boundary is considered to be bound (not infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightClosed-Semantica-Intervals-IntervalOpenKind-'></a>
### IsRightClosed() `method`

##### Summary

`true` if right closed (bound included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightClosed``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightClosed\`\`1() `method`

##### Summary

`true` if the right (upper) boundary is considered to be closed (included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightOpen-Semantica-Intervals-IntervalOpenKind-'></a>
### IsRightOpen() `method`

##### Summary

`true` if right open (bound not included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightOpen``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightOpen\`\`1() `method`

##### Summary

`true` if the right (upper) boundary is considered to be open (not included within the interval).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightUnbound-Semantica-Intervals-IntervalBoundKind-'></a>
### IsRightUnbound() `method`

##### Summary

`true` if right unbounded (infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsRightUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsRightUnbound\`\`1() `method`

##### Summary

`true` if the right (upper) boundary is considered to be unbound (infinite).

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsUnbound-Semantica-Intervals-IntervalBoundKind-'></a>
### IsUnbound() `method`

##### Summary

`true` if unbounded (infinite) on both sides.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Intervals-IntervalKindExtensions-IsUnbound``1-Semantica-Intervals-IReadOnlyInterval{``0}-'></a>
### IsUnbound\`\`1() `method`

##### Summary

`true` if the interval is unbounded (infinite) on both sides.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Intervals-IntervalOpenKind'></a>
## IntervalOpenKind `type`

##### Namespace

Semantica.Intervals

##### Summary

A flags enum that can indicating whether either the left or right bounds of an interval are closed or open. A closed bound
means that the bound's value itself is included in the interval, open means that the bound is not included in the interval.
`default` indicates both bounds are closed.

<a name='T-Semantica-Intervals-Interval`1'></a>
## Interval\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

Represents an interval of values.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') type. |

<a name='M-Semantica-Intervals-Interval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind-'></a>
### #ctor(left,right,openKind,boundKind) `constructor`

##### Summary

Constructs an Interval. Degenerate and Empty flags will be determined using the bounds and kinds.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [\`0](#T-`0 '`0') | Left (lower) boundary of the interval. |
| right | [\`0](#T-`0 '`0') | Right (upper) boundary of the interval. |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') indicating if any bounds are open. Default is half-open. |
| boundKind | [Semantica.Intervals.IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') | [IntervalBoundKind](#T-Semantica-Intervals-IntervalBoundKind 'Semantica.Intervals.IntervalBoundKind') indicating if sides are bound or unbound. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | throws if `left` is greater than `right`. |

##### Remarks

If a side is unbound, that side's open flag will be ignored and it will always be open.

<a name='M-Semantica-Intervals-Interval`1-#ctor-Semantica-Intervals-IReadOnlyInterval{`0}-'></a>
### #ctor(interval) `constructor`

##### Summary

Constructs an [Interval\`1](#T-Semantica-Intervals-Interval`1 'Semantica.Intervals.Interval`1') that is a functional copy of another interval.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interval | [Semantica.Intervals.IReadOnlyInterval{\`0}](#T-Semantica-Intervals-IReadOnlyInterval{`0} 'Semantica.Intervals.IReadOnlyInterval{`0}') | Any interval implementing [IReadOnlyInterval\`1](#T-Semantica-Intervals-IReadOnlyInterval`1 'Semantica.Intervals.IReadOnlyInterval`1'). |

<a name='M-Semantica-Intervals-Interval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind,Semantica-Intervals-IntervalBoundKind,System-Boolean,System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

constructor used in the static [Interval](#T-Semantica-Intervals-Interval 'Semantica.Intervals.Interval') methods;

##### Parameters

This constructor has no parameters.

<a name='F-Semantica-Intervals-Interval`1-_flags'></a>
### _flags `constants`

<a name='T-Semantica-Intervals-TargetInterval`1'></a>
## TargetInterval\`1 `type`

##### Namespace

Semantica.Intervals

##### Summary

An implementation of [IInterval\`1](#T-Semantica-Intervals-IInterval`1 'Semantica.Intervals.IInterval`1') that is defined by a center point ([TargetValue](#P-Semantica-Intervals-TargetInterval`1-TargetValue 'Semantica.Intervals.TargetInterval`1.TargetValue')) and a
distance of the bounds to that center point ([Margin](#P-Semantica-Intervals-TargetInterval`1-Margin 'Semantica.Intervals.TargetInterval`1.Margin')). This means these intervals are always bounded on both
sides.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Any type implementing [IArithmatic\`1](#T-Semantica-Patterns-IArithmatic`1 'Semantica.Patterns.IArithmatic`1') and [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1'). |

##### Remarks

Is considered empty when [Margin](#P-Semantica-Intervals-TargetInterval`1-Margin 'Semantica.Intervals.TargetInterval`1.Margin') is `default`, which is slightly different from other typesof
intervals. Consequently, these intervals are never considered degenerate.

<a name='M-Semantica-Intervals-TargetInterval`1-#ctor-`0,`0,Semantica-Intervals-IntervalOpenKind-'></a>
### #ctor(targetValue,margin,openKind) `constructor`

##### Summary

Constructs the interval centered around `targetValue`, with either bounds `margin`
away from either side of that value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetValue | [\`0](#T-`0 '`0') | The center of the interval. |
| margin | [\`0](#T-`0 '`0') | The margin of the interval (distance of either bound to the interval). |
| openKind | [Semantica.Intervals.IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') | [IntervalOpenKind](#T-Semantica-Intervals-IntervalOpenKind 'Semantica.Intervals.IntervalOpenKind') value indicating whether the bounds are open or closed. |

<a name='P-Semantica-Intervals-TargetInterval`1-Margin'></a>
### Margin `property`

##### Summary

The margin (radius) of the interval. This value is subtracted from [TargetValue](#P-Semantica-Intervals-TargetInterval`1-TargetValue 'Semantica.Intervals.TargetInterval`1.TargetValue') to obtain
[Left](#P-Semantica-Intervals-TargetInterval`1-Left 'Semantica.Intervals.TargetInterval`1.Left'); added to get [Right](#P-Semantica-Intervals-TargetInterval`1-Right 'Semantica.Intervals.TargetInterval`1.Right').

<a name='P-Semantica-Intervals-TargetInterval`1-TargetValue'></a>
### TargetValue `property`

##### Summary

The value representing the center of the interval, from which the bounds are calculated.
