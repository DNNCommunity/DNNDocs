---
uid: create-css
locale: en
title: Create a CSS File
dnnversion: 09.02.00
previous-topic: create-container
next-topic: create-doctype-xml
related-topics: themes
links: ["[W3C specifications on cascading and inheritance](https://www.w3.org/TR/css3-cascade/)","[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)"]
---

# Create a CSS File

A CSS file can be associated with a layout template or container by giving it the same filename and placing it in the same folder. When a **layout template** (or **container**) is applied to a webpage (or **pane**), the associated CSS file is automatically applied. Example: These three files are automatically associated with each other:

*   MyLayout.ascx
*   MyLayout.css
*   MyLayout.doctype.xml

CSS files are applied hierarchically. If a style is defined for an element in multiple CSS files with equal specificity, the last CSS that mentions the same element overrides the style definitions in previously loaded CSS files. By default, the CSS files are loaded in this order:

1.  `DefaultCss` (`~/Resources/Shared/stylesheets/dnndefault/x.x.x/default.css`, priority 5) — The default CSS for the website.  As of DNN 8, there is a new version of default.css, but version 7 is loaded by default.  A theme can choose which version to load or not load a default.css file at all.
2.  `AdminCss` (`~/Portals/_default/admin.css`, priority 6) — The admin CSS for the website.
3.  `FeatureCss` (`~/Resources/*/*.css`, priority 7) — Some CSS for shared DNN resources such as autocomplete, countries/regions, and drag & drop.
4.  `IeCss` (`~/Portals/_default/ie.css`, priority 8) — CSS loaded to handle quirks in Internet Explorer.
5.  `ModuleCss` (`~/DesktopModules/*/module.css`, priority 10) — The CSS for every module type that appears on the page.
6.  `ResourceCss` (`~/Resources/*/*.css`, priority 12) — Some CSS for shared DNN resources such as file upload, password strength, and cookie consent.
7.  `SkinCss` (`~/Portals/*/Skins/*/skin.css`, priority 15) — The master CSS for the theme must be called `skin.css`.
8.  `SpecificSkinCss` (`~/Portals/*/Skins/*/*.css, priority 20) — The CSS for a specific layout template, the CSS file name will match the layout file name, e.g. `Home.ascx` and `Home.css`.
9.  `ContainerCss` (`~/Portals/*/Containers/*/container.css, priority 25) — The master CSS for all containers in your theme.
10.  `SpecificContainerCss` (`~/Portals/*/Containers/*/*.css, priority 30) — The CSS for a specific container, the CSS file name will match the container file name, e.g. `Banner.ascx` and `Banner.css`.
11.  `PortalCss` (`~/Portals/*/portal.css`, priority 35) — The CSS that website administrators can edit through DNN, useful for creating site-specific overrides for styles.
12.  `DefaultPriority` (priority 100) —  If a priority is not specified, all other CSS files are loaded with this default priority.  This includes the _Page Stylesheet_, which can be set in the settings for a page.  The filename entered in that setting will be a path to a file in the site's file system (e.g. `home.css` will refer to `~/Portals/0/home.css` for a page in the site with ID `0`).  There is no guarantee about ordering within a single priority, so the _Page Stylesheet_ can load before and/or after other stylesheets loaded at `DefaultPriority`.
> [!NOTE]
> These style sheets are not required. You can also store all your styles in one master theme style sheet (skin.css). However, if you combine your container styles and your theme styles in one CSS file, then the container will display properly only when used with your theme.
>
>  Theme and module developers can load their own CSS files by calling the method `ClientResourceManager.RegisterStyleSheet` or using the `DnnCssInclude` control.  If priority is not specified in these calls, `DefaultPriority` will be used.  For modules and themes, a priority at or near `ModuleCss` and `SkinCss` are probably more correct, so that themes can more easily override module styles and administrators can more easily override theme styles.

## Steps

1.  Create the master style sheet for your theme (skin.css).

    Include:

    *   Common styles for all layout templates in your theme.
    *   Styles for **theme objects** used in all your layout templates.

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
