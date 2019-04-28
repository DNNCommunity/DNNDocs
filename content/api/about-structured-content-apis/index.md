---
uid: about-structured-content-apis
locale: en
title: About Liquid Content™ (Structured Content) APIs
dnneditions: 
dnnversion: 09.02.00
related-topics: developers-overview,glossary,creating-apps-that-use-microservices
---

# About Liquid Content™ (Structured Content) APIs

## Liquid Content™ (Structured Content) APIs

The Liquid Content™ (Structured Content) APIs expose the content types and content items in a site.

Different actions require different data in different components of the web request.

## Content Types

|  |**HTTP Method**|**URL**|**Query**|**Body**|
|---|---|---|---|---|---|
|[To get multiple content types using a filter](xref:api-contenttypes-get)|GET| |<ul><li>*maxitems*</li><li>and other filters</li></ul>| |
|[To get a specific content type](xref:api-contenttypes-id-get)|GET|ID of content type to get|  |  |
|[To create a content type](xref:api-contenttypes-post)|POST|  |  |<ul><li><em>name</em></li><li><em>icon</em></li><li><em>description</em></li><li><em>fields</em></li><li><em>properties</em></li></ul>|
|[To update a specific content type](xref:api-contenttypes-id-put)|PUT|ID of content type to update|  |fields to update|
|[To delete a specific content type](xref:api-contenttypes-id-delete)|DELETE|ID of content type to delete|  |  |

 

 

## Content Items
|  |**HTTP Method**|**URL**|**Query**|**Body**|
|---|---|---|---|---|
|[To get multiple content items using a filter](xref:api-contentitems-get)|GET|  |<ul><li><em>contentTypeId</em></li><li><em>maxitems</em></li><li><em>and other filters</em></li></ul>|  |
|[To get a specific content item](xref:api-contentitems-id-get)|GET|ID of content item to get|  |  |
|[To create a content item](xref:api-contentitems-post)|POST|  |<em>publish</em>|<ul><li><em>contentTypeId</em></li><li><em>name</em></li><li><em>description</em></li><li><em>fields</em></li><li><em>properties</em></li></ul>|
|[To update a specific content item](xref:api-contentitems-id-put)|PUT|ID of content item to update|*publish*|fields to update|
|[To delete a specific content item](xref:api-contentitems-id-delete)|DELETE|ID of content item to delete|  |  |
