---
topic: about-structured-content-api-get-responses
locale: en
title: About Liquid Content™ API Responses to GET Requests
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-apis
related-topics: about-structured-content-content-type-apis,about-structured-content-content-item-apis,about-structured-content-published-content-item-apis,about-structured-content-api-post-put-type-fields
---

# About Liquid Content™ API Responses to GET Requests

A Liquid Content API GET request can return either a JSON structure stored the body of the response or an error.

Different factors affect the contents of the response, including:

*   the parameters of the GET request
*   the number of results returned
*   whether the results are content types/items
*   the content type of the content item

## GET Parameters and Result Count

If the GET request includes the ID of a specific content type/item:

*   If none was found, the server returns a 404 message.
*   If the content type/item was found, the JSON structure contains information about the content type/item.
    
    ```
    
    {
        "id": "...",
        ...
    },
                            
    ```
    

If the GET request includes parameters in the query to filter the results, the JSON structure contains a documents array and totalResultCount.

*   If none was found, the documents array is empty.
    
    ```
    
    {
        "documents": [],
        "totalResultCount": 0
    }
                            
    ```
    
*   If one or more content types/items were found, the documents array contains one node for each content type/item in the results.
    
    ```
    
    {
        "documents": [
            {
                "id": "...",
                ...
            },
            {
                "id": "...",
                ...
            }
        ],
        "totalResultCount": 2
    }
                            
    ```
    

Note: By default, the maximum results returned is 10. Example: If 42 content items meet the criteria specified in the query of the request, only 10 will be returned. To override the default, set maxitems in the query string of the URL; e.g., `https://dnnapi.com/content/api/ContentItems?maxitems=500`

## Content Type Versus Content Item

Content type nodes differ from content item nodes as follows:

Content Type

Content Item

id name

icon

slug

The portion of the URL that uniquely identifies the content type for retrieval.

description

 

contentTypeId  
contentTypeName  
language

enabled

If `true`, content items can be created for this content type.

alreadyPublished

fields

Each field node includes the field type, the default value, the validation criteria, and the field's position in the form.

details

The values for the fields. If a field is a reference to another content type, `details` includes a node with the values for the fields of that referenced content type.

 

currentVersion

numberOfItems

The number of content items of this content type.

numberOfVisualizers

The number of visualizers associated with this content type.

usages

The number of times that a content item is used in other content items, in pages, or in apps.

Note: This is not the number of hits on the content item.

createdAt  
createdBy  
updatedAt  
updatedBy

isSystem

If `true`, the content type is one of the defaults and cannot be modified or deleted.

stateId

A code that represents the current workflow state. If 0, the item is in draft (unpublished) mode. If 1, the item is published.

tags

The list of tags associated with the content item.

clientReferenceId

\[string\] An external identifier used to synchronize the content item with clients, specifically the HTMLPro module in Evoq.

properties

seoSettings

## Content Type of the Content Item

The details node of the content item varies based on the defined fields of its content type.

Example: Suppose the content type definition contains the following two fields. (The definitions are simplified for clarity.)

Content Type Definition

Content Item Definition

```
"fields": [
```

```
"details": {
```

```

{
    "type": "multipleChoice",
    "defaultValue": null,
    "settings": {
        "subType": "radioButton",
        "choices": [
            { "label": "Evoq Engage" },
            { "label": "Evoq Content" },
            { "label": "Evoq Basic" },
            { "label": "DNN Platform" }
        ],
        "multiSelect": false,
        "listOrientation": "vertical",
        "otherAsAnOption": false
    },
    "validation": { ... },
    "name": "productName",
    "label": "Product Name", ...
},
                        
```

```

"productName": [
    "Evoq Content"
],
                        
```

```

{
    "type": "multipleChoice", ...
    "settings": {
        "subType": "radioButton",
        "choices": [
            { "label": "8.5" },
            { "label": "9.0" },
            { "label": "9.1" }
        ],
        "multiSelect": false,
        "listOrientation": "vertical",
        "otherAsAnOption": true
    },
    "validation": { ... },
    "name": "version",
    "label": "Version", ...
},
                        
```

```

"version": [
    "9.1"
],
                        
```

```

{
    "type": "dateTime", ...
    "settings": {
        "subType": "date",
        "dateFormat": "yyyymmdd",
        "timeFormat": "hr24",
        "timeZoneInfoActive": false,
        "timeZoneInfoId": "Dateline Standard Time"
    },
    "validation": { ... },
    "name": "releaseDate",
    "label": "Release Date", ...
},
                        
```

Dates and times are returned as Unix time.

```

"releaseDate": "1493208000",
                        
```

```

{
    "type": "singleLineText", ...
    "settings": {
        "subType": "url", ...
    },
    "validation": { ... },
    "name": "releaseNotes",
    "label": "Release Notes", ...
}
                        
```

```

"releaseNotes": "http://example.com"
                        
```

```
]
```

```
}
```