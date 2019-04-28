---
uid: spa-module-development
locale: en
title: SPA Module Development
dnnversion: 09.02.00
related-topics: create-module-using-templates,use-module-creator,providers
links: ["[Wikipedia: Single-Page Application](https://en.wikipedia.org/wiki/Single-page_application)","[DNN Wiki: Token Replacement API](https://www.dnnsoftware.com/wiki/ipropertyaccess)","[DNN Wiki: Standard DNN Tokens](https://www.dnnsoftware.com/wiki/tokens)"]
---

# SPA Module Development

## Overview

Single-Page Application (SPA) frameworks are a newer alternative to server-side web development frameworks such as ASP.NET. SPA replaces the full-page updates of server-side frameworks, with small targeted updates of select page elements. This lightweight approach results in a faster and more responsive UI.

DNN's SPA module type simplifies the creation of modules that simulate traditional SPA applications and that use AJAX for all server interactions.

The SPA module framework supplements other SPA frameworks, such as AngularJS, Knockout, and React, by providing DNN-specific functionality.

## SPA Module Architecture

In a SPA module, each HTML file loads the necessary JavaScript and CSS to properly render the UI. SPA modules also make AJAX calls to the business layer through the service layer. This architecture is similar to [the mobile application architecture for Web Forms modules](xref:web-forms-module-development).



![Logical architecture of a SPA module](/images/gra-module-architecture-spa.png)



When a DNN page is requested, the framework looks up the requested module control in the module definition. In an SPA module, the module control identifies a specific HTML file. DNN tokens in the HTML file are replaced with site-specific data before the HTML is injected into the page.

## Building SPA Modules

You have more development options available when building SPA modules compared to MVC modules. The server-side code can be created in Visual Studio as Web Application Project (WAP) or Web Site Project (WAP) types. (See [Web Application Projects Versus Web Site Projects in Visual Studio](https://msdn.microsoft.com/en-us/library/dd547590%28v=vs.110%29.aspx).) Because the presentation layer is created with plain HTML, JavaScript, and CSS, its components can be built using any code editor.

You can choose to build the SPA module with all presentation layer code in one project and all server-side code in a separate project. This approach makes it easy to use different development tools that are optimized for server-side or client-side development.

Alternatively, you can use Visual Studio to create a single project that includes both server-side and client-side components. This approach leverages the MS Build system to easily package your module as part of your development process. The DNN SPA module template is set up for this approach.

## Accessing DNN Features

Web Forms and MVC modules can easily access rendering-related DNN features because they are both server-side technologies. SPA modules use client-side technology and, therefore, require a different approach to access DNN features. Because a SPA module uses standard HTML, DNN provides custom tokens that can be included in the HTML to access data and APIs.

The following SPA module tokens can be used in your HTML:

*   JavaScript or JS registers a JavaScript file with the Client Resource Manager.
*   CSS registers a stylesheet with the Client Resource Manager.
*   AntiForgeryToken includes an anti-forgery token in the page to prevent Cross-Site Request Forgery (CSRF) attacks.
*   ModuleAction identifies custom module actions.
*   Resx includes a localized resource string in the page.
*   Request includes the page-request query string in the page.
*   ModuleContext includes a DNN module context property in the page. Supported module context properties include:
    *   ModuleId
    *   TabModuleId
    *   TabId
    *   PortalId
    *   IsSuperUser
    *   EditMode
    *   SettingName. You can access a specific module setting by using the setting name, instead of a predefined property name.
