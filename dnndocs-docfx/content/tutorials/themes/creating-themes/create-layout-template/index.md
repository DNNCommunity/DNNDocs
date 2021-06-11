---
uid: create-layout-template
locale: en
title: Create a Layout Template
dnnversion: 09.02.00
next-topic: create-container
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community Blog: DotNetNuke Skinning 101 (Part 1 and 2) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/132000/dotnetnuke-skinning-101-part-1)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# Create a Layout Template

A **layout template** defines where panes are located on the webpage and what each pane contains. The layout templates included in a theme are variations that the web designer can choose from for each page in the website, such as the home page, a gallery of photos, or a listing of products for sale.

*   The layout template must contain one or more panes. A container has exactly one pane; additional panes are ignored.
*   Exactly one of the panes must be called `ContentPane` (case-insensitive).
*   Each pane must have a name that is unique within the page.
*   All panes must be defined as a server control by adding `runat="server"` to the element.
*   A pane can be one of the following HTML elements: `<td>` (table cells), `<div>`, `<p>`, and `<span>`.

> [!TIP]
> ASP.NET might modify the control names (e.g., `div id`) when the page is rendered to avoid duplicate control names in a page. Instead of depending on the control name when styling, add a class attribute to each of the controls and refer to those class attributes in your CSS.

## Prerequisites

[A local DNN installation](xref:set-up-dnn) with **Host** permissions.

## Steps

1.  Create a new file for the layout template.

    A very basic layout template.

    *   HTML

        ```

            <div id="ContentPane" runat="server"></div>

        ```

    *   ASCX

        ```

            <!-- <%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %> -->
            <div id="ContentPane" runat="server"></div>

        ```


    A layout template with several panes, a header, a footer, and a LOGO theme object.

    *   HTML

        ```

            <div id="wrapper">
                <div id="header">
                    [LOGO]
                </div>
                <div id="sidebar">
                    <div id="feed">
                        <a class="feed-button" href="#"> </a>
                    </div>
                    <div id="SidebarPane" class="SidebarPane" runat="server"></div>
                    <div id="sidebar-bottom"> </div>
                </div>
                <div id="content">
                    <div id="BannerPane" class="BannerPane" runat="server"></div>
                    <div id="ContentPane" runat="server"></div>
                </div>
                <div id="footer"></div>
            </div>

        ```

    *   ASCX

        ```

            <%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Skins.Skin" %>
            <%@ Register TagPrefix="dnn" TagName="LOGO" Src="~/Admin/Skins/Logo.ascx" %>
            <div id="wrapper">
                <div id="header">
                    <dnn:LOGO runat="server" id="dnnLOGO" />
                </div>
                <div id="sidebar">
                    <div id="feed">
                        <a class="feed-button" href="#"> </a>
                    </div>
                    <div id="MySidebarPane" class="SidebarPane" runat="server"></div>
                    <div id="sidebar-bottom"> </div>
                </div>
                <div id="content">
                    <div id="MyBannerPane" class="MyBannerPane" runat="server"></div>
                    <div id="ContentPane" runat="server"></div>
                </div>
                <div id="footer"></div>
            </div>

        ```


2.  (Optional) Add theme objects to any pane for a more dynamic page.

    *   In HTML, you can use the HTML token (example: `[LOGIN]`).

        ```

            <div id="login_style" class="user">
                [LOGIN]
            </div>

        ```

    *   In ASCX, you must register the ASCX token (example: `<dnn:Login ...`) before using it for the first time in the file.

        ```

            <%@ Register TagPrefix="dnn" TagName="Login" Src="~/Admin/Skins/login.ascx" %>
            ...
            <div id="login_style" class="user">
                <dnn:Login runat="server" id="dnnLogin" CssClass="user" />
            </div>

        ```


    The following theme objects are relevant to layout templates:

    |**Theme Object**|**Description**|
    |---|---|
    |BREADCRUMB|Displays the path to the current tab (`>` is the default separator). Example: `PageName1 > PageName2 > PageName3`|
    |COPYRIGHT|Displays the copyright notice for the website.|
    |CURRENTDATE|Displays the current date on the server.|
    |DOTNETNUKE|Displays the copyright notice for DNN.|
    |HELP|Displays a **Help** link, which sends an email to the website's administrator, using the user's default email client.|
    |HOSTNAME|Displays the host title linked to the host URL. The host title and host URL are defined on the host settings page.|
    |LANGUAGE|Displays the language selector dropdown list or the language flags based on the theme object attribute settings.|
    |LEFTMENU|Displays a vertical menu layout.|
    |LINKS|Displays a flat menu of links associated with the current tab level and the parent node.|
    |LOGIN|Displays **Login** for anonymous users and **Logout** for authenticated users.|
    |LOGO|Displays the website's logo.|
    |NAV|Displays a menu according to the type specified in the ProviderName attribute.|
    |PRIVACY|Displays a link to the Privacy Information page for the website.|
    |SEARCH|Displays the search input box.|
    |STYLES|Allows you to add Internet Explorer-specific stylesheets to your theme.|
    |TAGS|Displays the **Tag** control allowing users to view and edit tags associated with the page or module.|
    |TERMS|Displays a link to the Terms and Conditions page of the website.|
    |TEXT|Displays localized text in your theme and supports the use of token replacement.|
    |TREEVIEW|Displays a menu, similar to the Windows Explorer menu, using the **DNN Treeview Control**.|
    |USER|Displays a **Register** link for anonymous users or the user's name for authenticated users.|

    > [!TIP]
    > [10 Pound Gorilla](https://www.10poundgorilla.com/)'s [Theming Tool](https://10poundgorilla.com/DNN-Skinning-Tool) is both a reference and a tool that customizes the code for DNN theme objects, based on the attribute values you specify.
