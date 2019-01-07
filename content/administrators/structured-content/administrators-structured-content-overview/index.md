---
topic: administrators-structured-content-overview
locale: en
title: About Liquid Content™ (Structured Content)
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-microservices-overview
related-topics: create-content-type,edit-content-type,duplicate-content-type,delete-content-type,create-visualizer,edit-visualizer,delete-visualizer,create-content-item,edit-content-item,duplicate-content-item,delete-content-item,visualizer-templates,administrators-forms-overview,administrators-fields-overview
links: ["[What Is Structured Content: Definition, Benefits, and How to Get Started](http://www.dnnsoftware.com/blog/what-is-structured-content-definition-benefits-and-how-to-get-started)"]
---

# About Liquid Content™ (Structured Content)

## Liquid Content™ (Structured Content) Overview

Liquid Content™ is a structured content microservice that manages content items or pieces of content that can be presented in any context, such as a webpage or a native mobile app.

Evoq's Liquid Content has three types of components:

*   Content Type. Defines the combination of fields and configuration of a piece of content.
*   Visualizer. The visualizer defines how the content item is formatted and styled. Just as a container is used to format and style a module, the visualizer is used to format and style the content item.
*   Content Item. The individual pieces of content.

A content item can be of any defined content type. Default content types include Content Block, Department, Job Posting, and People. You can create a content type from scratch or you can customize a default content type by duplicating it and then editing the copy.

Every content type is comprised of one or more fields of the following types:

*   [Single-line text](content-field-single-line-text)
*   [Multi-line text](content-field-multi-line-text)
*   [Number](content-field-number)
*   [Multiple choice](content-field-multiple-choice)
*   [Date / Time](content-field-date-time)
*   [Assets](content-field-assets)
*   [Reference object](content-field-reference-object)
*   [Static text](content-field-static-text)

An asset can be an image or a document. A reference object points to another content item; reference objects cannot be nested.

Each field can also be formed differently and, therefore, serve a different purpose. Example: The single-line text field could be used to enter plain text, a URL, an email address, or a phone number, and each one would be validated based on the selected format.

Settings can be different among different field types and among different field formats.

Example: The content item associated with a specific subscriber can be of the default content type Person. To create a content type Employee, you can duplicate the default content type Person, then add:

Field Name

Field Type

Employee Number

Number

Hire Date

DateTime

Annual Salary

Number

Direct Manager

Reference object

A content type is associated with a visualizer, which defines how content items of that type are displayed. Visualizers are to content types, as containers are to modules.

You can define multiple visualizers for a single content type. Example: You could have content items based on the Personcontent type containing employee information. You might want to display the C-suite members in larger font with photos and the rest of the company in smaller font without photos. Therefore, you need two visualizers for the Person content type: one with larger font and photos, another with smaller font and no photos.

## Create Structured Content

To create and use structured content,

1.  Plan your workflows. A workflow moves your content through the creation and approval process, from drafting to editing to publishing.
2.  Choose what content types you would accept. Create custom content types, if needed.
3.  Add content items. You can associate a workflow with each content item.
4.  Choose which visualizers would display your content items. Create custom visualizers, if needed.
5.  Add your content items with their associated visualizers to your page or your app.