---
topic: create-container
locale: en
title: Create a Container
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: designers-creating-themes-overview
previous-topic: create-layout-template
next-topic: create-css
related-topics: theme-objects,about-themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](http://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](http://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](http://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](http://www.10poundgorilla.com)"]
---

# Create a Container

A container is similar to a layout template, except a container's scope is a single pane, whereas a layout template's scope is the entire page. A container is associated with a module, which can generate dynamic content or perform other functionality.

Containers allow designers to seamlessly integrate modules from many different developers into a cohesive website design. Containers can also include visual elements that allow website users to interact with the module.

*   You can have a default container, which would be overridden by individual panes or modules if they provide their own style definitions.
*   You can use different containers in a single page.
*   You can mix and match any container with any CSS.

## Prerequisites

[A local DNN installation](set-up-dnn) with **Host** permissions.

## Steps

1.  Create a new file for the container.
    
    Note:
    
    *   The container must contain exactly one pane called `ContentPane`.
    *   The single pane must be defined as a server control by adding `runat="server"` to the element.
    *   A pane can be one of the following HTML elements: <td> (table cells), <div>, <p>, and <span>.
    *   (Optional) You can add the attribute `visible="false"` to the pane to prevent it from being displayed if no module is assigned to it.
    
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
    
    ACTIONBUTTON
    
    Displays an action from the module action menu.
    
    ACTIONBUTTON
    
    Displays an action from the module action menu.
    
    DROPDOWNACTIONS
    
    Displays the module action menu as a dropdown list.
    
    ICON
    
    Displays the module icon.
    
    PRINTMODULE
    
    Displays a link for the Print action from the module action menu.
    
    TITLE
    
    Displays the module title.
    
    VISIBILITY
    
    Displays a visibility control for the module allowing users to show or hide a given module on the page.