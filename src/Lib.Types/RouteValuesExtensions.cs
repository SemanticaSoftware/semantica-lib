namespace Semantica.Types;

public static class RouteValuesExtensions
{
    public static RouteValues AddIf(this RouteValues routeValues, bool condition, string paramKey, object value)
    {
        if (! condition)
        {
            return routeValues;
        }
        
        return routeValues.Add(paramKey, value);
    }
    
    public static RouteValues SetIf(this RouteValues routeValues, bool condition, string paramKey, object value)
    {
        if (! condition)
        {
            return routeValues;
        }
        
        return routeValues.Set(paramKey, value);
    }
    
    public static RouteValues ToRouteValues(this IReadOnlyDictionary<string, string> routeValueDictionary, params string[] requiredKeys)
    {
        return routeValueDictionary.ToRouteValues((IReadOnlyList<string>)requiredKeys);
    }
    
    public static RouteValues ToRouteValues(
        this IReadOnlyDictionary<string, string> routeValueDictionary,
        IReadOnlyList<string>? requiredKeys)
    {
        var result = RouteValues.None;
        if (routeValueDictionary.IsNullOrEmpty())
        {
            return result;
        }
        
        foreach ((var key, var value) in routeValueDictionary.ConditionalWhere(
                         ! requiredKeys.IsNullOrEmpty(),
                         rv => requiredKeys!.Contains(rv.Key)
                     ))
        {
            result = result.Add(key, value);
        }
        
        return result;
    }
    
    public static bool TryToRouteValues(this IReadOnlyDictionary<string, string> routeValueDictionary, out RouteValues routeValues, params string[] requiredKeys)
    {
        var values = routeValueDictionary.ToRouteValues(requiredKeys);
        routeValues = values;
        return requiredKeys.All(key => values.ContainsKey(key));
    }

    public static bool ContainsKeys(this IReadOnlyDictionary<string, string> routeValueDictionary, IReadOnlyList<string> requiredKeys)
    {
        return ! routeValueDictionary.IsNullOrEmpty() && requiredKeys.All(routeValueDictionary.ContainsKey);
    }

    public static bool ContainsKey(this RouteValues routeValues, string requiredKey)
    {
        return routeValues.Any(rv => rv.Key == requiredKey);
    }
}
