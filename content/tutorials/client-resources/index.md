---
uid: client-resources
locale: en
title: Client Resources
dnnversion: 07.02.00
---

# Client Resources

When requesting JavaScript and CSS, DNN has a system for coordinating these requests.  This allows for a variety of controls which provide performance and centralization of resources.

## API

The DotNetNuke.Web.Client assembly includes the types used for managing client resources.  The `ClientResourceManager` class has `RegisterScript` and `RegisterStyleSheet` methods which provide the basic functionality of requesting a JavaScript or CSS file be included on the page.

There are also WebForms controls which can be used in the `ascx` files within your module and theme, as well as helpers for MVC modules (introduced in DNN 9.7.0) and tokens for SPA modules.

### JavaScript Libraries

In addition to requesting individual files, DNN also has a JavaScript Library extension type.  This allows requesting a JavaScript library by name, and, optionally, a version range.  Unlike other package types, multiple versions of a JavaScript library can be installed at once.  JavaScript libraries can specify dependencies, which will automatically be included when the script is requested (e.g. a Bootstrap JS library can depend on the jQuery library, and requesting Boostrap will automatically cause jQuery to also be included on the page).

The [`JavaScript`](xref:DotNetNuke.Framework.JavaScriptLibraries.JavaScript) class provides three overloads of the `RequestRegistration` method.  The first overload takes only the name of the library, which will request the latest version of the library.  The second overload takes the library name and a version (this requests that specific version).  The final overload takes the library name, a version, and a [`SpecificVersion`](xref:DotNetNuke.Framework.JavaScriptLibraries.SpecificVersion) value indicating the acceptable version range.  For example, `RequestRegistration("swiper", new Version(6, 0, 1), SpecificVersion.LatestMajor)` will get the highest 6.x version of Swiper.  If different versions of the same library are requested on the same page, the higher version will be included.

## Basic Concepts

### Providers

When requesting a script or style sheet, a _provider_ can be specified.  DNN provides three providers, which specify which section of the page the resource will be referenced from.  The available providers are as follows:

* `DnnPageHeaderProvider` - render the script/style sheet reference in the `<head>` element
* `DnnBodyProvider` - render the script/style sheet reference in the `<body>` element, near the top
* `DnnFormBottomProvider` - render the script/style sheet reference in the `<form>` element, near the bottom

When requesting a CSS style sheet, the default provider is `DnnPageHeaderProvider`, whereas when requesting a JavaScript file, the default provider is `DnnBodyProvider`.  The client resource manager will de-duplicate scripts and style sheets within a provider.  For example, if two modules request `/DesktopModules/MyModule/MyScript.min.js` to be added to the `DnnFormBottomProvider`, only one `<script>` element will be rendered.  However, if one module requests the script to be added to `DnnPageHeaderProvider` and the other module requests the script to be added to the `DnnFormBottomProvider`, the `<script>` element will be rendered in both sections of the page.

### Priority

Each script or style sheet request has a numeric priority, which determines the order in which the scripts/styles will load.  The default priority for both scripts and style sheets is `100`, which loads _after_ all built-in scripts and styles (e.g after `module.css` and `portal.css`).  The class `DotNetNuke.Web.Client.FileOrder` exposes a `Css` enum and a `Js` enum, which provide access to the priority numbers for built-in scripts and styles, which is useful if you're replacing or adding to a built-in style.

JavaScript libraries use their database ID as their priority, so if you need to include a custom script after a library, make sure to use a high priority (e.g. `10000`) to ensure your custom script is after the library.

### Ad Hoc Names and Versions

When requesting a script or CSS file, a name and version can also be specified, which is used for de-duplication, in the same way that JavaScript libraries are automatically de-duplicated.

### Examples

#### MVC

