---
uid: relnotes-2018-aug-08
locale: en
title: DNN Release Notes — 2018 Aug 08
dnnversion: 09.02.01
---


# DNN Release Notes — 2018 Aug 08

Released 2018 Aug 08.




## DNN PLATFORM 9.2.1

GitHub

* Container - DNN-9099 When a container is placed on anything but a `<div>`, you can't add modules
* Cookies - DNN-20254 ASP.NET Session cookie being invalidated upon login in
* DDR Menu
  * DNN-8511 Long Page name should be wrapped inside a tooltip box
  * DNN-17683 Exclude Nodes still lists nested pages
* File/Folder API DNN-8893 Cannot access files in renamed folder unless the cache is cleared
* Import Export
* DNN-20580 A fix in TabOrder after import
* DNN-20255 Theme files getting duplicated in the exported package
* DNN-18210 ImportExport issue for child pages
* Installation - DNN-20802 Installation/Upgrade can't run completely if globalization culture set to Turkish
* jQuery - DNN-20057 Upgrading from 9.1.1 to 9.2.0 results in multiple jQuery versions
* Login
  * DNN-19925 SI: Redirect after login setting not working for login page
  * DNN-19429 Login does not submit on enter key press
* Minification DNN-18552 CSS minification not working for third party sites.
* Output Cache DNN-20031 Output cache item count doesn't show correctly
* Persona Bar
  * General DNN-8377 Mouseover does not work in Chrome and FF
  * Language Pack DNN-18458 Better positioning and spacing for French text
  * Pages DNN-7976 UI not refreshed after page editing
  * Pages DNN-19496 Allow blank 'Site Alias'
  * Pages DNN-18240 When Duplicating a page the parent page is highlighted instead of the newly created one
  * Pages DNN-18228 Wrong message shown while accessing page setting.
  * Pages DNN-18059 Last page in the treeview shows extra white space and scroll if user enabled scheduling
  * Prompt DNN-8316 Set-user: Firstname and LastName shouldn't be mandatory
  * Prompt DNN-8327 Prompt List-pages : deleted flag default value should be true
  * Prompt DNN-17875 - No result is found while using wildcard search with --email flag of 'list-users' command
  * Search DNN-7820 Close button overlaps with Search button in user search
  * Search Crawler Settings - DNN-20480 A looping issue in GetCrawlerSettings
  * Site Settings DNN-19410 Remove development code from SiteSettings module
  * Site Settings Search DNN-17334 Site switching does not work in Search Tab
  * Site Settings DNN-11091 Adding Redirect to Page Settings Breaks Page Settings
* Profile DNN-19432 DNN 9.2 profile update does not work if Profile Property "Photo" is missing
* Registration DNN-18342 Password Strength Meter does not appear
* Scheduler DNN-17335 - Disabling a task does not work unless the application is restarted
* Tab API DNN-7981 On delete module, "lastmodifiedbyuserid" doesn't get updated in "TabModules"
* User Management
 * DNN-20663 Allow email as username
 * DNN-18612 RequireUniqueDisplayName does not work with adding users to multiple portals.
* SharpZipLib PR 2118 Better handling of the breaking change in 9.2
* Webforms - DNN-8137 Webform postback in Edit mode losing viewstate of the GridView

## EVOQ 9.2.1

### EVOQ BASIC

**Evoq Basic 9.2.1 contains the new features listed above in DNN Platform 9.2.1.**

* Persona Bar
  * Assets DNN-7984 Uploading to subfolder of User Profile folder in Assets loads to parent folder
  * Assets DNN-19980 Error when uploading asset from URL
  * Assets DNN-18307 Asset Sorting does not sort by Date Uploaded
  * Assets DNN-17154 - Spelling of Maximum is "Maximun"
  * File Crawler DNN-20867 Fixed an issue with saving file extension
  * Web Server DNN-16909 Text is not localized in Web Server Monitor Task
* Richtext Editor
  * DNN-20627 Line breaks gets be lost in pre tags
  * DNN-20429 Text under an image is not selectable in redactor when the image's vertical alignment is set to middle
  * DNN-20186 HTML Editor is adding `<spans>` when using Bold in the rich text editor.
  * DNN-19984 CTRL+Y doesn't work in text editor
  * DNN-19982 Adding images with the add image button in rich text does not place the image where the cursor is if the placement is inside of an ordered or unordered list.
  * DNN-14075 Bullet Point List Does Not Show in Editor
  * DNN-11160 Files with long name don't appear after upload
* Search FileCrawler DNN-20298 Crawling may fail in a web farm environment during unexpected app shutdown
* Workflow Notification DNN-20670 Direct Publish still sends notification even though notifications are shut off

## EVOQ CONTENT

**Evoq Content 9.2.1 contains the new features listed above in DNN Platform 9.2.1 and Evoq Basic 9.2.1.**
* Forms
  * DNN-83 Dropdown choices in Form editor not editable with single click in IE11
  * DNN-11025 Selecting a Form to add while another one is already loading causes errors and faulty behavior
  * DNN-18995 Form Builder Column Order Reset on Selection and Export
  * DNN-18733 Static text keeps disappearing from a form when using paragraph appearance
* Liquid Content
  * API DNN-20594 A minor fix to GetByIds
  * DNN-20000 "Items to Show" dropdown in a list visualizer does not scroll.
* Publisher
  * Search - DNN-20259 Optimizations in web farm environment
  * DNN-20106 Content can't save in publisher module if contains "&nbsp;"

## EVOQ ENGAGE

**Evoq Engage 9.2.1 contains the new features listed above in DNN Platform 9.2.1, Evoq Basic 9.2.1 and Evoq Content 9.2.1.**

* Discussions
  * DNN-291 Bug | Pinned topics not staying pinned when adding a new topic
  * DNN-290 Clicking the reply button doesn't take you down the page to the reply field
  * DNN-20940 Cannot create discussion posts with an ampersand
* Group Spaces - DNN-18574 - Evoq engage_group spaces module_notifications don't seem to be working as expected
* Blog DNN-18479 Authoring types are not working properly
