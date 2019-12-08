---
uid: relnotes-2014-oct-01
locale: en
title: DNN Release Notes — 2014 Oct 01
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Oct 01

## DNN PLATFORM 7.3.3

*   Enhanced DDR Menu to allow menus to be filtered by page tags.
*   Enhanced messaging system to support additional tokens.
*   Enhanced core library to include extension methods for creating/manipulating XML documents.
*   Fixed issue where notifications were not updated without a page refresh.
*   Fixed issue where site management was not working correctly with site skins.
*   Fixed issue where upgrades can fail due to a versioning issue.
*   Fixed issue where foldermanager was inefficient in iterating child folders and files in a given folder.
*   Fixed issues where RadEditor provider did not work correctly in IE11.
*   Fixed issue where custom page URLs were not properly formatted.
*   Fixed issue where page settings were not properly saved for localized pages.
*   Fixed issue where sample Razor script would list all users in an installation.
*   Fixed issue where improper module manifest can break extensions page.
*   Fixed issue where social modules did not update search index appropriately.
*   Fixed issue where malformed profile urls or profile pages for deleted users caused error in event log.
*   Fixed issue where upgrades failed for case sensitive SQL collations.
*   Fixed issue where reordering tabs in one portal affected tab order in other portals.
*   Security:
    *   Failure to validate user messaging permissions.

## EVOQ 7.3.3

EVOQ CONTENT

*   All updates included with DNN Platform 7.3.3.
*   Fixed issue that was causing an error being logged when updating documents with workflow.
*   Implemented new functionality that allows users to find documents using keywords in the file metadata.
*   Fixed issue that was causing the search priority in documents to not function correctly.
*   Improved performance during document indexing to reduce CPU usage.
*   Fixed issue that was causing slashes to be removed when using advanced URL functionality.
*   Fixed issue that was causing URLs to not be updated successfully when updating the value from the Manage Web Servers Settings.

EVOQ ENGAGE (EVOQ SOCIAL 2.0.0)

*   Enhanced the Community Manager Experience:
    *   Created a new control panel that replaces Social Dashboard and Gaming Mechanics Administration.
    *   Added additional analytic tracking and reporting options.
    *   Added community health indicators.
    *   Added ability to manage users.
    *   Surfaced tasks in this area.
    *   Centralized community setting management.
*   Enabled Friendly URLs for the main 6 content oriented modules (great for SEO, also avoids duplicate page titles; cid/## will become /my-content-title).
*   Surfaced comment moderation in additional areas (Discussions, Events and Ideas).
*   Added ability to report a user which results in notifications to moderators and community managers.
    *   Users can be removed from the profile area as well.
*   Added Upcoming events view in Social Events and made it the default view, shows only events currently in progress or scheduled in the future.
*   Added ability to delete a user from the user's profile page (this is a soft-delete) as well as promote them to a moderator role.
*   Updated search control in the seven social modules that use it to be a companion module, and thus optional to show/hide for site administrators and page editors.
    *   This also exposes a new create button in the left hand footer of those modules too, to enable creation when search is not displayed (or without requiring a scroll to top for end users).

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.03](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.03)