```csharp
@Dnn.DnnCssInclude("/Portals/_default/Skins/MySkin/Styles/bootstrap.min.css", 14, "DnnPageHeaderProvider", "bootstrap", "4.5.2")
@Dnn.DnnCssInclude("https://fonts.googleapis.com/css2?family=Oswald&display=swap")

@Dnn.JavaScriptLibraryInclude("swiper", new Version(6, 0, 1), SpecificVersion.LatestMajor)

@Dnn.DnnJsInclude("/Portals/_default/Skins/MySkin/Scripts/bootstrap.min.js", 100, "DnnFormBottomProvider", "bootstrap", "4.5.2")
@Dnn.DnnJsInclude("/Portals/_default/Skins/MySkin/Scripts/mySliders.min.js", 10001, "DnnFormBottomProvider")
```

#### SPA Tokens

```html
[Css:{ path: "/Portals/_default/Skins/MySkin/Styles/bootstrap.min.css", priority: 14 }]
[Css:{ path: "https://fonts.googleapis.com/css2?family=Oswald&display=swap" }]

[JavaScript:{ jsname: "swiper", version: "6.0.1", specific: "LatestMajor" }]

[JavaScript:{ path: "/Portals/_default/Skins/MySkin/Scripts/bootstrap.min.js", provider: "DnnFormBottomProvider", jsname: "bootstrap", version: "4.5.2" }]
[JavaScript:{ path: "/Portals/_default/Skins/MySkin/Scripts/mySliders.min.js", priority: 10001, provider: "DnnFormBottomProvider" }]
```

#### WebForms

```html
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<%@ Register TagPrefix="dnn" TagName="" Src="JavaScriptLibraryInclude" Src="~/admin/Skins/JavaScriptLibraryInclude.ascx" %>

<dnn:DnnCssInclude runat="server" PathNameAlias="SkinPath" FilePath="Styles/bootstrap.min.css" Priority="14" Name="bootstrap" Version="4.5.2" />
<dnn:DnnCssInclude runat="server" FilePath="https://fonts.googleapis.com/css2?family=Oswald&display=swap" />

<dnn:JavaScriptLibraryInclude runat="server" Name="swiper" Version="6.0.1", SpecificVersion="LatestMajor" />

<dnn:DnnJsInclude runat="server" PathNameAlias="SkinPath" FilePath="Scripts/bootstrap.min.js" ForceProvider="DnnFormBottomProvider" Name="bootstrap" Version="4.5.2" />
<dnn:DnnJsInclude runat="server" PathNameAlias="SkinPath" FilePath="Scripts/mySliders.min.js" ForceProvider="DnnFormBottomProvider" Priority="10001" />
```

##### Additional Attributes

When using the WebForms controls, there's an additional attribute, `HtmlAttributesAsString`, which can be used to add additional attributes to the rendered `<script>` or `<link>` element.  Specify the attributes as a comma-delimited list of key-value pairs, separating the key and value with a colon (`:`) character.

```html
<dnn:DnnCssInclude runat="server" FilePath="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" HtmlAttributesAsString="integrity:sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z,crossorigin:anonymous">" />

<dnn:DnnJsInclude runat="server" FilePath="https://www.google.com/recaptcha/api.js" ForceProvider="DnnPageHeaderProvider" HtmlAttributesAsString="async:async,defer:defer" />
```

##### Remove and replace CSS and JS requests

There are two additional theme objects, `DnnCssExclude` and `DnnJsExclude` which can stop a requested CSS or JavaScript file from being included on the page.  A common usage of this feature is for a theme to stop DNN from including its default CSS:

```html
<dnn:DnnCssExclude runat="server" Name="dnndefault" />
```

Similarly, requesting a resource with the same name as another resource will replace the first resource (i.e. requests with the same name are de-duplicated).  To use the version 8 default CSS instead of version 7:

```html
<dnn:DnnCssInclude runat="server"
    FilePath="~/resources/shared/stylesheets/dnndefault/8.0.0/default.css"
    Priority="<%#FileOrder.Css.DefaultCss%>"
    Name="dnndefault"
    Version="8.0.0" />
```

## Configuration

Some of the details of how the scripts and styles get included on the page can be managed by the administrator of the site.  On the _Servers_ page of the Persona Bar, in the _Performance_ sub-tab of the _Server Settings_ tab, there is a _Client Resource Management_ section.  The section can be managed globally and/or for different sites individually.

![Client Resource Management screenshot](/images/scr-ClientResourceManagement.png)

