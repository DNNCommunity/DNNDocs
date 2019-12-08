---
uid: relnotes-2016-jan-14
locale: en
title: DNN Release Notes — 2016 Jan 14
dnnversion: 09.02.00
---

# DNN Release Notes — 2016 Jan 14

## DNN PLATFORM 8.0.0

The following are breaking changes that can impact upgrades as well as third-party extensions:

*   .NET 4.5.1 or higher is now required.
*   Removed the following administration modules from the product: Site Log, Newsletters, Vendors, and Banners. Although no longer supported, these can be downloaded from [DNNCommunity in GitHub](https://github.com/DNNCommunity).
*   Removed the following navigation providers: ASP2Menu, DNNDropDown, DNNMenu, DNNTree, Solpart.
*   Removed the following functionality/modules: What's New, Feed Browser, Widget Framework, Getting Started, Content List.
*   Removed the legacy appSetting connection string. Modules that have not been updated for this change in the past years will now break.
*   Moved Telerik controls to a new assembly, requiring third-party extensions to recompile to continue to work. This will be phased out completely in subsequent releases.
*   Removed support for Internet Explorer 8.
*   These third party modules (core modules that formerly shipped with the Platform) break in this upgrade and must be upgraded:
    *   [FAQ](https://github.com/DNNCommunity/DNN.Faq)
    *   [Feedback](https://github.com/DNNCommunity/DNN.Feedback)
    *   [IFrame](https://github.com/DNNCommunity/DNN.IFrame)
    *   [Events](https://github.com/DNNCommunity/DNN.Events)
    *   [Form and List](https://github.com/DNNCommunity/DNN.FormAndList)

The following updates are geared towards extension developers and theme designers:

*   Single Page Application (SPA) and MVC modules are now supported, so developers can create non-Webforms-based modules. Visual Studio 2015 templates for both types are also released.
*   The module settings API was updated to support strongly typed settings.
*   Incremental upgrade support is now possible through **SqlDataProvider**, cleanup files, and configuration merge files. This allows changes to the platform or third-party extensions without requiring a new versioned release.
*   Extension developers can now create admin and host pages through the DNN Manifest (.dnn).
*   Developers can now exclude individual CSS and/or JS files from being loaded or combined during minification through a new control.
*   **Default.css** now has versioning support, which can be set by theme designers to reduce the CSS that their themes need to override.
*   Third party components (CodeMirror and Newtonsoft) were upgraded to newer versions.
*   DAL 2 is enhanced to add a fluent configuration API that allows developers to separate their data implementation details from their models.
*   The DNN Platform now uses Web API 2.0.
*   JSON Web Token (JWT) authentication support is added to allow developers a way to expose WebAPI services for consumption outside of the framework, such as mobile applications. **Warning:** This feature is still in beta.

Additional changes:

*   A new image handler is exposed to developers to be used for profile pictures throughout the application.
*   CK Editor is the new default HTML provider in new installations (replacing the Telerik RadEditor as default).
*   A number of Administration modules (including Vendors, Site Log, Newsletters) were removed from the base installation.
*   A new default theme that uses Bootstrap 3 is now available.
*   The base project was converted from a Website Project (WSP) to a Web Application Project (WAP) to help reduce application startup time.
*   The page output caching provider was moved from Evoq to the DNN Platform.
*   Password resets now use the same token as long as it isn't expired. This means that, if the user clicks **Send password** multiple times quickly, only a single token will be generated.
*   Password inputs now allow 39 characters instead of 20.
*   The default robots.txt now allows client-side resources to be indexed.
*   Text used throughout the entire application were reviewed for consistency.
*   The Breadcrumb theme object now outputs schema.org markup.
*   Fixed: The issue where some platform functionality injected CSS files too late, so that they couldn't be modified by skin.css.
*   SMTP now supports TLS authentication.

## EVOQ 8.3.0

EVOQ CONTENT BASIC

*   All updates included with DNN Platform 8.0.0.
*   Added ability to manage a user's roles within the Users section of the Persona Bar.
*   Corrected several problems around generating URLs for Digital Asset Manager.
*   Additional minor enhancements and bug fixes.

EVOQ CONTENT

*   All updates included with Evoq Content Basic 8.3.0.
*   Added Optimizely connector and module that provides a way to do A/B (split) testing within Evoq.
*   Additional minor enhancements and bug fixes.

EVOQ ENGAGE

*   All updates included with Evoq Content 8.3.
*   Added ability to subscribe to activity stream posts and their comments (for items created within the activity stream).
*   Added emoji support in activity stream.
*   Updated activity stream comment area to provide the same experience as creating a new post (support for images, videos, etc.).
*   Removed notifications for votes on Ideas.
*   Added ability to sort comments in Discussions module by newest or oldest (also available for third party extensions utilizing the commenting control of Engage).
*   Made it possible for users to delete posts from other users on their own activity stream.
*   Corrected problems where Ideas votes may not be returned or added back.
*   Additional minor enhancements and bug fixes.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.8x/tree/master/08.00.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.8x/tree/master/08.00.00)