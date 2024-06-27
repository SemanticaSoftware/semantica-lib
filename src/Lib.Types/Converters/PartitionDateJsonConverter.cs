using Semantica.Core.Json;

namespace Semantica.Types.Converters;

public class PartitionDateJsonConverter : StringJsonConverterBase<PartitionDate>
{
    protected override PartitionDate FromString(string str) => PartitionDateTypeConverter.Deserialize(str);

    protected override string? ToString(PartitionDate value) 
        => value.IsEmpty() ? null : PartitionDateTypeConverter.Serialize(value);
}