DNN keeps track of the Client Resource Management (CRM) version, which is used to help cache generated files and avoid old versions of files from being served out of a browser's cache.  The version is also automatically incremented upon package upgrades and repair installations, upgrades of DNN Platform, as well use of the CSS editor.  This section of the Persona Bar provides access to increment the CRM version manually (which can be useful, for example, when a style sheet has been manually updated via the asset manager).

This section also allows an adminstrator to enable composite files.  When composite files are turned on, all local files requested from the same provider are bundled together into a single request.  Also, once combined, an administrator can optionally turn on minification of CSS or JavaScript to try to reduce the payload being delivered (note, however, that minification is _not_ available when files are not combined).

As an example, without composite files on, a site's `<head>` may render something like this:

```html
<link href="/Resources/Shared/stylesheets/dnndefault/7.0.0/default.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/DesktopModules/YWC_CookieConsent/module.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/DesktopModules/Blog/module.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/DesktopModules/OpenContent/module.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Resources/Search/SearchSkinObjectPreview.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/_default/skins/MyTheme/skin.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/1/portal.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/_default/skins/MyTheme/OpenContent/Templates/_Generic/Banner/template.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/_default/skins/MyTheme/OpenContent/Templates/Showcase/Details/Feedback/template.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/_default/skins/MyTheme/OpenContent/Templates/Showcase/Listing/template.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="/Portals/_default/skins/MyTheme/OpenContent/Templates/Home/FeaturedServices/template.css?cdv=593" type="text/css" rel="stylesheet"/>
<link href="https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700|Roboto:400,400i,700&amp;cdv=593" type="text/css" rel="stylesheet"/>
<link href="https://fonts.googleapis.com/icon?family=Material+Icons&amp;cdv=593" type="text/css" rel="stylesheet"/>

<script src="/Resources/libraries/jQuery/01_09_01/jquery.js?cdv=593" type="text/javascript"></script>
<script src="/Resources/libraries/jQuery-Migrate/01_02_01/jquery-migrate.js?cdv=593" type="text/javascript"></script>
<script src="/Resources/libraries/jQuery-UI/01_11_03/jquery-ui.js?cdv=593" type="text/javascript"></script>
<script src="/Resources/libraries/html5shiv/03_07_03/html5shiv-printshiv.min.js?cdv=593" type="text/javascript"></script>
```

With composite files turned on, that site section of the page would render more like this:

```html
<link href="/DependencyHandler.axd/fcdcd729be4c730f0427730c95714376/593/css" type="text/css" rel="stylesheet"/>
<link href="https://fonts.googleapis.com/css?family=Roboto+Condensed:400,700|Roboto:400,400i,700&amp;cdv=593" type="text/css" rel="stylesheet"/>
<link href="https://fonts.googleapis.com/icon?family=Material+Icons&amp;cdv=593" type="text/css" rel="stylesheet"/>

<script src="/DependencyHandler.axd/32d57d00960ee6ddaeb7c6087eabe65a/593/js" type="text/javascript"></script>
```

Notice that the external CSS file requests remain external, but all other file requests have been combined and are served via `DependencyHandler.axd`.

### Considerations

There are some caveats to consider when combining scripts.

First, measuring the performance impact of turning on this feature is important.  Especially with the advent of HTTP 2, serving many small files may perform better than serving one large file.

Secondly, when combining CSS and JavaScript, certain code constructs may not behave the same.  For example, an `@import` in the middle of a CSS file is ignored, as is a `'use strict'` directive in JavaScript.

Finally, combining all of the scripts for each page may have better performance with an empty browser cache, but create worse performance with a primed cache.  Consider the above scenario where a user is presented with 13 style sheets and 4 scripts when viewing a site's home page.  When navigating to an interior page requesting 10 of those 13 style sheets and one additional script, the browser can serve most of those resources out of its cache.  However, with file combination turned on, the `DependencyHandler.axd` requests will be different between those two pages, so all of the contents of those 10 same style sheets and 4 same scripts will end up being re-downloaded as part of the new bundle.

Ultimately, testing is needed to understand how much of a benefit or deteriment any of these features provide for any particular site.
