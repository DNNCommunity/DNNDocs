---
topic: api-contentitems-get
locale: en
title: GET Content Items
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-content-item-apis
related-topics: api-contentitems-id-get,api-contentitems-post,api-contentitems-id-put,api-contentitems-id-delete,about-structured-content-api-get-responses
---

# GET Content Items

## GET /api/ContentItems

Gets all content items that match the specified criteria.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/ContentItems?query

```

query

Can include the following keys and their associated values:

query.published

\[boolean\] (Optional) If true, only published content items are included in the results.

query.tags

\[string\] (Optional) The tags to search for. Comma-separated and URL-encoded. Example: tags=my%20tag,tag2,lastTag

query.contentTypeId

\[string\] (Optional)

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