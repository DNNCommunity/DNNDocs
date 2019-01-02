---
topic: api-contentitems-id-get
locale: en
title: GET Content Items with ID
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-content-item-apis
related-topics: api-contentitems-get,api-contentitems-post,api-contentitems-id-put,api-contentitems-id-delete,about-structured-content-api-get-responses
---

# GET Content Items with ID

## GET /api/ContentItems/{id}

Gets the content item with the specified identifier.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/ContentItems/{id}

```

id

\[string\] The unique identifier of the content item to get.

## HTTP Response

Status: 200

```

{
    "id" : "string"
    "slug" : "string"
    "contentTypeId" : "string"
    "contentTypeName" : "string"
    "name" : "string"
    "description" : "string"
    "language" : "string"
    "alreadyPublished" : "boolean"
    "details" : "object"
    "currentVersion" : "integer"
    "usages" : "integer"
    "createdAt" : "string"
    "createdBy" :
        {
            "id" : "string"
            "name" : "string"
            "thumbnail" : "string"
        }
    "updatedAt" : "string"
    "updatedBy" :
        {
            "id" : "string"
            "name" : "string"
            "thumbnail" : "string"
        }
    "stateId" : "integer"
    "tags" : "array"
    "clientReferenceId" : "string"
    "seoSettings" :
        {
            "pageTitle" : "string"
            "description" : "string"
            "keywords" : "array"
            "image" :
                {
                    "fileName" : "string"
                    "fileId" : "integer"
                    "url" : "string"
                }
        }
}

```

id

\[string\] The unique identifier of the content item.

slug

\[string\] The portion of the URL that uniquely identifies this content item for retrieval.

contentTypeId

\[string\] The unique identifier of the content type of the content item.

contentTypeName

\[string\] The name of the content type of the content item.

name

\[string\] The name of the content item.

description

\[string\] The description of the content item.

language

\[string\] The language of the content item.

alreadyPublished

\[boolean\] Whether the content item has been published.

details

\[object\] The JObject structure that contains the values of all dynamic fields of the content item.

currentVersion

\[integer\] The current version of the content item.

usages

\[integer\] The number of times that the content item is used.

createdAt

\[string\] When the content item was created.

createdBy

Who created the content item.

id

\[string\]

name

\[string\]

thumbnail

\[string\]

updatedAt

\[string\] When the content item was last updated.

updatedBy

Who last updated the content item.

id

\[string\]

name

\[string\]

thumbnail

\[string\]

stateId

\[integer\] A code that represents the current workflow state. If 0, the item is in draft (unpublished) mode. If 1, the item is published.

tags

\[array\] The list of tags associated with the content item.

clientReferenceId

\[string\] An external identifier used to synchronize the content item with clients, specifically the HTMLPro module in Evoq.

seoSettings

Seo settings of the content item.

pageTitle

\[string\]

description

\[string\]

keywords

\[array\]

image

fileName

\[string\]

fileId

\[integer\]

url

\[string\]