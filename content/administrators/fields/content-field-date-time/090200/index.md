---
topic: content-field-date-time
locale: en
title: Content Field: Date / Time
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-structured-content-overview
related-topics: content-field-assets,content-field-multi-line-text,content-field-multiple-choice,content-field-number,content-field-reference-object,content-field-single-line-text,content-field-static-text
---

# Content Field: Date / Time

## Form Type

  

![Form Type for Date / Time field](img/scr-ContentField-DateTime-formtype.gif)

  

Field

Description

Appearance

*   Date. The user can choose only the date.
*   Date / Time. The user can choose both the date and the time.
*   Time. The user can choose only the time.

Date Format

How the date is displayed.

Time Format

How the time is displayed.

Include Timezone

If enabled (On), the time is stored with the specified timezone.

## General Settings

  

![General Settings for Date / Time field](img/scr-ContentField-DateTime-generalsettings.gif)

  

Field

Description

Title/Label

Name of the field. You can change the name either in the General Settings panel or directly above the field on the canvas.

Default Value

The value to assign to the field if the user does not provide a custom value. If blank, the Help Text Inside Field value is displayed.

Set Default Value as Hidden

If checked,

*   The default value is not displayed to the user.
*   Required must be Off.

Description

If enabled (On), displays the instructions or field description you enter in the provided text box. Maximum length: 140 characters.

Tooltip

If enabled (On) and the user hovers/clicks/taps over the information icon (i) next to the field name, displays the help text you enter in the provided text box. Maximum length: 140 characters.

## Validation

  

![Validation for Date / Time field](img/scr-ContentField-DateTime-validation.gif)

  

Field

Description

Error Message

The message to display if the user entered data that does not meet the requirements for the field.

Required

If enabled (On),

*   The field name is marked as required.
*   The message you enter in the provided text box will be displayed if the user does not provide a value in the field.

Time Range

Date Range

If enabled (On), the message you enter in the provided text box will be displayed if the user selects a date/time outside the valid range. You must indicate the valid range:

*   Before. The valid range is from infinity to the date/time you select.
*   After. The valid range is from the date/time you select to infinity.
*   Between. The valid range is from the date/time you select in the first field to the date/time you select in the second field. The first date/time value must be earlier than the second date/time value.