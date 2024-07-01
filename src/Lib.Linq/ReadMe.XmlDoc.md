<a name='assembly'></a>
# Lib.Linq

## Contents

- [EnumerableLinq](#T-Semantica-Linq-EnumerableLinq 'Semantica.Linq.EnumerableLinq')
  - [AnyAndAll\`\`1(source,predicate)](#M-Semantica-Linq-EnumerableLinq-AnyAndAll``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.AnyAndAll``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
  - [AnyToArray\`\`1(source,array)](#M-Semantica-Linq-EnumerableLinq-AnyToArray``1-System-Collections-Generic-IEnumerable{``0},``0[]@- 'Semantica.Linq.EnumerableLinq.AnyToArray``1(System.Collections.Generic.IEnumerable{``0},``0[]@)')
  - [AnyToList\`\`1(source,list)](#M-Semantica-Linq-EnumerableLinq-AnyToList``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-List{``0}@- 'Semantica.Linq.EnumerableLinq.AnyToList``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.List{``0}@)')
  - [AnyToReadOnlyList\`\`1(source,list)](#M-Semantica-Linq-EnumerableLinq-AnyToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyList{``0}@- 'Semantica.Linq.EnumerableLinq.AnyToReadOnlyList``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IReadOnlyList{``0}@)')
  - [Append\`\`1(source,append)](#M-Semantica-Linq-EnumerableLinq-Append``1-System-Collections-Generic-IEnumerable{``0},``0[]- 'Semantica.Linq.EnumerableLinq.Append``1(System.Collections.Generic.IEnumerable{``0},``0[])')
  - [AsReadOnlyCollection\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-AsReadOnlyCollection``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.AsReadOnlyCollection``1(System.Collections.Generic.IEnumerable{``0})')
  - [AsReadOnlyList\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-AsReadOnlyList``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.AsReadOnlyList``1(System.Collections.Generic.IEnumerable{``0})')
  - [ConcatWhenNotNull\`\`1(enumerable,second)](#M-Semantica-Linq-EnumerableLinq-ConcatWhenNotNull``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ConcatWhenNotNull``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})')
  - [ConditionalAppend\`\`1(source,condition,append)](#M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,``0[]- 'Semantica.Linq.EnumerableLinq.ConditionalAppend``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,``0[])')
  - [ConditionalAppend\`\`1(source,element)](#M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},``0- 'Semantica.Linq.EnumerableLinq.ConditionalAppend``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [ConditionalAppend\`\`1(source,element)](#M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalAppend``1(System.Collections.Generic.IEnumerable{``0},System.Nullable{``0})')
  - [ConditionalConcat\`\`1(source,condition,second)](#M-Semantica-Linq-EnumerableLinq-ConditionalConcat``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalConcat``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0})')
  - [ConditionalIntersectBy\`\`2(source,condition,second,keySelector)](#M-Semantica-Linq-EnumerableLinq-ConditionalIntersectBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``1},System-Func{``0,``1}- 'Semantica.Linq.EnumerableLinq.ConditionalIntersectBy``2(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``1},System.Func{``0,``1})')
  - [ConditionalIntersectBy\`\`2(source,condition,second,keySelector,equalityComparer)](#M-Semantica-Linq-EnumerableLinq-ConditionalIntersectBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``1},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}- 'Semantica.Linq.EnumerableLinq.ConditionalIntersectBy``2(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``1},System.Func{``0,``1},System.Collections.Generic.IEqualityComparer{``1})')
  - [ConditionalIntersect\`\`1(source,condition,second)](#M-Semantica-Linq-EnumerableLinq-ConditionalIntersect``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalIntersect``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0})')
  - [ConditionalIntersect\`\`1(source,condition,second,equalityComparer)](#M-Semantica-Linq-EnumerableLinq-ConditionalIntersect``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEqualityComparer{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalIntersect``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0})')
  - [ConditionalPrepend\`\`1(source,condition,prepend)](#M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,``0[]- 'Semantica.Linq.EnumerableLinq.ConditionalPrepend``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,``0[])')
  - [ConditionalPrepend\`\`1(source,element)](#M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},``0- 'Semantica.Linq.EnumerableLinq.ConditionalPrepend``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [ConditionalPrepend\`\`1(source,element)](#M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalPrepend``1(System.Collections.Generic.IEnumerable{``0},System.Nullable{``0})')
  - [ConditionalSkip\`\`1(source,condition,count)](#M-Semantica-Linq-EnumerableLinq-ConditionalSkip``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Int32- 'Semantica.Linq.EnumerableLinq.ConditionalSkip``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Int32)')
  - [ConditionalSkip\`\`1(source,count)](#M-Semantica-Linq-EnumerableLinq-ConditionalSkip``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{System-Int32}- 'Semantica.Linq.EnumerableLinq.ConditionalSkip``1(System.Collections.Generic.IEnumerable{``0},System.Nullable{System.Int32})')
  - [ConditionalUnionBy\`\`2(source,condition,second,keySelector)](#M-Semantica-Linq-EnumerableLinq-ConditionalUnionBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}- 'Semantica.Linq.EnumerableLinq.ConditionalUnionBy``2(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})')
  - [ConditionalUnionBy\`\`2(source,condition,second,keySelector,comparer)](#M-Semantica-Linq-EnumerableLinq-ConditionalUnionBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}- 'Semantica.Linq.EnumerableLinq.ConditionalUnionBy``2(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Collections.Generic.IEqualityComparer{``1})')
  - [ConditionalUnion\`\`1(source,condition,second)](#M-Semantica-Linq-EnumerableLinq-ConditionalUnion``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalUnion``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0})')
  - [ConditionalUnion\`\`1(source,condition,second,comparer)](#M-Semantica-Linq-EnumerableLinq-ConditionalUnion``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEqualityComparer{``0}- 'Semantica.Linq.EnumerableLinq.ConditionalUnion``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEqualityComparer{``0})')
  - [ConditionalWhere\`\`1(source,condition,predicate)](#M-Semantica-Linq-EnumerableLinq-ConditionalWhere``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.ConditionalWhere``1(System.Collections.Generic.IEnumerable{``0},System.Boolean,System.Func{``0,System.Boolean})')
  - [ConditionalWhere\`\`1(source,predicate)](#M-Semantica-Linq-EnumerableLinq-ConditionalWhere``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.ConditionalWhere``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
  - [Enumerate\`\`1()](#M-Semantica-Linq-EnumerableLinq-Enumerate``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.Enumerate``1(System.Collections.Generic.IEnumerable{``0})')
  - [FirstOrDefaultOfFirst\`\`2(source,selector,predicate)](#M-Semantica-Linq-EnumerableLinq-FirstOrDefaultOfFirst``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Collections-Generic-IEnumerable{``1}},System-Func{``1,System-Boolean}- 'Semantica.Linq.EnumerableLinq.FirstOrDefaultOfFirst``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Collections.Generic.IEnumerable{``1}},System.Func{``1,System.Boolean})')
  - [FollowFrom(source,if)](#M-Semantica-Linq-EnumerableLinq-FollowFrom-System-Collections-Generic-IEnumerable{System-Boolean},System-Boolean- 'Semantica.Linq.EnumerableLinq.FollowFrom(System.Collections.Generic.IEnumerable{System.Boolean},System.Boolean)')
  - [FollowFrom\`\`1(source,predicate,if)](#M-Semantica-Linq-EnumerableLinq-FollowFrom``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean},System-Boolean- 'Semantica.Linq.EnumerableLinq.FollowFrom``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean},System.Boolean)')
  - [ForEachAndPass\`\`2(source,action,param)](#M-Semantica-Linq-EnumerableLinq-ForEachAndPass``2-System-Collections-Generic-IEnumerable{``0},System-Action{``0,``1},``1- 'Semantica.Linq.EnumerableLinq.ForEachAndPass``2(System.Collections.Generic.IEnumerable{``0},System.Action{``0,``1},``1)')
  - [ForEachAsync\`\`1(source,asyncAction)](#M-Semantica-Linq-EnumerableLinq-ForEachAsync``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Threading-Tasks-Task}- 'Semantica.Linq.EnumerableLinq.ForEachAsync``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Threading.Tasks.Task})')
  - [ForEachWithNext\`\`1(source,action,skipLast)](#M-Semantica-Linq-EnumerableLinq-ForEachWithNext``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0,``0},System-Boolean- 'Semantica.Linq.EnumerableLinq.ForEachWithNext``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0,``0},System.Boolean)')
  - [ForEach\`\`1(source,action)](#M-Semantica-Linq-EnumerableLinq-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}- 'Semantica.Linq.EnumerableLinq.ForEach``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0})')
  - [HasCount\`\`1(source,count)](#M-Semantica-Linq-EnumerableLinq-HasCount``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'Semantica.Linq.EnumerableLinq.HasCount``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [HasCount\`\`1(source,count,predicate)](#M-Semantica-Linq-EnumerableLinq-HasCount``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.HasCount``1(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Func{``0,System.Boolean})')
  - [HasNoneOrOne\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-HasNoneOrOne``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.HasNoneOrOne``1(System.Collections.Generic.IEnumerable{``0})')
  - [HasNoneOrOne\`\`1(source,predicate)](#M-Semantica-Linq-EnumerableLinq-HasNoneOrOne``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.HasNoneOrOne``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
  - [OneOrDefault\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-OneOrDefault``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.OneOrDefault``1(System.Collections.Generic.IEnumerable{``0})')
  - [OneOrDefault\`\`1(source,predicate)](#M-Semantica-Linq-EnumerableLinq-OneOrDefault``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.OneOrDefault``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
  - [PrecedeBy\`\`1(source,startItem)](#M-Semantica-Linq-EnumerableLinq-PrecedeBy``1-System-Collections-Generic-IEnumerable{``0},``0- 'Semantica.Linq.EnumerableLinq.PrecedeBy``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [Prepend\`\`1(source,prepend)](#M-Semantica-Linq-EnumerableLinq-Prepend``1-System-Collections-Generic-IEnumerable{``0},``0[]- 'Semantica.Linq.EnumerableLinq.Prepend``1(System.Collections.Generic.IEnumerable{``0},``0[])')
  - [SelectAndPass\`\`3(source,transformFunc,param)](#M-Semantica-Linq-EnumerableLinq-SelectAndPass``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``2,``1},``2- 'Semantica.Linq.EnumerableLinq.SelectAndPass``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``2,``1},``2)')
  - [SelectAndPass\`\`4(source,selectFunc,param1,param2)](#M-Semantica-Linq-EnumerableLinq-SelectAndPass``4-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``2,``3,``1},``2,``3- 'Semantica.Linq.EnumerableLinq.SelectAndPass``4(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``2,``3,``1},``2,``3)')
  - [SelectArrayAndPass\`\`3(source,length,selectFunc,param)](#M-Semantica-Linq-EnumerableLinq-SelectArrayAndPass``3-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,``1,``2},``1- 'Semantica.Linq.EnumerableLinq.SelectArrayAndPass``3(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Func{``0,``1,``2},``1)')
  - [SelectArray\`\`2(source,length,selectFunc)](#M-Semantica-Linq-EnumerableLinq-SelectArray``2-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,``1}- 'Semantica.Linq.EnumerableLinq.SelectArray``2(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Func{``0,``1})')
  - [SelectArray\`\`2(source,length,selectFunc)](#M-Semantica-Linq-EnumerableLinq-SelectArray``2-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,System-Int32,``1}- 'Semantica.Linq.EnumerableLinq.SelectArray``2(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Func{``0,System.Int32,``1})')
  - [SelectIfDictionaryContains\`\`2(enumerable,dict)](#M-Semantica-Linq-EnumerableLinq-SelectIfDictionaryContains``2-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyDictionary{``0,``1}- 'Semantica.Linq.EnumerableLinq.SelectIfDictionaryContains``2(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IReadOnlyDictionary{``0,``1})')
  - [SelectIfDictionaryContains\`\`3(source,keyFunc,dict)](#M-Semantica-Linq-EnumerableLinq-SelectIfDictionaryContains``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Collections-Generic-IReadOnlyDictionary{``1,``2}- 'Semantica.Linq.EnumerableLinq.SelectIfDictionaryContains``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Collections.Generic.IReadOnlyDictionary{``1,``2})')
  - [SelectManyTuples\`\`2(enumerable)](#M-Semantica-Linq-EnumerableLinq-SelectManyTuples``2-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.SelectManyTuples``2(System.Collections.Generic.IEnumerable{``0})')
  - [SelectMany\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-SelectMany``1-System-Collections-Generic-IEnumerable{System-Collections-Generic-IEnumerable{``0}}- 'Semantica.Linq.EnumerableLinq.SelectMany``1(System.Collections.Generic.IEnumerable{System.Collections.Generic.IEnumerable{``0}})')
  - [SelectWithContext\`\`2(source,combineWithContext)](#M-Semantica-Linq-EnumerableLinq-SelectWithContext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``0,``1}- 'Semantica.Linq.EnumerableLinq.SelectWithContext``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,``0,``1})')
  - [SelectWithNext\`\`2(source,combineWithNextFunc)](#M-Semantica-Linq-EnumerableLinq-SelectWithNext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1}- 'Semantica.Linq.EnumerableLinq.SelectWithNext``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,``1})')
  - [SelectWithNext\`\`2(source,combineWithNextFunc,skipLast)](#M-Semantica-Linq-EnumerableLinq-SelectWithNext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1},System-Boolean- 'Semantica.Linq.EnumerableLinq.SelectWithNext``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,``1},System.Boolean)')
  - [SelectWithPrevious\`\`2(source,combineWithPreviousFunc)](#M-Semantica-Linq-EnumerableLinq-SelectWithPrevious``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1}- 'Semantica.Linq.EnumerableLinq.SelectWithPrevious``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,``1})')
  - [Select\`\`2(source,selectFunc)](#M-Semantica-Linq-EnumerableLinq-Select``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean,System-Boolean,``1}- 'Semantica.Linq.EnumerableLinq.Select``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean,System.Boolean,``1})')
  - [Sum(source)](#M-Semantica-Linq-EnumerableLinq-Sum-System-Collections-Generic-IEnumerable{System-Int16}- 'Semantica.Linq.EnumerableLinq.Sum(System.Collections.Generic.IEnumerable{System.Int16})')
  - [Sum\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-Sum``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.Sum``1(System.Collections.Generic.IEnumerable{``0})')
  - [Sum\`\`2(source,selector)](#M-Semantica-Linq-EnumerableLinq-Sum``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}- 'Semantica.Linq.EnumerableLinq.Sum``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})')
  - [ToArrayOrNull\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-ToArrayOrNull``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ToArrayOrNull``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToArray\`\`1(source,length)](#M-Semantica-Linq-EnumerableLinq-ToArray``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'Semantica.Linq.EnumerableLinq.ToArray``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [ToArray\`\`1(source,length,defaultValue)](#M-Semantica-Linq-EnumerableLinq-ToArray``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0- 'Semantica.Linq.EnumerableLinq.ToArray``1(System.Collections.Generic.IEnumerable{``0},System.Int32,``0)')
  - [ToListOrNull\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-ToListOrNull``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ToListOrNull``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToReadOnlyDictionary\`\`3(enumerable,keySelector,elementSelector)](#M-Semantica-Linq-EnumerableLinq-ToReadOnlyDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}- 'Semantica.Linq.EnumerableLinq.ToReadOnlyDictionary``3(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1},System.Func{``0,``2})')
  - [ToReadOnlyListOrNull\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-ToReadOnlyListOrNull``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ToReadOnlyListOrNull``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToReadOnlyList\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.ToReadOnlyList``1(System.Collections.Generic.IEnumerable{``0})')
  - [ToReadOnlyList\`\`1(source,length)](#M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'Semantica.Linq.EnumerableLinq.ToReadOnlyList``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [ToReadOnlyList\`\`1(source,length,defaultValue)](#M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0- 'Semantica.Linq.EnumerableLinq.ToReadOnlyList``1(System.Collections.Generic.IEnumerable{``0},System.Int32,``0)')
  - [TryFirst\`\`1(source,first)](#M-Semantica-Linq-EnumerableLinq-TryFirst``1-System-Collections-Generic-IEnumerable{``0},``0@- 'Semantica.Linq.EnumerableLinq.TryFirst``1(System.Collections.Generic.IEnumerable{``0},``0@)')
  - [TryPrevious\`\`1(source,predicate,element)](#M-Semantica-Linq-EnumerableLinq-TryPrevious``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean},``0@- 'Semantica.Linq.EnumerableLinq.TryPrevious``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean},``0@)')
  - [TrySingle\`\`1(source,matchedElement)](#M-Semantica-Linq-EnumerableLinq-TrySingle``1-System-Collections-Generic-IEnumerable{``0},``0@- 'Semantica.Linq.EnumerableLinq.TrySingle``1(System.Collections.Generic.IEnumerable{``0},``0@)')
  - [WhereNotDefault\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-WhereNotDefault``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.WhereNotDefault``1(System.Collections.Generic.IEnumerable{``0})')
  - [WhereNotIn\`\`1(source,compareCollection)](#M-Semantica-Linq-EnumerableLinq-WhereNotIn``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyCollection{``0}- 'Semantica.Linq.EnumerableLinq.WhereNotIn``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IReadOnlyCollection{``0})')
  - [WhereNotNul(source)](#M-Semantica-Linq-EnumerableLinq-WhereNotNul-System-Collections-Generic-IEnumerable{System-Char}- 'Semantica.Linq.EnumerableLinq.WhereNotNul(System.Collections.Generic.IEnumerable{System.Char})')
  - [WhereNotNullOrEmpty(source)](#M-Semantica-Linq-EnumerableLinq-WhereNotNullOrEmpty-System-Collections-Generic-IEnumerable{System-String}- 'Semantica.Linq.EnumerableLinq.WhereNotNullOrEmpty(System.Collections.Generic.IEnumerable{System.String})')
  - [WhereNotNull\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-WhereNotNull``1-System-Collections-Generic-IEnumerable{``0}- 'Semantica.Linq.EnumerableLinq.WhereNotNull``1(System.Collections.Generic.IEnumerable{``0})')
  - [WhereNotNull\`\`1(source)](#M-Semantica-Linq-EnumerableLinq-WhereNotNull``1-System-Collections-Generic-IEnumerable{System-Nullable{``0}}- 'Semantica.Linq.EnumerableLinq.WhereNotNull``1(System.Collections.Generic.IEnumerable{System.Nullable{``0}})')
  - [WhereNot\`\`1(source,predicate)](#M-Semantica-Linq-EnumerableLinq-WhereNot``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.EnumerableLinq.WhereNot``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})')
- [EnumeratorExtensions](#T-Semantica-Linq-EnumeratorExtensions 'Semantica.Linq.EnumeratorExtensions')
  - [TryMoveNext\`\`1(enumerator,element)](#M-Semantica-Linq-EnumeratorExtensions-TryMoveNext``1-System-Collections-Generic-IEnumerator{``0},``0@- 'Semantica.Linq.EnumeratorExtensions.TryMoveNext``1(System.Collections.Generic.IEnumerator{``0},``0@)')
- [QueryableLinq](#T-Semantica-Linq-QueryableLinq 'Semantica.Linq.QueryableLinq')
  - [ConditionalSkip\`\`1(queryable,condition,count)](#M-Semantica-Linq-QueryableLinq-ConditionalSkip``1-System-Linq-IQueryable{``0},System-Boolean,System-Int32- 'Semantica.Linq.QueryableLinq.ConditionalSkip``1(System.Linq.IQueryable{``0},System.Boolean,System.Int32)')
  - [ConditionalSkip\`\`1(queryable,count)](#M-Semantica-Linq-QueryableLinq-ConditionalSkip``1-System-Linq-IQueryable{``0},System-Nullable{System-Int32}- 'Semantica.Linq.QueryableLinq.ConditionalSkip``1(System.Linq.IQueryable{``0},System.Nullable{System.Int32})')
  - [ConditionalWhereParameter\`\`2(queryable,condition,predicateFunc,params)](#M-Semantica-Linq-QueryableLinq-ConditionalWhereParameter``2-System-Linq-IQueryable{``0},System-Boolean,System-Func{``1,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}},System-Collections-Generic-IEnumerable{``1}- 'Semantica.Linq.QueryableLinq.ConditionalWhereParameter``2(System.Linq.IQueryable{``0},System.Boolean,System.Func{``1,System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}},System.Collections.Generic.IEnumerable{``1})')
  - [ConditionalWhere\`\`1(queryable,condition,predicate)](#M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Boolean,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'Semantica.Linq.QueryableLinq.ConditionalWhere``1(System.Linq.IQueryable{``0},System.Boolean,System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})')
  - [ConditionalWhere\`\`1(queryable,predicate)](#M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- 'Semantica.Linq.QueryableLinq.ConditionalWhere``1(System.Linq.IQueryable{``0},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})')
  - [ConditionalWhere\`\`1(queryable,condition,predicateFunc)](#M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Boolean,System-Func{System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}}- 'Semantica.Linq.QueryableLinq.ConditionalWhere``1(System.Linq.IQueryable{``0},System.Boolean,System.Func{System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}})')
  - [WhereParameter\`\`2(queryable,predicateFunc,params)](#M-Semantica-Linq-QueryableLinq-WhereParameter``2-System-Linq-IQueryable{``0},System-Func{``1,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}},System-Collections-Generic-IEnumerable{``1}- 'Semantica.Linq.QueryableLinq.WhereParameter``2(System.Linq.IQueryable{``0},System.Func{``1,System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}},System.Collections.Generic.IEnumerable{``1})')
- [ReadOnlyCollectionLinq](#T-Semantica-Linq-ReadOnlyCollectionLinq 'Semantica.Linq.ReadOnlyCollectionLinq')
  - [Any\`\`1(source)](#M-Semantica-Linq-ReadOnlyCollectionLinq-Any``1-System-Collections-Generic-IReadOnlyCollection{``0}- 'Semantica.Linq.ReadOnlyCollectionLinq.Any``1(System.Collections.Generic.IReadOnlyCollection{``0})')
  - [IsNullOrEmpty\`\`1(source)](#M-Semantica-Linq-ReadOnlyCollectionLinq-IsNullOrEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0}- 'Semantica.Linq.ReadOnlyCollectionLinq.IsNullOrEmpty``1(System.Collections.Generic.IReadOnlyCollection{``0})')
  - [NullIfEmpty\`\`1(source)](#M-Semantica-Linq-ReadOnlyCollectionLinq-NullIfEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0}- 'Semantica.Linq.ReadOnlyCollectionLinq.NullIfEmpty``1(System.Collections.Generic.IReadOnlyCollection{``0})')
  - [SelectArraySkipLast\`\`2(source,transformFunc,count)](#M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,``1},System-Int32- 'Semantica.Linq.ReadOnlyCollectionLinq.SelectArraySkipLast``2(System.Collections.Generic.IReadOnlyCollection{``0},System.Func{``0,``1},System.Int32)')
  - [SelectArray\`\`2(source,transformFunc)](#M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArray``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyCollectionLinq.SelectArray``2(System.Collections.Generic.IReadOnlyCollection{``0},System.Func{``0,``1})')
  - [SelectArray\`\`2(source,transformFunc)](#M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArray``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,System-Int32,``1}- 'Semantica.Linq.ReadOnlyCollectionLinq.SelectArray``2(System.Collections.Generic.IReadOnlyCollection{``0},System.Func{``0,System.Int32,``1})')
- [ReadOnlyDictionaryLinq](#T-Semantica-Linq-ReadOnlyDictionaryLinq 'Semantica.Linq.ReadOnlyDictionaryLinq')
  - [IsNullOrEmpty\`\`2(readOnlyDictionary)](#M-Semantica-Linq-ReadOnlyDictionaryLinq-IsNullOrEmpty``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1}- 'Semantica.Linq.ReadOnlyDictionaryLinq.IsNullOrEmpty``2(System.Collections.Generic.IReadOnlyDictionary{``0,``1})')
- [ReadOnlyListLinq](#T-Semantica-Linq-ReadOnlyListLinq 'Semantica.Linq.ReadOnlyListLinq')
  - [AreDistinctOrDefault\`\`2(list,propFunc,equalityComparer)](#M-Semantica-Linq-ReadOnlyListLinq-AreDistinctOrDefault``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}- 'Semantica.Linq.ReadOnlyListLinq.AreDistinctOrDefault``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1},System.Collections.Generic.IEqualityComparer{``1})')
  - [AreDistinctOrDefault\`\`2(list,propFunc)](#M-Semantica-Linq-ReadOnlyListLinq-AreDistinctOrDefault``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyListLinq.AreDistinctOrDefault``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1})')
  - [AreDistinct\`\`2(list,propFunc,equalityComparer)](#M-Semantica-Linq-ReadOnlyListLinq-AreDistinct``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}- 'Semantica.Linq.ReadOnlyListLinq.AreDistinct``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1},System.Collections.Generic.IEqualityComparer{``1})')
  - [AreDistinct\`\`2(list,propFunc)](#M-Semantica-Linq-ReadOnlyListLinq-AreDistinct``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyListLinq.AreDistinct``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1})')
  - [ConcatArray\`\`1(list,concatList)](#M-Semantica-Linq-ReadOnlyListLinq-ConcatArray``1-System-Collections-Generic-IReadOnlyList{``0},System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.ConcatArray``1(System.Collections.Generic.IReadOnlyList{``0},System.Collections.Generic.IReadOnlyList{``0})')
  - [CopyTo\`\`1(source,target,index)](#M-Semantica-Linq-ReadOnlyListLinq-CopyTo``1-System-Collections-Generic-IReadOnlyList{``0},``0[],System-Int32- 'Semantica.Linq.ReadOnlyListLinq.CopyTo``1(System.Collections.Generic.IReadOnlyList{``0},``0[],System.Int32)')
  - [ElementAtOrDefault\`\`1(source,index)](#M-Semantica-Linq-ReadOnlyListLinq-ElementAtOrDefault``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.ElementAtOrDefault``1(System.Collections.Generic.IReadOnlyList{``0},System.Int32)')
  - [First\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-First``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.First``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [ForEach\`\`1(list,action)](#M-Semantica-Linq-ReadOnlyListLinq-ForEach``1-System-Collections-Generic-IReadOnlyList{``0},System-Action{``0}- 'Semantica.Linq.ReadOnlyListLinq.ForEach``1(System.Collections.Generic.IReadOnlyList{``0},System.Action{``0})')
  - [ForEach\`\`1(list,action)](#M-Semantica-Linq-ReadOnlyListLinq-ForEach``1-System-Collections-Generic-IReadOnlyList{``0},System-Action{``0,System-Int32}- 'Semantica.Linq.ReadOnlyListLinq.ForEach``1(System.Collections.Generic.IReadOnlyList{``0},System.Action{``0,System.Int32})')
  - [GetOrDefault\`\`1(list,index)](#M-Semantica-Linq-ReadOnlyListLinq-GetOrDefault``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.GetOrDefault``1(System.Collections.Generic.IReadOnlyList{``0},System.Int32)')
  - [IndexOf\`\`1(source,element)](#M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},``0- 'Semantica.Linq.ReadOnlyListLinq.IndexOf``1(System.Collections.Generic.IReadOnlyList{``0},``0)')
  - [IndexOf\`\`1(source,element,startIndex)](#M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},``0,System-Int32- 'Semantica.Linq.ReadOnlyListLinq.IndexOf``1(System.Collections.Generic.IReadOnlyList{``0},``0,System.Int32)')
  - [IndexOf\`\`1(source,predicate)](#M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.ReadOnlyListLinq.IndexOf``1(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Boolean})')
  - [IndexOf\`\`1(source,predicate,startIndex)](#M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.IndexOf``1(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Boolean},System.Int32)')
  - [IsNullOrEmpty\`\`1(list)](#M-Semantica-Linq-ReadOnlyListLinq-IsNullOrEmpty``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.IsNullOrEmpty``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [LastIndexOf\`\`1(source,predicate)](#M-Semantica-Linq-ReadOnlyListLinq-LastIndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean}- 'Semantica.Linq.ReadOnlyListLinq.LastIndexOf``1(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Boolean})')
  - [LastIndexOf\`\`1(source,predicate,startIndex)](#M-Semantica-Linq-ReadOnlyListLinq-LastIndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.LastIndexOf``1(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Boolean},System.Int32)')
  - [Last\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-Last``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.Last``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [NullIfEmpty\`\`1(list)](#M-Semantica-Linq-ReadOnlyListLinq-NullIfEmpty``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.NullIfEmpty``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [SelectArrayAndPass\`\`3(source,transformFunc,param)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAndPass``3-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``2,``1},``2- 'Semantica.Linq.ReadOnlyListLinq.SelectArrayAndPass``3(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``2,``1},``2)')
  - [SelectArrayAndPass\`\`4(source,transformFunc,param,param2)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAndPass``4-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``2,``3,``1},``2,``3- 'Semantica.Linq.ReadOnlyListLinq.SelectArrayAndPass``4(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``2,``3,``1},``2,``3)')
  - [SelectArrayAsync\`\`2(source,selectFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAsync``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Threading-Tasks-Task{``1}}- 'Semantica.Linq.ReadOnlyListLinq.SelectArrayAsync``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Threading.Tasks.Task{``1}})')
  - [SelectArrayAsync\`\`2(source,selectFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAsync``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Int32,System-Threading-Tasks-Task{``1}}- 'Semantica.Linq.ReadOnlyListLinq.SelectArrayAsync``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Int32,System.Threading.Tasks.Task{``1}})')
  - [SelectArrayOrNull\`\`2(source,transformFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArrayOrNull``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyListLinq.SelectArrayOrNull``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1})')
  - [SelectArraySkipLast\`\`2(source,transformFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyListLinq.SelectArraySkipLast``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1})')
  - [SelectArraySkipLast\`\`2(source,transformFunc,count)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.SelectArraySkipLast``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1},System.Int32)')
  - [SelectArray\`\`2(source,selectFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}- 'Semantica.Linq.ReadOnlyListLinq.SelectArray``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,``1})')
  - [SelectArray\`\`2(source,selectFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Int32,``1}- 'Semantica.Linq.ReadOnlyListLinq.SelectArray``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Int32,``1})')
  - [SelectArray\`\`2(source,selectFunc)](#M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean,System-Boolean,``1}- 'Semantica.Linq.ReadOnlyListLinq.SelectArray``2(System.Collections.Generic.IReadOnlyList{``0},System.Func{``0,System.Boolean,System.Boolean,``1})')
  - [SkipLast\`\`1(list,numOfElementsToSkip)](#M-Semantica-Linq-ReadOnlyListLinq-SkipLast``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32- 'Semantica.Linq.ReadOnlyListLinq.SkipLast``1(System.Collections.Generic.IReadOnlyList{``0},System.Int32)')
  - [ToArray\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-ToArray``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.ToArray``1(System.Collections.Generic.IReadOnlyList{``0})')
  - [ToBucketDictionary\`\`2(source,keysToCollate,keyFunc)](#M-Semantica-Linq-ReadOnlyListLinq-ToBucketDictionary``2-System-Collections-Generic-IReadOnlyList{``1},System-Collections-Generic-IReadOnlyList{``0},System-Func{``1,``0}- 'Semantica.Linq.ReadOnlyListLinq.ToBucketDictionary``2(System.Collections.Generic.IReadOnlyList{``1},System.Collections.Generic.IReadOnlyList{``0},System.Func{``1,``0})')
  - [ToReadOnlyList\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-System-Collections-Generic-List{``0}- 'Semantica.Linq.ReadOnlyListLinq.ToReadOnlyList``1(System.Collections.Generic.List{``0})')
  - [ToReadOnlyList\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-``0[]- 'Semantica.Linq.ReadOnlyListLinq.ToReadOnlyList``1(``0[])')
  - [ToReadOnlyList\`\`1(source)](#M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Linq.ReadOnlyListLinq.ToReadOnlyList``1(System.Collections.Generic.IReadOnlyList{``0})')

<a name='T-Semantica-Linq-EnumerableLinq'></a>
## EnumerableLinq `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality to [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') collections.

<a name='M-Semantica-Linq-EnumerableLinq-AnyAndAll``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### AnyAndAll\`\`1(source,predicate) `method`

##### Summary

Determines whether all elements of a non-empty sequence satisfy a condition.

##### Returns

`true` if `source` contains at least one element and
`predicate` returns `true` for all elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to check. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-AnyToArray``1-System-Collections-Generic-IEnumerable{``0},``0[]@-'></a>
### AnyToArray\`\`1(source,array) `method`

##### Summary

Creates an array from the sequence and returns a value indicating whether it contains any items.

##### Returns

`true` if `array` contains at least one element; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| array | [\`\`0[]@](#T-``0[]@ '``0[]@') | When this method returns, contains an array with the elements from the input sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-AnyToList``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-List{``0}@-'></a>
### AnyToList\`\`1(source,list) `method`

##### Summary

Creates a [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') from the sequence and returns a value indicating whether it contains any items.

##### Returns

`true` if `list` contains at least one element; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| list | [System.Collections.Generic.List{\`\`0}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}@') | When this method returns, contain a new [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') with the elements from the input sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-AnyToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyList{``0}@-'></a>
### AnyToReadOnlyList\`\`1(source,list) `method`

##### Summary

Creates an [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') from the sequence and returns a value indicating whether it contains any items.

##### Returns

`true` if `list` contains at least one element; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}@') | When this method returns, contain an [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') with the elements from the input sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-Append``1-System-Collections-Generic-IEnumerable{``0},``0[]-'></a>
### Append\`\`1(source,append) `method`

##### Summary

Appends one or multiple values to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by those in
`append`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to append things to. |
| append | [\`\`0[]](#T-``0[] '``0[]') | An array of elements to append. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-AsReadOnlyCollection``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### AsReadOnlyCollection\`\`1(source) `method`

##### Summary

Returns an enumerable as a [IReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection`1 'System.Collections.Generic.IReadOnlyCollection`1'). If the passed class can be, it will be cast, otherwise
the enumeration is converted to a new collection.

##### Returns

A [IReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection`1 'System.Collections.Generic.IReadOnlyCollection`1') that is a new instance only if it cannot be cast.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | A sequence of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-AsReadOnlyList``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### AsReadOnlyList\`\`1(source) `method`

##### Summary

Returns an enumerable as a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'). If the passed class can be, it will be cast, otherwise
the enumeration is converted to a new list.

##### Returns

A [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that is a new instance only if it cannot be cast.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | A sequence of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConcatWhenNotNull``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### ConcatWhenNotNull\`\`1(enumerable,second) `method`

##### Summary

Concatenates two sequences if the second sequence is not `null`.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements of the two sequences, or the first sequence if
`second` is `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The first sequence to concatenate. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The sequence to concatenate to the first sequence, or `null`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in both sequences. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,``0[]-'></a>
### ConditionalAppend\`\`1(source,condition,append) `method`

##### Summary

Conditionally appends one or multiple values to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by those in
`append` if condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to append things to. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| append | [\`\`0[]](#T-``0[] '``0[]') | An array of elements to append. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### ConditionalAppend\`\`1(source,element) `method`

##### Summary

Conditionally appends a value to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by
`element` if not `null`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to append things to. |
| element | [\`\`0](#T-``0 '``0') | An element to append, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalAppend``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{``0}-'></a>
### ConditionalAppend\`\`1(source,element) `method`

##### Summary

Conditionally appends a value to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by
`element` if not `null`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to append things to. |
| element | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | An element to append, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalConcat``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}-'></a>
### ConditionalConcat\`\`1(source,condition,second) `method`

##### Summary

Concatenates two sequences if the specified condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements
of the two input sequences; otherwise, returns the first sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The first sequence to concatenate. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the two sequences should be concatenated. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The sequence to concatenate to the first sequence |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in both sequences. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalIntersectBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``1},System-Func{``0,``1}-'></a>
### ConditionalIntersectBy\`\`2(source,condition,second,keySelector) `method`

##### Summary

Produces the set intersection of two sequences according to a specified key selector function, if the specified
condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the distinct
elements that appear in both sequences; otherwise, returns the first sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in `second` will be returned. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the intersection of the two sequences is produced. |
| second | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in the first sequence will be returned. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to extract the key for each element in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TKey | The type of elements in `second`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalIntersectBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``1},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}-'></a>
### ConditionalIntersectBy\`\`2(source,condition,second,keySelector,equalityComparer) `method`

##### Summary

Produces the set intersection of two sequences according to a specified key selector function, if the specified
condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the distinct
elements that appear in both sequences; otherwise, returns the first sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in `second` will be returned. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the intersection of the two sequences is produced. |
| second | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in the first sequence will be returned. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to extract the key for each element in `source`. |
| equalityComparer | [System.Collections.Generic.IEqualityComparer{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``1}') | An [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') used to compare keys. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TKey | The type of elements in `second`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalIntersect``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}-'></a>
### ConditionalIntersect\`\`1(source,condition,second) `method`

##### Summary

Produces the set intersection of two sequences using the default equality comparer, if the specified condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the distinct
elements that appear in both sequences; otherwise, returns the first sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in `second` will be returned. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the intersection of the two sequences is produced. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in the first sequence will be returned. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in both sequences. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalIntersect``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEqualityComparer{``0}-'></a>
### ConditionalIntersect\`\`1(source,condition,second,equalityComparer) `method`

##### Summary

Produces the set intersection of two sequences using the specified [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1'), if the specified
condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the distinct
elements that appear in both sequences; otherwise, returns the first sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in `second` will be returned. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the intersection of the two sequences is produced. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements that also appear in the first sequence will be returned. |
| equalityComparer | [System.Collections.Generic.IEqualityComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``0}') | An [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') used to compare values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in both sequences. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,``0[]-'></a>
### ConditionalPrepend\`\`1(source,condition,prepend) `method`

##### Summary

Conditionally prepends one or multiple values to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by those in
`prepend` if condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to prepend things to. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| prepend | [\`\`0[]](#T-``0[] '``0[]') | An array of elements to prepend. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### ConditionalPrepend\`\`1(source,element) `method`

##### Summary

Conditionally prepends a value to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by
`element` if not `null`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to prepend things to. |
| element | [\`\`0](#T-``0 '``0') | An element to prepend, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalPrepend``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{``0}-'></a>
### ConditionalPrepend\`\`1(source,element) `method`

##### Summary

Conditionally prepends a value to the end of a sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `source` followed by
`element` if not `null`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to prepend things to. |
| element | [System.Nullable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{``0}') | An element to prepend, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalSkip``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Int32-'></a>
### ConditionalSkip\`\`1(source,condition,count) `method`

##### Summary

Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
condition is met.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements that occur after the specified index in the input sequence,
or `source` if `condition` is `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements to skip before returning the remaining elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalSkip``1-System-Collections-Generic-IEnumerable{``0},System-Nullable{System-Int32}-'></a>
### ConditionalSkip\`\`1(source,count) `method`

##### Summary

Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
count has a value.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements that occur after the specified index in the input sequence,
or `source` if count has no value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |
| count | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The number of elements to skip before returning the remaining elements, or `null`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalUnionBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}-'></a>
### ConditionalUnionBy\`\`2(source,condition,second,keySelector) `method`

##### Summary

Conditionally produces the set union of two sequences according to a specified key selector function.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from both input sequences, excluding duplicates, if
condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the first set for the union. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the second set for the union. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to extract the key for each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |
| TKey | The type of key to identify elements by. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalUnionBy``2-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}-'></a>
### ConditionalUnionBy\`\`2(source,condition,second,keySelector,comparer) `method`

##### Summary

Conditionally produces the set union of two sequences according to a specified key selector function.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from both input sequences, excluding duplicates, if
condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the first set for the union. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the second set for the union. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to extract the key for each element. |
| comparer | [System.Collections.Generic.IEqualityComparer{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``1}') | The [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') to compare key values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |
| TKey | The type of key to identify elements by. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalUnion``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0}-'></a>
### ConditionalUnion\`\`1(source,condition,second) `method`

##### Summary

Conditionally produces the set union of two sequences by using the default equality comparer.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from both input sequences, excluding duplicates, if
condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the first set for the union. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the second set for the union. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalUnion``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEqualityComparer{``0}-'></a>
### ConditionalUnion\`\`1(source,condition,second,comparer) `method`

##### Summary

Conditionally produces the set union of two sequences by using a specified [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1').

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from both input sequences, excluding duplicates, if
condition is `true`; `source` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the first set for the union. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If `false`, will just return `source`. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose distinct elements form the second set for the union. |
| comparer | [System.Collections.Generic.IEqualityComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``0}') | The [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') to compare values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalWhere``1-System-Collections-Generic-IEnumerable{``0},System-Boolean,System-Func{``0,System-Boolean}-'></a>
### ConditionalWhere\`\`1(source,condition,predicate) `method`

##### Summary

Filters a sequence based on a predicate, if the specified condition is met.

##### Returns

If `condition` is `true`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains elements from
the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to filter. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the filter is applied. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ConditionalWhere``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### ConditionalWhere\`\`1(source,predicate) `method`

##### Summary

Filters a sequence based on a predicate, if the specified condition is met.

##### Returns

If `predicate` is not `null`, an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains elements from
the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to filter. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-Enumerate``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Enumerate\`\`1() `method`

##### Summary

Just enumerates all elements of the IEnumerable without doing or returning anything.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Linq-EnumerableLinq-FirstOrDefaultOfFirst``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Collections-Generic-IEnumerable{``1}},System-Func{``1,System-Boolean}-'></a>
### FirstOrDefaultOfFirst\`\`2(source,selector,predicate) `method`

##### Summary

Returns the first element that satisfies a condition in a projection of the collection.

##### Returns

A tuple that contains the first element that satisfies `predicate` in a list of items selected by
`selector`, and the associated element in `source`. If no elements match
`predicate`, returns a tuple with a default value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to project and find. |
| selector | [System.Func{\`\`0,System.Collections.Generic.IEnumerable{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Collections.Generic.IEnumerable{``1}}') | A transform function to apply to each element. |
| predicate | [System.Func{\`\`1,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,System.Boolean}') | A function to test each element of the projection for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |
| TOut | The type of elements in the projection. |

<a name='M-Semantica-Linq-EnumerableLinq-FollowFrom-System-Collections-Generic-IEnumerable{System-Boolean},System-Boolean-'></a>
### FollowFrom(source,if) `method`

##### Summary

Determines if the provided booleans follow from `if` [`if` ->
`source`].

##### Returns

`true` if either `if` is `false`, or `if` and all
elements of `source` are `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Boolean}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of `bool` values. |
| if | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The `bool` parameter to be tested. |

<a name='M-Semantica-Linq-EnumerableLinq-FollowFrom``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean},System-Boolean-'></a>
### FollowFrom\`\`1(source,predicate,if) `method`

##### Summary

Determines if the provided booleans follow from `if`
[`if` -> `predicate`(`source`)].

##### Returns

`true` if either `if` is `false`, or `if` and all
`source` pass `predicate`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of elements to evaluate. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate used to evaluate the elements of `source`. |
| if | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The `bool` parameter to be tested. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ForEachAndPass``2-System-Collections-Generic-IEnumerable{``0},System-Action{``0,``1},``1-'></a>
### ForEachAndPass\`\`2(source,action,param) `method`

##### Summary

Invokes an action on each element in the sequence with an additional parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to invoke an
action on. |
| action | [System.Action{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1}') | A delegate to invoke on each element of `source`. `param` is passed as second
argument to this method. |
| param | [\`\`1](#T-``1 '``1') | A value to pass as the second argument of `action`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |
| TParam | The type of parameter to pass to `action`. |

<a name='M-Semantica-Linq-EnumerableLinq-ForEachAsync``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Threading-Tasks-Task}-'></a>
### ForEachAsync\`\`1(source,asyncAction) `method`

##### Summary

Asynchronously invokes an action on each element in the sequence.

##### Returns

A task representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the element to perform an action on. |
| asyncAction | [System.Func{\`\`0,System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Threading.Tasks.Task}') | A delegate that returns a task to await for each element in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ForEachWithNext``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0,``0},System-Boolean-'></a>
### ForEachWithNext\`\`1(source,action,skipLast) `method`

##### Summary

Invokes an action on each element in the sequence, along with the element that follows it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to invoke an action on. |
| action | [System.Action{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``0}') | A delegate to invoke on each element in `source`. The second argument contains the element that
follows the first argument in the collection. |
| skipLast | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to skip the last invocation, or `false` to invoke `action` on
the last element with the second argument set to a default value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}-'></a>
### ForEach\`\`1(source,action) `method`

##### Summary

Invokes an action on each element in the sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to perform an action on. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | A delegate to invoke on each element of `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-HasCount``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### HasCount\`\`1(source,count) `method`

##### Summary

Determines whether the sequence contains exactly `count` elements.

##### Returns

`true` if `source` contains exactly `count` elements;
otherwise, if `source` contains less or more elements, returns `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to count. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The expected number of elements in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-HasCount``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,System-Boolean}-'></a>
### HasCount\`\`1(source,count,predicate) `method`

##### Summary

Determines whether the sequence contains exactly `count` elements that satisfy a condition.

##### Returns

`true` if `source` contains exactly `count` elements for which
`predicate` returns `true`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to count. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The expected number of elements in `source`. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-HasNoneOrOne``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### HasNoneOrOne\`\`1(source) `method`

##### Summary

Determines whether the enumeration contains either no elements, or exactly one element.

##### Returns

`true` if the input contains exactly zero or one elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-HasNoneOrOne``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### HasNoneOrOne\`\`1(source,predicate) `method`

##### Summary

Determines whether the enumeration contains either no elements, or exactly one element for which
`predicate` evaluates to `true`.

##### Returns

`true` if the input contains exactly zero or one elements that satisfy the predicate;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A predicate that accepts an element of type `T`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-OneOrDefault``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### OneOrDefault\`\`1(source) `method`

##### Summary

The one element of the input sequence, or default( `T`) if the sequence contains no elements or
more than one element.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

Note that [SingleOrDefault\`\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Enumerable.SingleOrDefault``1 'System.Linq.Enumerable.SingleOrDefault``1(System.Collections.Generic.IEnumerable{``0})') will throw when the sequence contains more than
one element, whereas this extension will return `default`.

<a name='M-Semantica-Linq-EnumerableLinq-OneOrDefault``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### OneOrDefault\`\`1(source,predicate) `method`

##### Summary

The one element of the input sequence, or default(`T`) if the sequence contains no elements or
more than one element that satisfy `predicate`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A predicate that accepts an element of type `T`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-PrecedeBy``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### PrecedeBy\`\`1(source,startItem) `method`

##### Summary

Adds a value to the beginning of the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains `startItem` followed by the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to return after `startItem`. |
| startItem | [\`\`0](#T-``0 '``0') | The value to prepend to `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-Prepend``1-System-Collections-Generic-IEnumerable{``0},``0[]-'></a>
### Prepend\`\`1(source,prepend) `method`

##### Summary

Adds multiple values to the beginning of the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements in `prepend` followed by the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to return after the elements in `prepend`. |
| prepend | [\`\`0[]](#T-``0[] '``0[]') | An array of values to prepend to `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectAndPass``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``2,``1},``2-'></a>
### SelectAndPass\`\`3(source,transformFunc,param) `method`

##### Summary

Projects each element of a sequence into a new form, with an additional parameter to be passed to the transform
function.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose elements are the result of invoking the transform function on each element of the
input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`2,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2,``1}') | A transform function to apply to each source element; the second parameter of the function is `param`. |
| param | [\`\`2](#T-``2 '``2') | A value that is passed to `transformFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of values returned by `transformFunc`. |
| TParam | The type of parameter passed to `transformFunc`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectAndPass``4-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``2,``3,``1},``2,``3-'></a>
### SelectAndPass\`\`4(source,selectFunc,param1,param2) `method`

##### Summary

Projects each element of a sequence into a new form, with two additional parameters to be passed to the transform
function.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') whose elements are the result of invoking the transform function on each element of the
input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to transform. |
| selectFunc | [System.Func{\`\`0,\`\`2,\`\`3,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2,``3,``1}') | A transform function to apply to each source element; the second and third parameters of the function are
`param1` and `param2`, respectively. |
| param1 | [\`\`2](#T-``2 '``2') | A value that is passed to `selectFunc`. |
| param2 | [\`\`3](#T-``3 '``3') | A second value that is passed to `selectFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of values returned by `selectFunc`. |
| TParam1 | The type of first parameter passed to `selectFunc`. |
| TParam2 | The type of the second parameter passed to `selectFunc`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectArrayAndPass``3-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,``1,``2},``1-'></a>
### SelectArrayAndPass\`\`3(source,length,selectFunc,param) `method`

##### Summary

Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
item.

##### Returns

A new array with up to `length` elements from `source` after applying a
transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The sequence to source elements from. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the new array. |
| selectFunc | [System.Func{\`\`0,\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2}') | A function that selects the items to be returned in the new array based on each element in `source`.
The second parameter is `param`. |
| param | [\`\`1](#T-``1 '``1') | A value passed to `selectFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of elements in the array to be returned. |
| TParam | The type of value to be passed along to `selectFunc`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectArray``2-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,``1}-'></a>
### SelectArray\`\`2(source,length,selectFunc) `method`

##### Summary

Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
item.

##### Returns

A new array with up to `length` elements from `source` after applying a
transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The sequence to source elements from. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the new array. |
| selectFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function that selects the items to be returned in the new array based on each element in
`source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of elements in the array to be returned. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectArray``2-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Func{``0,System-Int32,``1}-'></a>
### SelectArray\`\`2(source,length,selectFunc) `method`

##### Summary

Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
item.

##### Returns

A new array with up to `length` elements from `source` after applying a
transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The sequence to source elements from. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the created array. |
| selectFunc | [System.Func{\`\`0,System.Int32,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Int32,``1}') | A function that selects the items to be returned in the new array based on each element in `source`
and its zero-based index in the new array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of elements in the array to be returned. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectIfDictionaryContains``2-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyDictionary{``0,``1}-'></a>
### SelectIfDictionaryContains\`\`2(enumerable,dict) `method`

##### Summary

Projects each element of a sequence into a key/value pair based on the specified dictionary.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of key/value pairs with values from `dict`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection to transform. |
| dict | [System.Collections.Generic.IReadOnlyDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{``0,``1}') | The dictionary whose values to use in the projected sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of keys in `dict`. |
| TValue | The type of values in `dict`. |

##### Remarks

Elements from `enumerable` that are not found in `dict` will not be returned.

<a name='M-Semantica-Linq-EnumerableLinq-SelectIfDictionaryContains``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Collections-Generic-IReadOnlyDictionary{``1,``2}-'></a>
### SelectIfDictionaryContains\`\`3(source,keyFunc,dict) `method`

##### Summary

Projects each element of a sequence into a key/value pair based on the specified dictionary.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of key/value pairs with values from `dict` based on the
`keyFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection to transform. |
| keyFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to select matching dictionary keys from items in `source`. |
| dict | [System.Collections.Generic.IReadOnlyDictionary{\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{``1,``2}') | The dictionary whose values to use in the projected sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TObj | The type of elements in `source`. |
| TKey | The type of keys in `dict`. |
| TValue | The type of values in `dict`. |

##### Remarks

Elements from `source` that are not found in `dict` will not be returned.

<a name='M-Semantica-Linq-EnumerableLinq-SelectManyTuples``2-System-Collections-Generic-IEnumerable{``0}-'></a>
### SelectManyTuples\`\`2(enumerable) `method`

##### Summary

Flattens the sequences into a single sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains tuples where the second item is each element in the flattened list, and
the first item is the list that contained it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains sequences to flatten. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `enumerable`. |
| TSourcener | The type of elements in `T`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectMany``1-System-Collections-Generic-IEnumerable{System-Collections-Generic-IEnumerable{``0}}-'></a>
### SelectMany\`\`1(source) `method`

##### Summary

Flattens the sequences into a single sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from each sequence in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Collections.Generic.IEnumerable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Collections.Generic.IEnumerable{``0}}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') objects to flatten. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in each sequence in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectWithContext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``0,``1}-'></a>
### SelectWithContext\`\`2(source,combineWithContext) `method`

##### Summary

A Select-variant that expects a transformation function `combineWithContext` that accepts three input
items. The transformation will be called with each element as the second parameter, the previous element as the first
parameter, and the next element in the enumeration as the third parameter. Then the enumeration reaches the last
element, the transformation is called with default( `TSource`) as second parameter.

##### Returns

An enumeration of items of type `TOut`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumeration of items of type `TSource`. |
| combineWithContext | [System.Func{\`\`0,\`\`0,\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0,``0,``1}') | A transformation function that creates elements of type `TOut`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectWithNext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1}-'></a>
### SelectWithNext\`\`2(source,combineWithNextFunc) `method`

##### Summary

A Select-variant that expects a transformation function `combineWithNextFunc` that accepts two input
items. The transformation will be called with each element as the first parameter, and the next element in the
enumeration as the second parameter. Then the enumeration reaches the last element, the transformation is called
with default( `TSource`) as second parameter.

##### Returns

An enumeration of items of type `TOut`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumeration of items of type `TSource`. |
| combineWithNextFunc | [System.Func{\`\`0,\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0,``1}') | A transformation function that creates elements of type `TOut`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectWithNext``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1},System-Boolean-'></a>
### SelectWithNext\`\`2(source,combineWithNextFunc,skipLast) `method`

##### Summary

A Select-variant that expects a transformation function `combineWithNextFunc` that accepts two input
items. The transformation will be called with each element as the first parameter, and the next element in the
enumeration as the second parameter. Then the enumeration reaches the last element, the transformation is called with
default( `TSource`) as second parameter.

##### Returns

An enumeration of items of type `TOut`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumeration of items of type `TSource`. |
| combineWithNextFunc | [System.Func{\`\`0,\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0,``1}') | A transformation function that creates elements of type `TOut`. |
| skipLast | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | When true, the enumeration will skipped for the last element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-EnumerableLinq-SelectWithPrevious``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,``1}-'></a>
### SelectWithPrevious\`\`2(source,combineWithPreviousFunc) `method`

##### Summary

A Select-variant that expects a transformation function `combineWithPreviousFunc` that accepts two
input items. The transformation will be called with each element as the first parameter, and the previous element in
the enumeration as the second parameter. For the first element in the enumeration the transformation is called with
default( `TSource`) as second parameter.

##### Returns

An enumeration of items of type `TOut`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumeration of items of type `TSource`. |
| combineWithPreviousFunc | [System.Func{\`\`0,\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0,``1}') | A transformation function that creates elements of type `TOut`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-EnumerableLinq-Select``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean,System-Boolean,``1}-'></a>
### Select\`\`2(source,selectFunc) `method`

##### Summary

Overload of Select that expects a transformation function `selectFunc` with two additional boolean
parameters: The first boolean will be set to true if the transformed item is the first item in the source. The
second boolean will be set to true if the transformed item is the last item in the source.

##### Returns

An enumeration of items of type `TOut`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An enumeration of items of type `TSource`. |
| selectFunc | [System.Func{\`\`0,System.Boolean,System.Boolean,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean,System.Boolean,``1}') | A transformation function that creates elements of type `TOut`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-EnumerableLinq-Sum-System-Collections-Generic-IEnumerable{System-Int16}-'></a>
### Sum(source) `method`

##### Summary

Computes the sum of a sequence of [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') values.

##### Returns

The sum of values in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Int16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int16}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') values to calculate the sum of. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.OverflowException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.OverflowException 'System.OverflowException') | The sum of values exceeds [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16.MaxValue 'System.Int16.MaxValue'). |

<a name='M-Semantica-Linq-EnumerableLinq-Sum``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Sum\`\`1(source) `method`

##### Summary

Computes the sum of a sequence of `T` values.

##### Returns

The sum of values in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of values to calculate the sum of. |

<a name='M-Semantica-Linq-EnumerableLinq-Sum``2-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1}-'></a>
### Sum\`\`2(source,selector) `method`

##### Summary

Computes the sum of a sequence of `TSource` elements.

##### Returns

The sum of values selected from `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of values to calculate the sum of. |
| selector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function that selects the `TValue` value from an element. |

<a name='M-Semantica-Linq-EnumerableLinq-ToArrayOrNull``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ToArrayOrNull\`\`1(source) `method`

##### Summary

Creates an array from the sequence only if it contains any elements.

##### Returns

A new array containing elements from the input sequence, or `null` if the input sequence is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ToArray``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### ToArray\`\`1(source,length) `method`

##### Summary

Creates an array with the specified length from the sequence.

##### Returns

A new array with `length` items taken from `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the new array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

If the input sequence contains fewer items than `length`, the remaining elements in the array are
padded with default values.

<a name='M-Semantica-Linq-EnumerableLinq-ToArray``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0-'></a>
### ToArray\`\`1(source,length,defaultValue) `method`

##### Summary

Creates an array with the specified length from the sequence.

##### Returns

A new array with `length` items taken from `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the new array. |
| defaultValue | [\`\`0](#T-``0 '``0') | The value pad the the array with when the sequence contains fewer than `length` items. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

If the input sequence contains fewer items than `length`, the remaining elements in the array are
padded with `defaultValue`.

<a name='M-Semantica-Linq-EnumerableLinq-ToListOrNull``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ToListOrNull\`\`1(source) `method`

##### Summary

Creates a [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') from the sequence only if it contains any elements.

##### Returns

A new [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') containing elements from the input sequence, or `null` if the input sequence
is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ToReadOnlyDictionary``3-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``1},System-Func{``0,``2}-'></a>
### ToReadOnlyDictionary\`\`3(enumerable,keySelector,elementSelector) `method`

##### Summary

Creates a [IReadOnlyDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary`2 'System.Collections.Generic.IReadOnlyDictionary`2') from an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') according to specified
key selector and element selector functions.

##### Returns

A [IReadOnlyDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary`2 'System.Collections.Generic.IReadOnlyDictionary`2') that contains values of type `TElement` selected
from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to create a [IReadOnlyDictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary`2 'System.Collections.Generic.IReadOnlyDictionary`2') from. |
| keySelector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to extract a key from each element. |
| elementSelector | [System.Func{\`\`0,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2}') | A transform function to produce a result element value from each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `enumerable`. |
| TKey | The type of the key returned by `keySelector`. |
| TElement | The type of the value returned by `elementSelector`. |

<a name='M-Semantica-Linq-EnumerableLinq-ToReadOnlyListOrNull``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ToReadOnlyListOrNull\`\`1(source) `method`

##### Summary

Creates a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') from the sequence only if it contains any elements.

##### Returns

A new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing elements from the input sequence, or `null` if the input
sequence is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ToReadOnlyList\`\`1(source) `method`

##### Summary

Creates a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') from the sequence.

##### Returns

A [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains elements from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### ToReadOnlyList\`\`1(source,length) `method`

##### Summary

Creates a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') with the specified amount of items from the sequence.

##### Returns

A [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains exactly `length` elements from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the read-only list to create. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

If the input sequence contains fewer items than `length`, the resulting list will be padded with nulls
or default values.

<a name='M-Semantica-Linq-EnumerableLinq-ToReadOnlyList``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0-'></a>
### ToReadOnlyList\`\`1(source,length,defaultValue) `method`

##### Summary

Creates a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') with the specified amount of items from the sequence.

##### Returns

A [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains exactly `length` elements from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to convert. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the read-only list to create. |
| defaultValue | [\`\`0](#T-``0 '``0') | The value pad the the output with when the sequence contains fewer than `length` items. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

If the input sequence contains fewer items than `length`, the resulting list will be padded with
`defaultValue`.

<a name='M-Semantica-Linq-EnumerableLinq-TryFirst``1-System-Collections-Generic-IEnumerable{``0},``0@-'></a>
### TryFirst\`\`1(source,first) `method`

##### Summary

Gets the first element of the enumerable and puts it in the out parameter. Returns false if the enumerable had no
elements.

##### Returns

`true` if `source` contains at least one item; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the item to find. |
| first | [\`\`0@](#T-``0@ '``0@') | When this method returns `true`, contains the first item in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-TryPrevious``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean},``0@-'></a>
### TryPrevious\`\`1(source,predicate,element) `method`

##### Summary

Retrieves the element that precedes the first element that satisfies a condition, and returns a value indicating
whether such an element exists.

##### Returns

`true` if `predicate` returned `true` for an element in
`source`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the items to find. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition. |
| element | [\`\`0@](#T-``0@ '``0@') | When this method returns `true`, contains the item that precedes the first item for which
`predicate` returns `true`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-TrySingle``1-System-Collections-Generic-IEnumerable{``0},``0@-'></a>
### TrySingle\`\`1(source,matchedElement) `method`

##### Summary

Retrieves the only element in the sequence, and returns a value indicating whether the operation succeeded.

##### Returns

`true` if `source` only contains one item; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that may or may not contain a single item. |
| matchedElement | [\`\`0@](#T-``0@ '``0@') | When this method returns `true`, contains the only item in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotDefault``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### WhereNotDefault\`\`1(source) `method`

##### Summary

Filters the default values from a sequence of values.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains elements from the input sequence that are not equal to
`default`(`T`).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to filter. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The value type of elements of `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotIn``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IReadOnlyCollection{``0}-'></a>
### WhereNotIn\`\`1(source,compareCollection) `method`

##### Summary

Filters the specified items from the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains all elements from the input sequence that are not also in
`compareCollection`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to return. |
| compareCollection | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | A collection of items to filter from the input sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

##### Remarks

This method preserves duplicate values, unlike [Except\`\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Enumerable.Except``1 'System.Linq.Enumerable.Except``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})'), and
leverages any existing collection.

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotNul-System-Collections-Generic-IEnumerable{System-Char}-'></a>
### WhereNotNul(source) `method`

##### Summary

Filters NUL (`\0`) characters from the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains all non-NUL characters in the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Char}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of characters to filter. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotNullOrEmpty-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WhereNotNullOrEmpty(source) `method`

##### Summary

Filters `null` and empty strings from the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains all non-null and non-empty strings from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') with strings to return. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotNull``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### WhereNotNull\`\`1(source) `method`

##### Summary

Filters `null` elements from a sequence of values.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains all non-null values from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') with the values to return. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNotNull``1-System-Collections-Generic-IEnumerable{System-Nullable{``0}}-'></a>
### WhereNotNull\`\`1(source) `method`

##### Summary

Filters `null` elements from a sequence of values.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains all non-null values from the input sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Nullable{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Nullable{``0}}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') with the values to return. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-EnumerableLinq-WhereNot``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>
### WhereNot\`\`1(source,predicate) `method`

##### Summary

Filters elements that satisfy a predicate from the sequence.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains only elements from the input sequence that do not satisfy
`predicate`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements to filter. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | A function to test each element for a condition (or lack thereof). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='T-Semantica-Linq-EnumeratorExtensions'></a>
## EnumeratorExtensions `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality for enumerators.

<a name='M-Semantica-Linq-EnumeratorExtensions-TryMoveNext``1-System-Collections-Generic-IEnumerator{``0},``0@-'></a>
### TryMoveNext\`\`1(enumerator,element) `method`

##### Summary

Attemps to advance the enumerator to the next element in the collection.

##### Returns

`true` if the enumerator was successfully advanced to the next element; `false` if the
enumerator has passed the end of the collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Collections.Generic.IEnumerator{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator{``0}') | An [IEnumerator\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator`1 'System.Collections.Generic.IEnumerator`1'). |
| element | [\`\`0@](#T-``0@ '``0@') | When this method returns `true`, contains the element at the new position in the collection. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the collection. |

<a name='T-Semantica-Linq-QueryableLinq'></a>
## QueryableLinq `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality for LINQ queries.

<a name='M-Semantica-Linq-QueryableLinq-ConditionalSkip``1-System-Linq-IQueryable{``0},System-Boolean,System-Int32-'></a>
### ConditionalSkip\`\`1(queryable,condition,count) `method`

##### Summary

Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
condition is met.

##### Returns

If `condition` is `true`, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements
that occur after the specified index in the input sequence; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1'). |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the skip is applied. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements to skip before returning the remaining elements, or `null`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |

<a name='M-Semantica-Linq-QueryableLinq-ConditionalSkip``1-System-Linq-IQueryable{``0},System-Nullable{System-Int32}-'></a>
### ConditionalSkip\`\`1(queryable,count) `method`

##### Summary

Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
count has a value.

##### Returns

If `count` has a value, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements that occur after the
specified index in the input sequence; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1'). |
| count | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The number of elements to skip before returning the remaining elements, or `null`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |

<a name='M-Semantica-Linq-QueryableLinq-ConditionalWhereParameter``2-System-Linq-IQueryable{``0},System-Boolean,System-Func{``1,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}},System-Collections-Generic-IEnumerable{``1}-'></a>
### ConditionalWhereParameter\`\`2(queryable,condition,predicateFunc,params) `method`

##### Summary

Filters a query based on a series of parameterised predicates, if the specified condition is met.

##### Returns

If `condition` is `true`, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains elements from
the input sequence that satisfy all the generated predicates; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements to filter. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the filter is applied. |
| predicateFunc | [System.Func{\`\`1,System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}}') | A function that will return another function used to test each element, used to generate a predicate for each element in
`params`. |
| params | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | A sequence of parameters with which to generate predicates. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |
| TParam | The type of the parameter to generate the predicates. |

<a name='M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Boolean,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### ConditionalWhere\`\`1(queryable,condition,predicate) `method`

##### Summary

Filters a query based on a predicate, if the specified condition is met.

##### Returns

If `condition` is `true`, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains elements from
the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements to filter. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the filter is applied. |
| predicate | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | A function to test each element for a condition. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |

<a name='M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>
### ConditionalWhere\`\`1(queryable,predicate) `method`

##### Summary

Filters a query based on a predicate, if the specified condition is met.

##### Returns

If `predicate` is not `null`, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains elements from
the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements to filter. |
| predicate | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}') | A function to test each element for a condition, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |

<a name='M-Semantica-Linq-QueryableLinq-ConditionalWhere``1-System-Linq-IQueryable{``0},System-Boolean,System-Func{System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}}-'></a>
### ConditionalWhere\`\`1(queryable,condition,predicateFunc) `method`

##### Summary

Filters a query based on a predicate, if the specified condition is met.

##### Returns

If `condition` is `true`, an [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains elements from
the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements to filter. |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | A value that determines whether the filter is applied. |
| predicateFunc | [System.Func{System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}}') | A function that will return another function used to test each element. Only evaluated when `condition`
evaluates to `true` |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |

<a name='M-Semantica-Linq-QueryableLinq-WhereParameter``2-System-Linq-IQueryable{``0},System-Func{``1,System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}},System-Collections-Generic-IEnumerable{``1}-'></a>
### WhereParameter\`\`2(queryable,predicateFunc,params) `method`

##### Summary

Filters a query based on a series of parameterised predicates.

##### Returns

An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains elements from the input sequence that satisfy all the generated predicates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryable | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | An [IQueryable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable`1 'System.Linq.IQueryable`1') that contains the elements to filter. |
| predicateFunc | [System.Func{\`\`1,System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}}') | A function that will return another function used to test each element, used to generate a predicate for each element in
`params`. |
| params | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | A sequence of parameters with which to generate predicates. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `queryable`. |
| TParam | The type of the parameter to generate the predicates. |

<a name='T-Semantica-Linq-ReadOnlyCollectionLinq'></a>
## ReadOnlyCollectionLinq `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality for collections.

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-Any``1-System-Collections-Generic-IReadOnlyCollection{``0}-'></a>
### Any\`\`1(source) `method`

##### Summary

Determines whether a collection contains any elements.

##### Returns

`true` if input contains any elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-IsNullOrEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0}-'></a>
### IsNullOrEmpty\`\`1(source) `method`

##### Summary

Determines whether the collection is `null` or empty.

##### Returns

`true` if input is `null` or does not contain any items; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-NullIfEmpty``1-System-Collections-Generic-IReadOnlyCollection{``0}-'></a>
### NullIfEmpty\`\`1(source) `method`

##### Summary

Returns the collection, or `null` if it is empty.

##### Returns

`null` if input contains no items; otherwise the input is returned unchanged.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection to return. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in `source`. |

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,``1},System-Int32-'></a>
### SelectArraySkipLast\`\`2(source,transformFunc,count) `method`

##### Summary

Eagerly enumerates `source` and applies `transformFunc` but skips the last
`count` elements. Returns an array of type `TOut`.

##### Returns

array of type `TOut` of length `source`.Count - `count`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | Collection to enumerate. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Transformation function applied to elements of `source`. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Amount of elements to skip at end. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | Type of the elements of `source`. |
| TOut | Type of the elements of the returned array. |

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArray``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,``1}-'></a>
### SelectArray\`\`2(source,transformFunc) `method`

##### Summary

Converts the collection to an array using the specified transformation function.

##### Returns

A new array with the elements of the input passed through the transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection to convert. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function that selects the items to be returned in the converted array based on each element in
`source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of elements in `source`. |
| TOut | The type of elements in the array to be returned. |

<a name='M-Semantica-Linq-ReadOnlyCollectionLinq-SelectArray``2-System-Collections-Generic-IReadOnlyCollection{``0},System-Func{``0,System-Int32,``1}-'></a>
### SelectArray\`\`2(source,transformFunc) `method`

##### Summary

Converts the collection to an array using the specified transformation function.

##### Returns

A new array with the elements of the input passed through a transformation function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyCollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{``0}') | The collection to convert. |
| transformFunc | [System.Func{\`\`0,System.Int32,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Int32,``1}') | A function that selects the items to be returned in the converted array based on each element in
`source` and its zero-based index in the new array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of elements in `source`. |
| TOut | The type of elements in the array to be returned. |

<a name='T-Semantica-Linq-ReadOnlyDictionaryLinq'></a>
## ReadOnlyDictionaryLinq `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality for read-only dictionaries.

<a name='M-Semantica-Linq-ReadOnlyDictionaryLinq-IsNullOrEmpty``2-System-Collections-Generic-IReadOnlyDictionary{``0,``1}-'></a>
### IsNullOrEmpty\`\`2(readOnlyDictionary) `method`

##### Summary

Determines whether the read-only dictionary is `null` or empty.

##### Returns

`true` if `readOnlyDictionary` is `null` or does not contain any items;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| readOnlyDictionary | [System.Collections.Generic.IReadOnlyDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyDictionary 'System.Collections.Generic.IReadOnlyDictionary{``0,``1}') | The collection to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of keys in `readOnlyDictionary`. |
| TValue | The type of value in `readOnlyDictionary`. |

<a name='T-Semantica-Linq-ReadOnlyListLinq'></a>
## ReadOnlyListLinq `type`

##### Namespace

Semantica.Linq

##### Summary

Provides additional functionality for read-only lists.

<a name='M-Semantica-Linq-ReadOnlyListLinq-AreDistinctOrDefault``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}-'></a>
### AreDistinctOrDefault\`\`2(list,propFunc,equalityComparer) `method`

##### Summary

Determines whether all elements in the list are unique by comparing specific properties using the specified
[IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1'). Default values are ignored.

##### Returns

`true` if all elements with a non-default value in the list are unique according to
`propFunc` and `equalityComparer`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list whose uniqueness to determine. |
| propFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to select the property whose values to compare. |
| equalityComparer | [System.Collections.Generic.IEqualityComparer{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``1}') | An [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') used to compare values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |
| TProp | The type of property to compare. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-AreDistinctOrDefault``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}-'></a>
### AreDistinctOrDefault\`\`2(list,propFunc) `method`

##### Summary

Determines whether all elements in the list are unique by comparing specific properties using the default equality
comparer. Default values are ignored.

##### Returns

`true` if all elements that have a non-default value in the list are unique according to
`propFunc`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list whose uniqueness to determine. |
| propFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to select the property whose values to compare. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |
| TProp | The type of property to compare. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-AreDistinct``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Collections-Generic-IEqualityComparer{``1}-'></a>
### AreDistinct\`\`2(list,propFunc,equalityComparer) `method`

##### Summary

Determines whether all elements in the list are unique by comparing specific properties using the specified
[IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1').

##### Returns

`true` if all elements in the list are unique according to `propFunc` and
`equalityComparer`; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list whose uniqueness to determine. |
| propFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to select the property whose values to compare. |
| equalityComparer | [System.Collections.Generic.IEqualityComparer{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer{``1}') | An [IEqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer`1 'System.Collections.Generic.IEqualityComparer`1') used to compare values. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |
| TProp | The type of property to compare. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-AreDistinct``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}-'></a>
### AreDistinct\`\`2(list,propFunc) `method`

##### Summary

Determines whether all elements in the list are unique by comparing specific properties using the default equality
comparer.

##### Returns

`true` if all elements in the list are unique according to `propFunc`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list whose uniqueness to determine. |
| propFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A function to select the property whose values to compare. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |
| TProp | The type of property to compare. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ConcatArray``1-System-Collections-Generic-IReadOnlyList{``0},System-Collections-Generic-IReadOnlyList{``0}-'></a>
### ConcatArray\`\`1(list,concatList) `method`

##### Summary

Concatenates two lists and returns the result as an array.

##### Returns

A new array that contains the elements of `list` followed by the elements from
`concatList`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The first list to concatenate. |
| concatList | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The list to concatenate with the first list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the input lists. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-CopyTo``1-System-Collections-Generic-IReadOnlyList{``0},``0[],System-Int32-'></a>
### CopyTo\`\`1(source,target,index) `method`

##### Summary

Copies all the elements of the list to the target array, optionally starting at the specified destination index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') whose elements to copy. |
| target | [\`\`0[]](#T-``0[] '``0[]') | The array to copy the elements to. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index in `target` at which copying begins. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ElementAtOrDefault``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32-'></a>
### ElementAtOrDefault\`\`1(source,index) `method`

##### Summary

Returns the element at a specified index in a sequence or a default value if the index is out of range.

##### Returns

The element at the specified position in `source`; or `default` if
`index` is outside the bounds of the `source` sequence;

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to return the first element of. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the element to retrieve. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-First``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### First\`\`1(source) `method`

##### Summary

Returns the first element of a list.

##### Returns

The first element in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to return the first element of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') | `source` has no elements. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ForEach``1-System-Collections-Generic-IReadOnlyList{``0},System-Action{``0}-'></a>
### ForEach\`\`1(list,action) `method`

##### Summary

Invokes an action on each element in the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains the elements to invoke the action on. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | A delegate to invoke on each element in `list`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ForEach``1-System-Collections-Generic-IReadOnlyList{``0},System-Action{``0,System-Int32}-'></a>
### ForEach\`\`1(list,action) `method`

##### Summary

Invokes an action on each element in the list and its index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains the elements to invoke the action on. |
| action | [System.Action{\`\`0,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,System.Int32}') | A delegate to invoke on each element in `list`. The second parameter contains the index of the
corresponding element in the list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-GetOrDefault``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32-'></a>
### GetOrDefault\`\`1(list,index) `method`

##### Summary

Returns the element at the specified index in the list, or a default value if the index would be out of bounds.

##### Returns

The element at the specified index, or a default value if the index is not valid for the `list`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains the element to retrieve. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index of the element to retrieve. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},``0-'></a>
### IndexOf\`\`1(source,element) `method`

##### Summary

Returns the index of the first occurrence of a given value in the source. The list is searched forwards, and the
elements are compared to the given value using the default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1').

##### Returns

The zero-based index of the `element` in `source`; or -1 if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| element | [\`\`0](#T-``0 '``0') | The element to find. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},``0,System-Int32-'></a>
### IndexOf\`\`1(source,element,startIndex) `method`

##### Summary

Returns the index of the first occurrence of a given value in the source. The list is searched forwards, and the
elements are compared to the given value using the default [EqualityComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.EqualityComparer`1 'System.Collections.Generic.EqualityComparer`1').

##### Returns

The zero-based index of the `element` in `source`; or -1 if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| element | [\`\`0](#T-``0 '``0') | The element to find. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elements up to this index are skipped when starting the search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean}-'></a>
### IndexOf\`\`1(source,predicate) `method`

##### Summary

Returns the index of the first occurrence of a value satisfying `predicate` in the source. The list is
searched forwards.

##### Returns

The zero-based index of the first element that satisfies the predicate in `source`; or -1 if none
are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate function used to evaluate elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-IndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean},System-Int32-'></a>
### IndexOf\`\`1(source,predicate,startIndex) `method`

##### Summary

Returns the index of the first occurrence of a value satisfying `predicate` in the source. The list is
searched forwards.

##### Returns

The zero-based index of the first element that satisfies the predicate in `source`; or -1 if none
are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate function used to evaluate elements. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elements up to this index are skipped when starting the search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-IsNullOrEmpty``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### IsNullOrEmpty\`\`1(list) `method`

##### Summary

Indicates whether the input list is null or empty.

##### Returns

`true` if the list is `null` or contains no elements; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to check. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-LastIndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean}-'></a>
### LastIndexOf\`\`1(source,predicate) `method`

##### Summary

Returns the index of the last occurrence of a value satisfying `predicate` in the source. The list is
searched from back to front.

##### Returns

The zero-based index of the last element that satisfies the predicate in `source`; or -1 if none
are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate function used to evaluate elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-LastIndexOf``1-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean},System-Int32-'></a>
### LastIndexOf\`\`1(source,predicate,startIndex) `method`

##### Summary

Returns the index of the last occurrence of a value satisfying `predicate` in the source. The list is
searched from back to front.

##### Returns

The zero-based index of the last element that satisfies the predicate in `source`; or -1 if none
are found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to search in. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | The predicate function used to evaluate elements. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elements beyond this index are skipped when starting the search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-Last``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### Last\`\`1(source) `method`

##### Summary

Returns the last element of a list.

##### Returns

The last element in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to return the last element of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of `source`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') | `source` has no elements. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-NullIfEmpty``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### NullIfEmpty\`\`1(list) `method`

##### Summary

Returns the list, or `null` if it does not contain any elements.

##### Returns

`list`, or `null` if it is `null` or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to return. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAndPass``3-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``2,``1},``2-'></a>
### SelectArrayAndPass\`\`3(source,transformFunc,param) `method`

##### Summary

Projects each element in the list into a new form with an additional parameter passed to the transform function, and
returns the results as an array.

##### Returns

A new array containing the elements from the input list transformed by `transformFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`2,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2,``1}') | A transform function to apply to each source element. The second parameter is the value passed by
`param`. |
| param | [\`\`2](#T-``2 '``2') | The parameter to pass to `transformFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `transformFunc`. |
| TParam | The type of the additional parameter passed to `transformFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAndPass``4-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``2,``3,``1},``2,``3-'></a>
### SelectArrayAndPass\`\`4(source,transformFunc,param,param2) `method`

##### Summary

Projects each element in the list into a new form with two additional parameters passed to the transform function, and
returns the results as an array.

##### Returns

A new array containing the elements from the input list transformed by `transformFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`2,\`\`3,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``2,``3,``1}') | A transform function to apply to each source element. The second and third parameters are the values passed by
`param` and `param2`, respectively. |
| param | [\`\`2](#T-``2 '``2') | The first parameter to pass to `transformFunc`. |
| param2 | [\`\`3](#T-``3 '``3') | The second parameter to pass to `transformFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `transformFunc`. |
| TParam | The type of the first additional parameter passed to `transformFunc`. |
| TParam2 | The type of the second additional parameter passed to `transformFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAsync``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Threading-Tasks-Task{``1}}-'></a>
### SelectArrayAsync\`\`2(source,selectFunc) `method`

##### Summary

Asynchronously projects each element in the list into a new form and returns the results as an array.

##### Returns

A task that returns a new array containing the elements from the input list transformed by `selectFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| selectFunc | [System.Func{\`\`0,System.Threading.Tasks.Task{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Threading.Tasks.Task{``1}}') | An asynchronous transform function to apply to each source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `selectFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArrayAsync``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Int32,System-Threading-Tasks-Task{``1}}-'></a>
### SelectArrayAsync\`\`2(source,selectFunc) `method`

##### Summary

Asynchronously projects each element in the list into a new form and returns the results as an array.

##### Returns

A task that returns a new array containing the elements from the input list transformed by `selectFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| selectFunc | [System.Func{\`\`0,System.Int32,System.Threading.Tasks.Task{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Int32,System.Threading.Tasks.Task{``1}}') | An asynchronous transform function to apply to each source element. The second parameter is the zero-based index of the
element in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `selectFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArrayOrNull``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}-'></a>
### SelectArrayOrNull\`\`2(source,transformFunc) `method`

##### Summary

Projects each element in the list into a new form and returns the results as an array, or `null` if the
list is empty.

##### Returns

A new array containing the elements from the input list transformed by `transformFunc`, or
`null` if the input list contains no elements.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A transform function to apply to each source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `transformFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}-'></a>
### SelectArraySkipLast\`\`2(source,transformFunc) `method`

##### Summary

Eagerly enumerates `source` and applies `transformFunc` but skips the last element.
Returns an array of type `TOut`.

##### Returns

A new array of type `TOut` of length `source`.Count - 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Transformation function applied to elements of `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of the elements of `source`. |
| TOut | Type of the elements of the returned array. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArraySkipLast``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1},System-Int32-'></a>
### SelectArraySkipLast\`\`2(source,transformFunc,count) `method`

##### Summary

Eagerly enumerates `source` and applies `transformFunc` but skips the last
`count` elements. Returns an array of type `TOut`.

##### Returns

A new array of type `TOut` of length `source`.Count - `count`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| transformFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Transformation function applied to elements of `source`. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Amount of elements to skip at end. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Type of the elements of `source`. |
| TOut | Type of the elements of the returned array. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,``1}-'></a>
### SelectArray\`\`2(source,selectFunc) `method`

##### Summary

Projects each element in the list into a new form and returns the results as an array.

##### Returns

A new array containing the elements from the input list transformed by `selectFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| selectFunc | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | A transform function to apply to each source element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `selectFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Int32,``1}-'></a>
### SelectArray\`\`2(source,selectFunc) `method`

##### Summary

Projects each element in the list into a new form and returns the results as an array.

##### Returns

A new array containing the elements from the input list transformed by `selectFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing the elements to transform. |
| selectFunc | [System.Func{\`\`0,System.Int32,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Int32,``1}') | A transform function to apply to each source element. The second parameter is the zero-based index of the element in
`source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of elements in `source`. |
| TOut | The type of element returned by `selectFunc`. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SelectArray``2-System-Collections-Generic-IReadOnlyList{``0},System-Func{``0,System-Boolean,System-Boolean,``1}-'></a>
### SelectArray\`\`2(source,selectFunc) `method`

##### Summary

Transforms all elements of `source` using the selectFunction, returns a new array of equal length.
Transformation function `selectFunc` has three arguments: the element, a boolean that indicates if the
element is the first of the sequence, and a boolean that indicates if the element is the last of the sequence.

##### Returns

A new array containing the elements from the input list transformed by `selectFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | A IReadOnlyList with elements of type `TSource` |
| selectFunc | [System.Func{\`\`0,System.Boolean,System.Boolean,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean,System.Boolean,``1}') | Function used to transform the elements of `source`. Should have three arguments: an element of type
`TSource`, a boolean that indicates if the element is the first of the sequence, and a boolean that
indicates if the element is the last of the sequence. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | Input element type. |
| TOut | Output element type. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-SkipLast``1-System-Collections-Generic-IReadOnlyList{``0},System-Int32-'></a>
### SkipLast\`\`1(list,numOfElementsToSkip) `method`

##### Summary

Enumerates the elements in the list except for the specified number of elements at the end of the list.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') that contains the elements from the input list but does not include the last
`numOfElementsToSkip` elements.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') to enumerate. |
| numOfElementsToSkip | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements at the end of the list to not enumerate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ToArray``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### ToArray\`\`1(source) `method`

##### Summary

Returns a new array (T[]) containing all elements of the source.

##### Returns

A new T[] instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | Source list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ToBucketDictionary``2-System-Collections-Generic-IReadOnlyList{``1},System-Collections-Generic-IReadOnlyList{``0},System-Func{``1,``0}-'></a>
### ToBucketDictionary\`\`2(source,keysToCollate,keyFunc) `method`

##### Summary

Creates a dictionary from an [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') by putting values into lists according to a list of keys and
a key selector function.

##### Returns

A [Dictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary`2 'System.Collections.Generic.Dictionary`2') that contains values from the input list sorted into keys from
`keysToCollate` according to `keyFunc`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``1}') | The list that contains the values to put into the dictionary. |
| keysToCollate | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | An [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that contains the keys to create a dictionary from. |
| keyFunc | [System.Func{\`\`1,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1,``0}') | A function that selects the dictionary key to sort values from the list into. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of keys in the dictionary to create. |
| TValue | The type of elements in the list. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-System-Collections-Generic-List{``0}-'></a>
### ToReadOnlyList\`\`1(source) `method`

##### Summary

Returns a new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing all elements of the source.

##### Returns

A new instance implementing [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') | Source list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-``0[]-'></a>
### ToReadOnlyList\`\`1(source) `method`

##### Summary

Returns a new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing all elements of the source.

##### Returns

A new instance implementing [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0[]](#T-``0[] '``0[]') | Source array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements. |

<a name='M-Semantica-Linq-ReadOnlyListLinq-ToReadOnlyList``1-System-Collections-Generic-IReadOnlyList{``0}-'></a>
### ToReadOnlyList\`\`1(source) `method`

##### Summary

Returns a new [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') containing all elements of the source.

##### Returns

A new instance implementing [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | Source list. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements. |
