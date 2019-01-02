---
topic: api-publishedcontentitems-get
locale: en
title: GET Published Content Items
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-published-content-item-apis
related-topics: api-publishedcontentitems-getbyids-get,about-structured-content-api-get-responses
---

# GET Published Content Items

## GET /api/PublishedContentItems

Gets the latest versions of all published content items that match the specified criteria.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/PublishedContentItems?query

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