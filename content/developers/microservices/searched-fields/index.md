---
topic: searched-fields
locale: en
title: Liquid Content: Searched Fields
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-structured-content-overview
related-topics: visualizer-templates,api-results-pagination,about-structured-content-apis,examples-structured-content-apis
---

# Liquid Content: Searched Fields

## Overview

Some APIs accept `searchtext` as one of the criteria used to determine which items to return. Depending on the API object's type, the value of `searchtext` is compared with a different set of fields in the data.

## In Liquid Content™ (Structured Content)

Item Type

Searched Fields

all Structured Content items

*   TenantId
*   Name
*   Label

content items

*   TenantId
*   Name
*   ParentId
*   CreatedBy
*   UpdatedBy
*   Description
*   Details
*   ContentTypeId
*   ContentTypeName
*   Language
*   Tags
*   PreviousName
*   PreviousValues
*   PreviousUpdatedBy
*   DraftName
*   DraftUpdatedBy
*   DraftDescription
*   DraftDetails
*   DraftTags

visualizers

*   TenantId
*   Name
*   Description
*   ContentTypeId
*   ContentTypeName
*   CreatedBy
*   UpdatedBy