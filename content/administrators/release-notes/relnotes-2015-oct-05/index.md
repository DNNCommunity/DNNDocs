---
uid: relnotes-2015-oct-05
locale: en
title: DNN Release Notes — 2015 Oct 05
dnnversion: 09.02.00
---

# DNN Release Notes — 2015 Oct 05

## DNN PLATFORM 7.4.2

*   Added upgrade support from beta release.
*   Fixed issue with lists in custom registration form.
*   Fixed issue with ignore words in Italian and French.
*   Fixed issue with site export in multi-language site.
*   Fixed issue where parameters in return URL were malformed.
*   Fixed issue in sitemap for multi-language site.
*   Fixed issue where control panel did not render links correctly in SSL offload environments.
*   Fixed issue where pages with future start date were inaccessible.
*   Fixed multiple password reset issues.
*   Fixed issue where site settings could be duplicated.
*   Fixed issue where dismissing all notifications removed messages as well.
*   Fixed issue where file link for missing file caused exception.
*   Fixed issue where localized portal settings were not getting applied when switching languages.
*   Fixed issue where admin was unable to change interface language.
*   Fixed issue where page name uniqueness was applied cross language.
*   Fixed multiple scheduler issues.
*   Security:
    *   Fixed issue where users could get registered even though User Registration was set to none (medium).
    *   Fixed potential XSS issue when using tab controls (low).

## EVOQ 8.2.0

EVOQ CONTENT BASIC

*   All updates included with DNN Platform 7.4.2.
*   Added mobile view and support for the Persona Bar's Recycle Bin and Workflow sections.
*   HTML WYSIWYG editor updated to a newer version.
*   Made content layout a true module. This allows more options for features like "Display on All Pages" and for copying to other sites/pages.
*   Additional minor enhancements and bug fixes.

EVOQ CONTENT

*   All updates included with Evoq Content Basic 8.2.0.
*   Added region support to content personalization (requires purchase of GeoIP data from MaxMind).
*   Added profile property support for content personalization.
*   Improved the user experience of the page-visited rule for content personalization.
*   Added RSS feed capabilities to the Publisher module.
*   Added Search companion modules to allow multiple ways to search the Publisher module (tags, by author, text).
*   Additional bug fixes and minor enhancements.

EVOQ ENGAGE

*   All updates included with Evoq Content 8.2.0.
*   Added ability to create Zendesk tickets from topics or questions (if Zendesk connector setup).
*   Added paging support to the blog roster companion module.
*   Updated the usability of Content Exchange; search logic makes it easer to find things now.
*   Additional bug fixes and minor enhancements.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.02)