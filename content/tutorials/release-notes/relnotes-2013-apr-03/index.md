---
uid: relnotes-2013-apr-03
locale: en
title: DNN Release Notes — 2013 Apr 03
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 Apr 03

## DNN DOTNETNUKE 7.0.5

*   Fixed issue in the Client Resource Manager where data URL's were removed when running the composite files option.
*   Fixed issue when switching language from the control panel.
*   Fixed issue that stopped the Telerik RadMenu and RadTabstring from rendering correctly when an HTML module is added to the same page.
*   Fixed issue that stopped users from changing login settings.
*   Fixed issue that stopped users from changing the settings in the event viewer..
*   Fixed post back issue when copying a page using the control panel.
*   Implemented module icon override when updating to a new version of the product.
*   Fixed image upload control rendering issue when using IE or Firefox.
*   Fixed issue that makes the dashboard fail when running SQL Azure.
*   Fixed export as XML in Dashboard feature when running on SQL Azure.
*   Fixed upgrade issue when hosting a site in SQL Azure.
*   Fixed password validation issue when adding a new user.
*   Added auto complete when searching for devices to the Device Preview Management module.
*   Fix issue when the user is upgrading DNN and recycles the app pool before calling the upgrade page.
*   Fixed support pop ups feature when creating a new module from a manifest file.
*   Fixed the To and From logic in the messaging module.
*   Security:
    *   Fixed permissions issue when uploading files through Service Framework requests.
    *   Fixed potential javascript injections on sites running multiple languages.
    *   Fixed potential javascript injections on modules that implement pop ups for edits.
    *   Implemented filters in the rich text editor to avoid the possibility of cross-site scripting issues.

## DOTNETNUKE PLATFORM 6.2.7

[CodePlex](https://dotnetnuke.codeplex.com/releases/view/104373)

*   Security:
    *   Fixed potential javascript injections on sites running multiple languages.
    *   Implemented filters in the rich text editor to avoid the possibility of cross-site scripting issues.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.05](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.05)