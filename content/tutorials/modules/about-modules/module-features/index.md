---
uid: module-features
locale: en
title: Common Module Features
dnnversion: 09.02.00
related-topics: dnn-manifest-schema,module-architecture,developers-creating-modules-overview,about-evs
links: ["[DNN Module APIs](https://www.dnnsoftware.com/dnn-api/)"]
---

# Common Module Features

## Themes and Containers

While not traditionally considered part of module development, themes and containers define how a module is displayed on a page. Understanding the relationship between these elements will help you build modules that play well with other content on the page.

Themes define the look and feel of pages within DNN, and modules should be designed to work with a wide variety of styles. Through the placement of panes, the theme defines where modules can be positioned on a webpage.

> [!Tip]
> If you choose to define styles specific to your module, specify the scope of your styles in a root element (usually a `<div>` that wraps your entire markup) within your module. This ensures that your styles will be more specific than the styles defined in the theme.

DNN wraps a container around each module in the page. In addition to defining the look and feel of content blocks on the page, the container also provides UI elements that manage the module, such as the module title, the module action menu, and the action links.

## Module Action Menu

The module action menu provides standard functionality, such as module deletion, printing, content import/export, and content placement. Menu items are dynamically created based on module features and site settings.



![Module action menu](/images/scr-actionmenu-edit-icons.png)



You can customize the module action menu by implementing the following features in your module:

*   Provide a link to a help page manifest to change the Help link in the menu.
*   Implement the IPortable interface to display the Import and Export links in the menu.

    Note: The IPortable interface is also used by DNN when a page/portal template is created or used.

*   Implement the ISearchable interface to display the Syndicate link in the menu.

    Note: An Administrator must enable the Syndicate feature in the module settings.

*   Implement the IActionable interface to display custom menu items.

    Note: Custom menu items are included in the pencil icon menu. If IActionable is not implemented, then the pencil icon is not shown.


## Module Settings

DNN includes the settings objects for the Host, Portal, Tab, TabModule, and Module entities. To simplify module development, DNN manages the storage and retrieval of these settings. You might need to access these common settings to determine which of your module's features to enable.

You can also create custom settings and the associated UI to manage those custom settings.



![Custom module settings](/images/scr-module-settings.png)



## Packaging

Modules must be packaged in a standard format to be shared with other DNN websites. DNN packages are essentially .zip files that include a custom DNN manifest. The manifest is an XML file with a .dnn extension; it defines how the components of your module are installed.

You can bundle modules into packages:

*   manually,
*   by using the module packaging wizard, which is available through the Module Creator or the Extensions page, or

    ![Click Create Package to start the wizard.](/images/scr-module-package.png)



*   by using the build scripts that come with standard module templates.

## Security

DNN provides a role-based access control system that provides granular control at the site level, page level, and module level. You can extend this system to increase granularity of permission settings at the module level.



![Include custom module permissions](/images/scr-module-permissions.png)



Modules can also call DNN security APIs to check a user's current permissions before enabling secured features.
