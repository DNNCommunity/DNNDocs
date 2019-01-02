---
topic: creating-apps-that-use-microservices
locale: en
title: Creating Apps That Use Microservices
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-microservices-overview
related-topics: about-jwt,create-api-key
---

# Creating Apps That Use Microservices

## Overview

DNN provides APIs that you can use to access the microservices from your app. Essentially, your app simply needs to generate HTTPS requests to https://dnnapi.com/content with specific information in the URL path, the URL query, or the body of the request, along with an API key in the HTTP header. The results are sent back in the body of the response from the server.

Structured Content has APIs for content types, content items, published content items, the visualizer engine, visualizer definitions, and visualizer instances.

[DNN Microservices API Reference](api-overview)

## Authorization

Before your app can access the content types and items of a site, the site's host/superuser must provide you with an API key for that site. The API key can be granted read-only or read-write permissions to content items and/or content types that belong to its associated site.

In the HTTP header of your request, you must include an authorization setting; i.e., "Authorization: Bearer myAPIkey" .

## HTTP Request

Each API is an HTTP request method: GET, POST, PUT, or DELETE. Example: The ContentTypes group under the Structured Content microservice allows you to do the following:

*   GET to retrieve the list of all items or specific item
*   POST to create a new item
*   PUT to update an existing item
*   DELETE to remove an existing item

An item might be a content type, a content item, a published content item, a visualizer, or a visualizer instance.

Important: All API HTTP requests for Evoq sites must go to https://dnnapi.com/content .

The microservices expect the parameters of an API in one of these locations:

*   URL query. If the API retrieves (GET) a list of items, according to a set of criteria, the criteria are specified as optional key-value pairs in the query portion of a URL.
*   URL path. If the API retrieves (GET), modifies (PUT), or deletes (DELETE) a specific item, the ID of the item is typically added to the URL path.
*   Message body. If the API creates (POST) or modifies (PUT) an item, the properties of the new item (POST) or the new properties of an existing item (PUT) are specified in a JSON-serialized data transfer object (DTO) in the body of the request. The fields in a DTO vary depending on the item type.

HTTP Method

Objective

Typical URL Path

HTTP Body

GET

list of items

https://dnnapi.com/content/api/apiname?field=value

(Not required.)

GET

specific item

https://dnnapi.com/content/api/apiname/itemID

(Not required.)

POST

specific item

https://dnnapi.com/content/api/apiname/itemID?publish=TRUE

JSON DTO

PUT

specific item

https://dnnapi.com/content/api/apiname/itemID?publish=TRUE

JSON DTO

DELETE

specific item

https://dnnapi.com/content/api/apiname/itemID

(Not required.)

## HTTP Response

If the API returns an item or a list of items, the result is a JSON-serialized DTO in the body of the response.

If the result is a list, the body of the response is a JSON object containing the following:

*   a documents array that contains the information for each item in a JSON object, and
*   a totalResultCount whose value indicates the number of items returned.

If the result is a single item, the body of the response is a JSON object that contains only that item.

## Getting the Item ID

Each item has a unique ID that identifies it, regardless of its type. Many of the APIs require the ID of the specific item to act on.

You can determine the ID of a specific item by performing a filtered GET and parsing the body of the response. Example: The GET /api/ContentTypes API returns a JSON-formatted list that match the criteria specified in the URL query. Each element of the resulting list includes a pair with the key `id`.

## Example

This example updates a content item using the PUT /api/ContentItems/{id} API, which takes three parameters:

*   `id`. (string) Required in the path.
*   `contentItem`. (JSON-formatted string) Required as the request body.
*   `publish`. (boolean) Optional parameter in the URL query.

1.  If you don't know the content item's ID, use GET /api/ContentItems with parameters that match the criteria you want. Then find the content item you want from the returned list. The returned list of content item objects will be in this format:
    
    ```
    
        {
            "documents": [
                {
                    "id": "11111111-...",
                    "contentTypeId": "myContentType",
                    "contentTypeName": "myContentType",
                    "name": "myContentItemName",
                    "description": "string",
                    "language": "string",
                    "alreadyPublished": true,
                    "details": {},
                    "currentVersion": 0,
                    "usages": 0,
                    "createdAt": "string",
                    "createdBy": {
                        "id": "string",
                        "name": "string",
                        "thumbnail": "string"
                    },
                    "updatedAt": "string",
                    "updatedBy": "StructuredContent.Models.UserInfo",
                    "stateId": 0,
                    "tags": [
                        "tag1", "tag2", "tag3"
                    ],
                    "clientReferenceId": "string"
                },
                {
                    "id": "22222222-...",
                    ...
                },
                {
                    "id": "33333333-...",
                    ...
                }
                ...
            ],
            "totalResultCount": "string"
        }
                        
    ```
    
2.  If you know the content item's ID, use GET /api/ContentItems/{id}. The returned content item object will be in this format:
    
    ```
    
        {
            "id": "11111111-...",
            "contentTypeId": "string",
            "contentTypeName": "string",
            "name": "string",
            "description": "string",
            "language": "string",
            "alreadyPublished": true,
            "details": {},
            "currentVersion": 0,
            "usages": 0,
            "createdAt": "string",
            "createdBy": {
                "id": "string",
                "name": "string",
                "thumbnail": "string"
            },
            "updatedAt": "string",
            "updatedBy": "StructuredContent.Models.UserInfo",
            "stateId": 0,
            "tags": [
                "tag1", "tag2", "tag3"
            ],
            "clientReferenceId": "string"
        }
                        
    ```
    
3.  Copy the values from the returned content item object and paste them to the body of your own PUT request. Then replace the values you want to change. The body parameter must be in this format:
    
    ```
    
        {
            "id": "11111111-...",
            "contentTypeId": "string",
            "contentTypeName": "string",
            "name": "My New Name",
            "description": "My new description goes here.",
            "language": "string",
            "alreadyPublished": true,
            "details": {},
            "currentVersion": 0,
            "usages": 0,
            "createdAt": "string",
            "createdBy": {
                "id": "string",
                "name": "string",
                "thumbnail": "string"
            },
            "updatedAt": "string",
            "updatedBy": "StructuredContent.Models.UserInfo",
            "stateId": 0,
            "tags": [
                "tag1", "tag2", "tag3", "my new tag"
            ],
            "clientReferenceId": "string"
        }
                        
    ```
    
    Note: You cannot change the ID.
    
4.  Construct the URL of your PUT request to contain the path parameter (id) and the optional query parameter (publish). Example: If id is "11111111-1111-1111" and you want the changes to be published immediately, then the URL would be as follows:
    
    ```
    
        https://dnnapi.com/content/api/ContentItems/11111111-1111-1111?publish=true
                        
    ```
    

Remember: Include the authentication token in the header.