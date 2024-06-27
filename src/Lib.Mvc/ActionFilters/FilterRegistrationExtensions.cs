using Microsoft.AspNetCore.Mvc.Filters;

namespace Semantica.Mvc.ActionFilters;

public static class FilterRegistrationExtensions
{
    public static FilterCollection AddBadRequestOnInvalidModel(this FilterCollection filterCollection)
    {
        filterCollection.Add<BadRequestOnInvalidModelAttribute>();
        return filterCollection;
    }
}
