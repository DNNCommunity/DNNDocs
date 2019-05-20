---
uid: relnotes-2016-dec-09
locale: en
title: DNN Release Notes — 2016 Dec 9
dnnversion: 09.02.00
---

# DNN Release Notes — 2016 Dec 9

## DNN PLATFORM 9.0.0

*   The host/admin experience is enhanced with a modern Persona Bar user interface. Most modules were rewritten using React.js. The legacy Control Panel and its accompanying host/admin pages are removed during the upgrade.
*   New modules can now be installed directly from the Persona Bar menu by a host/superuser.
*   Persona Bar modules can be configured with individual permissions, thereby allowing the creation of custom personas.
*   Advanced URL Management functionality, which used to be available in Evoq only, is released to the Platform.
*   The About menu option (formerly License Management) now includes links to the new Documentation Center and to Sales.
*   The Scheduler's task management and user interface elements were updated.
*   The user interface of the Themes module was converted to a gallery-style theme browser.

## EVOQ 9.0.0

EVOQ CONTENT BASIC

*   All updates included with DNN Platform 9.0.0.
*   Site Groups was folded into Site Management. The Site Groups module now displays a snapshot of each portal's home page as a thumbnail card.
*   Content localization was simplified, and redundancies were removed. Content localization now occurs at the page level.

EVOQ CONTENT

*   All updates included with Evoq Content Basic 9.0.0.
*   The new MailChimp connector allows new users or subscribers to be automatically mapped to your MailChimp subscription lists. The connector also includes an Unsubscribe module for users to be automatically removed if they opt out.
*   New Evoq Analytics service replaces the old built-in analytics functionality. The new service connects to Google Analytics and displays visualizations, data, and insights inside the Evoq interface.[1](#fn-cloud-based)
*   Form Builder: You can now build and deploy dynamic forms.[1](#fn-cloud-based)
    *   Four common use cases are shipped out of the box.
    *   You can now customize the view of the form response list for easier analysis.
    *   You can configure the properties (custom URL) and custom connections (Google Analytics) of a form. You can also hide forms.
    *   Forms can perform one or more of the following actions when a response is submitted:
        *   Send an email to the form respondent or an internal team.
        *   Provide a downloadable file.
        *   Display a message.
        *   Redirect to another URL.

EVOQ ENGAGE

*   All updates included with Evoq Content 9.0.0.
*   Structured Content: Separates the content creation process from the design process.[1](#fn-cloud-based)
    *   You can easily create content types with drag-and-drop functionality and dynamic layouts.
    *   Six common use cases are shipped out of the box.
    *   Content creators don't have to worry about the design of the page where their content would appear.
    *   Images can be edited directly on the page.
    *   Dynamic lists are automatically updated with newly created content items matching the configured criteria.
    *   Dynamic lists can easily link to a detail view without requiring a new page for every content item.
*   Visualizers: Modern and beautifully designed content wrappers are included.[1](#fn-cloud-based)
    *   With dozens of visualizers provided out of the box and more added with each update, web designers can easily add modern design elements to web pages using content.
    *   Visualizers are easily created using templates that bundle HTML, CSS, and JavaScript.
    *   Visualizer Builder templates also support pagination, header wrappers, and footer wrappers.
*   The new connector between the Form Builder and Structured Content converts form submissions to content items, which can be mined for testimonials or reviews and displayed on a page.
*   A dedicated Community Analytics dashboard displays important community performance metrics and analytics.

<a name="fn-cloud-based">1</a> Delivered as a cloud-based DNN microservice. Microservices allow for easier upgrades and faster deployment of new updates. Microservices also improve the overall performance of your site by hosting additional functionality on cloud servers.


## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.0.0](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.0.0)






















