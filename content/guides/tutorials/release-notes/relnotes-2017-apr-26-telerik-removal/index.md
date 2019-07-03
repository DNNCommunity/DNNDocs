---
uid: relnotes-2017-apr-26-telerik-removal
locale: en
title: Upcoming in v9.1 — Telerik Removal
dnnversion: 09.02.00
---

# Upcoming in v9.1 — Telerik Removal

## Overview of Telerik Removal

Telerik UI controls were originally introduced to DNN products to make it easier for extension developers to build UI components and to provide consistency in the appearance of various modules on a page. However, most developers have switched to lightweight client-side frameworks for UI rendering and to Microsoft's Web API for business logic. Therefore, Telerik components have become unnecessary to the core product. Removing Telerik will likely provide significant performance improvements through more efficient memory utilization, faster application start-up, and smaller page sizes.

Important: Creators of third-party modules are strongly advised to replace their dependencies on Telerik with other solutions.

## Installation

DNN Platform still ships with the Digital Asset Management (DAM) component, which requires Telerik DLLs; therefore, Telerik is still installed as part of the DNN Platform.

With Evoq, Telerik is not installed during a clean installation. However, Telerik is not removed in an Evoq upgrade either, in order to avoid breaking third-party modules that depend on it.

## Replacements

DNN plans to introduce smaller client-side libraries that developers can use instead of Telerik. The following replacements are now available.

Telerik

Replacement

Notes

RadComboBox

Recommended: [Selectize](https://selectize.github.io/selectize.js/), which is a hybrid textbox and selection box.

Also used in advanced search filter options in DNN pages.

RadScriptManager

Microsoft's ScriptManager

Previously registered on every page.

RadStyleSheetManager

(Deleted without replacement.)

Previously registered on every page.

RadAjaxPanel via DNN's DnnAjaxPanel

Microsoft's UpdatePanel control

 

DotNetNuke.Web.Deprecated.dll

DotNetNuke.Web.dll

The names of the controls might not be the same.

Telerik client-side commands to locate HTML elements. Examples:

*   `$find(#myid)`
*   `$get_value(#myid)`
*   `$get_items(#myid)`

jQuery `$('#'+id).cmd()`, where id is the HTML element identifier. Examples:

*   `$('#myid').find();`
*   `$('#myid').val();`
*   `#('#myid').get();`

 

## Packaging Changes

The following module packages have been changed.

Package

Upgrade - Platform

Upgrade - Evoq

Clean Install - Platform

Clean Install - Evoq

Telerik\_08.00.01\_Install.zip

A library package that deploys the two Telerik DLLs (Telerik.Web.UI.dll and Telerik.Web.UI.Skins.dll). The installation also adds Telerik-related handles and HTTP module entries into web.config.

Reinstalled.

Not installed; previous installations are untouched.

Installed.

Not installed.

DNNCE\_01\_Web.Deprecated\_09.01.00\_Install.zip

A new library package that contains DotNetNuke.Web.Deprecated.dll, which was previously shipped as part of the bin folder since DNN Platform 8.0.0.

Installed.

Not installed; previous installations are untouched.

Installed.

Not installed; previous installations are untouched.

RadEditorProvider\_09.01.00\_Install.resources

Previously available as an optional install package.

Not installed; previous installations are untouched.

Not installed; previous installations are untouched.

Not installed.

Not installed.
