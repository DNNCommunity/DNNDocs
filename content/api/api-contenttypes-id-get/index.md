---
topic: api-contenttypes-id-get
locale: en
title: GET Content Types with ID
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-content-type-apis
related-topics: api-contenttypes-get,api-contenttypes-post,api-contenttypes-id-put,api-contenttypes-id-delete,about-structured-content-api-get-responses
---

# GET Content Types with ID

## GET /api/ContentTypes/{id}

Gets the content type with the specified identifier.

## HTTP Request

In the URL,

```

https://dnnapi.com/content/api/ContentTypes/{id}

```

id

\[string\] The unique identifier of the content type to get.

## HTTP Response

Status: 200

```

{
    "id" : "string"
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
    "name" : "string"
    "icon" : "string"
    "description" : "string"
    "enabled" : "boolean"
    "fields" : "array"
    "numberOfItems" : "integer"
    "numberOfVisualizers" : "integer"
    "isSystem" : "boolean"
    "properties" :
        {
            "contentName" :
                {
                    "type" : "string"
                    "settings" :
                        {
                            "nameGeneratorFields" : "array"
                        }
                    "id" : "string"
                    "name" : "string"
                    "label" : "string"
                    "descriptionActive" : "boolean"
                    "description" : "string"
                    "tooltipActive" : "boolean"
                    "tooltip" : "string"
                    "row" : "integer"
                    "width" : "string"
                    "position" : "string"
                }
            "contentTags" :
                {
                    "type" : "string"
                    "validation" :
                        {
                            "requireField" :
                                {
                                    "active" : "boolean"
                                    "errorMessage" : "string"
                                }
                            "standardErrorMessage" : "string"
                        }
                    "id" : "string"
                    "name" : "string"
                    "label" : "string"
                    "descriptionActive" : "boolean"
                    "description" : "string"
                    "tooltipActive" : "boolean"
                    "tooltip" : "string"
                    "row" : "integer"
                    "width" : "string"
                    "position" : "string"
                }
            "contentDescription" :
                {
                    "type" : "string"
                    "validation" :
                        {
                            "requireField" :
                                {
                                    "active" : "boolean"
                                    "errorMessage" : "string"
                                }
                            "standardErrorMessage" : "string"
                        }
                    "id" : "string"
                    "name" : "string"
                    "label" : "string"
                    "descriptionActive" : "boolean"
                    "description" : "string"
                    "tooltipActive" : "boolean"
                    "tooltip" : "string"
                    "row" : "integer"
                    "width" : "string"
                    "position" : "string"
                }
        }
}

```

id

\[string\] The unique identifier of the content type.

createdAt

\[string\] When the content type was created.

createdBy

Who created the content type.

id

\[string\]

name

\[string\]

thumbnail

\[string\]

updatedAt

\[string\] When the content type was last updated.

updatedBy

Who last updated the content type.

id

\[string\]

name

\[string\]

thumbnail

\[string\]

name

\[string\] The name of the content type.

icon

\[string\] The icon associated with the content type.

description

\[string\] The description of the content type.

enabled

\[boolean\] If true, new content items of this content type can be created. Otherwise, not.

fields

\[array\] The set of fields that comprise the content type.

numberOfItems

\[integer\] The number of content items that are of this content type.

numberOfVisualizers

\[integer\] The number of visualizers associated with this content type.

isSystem

\[boolean\] If true, this content type is a default provided by DNN.

properties

The set of properties of the content type.

contentName

type

\[string\]

settings

nameGeneratorFields

\[array\]

id

\[string\]

name

\[string\]

label

\[string\]

descriptionActive

\[boolean\]

description

\[string\]

tooltipActive

\[boolean\]

tooltip

\[string\]

row

\[integer\]

width

\[string\]

position

\[string\]

contentTags

type

\[string\]

validation

requireField

active

\[boolean\]

errorMessage

\[string\]

standardErrorMessage

\[string\]

id

\[string\]

name

\[string\]

label

\[string\]

descriptionActive

\[boolean\]

description

\[string\]

tooltipActive

\[boolean\]

tooltip

\[string\]

row

\[integer\]

width

\[string\]

position

\[string\]

contentDescription

type

\[string\]

validation

requireField

active

\[boolean\]

errorMessage

\[string\]

standardErrorMessage

\[string\]

id

\[string\]

name

\[string\]

label

\[string\]

descriptionActive

\[boolean\]

description

\[string\]

tooltipActive

\[boolean\]

tooltip

\[string\]

row

\[integer\]

width

\[string\]

position

\[string\]