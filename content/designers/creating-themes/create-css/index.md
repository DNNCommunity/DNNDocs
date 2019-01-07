---
topic: create-css
locale: en
title: Create a CSS File
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: designers-creating-themes-overview
previous-topic: create-container
next-topic: create-doctype-xml
related-topics: about-themes
links: ["[W3C specifications on cascading and inheritance](http://www.w3.org/TR/CSS21/cascade.html)","[DNN Wiki: DotNetNuke Skins](http://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Professional Training: Creating HTML Skins](http://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)"]
---

# Create a CSS File

A CSS file can be associated with a layout template or container by giving it the same filename and placing it in the same folder. When a layout template (or container) is applied to a webpage (or pane), the associated CSS file is automatically applied. Example: These three files are automatically associated with each other:

*   MyLayout.ascx
*   MyLayout.css
*   MyLayout.doctype.xml

CSS files are applied hierarchically. If a style is defined for an element in multiple CSS files with equal specificity, the last CSS that mentions the same element overrides the style definitions in previously loaded CSS files. By default, the CSS files are loaded in this order:

1.  default.css ( ~/Portals/_default/default.css) — The default CSS for the website.
2.  module.css ( ~/DesktopModules/mymodulename/module.css) — The CSS for every module type that appears on the page.
3.  skin.css ( ~/Portals/PortalID/Skins/SkinPackageName/skin.css) — The master CSS for the theme must be called skin.css.
4.  MyThemeTemplate.css ( ~/Portals/_default/Skins/SkinPackageName/MyThemeTemplate.css) — The CSS for a specific layout template.
5.  container.css ( ~/Portals/PortalID/Containers/ContainerPackageName/container.css) — The master CSS for all containers in your theme.
6.  portal.css ( ~/Portals/PortalID/portal.css) — The CSS that can override elements in the installed themes. Website administrators can use this to override any styles in the theme or containers.

Note: These style sheets are not required. You can also store all your styles in one master theme style sheet (skin.css). However, if you combine your container styles and your theme styles in one CSS file, then the container will display properly only when used with your theme.

## Steps

1.  Create the master style sheet for your theme (skin.css).
    
    Include:
    
    *   Common styles for all layout templates in your theme.
    *   Styles for theme objects used in all your layout templates.
    
2.  (Optional) Create a separate style sheet for each layout template in your theme (MyThemeLayout.css).
    
    Include:
    
    *   Styles that are specific to a layout template.
    *   Styles for theme objects that are used only in a specific layout template.
    
3.  (Recommended) Create the master style sheet for all containers in your theme (container.css).
    
    Include:
    
    *   Common styles for all containers in your theme.
    *   Styles for theme objects used in all your containers.
    
4.  (Optional) Create a separate style sheet for each container type in your theme (MyThemeLayout.css).
    
    Include:
    
    *   Styles that are specific to a container.
    *   Styles for theme objects that are used only in a specific container.
    

## Example

layout template

```

    <div id="login_style" class="user">
        <object id="dnnLOGIN" codebase="LOGIN" codetype="dotnetnuke/server">
            <param name="CssClass" value="user" />
        </object>
    </div>
            
```

CSS

```

    #login_style .linkseparator{
         color: white;
         font-weight: bold;
    }
            
```