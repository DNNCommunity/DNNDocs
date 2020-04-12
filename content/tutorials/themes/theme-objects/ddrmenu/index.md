---
uid: ddrmenu-overview
locale: en
title: DDRMenu Razor Templates Overview
dnnversion: 09.02.00
previous-topic: breadcrumb
next-topic: ddrmenu-reference-guide
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# DDRMenu Overview  

Originally built and maintained by [Mark Allan @MarkXA](https://twitter.com/markxa), the DDRMenu is a robust menu system that is installed and used by default in DNN since version 6.0.
With the right Template and Styling any menu style can be created. With DDR menu you can use [TOKEN], XSLT or Razor templates.

## Installation

In DNN 6 and newer, there is no installation necessary.  If your DNN website began as DNN 6 or newer, please feel free to continue to the next section.  The information below is likely already done by DNN itself.  

In order for your theme to see and use the DDRMenu, it will need to be available as a configuration option in the _web.config_ file.  You should see the following entry in the `navigationControl` providers section.  

```xml
<add name="DDRMenuNavigationProvider" type="DotNetNuke.Web.DDRMenu.DDRMenuNavigationProvider, DotNetNuke.Web.DDRMenu" />
```

In a brand new installation of DNN 9.xx, that section will look like this:

```xml
<navigationControl defaultProvider="DDRMenuNavigationProvider">
  <providers>
    <clear />
    <add name="DDRMenuNavigationProvider" type="DotNetNuke.Web.DDRMenu.DDRMenuNavigationProvider, DotNetNuke.Web.DDRMenu" />
  </providers>
</navigationControl>
```

## Ready-To-Use Menu Templates

First, [download a suitable template](https://github.com/MarkXA/ddrmenutemplates). Drop the template folder into your theme folder (or portal root if you want the menu style available throughout a particular portal or `/DesktopModules/DDRMenu` if you want the menu style available to the entire DNN instance).  

If it's not already there, now add to your theme:

```html
<%@ Register TagPrefix="dnn" TagName="MENU" Src="~/DesktopModules/DDRMenu/Menu.ascx" %>  
```

Next, you'll add a skin object, similar to the following example:

```html
<dnn:MENU MenuStyle="..." runat="server" />
```

The `MenuStyle` attribute is the name of the menu template folder (usually found in your theme).  

> [!NOTE]
> 
>  While it is also possible to use a `dnn:NAV` control with the `DDRMenuNavigationProvider` and `CustomAttributes` to render a non-DNNMenu template, it adds complexity and brings no particular benefits, so is not recommended.
> 

## Choosing Pages to Show in the Menu

By default, DNN will handle which pages are displayed in the menu, generally based on permissions and visibility properties in the respective page's settings.  If you don't want to show all the pages in your menu, you have a few options available to you.  The most common way is to use the `NodeSelector` option.  

Example (from the Xcillion theme):  

```html
<dnn:MENU ID="MENU" MenuStyle="Menus/MainMenu" runat="server" NodeSelector="*" />
```

Possible values for `NodeSelector` include:

* `RootOnly` to show only the root level menu items (alias for *,0,0)
* `RootChildren` to show all the children of the root menu item that is the parent of the current page (alias for +0)
* `CurrentChildren` to show the children of the current page (alias for .)
* `pageID` to show the children of a specific page
* `{root},{skip},{depth}` 
  * Note: `{skip}` and `{depth}` may be omitted. 
  * `{root}` is `*` for the root, `.` or `0` for the current page, `-n` for `n` levels above the current page, `+n` for `n` levels down from the root menu towards the current page, `PageID` to select a particular page by ID or `PageName` to select a particular page by name. 
  * `{skip}` if provided skips that number of levels (e.g. `0` shows the selected page, `1` shows its children). 
  * `{depth}` if provided specifies the number of levels deep to go (e.g. `0` for just the current level, `1` to include immediate children).

You can also use the `IncludeNodes` and `ExcludeNodes` options. These have historically been used in DNN 4 and 5 to create separate menus for administrators and superusers. Use a comma separated list of page names, IDs or roles to include in the menu (top level only), e.g. `IncludeNodes="Admin,Host"` or `ExcludeNodes="321,123"`. Wrap roles in `[]`, e.g. `[All users]` shows only those pages visible to all users.  

Since DNN 6, you can specify `IncludeHidden="true"` to include hidden pages in the menu structure.  This can be useful for creating separate menus to show site sections that are hidden from the main menu.  

## Localized Menus  

In general, you don't need to do anything to have localized menus.  If you're using DNN's built in localization (or Ealo, Apollo or Adequation), DDRMenu will detect and use them automatically.  If you need to use localized strings in your template then use the `GetString` extension function in an XSLT template.  If you have another localization provider, then implement the `ILocalization` interface in your localization provider's controller.  

## Building Your Own Custom Menu  

The best way to build a custom menu is to take [an existing template as a starting point](https://github.com/MarkXA/ddrmenutemplates) and work from there. You can use the built-in DumpXML template at any time to view the actual live data structure that your template is using (just switch to `MenuStyle="DumpXML"`).  See the pages on Token, XSLT and Razor templates for more information, and if you are building a menu that may need to work with several skins then also see the reference guide for details on how to include JavaScript and CSS files with the menu.  

## Setting Options in the `<dnn:NAV>` Theme Object  

Use the following format:  

Add the following to the list of `Register` directives at the top of your theme ASCX file:

```html
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.UI.Skins" Assembly="DotNetNuke" %>
```

Then use the following format:

```html
<dnn:NAV providername="DDRMenuNavigationProvider" ...> 
  <CustomAttributes> 
    <dnn:CustomAttribute Name="OptionName" Value="OptionValue"/>
  </CustomAttributes>
</dnn:NAV>
```

Any option whose name is not recognized as a standard option will be set as a `ClientOption`.

## Setting Options on a Menu Added Using the Module

Module options are set through the standard module settings.  Template arguments and client options should be supplied as one or more lines in `Setting=Value` format.

### Related Content  

*   [DDRMenu Reference Guide](xref:ddrmenu-reference-guide)  
*   [DDRMenu Token Templates](xref:ddrmenu-token-templates)  
*   [DDRMenu XSLT Templates](xref:ddrmenu-xslt-templates)  
*   [DDRMenu Razor Templates](xref:ddrmenu-razor-templates-overview)  

### Additional Links  

*   [DDRMenu Razor Templates in DotNetNuke 7.x](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx)  
*   [Advanced Menu Design with DDRMenu](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3446/Advanced-Menu-Design-with-DDRMenu.aspx)  
*   [A Razor Templated DDRMenu for DotNetNuke 6](http://www.aubrett.com/InformationTechnology/WebDevelopment/CMSPlatforms/DotNetNuke/RazorTemplatedDDRMenu.aspx)  
*   [DDR Menu Demo skins](https://demo.40fingers.net/dnn-ddr-demo-skin)
