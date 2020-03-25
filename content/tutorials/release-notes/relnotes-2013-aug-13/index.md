---
uid: relnotes-2013-aug-13
locale: en
title: DNN Release Notes — 2013 Aug 13
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 Aug 13

## DNN PLATFORM 7.1.1

*   Fixed issue where vanity URL was not working correctly in FireFox.
*   Fixed issue where default Friendly URL setting was missing for the doNotRewriteRegex.
*   Fixed issue where language URLs were not working.
*   Fixed issue where adding a new page resulted in an error message.
*   Added the ability to define a standard prefix to vanity URLs.
*   Fixed issue where the unauthenticated role permissions were not being applied.
*   Fixed issue where password strength meter was missing for sites upgraded to 7.1.
*   Fixed issue where the Search Admin was missing a resx file in the mobile site template.
*   Updated RadControls for ASP.Net Ajax to the Q2 2013 release.
*   Fixed issue where hard-deleting a user resulted in an error.
*   Fixed issue where localization would stop working.
*   Fixed issue where progress bar does not show any progress in the Digital Asset Manager.
*   Fixed issue where removing a custom page URL causes a redirect to the home page.
*   Fixed issue where language aliases are not created when importing a site with content localization.
*   Fixed issue where upgrades from 6.1.5 would cause numerous error log entries regarding potentially dangerous request.
*   Fixed issue where disabling anonymous authentication with AD provider installed causes 404 error.
*   Security:
    *   Fixed potential reflective xss issue.
    *   Fixed issue where malformed html may allow XSS.
    *   Fixed issue that could lead to redirect 'Phishing' attack.

## DOTNETNUKE PLATFORM 6.2.9

[CodePlex](https://dotnetnuke.codeplex.com/releases/view/110758)

*   Security:
    *   Fixed potential reflective xss issue.
    *   Fixed issue where malformed html may allow XSS.
    *   Fixed issue that could lead to redirect 'Phishing' attack.

## EVOQ 7.1.1

EVOQ CONTENT

*   All updates included with DNN Platform 7.1.1.
*   Fixed performance issue when creating a site group with a large set of users.
*   Fixed issue where an exception was being thrown when viewing documents statistics in Document Library and using IE 10.
*   Fixed issue in the Digital Assets Manager Module where empty .txt files were getting deleted.
*   Fixed issue that was causing an error in the single sign on functionality when Active Directory was used.
*   Added new functionality to the Digital Assets Manager module to allow users to set a default folder type when creating new folders.
*   Fixed issue where only the root folder was being extracted when doing a zip upload with the unzip option checked.
*   Fixed issue in the Digital Assets Manager module where .xlsx icons were not being shown.
*   Fixed issue in the Client Dependency Framework where an exception was thrown when using GethostByAddress.
*   Enhanced security in the Journal module so that unverified users cannot access the information.
*   Fixed issue in the Digital Assets Manager module where users with full control privileges were not able to upload documents.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.01.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.01.01)