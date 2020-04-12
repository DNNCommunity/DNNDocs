---
uid: event-system
locale: en
title: Event System
dnnversion: 
---

# Event System

## What is the Event System?

Using the core event system, you can attach custom C# event handlers to hook into various core events that happen throughout DNN Platform.
The events that you hook into are can be categorized as theme (skin) events, container events and general system events. The general system events span various areas of the platform including users, the file system, modules and pages.

## Theme (Skin) Events

Theme events happen during the server side skin load lifecycle of any page when it is being accessed.

You can attach code to the following Theme events: 

> OnSkinInit
> OnSkinLoad
> OnSkinPreload
> OnSkinUnload

## Container Events

Container events happen during the container load lifecycle of every container on a page when a page is being accessed.

You can attach code to the following Container events: 

-	OnContainerInit
-	OnContainerLoad
-	OnContainerPreRender
-	OnContainerUnLoad


General System Events

Coming Soon
