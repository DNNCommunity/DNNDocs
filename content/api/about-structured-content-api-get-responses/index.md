---
uid: about-structured-content-api-get-responses
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
    

> [!NOTE]
> By default, the maximum results returned is 10. Example: If 42 content items meet the criteria specified in the query of the request, only 10 will be returned. To override the default, set maxitems in the query string of the URL; e.g., `https://dnnapi.com/content/api/ContentItems?maxitems=500`

## Content Type Versus Content Item

Content type nodes differ from content item nodes as follows:

|**Content Type**|**Content Item**|
|---|---|
|*id name*| |
|*icon*|*slug*<br />The portion of the URL that uniquely identifies the content type for retrieval.|
|*description*| |
||*contentTypeId<br />contentTypeName<br />language*|
|*enabled*<br />If `true`, content items can be created for this content type.|*alreadyPublished*|
|*fields*<br />Each field node includes the field type, the default value, the validation criteria, and the field's position in the form.|*details*<br />The values for the fields. If a field is a reference to another content type, `details` includes a node with the values for the fields of that referenced content type.|
| | *currentVersion*|
|*numberOfItems*<br />The number of content items of this content type.<br />*numberOfVisualizers*<br />The number of visualizers associated with this content type.|*usages*<br />The number of times that a content item is used in other content items, in pages, or in apps.<br /><br /><strong>Note: This is not the number of hits on the content item</strong>.|
|*createdAt<br />createdBy<br />updatedAt<br />updatedBy*| |
|*isSystem*<br />If `true`, the content type is one of the defaults and cannot be modified or deleted.|*stateId*<br />A code that represents the current workflow state. If 0, the item is in draft (unpublished) mode. If 1, the item is published.<br />*tags*<br />The list of tags associated with the content item.<br />*clientReferenceId*<br />
\[string\] An external identifier used to synchronize the content item with clients, specifically the HTMLPro module in Evoq.|
|*properties*|*seoSettings*|

## Content Type of the Content Item

The details node of the content item varies based on the defined fields of its content type.

Example: Suppose the content type definition contains the following two fields. (The definitions are simplified for clarity.)

<table>
    <tr>
        <th><strong>Content Type Definition</strong></th><th><strong>Content Item Definition</strong></th>
    </tr>
    <tr>
        <td><pre>"fields": [</pre></td> <td><pre>"details": { </pre></td>
    </tr>
    <tr>
        <td>
            <pre>
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
            </pre>
        </td>
        <td>
            <pre>"productName": ["Evoq Content"],</pre>
        </td>
    </tr>
    <tr>
        <td>
            <pre>
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
            </pre>
        </td>
        <td>
            <pre>"version": ["9.1"],</pre>
        </td>
    </tr>
    <tr>
        <td>
            <pre>
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
            </pre>
        </td>
        <td>
            Dates and times are returned as Unix time.<br />
            <pre>"releaseDate": "1493208000",</pre>
        </td>
    </tr>
    <tr>
        <td>
            <pre>
            {
                "type": "singleLineText", ...
                "settings": {
                    "subType": "url", ...
                },
                "validation": { ... },
                "name": "releaseNotes",
                "label": "Release Notes", ...
            }
            </pre>
        </td>
        <td><pre>"releaseNotes": "http://example.com"</pre></td>
    </tr>
    <tr><td><pre>]</pre></td>
        <td><pre>}</pre></td>
    </tr>
</table>
