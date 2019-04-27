---
uid: about-themes
topic: about-themes
locale: en
title: About Themes
dnneditions: DNN Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: designers-overview
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[UX Guide](https://uxguide.dnnsoftware.com/)","[DNN Community Blog: DotNetNuke Skinning 101 (Part 1) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/132000/dotnetnuke-skinning-101-part-1)"]
---

# About Themes

## Components of a Theme

A DNN **theme** (formerly called a **skin**) defines the look and feel of the website. It is comprised of:

*   one or more layout templates (HTML or ASCX)
*   (optional) a style sheet (CSS) for each of the layout templates
*   (optional) a master style sheet (CSS) for all the layout templates



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

## Cascading Style Sheets (CSS)

Cascading Style Sheets (CSS files) are automatically associated with layouts and containers, if they are in the same folder and they share the same filename. Example: **MyFirstLayout.css** is associated with **MyFirstLayout.ascx**.

*   Any CSS file associated with a layout template defines how elements of the entire page are displayed.
*   Any CSS file associated with a container defines how the dynamic content is displayed within a single pane of the webpage. This ensures a unified design throughout the entire page, even if the various modules in the same page come from different creators.

If CSS files are not explicitly associated with the layouts and containers, the website's master CSS file is used. If no CSS files are associated with the website, the host's master CSS file is used.

Layouts and containers can share several CSS files or a single master CSS file.

When a layout template is applied to a webpage, any associated CSS is automatically added to the webpage. Likewise, when a container is applied to a pane, any associated CSS is automatically added to the pane.

## Theme Types

DNN supports two different types of themes: HTML and ASCX.

|**HTML**|**ASCX**|
|---|---|
|Basic theme.|Advanced theme.|
|Can be created using any HTML editor.|Requires [Microsoft Visual Studio](https://www.visualstudio.com/).|
|Automatically converted to ASCX when installed. Only the contents inside the `<body>` tag is retained (without the tag); everything else is discarded, including the entire `<header>`.|Used as is.|
|Easier to create.<br />Uses DNN tokens, which represent code that call DNN APIs. The tokens are replaced with code during conversion to ASCX.|More powerful.<br />Allows customization of code that call DNN APIs.|

Thousands of third-party modules and themes are available from the [DNN Store](https://store.dnnsoftware.com). There are extensions for sale, including versions that include the source code, as well as some free extension.

