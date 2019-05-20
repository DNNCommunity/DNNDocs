---
uid: relnotes-2018-mar-22
locale: en
title: DNN Release Notes — 2018 Mar 22
dnnversion: 09.02.00
---

# DNN Release Notes — 2018 Mar 22

Released 2018 Mar 22.

## DNN PLATFORM 9.2.0

### DNN PROMPT
DNN Platform comes with a brand new command line interface to perform administrative tasks. Read more about [DNN Prompt here](https://www.dnnsoftware.com/community-blog/cid/155456/previewing-prompt-in-dnnevoq-920). DNN Prompt is extensible as well, meaning you can add your own commands as well. Look out for a future blog on this topic.

### UPDATED PAGE MANAGEMENT
The page management experience has been greatly enhanced using tree view navigation. You can drag & drop !)

### INTRODUCING CONNECTORS (ALONG WITH AZURE STORAGE CONNECTOR)
Connectors were first introduced in Evoq to have a single place to manage external connections. Evoq integrates with several services such as Dropbox, Box, Mailchimp, Zendesk, etc., which all use one common interface to define and configure connection information. Just like anything else in DNN, Connectors were built with extensibility in mind. We have now moved the base Connectors framework into DNN Platform. Along with that, we also made the Azure Storage Connector availble in Platform as well. Look out for a future blog on this topic.

### PERFORMANCE UPDATES
User Search - Faster and more reliable user search in Persona Bar
Security Analyzer - Faster initial scan

### FRAMEWORK UPDATES
A number of platform updates were done in this release

* Integration Testing Framework [Blog 1](https://www.dnnsoftware.com/community-blog/cid/155465/dnn-unitintegration-testing--part-1),[Blog 2](https://www.dnnsoftware.com/community-blog/cid/155468/dnn-unitintegration-testing-part-2') and [Blog 3](https://www.dnnsoftware.com/community-blog/cid/155481/dnn-unitintegration-testing-part-3)
* [Libraries updated to - jQuery 3.2.1, NewtonSoft 10.0.3, Sharpzlib 0.86.0.518, ClientDependency.Core 1.9.3](https://www.dnnsoftware.com/community-blog/cid/155510/jquery-newtonsoft-etc-updated-in-dnn-platform-92)
* [Removal of deprecated APIs](https://www.dnnsoftware.com/community-blog/cid/155508/dnn-platform-92-removes-over-500-deprecated-apis)
* [Replaced 51 Degrees with local provider](https://dnntracker.atlassian.net/browse/DNN-10284)

### OVERALL STABLIZATIION
Stabilization in the following DNN Platform features: Site Settings, Installation & Upgrade, Journal, Localization, Messaging, MVC, SEO, Search, User Profile, Login & Registration, Client Depdendency, CK Editor, DDR Menu, Host SQL, Image Handler, Member Directory, Redirect updates, and Display module on all pages.

## EVOQ 9.2.0

### EVOQ BASIC

Evoq Basic 9.2 contains the new features listed above in DNN Platform 9.2.
IMPROVEMENTS IN PERSONA BAR ASSETS
Now you can set publish period and attributes for files via Persona Bar Assets.
OVERALL STABLIZATIION
Stabilization in the following Evoq Basic features: Workflow, Open Grpah, Active Directory, Edit Bar and Google Analytics Connector.

### EVOQ CONTENT

**Evoq Content 9.2 contains the new features listed above in DNN Platform 9.2 and Evoq Basic 9.2.**

### LIQUID CONTENT LOCALIZATION
Now you can easily localize content items per the languages defined in your site. The visualizers in Liquid Content have been updated to render the content in the page or site's selected language.

### ADDITIONAL LIQUID CONTENT ENHANCEMENTS
Improved import/export, the addition of oData Filtering, enhancements to SEO, and improvements to editing default content types.

### IMPROVEMENTS IN MAILCHIMP INTEGRATION
Improved profile data synchronization.

### OVERALL STABLIZATIION
Stabilization in the following Evoq Content features: Box Connector, Dropbox Connector and Content Personalization.

## EVOQ ENGAGE

**Evoq Engage 9.2 contains the new features listed above in DNN Platform 9.2, Evoq Basic 9.2 and Evoq Content 9.2.**

### IMPROVEMENTS IN ZENDESK CONNECTOR
Connector now correctly updates ticket status to OPEN while adding a comment. Better column layout.

### OVERALL STABLIZATIION
Stabilization in the following Evoq Engage features: Answers, Groups Directory, Blogs, Activity Stream, Leaderboard.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.2.0](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.2.0)