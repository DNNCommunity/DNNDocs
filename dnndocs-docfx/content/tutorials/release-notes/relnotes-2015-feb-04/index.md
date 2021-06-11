---
uid: relnotes-2015-feb-04
locale: en
title: DNN Release Notes — 2015 Feb 04
dnnversion: 09.02.00
---

# DNN Release Notes — 2015 Feb 04

## DNN PLATFORM 7.4.0

*   Added Workflow and versioning API.
*   Added multilanguage support to Site Settings.
*   Fixed issues where core platform rendered non-HTML5 compliant markup.
*   Refactored PortalSettings and Eventlogs to better support future enhancements.
*   Enhanced User Search to include email and username.
*   Removed obsolete meta tags.
*   Updated 51Degrees to 3.1.9.3.
*   Added HTML Editor Manager module.
*   Fixed issue where enabling content localization fails with multiple languages installed.
*   Fixed issue where password reset error prevented updating password.
*   Added localization support for Persian.
*   Added localization support for additional culture code formats.
*   Fixed issue where profile properties were not displayed using UTF-8.
*   Fixed issue where scheduler would fail when large number of history items existed.
*   Fixed issue where scheduler would fail with InvalidOperationException.
*   Fixed issue where module settings could not be accessed after upgrade.
*   Fixed issue where files in folder providers were not deleted properly.

## EVOQ 8.0.0

EVOQ CONTENT BASIC

*   All updates included with DNN Platform 7.4.0.
*   Created a new content authoring experience exposed to Content Managers and Content Editors (new roles) through the Persona Bar, which replaces the Control Panel.
*   Made it possible for Content Managers to search users and assign them content editing permissions.
*   Added the Asset Manager, which replaces the File Manager and is available to Content Managers and Editors from the Persona Bar.
*   Added a new content analytics engine that allows page and site traffic to be tracked and reviewed.
*   Enhanced workflow and made it easier to configure. Also moved it from the module to page level.
*   Added a new WYSIWYG editor that also provides image editing capabilities, such as image cropping and rotation.
*   Provided a new simplified page management experience within the Persona Bar, which is exposed to Content Managers and Editors.
*   Made it possible for Content Managers and Editors to create page templates to reuse when creating new site pages.
*   Created a new Recycle Bin, which is accessible to Content Managers and Editors.
*   Added new content layout module that provides Content Editors with a way to control the layout of the content they are authoring, without requiring a new theme or knowledge of HTML.
*   Added preview capabilities for desktop, tablet, and mobile devices. The preview capabilities are exposed at the page level.
*   Simplified how pages and content are published and versioned. Also made it more accessible to Content Editors.
*   Exposed Google Analytics configuration to Content Manager.

EVOQ CONTENT

*   All updates included with Evoq Content Basic 8.0.0.
*   Added content personalization capabilities. This allows Content Editors to create personalized views of existing pages that are displayed based on a series of rules they define.
*   Added connectors to the following external products/services: Box, Dropbox, and Marketo.
*   Added a Marketo Forms module which allows forms created in Marketo to be displayed within your Evoq site.

EVOQ ENGAGE

*   All updates included with Evoq Content 8.0.0.
*   New Content Exchange — Allows you to move or copy content between multiple modules within Social (e.g., turn a topic into a question).
*   New Challenges Module — A module that is tied to gaming mechanics to help increase reach beyond your online community through your existing community (Advocacy Marketing).
*   New Member Profile — Split the Profile Dashboard module so each piece can be moved around the page. Also added the ability to see a user's activity per day (positive scoring only).
*   Leaderboard Updates — Simplified settings. Added the ability to control the interval used for display. Previously, the only display interval option was lifetime.
*   Export to Excel — All engagement reports in the dashboard now export to a single Excel file, based on selected date range at the time of the export.
*   Custom Date Range Reports — Community managers can now set the start/end dates for reports, in addition to the predefined intervals.
*   Spectators — People who have viewed but not engaged with content are now tracked in the dashboard reports.
*   Asset Manager — A file manager in the Persona Bar (what the community manager sees) also allows management of files of specific users (as a manager).
*   Activity Stream — New option to group similar items in the stream. Example: If User A earned Badge X, pictures of up to 3 other users who also recently earned the same badge are displayed.
*   Integrated mechanics / actions with CMS-related activities (edited module or page, created page or module, edited content, etc.).
*   Discussions — Added support for attachments. Requires access permissions.
*   Events — Added .ics link, so users can add the viewed event to their calendar.
*   Answers — Moderators can now see who voted on a question or answer.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.00)