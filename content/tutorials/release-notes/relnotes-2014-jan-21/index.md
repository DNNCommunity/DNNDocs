---
uid: relnotes-2014-jan-21
locale: en
title: DNN Release Notes — 2014 Jan 21
dnnversion: 09.02.00
---

# DNN Release Notes — 2014 Jan 21

## DNN PLATFORM 7.2.1

*   Fixed issue where .dnn7 manifest was not being utilized in module installation process.
*   Fixed issue where restored user could not change his profile avatar.
*   Added .ashx to regex filter for Do Not Redirect rule in advanced url management.
*   Added various SQL database optimizations contributed by Sebastian Leupold.
*   Fixed issue with rich text editor in Newsletters in Firefox.
*   Fixed copy page so that all properties are copied.
*   Fixed UI issue when managing Authentication providers.
*   Fixed browser compatibility issue when managing Available Modules in Site Settings.
*   Fixed defaults of billing and trial values when adding security roles.
*   Added a 404 page to the blank site template.
*   Fixed issue where config element in module manifest throws errors when XML Merge script is in separate file.
*   Fixed terminology when changing password as Administrator.
*   Fixed Console module so that it ignores pages that are not intended to be included in the menu.
*   Fixed access control so that Deny permissions always ovveride Grant permissions.
*   Fixed access control so that Navigate permission can be denied.
*   Enhanced permissions grid so that full control specification can not be overridden for specific permissions.
*   Enhanced control panel so that Stay In Edit Mode option is always available.
*   Make application FIPS compliant.
*   Fixed issue preventing DAM from being used in Group mode.
*   Fixed javascript issue in DNNMenuProvider.
*   Fixed access control so that module level permissions are observed for all individualpermission types.
*   Disabled field validation when changing countries during registration.
*   ModuleSettingsPresenterBased now instantiates ModuleSettings and TabModuleSettings.
*   Fixed exception when composing new message to user.
*   GetUserRoles will now return an empty list if the user is not valid.
*   Made Group pending notification URLs absolute.
*   Allow a user using the Windows Live authentication provider to be a member of multiple portals.
*   Removed inline style in Logo skin object.
*   Fixed Member Directory issue where the same user is displayed multiple times.
*   Added stored procedure to prevent error when uninstalling dashboard extension.
*   Improved Newsletters so you can send to Social Groups as well as Security Roles.
*   Fixed issue where page with a future publish date can not be edited.
*   Allow a user to specify both a date and time for publishing in module settings.
*   Fixed issue where UserInfo object did not contain LastIPAddress.
*   Fixed Site Group behavior so that Site Settings are populated with current portal properties.
*   Improved performance of loading folders that contain a large volume of files.
*   Fixed scheduler so that Application_Start is recognized when using Request mode.
*   Fixed search by tag functionality.
*   Fixed Users Online so that it is thread-safe.
*   Enhancement so that Google Analytics does not track admin or host user activity.
*   Enhanced Test SMTP options so that it tells you who the email was sent from and to.
*   Fixed issue preventing the closing of the "Welcome to Your Installation" pop up.
*   Search crawler enhanced to include host pages.
*   Fixed issue causing SendMail to crash when sending blank value for to, cc or bcc.
*   Fixed user profile so that users can view their friends profile info if security is set to Friends.
*   Fixed Splash page behavior.
*   Fixed issues where updating a journal item was creating a new record instead of updating existing one.
*   Fixed issue where upgrading from an older version was not cleaning up auth systems, providers and optional modules.
*   Enhanced uploading new extension experience to show progress indicator.
*   Fixed issue where User could not reply to Message.
*   Added new host setting to optionally disable critical error reports displayed in page.
*   Fixed upgrade issue if previous version of module creator was installed.
*   Fixed an issue where user folders were not deleted when a user was deleted.

## EVOQ 7.2.1

EVOQ CONTENT

*   All updates included with DNN Platform 7.2.1.
*   Implemented new functionality that allows users to open and edit Office documents on the server from the File Manager.
*   Implemented new functionality that allows users to set the root folder in the File Manager.
*   Implemented new functionality that allows users to share links to a folder or tag.
*   Implemented new functionality where if a File Manager is added to the profile page, the documents are filtered per user.
*   Implemented various performance enhancements in the File Manager.
*   Enhanced the user switcher functionality so that it can also be used by administrators (not only super users).
*   Fixed issue where only system administrators were able to approve documents in the File Manager.
*   Fixed issue where the update and cancel buttons did not close the pop up in the MyModules module.
*   Fixed issue where large files were not being uploaded to the File Manager.
*   Fixed issue where modules were still being shared after a site was removed from a group.

EVOQ ENGAGE (EVOQ SOCIAL 1.1.0)

*   All 7.1 Platform Enhancements:
    *   All user facing social modules now take full advantage of the new Search.
*   Answers:
    *   New feature: Inline comment support added for both questions and answers.
    *   Additional mechanics activities are logged.
*   Azure Compatibility.
*   Blogs:
    *   Pinned blog entry support (1.0.2).
    *   More control over HTML layout of blog list view items (1.0.2).
    *   Enhanced 'blogger bar' to include drop down selector.
*   Design updates to provide a more consistent experience across all social modules.
*   Ideas:
    *   Locking enhanced for various statuses to disallow voting.
    *   Additional mechanics activities are logged.
*   Profile Dashboard enhanced to allow more control of influence/engagement calculations.
*   Related Content updated to support tags in list views (when cid is not present in URL).
*   Social Events now also integrated with Bing maps (1.0.2).
*   Subscriptions:
    *   New feature: Module content notifications (subscribe to new questions, enties, topics, ideas, events, articles).
    *   Subscribe option added to several modules where users author content (ask question, start topic, create idea).
*   Toast skin object updated to be proper skin object so it can be used with HTML skinning.
*   New feature: Wiki (A new module slightly different from a traditional Wiki).
    *   Gaming and reputation mechanics integrated from the start (like all other social modules).
    *   Pages are called articles to avoid ambiguity with pages and tabs in the platform.
    *   Use's Dnn's page design setup to move away from Wiki content templates by exposing companion modules.
    *   Utilizes cor metadata API.
    *   Users HTML and not Wiki markup or markdown (except for page links).
    *   Table of contents automatically build (in comanion module) based on h tags.
*   Implements new content revisions API for change management.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.01)