---
uid: form-field-date-time
locale: en
title: "Form Field: Date / Time"
dnneditions: Evoq Engage
dnnversion: 09.02.00
related-topics: form-field-address,form-field-dropdown,form-field-email,form-field-esignature,form-field-multi-line-text,form-field-multiple-choice,form-field-name,form-field-number,form-field-phone-number,form-field-single-line-text,form-field-static-text,form-field-terms-conditions,form-field-url-website,form-field-submit
---

# Form Field: Date / Time

## General Settings

  

![General Settings for Date / Time field](/images/scr-FormField-DateTime-generalsettings.gif)

  

|**Field**|**Description**|
|---|---|
|**Title/Label**|Name of the field. You can change the name either in the **General Settings** panel or directly above the field on the canvas.|
|**Required**|If enabled (**On**)<ul><li>The field name is marked as required.</li><li>The message you enter in the provided text box will be displayed if the user does not provide a value in the field.</li></ul>|
|**Appearance**|<ul><li><strong>Date</strong>. The user can choose only the date.</li><li><strong>Date / Time</strong>. The user can choose both the date and the time.</li><li><strong>Time</strong>. The user can choose only the time.</li></ul>|
|**Date Format**|How the date is displayed.|
|**Time Format**|How the time is displayed.|
|**Include Timezone**|If enabled (**On**), the time is stored with the specified timezone.|

## Help Text

  

![Help settings for Date and Time field](/images/scr-FormField-DateTime-helptext.gif)

  

|**Field**|**Description**|
|---|---|
|**Below Field**|Help text to be displayed below the field. Maximum length: 140 characters.|
|**Tooltip**|If enabled (**On**) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.|

## Validation

  

![Date validation settings for Date and Time field](/images/scr-FormField-DateTime-validationdate.gif)

  
  

![Time validation settings for Date and Time field](/images/scr-FormField-DateTime-validationtime.gif)

  

|**Field**|**Description**|
|---|---|
|**Error Message**|The message to display if the user entered data that does not meet the requirements for the field.|
|**Time Range <br />Date Range**|If enabled (**On**), the message you enter in the provided text box will be displayed if the user selects a date/time outside the valid range. You must indicate the valid range:<ul><li><strong>Before</strong>. The valid range is from infinity to the date/time you select.</li><li><strong>After</strong>. The valid range is from the date/time you select to infinity.</li><li><strong>Between</strong>. The valid range is from the date/time you select in the first field to the date/time you select in the second field. The first date/time value must be earlier than the second date/time value.</li></ul>|
