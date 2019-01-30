---
uid: about-structured-content-api-post-put-type-fields
topic: about-structured-content-api-post-put-type-fields
locale: en
title: About Liquid Content™ Content Type Fields for POST and PUT APIs
dnneditions: 
dnnversion: 09.02.00
parent-topic: about-structured-content-apis
related-topics: about-structured-content-content-type-apis,about-structured-content-content-item-apis,about-structured-content-published-content-item-apis,about-structured-content-api-get-responses
---

# About Liquid Content™ Content Type Fields for POST and PUT APIs

The JSON structure in the body of the POST request requires a `fields` array, and each field in the content type is defined as a node in the fields array.

Example of a JSON node in the `fields` array:

```

"fields": [
    ...
    {
        "type": "singleLineText",
        "defaultValue": null,
        "setDefaultValueAsHidden": false,
        "settings": {
            "subType": "singleLine",
            "phoneNumberFormat": null
        },
        "validation": {
            "requireField": {
                "active": true,
                "errorMessage": "This is a required field"
            },
            "numberOfCharacters": {
                "active": false,
                "rangeDefinition": "between",
                "minimum": null,
                "minimumUnit": null,
                "maximum": null,
                "maximumUnit": null,
                "errorMessage": "This field does not meet the required number of characters"
            },
            "standardErrorMessage": null
        },
        "id": "aa50984e-b459-4caa-94b9-5fa3a95ff082",
        "name": "lastName",
        "label": "Last Name",
        "descriptionActive": false,
        "description": "",
        "tooltipActive": false,
        "tooltip": "",
        "row": 0,
        "width": "half",
        "position": "half"
    },
    ...
]
                
```

Tip: Evoq UI is the easiest way to create content types in most cases. To copy content types to multiple sites/servers, you can use the Export/Import feature.

If you want to create multiple similar content types or if you want to recreate the same content types for testing,

1.  create one of the content types in the UI,
2.  request (GET) that content type from your app,
3.  clean up the resulting JSON to remove the specific values, such as the id of the content type and of reference fields, and
4.  replace the old values with values for the new type.

## Field Types

A field can be any of the following types:

*   Single-Line Text
*   Multi-Line Text
*   Number
*   Multiple Choice
*   Date/Time
*   Assets
*   Reference Object
*   Static Text

Each type could require additional settings. Example: The Single Line Text type requires the subtype setting.

