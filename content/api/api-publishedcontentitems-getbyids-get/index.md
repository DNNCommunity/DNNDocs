---
topic: api-publishedcontentitems-getbyids-get
locale: en
title: GET Published Content Items with ID Array
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-published-content-item-apis
related-topics: api-publishedcontentitems-get,about-structured-content-api-get-responses
---

# GET Published Content Items with ID Array

## GET /api/PublishedContentItems/GetByIds

Gets the latest versions of the published content items that match the specified identifiers.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/PublishedContentItems/GetByIds?query

```

query

Can include the following keys and their associated values:

contentItemIds

\[array\] Collection of content items identifiers.

## HTTP Response

Status: 200

```

{
    [
        {
            "id" : "string"
            "slug" : "string"
            "type" : "string"
            "contentTypeName" : "string"
            "name" : "string"
            "description" : "string"
            "tags" : "array"
            "language" : "string"
            "alreadyPublished" : "boolean"
            "details" : "object"
            "currentVersion" : "integer"
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
        , ...
    ]
}

```

type

items

id

\[string\]

slug

\[string\]

type

\[string\]

contentTypeName

\[string\]

name

\[string\]

description

\[string\]

tags

\[array\]

language

\[string\]

alreadyPublished

\[boolean\]

details

\[object\]

currentVersion

\[integer\]

createdAt

\[string\]

createdBy

id

\[string\]

name

\[string\]

thumbnail

\[string\]

updatedAt

\[string\]

updatedBy

id

\[string\]

name

\[string\]

thumbnail

\[string\]

seoSettings

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