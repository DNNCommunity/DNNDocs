﻿---
uid: form-field-number
locale: en
title: "Form Field: Number"
dnneditions: Evoq Engage
dnnversion: 09.02.00
related-topics: form-field-address,form-field-date-time,form-field-dropdown,form-field-email,form-field-esignature,form-field-multi-line-text,form-field-multiple-choice,form-field-name,form-field-phone-number,form-field-single-line-text,form-field-static-text,form-field-terms-conditions,form-field-url-website,form-field-submit
---

# Form Field: Number

## General Settings

  

![Settings for Number field](/images/scr-FormField-Number-generalsettings-labelreq.gif)

  

|**Field**|**Description**|
|---|---|
|**Title/Label**|Name of the field. You can change the name either in the General Settings panel or directly above the field on the canvas.|
|**Required**|If enabled (**On**):<ul><li>The field name is marked as required.</li><li>The message you enter in the provided text box will be displayed if the user does not provide a value in the field.</li></ul>|
|**Number Set**|The number type: **Integer, Decimal,** or **Percentage**.

  

![Settings for Number field](/images/scr-FormField-Number-generalsettings-appearance.gif)

  

|**Field**|**Description**|
|---|---|
|**Appearance**|<ul><li>**Single Line**. The user must type in the number.</li><li>**Spinner**. The user can either type in the number or use the buttons to increment or decrement the number.</li><li>**Dropdown**. The user selects the number from the list.</li></ul>|
|**Spinner Range <br />Dropdown Range**|The numeric range that the field will allow. The numbers are incremented/decremented by 1 (if integers) or 0.1 (if decimals or percentages).|
|**Spinner Orientation**|<ul><li>**Horizontal**. Displays the - and + on the sides of the main type-in box.</li><li>**Vertical**. Stacks the - and + on the right side of the type-in box.</li></ul>|
|**Dropdown Order**|<ul><li>Ascending</li><li>Descending</li><li>Randomized</li></ul>|

## Help Text

  

![Settings for Number field](/images/scr-FormField-Number-helptext.gif)

  

|**Field**|**Description**|
|---|---|
|**Below Field**|Help text to be displayed below the field. Maximum length: 140 characters.|
|**Tooltip**|If enabled (**On**) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.|

## Default Value

  

![Settings for Number field](/images/scr-FormField-Number-defaultvalue.gif)


> [!NOTE]
> If using the spinner or dropdown appearance, specify the **Min** and **Max** of the range to populate this **Default Value** dropdown list, then select the default value.
  

|**Field**|**Description**|
|---|---|
|**Default Value**|The value to assign to the field if the user does not provide a custom value.|
|**Set Default Value as Hidden**|If checked: <ul><li>The default value is not displayed to the user.</li><li>**Required** must be **Off**.</li></ul>|

## Validation

  

![Settings for Number field](/images/scr-FormField-Number-validation.gif)

  

|**Field**|**Description**|
|---|---|
|**Error Message**|The message to display if the user entered data that does not meet the requirements for the field.|
|**Number of Characters**|If enabled (**On**), the message you enter in the provided text box will be displayed if the user provides a value outside the valid range. You must indicate the valid range:<ul><li>**Minimum**. The valid range is from the value you enter in **Min** to infinity.</li><li>**Maximum**. The valid range is from infinity to the value you enter in **Max**.</li><li>**Between**. The valid range is from the value you enter in **Min** to the value you enter in **Max**.</li></ul><br />**Min** must be less than **Max**.|
