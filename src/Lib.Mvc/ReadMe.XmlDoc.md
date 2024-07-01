<a name='assembly'></a>
# Lib.Mvc

## Contents

- [CheapDictionary](#T-Semantica-Mvc-Types-CheapDictionary 'Semantica.Mvc.Types.CheapDictionary')
- [ControllerConventionExtensions](#T-Semantica-Mvc-Conventions-ControllerConventionExtensions 'Semantica.Mvc.Conventions.ControllerConventionExtensions')
  - [AddControllersKebabCase()](#M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersKebabCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}- 'Semantica.Mvc.Conventions.ControllerConventionExtensions.AddControllersKebabCase(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Microsoft.AspNetCore.Mvc.MvcOptions})')
  - [AddControllersLowerCase()](#M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersLowerCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}- 'Semantica.Mvc.Conventions.ControllerConventionExtensions.AddControllersLowerCase(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Microsoft.AspNetCore.Mvc.MvcOptions})')
  - [AddControllersSnakeCase()](#M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersSnakeCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}- 'Semantica.Mvc.Conventions.ControllerConventionExtensions.AddControllersSnakeCase(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Microsoft.AspNetCore.Mvc.MvcOptions})')
  - [AddRouteTransformer\`\`1(conventions)](#M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddRouteTransformer``1-System-Collections-Generic-IList{Microsoft-AspNetCore-Mvc-ApplicationModels-IApplicationModelConvention}- 'Semantica.Mvc.Conventions.ControllerConventionExtensions.AddRouteTransformer``1(System.Collections.Generic.IList{Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention})')

<a name='T-Semantica-Mvc-Types-CheapDictionary'></a>
## CheapDictionary `type`

##### Namespace

Semantica.Mvc.Types

##### Summary

Dit is niet een echte dictionary, gewoon een wrapper om een simpele array, en implementeert alleen de IEnumerable methods.
    De class is bedoeld voor plekken in het framework die IDictionary als input verwachten, en vervolgens alleen de keyvaluepairs enumereren.

<a name='T-Semantica-Mvc-Conventions-ControllerConventionExtensions'></a>
## ControllerConventionExtensions `type`

##### Namespace

Semantica.Mvc.Conventions

##### Summary

Provides several extension methods for use during the [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') step
of the Program.cs.

<a name='M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersKebabCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}-'></a>
### AddControllersKebabCase() `method`

##### Summary

*Inherit from parent.*

##### Summary

Adds services for controllers to the specified IServiceCollection. Adds a [RouteTokenTransformerConvention](#T-Microsoft-AspNetCore-Mvc-ApplicationModels-RouteTokenTransformerConvention 'Microsoft.AspNetCore.Mvc.ApplicationModels.RouteTokenTransformerConvention')
to the conventions collection that transforms route tokens from pascal case to kebab case. This method will not register
services used for views or pages.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersLowerCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}-'></a>
### AddControllersLowerCase() `method`

##### Summary

*Inherit from parent.*

##### Summary

Adds services for controllers to the specified IServiceCollection. Adds a [RouteTokenTransformerConvention](#T-Microsoft-AspNetCore-Mvc-ApplicationModels-RouteTokenTransformerConvention 'Microsoft.AspNetCore.Mvc.ApplicationModels.RouteTokenTransformerConvention')
to the conventions collection that transforms route tokens to lower case. This method will not register services used
for views or pages.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddControllersSnakeCase-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Microsoft-AspNetCore-Mvc-MvcOptions}-'></a>
### AddControllersSnakeCase() `method`

##### Summary

*Inherit from parent.*

##### Summary

Adds services for controllers to the specified IServiceCollection. Adds a [RouteTokenTransformerConvention](#T-Microsoft-AspNetCore-Mvc-ApplicationModels-RouteTokenTransformerConvention 'Microsoft.AspNetCore.Mvc.ApplicationModels.RouteTokenTransformerConvention')
to the conventions collection that transforms route tokens from pascal case to snake case. This method will not register
services used for views or pages.

##### Parameters

This method has no parameters.

<a name='M-Semantica-Mvc-Conventions-ControllerConventionExtensions-AddRouteTransformer``1-System-Collections-Generic-IList{Microsoft-AspNetCore-Mvc-ApplicationModels-IApplicationModelConvention}-'></a>
### AddRouteTransformer\`\`1(conventions) `method`

##### Summary

Adds an instance of `TTransformer` as [RouteTokenTransformerConvention](#T-Microsoft-AspNetCore-Mvc-ApplicationModels-RouteTokenTransformerConvention 'Microsoft.AspNetCore.Mvc.ApplicationModels.RouteTokenTransformerConvention') to the
conventions collection.

##### Returns

`conventions`, for FluentAPI syntax.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conventions | [System.Collections.Generic.IList{Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelConvention}') | The [Conventions](#P-Microsoft-AspNetCore-Mvc-MvcOptions-Conventions 'Microsoft.AspNetCore.Mvc.MvcOptions.Conventions') collection of the [MvcOptions](#T-Microsoft-AspNetCore-Mvc-MvcOptions 'Microsoft.AspNetCore.Mvc.MvcOptions'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TTransformer | A type implementing [IOutboundParameterTransformer](#T-Microsoft-AspNetCore-Routing-IOutboundParameterTransformer 'Microsoft.AspNetCore.Routing.IOutboundParameterTransformer'). |
