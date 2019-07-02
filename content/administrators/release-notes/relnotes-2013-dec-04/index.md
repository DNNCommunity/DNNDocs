---
uid: relnotes-2013-dec-04
locale: en
title: DNN Release Notes — 2013 Dec 04
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 Dec 04

## DNN PLATFORM 7.2.0

Application features

*   Responsive Design Skin: The Gravity skin was redesigned to use the Bootstrap framework which provides for a fully responsive design out of the box.
*   The SQL module has undergone a complete overhaul in 7.2.0 including a new editor and updated query results pane.
*   The DNN Module Creator has been incorporated directly into DNN making it easier than ever to get started writing your new DNN extension.
*   The DNN Search has been extended in 7.2.0 to include the ability to search users and user profiles (this feature is easily disabled for those who would prefer not to use it).

Developer features

*   JavaScript Library Management: DNN 7.2.0 allows you to install JavaScript libraries as first party extensions. Once installed your module or skin can request that JavaScript library and the platform will automatically add the library into the page. The API mirrors the one used for jQuery and JQuery UI making it very easy to use.
*   Code Editor: The new CodeMirror code editor component has been added to DNN to provide a full syntax highlighting code editor when needed. Module developers can incorporate this feature with just a few lines of JavaScript.

## EVOQ 7.2.0

EVOQ CONTENT

*   All updates included with DNN Platform 7.2.0.
*   A new customizable Document Viewer module that allows you list documents on a page filtering by folder or tags.
*   The DAM module now includes a Group Mode that allows you to easily create a library in a social group.
*   The DAM now allows you to edit the properties of multiple documents at the same time.
*   You can now track the number of views and downloads of your digital assets.
*   The DAM module is now integrated with the subscriptions and notifications functionality to automate the collaboration on your digital assets.
*   Fixed issue filtering issue in the User Switcher feature.
*   Fixed usability issue in the HTML Module's Save Draft workflow.
*   Fixed issue in the Digital Assets Manager where an Unknown Server Error was thrown.
*   Fixed exception thrown when a page has a malformed URL and Page Output Caching is selected.
*   Fixed issue in the Valid Friendly URL Regular Expression functionality where the value entered was not being handled correctly.
*   Fixed issue where subfolders were not unzipped correctly when uploading a zipped folder to the Digital Assets Manager.
*   Fixed issue where the File Crawler would stop indexing when an error occurs in the Amazon S3 Provider.
*   Fixed issue where the Digital Assets Manager's Workflow functionality was not available on upgraded sites.
*   Fixed issue where a 301 error is thrown when the homepage of a site is access with querystring parameters.

## Downloads
*  [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.02.00)