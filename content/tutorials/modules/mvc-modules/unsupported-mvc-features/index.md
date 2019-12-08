---
uid: unsupported-mvc-features
locale: en
title: Unsupported MVC Features
dnnversion: 09.02.00
related-topics: mvc-module-project-overview,mvc-module-mvccontroller,mvc-module-mvcviews,mvc-module-unittest
---

# Unsupported MVC Features

Some MVC features were not fully implemented in DNN 8 due to the differences between ASP.NET MVC and ASP.NET Web Forms frameworks.

*   HTML Helpers
    *   FormExtensions (BeginForm, BeginRouteForm, EndForm)
    *   Html.RouteLink
    *   All ChildActionExtensions (e.g., Html.Action, Html.RenderAction)
*   URL Helpers
    *   Url.Action(string actionName, string controllerName, RouteValueDictionary routeValues, string protocol)
    *   Url.Action(string actionName, string controllerName, object routeValues, string protocol)
    *   Url.Action(string actionName, string controllerName, RouteValueDictionary routeValues, string protocol, string hostName)
    *   Url.RouteUrl
    *   Url.HttpRouteUrl
*   Controller Action Return Types. DNN 8 expects actions to return an ActionResult. All other result types are currently unsupported:
    *   ContentResult
    *   EmptyResult
    *   FileResult
    *   FileStreamResult
    *   RedirectResults
    *   RedirectToRouteResult
*   AsyncControllers
*   Attribute Routing
*   Bundles. DNN implements a different minification-and-bundling API for MVC modules.

The following features are expected in a future release:

*   AJAX Helpers
