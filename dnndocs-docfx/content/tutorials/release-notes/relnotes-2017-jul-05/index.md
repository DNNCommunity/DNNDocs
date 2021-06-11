---
uid: relnotes-2017-jul-05
locale: en
title: DNN Release Notes — 2017 Jul 5
dnnversion: 09.02.00
---

# DNN Release Notes — 2017 Jul 5

Released 2017 Jul 5.

## DNN PLATFORM 9.1.1

FIPS Compliance

The user verification algorithm was updated to use a FIPS-compliant method.

Important: After the upgrade, links in verification emails sent prior to the upgrade will fail. Therefore, administrators must check the Unverified Users role and, if necessary, reissue a verification email for users belonging to that role.

Navigation

*   Menu and button interactions show additional validation and user feedback implementations.
*   In-app navigation and breadcrumbs have been added and improved, where applicable, to increase usability.
*   Minor UI enhancements were made in the following menus: Security, Servers, Sites, and Scheduler.

UI

*   In Page Management, the option to select the parent page (when creating a new web page) was restored.
*   In the Edit mode toggle, the option to remain in Edit mode was restored.

Translation

Fixed several translation issues in the default language packs.

## EVOQ 9.1.1

EVOQ BASIC

All updates included with DNN Platform 9.1.1.

Customer-requested

Various updates based on almost 70 customer support tickets, including 20 customer-requested improvements.

EVOQ CONTENT

All updates included with Evoq Basic 9.1.1.

Dropbox

The Dropbox folder provider was updated to version 2.

Import/Export

Import/Export now supports a site's entire microservice content library. When exporting a site or portion of a site, users can now elect to transfer the contents of their Liquid Content™ library along with the export package.

Liquid Content™

*   Related Content is a new visualizer type that communicates with an existing visualizer on a page to filter and display related content items. Example: A blog post may have certain tags to describe the content in the post. The Related Content visualizer, when deployed on a blog post page, will use the taxonomy of that content to display similar types of blog posts. This is extremely useful for content marketers trying to create sticky websites and engage their audience.
*   The contents of a Liquid Content™ list and the details of that list are now fully indexed and are discoverable in Evoq Search.
*   The loading time and the behavior of the microservice menus were enhanced for better performance.
*   The social publishing authentication workflow was improved to allow saved profiles to persist as long as the social network allows the user to remain authenticated.
*   Social publishing preview posts are updated to better reflect the actual content and structure of the post on a social network.
*   Visualizer updates are now refreshed more granularly (using AJAX) instead of requiring a full page refresh.

Form Builder

*   Notifications can now be sent to multiple recipients when a form is completed.
*   The Form Builder — Structured Content connector now accepts files and assets from submitted forms and transfers them to the corresponding content item.
*   Webhook support/subscription can now listen to form responses and copy a file or content to a custom endpoint.
*   Files and assets uploaded through a form submission are now added to a dedicated Form Submissions folder within Assets.

Analytics

Evoq Analytics now tracks individual content items displayed through a visualizer on any web page, allowing users to analyze how many times a content item has been viewed and who viewed it.

EVOQ ENGAGE

All updates included with Evoq Content 9.1.1.

Minor updates

Several minor customer enhancements were added and bugs fixed.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.1](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.1)