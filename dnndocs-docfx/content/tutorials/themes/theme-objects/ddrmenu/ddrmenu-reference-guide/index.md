---
uid: ddrmenu-reference-guide
locale: en
title: DDRMenu Razor Templates Overview
dnnversion: 09.02.00
previous-topic: ddrmenu-overview
next-topic: designers-home
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# DDRMenu Reference Guide

This guide provides a reference to the various options, interfaces and extensions available in DDRMenu. For a task-oriented overview, please refer to the [DDR Menu user guide](xref:ddrmenu-overview).

## Menu Options

Please see the [DDR Menu user guide](xref:ddrmenu-overview) for information on how to apply these options.

### `MenuStyle`

`MenuStyle` is the name of the template to use.  This is the name of the folder that contains the menu manifest file `menudef.xml` (the name can contain `'/'` if the folder is in a subfolder).  If not specified (_see Filenames below_) the search order is:

* Container (_action menus only, in legacy versions of DNN_)
* Skin
* Portal root
* DesktopModules/DDRMenu
* Application root

### `NodeSelector`

`NodeSelector` determines which part of the page hierarchy to show in the menu.  Use:

* `RootOnly` to show only the root level menu items (alias for `*,0,0`)
* `RootChildren` to show all the children of the root menu item that is the parent of the current page (alias for `+0`)
* `CurrentChildren` to show the children of the current page (alias for `.`)
* `pageID` to show the children of a specific page
* `{root},{skip},{depth}` (where `{skip}` and `{depth}` may be omitted)

Options for `{root}` include:

* `*` for the root
* `.` or `0` for the current page
* `-n` for `n` levels above the current page
* `+n` for `n` levels down from the root menu towards the current page
* `PageID` to select a particular page by ID
* `PageName` to select a particular page by name

`{skip}`, if provided, skips that number of levels (e.g. `0` shows the selected page, `1` shows its children).

`{depth}`, if provided, specifies the number of levels deep to go (e.g. `0` for just the current level, `1` to include immediate children).

### IncludeNodes

Historically, this was used in DNN 4 and 5 to create separate menus for administrators and superusers.  Use a comma separated list of page names, IDs or roles to include in the menu (top level only).  For example, `IncludeNodes="Admin,Host"` or `IncludeNodes="321,123"`.

You can also wrap roles in `[]`.  For example, `[All users]` shows only those pages visible to which are visible all users.

### ExcludeNodes

Works exactly the same as `IncludeNodes`, but with the obvious difference...

### IncludeContext

If `true`, details of the currently logged on user will be passed to the template (e.g., a `DotNetNuke.Entities.User.UserInfo` object, available in `Root/user` for XSLT templates and `Model.Source.User` for Razor templates).

### IncludeHidden

Included as a feature since DNN 6 and newer, if set to `true`, hidden pages will be included.  This can be useful for creating separate menus to show site sections that are hidden from the main menu.

### NodeManipulator

If you need to adjust the menu structure before rendering (for example to add extra entries for categories in an e-commerce module), set this to an assembly and type to use to perform server-side menu structure manipulation.

The type supplied must implement the `INodeManipulator` interface.  Please see the [`DDRMenu_Common/INodeManipulator.cs` class on GitHub](https://github.com/dnnsoftware/Dnn.Platform/blob/development/DNN%20Platform/Modules/DDRMenu/INodeManipulator.cs).

### NodeXmlPath

If you want to use a menu template with your own custom page structure, you can supply an XML file to be loaded instead of using the DNN pages.  If not specified, (see Filenames below) the search order is:

* Menu folder
* Skin
* DesktopModules/DDRMenu
* Portal root
* Application root

### TemplateArguments

Arguments can be passed into the template.  For an XSLT template, these will be template parameters.  For a Razor template, they are passed in as members of the `Model` object.  For a token template, they are accessible by name.

### Client Options

Client options are name/value pairs that can be passed as a JSON object to jQuery plugins and most other JavaScript menus.  They are given to the template as an argument called Options that can then be passed on to the client-side code.

## Manifest File

A menudef.xml manifest file looks like the example below.

```xml
<?xml version="1.0" ?>
<manifest>
  <template>templateName.ext</template>
  <templateHead>templateHead.txt</templateHead>
  <scripts>
    <script jsObject="jQuery" />
    <script jsObject="jQuery.ui" />
    <script jsObject="jsObjectToCheck">myScript.js</script>
  </scripts>
  <stylesheets>
    <stylesheet>stylesheet.css</stylesheet>
  </stylesheets>
  <defaultClientOptions>
    <clientOption name="optionName" value="Value" />
    <clientOption name="optionName" value="1" type="number" />
  </defaultClientOptions>
  <defaultTemplateArguments>
    <templateArgument name="optionName" value="Value" />
  </defaultTemplateArguments>
</manifest>
```

All elements apart from `<template>` are optional. The element usage is further described below.

### `<template>`

The filename of the actual template.  The type of template is determined by the file extension - .txt for token templates, .cshtml or .vbhtml for Razor templates, and anything else for XSLT templates.

### `<templateHead>`

The path of a text file to insert in the `<head>` of the page.

### `<scripts>`

The paths of JavaScripts file to import.  If the `jsObject` attribute is specified, the script will only be imported if the specified JavaScript object does not exist.  Also, if `jsObject` is either `jQuery` or `jQuery.ui` and no script path is specified then the menu will request DNN to register the appropriate library (or load Google's hosted version of jQuery or jQuery UI in earlier versions of DNN).  Alternatively, a `name` attribute can be used to request an installed JavaScript library (and `version` and `specificVersion` attributes can determine the version range of the library). If your menu is to be used with a specific theme, it is recommended that you do not use this element, but instead combine and minify your scripts into one file and include them in the theme.

### `<stylesheets>`

The paths of CSS files to import.  If your menu is to be used with a specific theme, it is recommended that you do not use this element, but instead combine and minify your styles into one file and include them in the theme.

### `<defaultClientOptions>`

The default values for any client options that the template may support.

### `<fileNames>`

When specifying a filename or template name, if you don't want DDRMenu to automatically search for it, you can specify the file location as follows:

* `{[MANIFEST]/filename}`: In the folder containing the menu manifest (e.g. ~/Portals/0/skins/MySkin/MyTemplate/filename).
* `{[SKIN]/filename}`: In the current skin folder (e.g. ~/Portals/0/skins/MySkin/filename).
* `{[DDRMENU]/filename}`: In the DDRMenu folder (i.e. ~/DesktopModules/DDRMenu/filename).
* `{[PORTAL]/filename}`: In the portal root (e.g. ~/Portals/0/filename).
* `{[DNN]/filename}`: In the DNN application root (i.e. ~/filename).
* `{~/filename}`: In the DNN application root.

### Related Content

*   [DDRMenu Overview](xref:ddrmenu-overview)
*   [DDRMenu Token Templates](xref:ddrmenu-token-templates)
*   [DDRMenu XSLT Templates](xref:ddrmenu-xslt-templates)
*   [DDRMenu Razor Templates](xref:ddrmenu-razor-templates-overview)

### Additional Links

*   [DDRMenu Razor Templates in DotNetNuke 7.x](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx)
*   [Advanced Menu Design with DDRMenu](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3446/Advanced-Menu-Design-with-DDRMenu.aspx)
*   [A Razor Templated DDRMenu for DotNetNuke 6](http://www.aubrett.com/InformationTechnology/WebDevelopment/CMSPlatforms/DotNetNuke/RazorTemplatedDDRMenu.aspx)
