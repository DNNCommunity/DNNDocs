---
uid: ddrmenu-razor-templates-overview
locale: en
title: DDRMenu Razor Templates Overview
dnnversion: 09.02.00
previous-topic: ddrmenu-reference-guide
next-topic: ddrmenu-token-tenplates
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# DDRMenu Razor Template Engine  

This page describes how the DDRMenu Razor template processor works. Razor-based templates provide most power, including access to the DNN API. Starting with DNN 7.0, support is built in in the platform, but requires DDRMenu 2.0.3 or newer to work properly. This is due to a breaking change in DNN 7, which is [explained in this blog post](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx).  

> [!NOTE]
>
> In older versions of DNN, DDRMenu Razor templates are only supported with ASP.NET 4.0 with the Razor Host module installed.
> 

## Data Model

Razor templates receive the following members in the Razor model:

*   `Source.root` - The root menu node. You can see the exact structure of MenuNode in the DDRMenu source code, but in summary the following properties are available:
    *   `TabId` - The page ID
    *   `Text` - The page name (i.e. what should normally be displayed in the menu)
    *   `Title` - The full page title
    *   `Url` - The page URL
    *   `Target` - The target for for the page (e.g. _blank, Open in New)
    *   `Enabled` - Whether the page is enabled
    *   `Selected` - Whether the page is selected
    *   `Breadcrumb` - Whether the page is in the current breadcrumb
    *   `Separator` - Whether the node is a separator
    *   `Icon` - The URL of the page icon
    *   `LargeImage` - The URL of the large page icon (DNN 6 only)
    *   `First` - Whether the page is the first in its level
    *   `Last` - Whether the page is the last in its level
    *   `Depth` - The depth of the current page in the menu structure (starting at 0)
    *   `Keywords` - The keywords defined for the current page
    *   `Description` - The description of the current page
    *   `CommandName` - The action command name (action menus only)
    *   `CommandArgument` - The action command argument (action menus only)
    *   `Children` - The child nodes of this node
    *   `Parent` - The parent node of this node
*   `ControlID` - The ASP.NET control ID of the current DDRMenu instance
*   `Options` - The client options (in JSON format)
*   `DNNPath` - The path of the DNN application root
*   `ManifestPath` - The path of the menu template's manifest folder
*   `PortalPath` - The path to the current portal root
*   `SkinPath` - The path to the current theme

## Example

A simple example (using a .cshtml C# template) might look like this (this is the DNN 7.x + syntax):

```csharp
@using DotNetNuke.Web.DDRMenu;
@using System.Dynamic; 
@inherits DotNetNuke.Web.Razor.DotNetNukeWebPage<dynamic>
@{ var root = Model.Source.root; }
@helper RenderNodes(IList<MenuNode> nodes) {
  if (nodes.Count > 0) {
    <ul>
      @foreach (var node in nodes) {
        var cssClasses = new List<string>();
        
        if (node.First) { cssClasses.Add("first"); }
        
        if (node.Last) { cssClasses.Add("last"); }
        
        if (node.Selected) { cssClasses.Add("selected"); }
        
        var classString = new HtmlString((cssClasses.Count == 0) ? "" : (" class=\"" + String.Join(" ", cssClasses.ToArray()) + "\""));
        
        <li @classString>
          @if (node.Enabled) {
            <a href="@node.Url">@node.Text</a>
          } else {
            @node.Text
          }
          @RenderNodes(node.Children)
        </li>
      }
    </ul>
  }
}
@RenderNodes(root.Children)
```

### Related Content  

*   [DDRMenu Overview](xref:ddrmenu-overview)  
*   [DDRMenu Reference Guide](xref:ddrmenu-reference-guide)  
*   [DDRMenu Token Templates](xref:ddrmenu-token-templates)  
*   [DDRMenu XSLT Templates](xref:ddrmenu-xslt-templates)  

### Additional Links  

*   [DDRMenu Razor Templates in DotNetNuke 7.x](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx)  
*   [Advanced Menu Design with DDRMenu](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3446/Advanced-Menu-Design-with-DDRMenu.aspx)  
*   [A Razor Templated DDRMenu for DotNetNuke 6](http://www.aubrett.com/InformationTechnology/WebDevelopment/CMSPlatforms/DotNetNuke/RazorTemplatedDDRMenu.aspx)  