Also see the [Validation section](#validation).

Field Type

Code Snippet(s)

Single-Line Text

For a plain text field:

```

"type" : "singleLineText",
"settings": {
    "subType": "singleLine",
    "phoneNumberFormat": null
}
                        
```

For a URL/website:

```

"type" : "singleLineText",
"settings": {
    "subType": "url",
    "phoneNumberFormat": null
}
                        
```

For an email address:

```

"type" : "singleLineText",
"settings": {
    "subType": "email",
    "phoneNumberFormat": null
}
                        
```

For a phone number:

```

"type" : "singleLineText",
"settings": {
    "subType": "phoneNumber",
    "phoneNumberFormat": null
}
                        
```

Multi-Line Text

For plain text:

```

"type" : "multiLineText",
"settings": {
    "subType": "multiLine"
}
                        
```

For rich text:

```

"type" : "multiLineText",
"settings": {
    "subType": "textEditor"
}
                        
```

Number

Example:

```

"type": "numberSelector",
"settings": {
    "subType": "singleLine",
    "numberSetFormat": "decimal",
    "spinnerOrientation": "horizontal",
    "numberRange": {
        "minimum": 1.0,
        "maximum": 5.0
    }
}
                        
```

To specify the number set:

*   Integers: `"numberSetFormat": "integer"`
*   Decimals: `"numberSetFormat": "decimal"`
*   Percentages: `"numberSetFormat": "percentage"`

To indicate how the selection is displayed in the UI:

*   As a plain text box:
    
    ```
    
    "subType": "singleLine"
                                    
    ```
    
*   As a vertical spinner:
    
    ```
    
    "subType": "spinner",
    "spinnerOrientation": "vertical"
                                    
    ```
    
*   As a horizontal spinner:
    
    ```
    
    "subType": "spinner",
    "spinnerOrientation": "horizontal"
                                    
    ```
    
*   As a dropdown:
    
    ```
    
    "subType": "dropdown"
                                    
    ```
    

To specify the number range, use floats regardless of the number set:

```

"numberRange": {
    "minimum": 1.0,
    "maximum": 5.0
}
                        
```

Multiple Choice

Example:

```

"type": "multipleChoice",
"defaultValue": "blue",
"settings": {
    "subType": "dropDown",
    "choices": [
        { "label": "blue" },
        { "label": "green" }
    ],
    "multiSelect": false,
    "listOrientation": "vertical",
    "otherAsAnOption": false
}
                        
```

To change how the choices are displayed in the Evoq UI:

*   As a dropdown: `"subType": "dropDown"`
*   As checkboxes: `"subType": "checkBox"`
*   As radiobuttons: `"subType": "radioButton"`

To specify the options, enter each as the value of a label setting in the choices array.

```

"settings": {
    ...
    "choices": [
        { "label": "blue" },
        { "label": "green" }
    ],
    ...
}
                        
```

To indicate the number of selected choices:

*   To allow only one selection, `"multiSelect": false`
*   To allow more than one selection, `"multiSelect": true`

To specify how checkboxes and radio buttons are displayed (List orientation is ignored for dropdown lists.):

*   To display the choices vertically, `"listOrientation": "vertical"`
*   To display the choices horizontally, `"listOrientation": "horizontal"`

To allow Other as an option: `"otherAsAnOption": true`

Date / Time

Example:

```

"type" : "dateTime",
"settings": {
    "subType": "date",
    "dateFormat": "yyyymmdd",
    "timeFormat": "hr24",
    "timeZoneInfoActive": false,
    "timeZoneInfoId": "Dateline Standard Time"
},
                        
```

To choose the variation:

*   For the date only: `"subType": "date"`
*   For the time only: `"subType": "time"`
*   For both date and time: `"subType": "dateTime"`

Valid date formats:

*   `"dateFormat": "ddmmyy"`
*   `"dateFormat": "mmddyy"`
*   `"dateFormat": "ddmmyyyy"`
*   `"dateFormat": "mmddyyyy"`
*   `"dateFormat": "yyyymmdd"`

Valid time formats:

*   `"timeFormat": "hr24"`
*   `"timeFormat": "amPm"`

To use the default timezone:

```

"timeZoneInfoActive": false,
"timeZoneInfoId": "Dateline Standard Time"
                        
```

To specify UTC for the indicated time:

```

"timeZoneInfoActive": true,
"timeZoneInfoId": "UTC"
                        
```

To specify the Pacific timezone for the indicated time:

```

"timeZoneInfoActive": true,
"timeZoneInfoId": "Pacific Standard Time"
                        
```

Assets

For an image asset:

```

"type" : "assets",
"settings": {
    "subType": "image",
    "maxAssets": 1
},
                        
```

For a document asset:

```

"type" : "assets",
"settings": {
    "subType": "document",
    "maxAssets": 1
},
                        
```

Reference Object

To accept only one reference:

```

"type" : "referenceObject",
"settings": {
    "subType": "singleReferenceObject"
}
                        
```

To accept multiple references:

```

"type" : "referenceObject",
"settings": {
    "subType": "multiReferenceObject"
}
                        
```

Static Text

To specify a static heading (headingType can be "h2", "", ):

```

"type" : "staticText",
"settings": {
    "subType": "heading",
    "headingType": "h2",
    "headingContent": "MyHeading",
    "paragraphContent": ""
},
                        
```

To specify a paragraph:

```

"type" : "staticText",
"settings": {
    "subType": "paragraph",
    "headingType": "",
    "headingContent": "",
    "paragraphContent": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam imperdiet turpis turpis, blandit varius nibh dignissim ut."
},
                        
```

## Name and Label

All fields require a name and a label. Example:

```

"name": "firstName",
"label": "First Name"
            
```

## Default Value

A field could have a default value setting (defaultValue) which is stored as a string. This setting is required whether the field has a default value or not.

You can also hide the default value from the user. However, if the default value is hidden, the field must not be required.

Without a default value:

```

"defaultValue" : null
                
```

With a default value that is shown:

```

"defaultValue" : "This is my default.",
"setDefaultValueAsHidden" : false
                
```

With a default value that is hidden:

```

"defaultValue" : "This is my default.",
"setDefaultValueAsHidden": true,
...
"validation" : {
    "requireField" : {
        "active" : false,
        "errorMessage" : null
    },
},
...
                
```
<a name="validation"></a>
## Validation

You can optionally require validation for data entered in the field. Each field type requires different validation settings.

Example: The following settings require a value for a Single-Line Text field but it doesn't impose a limit on the number of characters that can be entered:

```

"validation": {
    "requireField": {
        "active": true,
        "errorMessage": "This is a required field"
    },
    "numberOfCharacters": {
        "active": false,
        "rangeDefinition": "between",
        "minimum": null,
        "minimumUnit": null,
        "maximum": null,
        "maximumUnit": null,
        "errorMessage": "This field does not meet the required number of characters"
    },
    "standardErrorMessage": null
}
            
```

The validation node can contain the following settings.

Validation Setting

Applicable in Field Types

Description and Example

requireField

All field types

If the field is optional,

```

"requireField": {
    "active": false,
    "errorMessage": null
}
                        
```

If the user must enter a value for the field,

```

"requireField": {
    "active": true,
    "errorMessage": "This is a required field"
}
                        
```

standardErrorMessage

All field types

The error message to use for all other errors without defined error messages.

```
"standardErrorMessage": null
```

numberOfCharacters

singleLineText  
multiLineText

If the field can contain any number of characters,

```

"numberOfCharacters": {
    "active": false,
    "rangeDefinition": null,
    "minimum": null,
    "minimumUnit": null,
    "maximum": null,
    "maximumUnit": null,
    "errorMessage": null
},
                        
```

If the number of characters must be restricted, you can specify a range, only the minimum, or only the maximum.

Range restriction: If the text must have 5 to 140 characters,

```

"numberOfCharacters": {
    "active": true,
    "rangeDefinition": "between",
    "minimum": 5,
    "minimumUnit": null,
    "maximum": 140,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of characters"
},
                        
```

Minimum restriction: If the text must have at least 20 characters,

```

"numberOfCharacters": {
    "active": true,
    "rangeDefinition": "minimum",
    "minimum": 20,
    "minimumUnit": null,
    "maximum": null,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of characters"
},
                        
```

Maximum restriction: If the text must have no more than 500 characters,

```

"numberOfCharacters": {
    "active": true,
    "rangeDefinition": "maximum",
    "minimum": null,
    "minimumUnit": null,
    "maximum": 500,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of characters"
},
                        
```

numberOfReferences

referenceObject (Multi-Reference Object)

If the field can contain any number of references,

```

"numberOfReferences": {
    "active": false,
    "rangeDefinition": null,
    "minimum": null,
    "minimumUnit": null,
    "maximum": null,
    "maximumUnit": null,
    "errorMessage": null
},
                        
```

If the number of references must be restricted, you can specify a range, only the minimum, or only the maximum.

Range restriction: If the field must refer to 2 to 5 content items,

```

"numberOfReferences": {
    "active": true,
    "rangeDefinition": "between",
    "minimum": 2,
    "minimumUnit": null,
    "maximum": 5,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of references"
},
                        
```

Minimum restriction: If the field must refer to at least 2 content items,

```

"numberOfReferences": {
    "active": true,
    "rangeDefinition": "minimum",
    "minimum": 2,
    "minimumUnit": null,
    "maximum": null,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of references"
},
                        
```

Maximum restriction: If the field must refer to no more than 5 content items,

```

"numberOfReferences": {
    "active": true,
    "rangeDefinition": "maximum",
    "minimum": null,
    "minimumUnit": null,
    "maximum": 5,
    "maximumUnit": null,
    "errorMessage": "This field does not meet the required number of references"
},
                        
```

dropdownOrder

numberSelector

```

"dropdownOrder": "ascending"
                        
```

dateRange

dateTime

If the date is not restricted,

```

"dateRange": {
    "active": false,
    "rangeDefinition": null,
    "startDateTime": null,
    "endDateTime": null,
    "errorMessage": null
}
                        
```

If the date must be restricted, you can specify a date range (`between`), only the start date (`after`), or only the end date (`before`).

Range restriction: If the date must fall between 2017-07-10 and 2017-07-14,

`"dateRange": { "active": true, "rangeDefinition": "between", "startDateTime": "2017-07-10T19:00:00Z", "endDateTime": "2017-07-14T19:00:00Z", "errorMessage": "Your date is not within the accepted date range." }`

Start date restriction: If the date must be after 2017-07-31,

`"dateRange": { "active": true, "rangeDefinition": "after", "startDateTime": "2017-07-31T19:00:00Z", "endDateTime": null, "errorMessage": "Your date is not within the accepted date range." }`

End date restriction: If the date must be before 2017-07-01,

`"dateRange": { "active": true, "rangeDefinition": "before", "startDateTime": null, "endDateTime": "2017-07-01T19:00:00Z", "errorMessage": "Your date is not within the accepted date range." }`

timeRange

dateTime

If the time is not restricted,

```

"timeRange": {
    "active": false,
    "rangeDefinition": null,
    "startDateTime": null,
    "endDateTime": null,
    "errorMessage": null
}
                        
```

If the time must be restricted, you can specify a time span (`between`), only the start time (`after`), or only the end time (`before`).

Span restriction: If the time must fall within a time span,

`"timeRange": { "active": true, "rangeDefinition": "between", "startDateTime": "09:00:00", "endDateTime": "19:59:00", "errorMessage": "Your time is not within the accepted time range." }`

Start time restriction: If the time must be after 21:00,

`"timeRange": { "active": true, "rangeDefinition": "after", "startDateTime": "21:00:00", "endDateTime": "23:59:00", "errorMessage": "Your time is not within the accepted time range." }`

End time restriction: If the time must be before 05:00,

`"timeRange": { "active": true, "rangeDefinition": "before", "startDateTime": "00:00:00", "endDateTime": "05:00:00", "errorMessage": "Your time is not within the accepted time range." },`

## User Hints

To provide hints that describe the purpose of the field, you can add a field description or a tooltip.

Setting

Description and Example

Description

*   descriptionActive
*   description

Set descriptionActive to `true` to display the value of description below the field in the Evoq UI.

No description:

```

"descriptionActive": false,
"description": ""
                        
```

With description:

```

"descriptionActive": true,
"description": "This is the field description."
                        
```

Tooltip

*   tooltipActive
*   tooltip

Set tooltipActive to `true` to include the information icon, which displays the value of tooltip when clicked/tapped in the Evoq UI.

No tooltip:

```

"tooltipActive": false,
"tooltip": ""
                        
```

With tooltip:

```

"tooltipActive": true,
"tooltip": "This is the field's tooltip."
                        
```

## UI Positioning

Some settings are required to display the content type correctly in the UI. The canvas that displays the fields are comprised of rows. Each row can be divided into three or four equal parts, and each part contains one field.

Setting

Description and Example

row

The numbering of rows are zero-based; therefore, the first row is Row 0.

Example: `"row" : 2`

width

The width of the field, relative to the width of the canvas. Possible values are:

*   full
*   threeQuarters
*   twoThirds
*   half
*   third
*   quarter

Note: The division of the row must be consistent between width and position.

Examples:

*   `"width" : "full"`
*   `"width" : "twoThirds"`
*   `"width" : "quarter"`

position

The position of the field in the row.

If the row is divided into four sections, possible values are:

*   start
*   quarter
*   half
*   threeQuarters

If the row is divided into three sections, possible values are:

*   start
*   third
*   twoThirds

Note: The division of the row must be consistent between width and position.

Examples:

*   `"position" : "start"`
*   `"position" : "half"`
*   `"position" : "third"`

Important: If a row overflows (i.e., too many fields), if fields overlap in a row, or if the fields assume a different type of row division (i.e., one field uses quarters and another uses thirds), your POST request might be rejected.

If width is `full`, the position must be `start`, and no other fields are allowed in the same row.

```

"row" : 0,
"width" : "full",
"position" : "start"
            
```