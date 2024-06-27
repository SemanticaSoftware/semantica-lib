# Semantica.Lib.Package.Core
This package is part of the core packages of Semantica.Lib.

### Summary

Combines all primary Semantica.Lib.Core packages in a single package. Check the ReadMe of each package for further elaboration
on package contents.

#### Includes packages:

- [Semantica.Lib.Checks](https://www.nuget.org/packages/Semantica.Lib.Checks)
- [Semantica.Lib.Collections](https://www.nuget.org/packages/Semantica.Lib.Collections)
- [Semantica.Lib.Core](https://www.nuget.org/packages/Semantica.Lib.Core)
- [Semantica.Lib.Extensions](https://www.nuget.org/packages/Semantica.Lib.Extensions)
- [Semantica.Lib.Intervals](https://www.nuget.org/packages/Semantica.Lib.Intervals)
- [Semantica.Lib.Linq](https://www.nuget.org/packages/Semantica.Lib.Linq)
- [Semantica.Lib.Ordering](https://www.nuget.org/packages/Semantica.Lib.Ordering)
- [Semantica.Lib.Patterns](https://www.nuget.org/packages/Semantica.Lib.Patterns)
- [Semantica.Lib.Patterns.Converters](https://www.nuget.org/packages/Semantica.Lib.Patterns.Converters)
- [Semantica.Lib.Trees](https://www.nuget.org/packages/Semantica.Lib.Trees)
- [Semantica.Lib.Types](https://www.nuget.org/packages/Semantica.Lib.Types)

#### Excludes:

- [Semantica.Lib.Core.Json.Newtonsoft](https://www.nuget.org/packages/Semantica.Lib.Core.Json.Newtonsoft)
- [Semantica.Lib.Core.SimpleInjector](https://www.nuget.org/packages/Semantica.Lib.Core.SimpleInjector)
- [Semantica.Lib.Mvc](https://www.nuget.org/packages/Semantica.Lib.Mvc)
- [Semantica.Lib.Mvc.Rendering](https://www.nuget.org/packages/Semantica.Lib.Mvc.Rendering)

Also excludes all Design / Testing packages

## Purpose

So why does Semantica.Lib.Core exist? Every new project I found myself wanting to copy the library I made for the previous 
project. Every time I was assisting colleagues with their projects, I found myself sending them my library code to solve a 
problem. 

Parts of this library are just general helpfulness. Other parts are focussed mainly on being able to produce
better readable/maintainable code. I've included a few interfaces that describe very common patterns, and (extension-) 
functionality that builds on those patterns. There are some data types for clearer modelling and associated functionality, and
some types for convenience. 

Finally, there are quite a few types/extensions that I thought were missing from the base C#.NET framework. Since the first 
versions of this library around the time of .NET Core 2, many of these omissions have since been added to the framework. When
this happens I will mark the now superfluous part as Obsolete, and take them out completely in a subsequent minor version. 
