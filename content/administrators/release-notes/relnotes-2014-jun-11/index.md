---
uid: relnotes-2014-jun-11
locale: en
title: DNN Release Notes — 2014 Jun 11
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Jun 11

## DNN PLATFORM 7.3.0

*   Page markup reduction - intelligent resource management
    *   Removal of unnecessary Viewstate — Home page 4005 bytes down to 90 bytes.
    *   YSlow base score improvement (7.2.2 80/Grade C -> 7.3.0 93/Grade A).
    *   25% reduction in page size for home page requests.
*   Extra caching and streamlining of database calls.
    *   Granular management of objects in cache to reduce cache rebuilds.
    *   Reduced database activity in high transaction scenarios.
    *   Tested sites with up to 100 portals — no significant performance impact.
*   New 51 Degrees implementation.
    *   New lookup algorithm is 100x faster.
    *   Zero memory consumption.
    *   Can be disabled if required.
*   Admin UI Updates for increased Admin page load speed.
    *   File picker/upload control updated for drag/drop.
    *   User Permissions Grid optimized for active roles only.
*   Add Module Control bar improvements.
    *   Bookmarking for favorite Modules.
    *   Search feature for finding modules.
    *   Lazy load feature to speed panel load.
    *   Improved scrolling.
*   Scheduled tasks improvement for better control over jobs.
    *   More granular control over jobs including ability to set a start date/time.
    *   Delayed initialization for faster application startup.
*   Folder Provider Improvements.
    *   Ability to create new sites with the site root Folder on remote storage — separating user data from application data. Other Improvements.

## EVOQ 7.3.0

EVOQ CONTENT

*   All updates included with DNN Platform 7.3.0.
*   Web Server Control.
    *   Simplified Web Server Management UI.
    *   Eliminating Site Alias dependency for Web Servers.
    *   Multiple Server Groups for staging/production using backup/restored database.
    *   Optimized for Cloud based systems with dynamic servers in autoscale.
*   Scheduled tasks improvement for better control over jobs.
    *   Automatically transfer control of single-server tasks to new servers when server removed from webfarm.
*   Folder Provider Improvements.
    *   Optimized Synchronization using ETags for Cloud Providers reduces synch time from minutes to seconds.
    *   Saving/Restoring modules with content and settings.
*   New Page Publish option for pushing Admin-only pages to All Users with single click.
*   Many UI and functionality bugs fixed.

EVOQ ENGAGE (EVOQ SOCIAL 1.1.2)

*   Added ability to moderate new comments in Blogs.
*   Added ability to edit comments and replies within the 6 main user driven content modules (as comment author, moderator, etc.).
*   Added group mode support to additional modules (Answers, Wiki, Blogs).
*   Added ability to delete Wiki articles.
*   Improved date and time selection in Blogs (to match Social Events).
*   Corrected several problems in multi-culture installs.
*   Additional minor bug fixes and improvements were also part of the release.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.00)