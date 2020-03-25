---
uid: relnotes-2014-nov-12
locale: en
title: DNN Release Notes — 2014 Nov 12
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Nov 12

## DNN PLATFORM 7.3.4

*   Fixed issue where site settings were not updating correctly in multi-language installations.
*   Fixed issue where partial site templates were not working correctly with child sites.
*   Fixed issue where links created in Telerik RadEditor were not correct.
*   Fixed issue where search results might be duplicated.
*   Fixed issue where user could not change default value for a profile property.
*   Fixed issue where a file uploaded from the web is not visible in the Host File Management.
*   Fixed issue where ControlBarController returned invalid JSON.
*   Fixed issue where you couldn't add a module in a spanish language site.
*   Fixed issue where a clustered index was missing from a search table.
*   Fixed issue where uploading an ICO file failed.
*   Fixed issue where HTML Editor Permissions were not working correctly.
*   Fixed issue where popups were not centered on the screen.
*   Fixed issue where popup iframe is not initialized correctly.
*   Fixed issue where AUM was not correctly handling 301 redirects.
*   Fixed issue where multiple region/country controls in a profile did not work correctly.
*   Added ability to save localized lists to resource file.
*   Added method to remove all subscriptions from a ContentItem.

## EVOQ 7.3.4

EVOQ CONTENT

*   All updates included with DNN Platform 7.3.4.
*   Fixed issue where the HTML module was set to draft mode after clicking the publish button without making changes.
*   Fixed issue that cause the file download statistics to not render the correct information.
*   Fixed timeout issue in GetAggregatedFile that was causing a 500 error.
*   Fixed issue where an authentication pop up was shown after viewing file properties.
*   Fixed issue where the URL of a server was not updated after changing it in the Manage Webservers Page.

EVOQ ENGAGE (EVOQ SOCIAL 2.0.1)

*   Comments now convert URLs to clickable links (Activity Stream).
*   Added ability to include video in wall posts (Activity Stream).
    *   Links from Youtube/Vimeo and others using Open Graph Protocol have preview and iframe embedded image on publish.
*   Now pulling Open Graph Protocol data when URLs are typed/pasted into wall posts (Activity Stream).
*   Added ability for moderators to accept an answer for a question author (Answers).
*   Added capability to de-select an accepted answer (Answers).
*   Added an add entry button to top portion of module, now consistent with other Social modules (Blogs).
*   Now including primary image as part of RSS feed content for entry, if available (Blogs).
*   Added ability to moderate new events (Events).
*   Added support for commenting (Wiki).
    *   Also added privileges for commenting unmoderated, editing own comments and integrated with gaming mechanics.
*   Added edit own comment privileges across all Social modules.
*   Made publishing experience consistent across Social modules.
    *   Approval checkbox in UI when applicable, single button instead of two.
*   Added auto-subscribe capability throughout Social modules (when commenting, positive voting, etc.).
*   Performance updates: Analytics, Activity Stream, Group Spaces, Base platform.
*   Added search tracking mechanics action to each module.
*   Improved experience on Windows Phone 8 devices.
*   Changed mobile modals to look inline.
*   Changed chart axis scaling in dashboard to make better use of space.
*   Added Sitemap providers for the 6 main modules (SEO).
*   Made paging links in modules use proper anchor tags (SEO).


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.04](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.04)