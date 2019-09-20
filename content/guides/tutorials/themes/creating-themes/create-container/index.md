---
uid: create-container
locale: en
title: Create a Container
dnnversion: 09.02.00
previous-topic: create-layout-template
next-topic: create-css
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# Create a Container

A **container** is similar to a layout template, except a container's scope is modules, whereas a template's layout (formerly Skin) scope is the entire page. A container is essentially a wrapper for a **module** and can be used to style it's content or add other functionality (advanced use cases).

Containers allow designers to seamlessly integrate modules from many different developers into a cohesive website design. Containers can also include visual elements that allow website users to interact with the module.

*   You can have a default container, which would be overridden by individual panes or modules if they provide their own style definitions.
*   You can use different containers in a single page.
*   You can mix and match any container with any CSS.

## Prerequisites

[A local DNN installation](xref:set-up-dnn) with **Host** permissions.

## Steps

1.  Create a new file for the container.

    > [!NOTE]
    >
    > *   The container must contain exactly one pane called `ContentPane`.
    > *   The single pane must be defined as a server control by adding `runat="server"` to the element.
    > *   A pane can be one of the following HTML elements: `<td>` (table cells), `<div>`, `<p>`, and `<span>`.
    > *   (Optional) You can add the attribute `visible="false"` to the pane to prevent it from being displayed if no module is assigned to it.

    A very basic container in HTML.

    ```

        <div id="ContentPane" runat="server"></div>

    ```

    A very basic container in ASCX.

    ```

        <%@ Control AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.UI.Containers.Container" %>
        <div id="ContentPane" runat="server"></div>

    ```

2.  (Optional) Add theme objects to your container for a more dynamic page.

    The following theme objects are relevant to containers:

    <table>
     <tr>
       <td>ACTIONBUTTON</td>
       <td>Displays an action from the <strong>module action menu</strong>.</td>
     </tr>
     <tr>
       <td>DROPDOWNACTIONS</td>
       <td>Displays the <strong>module action menu</strong> as a dropdown list.</td>
     </tr>
     <tr>
       <td>ICON</td>
       <td>Displays the module icon.</td>
     </tr>
     <tr>
       <td>PRINTMODULE</td>
       <td>Displays a link for the Print action from the <strong>module action menu</strong>.</td>
     </tr>
     <tr>
       <td>TITLE</td>
       <td>Displays the module title.</td>
     </tr>
     <tr>
       <td>VISIBILITY</td>
       <td>Displays a visibility control for the module allowing users to show or hide a given module on the page.</td>
     </tr>
    </table>
