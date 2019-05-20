---
uid: relnotes-2013-jul-09
locale: en
title: DNN Release Notes — 2013 Jul 09
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 Jul 09

## DNN PLATFORM 7.1.0

*   Implemented functionality so that users are able to assign custom CSS to pages without modifying the skin.
*   Updated to JQuery 1.9.1.
*   Implemented auto-complete functinoality in the taxonomy module.
*   Updated the page and user selector controls to improve the experience in larger sites with multiple users.
*   Implemented a warning message for Azure users when they install a module that does not have the Azure Compatible flag.
*   Fixed issue where users were being logged out if switching between www.domain.com and domain.com.
*   Fixed issue when exporting and importing a template where content localization is enabled.
*   Fixed issue where data was not being cleaned up after removing a folder provider.
*   Fixed issue that made modules not to render corectly when module caching was enabled through the Client Resource Management Framework.
*   Added support for accents in profile properties.
*   Fixed issue where calling the GetUserByVanityUrl function was throwing an error.

## DOTNETNUKE PLATFORM 6.2.8

[CodePlex](https://dotnetnuke.codeplex.com/releases/view/108860)

*   Fixed issue where the application throws an Unhandled Error and an HTTP Response Code of 200 when the connection to the database is lost.

## EVOQ 7.1.0

EVOQ CONTENT

*   All updates included with DNN Platform 7.1.0.
*   Fixed issue in the File Manager page when the user tried to refresh a page using F5.
*   Fixed issue where new PDF documents were not indexed by the search crawler.
*   Implemented new functionality to roll back changes when enabling Content Localization fails.
*   Updated the neat upload assembly that was causing errors when uploading documents to document library.
*   Fixed UI issue in Document Library's security settings.
*   Fixed issue that stopped users from adding attachments from the local drive whens sending messages.
*   Fixed issue where admin and host pages were being indexed when crawling the site as an administrator.
*   Fixed issue in the linkclick functionality when linking to documents stored in the Amazon S3 provider.
*   Replaced the page selector control to improve performance in large websites.
*   Fixed UI issue where pop ups were not rendered centered in the page.
*   Fixed issue that stopped users from uploading files to Azure from the Image Manager.
*   Fixed issue when creating sites from a template.
*   Fixed issue where only the first site alias was used when multiple aliases were created.
*   Fixed issue where visitors using IE were getting a "mixed content warning" when SSL Offloading was enabled.
*   Fixed issue when uploading files form the HTML Module to a UNC Folder.
*   Fixed issue where folder names were changed to lower case when upgrading Document Library.
*   Added the Company Name filed to the Commerce Module.
*   Fixed issue that stopped users from uploading mp4 files through the HTML Module.
*   Fixed issue where HTML workflow notifications were not sent to Administrators.
*   Fixed issue that stopped users from creating sub pages from templates.
*   Fixed issue where manual synchronization was not working correctly in Document Library.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.01.00](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.01.00)