---
uid: relnotes-2017-apr-26
locale: en
title: DNN Release Notes — 2017 Apr 26
dnnversion: 09.02.00
---

# DNN Release Notes — 2017 Apr 26

Released 2017 Apr 26.

## DNN PLATFORM 9.1.0
ADA Compliance

DNN complies with accessibility requirements defined by the Americans with Disabilities Act (ADA). Anonymous site visitors with those requirements can now use accessibility tools to browse and interact with any DNN site. Authenticated users can additionally use an accessibility tool to navigate the Persona Bar and to perform other actions. New accessibility features include:

*   Ability to add alternative text for every image on a site.
*   Ability to post documents in text format, so text-to-speech and other assistive technologies can vocalize the content.
*   Full control over colors and font settings to allow the creation of web pages with high contrast and large fonts.

Although DNN provides the capability and assistance in creating ADA-compliant web pages, site managers are still responsible for choosing and adopting appropriate content creation strategies.

Import/Export

DNN now ships with a standalone module that exports/imports entire websites, as well as more granular components, such as individual site pages, the user database, and the content database. The exported data is stored in a single portable package that contains everything required to recreate that site or component in a different installation.

Telerik Removal

Additional changes were made to continue phasing out Telerik from DNN products. [See details.](xref:relnotes-2017-apr-26-telerik-removal)

Added and Deprecated Extensions

Some extensions were added and others deprecated depending on the product and the installation/upgrade scenario. [See details.](xref:relnotes-2017-apr-26-extensions)

## EVOQ 9.1.0

EVOQ BASIC

All updates included with DNN Platform 9.1.0.

Note: Changes for [Telerik Removal](xref:relnotes-2017-apr-26-telerik-removal) and for [Added and Deprecated Extensions](xref:relnotes-2017-apr-26-extensions) are different for each product.

Global Asset Management

Superusers/Hosts can now manage and browse all assets (from all Evoq sites within the installation) through the Asset Manager. Previously, assets could only be viewed at the site level.

Multiple Connector Support

Evoq now allows connecting to multiple accounts for the same folder provider. Example: You can sync the folders of different Dropbox accounts with Evoq. Each folder path is given a unique name and is managed independently.

EVOQ CONTENT

All updates included with Evoq Basic 9.1.0.

Note: Changes for [Telerik Removal](xref:relnotes-2017-apr-26-telerik-removal) and for [Added and Deprecated Extensions](xref:relnotes-2017-apr-26-extensions) are different for each product.

In-context Editing for Liquid Content™

You can add content, edit content, and manage the visualizer within the module interface. Module permissions have been added to restrict access to either the visualizer or content editing functions. Changing the content or visualizer also triggers page workflow and versioning. Currently, workflow is triggered with content item visualizers only; list workflow events are coming soon.

New Google Tag Manager Connector

You can now connect to Google Tag Manager to administer and analyze your website dynamically, to define segments of pages, and to manage campaigns.

Analytics Updates

Rich dynamic charts were added to further segment data and understand interactions on the website. Charts are updated in real time, as users modify dimensions or date ranges. Conversion tracking was enhanced to include segmentation based on individual conversion metrics, as well as visitor pathway analysis and attribute page conversion performance.

Multi-Step Forms

You can create and deploy forms with multiple steps. Useful for surveys, questionnaires, and quizzes. You can customize the look and feel of the form, including the transition between steps, and then you can view the results for each step.

New Form Submission Event to Collect Form Response Data

The webhook capability of forms was updated to provide developers a deeper access point to the form response data.

Visualizer Import/Export

For designers and developers who hate copying and pasting code from environment to environment, we've added export and import capability for visualizers and their accompanying content types.

Content Item Revision History

Liquid Content™ now saves every version of a content item. You can preview and roll back to prior versions.

Auto-Suggest Tagging in Visualizers and Content Items to Assist with List Visualizers

During the creation of a List or List/Detail visualizer, tags will be suggested to help filter content elements. This enables marketers to deploy brand-consistent content and to easily find the content they're looking for. Tag suggestions are based on the taxonomy of the content library and on what has already been published on the page.

Content Item <meta> Tag Support

All content items now support the Open Graph Protocol, which allows a title, a description, keywords, and an image to be used as the content preview when shared in social channels.

EVOQ ENGAGE

All updates included with Evoq Content 9.1.0.

Note: Changes for [Telerik Removal](xref:relnotes-2017-apr-26-telerik-removal) and for [Added and Deprecated Extensions](xref:relnotes-2017-apr-26-extensions) are different for each product.

Content Item Analytics

Analytics is now available for individual content items to provide information such as:

*   how they are used on the web (in an Evoq site or embedded in an app)
*   how often they were shared
*   how much engagement they received

Multichannel Publishing : API Key Management

You can easily generate an API key to allow other applications and services to access the Liquid Content™ REST API, which provides access to content and which communicates with external services. You can integrate Liquid Content with native mobile apps, digital signage, or even another CMS.

Multichannel Publishing : Content Item Embed Code

You can generate an embed code to allow your content to live anywhere on the web. Evoq's content analytics also tracks what URLs your content lives in and how much reach it gets.

Multichannel Publishing : Social Publishing

Using Liquid Content™'s publishing application, users can connect their social profiles and publish content directly to Facebook, Twitter, or LinkedIn. Evoq saves a rendering of that post, the date/time it was published, and how much engagement it received.

## Downloads
* [https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.0](https://github.com/dnnsoftware/Dnn.Platform/releases/tag/v9.1.0)