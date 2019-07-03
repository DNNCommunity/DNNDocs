---
uid: relnotes-2014-mar-19
locale: en
title: DNN Release Notes — 2014 Mar 19
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Mar 19

## DNN PLATFORM 7.2.2

*   Fixed issue where Display Name was editable when when a Display Name format was specified.
*   Fixed issue with Portal Templates and modules that are configured to Display On All Pages.
*   Enhanced so that system confirmation is required when Unregistering a User Account.
*   Changed default module output caching provider from disk to memory.
*   Ensure that system modules are identified in the system so they cant be uninstalled.
*   Added a querystring parameter that allows you to hide the control panel.
*   Added a detailed message when deleting a page with child pages.
*   Added an alternate link with "hreflang" to sitemap.aspx for multilingual websites.
*   Disabled autocomplete on password strength controller.
*   Advanced search tags allow html/script and can break rendering.
*   Fixed issue where exceptions were thrown if old user profiles are missing during indexing.
*   Fixed Journal API to allow edited Comments to be liked.
*   If a custom Register page is specified, prevent user from browsing to Register.aspx.
*   Fixed JavaScript error in Digital Asset Manager module in IE8.
*   Changed tokens in module creator templates so they do not show up as errors in Visual Studio.
*   Added a confirmation prompt when deleting modules from Page Management.
*   Fixed Site Management so you can filter by "ALL".
*   Fixed thread safety issue in DotNetNuke.Common.Utilities.ImageUtils where imgWidth and imgHeight were statics.
*   Fixed link to app gallery.
*   Fixed ability to specify an Upload To location when uploading files.
*   Fixed issue with IconBar in DNN 7.2.0+.
*   Reduced scope of dnn.DropDownList.css.
*   Improved performance of Update Host Settings which caused too many cached objects to be removed.
*   Fixed Password Reset so that it is hidden after a duccessful entry.
*   Improved editing style for SQL Module.
*   Allow Default skins to be removed.
*   Fixed exception when Editing a registered user for the first time.
*   Allowed sub*sub menus to be accessible in default skin.
*   Optimized indexes on Eventlog Table.
*   Allow password banned list to be disabled.
*   Allow Page URLs to contain spaces.
*   Fixed numerous typos in resource files.
*   Optimized indexes on TabModules table.
*   Optimized indexes on Tabs table.
*   Optimized indexes on Permissions tables.
*   Fixed deny permissions for Folder.
*   Added ability to add new Folder Provider.
*   Fixed error so that non*members can join a Private Group.
*   Optimized logic of numerous stored procedures and views.
*   Allow a custom URL with different domain.
*   Allow host user to set max upload size.
*   Fixed issue when switchinf to layout mode on Site Settings page.
*   Allow CAPTCHA to be used on reset password page.
*   Fixed Profile Picture Handler to work in SSL Offloading configuration.
*   Enhanced DDR Menu to be Touch Friendly for Mobile and Tablets.
*   Added basic Robots.txt in root folder.
*   Fixed Password Retrieval issue.
*   Fixed issue where Language detection was not working with advanced URL management.
*   Fixed issue where IUpgradable did not fire from a Library type extension.
*   Enhanced file upload control to support folders with large volumes of files.
*   Enhanced file upload to be able to upload from URL.
*   Fixed issue where additional parameters passed as string array in NavigateURL() and EditUrl() are ignored.
*   Optimized search query sent to Lucene.
*   Enhancement to allow separate modules to use the same module definition name.

## EVOQ 7.2.2

EVOQ CONTENT

*   All updates included with DNN Platform 7.2.2.
*   Added new Print button to Commerce receipts.
*   Implemented change to allow Vanity URLs in unicode based languages.
*   Implemented change to allow redirected pages and their child pages to be copied.
*   Fixed various installation errors.
*   Fixed error when javascript CDN enabled.
*   Fixed issue with adding Folder Types in File Manager.
*   Fixed error for search results on external DNN websites.
*   Fixed problem with incorrect extensions image path breaking Extensions page.
*   Fixed issue switching to/from SSL using client redirect.

EVOQ ENGAGE (EVOQ SOCIAL 1.1.1)

*   Localized additional items that were not localizable before (for translations) and corrected several bugs found when running in other languages.
*   Improved the date and time selection experience in Social Events.
*   Added content notifications (for people subscribed to a specific Question) for up-votes.
*   Added content notifications (for people subscribed to a specific Idea) for votes assigned.
*   Added ability to manage which companion modules (like Answers Subscriptions) are displayed on the page in an intuitive fashion.
*   Separated leaderboard templates from mode behavior, now you can choose ranking or top contributors mode and any template.
*   Corrected several problems in Leaderboard and My Status when used across multiple portals.
*   Additional minor bug fixes and improvements were also part of the release.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.02)