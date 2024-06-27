namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.ValueTypes;

public struct ValueTypeModel
{
    public ValueTypeModel(string value)
    {
        Value = value;
    }

    public string Value { get; }
}