---
uid: ddrmenu-token-templates
locale: en
title: DDRMenu Token Templates Overview
dnnversion: 09.02.00
previous-topic: ddrmenu-razor-templates
next-topic: ddrmenu-xslt-templates
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# DDRMenu Token Templates  

This page describes how the DDRMenu token template processor works.  Token-based templates are supported in all versions of DNN and provide a simple templating option if the additional programming power of XSLT or Razor are not required.  

## Tokens

The full set of tokens available currently for each menu node (page) are:

* `NODE` - A page  
* `ID` - The page ID  
* `TEXT` - The page name (i.e., what should normally be displayed in the menu)  
* `TITLE` - The full page title  
* `URL` - The page URL  
* `ENABLED` - Whether the page is enabled  
* `SELECTED` - Whether the page is selected  
* `BREADCRUMB` - Whether the page is in the current breadcrumb  
* `SEPARATOR` - Whether the node is a separator  
* `ICON` - The URL of the page icon  
* `LARGEIMAGE` - The URL of the large page icon (DNN 6 only)  
* `FIRST` - Whether the page is the first in its level  
* `LAST` - Whether the page is the last in its level  
* `ONLY` - Whether the page is the only one in its level  
* `DEPTH` - The depth of the current page in the menu structure (starting at 0)  
* `TARGET` - The target window for the url defined for the page (_new or null)  
* `KEYWORDS` - The keywords defined for the current page  
* `DESCRIPTION` - The description of the current page  
* `TARGET` - The target property is used to identify the browser window.  

You can see an example of the values these take in the output of the DumpXML template.  

## Directives  

The following directives are available in a token template:

* `[=TOKEN]` - Simply outputs the value of the given token.  
* `[?TOKEN]...[/?]` - Only output if the token is defined.  This will generally be used as `[?NODE]...[/?]` to output a section if there are any child nodes, or as `[?SELECTED]...[/?]`, etc. to output something only if the current node is selected.  You can also use `[?!TOKEN]...[/?]` (output if token is not defined) and `[?TOKEN]...[?ELSE]...[/?]`.  
* `[*TOKEN]...[/*]` - Outputs the contents for each occurrence of the given token. In practice this means `[*NODE]...[/*]` to produce output for each menu node at the current level.  
* `[*>TOKEN-MODE]` - Outputs the contents of a sub-template for each occurrence of the given token.  The optional `MODE` parameter allows you to specify more than one sub-template for a given token.  For example, you might define `[>NODE-TOP]` for top-level menu nodes and `[>NODE-SUB]` for sub-menus.  
* `[>TOKEN-MODE]...[/>]` - Defines a sub-template (called using the above directive).  

### Example  

A very simple example to output an unordered list with relevant classes on the `li` elements might look like what you see below:  

```xml
<ul>
	[*>NODE]
</ul>
[>NODE]
	<li class="[?FIRST]first[/?][?LAST] last[/?][?SELECTED] selected[/?]">
		[?ENABLED]
			<a href="[=URL]">[=TEXT]</a>
		[?ELSE]
			[=TEXT]
		[/?]
		[?NODE]
			<ul>
				[*>NODE]
			</ul>
		[/?]
	</li>
[/>]
```

For additional examples, [download the DDR Menu starter templates](https://github.com/MarkXA/ddrmenutemplates).  

### Related Content  

*   [DDRMenu Overview](xref:ddrmenu-overview)  
*   [DDRMenu Reference Guide](xref:ddrmenu-reference-guide)  
*   [DDRMenu XSLT Templates](xref:ddrmenu-xslt-templates)  
*   [DDRMenu Razor Templates](xref:ddrmenu-razor-templates-overview)  

### Additional Links  

*   [DDRMenu Razor Templates in DotNetNuke 7.x](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3619/ContentItemId/150607/DDRMenu-Razor-Templates-in-DotNetNuke-7-x.aspx)  
*   [Advanced Menu Design with DDRMenu](http://www.dnnsoftware.com/Resources/Blogs/EntryId/3446/Advanced-Menu-Design-with-DDRMenu.aspx)  
*   [A Razor Templated DDRMenu for DotNetNuke 6](http://www.aubrett.com/InformationTechnology/WebDevelopment/CMSPlatforms/DotNetNuke/RazorTemplatedDDRMenu.aspx)  