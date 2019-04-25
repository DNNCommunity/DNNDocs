---
uid: content-field-single-line-text
topic: content-field-single-line-text
locale: en
title: "Content Field: Single-Line Text"
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-structured-content-overview
related-topics: content-field-assets,content-field-date-time,content-field-multi-line-text,content-field-multiple-choice,content-field-number,content-field-reference-object,content-field-static-text
---

# Content Field: Single-Line Text

## Form Type

  

![Form Type for Single-Line Text field](/images/scr-ContentField-SingleLineText-formtype.gif)

  

|**Field**|**Description**|
|---|---|
|**Appearance**|<ul><li><strong>Single Line</strong>. Plain text. You can restrict the length of the text under <strong>Validation</strong>.</li><li><strong>URL / Website</strong>. The user can choose the protocol (e.g., http).</li><li><strong>Email</strong></li><li><strong>Phone Number</strong>. To allow the user to include a country code, set <strong>Phone Number Type</strong> to <strong>International</strong>.</li></ul>|

## General Settings

  

![General Settings for Single-Line Text field](/images/scr-ContentField-SingleLineText-generalsettings.gif)

  

|**Field**|**Description**|
|---|---|
|**Title/Label**|Name of the field. You can change the name either in the **General Settings** panel or directly above the field on the canvas.|
|**Default Value**|The value to assign to the field if the user does not provide a custom value. If blank, the **Help Text Inside Field** value is displayed.|
|**Set Default Value as Hidden**|If checked: <ul><li>The default value is not displayed to the user.</li><li><strong>Required</strong> must be <strong>Off</strong>.</li></ul>|
|**Description**|If enabled (**On**), displays the instructions or field description you enter in the provided text box. Maximum length: 140 characters.|
|**Tooltip**|If enabled (**On**) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.|

## Validation

  

![Validation for Single-Line Text field](/images/scr-ContentField-SingleLineText-validation.gif)

  

|**Field**|**Description**|
|---|---|
|**Error Message**|The message to display if the user entered data that does not meet the requirements for the field.|
|**Required**|If enabled (**On**):<ul><li>The field name is marked as required.</li><li>The message you enter in the provided text box will be displayed if the user does not provide a value in the field.</li></ul>|
|**Number of Characters**|If enabled (**On**), the message you enter in the provided text box will be displayed if the user provides a value outside the valid range. You must indicate the valid range:<ul><li><strong>Minimum</strong>. The valid range is from the value you enter in **Min** to infinity.</li><li><strong>Maximum</strong>. The valid range is from infinity to the value you enter in **Max**.</li><li><strong>Between</strong>. The valid range is from the value you enter in **Min** to the value you enter in **Max**.</li></ul><br />**Min** must be less than **Max**.|