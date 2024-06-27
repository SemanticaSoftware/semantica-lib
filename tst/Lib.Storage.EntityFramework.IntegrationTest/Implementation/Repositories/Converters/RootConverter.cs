using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.ValueTypes;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.Converters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.ComplexTypes;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.Converters;

public class RootConverter : RootKeyConverter, IRootConverter
{
    public RootModel ToDomain(Root storageModel)
    {
        return new RootModel() {
            Key = ToKey(storageModel),
            Prop = storageModel.Prop,
            ImmutableProp = storageModel.ImmutableProp,
            NotMappedProp = storageModel.NotMappedProp,
            Values = storageModel.Values?.ValueTypeProp == null
                ? (ValueTypeModel?)null
                : new ValueTypeModel(storageModel.Values.ValueTypeProp),                
        };
    }

    public Root ToStorage(RootModel domainModel)
    {
        var storageModel = new Root();
        SetStorageProperties(storageModel, domainModel);
        return storageModel;
    }

    public void SetStorageProperties(Root storageModel, RootModel domainModel)
    {
        storageModel.Prop = domainModel.Prop;
        storageModel.ImmutableProp = domainModel.ImmutableProp;
        storageModel.NotMappedProp = domainModel.NotMappedProp;
        storageModel.Values = new ValueType()
        {
            ValueTypeProp = domainModel.Values?.Value
        };
    }
}