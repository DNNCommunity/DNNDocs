---
uid: relnotes-2018-oct-01
locale: en
title: DNN Release Notes — 2018 Oct 01
dnnversion: 09.02.02
---


# DNN Release Notes — 2018 Oct 01

Released 2018 Oct 01.

## DNN PLATFORM 9.2.2

* Core
  * Improvements in string management to increase overall performance.
  * Improve MVC support with RedirectToAction.
* Installation / Upgrade
  * Improve feedback in the cleanup process during module installation and upgrades.
* Registration
  * Cannot create new user with email address as username 
  * User registration will clear whole site's cache and cause performance issue
* Login
  * Email as username breaks login/Unauthorized message
* Persona Bar
  * Language Resource Files unescaping "&"
  * Parent page is not getting set while adding new page.
  * Extensions - Resource dropdown is not populated
  * Prompt: Cross-portal scripting: "add-roles" is not working with anything other than the main site (To be general, the site in the URL))
  * Prompt: Cross-portal scripting: "restore-user" is not working with anything other than the main site (To be general, the site in the URL))
  * Prompt: Add-roles : Missing validation add non-existing role
  * Prompt: Cross-portal scripting: "set-user", "restore-user", "add-roles" are not working with anything other than the main site (To be general, the site in the URL))
  * Prompt: Manipulating host users in a site other than the one it is originally created on, causes some faulty behaviors
* Connectors
  * Incorrect message is shown for Invalid Access Key Id
* Groups
  * While creating group file upload by browse file not working but drag'n'drop is fine
* Import Export
  * Import/Export Circular Dependency in pages cause pages not to be imported
  * Export/Import not importing module permissions for custom roles
* Profile
  * Space in Date type user profile field name breaks read-only functionality
* Richtext Editor
  * Rich Text Editor Upload limits
* UI
  * All forms are not listed at time of Adding module
  * Action menu's position will not stay in place when the pane position set to fixed
  * Missing styles in 9.2 to notify user which pages are hidden/Disabled
* Tests
  * Refactor SetUserUnitTests to Inherit from CommandTest
  * Refactor GetUser Command Unit Test to Inherit from CommandTest
* Package
  * Reviewed and updated build scripts throughout the platform to enable VSTS CI.
* Security
  * 2018-13 (Critical) Possible Leaked Cryptographic Information
  * 2018-14 (Low) Possible Cross-Site Scripting (XSS) Vulnerability
  * Visit Security Blog to read more information.

## EVOQ 9.2.2

### EVOQ BASIC

**Evoq Basic 9.2.2 contains the new features listed above in DNN Platform 9.2.2.**

* Persona Bar
  * Evoq builds showing incorrect version in PB
* Search
  * Search Results date modified for pages not consistent with page update
* Assets
  * The upload status of files in Assets screen does not clear after upload panel closed
* Richtext Editor
  * HTML Editor is adding `<spans>` when using Bold in the rich text editor.
  * Editor creates a new version of the content when click on close without perform changes
* Integration with Kayako Messenger

## EVOQ CONTENT

**Evoq Content 9.2.2 contains the new features listed above in DNN Platform 9.2.2 and Evoq Basic 9.2.2.**

* Forms
  * Form response formatting
  * Changes are not reflecting in published Page after updating a form
  * Form Responses now showing when filter should not return any responses
* Liquid Content
  * Check for stale content items in search index
  * Deleting a piece of liquid content via the content library that is used on a page will result in the content still being selected in the visualizer, but unselectable.

### EVOQ ENGAGE

**Evoq Engage 9.2.2 contains the new features listed above in DNN Platform 9.2.2, Evoq Basic 9.2.2 and Evoq Content 9.2.2.**

* Engage
  * Need to append groupId for http call(ajax) with term when tagged a user in comment or post
* Persona Bar
  * Viewing Analytics - On click, no action is performed
  * Influence/Engagement always empty
* Blogs: Community Manager cannot add entry on his own blog

## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.2.2](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.2.2)