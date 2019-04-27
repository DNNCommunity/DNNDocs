﻿---
uid: developers-extensions-overview
topic: developers-extensions-overview
locale: en
title: Creating a Module
dnneditions: DNN Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-about-modules-overview
related-topics: dnn-manifest-schema,module-features,module-architecture,about-evs
links: ["[DNN Module APIs](https://www.dnnsoftware.com/dnn-api/)","[DNN 8 API Reference](https://www.dnnsoftware.com/dnn-api/)","[DNN Wiki: Module Development](https://www.dnnsoftware.com/wiki/module-development/)","[DNN Community Blog: Module Development series by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155064/module-development-for-non-developers-skinners-dnn-beginners--blog-series-intro/)","[Using the new Module Development Templates for DotNetNuke 7 by Chris Hammond](https://www.chrishammond.com/blog/itemid/2616/using-the-new-module-development-templates-for-dot/)"]
---

# Should You Create an Extension?

Before you create an extension, it's worth your time to first check to see if the extension you want already exists.  Try searching the resources below first to see if the extension you want to create already exists.

* [DNN Store](https://store.dnnsoftware.com/)
* [Search GitHub](https://github.com/search?q=dnn)
* [Use nvQuickPulse to find an Extensionn](https://github.com/nvisionative/nvQuickPulse/blob/master/README.md)
* [Look through the DNN-Connect directory](https://www.dnn-connect.org/community/community-extensions)

# Types of Extensions

Often, developers will create a _module_ extension to solve a problem when another type of extension is more suitable.  Of course, you can also use your module to enhance or provide a configuration interface for other extensions. 

For example, if you have code to run a custom report on regular basis, you would typically create a _scheduling_ extension. However, since the scheduler is only available to SuperUser account, if you want to allow other users to run it ad-hoc or to change the schedule, you could create a  _module_ that has a front-end to expose some of those settings. You could then provide access to that module for users and/or security roles using DNN’s module permissions mechanism.

*   *JavaScript Library* - Allows you to install a JavaScript framework (e.g., Angular or React) in a way that allows multiple extensions to safely ask for and include the framework without loading it multiple times. It also allows superusers to globally define from where and how the library loads.  
*   *Library* - A file known as a DLL is packaged and installed so that it's available for any number of purposes. Some extensions may use it as a shared API and/or it can be one of the other types of extensions listed below.  For example, a URL Provider is distributed as a library extension.  
*   *Module* - This is the standard type of extension that's most commonly created. A module can be seen by administrators and/or website visitors once it's installed and added to a page. No other extension can be added to a page and no other extension can have permissions directly assigned to it. A module package may work together with and may even include other types of extensions.  
*   *Provider* - In general, a provider is a development pattern where functionality is provided out of the box, but the functionality may be changed or replaced altogther by installing and specifying an alternative provider.  
    *   *Authentication* - This is the only way you can safely replace the authentication system in DNN. Simply building a module will not account for all of the login/registration scenarios and will also potentially open up a security hole in your website.  
    *   *Data* - If you don't want DNN to connect to and use SQL Server, you can create a data provider to connect to another type of database. In the past, examples of this has included MS Access and Oracle databases.  
    *   *Folder* - This allows you to specify other folder types and/or locations for you to store files. In the front-end, nothing changes, but when someone accesses or saves a new folder, it will actually be "pointing" somewhere else behind the scenes (e.g., Dropbox, file share, Azure, etc.).  
    *   *Logging* By default, DNN logs to the file sytem and configured database, but it's possible for you to alter the logging to store the events in another location by using this extension point.  
    *   *Membership* - DNN includes its own membership provider that's a wrapper of the AspNetMembership provider. Use this extension point to have another provider used. For example, this would be ideal for a web farm environment that requires zero tolerance for data loss, by centrally storing user accounts in a specific location outside of DNN.  
    *   *Navigation* - There is a very powerful navigation provider already included in DNN, known as the DDR Menu, but if you wish to use an alternative, this is the primary way you'd do that.  
    *   *Output Cache* - This provider allows you to determine how to save and invalidate cache. While this is most relevant and sees the most impact in web farm scenarios, it's used across all types of website implementation, including cloud scenarios, such as Redis caching.  
    *   *Permissions* - This provider allows you to override how the permissions grids in DNN work.  For example, this is how Evoq adds the granular permissions feature.  
    *   *Profile* - Somewhat similar to the member, this provider overrides where and how you store the profile information. For highly sensitive website implmentations, you may want to consider using both providers to store and access user data in a separate location.   
    *   *Roles* - The roles provider is again similar to the membership and profile providers, only this one pertains to information related to security roles.  
    *   *Scheduling* - There is a scheduled job feature in DNN that regularly runs code-based logic/routines on intervals defined by individual scheduled jobs. This provider controls how that feature works. An example of overriding this feature may be to run the schedule in Windows, instead of in the website's IIS application pool.  
    *   *Search Data Store* - This provider allows you to control where the search index data is stored.  
    *   *Search Index* - There can be many search index providers, allowing you to index the file system, static content/pages, and various types of data together or individually. This provider makes that possible.   
    *   *Sitemap* - An XML sitemap is generated for you automatically using this provider.  The default provider generally works quite well for nearly any website, not requiring you to change it. Where this provider really shines is when you have a module that generates a lot of additional pages (e.g, a blog or news articles) that need to be properly fed into search crawlers like Google and Bing.  
    *   *Text (HTML) Editor* - If you wish to have additional or alternative text editors for content contributors to use or even to display in your own modules only, use this provider to do that.  
    *   *URL* - This is a very commonly used provider, to make URLs on your DNN website more user- and search-friendly. This is the provider you'd use to do things like remove the ID number from a URL in a module that lists content that has dynamically generated pages (e.g, a blog or news articles).   
*   *Scheduled Job* - Use a scheduled job extension to plug into and run code-based logic at a regular interval. Installing this extension and specifying it in the scheduler allows the code to run at whatever intervals or events you choose. In web farms, you can (and should) even choose which server the scheduled job runs on. For example, this is how the search index runs.  
*   *Theme* - Formerly referred to as "skins," this extension point is what allows you to install and make available the visual elements that make individual pages or the entire website look a specific way. It provides the dependencies and files required to allow administrators to set a global default design for the entire website, as well as assign/override that setting on specific pages. A theme package will often contain one or both of the extension types below.  
   *   *Container* - Whereas a theme file makes a web page look a specific way, a container will make a module look a specific way.  Each module on a specific page could potentially have its own look-and-feel (though, not recommended in most cases).   
   *   *Skin (Theme) Object* - A skin object has many of the same attributes and abilities as a module, but administrators are not able to configure it in any way.  It will always be presented within the theme, and generally may only be configured by editing the theme code itself. Examples of a skin object include static links (e.g., login, register, privacy statement, terms of use), search, logo, and breadcrumbs.  

# Creating a Module  

You can produce a module in different ways:

*   Create an entire module from scratch. For very simple modules, you can use the DNN Module Creator.
*   Start with module development templates, such as:
    *   [DNN 8 Templates](https://github.com/dnnsoftware/DNN.Templates/releases/)
    *   [Chris Hammond's DotNetNuke Module and Theme Development Templates](https://github.com/ChrisHammond/DNNTemplates/) ([Installation instructions](https://www.chrishammond.com/blog/itemid/2616/using-the-new-module-development-templates-for-dot/))
    *   [Matt Rutledge's generator-dnn](https://github.com/mtrutledge/generator-dnn)
    *   [Upendo Ventures' generator-upendodnn](https://github.com/UpendoVentures/generator-upendodnn)
*   Customize a pre-existing module.

    Thousands of third-party modules and themes are available from the [DNN Store](https://store.dnnsoftware.com). There are extensions for sale, including versions that include the source code, as well as some free extension.



You can also use different programming frameworks (Web Forms, MVC, SPA) and languages (C#, VB) to create your module.
