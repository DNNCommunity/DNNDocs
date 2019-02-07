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

> [!TIP]
> Evoq UI is the easiest way to create content types in most cases. To copy content types to multiple sites/servers, you can use the Export/Import feature.

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

<table>
    <th><strong>Field Type</strong></th><th><strong>Code Snippet(s)</strong></th>
    <tr>
        <td>Single-Line Text</td>
        <td>
            For a plain text field:<br />
            <pre>"type" : "singleLineText",
                 "settings": {
                     "subType": "singleLine",
                     "phoneNumberFormat": null
                 }
            </pre>
            <br />
            For a URL/website:<br />
            <pre>
            "type" : "singleLineText",
            "settings": {
                "subType": "url",
                "phoneNumberFormat": null
            }
            </pre>
            <br />
            For an email address:
            <br />
            <pre>
            "type" : "singleLineText",
            "settings": {
                "subType": "email",
                "phoneNumberFormat": null
            }
            </pre>
            <br />
            For a phone number:
            <br />
            <pre>
                "type" : "singleLineText",
                "settings": {
                    "subType": "phoneNumber",
                    "phoneNumberFormat": null
                }
            </pre>
        </td>
    </tr>
    <tr>
        <td>Multi-Line Text</td>
        <td>For plain text:<br />
            <pre>
                "type" : "multiLineText",
                "settings": {
                    "subType": "multiLine"
                }
            </pre>
            <br />
            For rich text:
            <pre>
                "type" : "multiLineText",
                "settings": {
                    "subType": "textEditor"
                }
            </pre>
        </td>
    </tr>
    <tr>
        <td>Number</td>
        <td>Example:<br />
            <pre>"type": "numberSelector",
                "settings": {
                    "subType": "singleLine",
                    "numberSetFormat": "decimal",
                    "spinnerOrientation": "horizontal",
                    "numberRange": {
                        "minimum": 1.0,
                        "maximum": 5.0
                    }
                }
            </pre><br />
            To specify the number set:
            <ul>
                <li>Integers: <pre>"numberSetFormat": "integer"</pre></li>
                <li>Decimals: <pre>"numberSetFormat": "decimal"</pre></li>
                <li>Percentages: <pre>"numberSetFormat": "percentage"</pre></li>
            </ul>
            To indicate how the selection is displayed in the UI:
            <ul>
                <li>As a plain text box:<br />
                    <pre>"subType": "singleLine"</pre>
                </li>
                <li> As a vertical spinner:<br />
                    <pre>"subType": "spinner",
                         "spinnerOrientation": "vertical"</pre>
                </li>
                <li>As a horizontal spinner:<br />
                    <pre>    
                    "subType": "spinner",
                    "spinnerOrientation": "horizontal"
                    </pre>
                </li>
                <li>As a dropdown:<br />
                    <pre>
                    "subType": "dropdown"
                    </pre>
                </li>
            </ul>
            To specify the number range, use floats regardless of the number set:
            <pre>
                "numberRange": {
                    "minimum": 1.0,
                    "maximum": 5.0
                }
            </pre>                   
        </td>
    </tr>
    <tr>
        <td>Multiple Choice</td>
        <td>Example:
            <pre>
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
            </pre><br />
            To change how the choices are displayed in the Evoq UI:
            <ul>
                <li>As a dropdown: <pre>"subType": "dropDown"</pre></li>
                <li>As checkboxes: <pre>"subType": "checkBox"</pre></li>
                <li>As radiobuttons: <pre>"subType": "radioButton"</pre></li>
            </ul>
            To specify the options, enter each as the value of a <em>label</em> setting in the <em>choices</em> array.
            <pre>
            "settings": {
                ...
                "choices": [
                    { "label": "blue" },
                    { "label": "green" }
                ],
                ...
            }
            </pre><br />
            To indicate the number of selected choices:
            <ul>
                <li>To allow only one selection, <pre>"multiSelect": false</pre></li>
                <li>To allow more than one selection, <pre>"multiSelect": true</pre></li>
            </ul><br />
            To specify how checkboxes and radio buttons are displayed (List orientation is ignored for dropdown lists.):
            <ul>
                <li>To display the choices vertically, <pre>"listOrientation": "vertical"</pre> </li>
                <li>To display the choices horizontally, <pre>"listOrientation": "horizontal"</pre></li>
            </ul><br />
            To allow <strong>Other</strong> as an option: `"otherAsAnOption": true`
        </td>
    </tr>
    <tr>
        <td>Date / Time</td>
        <td>Example:<br />
        <pre>
            "type" : "dateTime",
            "settings": {
                "subType": "date",
                "dateFormat": "yyyymmdd",
                "timeFormat": "hr24",
                "timeZoneInfoActive": false,
                "timeZoneInfoId": "Dateline Standard Time"
            },
        </pre><br />
        To choose the variation:
        <ul>
            <li>For the date only: <pre>"subType": "date"</pre></li>
            <li>For the time only: <pre>"subType": "time"</pre></li>
            <li>For both date and time: <pre>"subType": "dateTime"</pre></li>
        </ul>
        Valid date formats:
        <ul>
            <li><pre>`"dateFormat": "ddmmyy"</pre></li>
            <li><pre>"dateFormat": "mmddyy"</pre></li>
            <li><pre>"dateFormat": "ddmmyyyy"</pre></li>
            <li><pre>"dateFormat": "mmddyyyy"</pre></li>
            <li><pre>"dateFormat": "yyyymmdd"</pre></li>
        </ul>
        Valid time formats:
        <ul>
            <li><pre>"timeFormat": "hr24"</pre></li>
            <li><pre>timeFormat": "amPm"</pre></li>
        </ul>
        To use the default timezone:
        <pre>
        "timeZoneInfoActive": false,
        "timeZoneInfoId": "Dateline Standard Time"
        </pre>                   
        To specify UTC for the indicated time:
        <pre>
        "timeZoneInfoActive": true,
        "timeZoneInfoId": "UTC"
        </pre>                                        
        To specify the Pacific timezone for the indicated time:
            <pre>"timeZoneInfoActive": true,<br />
            "timeZoneInfoId": "Pacific Standard Time"</pre>      
        </td>    
    </tr>
    <tr>
        <td>Assets</td>
        <td>
            For an image asset:
            <pre>
            "type" : "assets",
            "settings": {
                "subType": "image",
                "maxAssets": 1
            },
            </pre><br />
            For a document asset:
            <pre>
            "type" : "assets",
            "settings": {
                "subType": "document",
                "maxAssets": 1
            },
            </pre>
        </td>
    </tr>
    <tr>   
        <td>Reference Object</td>
        <td>
            To accept only one reference:<br />
            <pre>
                "type" : "referenceObject",
                "settings": {
                    "subType": "singleReferenceObject"
                }
            </pre><br />
            To accept multiple references:
            <pre>
                "type" : "referenceObject",
                "settings": {
                    "subType": "multiReferenceObject"
                }
            </pre>           
        </td>
    </tr>

    <tr>
        <td>Static Text</td>
        <td>
            To specify a static heading (headingType can be "h2", "", ):<br />
            <pre>
                "type" : "staticText",
                "settings": {
                    "subType": "heading",
                    "headingType": "h2",
                    "headingContent": "MyHeading",
                    "paragraphContent": ""
                },
            </pre><br />
            To specify a paragraph:
            <pre>
            "type" : "staticText",
            "settings": {
                "subType": "paragraph",
                "headingType": "",
                "headingContent": "",
                "paragraphContent": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam imperdiet turpis turpis, blandit varius nibh dignissim ut."
            },
            </pre>
        </td>
    </tr>
</table> 

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

The validation *node* can contain the following settings.

<table>
    <th><strong>Validation Setting</strong></th>
    <th><strong>Applicable in Field Types</strong></th>
    <th><strong>Description and Example</strong></th>
    <tr>
        <td><em>requireField</em></td>
        <td>All field types</td>
        <td>If the field is optional,
            <pre>
            "requireField": {
                "active": false,
                "errorMessage": null
            }
            </pre><br />                
            If the user must enter a value for the field,
            <pre>
            "requireField": {
                "active": true,
                "errorMessage": "This is a required field"
            }
            </pre>
        </td>
    </tr>
    <tr>
        <td><em>standardErrorMessage</em></td>
        <td>All field types</td>
        <td>The error message to use for all other errors without defined error messages.<br />
            <pre>"standardErrorMessage": null</pre>
        </td>
    </tr>
    <tr>
        <td><em>numberOfCharacters</em></td>
        <td><em>singleLineText<br />multiLineText</em></td>
        <td>If the field can contain any number of characters,
            <pre>
                "numberOfCharacters": {
                    "active": false,
                    "rangeDefinition": null,
                    "minimum": null,
                    "minimumUnit": null,
                    "maximum": null,
                    "maximumUnit": null,
                    "errorMessage": null
                },
            </pre><br />
            If the number of characters must be restricted, you can specify a range, only the minimum, or only the maximum.
            <br />
            Range restriction: If the text must have 5 to 140 characters,
            <pre>
            "numberOfCharacters": {
                "active": true,
                "rangeDefinition": "between",
                "minimum": 5,
                "minimumUnit": null,
                "maximum": 140,
                "maximumUnit": null,
                "errorMessage": "This field does not meet the required number of characters"
            },
            </pre>
            <br />
            Minimum restriction: If the text must have at least 20 characters,
            <pre>
                "numberOfCharacters": {
                    "active": true,
                    "rangeDefinition": "minimum",
                    "minimum": 20,
                    "minimumUnit": null,
                    "maximum": null,
                    "maximumUnit": null,
                    "errorMessage": "This field does not meet the required number of characters"
                },
            </pre>                        
            <br />
            Maximum restriction: If the text must have no more than 500 characters,
            <pre>
            "numberOfCharacters": {
                "active": true,
                "rangeDefinition": "maximum",
                "minimum": null,
                "minimumUnit": null,
                "maximum": 500,
                "maximumUnit": null,
                "errorMessage": "This field does not meet the required number of characters"
            },
            </pre>
        </td>
    </tr>
    <tr>
        <td><em>numberOfReferences</em></td>
        <td><em>referenceObject</em> (Multi-Reference Object)</td>
        <td>If the field can contain any number of references,
            <pre>
                "numberOfReferences": {
                    "active": false,
                    "rangeDefinition": null,
                    "minimum": null,
                    "minimumUnit": null,
                    "maximum": null,
                    "maximumUnit": null,
                    "errorMessage": null
                },
            </pre>
        <br />
        If the number of references must be restricted, you can specify a range, only the minimum, or only the maximum.
        <br />
        Range restriction: If the field must refer to 2 to 5 content items,<br />
        <pre>
        "numberOfReferences": {
            "active": true,
            "rangeDefinition": "between",
            "minimum": 2,
            "minimumUnit": null,
            "maximum": 5,
            "maximumUnit": null,
            "errorMessage": "This field does not meet the required number of references"
        },             
        </pre><br />
        Minimum restriction: If the field must refer to at least 2 content items,
        <pre>
        "numberOfReferences": {
            "active": true,
            "rangeDefinition": "minimum",
            "minimum": 2,
            "minimumUnit": null,
            "maximum": null,
            "maximumUnit": null,
            "errorMessage": "This field does not meet the required number of references"
        },
        </pre><br />
        Maximum restriction: If the field must refer to no more than 5 content items,
        <pre>
        "numberOfReferences": {
            "active": true,
            "rangeDefinition": "maximum",
            "minimum": null,
            "minimumUnit": null,
            "maximum": 5,
            "maximumUnit": null,
            "errorMessage": "This field does not meet the required number of references"
        },
        </pre>              
        </td>
    </tr>
    <tr>
        <td><em>dropdownOrder</em></td>
        <td><em>numberSelector</em></td>
        <td><pre>"dropdownOrder": "ascending"</pre></td>
    </tr>
    <tr>
        <td><em>dateRange</em></td>
        <td><em>dateTime</em></td>
        <td>
            If the date is not restricted,
            <br />
            <pre>
            "dateRange": {
                "active": false,
                "rangeDefinition": null,
                "startDateTime": null,
                "endDateTime": null,
                "errorMessage": null
            }
            </pre><br />
            If the date must be restricted, you can specify a date range (<pre>between</pre>), only the start date (<pre>after</pre>), or only the end date (<pre>before</pre>).
            <br />
            Range restriction: If the date must fall between 2017-07-10 and 2017-07-14,<br />
            <pre>"dateRange": { "active": true, "rangeDefinition": "between", "startDateTime": "2017-07-10T19:00:00Z", "endDateTime": "2017-07-14T19:00:00Z", "errorMessage": "Your date is not within the accepted date range." }</pre><br />
            Start date restriction: If the date must be after 2017-07-31,<br />
            <pre>"dateRange": { "active": true, "rangeDefinition": "after", "startDateTime": "2017-07-31T19:00:00Z", "endDateTime": null, "errorMessage": "Your date is not within the accepted date range." }</pre>
            <br />
            End date restriction: If the date must be before 2017-07-01,
            <pre>"dateRange": { "active": true, "rangeDefinition": "before", "startDateTime": null, "endDateTime": "2017-07-01T19:00:00Z", "errorMessage": "Your date is not within the accepted date range." }</pre>
        </td>
    </tr>
    <tr>
        <td><em>timeRange</em></td>
        <td><em>dateTime</em></td>
        <td>
            If the time is not restricted,<br />
        <pre>
        "timeRange": {
            "active": false,
            "rangeDefinition": null,
            "startDateTime": null,
            "endDateTime": null,
            "errorMessage": null
        }
        </pre>
        <br />
        If the time must be restricted, you can specify a time span (<pre>between</pre>), only the start time (<pre>after</pre>), or only the end time (<pre>before</pre>).
        <br />
        Span restriction: If the time must fall within a time span,<br />
        <pre>"timeRange": { "active": true, "rangeDefinition": "between", "startDateTime": "09:00:00", "endDateTime": "19:59:00", "errorMessage": "Your time is not within the accepted time range." }</pre>
        <br />
        Start time restriction: If the time must be after 21:00,<br />
        <pre>"timeRange": { "active": true, "rangeDefinition": "after", "startDateTime": "21:00:00", "endDateTime": "23:59:00", "errorMessage": "Your time is not within the accepted time range." }</pre><br />
        End time restriction: If the time must be before 05:00,
        <pre>"timeRange": { "active": true, "rangeDefinition": "before", "startDateTime": "00:00:00", "endDateTime": "05:00:00", "errorMessage": "Your time is not within the accepted time range." },</pre>
        </td>
    </tr>
</table>

## User Hints

To provide hints that describe the purpose of the field, you can add a field description or a tooltip.

<table>
    <th><strong>Setting</strong></th>
    <th><strong>Description and Example</strong></th>
    <tr>
        <td>
            Description<ul>
                <li><em>descriptionActive</em></li>
                <li><em>description</em></li>
            </ul>
        </td>
        <td>
        Set <em>descriptionActive</em> to <pre>true</pre> to display the value of <em>description</em> below the field in the Evoq UI.<br />
        No description:<br />
            <pre>    
            "descriptionActive": false,
            "description": ""
            </pre><br />
        With description:<br />
            <pre>
            "descriptionActive": true,
            "description": "This is the field description."
            </pre>
        </td>
    </tr>
    <tr>
        <td>Tooltip
            <ul>
                <li><em>tooltipActive</em>
                <li><em>tooltip</em></li>
        </td>
        <td>
            Set <em>tooltipActive</em> to <pre>true</pre> to include the information icon, which displays the value of <em>tooltip</em> when clicked/tapped in the Evoq UI.
            <br />
            No tooltip:
            <em>
            "tooltipActive": false,
            "tooltip": ""
            </em>
            <br />
            With tooltip:
            <br />
            <pre>
            "tooltipActive": true,
            "tooltip": "This is the field's tooltip."
            </pre> 
        </td>
    </tr>
</table>

## UI Positioning

Some settings are required to display the content type correctly in the UI. The canvas that displays the fields are comprised of rows. Each row can be divided into three or four equal parts, and each part contains one field.

<table>
    <th><strong>Setting</strong></th>
    <th><strong>Description and Example</strong></th>
    <tr>
        <td><em>row</em></td>
        <td>The numbering of rows are zero-based; therefore, the first row is Row 0.<br />
        Example: <pre>"row" : 2</pre></td>
    </tr>
    <tr>
        <td><em>width</em></td>
        <td>
            The width of the field, relative to the width of the canvas. Possible values are:
            <ul>
                <li>full</li>
                <li>threeQuarters</li>
                <li>twoThirds</li>
                <li>half</li>
                <li>third</li>
                <li>quarter</li>
            </ul>
            <strong>Note: The division of the row must be consistent between width and position.</strong>
            <br />
            Examples:
            <ul>
                <li><pre>"width" : "full"</pre></li>
                <li><pre>"width" : "twoThirds"</pre></li>
                <li><pre>"width" : "quarter"</pre></li>
            </ul>
        </td>
    </tr>
    <tr>
        <td>
            <em>position</em></td><td>The position of the field in the row.<br />
            If the row is divided into four sections, possible values are:
            <ul>
                <li>start</li>
                <li>quarter</li>
                <li>half</li>
                <li>threeQuarters</li>
            </ul>
            <br />
            If the row is divided into three sections, possible values are:
            <ul>
                <li>start</li>
                <li>third</li>
                <li>twoThirds</li>
            </ul>
            <br />
            Examples:
            <ul>
                <li><pre>"position" : "start"</pre>
                <li><pre>"position" : "half"</pre>
                <li><pre>"position" : "third"</pre>
            </ul>
        </td>
    </tr>
</table>

> [!NOTE]
> The division of the row must be consistent between width and position.


> [!Important]
> If a row overflows (i.e., too many fields), if fields overlap in a row, or if the fields assume a different type of row division (i.e., one field uses quarters and another uses thirds), your POST request might be rejected.

If width is `full`, the position must be `start`, and no other fields are allowed in the same row.

```
"row" : 0,
"width" : "full",
"position" : "start"         
```