---
uid: relnotes-2014-aug-14
locale: en
title: DNN Release Notes — 2014 Aug 14
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Aug 14

## DNN PLATFORM 7.3.2

*   Fixed backwards compatibility issue with 3rd party control panels.
*   Fixed issue in the drag and drop functionality of the File Uploader in IE 11 and Safari.
*   Fixed issue where users were able to create pages with the same name.
*   Fixed issue that affected older versions of DNN that do not include the maxAllowedContentLength during upgrade.
*   Fixed issue that stopped some skins from being upgraded to newer versions.
*   Fixed issue that randomly showed an unexpected error during user registration.
*   Fixed runaway threads that caused high CPU usage.
*   Implemented new functionality that resizes large images posted on the Journal.
*   Modified the API so that getModuleDefinitions uses the Definition Name and not the Friendly Name.
*   Fixed issue where the page size setting in the user account did not persist after update.
*   Fixed issue where share assemblies were removed after uninstalling 3rd party modules.
*   Fixed issue where the LoadQueueFromTimer did not pass the IISAppName.
*   Fixed CDN setting issue for JavaScript libraries.
*   Fixed issue in DAL2 when SQL started with `WITH`.
*   Fixed issue in the menu that made IE in Windows Phone OS to not work properly.
*   Fixed issue where the URL Parameter in Google Analytics was not being used.
*   Security:
    *   Improved captcha logic against automated registration attacks

## EVOQ 7.3.2

EVOQ CONTENT

*   All updates included with DNN Platform 7.3.2.
*   Improved Captcha logic and mitigated against automated registration attacks.
*   Changed user biography field to be a multi-line text box instead of rich text.
*   Changed to hide the profile page of an unverified user.
*   Added `rel=nofollow` on Login and Register links.
*   Show User Folder Path for Administrators.
*   Fix for Layout on User Profile Page using SSL.
*   Fixed issue with blurry profile pictures on Journal.

EVOQ ENGAGE (EVOQ SOCIAL 1.3.0)

*   Introduced Group Spaces and Directory which provide an enhanced set of features and options for social groups versus previous releases.
    *   Group Directory allows groups to be searched, created, tagged, moderated and managed in a fashion similar to the rest of Evoq Social and it is also tightly integrated with gaming mechanics.
    *   Group Spaces provides more tools for group owners and administrators to help potential members find their groups (if public), as well as ways to invite new members through notifications or email.
*   The ability to see who liked a comment has been surfaced across the modules as well as the activity stream.
*   Simplified the blog entry authoring experience.
*   Added the ability to associate a primary image with a blog entry, this is then utilized by list views and Social Sharing.
*   Unauthenticated users can now post a comment in the blog, and either sign in or register as they submit the comment.
*   Community Managers, or anyone with edit permissions, can now see who voted on an Idea and how many votes they committed.
*   The activity stream now does a check to see if new content was added to the stream since the user has viewed the page, if new content was added it lets them know.
*   Added additional scoring actions to allow rewarding of likes across the various modules.
*   Updated several modules to be responsive which weren't handled in the previous release: User Badges, Leaderboard, My Status (Expanded view for profile).
*   The CSS across modules has been reduced, simplified and refactored.
*   Made the analytics task run in batches in situations where lots of data was introduced in a short period of time (this can be a new site or import situations).


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.02](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.03.02)