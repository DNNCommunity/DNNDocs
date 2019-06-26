---
uid: glossary
locale: en
title: Glossary
dnnversion: 09.02.00
links: ["[DNN Wiki: DNN Glossary](https://www.dnnsoftware.com/wiki/dotnetnuke-glossary)","[DNN Wiki: Globalization Glossary](https://www.dnnsoftware.com/wiki/international-glossary)"]
---

# Glossary

**action menu**

The set of menus that provides access to the functionality of a module. Available only if the page is in **Edit** mode. The menus can include the Edit menu (pencil icon), the Manage menu (gear icon), and the Move menu (four-arrow icon). The DNN Platform provides actions that are common to all modules; however, a module might provide additional actions. If the module instance is independent, then actions performed through the module action menu affect only that specific module instance in that specific webpage. If the same module instance is referenced in multiple pages, then changes made to the module instance from any of those pages are reflected in all those pages.

**Advanced URL Management**

The latest implementation of the Friendly URL Rewriter. Includes additional tools that give DNN administrators greater control over the formatting of URLs within DNN.

**container**

A set of related components that define the look and feel of a module. In contrast, a skin or theme defines the look and feel of an entire webpage or website.

**culture**

The RFC 4646 code for the language and region. Example: en-US for English (US) and fr-FR for French (France).

**databaseOwner**

A token used in database scripts to refer to the SQL Server database schema that is used during DNN installation. Default: `dbo`.

**engagement**

A score that measures how involved the member is with the rest of the community.

**Experience Points**

An unlimited lifetime cumulative score based on the activities of the user on the site.

**extension**

A combination of themes, modules, or other components that replace or extend specific features of the DNN Platform.

**friendly URL**

A URL that hides a coded path. Example: https://www.example.com/myanswerpage might actually resolve to https://www.example.com/default.aspx?tabid=42. DNN provides three modes of friendly URLs:

*   **Advanced** provides both human-friendly and search-friendly URLs.
*   **HumanFriendly** uses simple URLs for page names and uses `tabid` in more complicated URLs. Limited redirect support.
*   **SearchFriendly** includes `tabid` patterns in URLs.

**influence**

A score that measures the positive or negative effect of the member on the community.

**manifest**

An XML file (e.g., MyExtension.dnn) that specifies how to install an extension. The manifest contains information regarding the extension type, and the various components that make up the extension.

**module**

A DNN extension that provides content or some functionality in a page. Example: A module could produce dynamic content that is displayed in a pane on the page.

**objectQualifier**

A custom string used as a prefix to names of DNN-related SQL objects, such as tables and stored procedures. This allows you to identify the DNN objects in a database that supports other applications besides DNN. Default: blank.

**package**

The zip file that contains all files required to install an extension in a DNN-based website. Also, a section of the DNN Manifest schema that specifies how the core components of the extension are installed.

**page**

A DNN object that includes all components of a webpage, including scripts and UI components.

**pane**

A layout template area that holds a module. Theme designers determine the names and positions of panes. Administrators and webpage editors select the pane for each module added to the webpage. When the webpage is viewed, the pane can display content, depending on the module's functionality.

**portal**
Portal is a term that was originally used during the earlier versions of DNN and has since been replaced with "site" or "website."  Essentially, a portal is a single website in your DNN instance, and DNN can have one or many portals/sites in a single instance of DNN.  You will still see the `portal` and `portals` term used exclusively in the API and database.

**portal alias**

A URL that refers to a specific website in a DNN installation. Examples: `https://www.example.com` (parent portal alias), `https://www.example.com/pathname` (child portal alias). Each website can have one or more portal aliases.

**premium**

A module setting that indicates that use of the module can be restricted for security reasons. Example: Modules that expose confidential user information and modules that manage security access to the site should be premium.

**provider**

A type of DNN extension that provides an alternative implementation of a specific functionality of the DNN Platform. Examples: authentication providers, data providers, and navigation providers. In most cases, even if multiple implementations are available in a DNN installation, only one implementation of each provider type is active at any time.

**Reputation Points**

A set of points based on how members of the site perceive the trustworthiness of a user.

**site**

A specific website in a DNN installation, which can host multiple websites that share files and resources.

**superuser**

The most privileged administrative account with complete access to all websites within the DNN installation and to all installed apps.

**tab**

This is a term that you may see used and it simply describes an instance of a page/webpage in DNN. "Page" and "Tab" are interchangeable terms from an end-user perspective. You'll still see `tab` and `tabs` used exclusively in the API and database.

**theme object**

A type of DNN extension used in themes to provide additional functionality for common UI elements on a webpage. Examples: menu bar, copyright notice, login/registration links, privacy link, terms of service link, and search box. Theme objects are configured by the theme designer.

> [!Tip]
> [10 Pound Gorilla](https://www.10poundgorilla.com/)'s [Skinning Tool](https://10poundgorilla.com/DNN-Skinning-Tool) is both a reference and a tool that customizes the code for DNN theme objects, based on the attribute values you specify.

**theme**

A set of related components that define the look and feel of a webpage or website. These components include:

*   one or more layout templates, and
*   an optional CSS for each of the templates, or an optional master CSS for the entire website.

In contrast, a container and any associated CSS define the look and feel of a module in a single pane of a page.

**token**

In an HTML content template, a placeholder for data to be injected into the HTML output. Example: `[User:UserName]` is replaced with the actual username.

In an HTML layout template, a word that represents DNN-standard code for a **theme object**. Examples: \[NAV\], \[COPYRIGHT\], \[LOGIN\], \[PRIVACY\], \[TERMS\], and \[SEARCH\].

In a Visualizer template, a word that represents a field in the content type associated with the visualizer. Example: If the content type field is named `Meeting Timeslot`, the field's token would be `{{ meetingTimeslot }}`.
