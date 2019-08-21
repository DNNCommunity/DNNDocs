---
uid: themes
locale: en
title: About Themes
dnnversion: 09.02.00
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[UX Guide](https://uxguide.dnnsoftware.com/)","[DNN Community Blog: DotNetNuke Skinning 101 (Part 1) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/132000/dotnetnuke-skinning-101-part-1)"]
---

# About Themes

## Components of a Theme

A DNN **theme** (formerly called a **skin**) defines the look and feel of the website. It is comprised of:

*   one or more layout templates (HTML or ASCX)
*   (optional) a master style sheet (CSS) for all the layout templates
*   (optional) a style sheet (CSS) for each of the layout templates



![Three variations of a theme](/images/gra-SkinTheme.png)



## Layouts and Containers



![Pane in a layout](/images/gra-PaneLayout.png)



A **pane** is a section of a webpage that displays static content, dynamic content, or a standard theme object.

A **layout template** defines where panes are located on the webpage and what each pane contains. The layout templates included in a theme are variations that the web designer can choose from for each page in the website, such as the home page, a gallery of photos, or a listing of products for sale.

A **container** is similar to a layout template, except a container's scope is a single pane, whereas a layout template's scope is the entire page. A container is associated with a **module**, which can generate dynamic content or perform other functionality.

*   The layout template must contain one or more panes. A container has exactly one pane; additional panes are ignored.
*   Exactly one of the panes must be called `ContentPane` (case-insensitive).
*   Each pane must have a name that is unique within the page.
*   All panes must be defined as a server control by adding `runat="server"` to the element.
*   A pane can be one of the following HTML elements: `<td>` (table cells), `<div>`, `<p>`, and `<span>`.

Layouts and containers can contain a **theme object**, which can be a typical component of a webpage, such as the menu bar, the copyright notice, the login/registration links, the privacy link, the terms of service link, and the search box. Theme objects are inserted in the HTML or ASCX as tokens.


## Theme application Levels
There are several levels at which a DNN Theme can be applied:

### Fallback Layout and Container
This is the Layout and/or Container that will be loaded when an error arises in one of the assigned Layout's or Container's ascx file.
Normally this should only happen during the development stage of a Theme or after a DNN upgrade, when the existing Theme uses legacy code or Theme objects.
This setting can be found in the **DotNetNuke.config** file in the root of the DNN installation.
The XML needs to be modified to change the Fallback skin:
  
~~~html
<skinningdefaults>
  <skininfo folder="/Xcillion/" default="Inner.ascx" admindefault="Admin.ascx" />
  <containerinfo folder="/Xcillion/" default="Title_h2.ascx" admindefault="Title_h2.ascx" />
</skinningdefaults>
~~~

*Normally you only need to change this when you uninstall an older DNN default skin*

### Portal Layout and Container
The Layout you set for the Portal will be applied to all pages unless you overrule this at the page level.
The same goes for the Portal Container, it will be applied to all Modules in the Portal.
  
### Page Layout and Container
The Layout and/or container you set for a Page, will overrule the Portals Layout & container. 
> [!NOTE]
> Child pages do not automatically inherit this setting. You can manually copy this to all child pages, but new child pages will not inherit the Page Layout or Container.*

### Module Container
In the Module settings, you can set a specific Container for that Module. This will overrule the previous settings, but only for that Module.

### Pane Container
In some cases, you may know that modules within a certain Pane in the layout all need a specific Container.
In that case, to make the life of a site Administrator easier, you can set the default Container for the Modules placed in that Pane.
This will override the settings for the Portal and the Page, but not for a module. 
Any module placed in that Pane will load the assigned Pane Container, unless this has been explicitly set in the Module settings.
You cannot make this change in the DNN Admin interface. Instead, you change this in the `[Layout].ascx` file.
Set the Pane container in your `[Layout].ascx` file by adding the `**ContainerSrc**` attribute.
The path should consist of the Containers Root Folder name and the name of the `[Container].ascx` to load.

~~~html
<div class="pane pane-bottom" id="BottomPaneFullWidth" ContainerSrc="MyContainer/NoTitle.ascx" runat="server" />
~~~

## Cascading Style Sheets (CSS)

Cascading Style Sheets (CSS files) are automatically associated with layouts and containers, if they are in the same folder and they share the same filename. Example: **MyFirstLayout.css** is associated with **MyFirstLayout.ascx**.

*   Any CSS file associated with a layout template defines how elements of the entire page are displayed.
*   Any CSS file associated with a container defines how the dynamic content is displayed within a single pane of the webpage. This ensures a unified design throughout the entire page, even if the various modules in the same page come from different creators.

If CSS files are not explicitly associated with the layouts and containers, the website's master CSS file is used. If no CSS files are associated with the website, the host's master CSS file is used.

Layouts and containers can share several CSS files or a single master CSS file.

When a layout template is applied to a webpage, any associated CSS is automatically added to the webpage. Likewise, when a container is applied to a pane, any associated CSS is automatically added to the pane.

## Theme Types

DNN supports two different ways of creating themes using: HTML and ASCX files.
The HTML files offer an easier way to get into DNN theming since DNN will convert the HTML file to an ASCX file and use that ASCX file as the actual theme.

|**HTML**|**ASCX**|
|---|---|
|Basic theme.|Advanced theme.|
|Can be created using any HTML editor.|Easier to edit using [Visual Studio Code](https://code.visualstudio.com/) or [Microsoft Visual Studio](https://www.visualstudio.com/).|
|Automatically converted to ASCX when installed. Only the contents inside the `<body>` tag is retained (without the tag); everything else is discarded, including the entire `<header>`.|Used as is.|
|Easier to create.<br />Uses DNN tokens, which represent code that call DNN APIs. The tokens are replaced with code during conversion to ASCX.|More powerful.<br />Allows customization of code that call DNN APIs.|

Thousands of third-party modules and themes are available from the [DNN Store](https://store.dnnsoftware.com). There are extensions for sale, including versions that include the source code, as well as some free extension.

