---
uid: providers
locale: en
title: Providers Reference
dnnversion: 09.02.00
related-topics: administrators-included-modules-overview,requirements,dnn-overview,dnn-overview,control-bar-to-persona-bar,persona-bar-by-role,more-resources
links: ["[DNN Wiki: Providers (and child links)](https://www.dnnsoftware.com/wiki/providers)"]
---

# Providers Reference

## Overview

Services can be provided by third parties to provide common functionality to websites. In most cases, these services are provided by apps on the server or by modules in DNN.

The DNN Platform includes default providers. In some cases, DNN Evoq includes additional providers. Other third-party providers are also available at the [DNN Store](https://store.dnnsoftware.com).

In a module, a provider is comprised of two layers:

*   **Abstract provider**. Exposed as a part of the DNN API set.
*   **Concrete provider**. Specific implementation of the abstract provider.

An abstract provider can be **Data Provider**, and a concrete provider can be **SQL Data Provider**.

To replace the default provider, simply change the value of the defaultProvider attribute of the appropriate tag in the web.config file.

## Authentication provider

Default web.config setting:

```

    <authentication defaultProvider="ADSIAuthenticationProvider">
        <providers>
            <clear/>
            <add name="ADSIAuthenticationProvider" type="DotNetNuke.Authentication.ActiveDirectory.ADSI.ADSIProvider, DotNetNuke.Authentication.ActiveDirectory" providerPath="~\Providers\AuthenticationProviders\ADSIProvider\"/>
        </providers>
    </authentication>

```

An **authentication provider** manages your website user logins using a single sign-on (SSO) provider. An SSO provider installs these UI elements:

*   a login control
*   a settings control
*   (optional) a logout control

DNN natively provides support for the following SSO providers:

*   Facebook
*   Google
*   Microsoft Live
*   Twitter

You can also [create your own](https://www.dnnsoftware.com/community-blog/cid/134678/dotnetnuke-tips-and-tricks-12-creating-your-own-authentication-provider).

See [membership provider](#membership-provider) (local authentication), [permissions provider](#permissions-provider), and [roles provider](#roles-provider).

## Caching provider

Default web.config setting:

```

    <caching defaultProvider="FileBasedCachingProvider">
        <providers>
            <clear/>
            <add name="FileBasedCachingProvider" type="DotNetNuke.Services.Cache.FBCachingProvider, DotNetNuke" providerPath="~\Providers\CachingProviders\FileBasedCachingProvider\"/>
        </providers>
    </caching>

```

A **caching provider** ensures that cached settings are synchronized across multiple servers in a web farm.

DNN provides two caching providers:

*   The default **FileBasedCachingProvider** uses a central file store to invalidate cache entries. This caching provider requires setting up permissions, application pools, domain users, and code access security.
*   The **WebBasedCachingProvider** is available only for Evoq customers and is recommended over the default. It requires minimal setup. Any web server can notify the other web servers to expire their cache in order to remain synchronized.

> [!NOTE]
> These two providers use cache invalidation to synchronize caching; they do not handle website changes, such as newly uploaded files or newly installed modules.

## Data provider

Default web.config setting:

```

    <data defaultProvider="SqlDataProvider">
        <providers>
            <clear/>
            <add name="SqlDataProvider" type="DotNetNuke.Data.SqlDataProvider, DotNetNuke" connectionStringName="SiteSqlServer" upgradeConnectionString="" providerPath="~\Providers\DataProviders\SqlDataProvider\" objectQualifier="" databaseOwner="dbo"/>
        </providers>
    </data>

```

A **data provider** allows a module to transfer data to and from a data store. To enable upgrades, data provider files include their version numbers in their filenames. During an upgrade, all intervening upgrades that were not previously installed will be installed with the current version.

Data providers require these web.config settings:

*   objectQualifier. A custom string used as a prefix to names of DNN-related SQL objects, such as tables and stored procedures. This allows you to identify the DNN objects in a database that supports other applications besides DNN. The default is blank.
*   databaseOwner. A token used in database scripts to refer to the SQL Server database schema that is used during DNN installation. The default is `dbo`.

DNN's default concrete data provider is the SQL Data Provider, which requires these UTF-8 files:

*   xx.xx.xx.sqldataprovider is a script executed during module/core installation/upgrade to modify the objectQualifier and databaseOwner settings. The xx.xx.xx portion of the filename is the script version.

    > [!NOTE]
    > DNN 8+ supports incremental scripts.

*   uninstall.sqldataprovider includes all of the module's SQL stored procedures, functions, views, and tables to be removed from the data store when the module is uninstalled. Developers: Always check if an item exists before removing it.

## Folder provider

Default web.config setting:

```

    <folder defaultProvider="StandardFolderProvider">
        <providers>
            <clear />
            <add name="StandardFolderProvider" type="DotNetNuke.Services.FileSystem.StandardFolderProvider, DotNetNuke" />
            <add name="SecureFolderProvider" type="DotNetNuke.Services.FileSystem.SecureFolderProvider, DotNetNuke" />
            <add name="DatabaseFolderProvider" type="DotNetNuke.Services.FileSystem.DatabaseFolderProvider, DotNetNuke" />
        </providers>
    </folder>

```

A **folder provider** enables websites to use multiple storage locations, including third-party cloud storage systems. The root portal directory can also be moved to a different provider.

DNN Platform provides three folder providers, and each has its own icon in the File Manager:

*   **StandardFolderProvider**, an unsecured file system.
*   **SecureFolderProvider**, a secured file system.
*   **DatabaseFolderProvider**, a secured database.

In addition, DNN Evoq includes built-in support for these third-party folder providers:

*   Amazon Simple Storage Service (S3)
*   Dropbox
*   Box
*   Microsoft Azure Storage
*   UNC Share

A **folder mapping** or **folder type** is an implementation of a folder provider for a specific storage system. A folder mapping can have its own settings, and it can be prioritized in case of collisions during synchronization.

*   Administrators: You can choose and configure the folder types you allow in the DNN installation (superuser or host) or in a specific website (site administrator).
*   Developers: To create a folder provider,
    1.  Implement the abstract methods inherited from the FolderProvider class.
    2.  Provide a **Settings** control that inherits from the FolderMappingSettingsControlBase class.
    3.  Provide an icon to be displayed in the File Manager.

See [Folder Providers](https://www.dnnsoftware.com/wiki/folder-providers) in the DNN Wiki.

## Friendly URL provider

Default web.config setting:

```

    <friendlyUrl defaultProvider="DNNFriendlyUrl">
        <providers>
            <clear/>
            <add name="DNNFriendlyUrl" type="DotNetNuke.Services.Url.FriendlyUrl.DNNFriendlyUrlProvider, DotNetNuke.HttpModules" includePageName="true" regexMatch="[^a-zA-Z0-9 _-]" urlFormat="advanced"/>
        </providers>
    </friendlyUrl>

```

A friendly URL is a human-friendly and/or search-friendly URL that hides a coded URL. A **friendly URL provider** associates the internal URL (used to retrieve the requested page) with the friendly URL (displayed on the browser's address bar when the page is displayed).

See [Building Friendly URLs](https://web.archive.org/web/20180630234743/https://www.ifinity.com.au/Blog/EntryId/102/Building-Friendly-Urls-into-DotNetNuke-Modules-ndash-Part-1) in the iFinity blog by [Bruce Chapman](https://www.dnnsoftware.com/users/bruce-chapman).

## HTML editor provider

Default web.config setting:

```

    <htmlEditor defaultProvider="DNNConnect.CKE">
        <providers>
            <clear/>
            <add name="DNNConnect.CKE" type="DNNConnect.CKEditorProvider.CKHtmlEditorProvider, DNNConnect.CKEditorProvider" providerPath="~/Providers/HtmlEditorProviders/DNNConnect.CKE/" settingsControlPath="~/Providers/HtmlEditorProviders/DNNConnect.CKE/Module/EditorConfigManager.ascx" />
        </providers>
    </htmlEditor>

```

An **HTML editor provider** is used to edit HTML directly within the website.

## Logging provider

Default web.config setting:

```

    <logging defaultProvider="DBLoggingProvider">
        <providers>
            <clear/>
            <add name="DBLoggingProvider" type="DotNetNuke.Services.Log.EventLog.DBLoggingProvider, DotNetNuke" providerPath="~\Providers\LoggingProviders\DBLoggingProvider\"/>
        </providers>
    </logging>

```

A **logging provider** manages error logs, event logs, and security logs in DNN.

## Membership provider

Default web.config setting:

```

    <members defaultProvider="AspNetMembershipProvider">
        <providers>
            <clear/>
            <add name="AspNetMembershipProvider" type="DotNetNuke.Security.Membership.AspNetMembershipProvider, DotNetNuke" providerPath="~\Providers\MembershipProviders\AspNetMembershipProvider\"/>
        </providers>
    </members>

```

A **membership provider** manages your website user logins using a local solution. The default membership provider ASP.NET Membership supports the following:

*   Creating new user accounts.
*   Storing user information in SQL, Active Directory, or other data store.
*   Authenticating users.
*   Managing passwords.
*   Exposing a unique identifier for authenticated users to use in your own modules.

Unlike authentication providers which provide SSO authentication, the membership provider is a standalone authentication solution that is local to the website or to the DNN installation.

See [authentication provider](#authentication-provider) (SSO authentication), [permissions provider](#permissions-provider), and [roles provider](#roles-provider). Also see the MSDN Library's [Introduction to Membership](https://msdn.microsoft.com/en-us/library/yh26yfzy.aspx) and Engage Weblog's [Building your own Membership Provider](https://engagesoftware.com/news/post/447/building-your-own-membership-provider-for-dotnetnuke-and-asp-net-2-0) by [Henry Kenuam](https://www.dnnsoftware.com/activity-feed/userid/32389).

## Module caching provider

Default web.config setting:

```

    <moduleCaching defaultProvider="FileModuleCachingProvider">
        <providers>
            <clear />
            <add name="FileModuleCachingProvider" type="DotNetNuke.Services.ModuleCache.FileProvider, DotNetNuke" providerPath="~\Providers\ModuleCachingProviders\FileModuleCachingProvider\" />
            <add name="MemoryModuleCachingProvider" type="DotNetNuke.Services.ModuleCache.MemoryProvider, DotNetNuke" providerPath="~\Providers\ModuleCachingProviders\MemoryModuleCachingProvider\" />
        </providers>
    </moduleCaching>

```

A **module caching provider** manages how the output of modules are cached and aged, whether they are stored in a file or in memory.

See [output caching provider](#output-caching-provider).

## Navigation provider

Default web.config setting:

```

    <navigationControl defaultProvider="DDRMenuNavigationProvider">
        <providers>
            <clear/>
            <add name="DDRMenuNavigationProvider" type="DotNetNuke.Web.DDRMenu.DDRMenuNavigationProvider, DotNetNuke.Web.DDRMenu" />
        </providers>
    </navigationControl>

```

A **navigation provider** supplies a specific type of navigation. [DDRMenu](https://www.dnnsoftware.com/wiki/ddrmenu-user-guide) is the default navigation provider in DNN8.

## Output caching provider

Default web.config setting:

```

    >outputCaching defaultProvider="FileOutputCachingProvider">
        >providers>
            >clear />
        >/providers>
    >/outputCaching>

```

An **output caching provider** manages how the entire page is cached and aged.

See [module caching provider](#module-caching-provider).

## Permissions provider

Default web.config setting:

```

    <permissions defaultProvider="CorePermissionProvider">
        <providers>
            <clear/>
            <add name="CorePermissionProvider" type="DotNetNuke.Security.Permissions.CorePermissionProvider, DotNetNuke" providerPath="~\Providers\PermissionProviders\CorePermissionProvider\" />
        </providers>
    </permissions>

```

A **permissions provider** manages asset permissions, such as those associated with components of the website, including page permissions and module permissions. These permissions are used in conjunction with user permissions (authentication provider or membership provider) and group permissions (roles provider) to determine if a specific user would be allowed to access the asset.

DNN Evoq supplies its own **GranularPermissionProvider**, which allows greater granularity with permissions.

See [authentication provider](#authentication-provider) (SSO authentication), [membership provider (local authentication)](#membership-provider), and [roles provider](#roles-provider).

## Profile provider

Default web.config setting:

```

    <profiles defaultProvider="DNNProfileProvider">
        <providers>
            <clear/>
            <add name="DNNProfileProvider" type="DotNetNuke.Security.Profile.DNNProfileProvider, DotNetNuke" providerPath="~\Providers\MembershipProviders\DNNProfileProvider\"/>
        </providers>
    </profiles>

```

A **profile provider** manages the profiles of registered users of the website.

## Roles provider

Default web.config setting:

```

    <roles defaultProvider="DNNRoleProvider">
        <providers>
            <clear/>
            <add name="DNNRoleProvider" type="DotNetNuke.Security.Roles.DNNRoleProvider, DotNetNuke" providerPath="~\Providers\MembershipProviders\DNNMembershipProvider\"/>
        </providers>
    </roles>

```

A **roles provider** manages the permissions required for specific roles. This allows the administrator to easily assign/revoke all permissions associated with a role by simply adding/deleting a user or a set of users to/from the role.

See [authentication provider](#authentication-provider) (SSO authentication), [membership provider](#membership-provider) (local authentication), and [permissions provider](#permissions-provider).

## Scheduling provider

Default web.config setting:

```

    <scheduling defaultProvider="DNNScheduler">
        <providers>
            <clear/>
            <add name="DNNScheduler" type="DotNetNuke.Services.Scheduling.DNNScheduler, DotNetNuke" providerPath="~\Providers\SchedulingProviders\DNNScheduler\" debug="false" maxThreads="1" delayAtAppStart="60" />
        </providers>
    </scheduling>

```

A **scheduling provider** manages when tasks are performed and triggers them automatically at the indicated time.

The DNN Scheduler can be accessed through Host \> Advanced Settings (double-gear tab) \> Schedule.

See [DotNetNuke Scheduling Provider](https://dnnzone.files.wordpress.com/2010/08/dotnetnuke-scheduler.pdf) by [Dan Caron](https://www.dnnsoftware.com/activity-feed/userid/2386).

## Search data store provider

Default web.config setting:

```

    <searchDataStore defaultProvider="SearchDataStoreProvider">
        <providers>
            <clear/>
            <add name="SearchDataStoreProvider" type="DotNetNuke.Services.Search.SearchDataStore, DotNetNuke" providerPath="~\Providers\SearchProviders\SearchDataStore\"/>
        </providers>
    </searchDataStore>

```

A **search data store provider** allows you to specify where the search engine should store search results and other search-related data.

See [search index provider](#search-index-provider).

## Search index provider

Default web.config setting:

```

    <searchIndex defaultProvider="ModuleIndexProvider">
        <providers>
            <clear/>
            <add name="ModuleIndexProvider" type="DotNetNuke.Services.Search.ModuleIndexer, DotNetNuke" providerPath="~\Providers\SearchProviders\ModuleIndexer\"/>
        </providers>
    </searchIndex>

```

A **search index provider** allows you to specify how the website content is indexed and what rules are performed to do searches.

See [search data store provider](#search-data-store-provider) and [sitemap provider](#sitemap-provider).

## Sitemap provider

Default web.config setting:

```

    <sitemap defaultProvider="coreSitemapProvider">
        <providers>
            <clear />
            <add name="coreSitemapProvider" type="DotNetNuke.Services.Sitemap.CoreSitemapProvider, DotNetNuke" providerPath="~\Providers\MembershipProviders\Sitemap\CoreSitemapProvider\" />
        </providers>
    </sitemap>

```

A **sitemap provider** creates an XML file that informs web crawlers and users how your website is organized. A module's sitemap exposes the multiple pages generated by the module, such as when a module serves up blog posts, articles, and forum discussions.

If your DNN website's sitemap is requested (https://www.example.com/Sitemap.aspx), the HTTP handler (set in web.config) runs its ProcessRequest method, which serves up the sitemap.xml file, if it exists. Otherwise, the ProcessRequest method calls BuildSiteMap to create sitemap.xml as follows:

1.  Checks the cache settings configured through the **SiteMap** module, which is available under Admin \> Search Engine SiteMap.
2.  Loops through all sitemap providers to build a collection of URLs.
3.  Creates the sitemap.xml file and stores it in the Portals/portalID/SiteMap folder.

DNN Evoq products include additional sitemap providers for these modules:

*   In DNN Evoq Content: Publisher
*   In DNN Evoq Engage: Answers, Blogs, Discussions, Ideas, Events, Wiki

See the DNN Wiki's [Creating a Sitemap Provider for Your Module](https://www.dnnsoftware.com/community-blog/cid/131987/creating-a-sitemap-provider-for-your-module) by Chris Paterra.
