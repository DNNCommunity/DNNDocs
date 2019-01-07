---
topic: api-contenttypes-get
locale: en
title: GET Content Types
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-content-type-apis
related-topics: api-contenttypes-id-get,api-contenttypes-post,api-contenttypes-id-put,api-contenttypes-id-delete,about-structured-content-api-get-responses
---

# GET Content Types

## GET /api/ContentTypes

Gets all content types that match the specified criteria.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/ContentTypes?query

```

query

Can include the following keys and their associated values:

query.searchText

\[string\] (Optional)

query.startIndex

\[integer\] (Optional)

query.maxItems

\[integer\] (Optional)

query.fieldOrder

\[string\] (Optional)

query.orderAsc

\[boolean\] (Optional)

query.createdFrom

\[string\] (Optional)

query.createdTo

\[string\] (Optional)

## HTTP Response

Status: 200

```

{
    "documents" : "array"
    "totalResultCount" : "integer"
}

```

documents

\[array\]

totalResultCount

\[integer\]