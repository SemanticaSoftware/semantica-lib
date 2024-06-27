#nullable enable
using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Extensions;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage.Models;
using Semantica.Storage;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Data;

class SimpleRootRepository
    : RepositoryBase<SimpleRootStorage, SimpleRootAddModel, SimpleRootReplaceModel, SimpleRootIsolationModel, SimpleRootKey>, ISimpleRootRepository
{
    public SimpleRootRepository(
        ISimpleRootDataStore dataStore,
        ISimpleRootConverter converter,
        IPropertyAnalyser analyser) : base(dataStore, converter, analyser)
    {
    }
}

interface ISimpleRootConverter : IDomainStorageConverter<SimpleRootStorage, SimpleRootAddModel, SimpleRootReplaceModel, SimpleRootIsolationModel, SimpleRootKey>, 
    IAggregationStorageConverter<SimpleRootStorage, SimpleRootModel>
{
}

interface IFirstSubConverter : IDomainConverter<FirstSubStorage, FirstSubIsolationModel>,
    IStorageConverter<FirstSubStorage, FirstSubIsolationModel, SimpleRootKey>,
    IAggregationStorageConverter<FirstSubStorage, FirstSubModel>
{
}

interface ISecondSubConverter : IDomainConverter<SecondSubStorage, SecondSubModel>,
    IStorageConverter<SecondSubStorage, SecondSubModel, SecondSubKey>
{
}

class SimpleRootKeyConverter : IKeyConverter<SimpleRootStorage, SimpleRootKey>
{
    public SimpleRootKey ToKey(SimpleRootStorage storageModel) => new SimpleRootKey(storageModel.Id);

    public SimpleRootStorage ToBlankStorageModel(SimpleRootKey key) => new SimpleRootStorage() { Id = key.Id };
}

class SimpleRootConverter
    : SimpleRootKeyConverter, ISimpleRootConverter
        , ICommonPropertyDomainConverter<SimpleRootStorage, ISimpleRootModel>
        , ICommonPropertyStorageConverter<SimpleRootStorage, ISimpleRootModel>
{
    private readonly IFirstSubConverter _firstSubConverter;

    public SimpleRootConverter(IFirstSubConverter firstSubConverter)
    {
        _firstSubConverter = firstSubConverter;
    }

    public SimpleRootModel ToAggregation(SimpleRootStorage storageModel)
    {
        var domainModel = new SimpleRootModel() {
            Key = ToKey(storageModel), Progression = storageModel.Progression, TimeStamp = storageModel.TimeStamp,
            FirstSub = storageModel.FirstSub.IfNotNull(_firstSubConverter.ToAggregation)
        };
        SetCommonDomainProperties(domainModel, storageModel);
        return domainModel;
    }

    public SimpleRootIsolationModel ToDomain(SimpleRootStorage storageModel)
    {
        var domainModel = new SimpleRootIsolationModel() {
            Key = ToKey(storageModel), 
            Progression = storageModel.Progression, 
            TimeStamp = storageModel.TimeStamp,
            FirstSub = storageModel.FirstSub.IfNotNull(_firstSubConverter.ToDomain)
        };
        SetCommonDomainProperties(domainModel, storageModel);
        return domainModel;
    }

    public SimpleRootStorage ToStorage(SimpleRootAddModel domainModel)
    {
        var storageModel = ToBlankStorageModel(default);
        storageModel.TimeStamp = domainModel.TimeStamp;
        storageModel.FirstSub = domainModel.FirstSub.IfNotNull(_firstSubConverter.ToStorage);
        SetCommonStorageProperties(storageModel, domainModel);
        return storageModel;
    }

    public SimpleRootStorage ToStorage(SimpleRootReplaceModel domainModel)
    {
        var storageModel = ToBlankStorageModel(default);
        storageModel.Logs = new[] {
            new LogStorage() { UserName = domainModel.LogUserName, TimeStamp = domainModel.LogTimeStamp }
        };
        SetCommonStorageProperties(storageModel, domainModel);
        return storageModel;
    }

    public void SetCommonStorageProperties(SimpleRootStorage storageModel, ISimpleRootModel domainModel)
    {
        storageModel.Value = domainModel.Value;
    }

    public void SetCommonDomainProperties(ISimpleRootModel domainModel, SimpleRootStorage storageModel)
    {
        domainModel.Value = storageModel.Value;
    }
}

class FirstSubConverter : IFirstSubConverter
{
    private readonly ISecondSubConverter _secondSubConverter;
    
    public FirstSubConverter(ISecondSubConverter secondSubConverter) { _secondSubConverter = secondSubConverter; }

    public FirstSubStorage ToStorage(FirstSubIsolationModel domainModel)
    {
        var storageModel = new FirstSubStorage() {
            Id = domainModel.Key.Id,
            Guid = domainModel.GuidKey.NullOnEmpty(),
            Value = domainModel.Value,
            SecondSub = domainModel.SecondSub.IfNotNull(_secondSubConverter.ToStorage)
        };
        return storageModel;
    }

    public FirstSubIsolationModel ToDomain(FirstSubStorage storageModel)
    {
        var domainModel = new FirstSubIsolationModel(new SimpleRootKey(storageModel.Id)) {
            Value = storageModel.Value,
            GuidKey = storageModel.Guid ?? Guid.Empty,
            SecondSub = storageModel.SecondSub.IfNotNull(_secondSubConverter.ToDomain)
        };
        return domainModel;
    }

    public FirstSubModel ToAggregation(FirstSubStorage storageModel) 
    {
        var domainModel = new FirstSubModel(new SimpleRootKey(storageModel.Id)) {
            Value = storageModel.Value,
            GuidKey = storageModel.Guid ?? Guid.Empty,
            SecondSub = storageModel.SecondSub.IfNotNull(_secondSubConverter.ToDomain)
        };
        return domainModel;
    }
}

class SecondSubConverter : ISecondSubConverter
{
    public SecondSubStorage ToStorage(SecondSubModel domainModel)
    {
        var storageModel = new SecondSubStorage() {
            Id = domainModel.Key.Key.Id,
            Value = domainModel.Value,
        };
        return storageModel;
    }

    public SecondSubModel ToDomain(SecondSubStorage storageModel)
    {
        var domainModel = new SecondSubModel(new SecondSubKey(new SimpleRootKey(storageModel.Id))) {
            Value = storageModel.Value
        };
        return domainModel;
    }
}