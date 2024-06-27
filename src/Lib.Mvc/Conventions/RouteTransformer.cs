using Microsoft.AspNetCore.Routing;
using Semantica.Extensions;

namespace Semantica.Mvc.Conventions;

public class RouteTransformer : IOutboundParameterTransformer
{
    public string? TransformOutbound(object? objValue)
    {
        var value = objValue?.ToString();
        return string.IsNullOrWhiteSpace(value) ? null : Transform(value);
    }
    
    protected virtual string Transform(string value)
    {
        return value.ToLower();
    }
}

public class KebabCaseRouteTransformer : RouteTransformer
{
    protected override string Transform(string value)
    {
        return value.ToKebabCase();
    }
}

public class SnakeCaseRouteTransformer : RouteTransformer
{
    protected override string Transform(string value)
    {
        return value.ToSnakeCase();
    }
}
