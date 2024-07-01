<a name='assembly'></a>
# Lib.Trees

## Contents

- [GrowingTree\`1](#T-Semantica-Trees-Implementations-GrowingTree`1 'Semantica.Trees.Implementations.GrowingTree`1')
  - [CopyToNew\`\`1()](#M-Semantica-Trees-Implementations-GrowingTree`1-CopyToNew``1-System-Func{Semantica-Trees-ITreeNode{`0},``0}- 'Semantica.Trees.Implementations.GrowingTree`1.CopyToNew``1(System.Func{Semantica.Trees.ITreeNode{`0},``0})')
  - [IsEmpty()](#M-Semantica-Trees-Implementations-GrowingTree`1-IsEmpty 'Semantica.Trees.Implementations.GrowingTree`1.IsEmpty')
- [IArrayTreeNode\`1](#T-Semantica-Trees-IArrayTreeNode`1 'Semantica.Trees.IArrayTreeNode`1')
  - [ChildIndices](#P-Semantica-Trees-IArrayTreeNode`1-ChildIndices 'Semantica.Trees.IArrayTreeNode`1.ChildIndices')
  - [Index](#P-Semantica-Trees-IArrayTreeNode`1-Index 'Semantica.Trees.IArrayTreeNode`1.Index')
  - [OffspringCount](#P-Semantica-Trees-IArrayTreeNode`1-OffspringCount 'Semantica.Trees.IArrayTreeNode`1.OffspringCount')
  - [ParentIndex](#P-Semantica-Trees-IArrayTreeNode`1-ParentIndex 'Semantica.Trees.IArrayTreeNode`1.ParentIndex')
- [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1')
  - [ChildNodes](#P-Semantica-Trees-IAscendantTreeNode`1-ChildNodes 'Semantica.Trees.IAscendantTreeNode`1.ChildNodes')
  - [GetOffspringCount()](#M-Semantica-Trees-IAscendantTreeNode`1-GetOffspringCount 'Semantica.Trees.IAscendantTreeNode`1.GetOffspringCount')
- [IDescendantTreeNode\`1](#T-Semantica-Trees-IDescendantTreeNode`1 'Semantica.Trees.IDescendantTreeNode`1')
  - [ParentNode](#P-Semantica-Trees-IDescendantTreeNode`1-ParentNode 'Semantica.Trees.IDescendantTreeNode`1.ParentNode')
  - [GetAncestorCount()](#M-Semantica-Trees-IDescendantTreeNode`1-GetAncestorCount 'Semantica.Trees.IDescendantTreeNode`1.GetAncestorCount')
  - [IsRoot()](#M-Semantica-Trees-IDescendantTreeNode`1-IsRoot 'Semantica.Trees.IDescendantTreeNode`1.IsRoot')
- [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1')
  - [AddChildNode(parentNode,payload)](#M-Semantica-Trees-IGrowingTree`1-AddChildNode-Semantica-Trees-ITreeNode{`0},`0- 'Semantica.Trees.IGrowingTree`1.AddChildNode(Semantica.Trees.ITreeNode{`0},`0)')
- [IMorphologicTreeNode\`1](#T-Semantica-Trees-IMorphologicTreeNode`1 'Semantica.Trees.IMorphologicTreeNode`1')
- [IMorphologicTree\`1](#T-Semantica-Trees-IMorphologicTree`1 'Semantica.Trees.IMorphologicTree`1')
  - [RootNode](#P-Semantica-Trees-IMorphologicTree`1-RootNode 'Semantica.Trees.IMorphologicTree`1.RootNode')
- [IPartialTreeConverter\`2](#T-Semantica-Trees-Converters-IPartialTreeConverter`2 'Semantica.Trees.Converters.IPartialTreeConverter`2')
  - [Convert(source)](#M-Semantica-Trees-Converters-IPartialTreeConverter`2-Convert-Semantica-Trees-IReadOnlyPartialTree{`0}- 'Semantica.Trees.Converters.IPartialTreeConverter`2.Convert(Semantica.Trees.IReadOnlyPartialTree{`0})')
- [IPartialTreeNode\`1](#T-Semantica-Trees-IPartialTreeNode`1 'Semantica.Trees.IPartialTreeNode`1')
  - [Owner](#P-Semantica-Trees-IPartialTreeNode`1-Owner 'Semantica.Trees.IPartialTreeNode`1.Owner')
- [IPayloadConverter\`2](#T-Semantica-Trees-Converters-IPayloadConverter`2 'Semantica.Trees.Converters.IPayloadConverter`2')
  - [ConvertPayload(node)](#M-Semantica-Trees-Converters-IPayloadConverter`2-ConvertPayload-`0- 'Semantica.Trees.Converters.IPayloadConverter`2.ConvertPayload(`0)')
- [IReadOnlyMorphologicTree\`2](#T-Semantica-Trees-IReadOnlyMorphologicTree`2 'Semantica.Trees.IReadOnlyMorphologicTree`2')
- [IReadOnlyPartialTree\`1](#T-Semantica-Trees-IReadOnlyPartialTree`1 'Semantica.Trees.IReadOnlyPartialTree`1')
- [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1')
  - [Depth](#P-Semantica-Trees-IReadOnlyTreePath`1-Depth 'Semantica.Trees.IReadOnlyTreePath`1.Depth')
  - [Nodes](#P-Semantica-Trees-IReadOnlyTreePath`1-Nodes 'Semantica.Trees.IReadOnlyTreePath`1.Nodes')
  - [RootNode](#P-Semantica-Trees-IReadOnlyTreePath`1-RootNode 'Semantica.Trees.IReadOnlyTreePath`1.RootNode')
  - [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode')
- [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1')
- [ITreeBuildPredicateProvider\`1](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1')
  - [IsChildOf(payload,parent)](#M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-IsChildOf-`0,`0- 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1.IsChildOf(`0,`0)')
  - [IsRoot(payload)](#M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-IsRoot-`0- 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1.IsRoot(`0)')
  - [OrderChildrenBy(payload)](#M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-OrderChildrenBy-`0- 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1.OrderChildrenBy(`0)')
  - [UseOrdering()](#M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-UseOrdering 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1.UseOrdering')
- [ITreeBuilder\`1](#T-Semantica-Trees-Builders-ITreeBuilder`1 'Semantica.Trees.Builders.ITreeBuilder`1')
  - [GrowTree(collection)](#M-Semantica-Trees-Builders-ITreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0}- 'Semantica.Trees.Builders.ITreeBuilder`1.GrowTree(Semantica.Collections.IRetrievalCollection{`0})')
- [ITreeConverter\`2](#T-Semantica-Trees-Converters-ITreeConverter`2 'Semantica.Trees.Converters.ITreeConverter`2')
  - [Convert(source)](#M-Semantica-Trees-Converters-ITreeConverter`2-Convert-Semantica-Trees-IReadOnlyTree{`0}- 'Semantica.Trees.Converters.ITreeConverter`2.Convert(Semantica.Trees.IReadOnlyTree{`0})')
- [ITreeNodeProperties\`1](#T-Semantica-Trees-ITreeNodeProperties`1 'Semantica.Trees.ITreeNodeProperties`1')
  - [Level](#P-Semantica-Trees-ITreeNodeProperties`1-Level 'Semantica.Trees.ITreeNodeProperties`1.Level')
  - [Payload](#P-Semantica-Trees-ITreeNodeProperties`1-Payload 'Semantica.Trees.ITreeNodeProperties`1.Payload')
  - [IsLeaf()](#M-Semantica-Trees-ITreeNodeProperties`1-IsLeaf 'Semantica.Trees.ITreeNodeProperties`1.IsLeaf')
- [ITreeNode\`1](#T-Semantica-Trees-ITreeNode`1 'Semantica.Trees.ITreeNode`1')
  - [Owner](#P-Semantica-Trees-ITreeNode`1-Owner 'Semantica.Trees.ITreeNode`1.Owner')
- [ITreePathNode\`1](#T-Semantica-Trees-ITreePathNode`1 'Semantica.Trees.ITreePathNode`1')
  - [NextNode](#P-Semantica-Trees-ITreePathNode`1-NextNode 'Semantica.Trees.ITreePathNode`1.NextNode')
  - [Owner](#P-Semantica-Trees-ITreePathNode`1-Owner 'Semantica.Trees.ITreePathNode`1.Owner')
- [Module](#T-Semantica-Trees-Module 'Semantica.Trees.Module')
- [MorphologicTreeJsonConverter\`2](#T-Semantica-Trees-JsonConverters-MorphologicTreeJsonConverter`2 'Semantica.Trees.JsonConverters.MorphologicTreeJsonConverter`2')
- [PartialTreeBuilder](#T-Semantica-Trees-Builders-PartialTreeBuilder 'Semantica.Trees.Builders.PartialTreeBuilder')
  - [MakeSubTree\`\`3(root,upperboundCapacity,payloadConverter)](#M-Semantica-Trees-Builders-PartialTreeBuilder-MakeSubTree``3-``2,System-Int32,System-Func{``2,``1}- 'Semantica.Trees.Builders.PartialTreeBuilder.MakeSubTree``3(``2,System.Int32,System.Func{``2,``1})')
- [PartialTreeJsonConverter\`1](#T-Semantica-Trees-JsonConverters-PartialTreeJsonConverter`1 'Semantica.Trees.JsonConverters.PartialTreeJsonConverter`1')
- [PartialTreeNode\`1](#T-Semantica-Trees-Implementations-PartialTreeNode`1 'Semantica.Trees.Implementations.PartialTreeNode`1')
- [PartialTree\`1](#T-Semantica-Trees-Implementations-PartialTree`1 'Semantica.Trees.Implementations.PartialTree`1')
  - [CopyToNew\`\`1()](#M-Semantica-Trees-Implementations-PartialTree`1-CopyToNew``1-System-Func{Semantica-Trees-IPartialTreeNode{`0},``0}- 'Semantica.Trees.Implementations.PartialTree`1.CopyToNew``1(System.Func{Semantica.Trees.IPartialTreeNode{`0},``0})')
  - [IsEmpty()](#M-Semantica-Trees-Implementations-PartialTree`1-IsEmpty 'Semantica.Trees.Implementations.PartialTree`1.IsEmpty')
- [TreeBuilder\`1](#T-Semantica-Trees-Builders-TreeBuilder`1 'Semantica.Trees.Builders.TreeBuilder`1')
  - [#ctor(provider)](#M-Semantica-Trees-Builders-TreeBuilder`1-#ctor-Semantica-Trees-Builders-ITreeBuildPredicateProvider{`0}- 'Semantica.Trees.Builders.TreeBuilder`1.#ctor(Semantica.Trees.Builders.ITreeBuildPredicateProvider{`0})')
  - [GrowTree()](#M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0}- 'Semantica.Trees.Builders.TreeBuilder`1.GrowTree(Semantica.Collections.IRetrievalCollection{`0})')
  - [GrowTree(collection,isRootPredicate,isChildOfFunc)](#M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0},System-Func{`0,System-Boolean},System-Func{`0,`0,System-Boolean}- 'Semantica.Trees.Builders.TreeBuilder`1.GrowTree(Semantica.Collections.IRetrievalCollection{`0},System.Func{`0,System.Boolean},System.Func{`0,`0,System.Boolean})')
  - [GrowTree(collection,isRootPredicate,isChildOfFunc,orderFunc)](#M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0},System-Func{`0,System-Boolean},System-Func{`0,`0,System-Boolean},System-Func{`0,System-IComparable}- 'Semantica.Trees.Builders.TreeBuilder`1.GrowTree(Semantica.Collections.IRetrievalCollection{`0},System.Func{`0,System.Boolean},System.Func{`0,`0,System.Boolean},System.Func{`0,System.IComparable})')
- [TreeConverter](#T-Semantica-Trees-Converters-TreeConverter 'Semantica.Trees.Converters.TreeConverter')
  - [ConvertTree\`\`2(source,convertFunc)](#M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyTree{``0},System-Func{Semantica-Trees-ITreeNode{``0},``1}- 'Semantica.Trees.Converters.TreeConverter.ConvertTree``2(Semantica.Trees.IReadOnlyTree{``0},System.Func{Semantica.Trees.ITreeNode{``0},``1})')
  - [ConvertTree\`\`2(source,convertFunc,predicate)](#M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyTree{``0},System-Func{Semantica-Trees-ITreeNode{``0},``1},System-Func{Semantica-Trees-ITreeNode{``0},System-Boolean}- 'Semantica.Trees.Converters.TreeConverter.ConvertTree``2(Semantica.Trees.IReadOnlyTree{``0},System.Func{Semantica.Trees.ITreeNode{``0},``1},System.Func{Semantica.Trees.ITreeNode{``0},System.Boolean})')
  - [ConvertTree\`\`2(source,convertFunc)](#M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyPartialTree{``0},System-Func{Semantica-Trees-IPartialTreeNode{``0},``1}- 'Semantica.Trees.Converters.TreeConverter.ConvertTree``2(Semantica.Trees.IReadOnlyPartialTree{``0},System.Func{Semantica.Trees.IPartialTreeNode{``0},``1})')
- [TreeExtensions](#T-Semantica-Trees-Extensions-TreeExtensions 'Semantica.Trees.Extensions.TreeExtensions')
  - [DepthFirstOrDefault\`\`2(tree,predicate)](#M-Semantica-Trees-Extensions-TreeExtensions-DepthFirstOrDefault``2-Semantica-Trees-IMorphologicTree{``1},System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreeExtensions.DepthFirstOrDefault``2(Semantica.Trees.IMorphologicTree{``1},System.Func{``0,System.Boolean})')
  - [EnumerateDepthFirst\`\`1(tree)](#M-Semantica-Trees-Extensions-TreeExtensions-EnumerateDepthFirst``1-Semantica-Trees-IMorphologicTree{``0}- 'Semantica.Trees.Extensions.TreeExtensions.EnumerateDepthFirst``1(Semantica.Trees.IMorphologicTree{``0})')
  - [TryDepthFirst\`\`1(tree,predicate,matchingNode)](#M-Semantica-Trees-Extensions-TreeExtensions-TryDepthFirst``1-Semantica-Trees-IMorphologicTree{``0},System-Func{``0,System-Boolean},``0@- 'Semantica.Trees.Extensions.TreeExtensions.TryDepthFirst``1(Semantica.Trees.IMorphologicTree{``0},System.Func{``0,System.Boolean},``0@)')
  - [TryDepthFirst\`\`2(tree,predicate,matchingNode)](#M-Semantica-Trees-Extensions-TreeExtensions-TryDepthFirst``2-Semantica-Trees-IMorphologicTree{``1},System-Func{``0,System-Boolean},``1@- 'Semantica.Trees.Extensions.TreeExtensions.TryDepthFirst``2(Semantica.Trees.IMorphologicTree{``1},System.Func{``0,System.Boolean},``1@)')
- [TreeJsonConverterFactory](#T-Semantica-Trees-JsonConverters-TreeJsonConverterFactory 'Semantica.Trees.JsonConverters.TreeJsonConverterFactory')
- [TreeJsonConverter\`1](#T-Semantica-Trees-JsonConverters-TreeJsonConverter`1 'Semantica.Trees.JsonConverters.TreeJsonConverter`1')
- [TreeNodeExtensions](#T-Semantica-Trees-Extensions-TreeNodeExtensions 'Semantica.Trees.Extensions.TreeNodeExtensions')
  - [EnumerateAncestors\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateAncestors``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.EnumerateAncestors``1(``0)')
  - [EnumerateOffspringUntil\`\`1(node,predicate)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspringUntil``1-``0,System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreeNodeExtensions.EnumerateOffspringUntil``1(``0,System.Func{``0,System.Boolean})')
  - [EnumerateOffspringWhere\`\`1(node,predicate)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspringWhere``1-``0,System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreeNodeExtensions.EnumerateOffspringWhere``1(``0,System.Func{``0,System.Boolean})')
  - [EnumerateOffspring\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspring``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.EnumerateOffspring``1(``0)')
  - [EnumerateOffspring\`\`1(node,predicate)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspring``1-``0,System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreeNodeExtensions.EnumerateOffspring``1(``0,System.Func{``0,System.Boolean})')
  - [IndexOf\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-IndexOf``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.IndexOf``1(``0)')
  - [IsLeaf\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-IsLeaf``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.IsLeaf``1(``0)')
  - [IsRoot\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-IsRoot``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.IsRoot``1(``0)')
  - [MakeTreePath\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-MakeTreePath``1-Semantica-Trees-ITreeNode{``0}- 'Semantica.Trees.Extensions.TreeNodeExtensions.MakeTreePath``1(Semantica.Trees.ITreeNode{``0})')
  - [Payloads\`\`1(nodes)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-Payloads``1-System-Collections-Generic-IEnumerable{Semantica-Trees-ITreeNodeProperties{``0}}- 'Semantica.Trees.Extensions.TreeNodeExtensions.Payloads``1(System.Collections.Generic.IEnumerable{Semantica.Trees.ITreeNodeProperties{``0}})')
  - [SiblingCount\`\`1(node)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-SiblingCount``1-``0- 'Semantica.Trees.Extensions.TreeNodeExtensions.SiblingCount``1(``0)')
  - [Where\`\`2(nodes,predicate)](#M-Semantica-Trees-Extensions-TreeNodeExtensions-Where``2-System-Collections-Generic-IEnumerable{``1},System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreeNodeExtensions.Where``2(System.Collections.Generic.IEnumerable{``1},System.Func{``0,System.Boolean})')
- [TreeNode\`1](#T-Semantica-Trees-Implementations-TreeNode`1 'Semantica.Trees.Implementations.TreeNode`1')
  - [ChildIndices](#P-Semantica-Trees-Implementations-TreeNode`1-ChildIndices 'Semantica.Trees.Implementations.TreeNode`1.ChildIndices')
  - [Index](#P-Semantica-Trees-Implementations-TreeNode`1-Index 'Semantica.Trees.Implementations.TreeNode`1.Index')
  - [ParentIndex](#P-Semantica-Trees-Implementations-TreeNode`1-ParentIndex 'Semantica.Trees.Implementations.TreeNode`1.ParentIndex')
  - [DuplicateFor\`\`1()](#M-Semantica-Trees-Implementations-TreeNode`1-DuplicateFor``1-Semantica-Trees-Implementations-GrowingTree{``0},``0- 'Semantica.Trees.Implementations.TreeNode`1.DuplicateFor``1(Semantica.Trees.Implementations.GrowingTree{``0},``0)')
  - [Unleaf(expectedChildren)](#M-Semantica-Trees-Implementations-TreeNode`1-Unleaf-System-Int32- 'Semantica.Trees.Implementations.TreeNode`1.Unleaf(System.Int32)')
- [TreePathExtensions](#T-Semantica-Trees-Extensions-TreePathExtensions 'Semantica.Trees.Extensions.TreePathExtensions')
  - [EnumerateNodesFromUltimate\`\`1(treePath)](#M-Semantica-Trees-Extensions-TreePathExtensions-EnumerateNodesFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0}- 'Semantica.Trees.Extensions.TreePathExtensions.EnumerateNodesFromUltimate``1(Semantica.Trees.IReadOnlyTreePath{``0})')
  - [FirstNotDefaultValueFromUltimate\`\`2(treePath,selector)](#M-Semantica-Trees-Extensions-TreePathExtensions-FirstNotDefaultValueFromUltimate``2-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,``1}- 'Semantica.Trees.Extensions.TreePathExtensions.FirstNotDefaultValueFromUltimate``2(Semantica.Trees.IReadOnlyTreePath{``0},System.Func{``0,``1})')
  - [FirstNotDefaultValue\`\`2(treePath,selector)](#M-Semantica-Trees-Extensions-TreePathExtensions-FirstNotDefaultValue``2-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,``1}- 'Semantica.Trees.Extensions.TreePathExtensions.FirstNotDefaultValue``2(Semantica.Trees.IReadOnlyTreePath{``0},System.Func{``0,``1})')
  - [FirstOrDefaultFromUltimate\`\`1(treePath,predicate)](#M-Semantica-Trees-Extensions-TreePathExtensions-FirstOrDefaultFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,System-Boolean}- 'Semantica.Trees.Extensions.TreePathExtensions.FirstOrDefaultFromUltimate``1(Semantica.Trees.IReadOnlyTreePath{``0},System.Func{``0,System.Boolean})')
  - [FirstOrDefaultFromUltimate\`\`1(treePath,predicate)](#M-Semantica-Trees-Extensions-TreePathExtensions-FirstOrDefaultFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{Semantica-Trees-ITreePathNode{``0},System-Boolean}- 'Semantica.Trees.Extensions.TreePathExtensions.FirstOrDefaultFromUltimate``1(Semantica.Trees.IReadOnlyTreePath{``0},System.Func{Semantica.Trees.ITreePathNode{``0},System.Boolean})')
- [TreePathNode\`1](#T-Semantica-Trees-Implementations-TreePathNode`1 'Semantica.Trees.Implementations.TreePathNode`1')
- [TreePath\`1](#T-Semantica-Trees-Implementations-TreePath`1 'Semantica.Trees.Implementations.TreePath`1')

<a name='T-Semantica-Trees-Implementations-GrowingTree`1'></a>
## GrowingTree\`1 `type`

##### Namespace

Semantica.Trees.Implementations

<a name='M-Semantica-Trees-Implementations-GrowingTree`1-CopyToNew``1-System-Func{Semantica-Trees-ITreeNode{`0},``0}-'></a>
### CopyToNew\`\`1() `method`

##### Summary

Creates a new tree with the same shape as the current instance, but with all node payloads converted to `TOut` using the provided `convertFunc`.
This method is used by [TreeConverter](#T-Semantica-Trees-Converters-TreeConverter 'Semantica.Trees.Converters.TreeConverter').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Trees-Implementations-GrowingTree`1-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

A tree is concidered empty when the root node has no children.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-IArrayTreeNode`1'></a>
## IArrayTreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a node in a type of tree where all nodes of that tree are part of the same indexable list or array, and thus each node can be uniquely identified by it's index within that list or array.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of payloads of the tree nodes |

<a name='P-Semantica-Trees-IArrayTreeNode`1-ChildIndices'></a>
### ChildIndices `property`

##### Summary

The indices of the children of the node within the node list.

<a name='P-Semantica-Trees-IArrayTreeNode`1-Index'></a>
### Index `property`

##### Summary

The index of this node within the node list.

<a name='P-Semantica-Trees-IArrayTreeNode`1-OffspringCount'></a>
### OffspringCount `property`

##### Summary

The total amount of offspring of this node.

<a name='P-Semantica-Trees-IArrayTreeNode`1-ParentIndex'></a>
### ParentIndex `property`

##### Summary

The index of the parent node within the node list.

<a name='T-Semantica-Trees-IAscendantTreeNode`1'></a>
## IAscendantTreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Interface can be implemented by any type of tree node that can have offspring.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TTreeNode | The type of tree nodes. This type has to also implement [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1') |

<a name='P-Semantica-Trees-IAscendantTreeNode`1-ChildNodes'></a>
### ChildNodes `property`

##### Summary

The list of all child nodes of this tree node. If the tree node is a leaf, this returns an empty list that can be enumerated, but has no elements.

<a name='M-Semantica-Trees-IAscendantTreeNode`1-GetOffspringCount'></a>
### GetOffspringCount() `method`

##### Summary

Gets the total amount of offspring nodes of this node (children, children of children, etc.)

##### Returns

The count of all offspring nodes of this node.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-IDescendantTreeNode`1'></a>
## IDescendantTreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Interface can be implemented by any type of tree node that either has a parent, or is a root node.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TTreeNode | The type of tree nodes. This type has to also implement [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1'). |

<a name='P-Semantica-Trees-IDescendantTreeNode`1-ParentNode'></a>
### ParentNode `property`

##### Summary

Parent node of this node. Returns null if this is the root node ([IsRoot](#M-Semantica-Trees-IDescendantTreeNode`1-IsRoot 'Semantica.Trees.IDescendantTreeNode`1.IsRoot') returns `true`).

<a name='M-Semantica-Trees-IDescendantTreeNode`1-GetAncestorCount'></a>
### GetAncestorCount() `method`

##### Summary

Gets the total amount of ancestor nodes of this node in the current structure. If the structure is a full tree, this is the same as the [Level](#P-Semantica-Trees-ITreeNodeProperties`1-Level 'Semantica.Trees.ITreeNodeProperties`1.Level') of the node.

##### Returns

The count of the amount of times the [ParentNode](#P-Semantica-Trees-IDescendantTreeNode`1-ParentNode 'Semantica.Trees.IDescendantTreeNode`1.ParentNode') reference can be followed until it's value is `null`.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Trees-IDescendantTreeNode`1-IsRoot'></a>
### IsRoot() `method`

##### Summary

`true` if this node is the root node of the tree, or local root of the partial tree. The root node will always have a [ParentNode](#P-Semantica-Trees-IDescendantTreeNode`1-ParentNode 'Semantica.Trees.IDescendantTreeNode`1.ParentNode') value of `null`,
[GetAncestorCount](#M-Semantica-Trees-IDescendantTreeNode`1-GetAncestorCount 'Semantica.Trees.IDescendantTreeNode`1.GetAncestorCount') of 0, and will be the only root node in the current structure.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-IGrowingTree`1'></a>
## IGrowingTree\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree data structure that has nodes with payloads, that can be grown by adding child nodes to the root node, or other earlier added nodes.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the payloads of the nodes. |

<a name='M-Semantica-Trees-IGrowingTree`1-AddChildNode-Semantica-Trees-ITreeNode{`0},`0-'></a>
### AddChildNode(parentNode,payload) `method`

##### Summary

Creates a new node and adds it to the tree, as a child of the provided `parentNode`.

##### Returns

Returns the created [ITreeNode\`1](#T-Semantica-Trees-ITreeNode`1 'Semantica.Trees.ITreeNode`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentNode | [Semantica.Trees.ITreeNode{\`0}](#T-Semantica-Trees-ITreeNode{`0} 'Semantica.Trees.ITreeNode{`0}') | Node to which to add the new node. Has to be part of, and created by this tree. |
| payload | [\`0](#T-`0 '`0') | Payload of the new node. |

<a name='T-Semantica-Trees-IMorphologicTreeNode`1'></a>
## IMorphologicTreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a node of any tree or partial tree, that has both a parent node, and, if the node is not a leaf, child nodes.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of node. |

<a name='T-Semantica-Trees-IMorphologicTree`1'></a>
## IMorphologicTree\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree data structure with nodes of type `TNode`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of nodes of the tree. |

##### Remarks

Implements ICanBeEmpty: the tree is considered empty if the root node has no children. The tree ALWAYS has a root node.
Can be enumerated to retrieve all nodes of the tree.

<a name='P-Semantica-Trees-IMorphologicTree`1-RootNode'></a>
### RootNode `property`

##### Summary

The root node of the tree.

<a name='T-Semantica-Trees-Converters-IPartialTreeConverter`2'></a>
## IPartialTreeConverter\`2 `type`

##### Namespace

Semantica.Trees.Converters

##### Summary

Can convert a partial tree of type `TIn` to a partial tree of type `TOut`.
The resulting tree wil have the same structure as the source tree. 
The payloads are converted by [IPayloadConverter\`2](#T-Semantica-Trees-Converters-IPayloadConverter`2 'Semantica.Trees.Converters.IPayloadConverter`2'), on which the implementation is dependent.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | Type of payloads of the tree to convert. |
| TOut | Type of payloads of the output tree. |

<a name='M-Semantica-Trees-Converters-IPartialTreeConverter`2-Convert-Semantica-Trees-IReadOnlyPartialTree{`0}-'></a>
### Convert(source) `method`

##### Summary

Converts a tree with payloads of type `TIn` to a new tree with payloads of type `TOut`, by converting the payloads using the injected [IPayloadConverter\`2](#T-Semantica-Trees-Converters-IPayloadConverter`2 'Semantica.Trees.Converters.IPayloadConverter`2').

##### Returns

A new tree with converted payloads that is structurally equivalent to the source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Semantica.Trees.IReadOnlyPartialTree{\`0}](#T-Semantica-Trees-IReadOnlyPartialTree{`0} 'Semantica.Trees.IReadOnlyPartialTree{`0}') | Tree to convert. |

<a name='T-Semantica-Trees-IPartialTreeNode`1'></a>
## IPartialTreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree node of a partial tree.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload that is present in each node. |

<a name='P-Semantica-Trees-IPartialTreeNode`1-Owner'></a>
### Owner `property`

##### Summary

Gets the partial tree that this node is part of. Nodes only have meaning in context of their accompanying tree, and cannot exist without it.

<a name='T-Semantica-Trees-Converters-IPayloadConverter`2'></a>
## IPayloadConverter\`2 `type`

##### Namespace

Semantica.Trees.Converters

##### Summary

Can convert a treenode of the type `TNode` to a payload of type `TOut`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of node. |
| TOut | Type of the output. |

##### Remarks

Implement this interface with `TNode` as [ITreeNode\`1](#T-Semantica-Trees-ITreeNode`1 'Semantica.Trees.ITreeNode`1') for DI support for [ITreeConverter\`2](#T-Semantica-Trees-Converters-ITreeConverter`2 'Semantica.Trees.Converters.ITreeConverter`2').
Implement this interface with `TNode` as [IPartialTreeNode\`1](#T-Semantica-Trees-IPartialTreeNode`1 'Semantica.Trees.IPartialTreeNode`1')for DI support for [IPartialTreeConverter\`2](#T-Semantica-Trees-Converters-IPartialTreeConverter`2 'Semantica.Trees.Converters.IPartialTreeConverter`2').

<a name='M-Semantica-Trees-Converters-IPayloadConverter`2-ConvertPayload-`0-'></a>
### ConvertPayload(node) `method`

##### Summary

Converts a treenode of type `TNode` to a payload of type `TOut`.

##### Returns

The converted payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`0](#T-`0 '`0') | Node to convert. |

<a name='T-Semantica-Trees-IReadOnlyMorphologicTree`2'></a>
## IReadOnlyMorphologicTree\`2 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree data structure where each node has a payload.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of the nodes. |
| TPayload | Type of payload of the nodes. |

<a name='T-Semantica-Trees-IReadOnlyPartialTree`1'></a>
## IReadOnlyPartialTree\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree data structure where each node can have a payload of type `T`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload of the nodes. |

##### Remarks

Implements ICanBeEmpty: the tree is considered empty if the root node has no children. The tree ALWAYS has a root node.
Also implements IReadOnlyList, and contains all nodes in the order they were added.

<a name='T-Semantica-Trees-IReadOnlyTreePath`1'></a>
## IReadOnlyTreePath\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a path in a tree from a node to the root node where each node can have a payload of type `T`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payloads of the nodes. |

##### Remarks

Implements [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'), this lists all node payloads in the path from the root node to the ultimate node.

<a name='P-Semantica-Trees-IReadOnlyTreePath`1-Depth'></a>
### Depth `property`

##### Summary

The amount of parent-child relations in the path, equal to [Nodes](#P-Semantica-Trees-IReadOnlyTreePath`1-Nodes 'Semantica.Trees.IReadOnlyTreePath`1.Nodes').[Count](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection`1.Count 'System.Collections.Generic.IReadOnlyCollection`1.Count') - 1.

<a name='P-Semantica-Trees-IReadOnlyTreePath`1-Nodes'></a>
### Nodes `property`

##### Summary

The list of all nodes in the path, from the root node till the ultimate node.

<a name='P-Semantica-Trees-IReadOnlyTreePath`1-RootNode'></a>
### RootNode `property`

##### Summary

Returns the root node of the [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1'). Which is also the first of the [Nodes](#P-Semantica-Trees-IReadOnlyTreePath`1-Nodes 'Semantica.Trees.IReadOnlyTreePath`1.Nodes'), and the node with the lowest level.

<a name='P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode'></a>
### UltimateNode `property`

##### Summary

Returns the final node of the [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1'). Which is also the last of the [Nodes](#P-Semantica-Trees-IReadOnlyTreePath`1-Nodes 'Semantica.Trees.IReadOnlyTreePath`1.Nodes'), and the node with the highest level.

<a name='T-Semantica-Trees-IReadOnlyTree`1'></a>
## IReadOnlyTree\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a tree data structure consisting of nodes of type [ITreeNode\`1](#T-Semantica-Trees-ITreeNode`1 'Semantica.Trees.ITreeNode`1') where each node can have a payload of type `T`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload of the nodes. |

##### Remarks

Implements [ICanBeEmpty](#T-Semantica-Patterns-ICanBeEmpty 'Semantica.Patterns.ICanBeEmpty'): the tree is considered empty if the root node has no children. The tree *always* has a root node.
Also implements [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'), and contains all nodes in the order they were added.

<a name='T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1'></a>
## ITreeBuildPredicateProvider\`1 `type`

##### Namespace

Semantica.Trees.Builders

##### Summary

Can identify a payload as the root node for a tree, or as a child of another payload.
Implement this interface for DI support for [ITreeBuilder\`1](#T-Semantica-Trees-Builders-ITreeBuilder`1 'Semantica.Trees.Builders.ITreeBuilder`1')

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload. |

<a name='M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-IsChildOf-`0,`0-'></a>
### IsChildOf(payload,parent) `method`

##### Summary

Determines if `payload` should be a child node of `parent`

##### Returns

True if payload is child of parent

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0](#T-`0 '`0') | Payload to test |
| parent | [\`0](#T-`0 '`0') | Payload of parent |

<a name='M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-IsRoot-`0-'></a>
### IsRoot(payload) `method`

##### Summary

Determines if a payload should be the root of a tree.

##### Returns

True if the payload is the root of the tree.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0](#T-`0 '`0') | Payload to test |

<a name='M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-OrderChildrenBy-`0-'></a>
### OrderChildrenBy(payload) `method`

##### Summary

Determines the value of the child, to be used for ordering the child and its siblings.

##### Returns

An IComparable value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`0](#T-`0 '`0') | Payload to order |

<a name='M-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1-UseOrdering'></a>
### UseOrdering() `method`

##### Summary

Determines if children should be ordered before they are added to the parent.
If this method returns false, OrderChildenBy is not utilized.

##### Returns

True if the implement

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-Builders-ITreeBuilder`1'></a>
## ITreeBuilder\`1 `type`

##### Namespace

Semantica.Trees.Builders

##### Summary

Used to build a [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') from a collection of payloads.
Implementation requires an instance of [ITreeBuildPredicateProvider\`1](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1') to identify payloads as root or children.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload for the tree. |

<a name='M-Semantica-Trees-Builders-ITreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0}-'></a>
### GrowTree(collection) `method`

##### Summary

Builds the tree. Will retrieve nodes from the collection, starting with the root node, and adding children recursively.

##### Returns

A [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') with `T` as payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [Semantica.Collections.IRetrievalCollection{\`0}](#T-Semantica-Collections-IRetrievalCollection{`0} 'Semantica.Collections.IRetrievalCollection{`0}') | [IRetrievalCollection\`1](#T-Semantica-Collections-IRetrievalCollection`1 'Semantica.Collections.IRetrievalCollection`1') containing the payloads. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Trees.Builders.TreeBuilderException](#T-Semantica-Trees-Builders-TreeBuilderException 'Semantica.Trees.Builders.TreeBuilderException') | If there is no root node in the collection. |

<a name='T-Semantica-Trees-Converters-ITreeConverter`2'></a>
## ITreeConverter\`2 `type`

##### Namespace

Semantica.Trees.Converters

##### Summary

Can convert a tree of type `TIn` to a tree of type `TOut`.
The resulting tree wil have the same structure as the source tree.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | Type of payload of the tree to convert. |
| TOut | Type of payload of the output tree. |

##### Remarks

The payloads are converted by [IPayloadConverter\`2](#T-Semantica-Trees-Converters-IPayloadConverter`2 'Semantica.Trees.Converters.IPayloadConverter`2'), on which the implementation is dependent.

<a name='M-Semantica-Trees-Converters-ITreeConverter`2-Convert-Semantica-Trees-IReadOnlyTree{`0}-'></a>
### Convert(source) `method`

##### Summary

Converts a tree of type `TIn` to a new tree of type `TOut`.

##### Returns

A new tree with converted payloads that is structurally equivalent to the source.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Semantica.Trees.IReadOnlyTree{\`0}](#T-Semantica-Trees-IReadOnlyTree{`0} 'Semantica.Trees.IReadOnlyTree{`0}') | Tree to convert |

<a name='T-Semantica-Trees-ITreeNodeProperties`1'></a>
## ITreeNodeProperties\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents any tree node with a [Payload](#P-Semantica-Trees-ITreeNodeProperties`1-Payload 'Semantica.Trees.ITreeNodeProperties`1.Payload')

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [Payload](#P-Semantica-Trees-ITreeNodeProperties`1-Payload 'Semantica.Trees.ITreeNodeProperties`1.Payload') |

<a name='P-Semantica-Trees-ITreeNodeProperties`1-Level'></a>
### Level `property`

##### Summary

The level of the node in the tree.

<a name='P-Semantica-Trees-ITreeNodeProperties`1-Payload'></a>
### Payload `property`

##### Summary

Payload of the tree node.

<a name='M-Semantica-Trees-ITreeNodeProperties`1-IsLeaf'></a>
### IsLeaf() `method`

##### Summary

`true` if this node has no children.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-ITreeNode`1'></a>
## ITreeNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a node in the accompanying tree.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payload that is present in each node. |

<a name='P-Semantica-Trees-ITreeNode`1-Owner'></a>
### Owner `property`

##### Summary

Gets the tree that this node is part of. Nodes only have meaning in context of their accompanying tree, and cannot exist without it.

<a name='T-Semantica-Trees-ITreePathNode`1'></a>
## ITreePathNode\`1 `type`

##### Namespace

Semantica.Trees

##### Summary

Represents a node in a [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1').
Can be enumerated to get all nodes from this node to the [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode') of the [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1')

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of [Payload](#P-Semantica-Trees-ITreeNodeProperties`1-Payload 'Semantica.Trees.ITreeNodeProperties`1.Payload'). |

<a name='P-Semantica-Trees-ITreePathNode`1-NextNode'></a>
### NextNode `property`

##### Summary

Gets the next node in the treepath. The next node is always a child of the current node.

<a name='P-Semantica-Trees-ITreePathNode`1-Owner'></a>
### Owner `property`

##### Summary

Gets the treepath that this node is part of. Nodes only have meaning in context of their accompanying treepath, and cannot exist without it.

<a name='T-Semantica-Trees-Module'></a>
## Module `type`

##### Namespace

Semantica.Trees

##### Summary

Module that registers implementations of:

<a name='T-Semantica-Trees-JsonConverters-MorphologicTreeJsonConverter`2'></a>
## MorphologicTreeJsonConverter\`2 `type`

##### Namespace

Semantica.Trees.JsonConverters

##### Summary

Can convert any [IReadOnlyMorphologicTree\`2](#T-Semantica-Trees-IReadOnlyMorphologicTree`2 'Semantica.Trees.IReadOnlyMorphologicTree`2') with payloads to a json-represemtation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload of each node. |
| TNode | Type of the nodes. |

##### Remarks

Conversion from json has not yet been implemented.

<a name='T-Semantica-Trees-Builders-PartialTreeBuilder'></a>
## PartialTreeBuilder `type`

##### Namespace

Semantica.Trees.Builders

<a name='M-Semantica-Trees-Builders-PartialTreeBuilder-MakeSubTree``3-``2,System-Int32,System-Func{``2,``1}-'></a>
### MakeSubTree\`\`3(root,upperboundCapacity,payloadConverter) `method`

##### Summary

Will make a partial treee.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| root | [\`\`2](#T-``2 '``2') |  |
| upperboundCapacity | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| payloadConverter | [System.Func{\`\`2,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``2,``1}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | Type of payloads of the input nodes. |
| TOut | Types of payloads of the output. |
| TNode | The type of nodes of the input. |

<a name='T-Semantica-Trees-JsonConverters-PartialTreeJsonConverter`1'></a>
## PartialTreeJsonConverter\`1 `type`

##### Namespace

Semantica.Trees.JsonConverters

##### Summary

Can convert any [IReadOnlyPartialTree\`1](#T-Semantica-Trees-IReadOnlyPartialTree`1 'Semantica.Trees.IReadOnlyPartialTree`1') to a json-represemtation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload of each node. |

##### Remarks

Conversion from json has not yet been implemented.

<a name='T-Semantica-Trees-Implementations-PartialTreeNode`1'></a>
## PartialTreeNode\`1 `type`

##### Namespace

Semantica.Trees.Implementations

##### Summary

*Inherit from parent.*

<a name='T-Semantica-Trees-Implementations-PartialTree`1'></a>
## PartialTree\`1 `type`

##### Namespace

Semantica.Trees.Implementations

<a name='M-Semantica-Trees-Implementations-PartialTree`1-CopyToNew``1-System-Func{Semantica-Trees-IPartialTreeNode{`0},``0}-'></a>
### CopyToNew\`\`1() `method`

##### Summary

Creates a new tree with the same shape as the current instance, but with all node payloads converted to `TOut` using the provided `convertFunc`.
This method is used by [TreeConverter](#T-Semantica-Trees-Converters-TreeConverter 'Semantica.Trees.Converters.TreeConverter').

##### Parameters

This method has no parameters.

<a name='M-Semantica-Trees-Implementations-PartialTree`1-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

A tree is considered empty if there are no nodes besides the root node.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Trees-Builders-TreeBuilder`1'></a>
## TreeBuilder\`1 `type`

##### Namespace

Semantica.Trees.Builders

##### Summary

Provides a way to grow a tree from the root down.
Can be used by either instantiating a builder and injecting a [ITreeBuildPredicateProvider\`1](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1'), or by using the static methods with root and child predicates.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of payloads |

<a name='M-Semantica-Trees-Builders-TreeBuilder`1-#ctor-Semantica-Trees-Builders-ITreeBuildPredicateProvider{`0}-'></a>
### #ctor(provider) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [Semantica.Trees.Builders.ITreeBuildPredicateProvider{\`0}](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider{`0} 'Semantica.Trees.Builders.ITreeBuildPredicateProvider{`0}') | The [ITreeBuildPredicateProvider\`1](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1') that will be used to identify the root of the tree, and children of each node. |

<a name='M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0}-'></a>
### GrowTree() `method`

##### Summary

Can build an [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') from a collection of payloads.

##### Returns

A [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') with `T` as payload.

##### Parameters

This method has no parameters.

##### Remarks

Uses the injected [ITreeBuildPredicateProvider\`1](#T-Semantica-Trees-Builders-ITreeBuildPredicateProvider`1 'Semantica.Trees.Builders.ITreeBuildPredicateProvider`1') for the root and child predicates, and optional ordering predicates.

<a name='M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0},System-Func{`0,System-Boolean},System-Func{`0,`0,System-Boolean}-'></a>
### GrowTree(collection,isRootPredicate,isChildOfFunc) `method`

##### Summary

Can build an [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') from a collection of payloads.

##### Returns

A [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') with `T` as payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [Semantica.Collections.IRetrievalCollection{\`0}](#T-Semantica-Collections-IRetrievalCollection{`0} 'Semantica.Collections.IRetrievalCollection{`0}') | Retrievalcollection that contains payloads. |
| isRootPredicate | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Function to determine if a payload should be the root of a tree. |
| isChildOfFunc | [System.Func{\`0,\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`0,System.Boolean}') | Function to determine if a payload should be a child node of a parent payload. |

##### Remarks

Will retrieve nodes from the collection, starting with the root node, and adding children recursively.

<a name='M-Semantica-Trees-Builders-TreeBuilder`1-GrowTree-Semantica-Collections-IRetrievalCollection{`0},System-Func{`0,System-Boolean},System-Func{`0,`0,System-Boolean},System-Func{`0,System-IComparable}-'></a>
### GrowTree(collection,isRootPredicate,isChildOfFunc,orderFunc) `method`

##### Summary

Can build an [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') from a collection of payloads.

##### Returns

A [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1') with `T` as payload.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [Semantica.Collections.IRetrievalCollection{\`0}](#T-Semantica-Collections-IRetrievalCollection{`0} 'Semantica.Collections.IRetrievalCollection{`0}') | Retrievalcollection that contains payloads. |
| isRootPredicate | [System.Func{\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Boolean}') | Function to determine if a payload should be the root of a tree. |
| isChildOfFunc | [System.Func{\`0,\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`0,System.Boolean}') | Function to determine if a payload should be a child node of a parent payload. |
| orderFunc | [System.Func{\`0,System.IComparable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.IComparable}') | Function to use to order children by. |

##### Remarks

Will retrieve nodes from the collection, starting with the root node, and adding children recursively. Childen are ordered by the result of the `orderFunc`.

<a name='T-Semantica-Trees-Converters-TreeConverter'></a>
## TreeConverter `type`

##### Namespace

Semantica.Trees.Converters

<a name='M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyTree{``0},System-Func{Semantica-Trees-ITreeNode{``0},``1}-'></a>
### ConvertTree\`\`2(source,convertFunc) `method`

##### Summary

Makes a new [GrowingTree\`1](#T-Semantica-Trees-Implementations-GrowingTree`1 'Semantica.Trees.Implementations.GrowingTree`1'), with the same shape as `source`, but each node is converted using `convertFunc`.

##### Returns

A new instance of [GrowingTree\`1](#T-Semantica-Trees-Implementations-GrowingTree`1 'Semantica.Trees.Implementations.GrowingTree`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Semantica.Trees.IReadOnlyTree{\`\`0}](#T-Semantica-Trees-IReadOnlyTree{``0} 'Semantica.Trees.IReadOnlyTree{``0}') | The [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1') to be converted. |
| convertFunc | [System.Func{Semantica.Trees.ITreeNode{\`\`0},\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Semantica.Trees.ITreeNode{``0},``1}') | The function that convertes the payloads. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of payload of `source`. |
| TOut | The type of payload of the output. |

##### Remarks

If `source` is an instance of [GrowingTree\`1](#T-Semantica-Trees-Implementations-GrowingTree`1 'Semantica.Trees.Implementations.GrowingTree`1'), the whole tree is copied efficiently without having to enumerate the tree and growing the new tree.

<a name='M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyTree{``0},System-Func{Semantica-Trees-ITreeNode{``0},``1},System-Func{Semantica-Trees-ITreeNode{``0},System-Boolean}-'></a>
### ConvertTree\`\`2(source,convertFunc,predicate) `method`

##### Summary

Makes a new [IGrowingTree\`1](#T-Semantica-Trees-IGrowingTree`1 'Semantica.Trees.IGrowingTree`1'), based on the `source`, but each node is converted using `convertFunc`.
If a `predicate` is provided, it's called for all children and only included in the output tree if it returns `true`.

##### Returns

A new instance of [GrowingTree\`1](#T-Semantica-Trees-Implementations-GrowingTree`1 'Semantica.Trees.Implementations.GrowingTree`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Semantica.Trees.IReadOnlyTree{\`\`0}](#T-Semantica-Trees-IReadOnlyTree{``0} 'Semantica.Trees.IReadOnlyTree{``0}') | The [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1') to be converted. |
| convertFunc | [System.Func{Semantica.Trees.ITreeNode{\`\`0},\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Semantica.Trees.ITreeNode{``0},``1}') | The function that convertes the payloads. |
| predicate | [System.Func{Semantica.Trees.ITreeNode{\`\`0},System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Semantica.Trees.ITreeNode{``0},System.Boolean}') | The predicate to be used on each childnode to see if is included in the output tree.
A value of `false` for a node will cause that node (and subtree) not to be added to the output tree. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of payload of `source`. |
| TOut | The type of payload of the output. |

##### Remarks

If a child is not included, it's children aren't included in the output either.

<a name='M-Semantica-Trees-Converters-TreeConverter-ConvertTree``2-Semantica-Trees-IReadOnlyPartialTree{``0},System-Func{Semantica-Trees-IPartialTreeNode{``0},``1}-'></a>
### ConvertTree\`\`2(source,convertFunc) `method`

##### Summary

Makes a new [PartialTree\`1](#T-Semantica-Trees-Implementations-PartialTree`1 'Semantica.Trees.Implementations.PartialTree`1'), with the same shape as `source`, but each node is converted using `convertFunc`.

##### Returns

A new instance of [PartialTree\`1](#T-Semantica-Trees-Implementations-PartialTree`1 'Semantica.Trees.Implementations.PartialTree`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Semantica.Trees.IReadOnlyPartialTree{\`\`0}](#T-Semantica-Trees-IReadOnlyPartialTree{``0} 'Semantica.Trees.IReadOnlyPartialTree{``0}') | The [IReadOnlyPartialTree\`1](#T-Semantica-Trees-IReadOnlyPartialTree`1 'Semantica.Trees.IReadOnlyPartialTree`1') to be converted. |
| convertFunc | [System.Func{Semantica.Trees.IPartialTreeNode{\`\`0},\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Semantica.Trees.IPartialTreeNode{``0},``1}') | The function that convertes the payloads. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TIn | The type of payload of `source`. |
| TOut | The type of payload of the output. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') | If the `source` is not an instance of [PartialTree\`1](#T-Semantica-Trees-Implementations-PartialTree`1 'Semantica.Trees.Implementations.PartialTree`1'). Other types of partial trees are not yet supported. |

##### Remarks

If `source` is an instance of [PartialTree\`1](#T-Semantica-Trees-Implementations-PartialTree`1 'Semantica.Trees.Implementations.PartialTree`1'), the whole tree is copied efficiently without having to enumerate the tree and growing the new tree.

<a name='T-Semantica-Trees-Extensions-TreeExtensions'></a>
## TreeExtensions `type`

##### Namespace

Semantica.Trees.Extensions

##### Summary

Provides additional functionality to [IMorphologicTree\`1](#T-Semantica-Trees-IMorphologicTree`1 'Semantica.Trees.IMorphologicTree`1'), which is a supertype of [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1') and [IReadOnlyPartialTree\`1](#T-Semantica-Trees-IReadOnlyPartialTree`1 'Semantica.Trees.IReadOnlyPartialTree`1')

<a name='M-Semantica-Trees-Extensions-TreeExtensions-DepthFirstOrDefault``2-Semantica-Trees-IMorphologicTree{``1},System-Func{``0,System-Boolean}-'></a>
### DepthFirstOrDefault\`\`2(tree,predicate) `method`

##### Summary

Finds the first treenode for which the payload satisfies the `predicate`.

##### Returns

The first node that matches `predicate`, null otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tree | [Semantica.Trees.IMorphologicTree{\`\`1}](#T-Semantica-Trees-IMorphologicTree{``1} 'Semantica.Trees.IMorphologicTree{``1}') | Tree to search. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Predicate that the node should satisfy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of the node. |
| TPayload | Type of the payload. |

##### Remarks

Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly.

<a name='M-Semantica-Trees-Extensions-TreeExtensions-EnumerateDepthFirst``1-Semantica-Trees-IMorphologicTree{``0}-'></a>
### EnumerateDepthFirst\`\`1(tree) `method`

##### Summary

Enumerate all nodes in the tree, traversing it depth-first.

##### Returns

An enumeration of all tree nodes. This enumration will always contain at least one node.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tree | [Semantica.Trees.IMorphologicTree{\`\`0}](#T-Semantica-Trees-IMorphologicTree{``0} 'Semantica.Trees.IMorphologicTree{``0}') | [IMorphologicTree\`1](#T-Semantica-Trees-IMorphologicTree`1 'Semantica.Trees.IMorphologicTree`1') to enumerate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of node. |

##### Remarks

Enumerating nodes depth-first is probably not the most efficient way to evaluate all tree nodes. Enumerate the tree directly if the order of enumeration does not have to be depth-first.

<a name='M-Semantica-Trees-Extensions-TreeExtensions-TryDepthFirst``1-Semantica-Trees-IMorphologicTree{``0},System-Func{``0,System-Boolean},``0@-'></a>
### TryDepthFirst\`\`1(tree,predicate,matchingNode) `method`

##### Summary

Finds the first treenode for which the payload satisfies the `predicate`.

##### Returns

True if a payload satisfying `predicate` was found, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tree | [Semantica.Trees.IMorphologicTree{\`\`0}](#T-Semantica-Trees-IMorphologicTree{``0} 'Semantica.Trees.IMorphologicTree{``0}') | [IMorphologicTree\`1](#T-Semantica-Trees-IMorphologicTree`1 'Semantica.Trees.IMorphologicTree`1') to search. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Predicate that the node should satisfy. |
| matchingNode | [\`\`0@](#T-``0@ '``0@') | Out parameter that contains the matching node. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of the node. |

##### Remarks

Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly.

<a name='M-Semantica-Trees-Extensions-TreeExtensions-TryDepthFirst``2-Semantica-Trees-IMorphologicTree{``1},System-Func{``0,System-Boolean},``1@-'></a>
### TryDepthFirst\`\`2(tree,predicate,matchingNode) `method`

##### Summary

Finds the first node for which the payload satisfies the `predicate`.

##### Returns

True if a node satisfying `predicate` was found, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tree | [Semantica.Trees.IMorphologicTree{\`\`1}](#T-Semantica-Trees-IMorphologicTree{``1} 'Semantica.Trees.IMorphologicTree{``1}') | Tree to search. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Predicate that the node should satisfy. |
| matchingNode | [\`\`1@](#T-``1@ '``1@') | Out parameter that contains the matching node. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of the node. |
| TPayload | Type of the payload. |

##### Remarks

Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly.

<a name='T-Semantica-Trees-JsonConverters-TreeJsonConverterFactory'></a>
## TreeJsonConverterFactory `type`

##### Namespace

Semantica.Trees.JsonConverters

##### Summary

Implementation of [JsonConverterFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverterFactory 'System.Text.Json.Serialization.JsonConverterFactory'), that will instantiate the correct [JsonConverter\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.Serialization.JsonConverter`1 'System.Text.Json.Serialization.JsonConverter`1') for one of the supported tree types.

##### Remarks

Supports [IReadOnlyMorphologicTree\`2](#T-Semantica-Trees-IReadOnlyMorphologicTree`2 'Semantica.Trees.IReadOnlyMorphologicTree`2'), [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1') and [IReadOnlyPartialTree\`1](#T-Semantica-Trees-IReadOnlyPartialTree`1 'Semantica.Trees.IReadOnlyPartialTree`1')

<a name='T-Semantica-Trees-JsonConverters-TreeJsonConverter`1'></a>
## TreeJsonConverter\`1 `type`

##### Namespace

Semantica.Trees.JsonConverters

##### Summary

Can convert any [IReadOnlyTree\`1](#T-Semantica-Trees-IReadOnlyTree`1 'Semantica.Trees.IReadOnlyTree`1') to a json-represemtation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload of each node. |

##### Remarks

Conversion from json has not yet been implemented.

<a name='T-Semantica-Trees-Extensions-TreeNodeExtensions'></a>
## TreeNodeExtensions `type`

##### Namespace

Semantica.Trees.Extensions

##### Summary

Provides additional functionality to [ITreeNode\`1](#T-Semantica-Trees-ITreeNode`1 'Semantica.Trees.ITreeNode`1') and many of it's supertypes, as well as enumerations of these types.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateAncestors``1-``0-'></a>
### EnumerateAncestors\`\`1(node) `method`

##### Summary

Returns an enumeration of all ancestors of the given node.

##### Returns

An enumeration of treenodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | The node for which to get ancestors. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | The Type of tree node, has to be a [IDescendantTreeNode\`1](#T-Semantica-Trees-IDescendantTreeNode`1 'Semantica.Trees.IDescendantTreeNode`1') |

##### Remarks

The enumeration starts with the first parent, and always ends at the root node.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspringUntil``1-``0,System-Func{``0,System-Boolean}-'></a>
### EnumerateOffspringUntil\`\`1(node,predicate) `method`

##### Summary

Returns an enumeration of offspring of `node` (not including the node itself).
When a node satisfies the `predicate`, enumeration of its children wil stop.

##### Returns

A filtered depth-first enumeration of treenodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | The node for which to get offspring. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Evaluated for every childnode, and when it returns `true`, the children of that node will not be enumerated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | The Type of tree node, has to be a [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1') |

##### Remarks

Tree traversal is depth-first, and siblings are returned in order.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspringWhere``1-``0,System-Func{``0,System-Boolean}-'></a>
### EnumerateOffspringWhere\`\`1(node,predicate) `method`

##### Summary

Returns an enumeration of offspring of `node` (not including the node itself).
Only yields offspring that satisfies the `predicate`, and when that happens enumeration of its children wil stop.

##### Returns

A filtered depth-first enumeration of treenodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | The node for which to get offspring. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Evaluated for every childnode, and only when it returns `true` that node will be yielded, and the children of that node will not be enumerated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | The Type of tree node, has to be a [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1') |

##### Remarks

Tree traversal is depth-first, and siblings are returned in order.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspring``1-``0-'></a>
### EnumerateOffspring\`\`1(node) `method`

##### Summary

Returns an enumeration of all offspring of `node` (not including the node itself).

##### Returns

An enumeration of treenodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | The node for which to get offspring. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | The Type of tree node, has to be a [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1') |

##### Remarks

Tree traversal is depth-first, and siblings are returned in order.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-EnumerateOffspring``1-``0,System-Func{``0,System-Boolean}-'></a>
### EnumerateOffspring\`\`1(node,predicate) `method`

##### Summary

Returns an enumeration of offspring of `node` (not including the node itself).
If a node does not satisfy the `predicate`, that node and it's offspring are not included in the enumration.

##### Returns

A filtered depth-first enumeration of treenodes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | The node for which to get offspring. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Is evaluated for every childnode. If it returns `false` the node and it's offspring are not enumerated. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | The Type of tree node, has to be a [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1') |

##### Remarks

Tree traversal is depth-first, and siblings are returned in order.

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-IndexOf``1-``0-'></a>
### IndexOf\`\`1(node) `method`

##### Summary

Finds the index of the node in its parent.

##### Returns

The index of the node in its parent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | A non-root node to get the index of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of treenode that implements [IMorphologicTreeNode\`1](#T-Semantica-Trees-IMorphologicTreeNode`1 'Semantica.Trees.IMorphologicTreeNode`1'). |

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-IsLeaf``1-``0-'></a>
### IsLeaf\`\`1(node) `method`

##### Summary

Determines if `node` has no children.

##### Returns

`true` if there are no children.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | Node to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of treenode that implements [IAscendantTreeNode\`1](#T-Semantica-Trees-IAscendantTreeNode`1 'Semantica.Trees.IAscendantTreeNode`1'). |

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-IsRoot``1-``0-'></a>
### IsRoot\`\`1(node) `method`

##### Summary

Determines if `node` is the root node of it's owner.

##### Returns

`true` if the node has no parent.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | Node to evaluate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of treenode that implements [IDescendantTreeNode\`1](#T-Semantica-Trees-IDescendantTreeNode`1 'Semantica.Trees.IDescendantTreeNode`1'). |

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-MakeTreePath``1-Semantica-Trees-ITreeNode{``0}-'></a>
### MakeTreePath\`\`1(node) `method`

##### Summary

Creates a [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') with `node` as the ultimate node.

##### Returns

A new [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [Semantica.Trees.ITreeNode{\`\`0}](#T-Semantica-Trees-ITreeNode{``0} 'Semantica.Trees.ITreeNode{``0}') | Node to get the treepath to. This node will be the treepath's [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the payload. |

##### Remarks

The rootnode of the path will be the [RootNode](#P-Semantica-Trees-IMorphologicTree`1-RootNode 'Semantica.Trees.IMorphologicTree`1.RootNode') of the `node`'s [Owner](#P-Semantica-Trees-ITreeNode`1-Owner 'Semantica.Trees.ITreeNode`1.Owner').

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-Payloads``1-System-Collections-Generic-IEnumerable{Semantica-Trees-ITreeNodeProperties{``0}}-'></a>
### Payloads\`\`1(nodes) `method`

##### Summary

Transforms an enumeration of nodes into an enumeration of the payload of those nodes.

##### Returns

An enumeration of payloads.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nodes | [System.Collections.Generic.IEnumerable{Semantica.Trees.ITreeNodeProperties{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Semantica.Trees.ITreeNodeProperties{``0}}') | An enumeration of treenodes. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the payload. |

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-SiblingCount``1-``0-'></a>
### SiblingCount\`\`1(node) `method`

##### Summary

Returns the amount of children of the provided node's parents, or put otherwise, the amount of siblings the node has (including itself).

##### Returns

An integer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| node | [\`\`0](#T-``0 '``0') | A non-root node to count the siblings of. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of treenode that implements [IMorphologicTreeNode\`1](#T-Semantica-Trees-IMorphologicTreeNode`1 'Semantica.Trees.IMorphologicTreeNode`1'). |

<a name='M-Semantica-Trees-Extensions-TreeNodeExtensions-Where``2-System-Collections-Generic-IEnumerable{``1},System-Func{``0,System-Boolean}-'></a>
### Where\`\`2(nodes,predicate) `method`

##### Summary

Filters and enumeration of tree nodes where the payload satisfies the `predicate`.

##### Returns

Enumeration of nodes matching `predicate`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| nodes | [System.Collections.Generic.IEnumerable{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``1}') | An enumeration of nodes. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Predicate that the nodes should satisfy. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TNode | Type of the node implementing [ITreeNodeProperties\`1](#T-Semantica-Trees-ITreeNodeProperties`1 'Semantica.Trees.ITreeNodeProperties`1'). |
| TPayload | Type of the payload. |

<a name='T-Semantica-Trees-Implementations-TreeNode`1'></a>
## TreeNode\`1 `type`

##### Namespace

Semantica.Trees.Implementations

<a name='P-Semantica-Trees-Implementations-TreeNode`1-ChildIndices'></a>
### ChildIndices `property`

##### Summary

Indices of the children of the node.

<a name='P-Semantica-Trees-Implementations-TreeNode`1-Index'></a>
### Index `property`

##### Summary

Index of this node in the tree.

<a name='P-Semantica-Trees-Implementations-TreeNode`1-ParentIndex'></a>
### ParentIndex `property`

##### Summary

Index of the parent node in the tree.

<a name='M-Semantica-Trees-Implementations-TreeNode`1-DuplicateFor``1-Semantica-Trees-Implementations-GrowingTree{``0},``0-'></a>
### DuplicateFor\`\`1() `method`

##### Summary

Makes a duplicate of the node for a copy of the tree.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Trees-Implementations-TreeNode`1-Unleaf-System-Int32-'></a>
### Unleaf(expectedChildren) `method`

##### Summary

Makes the node ready to have children added. For non-root nodes this should only be called if a child is added immediately after.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expectedChildren | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Initial capacity of the child index list |

<a name='T-Semantica-Trees-Extensions-TreePathExtensions'></a>
## TreePathExtensions `type`

##### Namespace

Semantica.Trees.Extensions

##### Summary

Provides additional functionality to [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1').

<a name='M-Semantica-Trees-Extensions-TreePathExtensions-EnumerateNodesFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0}-'></a>
### EnumerateNodesFromUltimate\`\`1(treePath) `method`

##### Summary

Enumerates the nodes of the treepath in reverse order, so starting at the ultimate node, and ending at the root node.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [ITreePathNode\`1](#T-Semantica-Trees-ITreePathNode`1 'Semantica.Trees.ITreePathNode`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| treePath | [Semantica.Trees.IReadOnlyTreePath{\`\`0}](#T-Semantica-Trees-IReadOnlyTreePath{``0} 'Semantica.Trees.IReadOnlyTreePath{``0}') | The [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') to enumerate. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the payloads of the nodes. |

<a name='M-Semantica-Trees-Extensions-TreePathExtensions-FirstNotDefaultValueFromUltimate``2-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,``1}-'></a>
### FirstNotDefaultValueFromUltimate\`\`2(treePath,selector) `method`

##### Summary

Finds the first value that is not `default(TValue)` in `treePath`, using `selector` to get the values,
starting at the [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode').

##### Returns

First value found not equal to `default(TValue)` in `treePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| treePath | [Semantica.Trees.IReadOnlyTreePath{\`\`0}](#T-Semantica-Trees-IReadOnlyTreePath{``0} 'Semantica.Trees.IReadOnlyTreePath{``0}') | The [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') to search. |
| selector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function that gets the value from the payload. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the node payloads. |
| TValue | Type of value to select. |

##### Remarks

Nodes are enumerated in reverse order, starting with [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode'), ending with [RootNode](#P-Semantica-Trees-IReadOnlyTreePath`1-RootNode 'Semantica.Trees.IReadOnlyTreePath`1.RootNode').
If not found, `default(TValue)` is returned instead.

<a name='M-Semantica-Trees-Extensions-TreePathExtensions-FirstNotDefaultValue``2-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,``1}-'></a>
### FirstNotDefaultValue\`\`2(treePath,selector) `method`

##### Summary

Finds the first value that is not `default(TValue)` in `treePath`, using `selector` to get the values.

##### Returns

First value found not equal to `default(TValue)` in `treePath`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| treePath | [Semantica.Trees.IReadOnlyTreePath{\`\`0}](#T-Semantica-Trees-IReadOnlyTreePath{``0} 'Semantica.Trees.IReadOnlyTreePath{``0}') | The [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') to search. |
| selector | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Function that gets the value from the payload. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the node payloads. |
| TValue | Type of value to select. |

##### Remarks

Nodes are enumerated in regular order, starting with [RootNode](#P-Semantica-Trees-IReadOnlyTreePath`1-RootNode 'Semantica.Trees.IReadOnlyTreePath`1.RootNode'), ending with [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode').
If not found, `default(TValue)` is returned instead.

<a name='M-Semantica-Trees-Extensions-TreePathExtensions-FirstOrDefaultFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{``0,System-Boolean}-'></a>
### FirstOrDefaultFromUltimate\`\`1(treePath,predicate) `method`

##### Summary

Finds the first node to satisfy the `predicate`, starting at the [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode').

##### Returns

First node to satisfy the `predicate`, or `default(TValue)`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| treePath | [Semantica.Trees.IReadOnlyTreePath{\`\`0}](#T-Semantica-Trees-IReadOnlyTreePath{``0} 'Semantica.Trees.IReadOnlyTreePath{``0}') | The [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') to search. |
| predicate | [System.Func{\`\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Boolean}') | Function used to evaluate each payload |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the node payloads. |

##### Remarks

Nodes are enumerated in reverse order, starting with [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode'), ending with [RootNode](#P-Semantica-Trees-IReadOnlyTreePath`1-RootNode 'Semantica.Trees.IReadOnlyTreePath`1.RootNode').
If not found, `default(TValue)` is returned instead.

<a name='M-Semantica-Trees-Extensions-TreePathExtensions-FirstOrDefaultFromUltimate``1-Semantica-Trees-IReadOnlyTreePath{``0},System-Func{Semantica-Trees-ITreePathNode{``0},System-Boolean}-'></a>
### FirstOrDefaultFromUltimate\`\`1(treePath,predicate) `method`

##### Summary

Finds the first node to satisfy the `predicate`, starting at the [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode').

##### Returns

First node to satisfy the `predicate`, or `default(TValue)`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| treePath | [Semantica.Trees.IReadOnlyTreePath{\`\`0}](#T-Semantica-Trees-IReadOnlyTreePath{``0} 'Semantica.Trees.IReadOnlyTreePath{``0}') | The [IReadOnlyTreePath\`1](#T-Semantica-Trees-IReadOnlyTreePath`1 'Semantica.Trees.IReadOnlyTreePath`1') to search. |
| predicate | [System.Func{Semantica.Trees.ITreePathNode{\`\`0},System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Semantica.Trees.ITreePathNode{``0},System.Boolean}') | Function used to evaluate each [ITreePathNode\`1](#T-Semantica-Trees-ITreePathNode`1 'Semantica.Trees.ITreePathNode`1') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the node payloads. |

##### Remarks

Nodes are enumerated in reverse order, starting with [UltimateNode](#P-Semantica-Trees-IReadOnlyTreePath`1-UltimateNode 'Semantica.Trees.IReadOnlyTreePath`1.UltimateNode'), ending with [RootNode](#P-Semantica-Trees-IReadOnlyTreePath`1-RootNode 'Semantica.Trees.IReadOnlyTreePath`1.RootNode').
If not found, `default(TValue)` is returned instead.

<a name='T-Semantica-Trees-Implementations-TreePathNode`1'></a>
## TreePathNode\`1 `type`

##### Namespace

Semantica.Trees.Implementations

##### Summary

*Inherit from parent.*

<a name='T-Semantica-Trees-Implementations-TreePath`1'></a>
## TreePath\`1 `type`

##### Namespace

Semantica.Trees.Implementations

##### Summary

*Inherit from parent.*
