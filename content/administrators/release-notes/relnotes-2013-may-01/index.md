---
uid: relnotes-2013-may-01
locale: en
title: DNN Release Notes — 2013 May 01
dnnversion: 09.02.00
---

# DNN Release Notes — 2013 May 01

## DNN PLATFORM 7.0.6

*   Fixed issue that caused broken links when changing the name of a page.
*   Added search capabilities in the page management section.
*   Added new funtionality to the Member Directory so that users can choose between the different search options.
*   When creating a social group the newly created role group is now set as the default group.
*   Implemented new functionality to allow users to hid the login button in the default skin.
*   Removed the module and skin templates from the Starter Kit package.
*   Fixed issue that shows an error when registration is set to unique display name.
*   Fixed issue that made child site files not to show when managing sites.
*   Fixed UX issue when changing the file size in the configuration management section.
*   Fixed issue in the Journal module where followers could see posts that are meant for friends only.
*   Fixed paging conflict between roles and users in the users' accounts screen.
*   Added new functionality that allows users to see all the social groups they belong to.
*   Fixed issue where separating a site from a group would not copy all the users.
*   Fixed issue when creating a page from a template when the template has modules that are set to display on all pages.
*   Removed the "-" from the invalid character list for page names.
*   Fixed the styling in the date time picker to display the time.
*   Fixed issue that shown the tokens when searching for pages.
*   Fixed issue that made the site redirection management screen to not work correctly when pop ups are disabled.
*   Fixed issue where exported templates point to the incorrect site settings.
*   Fixed issue that caused Social Group Roles to be limited to the Global Role group.
*   Fixed issue when page names include a ":" colon.
*   Fixed issue where scheduler runs overlap when retry is set to a short interval.
*   Fixed issue with modules that are expected to display in all pages and Content Localization is enabled.
*   Implemented auto-refresh functionality in the message center so that users can see updates in real time without refreshing the page.

## EVOQ 7.0.6

EVOQ CONTENT

*   All updates included with DNN Platform 7.0.6.
*   Fixed the date when expiration emails were sent when documents expired in Document Library.
*   Enhanced the performance in the Links Module.
*   Fixed issue that made avatar image to not show on the user profile next to the login link.
*   Fixed issue where unnecessary client dependency files were created.
*   Fixed issue where an unauthorized error was shown in when accessing the Journal through WebAPI incorrectly.
*   Fixed UX issue in the workflow state in the HTML Module.
*   Fixed memory leak in Search Crawler that affected the performance when crawling the site.
*   Implemented the command timeout in PetaPocoHelper.
*   Fixed issue where deleted HTML Modules appear in the MyWork section.
*   Fixed issue where the Console Module does not display the icons corrctly when creating a social group.
*   Fixed issue when uploading files with an ampersand in the name through the HTML Module.
*   Implemented setting in the HTML to manage the length of the HTMLTextController.
*   Updated the user agent user when the searchcrawler crawls the site.
*   Security:
    *   Fixed code that generates pop ups and can potentially allow for javascript / HTML injection.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.06](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.00.06)