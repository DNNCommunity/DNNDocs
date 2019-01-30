---
uid: content-managers-visualizer-templates-filters
topic: visualizer-templates-filters
locale: en
title: "Visualizer Templates: Filters"
dnneditions: Evoq Engage
dnnversion: 09.02.00
parent-topic: visualizer-templates
related-topics: visualizer-templates-basics,visualizer-templates-datetime
links: ["[Source: Liquid for Designers](https://github.com/Shopify/liquid/wiki/liquid-for-designers)","[DotLiquid](http://dotliquidmarkup.org/)"]
---

# Visualizer Templates: Filters

You can perform additional processing before displaying the value by passing the output through one or more filters separated by the pipeline (|).

## Math

Filter

Description

Example
<a name="divided_by"></a>
divided_by

Divides the piped value by the specified integer. Rounds the result. Also see [modulo](#modulo).

```

{{ 10 | divided_by: 3 }}
                        
```

3
                        
<a name="minus"></a>
minus

Subtracts the specified value from the piped value. Also see [plus](#plus).

```

{{ 4 | minus: 2 }}
                        
```

2
                        
<a name="modulo"></a>
modulo

Returns the modulo (remainder) when the piped value is divided by the specified value. Also see [divided_by](#divided_by).

```

{{ 3 | modulo: 2 }}
                        
```

1
                        
<a name="plus"></a>
plus

Adds the piped value and the specified value. If the values are numeric strings, the numbers are converted to integers, then added. Also see [minus](#minus).

```

{{ 1 | plus: 1 }}
                        
```

2
                        

times

Multiplies the piped value with the specified value.

```

{{ 5 | times: 4 }}
                        
```

20
                        

format

Converts the numeric value to its equivalent textual representation, using the specified .NET format. Please refer to [this page](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings) for a list and description of valid format strings.

```

{{ 4.1 | format: "F2" }}
                        
```

4.10
                        

## Strings

Filter

Description

Example
<a name="append"></a>
append

Appends the specified string to the end of the piped string. Also see [prepend](#prepend).

```

{{ "the quick brown fox" | append: " jumped over" }}
                        
```

the quick brown fox jumped over
                        
<a name="capitalize"></a>
capitalize

Capitalizes the first letters of words in the piped string. Also see [upcase](#upcase) and [downcase](#downcase).

```

{{ "the quick brown fox" | capitalize }}
{{ "jUmPeD OvEr tHe lAzY dOg" | capitalize }}
                        
```

The Quick Brown Fox
Jumped Over The Lazy Dog
                        
<a name="downcase"></a>
downcase

Converts the piped string to lowercase. Also see [upcase](#upcase) and [capitalize](#capitalize).

```

{{ "THE QUICK BROWN FOX" | downcase }}
{{ "The QUICK Brown foX" | downcase }}
                        
```

the quick brown fox
the quick brown fox
                        
<a name="prepend"></a>
prepend

Prepends a string. Also see [append](#append).

```

{{ "the lazy dog" | prepend: "jumped over " }}
                        
```

jumped over the lazy dog
                        
<a name="remove-first"></a>
remove_first

Removes the first occurrence of the specified string from the piped string. Also see [remove](#remove) and [replace](#replace).

```

{{ "peppers" | remove_first: "pe" }}
                        
```

ppers
                        
<a name="remove"></a>
remove

Removes every occurrence of the specified string from the piped string. Also see [remove_first](#remove-first) and [replace](#replace).

```

{{ "peppers" | remove: "pe" }}
                        
```

prs
                        
<a name="replace-first"></a>
replace_first

Replaces the first occurrence of the first specified string with the second specified string. Also see [replace](#replace) and [remove_first](#remove-first).

```

{{ "peppers" | replace_first: "pe", "to" }}
                        
```

toppers
                        
<a name="replace"></a>
replace

Replaces every occurrence of the first specified string with the second specified string. Also see [replace_first](#replace-first) and [remove](#remove).

```

{{ "peppers" | replace: "pe", "to" }}
                        
```

toptors
                        

size

Returns the size of the piped array or string.

```

{{ "hello" | size }}
                        
```

5
                        
<a name="slice"></a>
slice

Returns a substring from the piped string, from the specified offset and with the specified number of characters. A negative offset will start counting from the end of the string.

```

{{ "hello" | slice: 1, 2 }}
{{ "hello" | slice: -3, 3 }}
                        
```

el
llo
                        

split

Splits the piped string where the specified pattern is found, not including the search pattern. Also see [Arrays](#arrays).

Note: Arrays are converted to a string for display by simply concatenating the elements. The `join` can be used to format the array with a delimiter between each element.

```

{{ "a,b" | split: "," }}
{{ "a,b" | split: "," | join: "|"  }}
                        
```

ab
a|b
                        

strip_newlines

Removes all newline characters ("\\n") from the piped string.

If myMultiLineField is set to:

```

Twinkle, twinkle,
little star.
How I wonder
what you are.
                        
```

```

{{ myMultiLineText | strip_newlines }}
                        
```

Twinkle, twinkle,little star.How I wonderwhat you are.
                        

truncate

Truncates the piped string and appends the optional second parameter, so that the length of the final result is the first parameter.

```

{{ "supercalifragilistic" | truncate: 8, "man" }}
{{ "supercalifragilistic" | truncate: 5, "nny" }}
                        
```

superman
sunny
                        
<a name="upcase"></a>
upcase

Converts the piped string to uppercase.

```

{{ "hello" | upcase }}
                        
```

HELLO
                        

## HTML and URL Encodings for Strings

The following filters can be used if the field contains a string.

Filter

Description

Example

escape_once

Converts special characters in the string into HTML escape characters without affecting characters that are already HTML-escaped.

 

escape

Converts special characters in the string into HTML escape characters.

 

newline\_to\_br

Replaces each newline ("\\n") with an HTML break (<br/>).

 

strip_html

Removes all HTML-encoded characters from the piped string.

 

url_encode

Converts the piped string to URL encoding.

 

## Link Creation for URLs

The following filters can be used if the field contains a URL. The examples use the `{{ linkedIn }}` field placeholder.

Filter

Description

Example

(no filter)

Returns the URL as plain text.

```

{{ linkedIn }}
                        
```

http://www.linkedin.com/in/myexample
                        

link

Creates a link that would load the target page in the same browser tab.

```

{{ linkedIn | link }}
                        
```

<a href="http://www.linkedin.com/in/myexample">
    http://www.linkedin.com/in/myexample</a>
                        

link_new

Creates a link that would load the target page in a new browser tab.

```

{{ linkedIn | link_new }}
                        
```

<a href="http://www.linkedin.com/in/myexample" target="_blank">
    http://www.linkedin.com/in/myexample</a>
                        
<a name="arrays"></a>
## Arrays

Array indexes are zero-based; i.e., the first element's index is 0, and the last element's index is the number of elements minus 1. Example: If an array contains five elements, the index range is from 0 (for the first element) to 4 (for the last element).

Fields that are of the type Assets (images and documents) contain arrays; therefore, you can also use these filters with those fields.

These examples accept a string with comma-separated values, which is split into an array before the filter is applied. If the result is an array, the `join` filter combines the elements into a string with the tilde "~" as separator.

Note: Arrays are converted to a string for display by simply concatenating the elements. The `join` can be used to format the array with a delimiter between each element.

Filter

Description

Example
<a name="first"></a>
first

Returns the first element of the piped array. Also see [last](#last).

```

{{ "dddd,bb,ccc,a" | split: "," | first }}
                        
```

dddd
                        

index_at

Returns the URL of the element at the specified index. If the specified index is outside the valid range (0 to number of elements minus 1), nothing is returned.

```

{{ "dddd,bb,ccc,a" | split: "," | index_at: 2 }}
                        
```

ccc
                        

join

Combines the elements of the piped array with the specified character inserted between each element.

```

{{ "dddd,bb,ccc,a" | split: "," | join "~" }}
                        
```

dddd~bb~ccc~a
                        
<a name="last"></a>
last

Returns the last element of the piped array. Also see [first](#first).

```

{{ "dddd,bb,ccc,a" | split: "," | last }}
                        
```

a
                        

size

Returns the size of the piped array or string.

```

{{ "dddd,bb,ccc,a" | split: "," | size }}
                        
```

4
                        

sort

```

{{ "dddd,bb,ccc,a" | split: "," | sort | join "~" }}
                        
```

a~bb~ccc~dddd
                        

## Multiple Choice

These filters apply only to fields of the type Multiple Choice.

Filter

Description

Example

(no filter)

For single-choice fields, returns the value of the selection. For multiple-selection fields, returns the list of the selections as a comma-separated list.

```

{{ mySingleSelection }}
{{ myMultipleSelection }}
                        
```

Choice 1
Choice 1, Choice 2
                        

list

Returns an unordered list of the user's selections.

```

{{ myMultipleSelection | list }}
                        
```

<ul>
    <li>Choice 1</li>
    <li>Choice 2</li>
</ul>
                        

numberedlist

Returns an ordered list of the user's selections, in the order of the selection.

```

{{ myMultipleSelection | numberedlist }}
                        
```

<ol>
    <li>Choice 1</li>
    <li>Choice 2</li>
</ol>
                        

## Assets (Images and Documents)

These filters apply only to fields of the type Assets.

Filter

Description

Example

(no filter)

Returns all images/documents. Images are wrapped in `<img/>` tags. Documents are wrapped in `<a/>` tags.

```

{{ myImages }}
{{ myDocuments }}
                        
```

<img src="https://example.com/img-folder/my-image-1.png" alt="my image 1" />
<img src="https://example.com/img-folder/my-image-2.png" alt="my image 2" />
<a target="__blank" href="https://example.com/doc-folder/my-document-1.pdf">Title of My Document 1</a>
<a target="__blank" href="https://example.com/doc-folder/my-document-2.pdf">Title of My Document 2</a>
                        

(Formatted for legibility.)

images_url

Returns all the URLs of the images as plain text.

```

{{ myImages | images_url }}
                        
```

https://example.com/img-folder/my-image-1.png
https://example.com/img-folder/my-image-2.png
                        

(Formatted for legibility.)

images_list

Returns an unordered list containing the images wrapped in `<img />` tags.

```

{{ myImages | images_list }}
                        
```

<ul>
    <li><img src="https://example.com/img-folder/my-image-1.png" alt="my image 1" /></li>
    <li><img src="https://example.com/img-folder/my-image-2.png" alt="my image 2" /></li>
</ul>
                        

documents_url

Returns all the URLs of the documents as plain text.

```

{{ myDocuments | documents_url }}
                        
```

https://example.com/doc-folder/my-document-1.pdf
https://example.com/doc-folder/my-document-2.pdf
                        

(Formatted for legibility.)

documents_list

Returns an unordered list containing the document URLs wrapped in `<href />` tags.

```

{{ myDocuments | documents_list }}
                        
```

<ul>
    <li><a target="__blank" href="https://example.com/doc-folder/my-document-1.pdf">Title of My Document 1</a></li>
    <li><a target="__blank" href="https://example.com/doc-folder/my-document-2.pdf">Title of My Document 2</a></li>
</ul>
                        

## Misc

Filter

Description

Example

date

Reformats a date. (See [Datetime](xref:content-managers-visualizer-templates-datetime) .)

```

{{ meetingTimeslot | date: "HH:mm" }}
                        
```

18:00