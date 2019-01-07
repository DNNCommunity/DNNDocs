---
topic: visualizer-templates-basics
locale: en
title: Visualizer Templates: Basics
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: visualizer-templates
related-topics: visualizer-templates-filters,visualizer-templates-datetime
links: ["[Source: Liquid for Designers](https://github.com/Shopify/liquid/wiki/liquid-for-designers)","[DotLiquid](http://dotliquidmarkup.org/)"]
---

# Visualizer Templates: Basics

In a Visualizer template, placeholders represent the fields in the content type associated with the visualizer. The field placeholder is comprised of the field name with spaces stripped out and the first letter of the first word lowercased. Then the new word is enclosed in double curly brackets {{}}. Example: If the field is named Meeting Timeslot, the field's placeholder would be `{{ meetingTimeslot }}`.

Tip: Ctrl+Space displays a dropdown list of the fields in the associated content type. Choose the field from the list to automatically enter its placeholder in the canvas.

The double curly brackets can also contain an expression, such as:

Expression

Accepts

Displays

Example

Variables

Variable names must be comprised of alphanumeric characters and underscores only and must start with a letter.

Displays the value of the variable.

`{{ my_variable }}`

Array element

A variable that is an array, followed by the integer index/key of the array element, enclosed in square brackets \[\]. The index/key can be an expression, as long as it resolves to an integer.

Displays the value at the specified index of the array.

`{{ my_fish_array[42] }}` or `{{ my_fish_array[my_index + 1] }}`

Hash value

A variable that is a hash, followed by the string key of the hash key-value pair, enclosed in square brackets\[\] or separated from the hash variable by a dot. In the dot notation, the key variable must point directly to the value; it cannot contain the name of another variable.

Displays the value of the specified key.

`{{ my_towel_hash[my_key] }}` or `{{ my_towel_hash.my_key }}`

Array/Hash size

The array/hash variable, followed by a dot and the property `size`.

Displays the size of the array or hash.

`{{ my_fish_array.size }}`

Literal strings

Strings withing double quotes or single quotes.

Displays the string.

`{{ "To be or not to be..." }}`

Integers

Non-quoted numeric characters.

Displays the number.

`{{ 1024 }}`

Boolean and nil

`true`, `false`, or `nil`

Typically used within if/else statements.

`{{ true }}` or {{ is_raining }}