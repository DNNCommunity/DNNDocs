---
uid: referencing-dnn-assemblies
locale: en
title: Referencing DNN Assemblies
dnnversion: 09.04.03
related-topics: releases
---

# Referencing DNN Assemblies

Every release of the DNN Platform ships with a number of .net assemblies that end up in the bin folder.
When developing for DNN you need to be aware of the assemblies that ship with DNN so you

1. You reference the right versions of these assemblies in your code, and
2. Don't accidentally overwrite these assemblies when installing your extension package

On these pages you'll find which assemblies shipped with which DNN version and which assemblies are part of the DNN NuGet packages.

## NuGet

It is best practice to use NuGet to get the right references for your projects. As of this writing these are the packages that are available to you:

|**Package Name**|**Description**|
|---|---|
|[Dnn.PersonaBar.Library](https://www.nuget.org/packages/Dnn.PersonaBar.Library/)|DNN PersonaBar Common Library|
|[DotNetNuke.Abstractions](https://www.nuget.org/packages/DotNetNuke.Abstractions/)|Provides common abstraction API references for the DNN Platform.|
|[DotNetNuke.Bundle](https://www.nuget.org/packages/DotNetNuke.Bundle/)|This package is a metapackage that automatically includes all other available DNN Packages, this should only be used in situations where support for ALL types of development are truly needed.|
|[DotNetNuke.Core](https://www.nuget.org/packages/DotNetNuke.Core/)|Provides basic references to the DotNetNuke.dll to develop extensions for the DNN Platform.  For MVC or WebAPI please see other packages available as well|
|[DotNetNuke.DependencyInjection](https://www.nuget.org/packages/DotNetNuke.DependencyInjection/)|Provides API references needed to use Dependency Injection for the DNN Platform.|
|[DotNetNuke.Instrumentation](https://www.nuget.org/packages/DotNetNuke.Instrumentation/)|Provides references to enhanced logging and instrumentation available within DNN Platform for extension developers. Including access to Log4Net|
|[DotNetNuke.Providers.FolderProviders](https://www.nuget.org/packages/DotNetNuke.Providers.FolderProviders/)|Provides API references needed to develop custom folder providers, or to consume folder providers|
|[DotNetNuke.SiteExportImport](https://www.nuget.org/packages/DotNetNuke.SiteExportImport/)|This package contains components required for developing extensiong to utilize site export/import features.|
|[DotNetNuke.Web](https://www.nuget.org/packages/DotNetNuke.Web/)|Provides references to core components such as Caching, Security and other security-related items for DNN Platform|
|[DotNetNuke.Web.Client](https://www.nuget.org/packages/DotNetNuke.Web.Client/)|Provides API references for usage of the Client Dependency Framework (CDF) for the inclusion of CSS and JS files within DNN Platform|
|[DotNetNuke.Web.Deprecated](https://www.nuget.org/packages/DotNetNuke.Web.Deprecated/)|Provides API references for deprecated items removed from the primary API's, such as DNN's Telerik component.  These elements may not be distributed with DNN in the future|
|[DotNetNuke.Web.Mvc](https://www.nuget.org/packages/DotNetNuke.Web.Mvc/)|Provides API references needed to develop ASP.MVC extensions for DNN Platform|
|[DotNetNuke.WebApi](https://www.nuget.org/packages/DotNetNuke.WebApi/)|This package contains components required for developing WebAPI based services for DNN Platform.|

## Shipped Assemblies

Below you'll find a list of DNN releases since version 7.
Each will open a page where you'll find a complete rundown of the assemblies that shipped with this release as well as details of the NuGet packages for that release.

|**DNN Version**|**DotNetNuke.dll Version**|Details|
|---|---|---|
|[7.0.0](xref:assemblies-7.0.0)|7.0.0.1586|[details](xref:assemblies-7.0.0)|
|[7.0.1](xref:assemblies-7.0.1)|7.0.1.266|[details](xref:assemblies-7.0.1)|
|[7.0.2](xref:assemblies-7.0.2)|7.0.2.1|[details](xref:assemblies-7.0.2)|
|[7.0.3](xref:assemblies-7.0.3)|7.0.3.64|[details](xref:assemblies-7.0.3)|
|[7.0.4](xref:assemblies-7.0.4)|7.0.4.180|[details](xref:assemblies-7.0.4)|
|[7.0.5](xref:assemblies-7.0.5)|7.0.5.130|[details](xref:assemblies-7.0.5)|
|[7.0.6](xref:assemblies-7.0.6)|7.0.6.121|[details](xref:assemblies-7.0.6)|
|[7.1.0](xref:assemblies-7.1.0)|7.1.0.2676|[details](xref:assemblies-7.1.0)|
|[7.1.1](xref:assemblies-7.1.1)|7.1.1.385|[details](xref:assemblies-7.1.1)|
|[7.1.2](xref:assemblies-7.1.2)|7.1.2.356|[details](xref:assemblies-7.1.2)|
|[7.2.0](xref:assemblies-7.2.0)|7.2.0.607|[details](xref:assemblies-7.2.0)|
|[7.2.1](xref:assemblies-7.2.1)|7.2.1.367|[details](xref:assemblies-7.2.1)|
|[7.2.2](xref:assemblies-7.2.2)|7.2.2.303|[details](xref:assemblies-7.2.2)|
|[7.3.0](xref:assemblies-7.3.0)|7.3.0.499|[details](xref:assemblies-7.3.0)|
|[7.3.1](xref:assemblies-7.3.1)|7.3.1.20|[details](xref:assemblies-7.3.1)|
|[7.3.2](xref:assemblies-7.3.2)|7.3.2.109|[details](xref:assemblies-7.3.2)|
|[7.3.3](xref:assemblies-7.3.3)|7.3.3.118|[details](xref:assemblies-7.3.3)|
|[7.3.4](xref:assemblies-7.3.4)|7.3.4.45|[details](xref:assemblies-7.3.4)|
|[7.4.0](xref:assemblies-7.4.0)|7.4.0.353|[details](xref:assemblies-7.4.0)|
|[7.4.1](xref:assemblies-7.4.1)|7.4.1.280|[details](xref:assemblies-7.4.1)|
|[7.4.2](xref:assemblies-7.4.2)|7.4.2.216|[details](xref:assemblies-7.4.2)|
|[8.0.0](xref:assemblies-8.0.0)|8.0.0.809|[details](xref:assemblies-8.0.0)|
|[8.0.1](xref:assemblies-8.0.1)|8.0.1.236|[details](xref:assemblies-8.0.1)|
|[8.0.2](xref:assemblies-8.0.2)|8.0.2.4|[details](xref:assemblies-8.0.2)|
|[8.0.3](xref:assemblies-8.0.3)|8.0.3.5|[details](xref:assemblies-8.0.3)|
|[8.0.4](xref:assemblies-8.0.4)|8.0.4.226|[details](xref:assemblies-8.0.4)|
|[9.0.0](xref:assemblies-9.0.0)|9.0.0.1002|[details](xref:assemblies-9.0.0)|
|[9.0.1](xref:assemblies-9.0.1)|9.0.1.142|[details](xref:assemblies-9.0.1)|
|[9.0.2](xref:assemblies-9.0.2)|9.0.2.5|[details](xref:assemblies-9.0.2)|
|[9.1.0](xref:assemblies-9.1.0)|9.1.0.367|[details](xref:assemblies-9.1.0)|
|[9.1.1](xref:assemblies-9.1.1)|9.1.1.129|[details](xref:assemblies-9.1.1)|
|[9.2.0](xref:assemblies-9.2.0)|9.2.0.366|[details](xref:assemblies-9.2.0)|
|[9.2.1](xref:assemblies-9.2.1)|9.2.1.533|[details](xref:assemblies-9.2.1)|
|[9.2.2](xref:assemblies-9.2.2)|9.2.2.178|[details](xref:assemblies-9.2.2)|
|[9.3.1](xref:assemblies-9.3.1)|9.3.1.2|[details](xref:assemblies-9.3.1)|
|[9.3.2](xref:assemblies-9.3.2)|9.3.2.22|[details](xref:assemblies-9.3.2)|
|[9.4.0](xref:assemblies-9.4.0)|9.4.0.0|[details](xref:assemblies-9.4.0)|
|[9.4.1](xref:assemblies-9.4.1)|9.4.1.22|[details](xref:assemblies-9.4.1)|
|[9.4.2](xref:assemblies-9.4.2)|9.4.2.5830|[details](xref:assemblies-9.4.2)|
|[9.4.3](xref:assemblies-9.4.3)|9.4.3.33|[details](xref:assemblies-9.4.3)|
|[9.4.4](xref:assemblies-9.4.4)|9.4.4.5|[details](xref:assemblies-9.4.4)|
|[9.5.0](xref:assemblies-9.5.0)|9.5.0.0|[details](xref:assemblies-9.5.0)|
|[9.6.0](xref:assemblies-9.6.0)|9.6.0.0|[details](xref:assemblies-9.6.0)|
|[9.6.1](xref:assemblies-9.6.1)|9.6.1.0|[details](xref:assemblies-9.6.1)|
|[9.6.2](xref:assemblies-9.6.2)|9.6.2.0|[details](xref:assemblies-9.6.2)|
|[9.7.0](xref:assemblies-9.7.0)|9.7.0.0|[details](xref:assemblies-9.7.0)|
|[9.7.1](xref:assemblies-9.7.1)|9.7.1.0|[details](xref:assemblies-9.7.1)|
|[9.7.2](xref:assemblies-9.7.2)|9.7.2.0|[details](xref:assemblies-9.7.2)|
|[9.8.0](xref:assemblies-9.8.0)|9.8.0.0|[details](xref:assemblies-9.8.0)|

