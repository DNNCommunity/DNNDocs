---
uid: relnotes-2013-jan-09
locale: en
title: DNN Release Notes — 2013 Jan 09
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 Jan 09

## DOTNETNUKE PLATFORM 7.0.1

*   Fixed issue in sitemap priority when hosting services uses commas instead of dots as decimal separators. This issue affects directly to the no technician user of portal.
*   Fixed issue where files with special characters were not encoded correctly in the URL.
*   Fixed error that caused settings not to be saved from the page management module.
*   Fixed issue in the device redirection module where the isTablet or Both options were not being enabled when upgrading to the 51Degrees Basic data.
*   Fixed issue where the hyperlink manager threw an exception when running in debug mode.
*   Fixed issue in the editor provider dialog that caused "My Folder" not to be shown.
*   Fixed issue in the Journal where clicking the Get More button threw an authorization error.
*   Fixed issue that stopped users from deleting role groups.
*   Fixed module permissions issue when the editor has permissions to edit a module but not the page.
*   Fixed issue where autosave was not enabled by default when upgrading from CE to PE or EE.
*   Fixed error when sending a friend request to a member of a child site when the sites are in a group.
*   Fixed issue in the Journal where the text box would hide when commenting on an existing comment.
*   Fixed issue in the control panel where the module list would not work correctly with Firefox 17.
*   Fixed issue that caused only one component to be shown when adding multi-component modules to a page.
*   Fixed UI issue that caused the control panel to not hide when the HTML Editor is set to full screen mode.
*   Fixed issue where lists with large recordsets didn't be display all records.
*   Fixed issue that made images not clickable in the Journal.
*   Fixed issue that caused the Image or File Upload icons in the Journal not to work when using Firefox 17.
*   Fixed issue that made the Taxonomy module unavailable.
*   Fixed issue when using jquery tabs.
*   Added horizontal scrolling to grids with large record sets.
*   Removed the Feed Explorer module from the package.
*   Added the isSmartPhone property to the device redirection module when upgrading to the Basic or Premium data.
*   Optimized the messaging and notifications html / css to maximize the default.css inheritance.
*   Fixed issue where the user was not able to download language packs from the host - languages section.
*   Security:
    *   Enhanced the code that generates profile pictures to avoid performance problems.
    *   Enhanced the member search to avoid data compromise..
    *   A number of browsers incorrectly implement a particular HTML tag, in violation of the official W3C standards. Defensive coding was added to avoid the possibility to use this tag to redirect requests for certain files to another site.
*   Updated modules:
    *   File Manager
    *   Pages Module
    *   Taxonomy Manager
    *   HTML Editor
    *   Journal
    *   Member Directory Module
    *   Device Detection and Redirection Module

## DOTNETNUKE PLATFORM 6.2.6

[CodePlex](https://dotnetnuke.codeplex.com/releases/view/100072)

*   Fixed issue that cause the member avatars to not show in the Member Directory.
*   Security:
    *   Enhanced the code that generates profile pictures to avoid performance problems.
    *   Enhanced the member search to avoid data compromise..
    *   A number of browsers incorrectly implement a particular HTML tag, in violation of the official W3C standards. Defensive coding was added to avoid the possibility to use this tag to redirect requests for certain files to another site.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.01)