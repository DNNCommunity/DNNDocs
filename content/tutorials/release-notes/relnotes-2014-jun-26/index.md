---
uid: relnotes-2014-jun-26
locale: en
title: DNN Release Notes — 2014 Jun 26
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Jun 26

## DNN PLATFORM 7.3.1

*   Updated jQuery.RequestRegistration to also include jquery-migrate, which many third-party skins rely on.
*   Added back missing API methods to preserve binary compatibility.
*   Update 51 Degrees V3 to the latest assembly and data file.
*   Fixed case sensitivity issues with the scheduler and server names.
*   Rollback change to exclude portal.css by default.
*   Rollback to previous version of SharpZipLib assembly to preserve backward compatibility.
*   Fixed permission grid so that you can add additional roles.
*   Fixed user profile page alignment issues.
*   Fixed upgrade issue installing Knockout.
*   Fixed refactoring issue that would cause issues creating new pages.

## EVOQ 7.3.1

EVOQ CONTENT

*   All updates included with DNN Platform 7.3.1.
*   Upgraded to the latest Device Detection Library (51 degrees).
*   Fixed case-sensitive server check in webfarm management.
*   Changed 7.3 behaviour to always include portal.css.
*   Changed of legacy API methods from removed to deprecated.
*   Fixed issue in Permissions grid when using 'All Roles'.
*   Replaced ICSharpCode.SharpZipLib.dll with SharpZipLib.dll.
*   Updated old jQuery Request Registration to always include jquery-migrate.

EVOQ ENGAGE (EVOQ SOCIAL 1.2.0)

*   Made comment experience consistent across modules and Activity Stream, where applicable.
*   Enhanced Like Experience to provide more details in Activity Stream and several Social modules.
*   Enhanced Answers and Wiki list UI's for usability.
*   Moved to Platform subscriptions, in upgrade scenarios the data is migrated.
*   Notifications in Social are now streamlined, these now include direct links to all content.
*   Added Social Editor and integrated into 6 main Social modules.
*   Performance Improvements around SQL queries, space usage and reduced amount of data sent to the browser across all Social modules.
*   Added mobile support for most user facing Social modules.
*   Additional minor bug fixes and improvements were also part of the release.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.01)