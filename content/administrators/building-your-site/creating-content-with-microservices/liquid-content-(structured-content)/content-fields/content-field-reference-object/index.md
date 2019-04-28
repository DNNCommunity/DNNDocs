---
uid: content-field-reference-object
locale: en
title: "Content Field: Reference Object"
dnneditions: Evoq Engage
dnnversion: 09.02.00
related-topics: content-field-assets,content-field-date-time,content-field-multi-line-text,content-field-multiple-choice,content-field-number,content-field-single-line-text,content-field-static-text
---

# Content Field: Reference Object

## Form Type

  

![Form Type for Reference Object field](/images/scr-ContentField-ReferenceObject-formtype.gif)

  

|**Field**|**Description**|
|---|---|
|**Appearance**|<ul><li><strong>Single Reference</strong>. Allows the user to link to only one content item.</li><li><strong>Multi Reference</strong>. Allows the user to link to multiple content items.|
|**Allowed Reference Types**|The list of content types that the reference can point to.|

## General Settings

  

![General Settings for Reference Object field](/images/scr-ContentField-ReferenceObject-generalsettings.gif)

  

|**Field**|**Description**|
|---|---|
|**Title/Label**|Name of the field. You can change the name either in the **General Settings** panel or directly above the field on the canvas.|
|**Description**|If enabled (**On**), displays the instructions or field description you enter in the provided text box. Maximum length: 140 characters.|
|**Tooltip**|If enabled (**On**) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.|

## Validation

  

![Validation for Reference Object field](/images/scr-ContentField-ReferenceObject-validation.png)

  

|**Field**|**Description**|
|---|---|
|**Error Message**|The message to display if the user entered data that does not meet the requirements for the field.|
|**Required**|If enabled (**On**):<ul><li>The field name is marked as required.</li><li>The message you enter in the provided text box will be displayed if the user does not provide a value in the field.</li></ul>|
|**Number of References**|If enabled (**On**), the message you enter in the provided text box will be displayed if the user provides a value outside the valid range. You must indicate the valid range:<ul><li><strong>Minimum</strong>. The valid range is from the value you enter in <strong>Min</strong> to infinity.</li><li><strong>Maximum</strong>. The valid range is from infinity to the value you enter in <strong>Max</strong>.</li><li><strong>Between</strong>. The valid range is from the value you enter in Min to the value you enter in Max.</li></ul><br /><strong>Min</strong> must be less than <strong>Max</strong>.|
