---
uid: relnotes-2012-nov-28
locale: en
title: DNN Release Notes — 2012 Nov 28
dnnversion: 09.02.00
---

# DNN Release Notes — 2012 Nov 28

## DOTNETNUKE PLATFORM 7.0.0

*   Fixed issue that caused profiles of deleted users to be available.
*   Removed the postback after checkboxes are selected in Page Settings > Taxonomy.
*   Implemented the functionality required to edit security role names and social group names.
*   Fixed JavaScript error when using a ";" semicolon as a profile property.
*   Fixed issue when using DateTime properties in profiles.
*   Fixed viewstate error when using Facebook authentication in conjunction with "require valid profile for login".
*   Fixed issue where cached pages were not sending Content-Type in the response header.
*   Fixed issue where deleting the razor host module caused the razorhelpers to be deleted too.
*   Fixed issue where users could not upload a profile picture when a site belonged to a site group.
*   Fixed issue where the Journal ignores the page size setting.
*   Fixed issue where URLs were incorrect after moving a site with site groups enabled to a new serer.
*   Fixed issue in the Journal that made image thumbnails not clickable.
*   Fixed issue in the Journal where images were played like youtube videos.
*   Security:
    *   Fixed issue in the Member Directory module that could show members to non authenticated users.
    *   Fixed issue in the Lists module that could potentially be used for script / html injection.
    *   Fixed issue in Module's titles that would allow users to enter html or JavaScript code.
    *   Fixed issue where some validation was missing when uploading profile pictures.
*   Updated modules:
    *   File Manager
    *   Journal
    *   Member Directory
    *   Message Center
    *   My Modules
    *   Social Groups


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.00)