---
topic: about-structured-content-apis
locale: en
title: About Liquid Content™ (Structured Content) APIs
dnneditions: 
dnnversion: 09.02.00
parent-topic: api-overview
related-topics: developers-overview,glossary,creating-apps-that-use-microservices
---

# About Liquid Content™ (Structured Content) APIs

## Liquid Content™ (Structured Content) APIs

The Liquid Content™ (Structured Content) APIs expose the content types and content items in a site.

Different actions require different data in different components of the web request.

## Content Types

 

HTTP Method

URL

Query

Body

[To get multiple content types using a filter](http://localhost/docs/api/api-contenttypes-get.html)

GET

 

*   maxitems
*   and other filters

 

[To get a specific content type](http://localhost/docs/api/api-contenttypes-id-get.html)

GET

ID of content type to get

 

 

[To create a content type](http://localhost/docs/api/api-contenttypes-post.html)

POST

 

 

*   name
*   icon
*   description
*   fields
*   properties

[To update a specific content type](http://localhost/docs/api/api-contenttypes-id-put.html)

PUT

ID of content type to update

 

fields to update

[To delete a specific content type](http://localhost/docs/api/api-contenttypes-id-delete.html)

DELETE

ID of content type to delete

 

 

## Content Items

 

HTTP Method

URL

Query

Body

[To get multiple content items using a filter](http://localhost/docs/api/api-contentitems-get.html)

GET

 

*   contentTypeId
*   maxitems
*   and other filters

 

[To get a specific content item](http://localhost/docs/api/api-contentitems-id-get.html)

GET

ID of content item to get

 

 

[To create a content item](http://localhost/docs/api/api-contentitems-post.html)

POST

 

publish

*   contentTypeId
*   name
*   description
*   fields
*   properties

[To update a specific content item](http://localhost/docs/api/api-contentitems-id-put.html)

PUT

ID of content item to update

publish

fields to update

[To delete a specific content item](http://localhost/docs/api/api-contentitems-id-delete.html)

DELETE

ID of content item to delete