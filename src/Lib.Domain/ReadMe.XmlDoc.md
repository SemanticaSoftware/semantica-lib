<a name='assembly'></a>
# Lib.Domain

## Contents

- [AggregateRootEntityAttribute](#T-Semantica-Domain-DesignAttributes-AggregateRootEntityAttribute 'Semantica.Domain.DesignAttributes.AggregateRootEntityAttribute')
- [DependentAttribute](#T-Semantica-Domain-DesignAttributes-DependentAttribute 'Semantica.Domain.DesignAttributes.DependentAttribute')
  - [#ctor(cardinality,relationKind)](#M-Semantica-Domain-DesignAttributes-DependentAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind,Semantica-Domain-DesignAttributes-RelationKind- 'Semantica.Domain.DesignAttributes.DependentAttribute.#ctor(Semantica.Domain.DesignAttributes.RelationKind,Semantica.Domain.DesignAttributes.RelationKind)')
- [DependentEntityAttribute](#T-Semantica-Domain-DesignAttributes-DependentEntityAttribute 'Semantica.Domain.DesignAttributes.DependentEntityAttribute')
- [DependentEntityAttribute\`1](#T-Semantica-Domain-DesignAttributes-DependentEntityAttribute`1 'Semantica.Domain.DesignAttributes.DependentEntityAttribute`1')
- [DomainKeyAttribute](#T-Semantica-Domain-DesignAttributes-DomainKeyAttribute 'Semantica.Domain.DesignAttributes.DomainKeyAttribute')
- [DomainRelationAttribute](#T-Semantica-Domain-DesignAttributes-DomainRelationAttribute 'Semantica.Domain.DesignAttributes.DomainRelationAttribute')
- [Elective](#T-Semantica-Domain-Electives-Elective 'Semantica.Domain.Electives.Elective')
  - [Empty\`\`1()](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1')
  - [If\`\`1(condition,payload)](#M-Semantica-Domain-Electives-Elective-If``1-System-Boolean,``0- 'Semantica.Domain.Electives.Elective.If``1(System.Boolean,``0)')
  - [If\`\`1(payloadFunc)](#M-Semantica-Domain-Electives-Elective-If``1-System-Func{``0}- 'Semantica.Domain.Electives.Elective.If``1(System.Func{``0})')
  - [If\`\`1(payload)](#M-Semantica-Domain-Electives-Elective-If``1-``0- 'Semantica.Domain.Electives.Elective.If``1(``0)')
  - [Of\`\`1(payload)](#M-Semantica-Domain-Electives-Elective-Of``1-``0- 'Semantica.Domain.Electives.Elective.Of``1(``0)')
  - [Of\`\`1(payload,loadKind)](#M-Semantica-Domain-Electives-Elective-Of``1-``0,Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.Elective.Of``1(``0,Semantica.Domain.Electives.LoadKind)')
- [ElectiveCollection](#T-Semantica-Domain-Electives-ElectiveCollection 'Semantica.Domain.Electives.ElectiveCollection')
  - [Empty\`\`2()](#M-Semantica-Domain-Electives-ElectiveCollection-Empty``2 'Semantica.Domain.Electives.ElectiveCollection.Empty``2')
  - [If\`\`2(condition,payload)](#M-Semantica-Domain-Electives-ElectiveCollection-If``2-System-Boolean,``0- 'Semantica.Domain.Electives.ElectiveCollection.If``2(System.Boolean,``0)')
  - [If\`\`2(payloadFunc)](#M-Semantica-Domain-Electives-ElectiveCollection-If``2-System-Func{``0}- 'Semantica.Domain.Electives.ElectiveCollection.If``2(System.Func{``0})')
  - [Of\`\`2(payload,isFiltered)](#M-Semantica-Domain-Electives-ElectiveCollection-Of``2-``0,System-Boolean- 'Semantica.Domain.Electives.ElectiveCollection.Of``2(``0,System.Boolean)')
  - [Of\`\`2(payload,loadKind)](#M-Semantica-Domain-Electives-ElectiveCollection-Of``2-``0,Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.ElectiveCollection.Of``2(``0,Semantica.Domain.Electives.LoadKind)')
- [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2')
- [ElectiveExtensionsX](#T-Semantica-Domain-Electives-ElectiveExtensionsX 'Semantica.Domain.Electives.ElectiveExtensionsX')
- [ElectiveList](#T-Semantica-Domain-Electives-ElectiveList 'Semantica.Domain.Electives.ElectiveList')
  - [Empty\`\`1()](#M-Semantica-Domain-Electives-ElectiveList-Empty``1 'Semantica.Domain.Electives.ElectiveList.Empty``1')
  - [If\`\`1(condition,payload)](#M-Semantica-Domain-Electives-ElectiveList-If``1-System-Boolean,System-Collections-Generic-IReadOnlyList{``0}- 'Semantica.Domain.Electives.ElectiveList.If``1(System.Boolean,System.Collections.Generic.IReadOnlyList{``0})')
  - [If\`\`1(payloadFunc)](#M-Semantica-Domain-Electives-ElectiveList-If``1-System-Func{System-Collections-Generic-IReadOnlyList{``0}}- 'Semantica.Domain.Electives.ElectiveList.If``1(System.Func{System.Collections.Generic.IReadOnlyList{``0}})')
  - [Of\`\`1(payload,isFiltered)](#M-Semantica-Domain-Electives-ElectiveList-Of``1-System-Collections-Generic-IReadOnlyList{``0},System-Boolean- 'Semantica.Domain.Electives.ElectiveList.Of``1(System.Collections.Generic.IReadOnlyList{``0},System.Boolean)')
  - [Of\`\`1(payload,loadKind)](#M-Semantica-Domain-Electives-ElectiveList-Of``1-System-Collections-Generic-IReadOnlyList{``0},Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.ElectiveList.Of``1(System.Collections.Generic.IReadOnlyList{``0},Semantica.Domain.Electives.LoadKind)')
- [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1')
- [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1')
- [EntityAttribute](#T-Semantica-Domain-DesignAttributes-EntityAttribute 'Semantica.Domain.DesignAttributes.EntityAttribute')
- [EntityRelationAttribute](#T-Semantica-Domain-DesignAttributes-EntityRelationAttribute 'Semantica.Domain.DesignAttributes.EntityRelationAttribute')
- [IAddRemoveRepository\`2](#T-Semantica-Domain-Repositories-IAddRemoveRepository`2 'Semantica.Domain.Repositories.IAddRemoveRepository`2')
- [IAddRemoveRepository\`3](#T-Semantica-Domain-Repositories-IAddRemoveRepository`3 'Semantica.Domain.Repositories.IAddRemoveRepository`3')
- [IAddRepository\`2](#T-Semantica-Domain-Repositories-IAddRepository`2 'Semantica.Domain.Repositories.IAddRepository`2')
  - [Add(domainModel)](#M-Semantica-Domain-Repositories-IAddRepository`2-Add-`0- 'Semantica.Domain.Repositories.IAddRepository`2.Add(`0)')
  - [AddRange(domainModels)](#M-Semantica-Domain-Repositories-IAddRepository`2-AddRange-System-Collections-Generic-IEnumerable{`0}- 'Semantica.Domain.Repositories.IAddRepository`2.AddRange(System.Collections.Generic.IEnumerable{`0})')
- [IDomainModel\`1](#T-Semantica-Domain-IDomainModel`1 'Semantica.Domain.IDomainModel`1')
- [IElectiveCollection\`2](#T-Semantica-Domain-Electives-IElectiveCollection`2 'Semantica.Domain.Electives.IElectiveCollection`2')
  - [IsFiltered()](#M-Semantica-Domain-Electives-IElectiveCollection`2-IsFiltered 'Semantica.Domain.Electives.IElectiveCollection`2.IsFiltered')
- [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1')
  - [LoadKind](#P-Semantica-Domain-Electives-IElective`1-LoadKind 'Semantica.Domain.Electives.IElective`1.LoadKind')
  - [Payload](#P-Semantica-Domain-Electives-IElective`1-Payload 'Semantica.Domain.Electives.IElective`1.Payload')
  - [IsLoaded()](#M-Semantica-Domain-Electives-IElective`1-IsLoaded 'Semantica.Domain.Electives.IElective`1.IsLoaded')
- [IOwned](#T-Semantica-Domain-Electives-IOwned 'Semantica.Domain.Electives.IOwned')
- [IOwned\`1](#T-Semantica-Domain-Electives-IOwned`1 'Semantica.Domain.Electives.IOwned`1')
  - [Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner')
- [IReadRepository\`2](#T-Semantica-Domain-Repositories-IReadRepository`2 'Semantica.Domain.Repositories.IReadRepository`2')
  - [Contains(key)](#M-Semantica-Domain-Repositories-IReadRepository`2-Contains-`1- 'Semantica.Domain.Repositories.IReadRepository`2.Contains(`1)')
  - [ContainsAsync(key,cancellationToken)](#M-Semantica-Domain-Repositories-IReadRepository`2-ContainsAsync-`1,System-Threading-CancellationToken- 'Semantica.Domain.Repositories.IReadRepository`2.ContainsAsync(`1,System.Threading.CancellationToken)')
  - [GetAllAsync(cancellationToken)](#M-Semantica-Domain-Repositories-IReadRepository`2-GetAllAsync-System-Threading-CancellationToken- 'Semantica.Domain.Repositories.IReadRepository`2.GetAllAsync(System.Threading.CancellationToken)')
  - [GetAsync(key,cancellationToken)](#M-Semantica-Domain-Repositories-IReadRepository`2-GetAsync-`1,System-Threading-CancellationToken- 'Semantica.Domain.Repositories.IReadRepository`2.GetAsync(`1,System.Threading.CancellationToken)')
  - [GetListAsync(keys,cancellationToken)](#M-Semantica-Domain-Repositories-IReadRepository`2-GetListAsync-System-Collections-Generic-IEnumerable{`1},System-Threading-CancellationToken- 'Semantica.Domain.Repositories.IReadRepository`2.GetListAsync(System.Collections.Generic.IEnumerable{`1},System.Threading.CancellationToken)')
  - [GetListInMatchingOrderAsync(keys,cancellationToken)](#M-Semantica-Domain-Repositories-IReadRepository`2-GetListInMatchingOrderAsync-System-Collections-Generic-IEnumerable{`1},System-Threading-CancellationToken- 'Semantica.Domain.Repositories.IReadRepository`2.GetListInMatchingOrderAsync(System.Collections.Generic.IEnumerable{`1},System.Threading.CancellationToken)')
- [IRemoveRepository\`1](#T-Semantica-Domain-Repositories-IRemoveRepository`1 'Semantica.Domain.Repositories.IRemoveRepository`1')
  - [Remove(key)](#M-Semantica-Domain-Repositories-IRemoveRepository`1-Remove-`0- 'Semantica.Domain.Repositories.IRemoveRepository`1.Remove(`0)')
  - [RemoveRange(keys)](#M-Semantica-Domain-Repositories-IRemoveRepository`1-RemoveRange-System-Collections-Generic-IEnumerable{`0}- 'Semantica.Domain.Repositories.IRemoveRepository`1.RemoveRange(System.Collections.Generic.IEnumerable{`0})')
- [IReplaceRepository\`2](#T-Semantica-Domain-Repositories-IReplaceRepository`2 'Semantica.Domain.Repositories.IReplaceRepository`2')
  - [Replace(domainModel)](#M-Semantica-Domain-Repositories-IReplaceRepository`2-Replace-`0- 'Semantica.Domain.Repositories.IReplaceRepository`2.Replace(`0)')
  - [ReplaceRange(domainModels)](#M-Semantica-Domain-Repositories-IReplaceRepository`2-ReplaceRange-System-Collections-Generic-IEnumerable{`0}- 'Semantica.Domain.Repositories.IReplaceRepository`2.ReplaceRange(System.Collections.Generic.IEnumerable{`0})')
- [IRepository\`2](#T-Semantica-Domain-Repositories-IRepository`2 'Semantica.Domain.Repositories.IRepository`2')
- [IRepository\`3](#T-Semantica-Domain-Repositories-IRepository`3 'Semantica.Domain.Repositories.IRepository`3')
- [IRepository\`4](#T-Semantica-Domain-Repositories-IRepository`4 'Semantica.Domain.Repositories.IRepository`4')
- [ISimpleDomainModel\`1](#T-Semantica-Domain-ISimpleDomainModel`1 'Semantica.Domain.ISimpleDomainModel`1')
- [ISubEntity\`2](#T-Semantica-Domain-ISubEntity`2 'Semantica.Domain.ISubEntity`2')
- [KeyKind](#T-Semantica-Domain-DesignAttributes-KeyKind 'Semantica.Domain.DesignAttributes.KeyKind')
  - [Composite](#F-Semantica-Domain-DesignAttributes-KeyKind-Composite 'Semantica.Domain.DesignAttributes.KeyKind.Composite')
  - [Foreign](#F-Semantica-Domain-DesignAttributes-KeyKind-Foreign 'Semantica.Domain.DesignAttributes.KeyKind.Foreign')
  - [ForeignId](#F-Semantica-Domain-DesignAttributes-KeyKind-ForeignId 'Semantica.Domain.DesignAttributes.KeyKind.ForeignId')
  - [Guid](#F-Semantica-Domain-DesignAttributes-KeyKind-Guid 'Semantica.Domain.DesignAttributes.KeyKind.Guid')
  - [Id](#F-Semantica-Domain-DesignAttributes-KeyKind-Id 'Semantica.Domain.DesignAttributes.KeyKind.Id')
  - [Integer](#F-Semantica-Domain-DesignAttributes-KeyKind-Integer 'Semantica.Domain.DesignAttributes.KeyKind.Integer')
  - [Natural](#F-Semantica-Domain-DesignAttributes-KeyKind-Natural 'Semantica.Domain.DesignAttributes.KeyKind.Natural')
  - [Primary](#F-Semantica-Domain-DesignAttributes-KeyKind-Primary 'Semantica.Domain.DesignAttributes.KeyKind.Primary')
  - [Unique](#F-Semantica-Domain-DesignAttributes-KeyKind-Unique 'Semantica.Domain.DesignAttributes.KeyKind.Unique')
- [LinkAttribute](#T-Semantica-Domain-DesignAttributes-LinkAttribute 'Semantica.Domain.DesignAttributes.LinkAttribute')
  - [#ctor()](#M-Semantica-Domain-DesignAttributes-LinkAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind- 'Semantica.Domain.DesignAttributes.LinkAttribute.#ctor(Semantica.Domain.DesignAttributes.RelationKind)')
- [LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind')
  - [Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded')
  - [Unfiltered](#F-Semantica-Domain-Electives-LoadKind-Unfiltered 'Semantica.Domain.Electives.LoadKind.Unfiltered')
- [ModelAttribute](#T-Semantica-Domain-DesignAttributes-ModelAttribute 'Semantica.Domain.DesignAttributes.ModelAttribute')
  - [ModuleName](#P-Semantica-Domain-DesignAttributes-ModelAttribute-ModuleName 'Semantica.Domain.DesignAttributes.ModelAttribute.ModuleName')
  - [PrimaryKeyKind](#P-Semantica-Domain-DesignAttributes-ModelAttribute-PrimaryKeyKind 'Semantica.Domain.DesignAttributes.ModelAttribute.PrimaryKeyKind')
  - [Purpose](#P-Semantica-Domain-DesignAttributes-ModelAttribute-Purpose 'Semantica.Domain.DesignAttributes.ModelAttribute.Purpose')
- [ModelPurpose](#T-Semantica-Domain-DesignAttributes-ModelPurpose 'Semantica.Domain.DesignAttributes.ModelPurpose')
  - [Add](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Add 'Semantica.Domain.DesignAttributes.ModelPurpose.Add')
  - [Application](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Application 'Semantica.Domain.DesignAttributes.ModelPurpose.Application')
  - [Domain](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Domain 'Semantica.Domain.DesignAttributes.ModelPurpose.Domain')
  - [Entity](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Entity 'Semantica.Domain.DesignAttributes.ModelPurpose.Entity')
  - [Get](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Get 'Semantica.Domain.DesignAttributes.ModelPurpose.Get')
  - [Isolation](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Isolation 'Semantica.Domain.DesignAttributes.ModelPurpose.Isolation')
  - [Replace](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Replace 'Semantica.Domain.DesignAttributes.ModelPurpose.Replace')
  - [Repository](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Repository 'Semantica.Domain.DesignAttributes.ModelPurpose.Repository')
  - [Storage](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Storage 'Semantica.Domain.DesignAttributes.ModelPurpose.Storage')
  - [View](#F-Semantica-Domain-DesignAttributes-ModelPurpose-View 'Semantica.Domain.DesignAttributes.ModelPurpose.View')
- [Owned](#T-Semantica-Domain-Electives-Owned 'Semantica.Domain.Electives.Owned')
  - [Empty\`\`1()](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1')
  - [If\`\`2(condition,owned,owner)](#M-Semantica-Domain-Electives-Owned-If``2-System-Boolean,``1,``0- 'Semantica.Domain.Electives.Owned.If``2(System.Boolean,``1,``0)')
  - [If\`\`2(ownedFunc,owner)](#M-Semantica-Domain-Electives-Owned-If``2-System-Func{``1},``0- 'Semantica.Domain.Electives.Owned.If``2(System.Func{``1},``0)')
  - [If\`\`2(owned,owner)](#M-Semantica-Domain-Electives-Owned-If``2-``1,``0- 'Semantica.Domain.Electives.Owned.If``2(``1,``0)')
  - [Of\`\`2(owned,owner)](#M-Semantica-Domain-Electives-Owned-Of``2-``1,``0- 'Semantica.Domain.Electives.Owned.Of``2(``1,``0)')
  - [Of\`\`2(owned,owner,loadKind)](#M-Semantica-Domain-Electives-Owned-Of``2-``1,``0,Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.Owned.Of``2(``1,``0,Semantica.Domain.Electives.LoadKind)')
- [OwnedCollection](#T-Semantica-Domain-Electives-OwnedCollection 'Semantica.Domain.Electives.OwnedCollection')
  - [Empty\`\`2()](#M-Semantica-Domain-Electives-OwnedCollection-Empty``2 'Semantica.Domain.Electives.OwnedCollection.Empty``2')
  - [If\`\`3(condition,owned,owner)](#M-Semantica-Domain-Electives-OwnedCollection-If``3-System-Boolean,``1,``0- 'Semantica.Domain.Electives.OwnedCollection.If``3(System.Boolean,``1,``0)')
  - [If\`\`3(ownedFunc,owner)](#M-Semantica-Domain-Electives-OwnedCollection-If``3-System-Func{``1},``0- 'Semantica.Domain.Electives.OwnedCollection.If``3(System.Func{``1},``0)')
  - [Of\`\`3(owned,owner,isFiltered)](#M-Semantica-Domain-Electives-OwnedCollection-Of``3-``1,``0,System-Boolean- 'Semantica.Domain.Electives.OwnedCollection.Of``3(``1,``0,System.Boolean)')
  - [Of\`\`3(owned,owner,loadKind)](#M-Semantica-Domain-Electives-OwnedCollection-Of``3-``1,``0,Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.OwnedCollection.Of``3(``1,``0,Semantica.Domain.Electives.LoadKind)')
- [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2')
- [OwnedList](#T-Semantica-Domain-Electives-OwnedList 'Semantica.Domain.Electives.OwnedList')
  - [Empty\`\`1()](#M-Semantica-Domain-Electives-OwnedList-Empty``1 'Semantica.Domain.Electives.OwnedList.Empty``1')
  - [If\`\`2(condition,owned,owner)](#M-Semantica-Domain-Electives-OwnedList-If``2-System-Boolean,System-Collections-Generic-IReadOnlyList{``1},``0- 'Semantica.Domain.Electives.OwnedList.If``2(System.Boolean,System.Collections.Generic.IReadOnlyList{``1},``0)')
  - [If\`\`2(ownedFunc,owner)](#M-Semantica-Domain-Electives-OwnedList-If``2-System-Func{System-Collections-Generic-IReadOnlyList{``1}},``0- 'Semantica.Domain.Electives.OwnedList.If``2(System.Func{System.Collections.Generic.IReadOnlyList{``1}},``0)')
  - [Of\`\`2(owned,owner,isFiltered)](#M-Semantica-Domain-Electives-OwnedList-Of``2-System-Collections-Generic-IReadOnlyList{``1},``0,System-Boolean- 'Semantica.Domain.Electives.OwnedList.Of``2(System.Collections.Generic.IReadOnlyList{``1},``0,System.Boolean)')
  - [Of\`\`2(owned,owner,loadKind)](#M-Semantica-Domain-Electives-OwnedList-Of``2-System-Collections-Generic-IReadOnlyList{``1},``0,Semantica-Domain-Electives-LoadKind- 'Semantica.Domain.Electives.OwnedList.Of``2(System.Collections.Generic.IReadOnlyList{``1},``0,Semantica.Domain.Electives.LoadKind)')
- [OwnedList\`1](#T-Semantica-Domain-Electives-OwnedList`1 'Semantica.Domain.Electives.OwnedList`1')
- [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1')
- [OwnerAttribute](#T-Semantica-Domain-DesignAttributes-OwnerAttribute 'Semantica.Domain.DesignAttributes.OwnerAttribute')
  - [#ctor(relationKind)](#M-Semantica-Domain-DesignAttributes-OwnerAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind- 'Semantica.Domain.DesignAttributes.OwnerAttribute.#ctor(Semantica.Domain.DesignAttributes.RelationKind)')
- [Owner\`1](#T-Semantica-Domain-Electives-Owner`1 'Semantica.Domain.Electives.Owner`1')
  - [GetHashCode()](#M-Semantica-Domain-Electives-Owner`1-GetHashCode 'Semantica.Domain.Electives.Owner`1.GetHashCode')
- [RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind')
  - [Forward](#F-Semantica-Domain-DesignAttributes-RelationKind-Forward 'Semantica.Domain.DesignAttributes.RelationKind.Forward')
  - [ManyToOne](#F-Semantica-Domain-DesignAttributes-RelationKind-ManyToOne 'Semantica.Domain.DesignAttributes.RelationKind.ManyToOne')
  - [More](#F-Semantica-Domain-DesignAttributes-RelationKind-More 'Semantica.Domain.DesignAttributes.RelationKind.More')
  - [One](#F-Semantica-Domain-DesignAttributes-RelationKind-One 'Semantica.Domain.DesignAttributes.RelationKind.One')
  - [OneOrMore](#F-Semantica-Domain-DesignAttributes-RelationKind-OneOrMore 'Semantica.Domain.DesignAttributes.RelationKind.OneOrMore')
  - [OneToMany](#F-Semantica-Domain-DesignAttributes-RelationKind-OneToMany 'Semantica.Domain.DesignAttributes.RelationKind.OneToMany')
  - [Owned](#F-Semantica-Domain-DesignAttributes-RelationKind-Owned 'Semantica.Domain.DesignAttributes.RelationKind.Owned')
  - [OwnedValueObject](#F-Semantica-Domain-DesignAttributes-RelationKind-OwnedValueObject 'Semantica.Domain.DesignAttributes.RelationKind.OwnedValueObject')
  - [Owner](#F-Semantica-Domain-DesignAttributes-RelationKind-Owner 'Semantica.Domain.DesignAttributes.RelationKind.Owner')
  - [Ownership](#F-Semantica-Domain-DesignAttributes-RelationKind-Ownership 'Semantica.Domain.DesignAttributes.RelationKind.Ownership')
  - [ToMore](#F-Semantica-Domain-DesignAttributes-RelationKind-ToMore 'Semantica.Domain.DesignAttributes.RelationKind.ToMore')
  - [ToOne](#F-Semantica-Domain-DesignAttributes-RelationKind-ToOne 'Semantica.Domain.DesignAttributes.RelationKind.ToOne')
  - [ToOneOrMore](#F-Semantica-Domain-DesignAttributes-RelationKind-ToOneOrMore 'Semantica.Domain.DesignAttributes.RelationKind.ToOneOrMore')
  - [ValueObject](#F-Semantica-Domain-DesignAttributes-RelationKind-ValueObject 'Semantica.Domain.DesignAttributes.RelationKind.ValueObject')
- [ValueAttribute](#T-Semantica-Domain-DesignAttributes-ValueAttribute 'Semantica.Domain.DesignAttributes.ValueAttribute')
  - [#ctor(cardinality,relationKind)](#M-Semantica-Domain-DesignAttributes-ValueAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind,Semantica-Domain-DesignAttributes-RelationKind- 'Semantica.Domain.DesignAttributes.ValueAttribute.#ctor(Semantica.Domain.DesignAttributes.RelationKind,Semantica.Domain.DesignAttributes.RelationKind)')
- [ValueObjectAttribute](#T-Semantica-Domain-DesignAttributes-ValueObjectAttribute 'Semantica.Domain.DesignAttributes.ValueObjectAttribute')
- [ValueObjectAttribute\`1](#T-Semantica-Domain-DesignAttributes-ValueObjectAttribute`1 'Semantica.Domain.DesignAttributes.ValueObjectAttribute`1')

<a name='T-Semantica-Domain-DesignAttributes-AggregateRootEntityAttribute'></a>
## AggregateRootEntityAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a model that represents a particular entity in your domain that is the root entity in its aggregate.

<a name='T-Semantica-Domain-DesignAttributes-DependentAttribute'></a>
## DependentAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Summary

Indicates a property that contains an aggregation of owned entity objects.

<a name='M-Semantica-Domain-DesignAttributes-DependentAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind,Semantica-Domain-DesignAttributes-RelationKind-'></a>
### #ctor(cardinality,relationKind) `constructor`

##### Summary

Default relation is [Owned](#F-Semantica-Domain-DesignAttributes-RelationKind-Owned 'Semantica.Domain.DesignAttributes.RelationKind.Owned') with one to many cardinality.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardinality | [Semantica.Domain.DesignAttributes.RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind') |  |
| relationKind | [Semantica.Domain.DesignAttributes.RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind') | Forces [Owned](#F-Semantica-Domain-DesignAttributes-RelationKind-Owned 'Semantica.Domain.DesignAttributes.RelationKind.Owned') and [One](#F-Semantica-Domain-DesignAttributes-RelationKind-One 'Semantica.Domain.DesignAttributes.RelationKind.One'). |

<a name='T-Semantica-Domain-DesignAttributes-DependentEntityAttribute'></a>
## DependentEntityAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a model that represents a particular entity in your domain that is dependent on some principal entity in the same
aggregate.

<a name='T-Semantica-Domain-DesignAttributes-DependentEntityAttribute`1'></a>
## DependentEntityAttribute\`1 `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The main type representing the entity that is the principal for this entity. |

<a name='T-Semantica-Domain-DesignAttributes-DomainKeyAttribute'></a>
## DomainKeyAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a key struct for the domain. If used, the primaryKeyKind argument on the DomainModel attributes that
use the key can be omitted, as long as the interface [IDomainModel\`1](#T-Semantica-Domain-IDomainModel`1 'Semantica.Domain.IDomainModel`1') is implemented by the type.

<a name='T-Semantica-Domain-DesignAttributes-DomainRelationAttribute'></a>
## DomainRelationAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a property that represents a relationship to another domain object.

<a name='T-Semantica-Domain-Electives-Elective'></a>
## Elective `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') properties.

<a name='M-Semantica-Domain-Electives-Elective-Empty``1'></a>
### Empty\`\`1() `method`

##### Summary

Initializes the [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') without a payload.

##### Returns

An empty [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Elective-If``1-System-Boolean,``0-'></a>
### If\`\`1(condition,payload) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') if `condition` is `false`; An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1')
with `payload` otherwise.

##### Returns

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with payload if `condition` is `true`;
[Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| payload | [\`\`0](#T-``0 '``0') | The payload to use if the condition passed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Elective-If``1-System-Func{``0}-'></a>
### If\`\`1(payloadFunc) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') if `payloadFunc` is `null`; Otherwise
`payloadFunc` will be evaluated and the result is used to make an [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') instance.

##### Returns

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with payload if `payloadFunc` is not `null`;
[Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payloadFunc | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function that is evaluated to get the payload. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Elective-If``1-``0-'></a>
### If\`\`1(payload) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') if `payload`.[IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') is
`true`; An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with `payload` otherwise.

##### Returns

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with payload if `payload`.[IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') is
`false`; [Empty\`\`1](#M-Semantica-Domain-Electives-Elective-Empty``1 'Semantica.Domain.Electives.Elective.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload to use if not empty. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Elective-Of``1-``0-'></a>
### Of\`\`1(payload) `method`

##### Summary

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') instance with `payload`.

##### Returns

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Elective-Of``1-``0,Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`1(payload,loadKind) `method`

##### Summary

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') instance with `payload` and a custom [LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind').
[Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added.

##### Returns

An [Elective\`1](#T-Semantica-Domain-Electives-Elective`1 'Semantica.Domain.Electives.Elective`1') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload to use. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPayload | Type of the payload. |

<a name='T-Semantica-Domain-Electives-ElectiveCollection'></a>
## ElectiveCollection `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') properties.

<a name='M-Semantica-Domain-Electives-ElectiveCollection-Empty``2'></a>
### Empty\`\`2() `method`

##### Summary

Initializes the [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') without a payload.

##### Returns

An empty [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TElement | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-ElectiveCollection-If``2-System-Boolean,``0-'></a>
### If\`\`2(condition,payload) `method`

##### Summary

[Empty\`\`2](#M-Semantica-Domain-Electives-ElectiveCollection-Empty``2 'Semantica.Domain.Electives.ElectiveCollection.Empty``2') if `condition` is `false`; An
[ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') with `payload` otherwise.

##### Returns

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') with payload if `condition` is
`true`; [Empty\`\`2](#M-Semantica-Domain-Electives-ElectiveCollection-Empty``2 'Semantica.Domain.Electives.ElectiveCollection.Empty``2') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| payload | [\`\`0](#T-``0 '``0') | The payload to use if the condition passed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TElement | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-ElectiveCollection-If``2-System-Func{``0}-'></a>
### If\`\`2(payloadFunc) `method`

##### Summary

[Empty\`\`2](#M-Semantica-Domain-Electives-ElectiveCollection-Empty``2 'Semantica.Domain.Electives.ElectiveCollection.Empty``2') if `payloadFunc` is `null`; Otherwise
`payloadFunc` will be evaluated and the result is used to make an
[ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') instance.

##### Returns

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') with payload if `payloadFunc` is not
`null`; [Empty\`\`2](#M-Semantica-Domain-Electives-ElectiveCollection-Empty``2 'Semantica.Domain.Electives.ElectiveCollection.Empty``2') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payloadFunc | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function that is evaluated to get the payload. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TElement | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-ElectiveCollection-Of``2-``0,System-Boolean-'></a>
### Of\`\`2(payload,isFiltered) `method`

##### Summary

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') instance with `payload`.

##### Returns

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload to use. |
| isFiltered | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Pass `true` if the collection is filtered; `false` if the collection contains all
existing elements of `TElement` that are associated with the current context. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TElement | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-ElectiveCollection-Of``2-``0,Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`2(payload,loadKind) `method`

##### Summary

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') instance with `payload` and a custom
[LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind'). [Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added.

##### Returns

An [ElectiveCollection\`2](#T-Semantica-Domain-Electives-ElectiveCollection`2 'Semantica.Domain.Electives.ElectiveCollection`2') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [\`\`0](#T-``0 '``0') | The payload to use. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TElement | Type of the elements of the collection. |

<a name='T-Semantica-Domain-Electives-ElectiveCollection`2'></a>
## ElectiveCollection\`2 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') collection type that can be used to wrap the type of a collection that is optionally loaded.
It indicates that it's aggregated onto a domain class from within that entity's aggregate.

Can be implicitly cast to `TCollection` to get it's [Payload](#P-Semantica-Domain-Electives-ElectiveCollection`2-Payload 'Semantica.Domain.Electives.ElectiveCollection`2.Payload').

Using this instead of [Elective](#T-Semantica-Domain-Electives-Elective 'Semantica.Domain.Electives.Elective') can make using the property a bit more streamlined, because of enhanced
[IsEmpty](#M-Semantica-Domain-Electives-ElectiveCollection`2-IsEmpty 'Semantica.Domain.Electives.ElectiveCollection`2.IsEmpty') functionality and [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') implementation, although definition and initialisation
become a bit less concise.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of elements of the collection. |
| TCollection | Type of collection. |

<a name='T-Semantica-Domain-Electives-ElectiveExtensionsX'></a>
## ElectiveExtensionsX `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides additional functionality for classes/structs in electives, that cannot be part of [ElectiveExtensions](#T-Semantica-Domain-Electives-ElectiveExtensions 'Semantica.Domain.Electives.ElectiveExtensions')
because of signature overlap.

##### Remarks

The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
are on a separate class, so this weird thing has to exist.

<a name='T-Semantica-Domain-Electives-ElectiveList'></a>
## ElectiveList `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') properties.

<a name='M-Semantica-Domain-Electives-ElectiveList-Empty``1'></a>
### Empty\`\`1() `method`

##### Summary

Initializes the [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') without a payload.

##### Returns

An empty [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of the elements of the payload. |

<a name='M-Semantica-Domain-Electives-ElectiveList-If``1-System-Boolean,System-Collections-Generic-IReadOnlyList{``0}-'></a>
### If\`\`1(condition,payload) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-ElectiveList-Empty``1 'Semantica.Domain.Electives.ElectiveList.Empty``1') if `condition` is `false`; An
[ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') with `payload` otherwise.

##### Returns

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') with payload if `condition` is `true`;
[Empty\`\`1](#M-Semantica-Domain-Electives-ElectiveList-Empty``1 'Semantica.Domain.Electives.ElectiveList.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| payload | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The payload to use if the condition passed. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of the elements of the payload. |

<a name='M-Semantica-Domain-Electives-ElectiveList-If``1-System-Func{System-Collections-Generic-IReadOnlyList{``0}}-'></a>
### If\`\`1(payloadFunc) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-ElectiveList-Empty``1 'Semantica.Domain.Electives.ElectiveList.Empty``1') if `payloadFunc` is `null`; Otherwise
`payloadFunc` will be evaluated and the result is used to make an [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1')
instance.

##### Returns

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') with payload if `payloadFunc` is not `null`;
[Empty\`\`1](#M-Semantica-Domain-Electives-ElectiveList-Empty``1 'Semantica.Domain.Electives.ElectiveList.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payloadFunc | [System.Func{System.Collections.Generic.IReadOnlyList{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Collections.Generic.IReadOnlyList{``0}}') | The function that is evaluated to get the payload. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of the elements of the payload. |

<a name='M-Semantica-Domain-Electives-ElectiveList-Of``1-System-Collections-Generic-IReadOnlyList{``0},System-Boolean-'></a>
### Of\`\`1(payload,isFiltered) `method`

##### Summary

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') instance with `payload`.

##### Returns

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The payload to use. |
| isFiltered | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Pass `true` if the collection is filtered; `false` if the collection contains all
existing elements of `TElement` that are associated with the current context. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of the elements of the payload. |

<a name='M-Semantica-Domain-Electives-ElectiveList-Of``1-System-Collections-Generic-IReadOnlyList{``0},Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`1(payload,loadKind) `method`

##### Summary

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') instance with `payload` and a custom [LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind').
[Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added.

##### Returns

An [ElectiveList\`1](#T-Semantica-Domain-Electives-ElectiveList`1 'Semantica.Domain.Electives.ElectiveList`1') with `payload` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IReadOnlyList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``0}') | The payload to use. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of the elements of the payload. |

<a name='T-Semantica-Domain-Electives-ElectiveList`1'></a>
## ElectiveList\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') collection type that can be used to wrap a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that is optionally
loaded. It indicates that it's aggregated onto a domain class from within that entity's aggregate.

Implements [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'), delegating all members to the payload.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TElement | Type of elements of the [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'). |

<a name='T-Semantica-Domain-Electives-Elective`1'></a>
## Elective\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') type that can be used to wrap the type of a property or value that is optionally loaded. On
entity types, this indicates that it's assembled onto a domain class from outside that entity's aggregate.

Can be implicitly cast to `T` to get it's [Payload](#P-Semantica-Domain-Electives-Elective`1-Payload 'Semantica.Domain.Electives.Elective`1.Payload').

<a name='T-Semantica-Domain-DesignAttributes-EntityAttribute'></a>
## EntityAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a model that represents a particular entity in your domain.

<a name='T-Semantica-Domain-DesignAttributes-EntityRelationAttribute'></a>
## EntityRelationAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Summary

Indicates a property that contains a reference to other entity objects.

<a name='T-Semantica-Domain-Repositories-IAddRemoveRepository`2'></a>
## IAddRemoveRepository\`2 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

Collection-like interface that provides persistent storage for the entity that is respresented by the provided domain models.
This interface supports only read, add and remove methods, and does not support replacing entities.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | The type of the model class used to represent the entity. |
| TKey | The type used as key of the elements. |

##### Remarks

Use when the same model type is used for add and read methods.

<a name='T-Semantica-Domain-Repositories-IAddRemoveRepository`3'></a>
## IAddRemoveRepository\`3 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
indicated model types.
This interface supports only read, add and remove methods, and does not support replacing entities.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomainAdd | The type of the model class accepted for the Add-methods. |
| TDomain | The type of the model class accepted for the Replace-methods. |
| TKey | The type used as key of the elements. |

##### Remarks

Use when different model types are used for add and read methods.

<a name='T-Semantica-Domain-Repositories-IAddRepository`2'></a>
## IAddRepository\`2 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

An isolated interface providing only the Add-methods of a repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | The type of the model class accepted for the Add-methods. |
| TKey | The type used as key of the entity. |

<a name='M-Semantica-Domain-Repositories-IAddRepository`2-Add-`0-'></a>
### Add(domainModel) `method`

##### Summary

Sets up adding the provided model to the persistent collection as a new entity instance. The persistence isn't finalized
until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed. The method returns a function that will return the
new key after completion of the unitofwork (if the technology supports this).

##### Returns

A function that returns the key of the model, when executed after the unitofwork was completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainModel | [\`0](#T-`0 '`0') | A model representing the new entity instance. If the underlying technology will generate a new key, the domain model
should not contain a (non-empty) primary key. |

<a name='M-Semantica-Domain-Repositories-IAddRepository`2-AddRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### AddRange(domainModels) `method`

##### Summary

Sets up adding the provided collection of models to the persistent collection as a new entity instance. The persistence
isn't finalized until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed. The method returns an enumeration
of functions that will return the new keys after completion of the unitofwork (if the technology supports this).

##### Returns

An enumeration of functions that returns the key of the model, when executed after the unitofwork was completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainModels | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | An enumeration of models representing the new entity instances. If the underlying technology will generate a new key,
the domain models should not contain a (non-empty) primary key. |

<a name='T-Semantica-Domain-IDomainModel`1'></a>
## IDomainModel\`1 `type`

##### Namespace

Semantica.Domain

##### Summary

Implement on any model class that represents a single entity or value object in the domain that has a key, and has been
persisted in the repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the key. |

<a name='T-Semantica-Domain-Electives-IElectiveCollection`2'></a>
## IElectiveCollection\`2 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Indicates an elective (i.e. optionally filled) collection or collection property. An elective property is by default always
not [IsLoaded](#M-Semantica-Domain-Electives-IElective`1-IsLoaded 'Semantica.Domain.Electives.IElective`1.IsLoaded'), and will throw if it's retrieved before it's loaded.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of collection. |
| T | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-IElectiveCollection`2-IsFiltered'></a>
### IsFiltered() `method`

##### Summary

Indicates whether the collection contains all existing values/elements, or if elements have been additionally filtered
when retrieving them.

##### Returns

`true` when during loading the collection is indicated to be complete.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-Electives-IElective`1'></a>
## IElective\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Indicates an elective (i.e. optionally assigned) value or property. An elective property is by default never
[IsLoaded](#M-Semantica-Domain-Electives-IElective`1-IsLoaded 'Semantica.Domain.Electives.IElective`1.IsLoaded'), and will throw if it's retrieved before it's loaded.

Loading in this sense means assigning a value to the property of the entity or value object model that the value belongs to.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the load. |

##### Remarks

When [Payload](#P-Semantica-Domain-Electives-IElective`1-Payload 'Semantica.Domain.Electives.IElective`1.Payload') is retrieved (or [IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') is called) before the elective is loaded, a
[ElectiveNotLoadedException\`1](#T-Semantica-Domain-Electives-ElectiveNotLoadedException`1 'Semantica.Domain.Electives.ElectiveNotLoadedException`1') will be thrown.

It can be used to be able to differentiate at runtime between a property/value not yet being initialized, and it
purposefully set to the default/null value. This will automatically guard for assembly mistakes. It can also be used to
signal to enable or skip further processing.

<a name='P-Semantica-Domain-Electives-IElective`1-LoadKind'></a>
### LoadKind `property`

##### Summary

Contains the [LoadKind](#P-Semantica-Domain-Electives-IElective`1-LoadKind 'Semantica.Domain.Electives.IElective`1.LoadKind') of the assemblage. This property is public so that the unused six bits could be
used to contain extra loading information.

<a name='P-Semantica-Domain-Electives-IElective`1-Payload'></a>
### Payload `property`

##### Summary

Retrieves the payload.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Semantica.Domain.Electives.ElectiveNotLoadedException\`1](#T-Semantica-Domain-Electives-ElectiveNotLoadedException`1 'Semantica.Domain.Electives.ElectiveNotLoadedException`1') | Throws if not yet loaded. |

<a name='M-Semantica-Domain-Electives-IElective`1-IsLoaded'></a>
### IsLoaded() `method`

##### Summary

Indicates if the value has been loaded. i.e. Has the property been assigned on the owning model instance. Regardless of
whether the payload value was default or not.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-Electives-IOwned'></a>
## IOwned `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Indicates an entity type that is the target of an [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') that conveys ownership.

Note that only entities can be owned, and value objects should never be owned. An entity can have only one direct owner.
It can have more owners through transitivity.

<a name='T-Semantica-Domain-Electives-IOwned`1'></a>
## IOwned\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | The entity type that owns this type. |

<a name='P-Semantica-Domain-Electives-IOwned`1-Owner'></a>
### Owner `property`

##### Summary

When loaded, contains a reference to the owning entity.

<a name='T-Semantica-Domain-Repositories-IReadRepository`2'></a>
## IReadRepository\`2 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

An isolated interface providing only the read methods of a repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | The type of the returned model class. |
| TKey | The type used as key of the elements. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-Contains-`1-'></a>
### Contains(key) `method`

##### Summary

Determines whether the persistent collection contains an entity instance corresponding to the provided key.

##### Returns

`true` if the persistent collection the key; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`1](#T-`1 '`1') | A key to look up. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-ContainsAsync-`1,System-Threading-CancellationToken-'></a>
### ContainsAsync(key,cancellationToken) `method`

##### Summary

Determines whether the persistent collection contains an element corresponding to the provided key.

##### Returns

`true` if the persistent collection the key; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`1](#T-`1 '`1') | A key to look up. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken to observe while waiting for the task to complete. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-GetAllAsync-System-Threading-CancellationToken-'></a>
### GetAllAsync(cancellationToken) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken to observe while waiting for the task to complete. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-GetAsync-`1,System-Threading-CancellationToken-'></a>
### GetAsync(key,cancellationToken) `method`

##### Summary

Returns models retrieved from the persistent collection corresponding to the provided key.

##### Returns

Returns the model corresponding to the; `null` if no such element is found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`1](#T-`1 '`1') | A key to look up. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken to observe while waiting for the task to complete. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-GetListAsync-System-Collections-Generic-IEnumerable{`1},System-Threading-CancellationToken-'></a>
### GetListAsync(keys,cancellationToken) `method`

##### Summary

Zoekt alle `TDomain` modellen op in de Repository die matchen aan de `keys`.
Sleutels die niet zijn gevonden worden niet in de lijst opgenomen.
Deze methode kan niet worden uitgevoert als `TKey` een samengestelde sleutel is.

##### Returns

Een lijst van alle gevonden `TDomain` modellen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Collections.Generic.IEnumerable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`1}') | Een lijst met unieke sleutels. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken to observe while waiting for the task to complete. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Als `TKey` een samengestelde sleutel is. |

<a name='M-Semantica-Domain-Repositories-IReadRepository`2-GetListInMatchingOrderAsync-System-Collections-Generic-IEnumerable{`1},System-Threading-CancellationToken-'></a>
### GetListInMatchingOrderAsync(keys,cancellationToken) `method`

##### Summary

Zoekt alle `TDomain` modellen op in de Repository die matchen aan de `keys`.
De lijst is Sleutels die niet zijn gevonden worden niet in de lijst opgenomen.

##### Returns

Een lijst van alle gevonden `TDomain` modellen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Collections.Generic.IEnumerable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`1}') | Een lijst met unieke sleutels. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A CancellationToken to observe while waiting for the task to complete. |

<a name='T-Semantica-Domain-Repositories-IRemoveRepository`1'></a>
## IRemoveRepository\`1 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

An isolated interface providing onlt the Remove-methods of a repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type used as key of the elements. |

<a name='M-Semantica-Domain-Repositories-IRemoveRepository`1-Remove-`0-'></a>
### Remove(key) `method`

##### Summary

Sets up removing the entity instance corresponding to the provided key from the persistent collection. The persistence
isn't finalized until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [\`0](#T-`0 '`0') | A key representing the element instance to be removed. |

<a name='M-Semantica-Domain-Repositories-IRemoveRepository`1-RemoveRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### RemoveRange(keys) `method`

##### Summary

Sets up removing the entity instances corresponding to the provided keys from the persistent collection. The persistence
isn't finalized until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | An enumeration of keys representing the element instances to be removed. |

<a name='T-Semantica-Domain-Repositories-IReplaceRepository`2'></a>
## IReplaceRepository\`2 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

An isolated interface providing only the Replace-methods of a repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | The type of the model class accepted for the Replace-methods. |
| TKey | The type used as key of the elements. |

<a name='M-Semantica-Domain-Repositories-IReplaceRepository`2-Replace-`0-'></a>
### Replace(domainModel) `method`

##### Summary

Sets up replacing the current entity instance in the persistent collection with the provided model. The persistence
isn't finalized until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainModel | [\`0](#T-`0 '`0') | A model representing the entity instance to replace. |

<a name='M-Semantica-Domain-Repositories-IReplaceRepository`2-ReplaceRange-System-Collections-Generic-IEnumerable{`0}-'></a>
### ReplaceRange(domainModels) `method`

##### Summary

Sets up replacing the current entity instances in the persistent collection with the provided models. The persistence
isn't finalized until the current [IUnitOfWork](#T-Semantica-Domain-IUnitOfWork 'Semantica.Domain.IUnitOfWork') is completed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainModels | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | An enumeration of models representing the entity instance to replace. |

<a name='T-Semantica-Domain-Repositories-IRepository`2'></a>
## IRepository\`2 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
indicated model types.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomain | The type of the model class used to represent the entity. |
| TKey | The type used as key of the elements. |

##### Remarks

Use when the same model type is used for add, replace and read methods.

<a name='T-Semantica-Domain-Repositories-IRepository`3'></a>
## IRepository\`3 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
indicated model types.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomainAdd | The type of the model class accepted for the Add-methods. |
| TDomain | The type of the model class returned from the Get-methods and accepted for the Replace-methods. |
| TKey | The type used as key of the elements. |

##### Remarks

Use when one model type is used for adds and another for replace and read methods.

<a name='T-Semantica-Domain-Repositories-IRepository`4'></a>
## IRepository\`4 `type`

##### Namespace

Semantica.Domain.Repositories

##### Summary

Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
indicated model types.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TDomainAdd | The type of the model class accepted for the Add-methods. |
| TDomainReplace | The type of the model class accepted for the Replace-methods. |
| TDomainOut | The type of the model class returned from the Get-methods. |
| TKey | The type used as key of the elements. |

##### Remarks

Use when different model types are used for add, replace and read methods.

<a name='T-Semantica-Domain-ISimpleDomainModel`1'></a>
## ISimpleDomainModel\`1 `type`

##### Namespace

Semantica.Domain

##### Summary

Implement on any model class that represents a single entity or value object in the domain that has a simple key (i.e. the
key is not [Composite](#F-Semantica-Domain-DesignAttributes-KeyKind-Composite 'Semantica.Domain.DesignAttributes.KeyKind.Composite').), and has been persisted in the repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the simple key. |

<a name='T-Semantica-Domain-ISubEntity`2'></a>
## ISubEntity\`2 `type`

##### Namespace

Semantica.Domain

##### Summary

Implement on a model class that represents an entity that shares identity with a principal entity, but uses a different key
type for differentiation, but that type only contains the key of the principal entity. The relation of this entity to its
principal should be zero-or-one to one. When this is all the case, we call the dependent entity a subentity. Only relevant
for model classes that have been persisted in the repository.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSubKey | Key type of the sub entity. |
| TPrincipalKey | Key type of the principal entity that is contained in the subkey. |

<a name='T-Semantica-Domain-DesignAttributes-KeyKind'></a>
## KeyKind `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Describes the kind of a key type or property.

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Composite'></a>
### Composite `constants`

##### Summary

A key made from at least two attributes.

A value of 0 for this flag means the key is a Simple key (or a Concatenated key, which is functionally equivalent).

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Foreign'></a>
### Foreign `constants`

##### Summary

A key that has migrated to another entity.

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-ForeignId'></a>
### ForeignId `constants`

##### Summary

Typical for an entity with a one-to-zero-or-one relationship with it's principal.

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Guid'></a>
### Guid `constants`

##### Summary

The value of the key is a single [Guid](#F-Semantica-Domain-DesignAttributes-KeyKind-Guid 'Semantica.Domain.DesignAttributes.KeyKind.Guid'). Invalid for [Composite](#F-Semantica-Domain-DesignAttributes-KeyKind-Composite 'Semantica.Domain.DesignAttributes.KeyKind.Composite') keys. Mutually exclusive with [Integer](#F-Semantica-Domain-DesignAttributes-KeyKind-Integer 'Semantica.Domain.DesignAttributes.KeyKind.Integer').

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Id'></a>
### Id `constants`

##### Summary

Typical identity (ID)

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Integer'></a>
### Integer `constants`

##### Summary

The value of the key is a single integer. Invalid for [Composite](#F-Semantica-Domain-DesignAttributes-KeyKind-Composite 'Semantica.Domain.DesignAttributes.KeyKind.Composite') keys. Mutually exclusive with [Guid](#F-Semantica-Domain-DesignAttributes-KeyKind-Guid 'Semantica.Domain.DesignAttributes.KeyKind.Guid').

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Natural'></a>
### Natural `constants`

##### Summary

A value of 0 for this flag means the key is a Surrogate key

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Primary'></a>
### Primary `constants`

##### Summary

The key that is selected as the primary key. Only one key within an entity is selected to be the primary key. This is the key that is allowed to migrate to other entities to define the relationships that exist among the entities.

A value of 0 for this flag means the key is an Alternate key.

<a name='F-Semantica-Domain-DesignAttributes-KeyKind-Unique'></a>
### Unique `constants`

##### Summary

Indicates a (unique) key of it's entity or in the current context. Can only be 0 for _properties_ that are (foreign)
references that represent many-to-one relationships

<a name='T-Semantica-Domain-DesignAttributes-LinkAttribute'></a>
## LinkAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Summary

Indicates a property that contains a reference to a linked entity that is in a different aggregate.

<a name='M-Semantica-Domain-DesignAttributes-LinkAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind-'></a>
### #ctor() `constructor`

##### Summary

Default relation is [Forward](#F-Semantica-Domain-DesignAttributes-RelationKind-Forward 'Semantica.Domain.DesignAttributes.RelationKind.Forward') with zero-or-more to zero-or-one cardinality.

##### Parameters

This constructor has no parameters.

<a name='T-Semantica-Domain-Electives-LoadKind'></a>
## LoadKind `type`

##### Namespace

Semantica.Domain.Electives

<a name='F-Semantica-Domain-Electives-LoadKind-Loaded'></a>
### Loaded `constants`

##### Summary

Flag that indicates whether the elective property has been assigned (loaded).

<a name='F-Semantica-Domain-Electives-LoadKind-Unfiltered'></a>
### Unfiltered `constants`

##### Summary

Flag that indicates whether the elective collection contains all associated elements from the system, and is not
additionally filtered.

<a name='T-Semantica-Domain-DesignAttributes-ModelAttribute'></a>
## ModelAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates any model. Purpose is defined by the [ModelPurpose](#T-Semantica-Domain-DesignAttributes-ModelPurpose 'Semantica.Domain.DesignAttributes.ModelPurpose') property.

<a name='P-Semantica-Domain-DesignAttributes-ModelAttribute-ModuleName'></a>
### ModuleName `property`

##### Summary

Optional. The name of the module that the model is considered to be part of.

<a name='P-Semantica-Domain-DesignAttributes-ModelAttribute-PrimaryKeyKind'></a>
### PrimaryKeyKind `property`

##### Summary

Type of primary key used for the entity. If a specific struct is used for the key in [IDomainModel\`1](#T-Semantica-Domain-IDomainModel`1 'Semantica.Domain.IDomainModel`1'),
and that key has a [DomainKeyAttribute](#T-Semantica-Domain-DesignAttributes-DomainKeyAttribute 'Semantica.Domain.DesignAttributes.DomainKeyAttribute'), this value is ignored, and the value indicated in that attribute is
used instead.

<a name='P-Semantica-Domain-DesignAttributes-ModelAttribute-Purpose'></a>
### Purpose `property`

##### Summary

A flags enum of type [ModelPurpose](#T-Semantica-Domain-DesignAttributes-ModelPurpose 'Semantica.Domain.DesignAttributes.ModelPurpose') that indicates what the model represents, and where and how it is used.

<a name='T-Semantica-Domain-DesignAttributes-ModelPurpose'></a>
## ModelPurpose `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Describes the purpose of a model in the solution, be describing what it represents (entity, value object, view), where it's
used (domain layer, storage(/persistence) layer, application layer), what kind of model it is (isolation or aggregation),
and what it's usage is (reading/adding/replacing)

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Add'></a>
### Add `constants`

##### Summary

Model is used for adding new elements to the repository. In principal, these models should always be
[Isolation](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Isolation 'Semantica.Domain.DesignAttributes.ModelPurpose.Isolation') models.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Application'></a>
### Application `constants`

##### Summary

Model is made for use in the Application layer (what would generally be called a ViewModel in the MVC/MVVM patterns).

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Domain'></a>
### Domain `constants`

##### Summary

Model is made for use in the Domain layer.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Entity'></a>
### Entity `constants`

##### Summary

Model represents an entity in your domain. If this flag is not set, and neither is [View](#F-Semantica-Domain-DesignAttributes-ModelPurpose-View 'Semantica.Domain.DesignAttributes.ModelPurpose.View'), the model
represents a value object.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Get'></a>
### Get `constants`

##### Summary

Model is used for getting (reading) elements/data from the repository or inventory.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Isolation'></a>
### Isolation `constants`

##### Summary

Model is meant for use in repositories. i.e. (generally) does not have properties referencing other entity models
(outside of sub entities), such relations are represented by a foreign key property instead. If this flag is omitted,
the model is considered an aggregation model.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Replace'></a>
### Replace `constants`

##### Summary

Model is used for replacing existing elements in the repository. In principal, these models should always be
[Isolation](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Isolation 'Semantica.Domain.DesignAttributes.ModelPurpose.Isolation') models.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Repository'></a>
### Repository `constants`

##### Summary

Combined flag: Model is used in the repository for read, add and replace methods.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-Storage'></a>
### Storage `constants`

##### Summary

Model is made for use in the Storage layer.

<a name='F-Semantica-Domain-DesignAttributes-ModelPurpose-View'></a>
### View `constants`

##### Summary

Model is a subset of the properties of an entity (if [Entity](#F-Semantica-Domain-DesignAttributes-ModelPurpose-Entity 'Semantica.Domain.DesignAttributes.ModelPurpose.Entity') flag is set), or of/derived drom multiple
entities or aggregation of entities.

<a name='T-Semantica-Domain-Electives-Owned'></a>
## Owned `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') properties.

<a name='M-Semantica-Domain-Electives-Owned-Empty``1'></a>
### Empty\`\`1() `method`

##### Summary

Initializes the [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') without a payload.

##### Returns

An empty [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |

<a name='M-Semantica-Domain-Electives-Owned-If``2-System-Boolean,``1,``0-'></a>
### If\`\`2(condition,owned,owner) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') if `condition` is `false`; An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1')
with `owned` otherwise. [Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner') property on `owned`
will be set.

##### Returns

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with payload if `condition` is `true`;
[Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| owned | [\`\`1](#T-``1 '``1') | The payload to use if the condition passed. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |
| TOwner | Type of the owner. |

<a name='M-Semantica-Domain-Electives-Owned-If``2-System-Func{``1},``0-'></a>
### If\`\`2(ownedFunc,owner) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') if `ownedFunc` is `null`; Otherwise
`ownedFunc` will be evaluated and the result is used to make an [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') instance.
[Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner') property on the owned instance will be set.

##### Returns

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with payload if `ownedFunc` is not `null`;
[Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ownedFunc | [System.Func{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1}') | The function that is evaluated to get the payload. |
| owner | [\`\`0](#T-``0 '``0') | Owner of owned result instance. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |
| TOwner | Type of the owner. |

<a name='M-Semantica-Domain-Electives-Owned-If``2-``1,``0-'></a>
### If\`\`2(owned,owner) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') if `owned`.[IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') is
`true`; An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with `owned` otherwise. [Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner')
property on `owned` will be set.

##### Returns

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with payload if `owned`.[IsEmpty](#M-Semantica-Patterns-ICanBeEmpty-IsEmpty 'Semantica.Patterns.ICanBeEmpty.IsEmpty') is
`false`; [Empty\`\`1](#M-Semantica-Domain-Electives-Owned-Empty``1 'Semantica.Domain.Electives.Owned.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [\`\`1](#T-``1 '``1') | The payload to use if not empty. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |
| TOwner | Type of the owner. |

<a name='M-Semantica-Domain-Electives-Owned-Of``2-``1,``0-'></a>
### Of\`\`2(owned,owner) `method`

##### Summary

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') instance with `owned`. [Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner') property on
`owned` will be set.

##### Returns

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [\`\`1](#T-``1 '``1') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |
| TOwner | Type of the owner. |

<a name='M-Semantica-Domain-Electives-Owned-Of``2-``1,``0,Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`2(owned,owner,loadKind) `method`

##### Summary

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') instance with `owned` and a custom [LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind').
[Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added. [Owner](#P-Semantica-Domain-Electives-IOwned`1-Owner 'Semantica.Domain.Electives.IOwned`1.Owner') property on `owned`
will be set.

##### Returns

An [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [\`\`1](#T-``1 '``1') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the payload. |
| TOwner | Type of the owner. |

<a name='T-Semantica-Domain-Electives-OwnedCollection'></a>
## OwnedCollection `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') properties.

<a name='M-Semantica-Domain-Electives-OwnedCollection-Empty``2'></a>
### Empty\`\`2() `method`

##### Summary

Initializes the [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') without a payload.

##### Returns

An empty [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of the collection payload. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedCollection-If``3-System-Boolean,``1,``0-'></a>
### If\`\`3(condition,owned,owner) `method`

##### Summary

[Empty\`\`2](#M-Semantica-Domain-Electives-OwnedCollection-Empty``2 'Semantica.Domain.Electives.OwnedCollection.Empty``2') if `condition` is `false`; An
[OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` otherwise.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with payload if `condition` is
`true`; [Empty\`\`2](#M-Semantica-Domain-Electives-OwnedCollection-Empty``2 'Semantica.Domain.Electives.OwnedCollection.Empty``2') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| owned | [\`\`1](#T-``1 '``1') | The payload to use if the condition passed. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TCollection | Type of the collection payload. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedCollection-If``3-System-Func{``1},``0-'></a>
### If\`\`3(ownedFunc,owner) `method`

##### Summary

[Empty\`\`2](#M-Semantica-Domain-Electives-OwnedCollection-Empty``2 'Semantica.Domain.Electives.OwnedCollection.Empty``2') if `ownedFunc` is `null`; Otherwise
`ownedFunc` will be evaluated and the result is used to make an
[OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with payload if `ownedFunc` is not
`null`; [Empty\`\`2](#M-Semantica-Domain-Electives-OwnedCollection-Empty``2 'Semantica.Domain.Electives.OwnedCollection.Empty``2') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ownedFunc | [System.Func{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1}') | The function that is evaluated to get the payload. |
| owner | [\`\`0](#T-``0 '``0') | Owner of result of `ownedFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TCollection | Type of the collection payload. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedCollection-Of``3-``1,``0,System-Boolean-'></a>
### Of\`\`3(owned,owner,isFiltered) `method`

##### Summary

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance with `owned`.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [\`\`1](#T-``1 '``1') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |
| isFiltered | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Pass `true` if the collection is filtered; `false` if the collection contains all
existing elements of `TOwned` that are associated with the current context. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TCollection | Type of the collection payload. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedCollection-Of``3-``1,``0,Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`3(owned,owner,loadKind) `method`

##### Summary

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance with `owned` and a custom
[LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind'). [Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [\`\`1](#T-``1 '``1') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TCollection | Type of the collection payload. |
| TOwned | Type of the elements of the collection. |

<a name='T-Semantica-Domain-Electives-OwnedCollection`2'></a>
## OwnedCollection\`2 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') collection type that can be used to wrap the type of a collection that is optionally loaded.
It indicates that it's aggregated onto a domain class from within that entity's aggregate.

Can be implicitly cast to `TCollection` to get it's [Payload](#P-Semantica-Domain-Electives-OwnedCollection`2-Payload 'Semantica.Domain.Electives.OwnedCollection`2.Payload').

Using this instead of [Owned\`1](#T-Semantica-Domain-Electives-Owned`1 'Semantica.Domain.Electives.Owned`1') can make using the property a bit more streamlined, because of enhanced
[IsEmpty](#M-Semantica-Domain-Electives-OwnedCollection`2-IsEmpty 'Semantica.Domain.Electives.OwnedCollection`2.IsEmpty') functionality and [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') implementation, although definition and initialisation
become a bit less concise.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCollection | Type of collection. |
| TOwned | Type of elements of the collection. |

<a name='T-Semantica-Domain-Electives-OwnedList'></a>
## OwnedList `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

Provides static methods to initialize [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') properties.

<a name='M-Semantica-Domain-Electives-OwnedList-Empty``1'></a>
### Empty\`\`1() `method`

##### Summary

Initializes the [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') without a payload.

##### Returns

An empty [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedList-If``2-System-Boolean,System-Collections-Generic-IReadOnlyList{``1},``0-'></a>
### If\`\`2(condition,owned,owner) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-OwnedList-Empty``1 'Semantica.Domain.Electives.OwnedList.Empty``1') if `condition` is `false`; An
[OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` otherwise.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with payload if `condition` is
`true`; [Empty\`\`1](#M-Semantica-Domain-Electives-OwnedList-Empty``1 'Semantica.Domain.Electives.OwnedList.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| owned | [System.Collections.Generic.IReadOnlyList{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``1}') | The payload to use if the condition passed. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedList-If``2-System-Func{System-Collections-Generic-IReadOnlyList{``1}},``0-'></a>
### If\`\`2(ownedFunc,owner) `method`

##### Summary

[Empty\`\`1](#M-Semantica-Domain-Electives-OwnedList-Empty``1 'Semantica.Domain.Electives.OwnedList.Empty``1') if `ownedFunc` is `null`; Otherwise
`ownedFunc` will be evaluated and the result is used to make an
[OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with payload if `ownedFunc` is not
`null`; [Empty\`\`1](#M-Semantica-Domain-Electives-OwnedList-Empty``1 'Semantica.Domain.Electives.OwnedList.Empty``1') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ownedFunc | [System.Func{System.Collections.Generic.IReadOnlyList{\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Collections.Generic.IReadOnlyList{``1}}') | The function that is evaluated to get the payload. |
| owner | [\`\`0](#T-``0 '``0') | Owner of result of `ownedFunc`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedList-Of``2-System-Collections-Generic-IReadOnlyList{``1},``0,System-Boolean-'></a>
### Of\`\`2(owned,owner,isFiltered) `method`

##### Summary

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance with `owned`.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [System.Collections.Generic.IReadOnlyList{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``1}') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |
| isFiltered | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Pass `true` if the collection is filtered; `false` if the collection contains all
existing elements of `TOwned` that are associated with the current context. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TOwned | Type of the elements of the collection. |

<a name='M-Semantica-Domain-Electives-OwnedList-Of``2-System-Collections-Generic-IReadOnlyList{``1},``0,Semantica-Domain-Electives-LoadKind-'></a>
### Of\`\`2(owned,owner,loadKind) `method`

##### Summary

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') instance with `owned` and a custom
[LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind'). [Loaded](#F-Semantica-Domain-Electives-LoadKind-Loaded 'Semantica.Domain.Electives.LoadKind.Loaded') flag is always added.

##### Returns

An [OwnedCollection\`2](#T-Semantica-Domain-Electives-OwnedCollection`2 'Semantica.Domain.Electives.OwnedCollection`2') with `owned` loaded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owned | [System.Collections.Generic.IReadOnlyList{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList 'System.Collections.Generic.IReadOnlyList{``1}') | The payload to use. |
| owner | [\`\`0](#T-``0 '``0') | Owner of `owned`. |
| loadKind | [Semantica.Domain.Electives.LoadKind](#T-Semantica-Domain-Electives-LoadKind 'Semantica.Domain.Electives.LoadKind') | The flags value to use. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwner | Type of the owner. |
| TOwned | Type of the elements of the collection. |

<a name='T-Semantica-Domain-Electives-OwnedList`1'></a>
## OwnedList\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') collection type that can be used to wrap a [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1') that is optionally
loaded. It indicates that it's aggregated onto a domain class from within that entity's aggregate.

Implements [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'), delegating all members to the payload.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned | Type of elements of the [IReadOnlyList\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyList`1 'System.Collections.Generic.IReadOnlyList`1'). |

<a name='T-Semantica-Domain-Electives-Owned`1'></a>
## Owned\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') type that can be used to wrap a reference to another domain entity that is optionally loaded.
It represents a  It indicates that it's aggregated onto a domain class from within that entity's aggregate.

Can be implicitly cast to `TOwned` to get it's [Payload](#P-Semantica-Domain-Electives-Owned`1-Payload 'Semantica.Domain.Electives.Owned`1.Payload').

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TOwned |  |

<a name='T-Semantica-Domain-DesignAttributes-OwnerAttribute'></a>
## OwnerAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Summary

Indicates a property that contains a reference to the owning entity object.

<a name='M-Semantica-Domain-DesignAttributes-OwnerAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind-'></a>
### #ctor(relationKind) `constructor`

##### Summary

Default relation is [Owner](#F-Semantica-Domain-DesignAttributes-RelationKind-Owner 'Semantica.Domain.DesignAttributes.RelationKind.Owner') with zero-or-more to one cardinality.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relationKind | [Semantica.Domain.DesignAttributes.RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind') | Forces [Owner](#F-Semantica-Domain-DesignAttributes-RelationKind-Owner 'Semantica.Domain.DesignAttributes.RelationKind.Owner') and [ToOne](#F-Semantica-Domain-DesignAttributes-RelationKind-ToOne 'Semantica.Domain.DesignAttributes.RelationKind.ToOne'). |

<a name='T-Semantica-Domain-Electives-Owner`1'></a>
## Owner\`1 `type`

##### Namespace

Semantica.Domain.Electives

##### Summary

*Inherit from parent.*

##### Summary

An [IElective\`1](#T-Semantica-Domain-Electives-IElective`1 'Semantica.Domain.Electives.IElective`1') type that can be used to wrap the type of a property or value that is optionally loaded. It
indicates that it's Owner onto a domain class from outside that entity's aggregate.

Can be implicitly cast to `T` to get it's [Payload](#P-Semantica-Domain-Electives-Owner`1-Payload 'Semantica.Domain.Electives.Owner`1.Payload').

##### Remarks

[GetHashCode](#M-Semantica-Domain-Electives-Owner`1-GetHashCode 'Semantica.Domain.Electives.Owner`1.GetHashCode') implementation does not use payload, DO NOT USE AS DICTIONARY KEY OR IN HASHSET

<a name='M-Semantica-Domain-Electives-Owner`1-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Hashcode only calculated on loadkind to avoid recursive calls in records.

##### Parameters

This method has no parameters.

<a name='T-Semantica-Domain-DesignAttributes-RelationKind'></a>
## RelationKind `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Specifies the cardinality and other attributes of a relationship.

##### Remarks

If the cardinality of a side is not specified, it's Zero-or-One. If both flags of a side are 1, interpret it as One-or-More.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-Forward'></a>
### Forward `constants`

##### Summary

Without the [Ownership](#F-Semantica-Domain-DesignAttributes-RelationKind-Ownership 'Semantica.Domain.DesignAttributes.RelationKind.Ownership') flag set, setting this flag means the target will never reference back, and it's
(potentially) bidirectional otherwise.
With the [Ownership](#F-Semantica-Domain-DesignAttributes-RelationKind-Ownership 'Semantica.Domain.DesignAttributes.RelationKind.Ownership') flag set it means the relation points towards the owner.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-ManyToOne'></a>
### ManyToOne `constants`

##### Summary

Specifies a Zero-Or-More to One relationship cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-More'></a>
### More `constants`

##### Summary

Specifies the left side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-One'></a>
### One `constants`

##### Summary

Specifies the left side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-OneOrMore'></a>
### OneOrMore `constants`

##### Summary

Specifies the left side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-OneToMany'></a>
### OneToMany `constants`

##### Summary

Specifies a One to Zero-Or-More relationship cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-Owned'></a>
### Owned `constants`

##### Summary

Indicates a relationship property on an entity that points to the owned.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-OwnedValueObject'></a>
### OwnedValueObject `constants`

##### Summary

Indicates that the target of this relationship is an owned value object.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-Owner'></a>
### Owner `constants`

##### Summary

Indicates a relationship property that points to the owner entity.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-Ownership'></a>
### Ownership `constants`

##### Summary

Setting this flag implies the relationship conveys ownership. [Forward](#F-Semantica-Domain-DesignAttributes-RelationKind-Forward 'Semantica.Domain.DesignAttributes.RelationKind.Forward') flag determines direction.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-ToMore'></a>
### ToMore `constants`

##### Summary

Specifies the right side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-ToOne'></a>
### ToOne `constants`

##### Summary

Specifies the right side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-ToOneOrMore'></a>
### ToOneOrMore `constants`

##### Summary

Specifies the right side of the cardinality.

<a name='F-Semantica-Domain-DesignAttributes-RelationKind-ValueObject'></a>
### ValueObject `constants`

##### Summary

Indicates that the target of this relationship is a value object, not an entity. Note that a value object is normally
always [Owner](#F-Semantica-Domain-DesignAttributes-RelationKind-Owner 'Semantica.Domain.DesignAttributes.RelationKind.Owner'), and never (flag is illegal/ignored if) [Owned](#F-Semantica-Domain-DesignAttributes-RelationKind-Owned 'Semantica.Domain.DesignAttributes.RelationKind.Owned').

<a name='T-Semantica-Domain-DesignAttributes-ValueAttribute'></a>
## ValueAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Summary

Indicates a property that contains the references of one or a collection of value objects.

<a name='M-Semantica-Domain-DesignAttributes-ValueAttribute-#ctor-Semantica-Domain-DesignAttributes-RelationKind,Semantica-Domain-DesignAttributes-RelationKind-'></a>
### #ctor(cardinality,relationKind) `constructor`

##### Summary

Default relation is [OwnedValueObject](#F-Semantica-Domain-DesignAttributes-RelationKind-OwnedValueObject 'Semantica.Domain.DesignAttributes.RelationKind.OwnedValueObject'), (To-) cardinality has to be specified. Left
cardinality is always [One](#F-Semantica-Domain-DesignAttributes-RelationKind-One 'Semantica.Domain.DesignAttributes.RelationKind.One').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cardinality | [Semantica.Domain.DesignAttributes.RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind') | Used to specify the right (to) side of the cardinality. |
| relationKind | [Semantica.Domain.DesignAttributes.RelationKind](#T-Semantica-Domain-DesignAttributes-RelationKind 'Semantica.Domain.DesignAttributes.RelationKind') | Forces [OwnedValueObject](#F-Semantica-Domain-DesignAttributes-RelationKind-OwnedValueObject 'Semantica.Domain.DesignAttributes.RelationKind.OwnedValueObject') and [One](#F-Semantica-Domain-DesignAttributes-RelationKind-One 'Semantica.Domain.DesignAttributes.RelationKind.One'). |

<a name='T-Semantica-Domain-DesignAttributes-ValueObjectAttribute'></a>
## ValueObjectAttribute `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

Indicates a model that represents a particular value object in your domain.

<a name='T-Semantica-Domain-DesignAttributes-ValueObjectAttribute`1'></a>
## ValueObjectAttribute\`1 `type`

##### Namespace

Semantica.Domain.DesignAttributes

##### Summary

*Inherit from parent.*

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The main type representing the entity that is the owner for this value object. |
