using Microsoft.AspNetCore.Routing;
using Semantica.Linq;
using Semantica.Types;

namespace Semantica.Mvc;

public static class RouteValuesExtensions
{
    public static RouteValueDictionary ToDictionary(this RouteValues routeValues)
    {
        return routeValues.IsEmpty() 
            ? new RouteValueDictionary() 
            : RouteValueDictionary.FromArray(routeValues.Values.ToArray());
    }
}
