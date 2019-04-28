---
uid: content-field-number
locale: en
title: "Content Field: Number"
dnneditions: Evoq Engage
dnnversion: 09.02.00
related-topics: content-field-assets,content-field-date-time,content-field-multi-line-text,content-field-multiple-choice,content-field-reference-object,content-field-single-line-text,content-field-static-text
---

# Content Field: Number

## Form Type

  

![Form Type for Number field](/images/scr-ContentField-Number-formtype.gif)

  

|**Field**|**Description**|
|---|---|
|**Appearance**|<ul><li><strong>Single Line</strong>. The user must type in the number.</li><li><strong>Spinner</strong>. The user can either type in the number or use the buttons to increment or decrement the number.</li><li><strong>Dropdown</strong>. The user selects the number from the list.</li></ul>|
|**Number Set**|The number type: **Integer, Decimal,** or **Percentage**.|
|**Spinner Range<br />Dropdown Range**|The numeric range that the field will allow. The numbers are incremented/decremented by 1 (if integers) or 0.1 (if decimals or percentages).|
|**Spinner Orientation**|<ul><li><strong>Horizontal</strong>. Displays the - and + on the sides of the main type-in box.</li><li><strong>Vertical</strong>. Stacks the - and + on the right side of the type-in box.|

## General Settings

  

![General Settings for Number field](/images/scr-ContentField-Number-generalsettings.gif)

  

|**Field**|**Description**|
|---|---|
|**Title/Label**|Name of the field. You can change the name either in the **General Settings** panel or directly above the field on the canvas.|
|**Default Value**|The value to assign to the field if the user does not provide a custom value. If blank, the Help Text Inside Field value is displayed.|
|**Description**|If enabled (**On**), displays the instructions or field description you enter in the provided text box. Maximum length: 140 characters.|
|**Tooltip**|If enabled (**On**) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.|

## Validation

  

![Validation for Number field](/images/scr-ContentField-Number-validation.gif)

  

|**Field**|**Description**|
|---|---|
|**Error Message**|The message to display if the user entered data that does not meet the requirements for the field.|
|**Required**|If enabled (**On**): <ul><li>The field name is marked as required.</li><li>The message you enter in the provided text box will be displayed if the user does not provide a value in the field.</li></ul>|
|**Number of Characters**|If enabled (**On**), the message you enter in the provided text box will be displayed if the user provides a value outside the valid range. You must indicate the valid range:<ul><li><strong>Minimum</strong>. The valid range is from the value you enter in <strong>Min</strong> to infinity.</li><li><strong>Maximum</strong>. The valid range is from infinity to the value you enter in <strong>Max</strong>.</li><li><strong>Between</strong>. The valid range is from the value you enter in <strong>Min</strong> to the value you enter in <strong>Max</strong>.</li></ul><br />**Min** must be less than **Max**.|
|**Dropdown Order**|<ul><li>Ascending</li><li>Descending</li><li>Randomized</li></ul>|
