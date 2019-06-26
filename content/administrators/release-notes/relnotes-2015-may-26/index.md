---
uid: relnotes-2015-may-26
locale: en
title: DNN Release Notes — 2015 May 26
dnnversion: 09.02.00
---

# DNN Release Notes — 2015 May 26

## DNN PLATFORM 7.4.1

*   Fixed race condition which could cause errors during file upload.
*   Fixed issue where country profile property can cause registration to fail.
*   Fixed issue where calendar control breaks in Arabic language.
*   Fixed issue where Italian Language pack causes error on Host Settings.
*   Fixed issue where Twitter Provider fails to create unique DNN login names.
*   Fixed issue where creating a social group can fail in the "All Roles" mode.
*   Fixed issue where custom url providers can't be disabled.
*   Fixed issue where upgrades can fail if portalsettings has invalid values.
*   Fixed issue where permissions can't be applied to a shared module.
*   Fixed issue where url rewriting is broken for non-2 letter culture codes.
*   Fixed performance issue where missing page doctype causes excessive file lookups.
*   Fixed performance issue where testing for local URIs causes slow DNS lookups.
*   Fixed issues where removing large number of unauthorized users would fail.
*   Fixed issue where RazorHost did not follow standard Razor Engine behavior.
*   Fixed issue where JavaScript library version number cannot hold full value for some libraries.
*   Fixed issue where JavaScript libraries don't work in cached modules.
*   Fixed issue where JavaScript library API doesn't immport full dependency tree.
*   Fixed issue where 404 page was included in the sitemap.
*   Fixed issue where en-us systemlocale was hardcoded in PortalSettings API.
*   Fixed performance issue where some HttpModules were executed for static file requests.
*   Fixed issue where user registration can fail with long passwords.
*   Fixed issue where Country properties were returning numeric id rather than value.
*   Fixed issue where browser language detection fails.
*   Fixed issue where URLs are not exported correctly in page content.
*   Fixed issue where switching languages removes the query string parameters.
*   Added new Security Analyzer module.
*   Fixed caching issues with multi-language portal settings.
*   Security:
    *   Fixed account creation issue in install wizard (critical).
    *   Fixed request forgery issue in file upload component (low).
    *   Fixed information leakage issue for file existence (low).
    *   Fixed information leakage issue for installed version (low).

## EVOQ 8.1.0

EVOQ CONTENT BASIC

*   All updates included with DNN Platform 7.4.1.
*   Improved the overall experience for IE 9 users.
*   Exposed page analytics in mobile view.
*   Added a new content analytics engine that allows page and site traffic to be tracked and reviewed.
*   Turned the dashboard's navigation summary page names into links that load the page analytics of those pages (so you no longer need to navigate to a page to view its analytics).
*   Enhanced the usability of the Recycle Bin (in the Persona Bar), also made it a submenu item under Manage.
*   Moved the template section to a submenu item under Manage and updated the creation UI to be more consistent with the rest of the product.
*   Refined the create page experience and enabled page publish scheduling.
*   Updated Content Layout to handle responsive design and content properly.

EVOQ CONTENT

*   All updates included with Evoq Content Basic 8.1.0.
*   Added new Publisher content authoring module that ties into advanced workflow and provides an authoring experience similar to creating and editing page content.
*   Added Disqus connector that is tightly integrated with the new Publisher module.
*   Enhanced it so Content Managers/editors cannot create personalized versions of pages that shouldn't be personalized (template pages, user profile pages, etc.).
*   Added validation to UI when combining various rules for personalized pages to avoid the creation of a personalized page that could never be accessed.
*   Refined how unpublished deleted personalized pages are handled, they are immediately removed (hard deleted, along with any modules on the page) and NOT available in the recycle bin.

EVOQ ENGAGE

*   All updates included with Evoq Content 8.1.0.
*   Added Zendesk connector and module that allows end users to create, comment on and view Zendesk tickets from within your Engage website.
*   Added ability to sort by date created in list views of Answers and Ideas.
*   Added totals to all line charts in Dashboard reports.
*   Enhanced page analytics to handle all user generated content, so it is now tracked as an independent URL.
*   Updated how votes on questions/answers are added/removed with relation to gaming mechanics to avoid users abusing the system.
*   Added more scoring actions to track and reward various profile update activity.
*   Changed in-context analytics to show page traffic analytics instead of community health indicators (these are still accessible via the dashboard).
*   Made default visibility of Activity Stream entries to group members only, when in group mode.
*   Enhanced social connectors to return more insightful messaging when connections fail.
*   Stopped pushing updates to the journal when groups are updated, so you no longer see these in the Activity Stream (any previous entries are still available, in upgrades).

## Downloads
* [https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.01](https://github.com/dnnsoftware/Dnn.Releases.Archive.7x/tree/master/07.04.01)