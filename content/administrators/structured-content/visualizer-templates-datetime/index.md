---
topic: visualizer-templates-datetime
locale: en
title: Visualizer Templates: Date / Time
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: visualizer-templates
related-topics: visualizer-templates-basics,visualizer-templates-filters
links: ["[MSDN Custom Date and Time Format Strings](https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx)"]
---

# Visualizer Templates: Date / Time

You can choose which components of a Date / Time field are displayed using the `date` filter in the placeholder. Without the filter, the placeholder would return the full date and the full time.

Important: When creating a content item, the value of a Date / Time field must be entered as Universal Time Coordinated (UTC) time or Greenwich Mean Time (GMT), not the local time. However, the date and time will be converted to the local time when the content item is displayed.

Example: Suppose the value of the "My Datetime" field (placeholder: {{ myDatetime }}) is 2016 September 3, Saturday, 1:04 AM UTC. Suppose the local timezone is UTC+7; i.e., 08:04 AM Pacific Daylight Time.

*   The placeholder with the `date` filter would be `{{ myDatetime | date: [format] }}`, where `[format]` is a string specifying which components of the date/time to use.
*   You can combine the format components; therefore, `{{ myDatetime | date: "MMM dd, yyyy" }}` returns Sep 03, 2016.
*   Without filters, the field would be displayed as 9/3/2016 8:04:00 AM, depending on the local settings.

Format component

Description

Example

Result

`dd`

Day of the month, zero-padded (01 — 31)

`{{ myDatetime | date: "dd" }}`

`03`

`ddd`

Abbreviated name of the day of the week

`{{ myDatetime | date: "ddd" }}`

`Sat`

`dddd`

Full name of the day of the week

`{{ myDatetime | date: "dddd" }}`

`Saturday`

`gg`

Era; e.g., B.C. or A.D.

`{{ myDatetime | date: "gg" }}`

`A.D.`

`hh`

Hour of the day, 12-hour clock, zero-padded (01 — 12)

`{{ myDatetime | date: "hh" }}`

`08 (depending on local time)`

`HH`

Hour of the day, 24-hour clock, zero-padded (00 — 23)

`{{ myDatetime | date: "HH" }}`

`08 (depending on local time)`

`mm`

Minute of the hour, zero-padded (00 — 59)

`{{ myDatetime | date: "mm" }}`

`04`

`MM`

Month of the year, zero-padded (01 — 12)

`{{ myDatetime | date: "MM" }}`

`09`

`MMM`

Abbreviated name of the month

`{{ myDatetime | date: "MMM" }}`

`Sep`

`MMMM`

Full name of the month

`{{ myDatetime | date: "MMMM" }}`

`September`

`ss`

Seconds of the minute, zero-padded (00 — 59)

`{{ myDatetime | date: "ss" }}`

`00`

`tt`

AM/PM designator

`{{ myDatetime | date: "tt" }}`

`AM`

`y`

Year without the century (0 — 99)

`{{ myDatetime | date: "y" }}`

`16`

`yy`

Year without the century, zero-padded (00 — 99)

`{{ myDatetime | date: "yy" }}`

`16`

`yyyy`

Full year

`{{ myDatetime | date: "yyyy" }}`

`2016`

`string`

A literal string.

Note: You must use the escape character "\\" if your string contains characters that are reserved for formatting.

`{{ myDatetime | date: "hello, \hello" }}`

`8ello, hello`

`%`

Indicates that the following character(s) are formatting code.

`{{ myDatetime | date: "%Mdy" }}`

`9316`

`\`

Escape character. Indicates that the following character is literal; i.e., not a formatting code.

`{{ myDatetime | date: "comment, co\m\men\t" }}`

`co04enA, comment`