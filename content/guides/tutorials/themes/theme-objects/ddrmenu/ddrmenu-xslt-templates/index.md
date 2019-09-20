---
uid: ddrmenu-xslt-templates
locale: en
title: DDRMenu XSLT Templates Overview
dnnversion: 09.02.00
previous-topic: ddrmenu-token-templates
next-topic: designers-home
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# DDRMenu XSLT Templates  

## XML format  

The best way to see the XML structure provided to the XSLT stylesheet is to look at the output of the DumpXML template).  For reference, the full set of attributes and elements of a menu `<node>` is described below.

* `@id` - The page ID  
* `@text` - The page name (i.e., what should normally be displayed in the menu)  
* `@title` - The full page title  
* `@url` - The page URL  
* `@enabled` - Whether the page is enabled  
* `@selected` - Whether the page is selected  
* `@breadcrumb` - Whether the page is in the current breadcrumb  
* `@separator` - Whether the node is a separator  
* `@icon` - The URL of the page icon  
* `@largeimage` - The URL of the large page icon (DNN 6 only)  
* `@first` - Whether the page is the first in its level  
* `@last` - Whether the page is the last in its level  
* `@only` - Whether the page is the only one in its level  
* `@depth` - The depth of the current page in the menu structure (starting at `0`)  
* `@target` - The target window for the url defined for the page (`_new` or `null`); DNN 7.1+  
* `@commandname` - The action command name (action menus only, supported only in DNN 5 and older)  
* `@commandargument` - The action command argument (action menus only, supported only in DNN 5 and older)  
* `keywords` - The keywords defined for the current page  
* `description` - The description of the current page  
* `node` - A child node of this node  

### Related Content  

*   [DDRMenu Overview](xref:ddrmenu-overview)  
*   [DDRMenu Reference Guide](xref:ddrmenu-reference-guide)  
*   [DDRMenu Token Templates](xref:ddrmenu-token-templates)  
*   [DDRMenu Razor Templates](xref:ddrmenu-razor-templates-overview)  

### Additional Links  

*   [DDRMenu Razor Templates in DotNetNuke 7.x](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx)  
*   [Advanced Menu Design with DDRMenu](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3446/Advanced-Menu-Design-with-DDRMenu.aspx)  
*   [A Razor Templated DDRMenu for DotNetNuke 6](http://www.aubrett.com/InformationTechnology/WebDevelopment/CMSPlatforms/DotNetNuke/RazorTemplatedDDRMenu.aspx)  