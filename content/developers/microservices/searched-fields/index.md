---
uid: searched-fields
locale: en
title: "Liquid Content: Searched Fields"
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
related-topics: visualizer-templates,api-results-pagination,about-structured-content-apis,examples-structured-content-apis
---

# Liquid Content: Searched Fields

## Overview

Some APIs accept `searchtext` as one of the criteria used to determine which items to return. Depending on the API object's type, the value of `searchtext` is compared with a different set of fields in the data.

## In Liquid Content™ (Structured Content)

|**Item Type**|**Searched Fields**|
|---|---|
|all Structured Content items|<ul><li>TenantId</li><li>Name</li><li>Label</li></ul>|
|content items|<ul><li>TenantId</li><li>Name</li><li>ParentId</li><li>CreatedBy</li><li>UpdatedBy</li><li>Description</li><li>Details</li><li>ContentTypeId</li><li>ContentTypeName</li><li>Language</li><li>Tags</li><li>PreviousName</li><li>PreviousValues</li><li>PreviousUpdatedBy</li><li>DraftName</li><li>DraftUpdatedBy</li><li>DraftDescription</li><li>DraftDetails</li><li>DraftTags</li></ul>|
|visualizers|<ul><li>TenantId</li><li>Name</li><li>Description</li><li>ContentTypeId</li><li>ContentTypeName</li><li>CreatedBy</li><li>UpdatedBy</li></ul>|
