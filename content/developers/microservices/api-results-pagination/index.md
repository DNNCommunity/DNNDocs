---
uid: api-results-pagination
locale: en
title: "Microservices: Results Pagination"
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
related-topics: visualizer-templates,searched-fields,about-structured-content-apis,examples-structured-content-apis
---

# Microservices: Results Pagination

## Overview

In APIs that return a list of items, you can filter the results to return only the items that meet the criteria you specify. You can also define the portion (page) of the list that is sent back.

Pagination depends on two parameters:

*   `startindex`. The index in the results list at which to start the portion to return.
*   `maxitems`. The maximum number of items to return.

## Example

Suppose you want a list of content items whose name that has the word "new" in its text fields. Then your query would be:

**https://dnnapi.com/content/api/ContentItems?searchtext=new**

<table>
    <tr>
        <td>index</td>
        <td>0</td>
        <td>1</td>
        <td>2</td>
        <td>3</td>
        <td>4</td>
        <td>5</td>
        <td>6</td>
        <td>7</td>
        <td>8</td>
        <td>9</td>
    </tr>
    <tr>
        <td>item</td>
        <td>newA</td>
        <td>newB</td>
        <td>newC</td>
        <td>newD</td>
        <td>newE</td>
        <td>newF</td>
        <td>newG</td>
        <td>newH</td>
        <td>newI</td>
        <td>newJ</td>
    </tr>
    <tr>
        <td>returned</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
    </tr>
</table>



If you want each page to have a maximum of three content items, then set `maxitems` to 3.

**https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=3**

To display the third page of the results, then set `startindex` to the first index of that page. That is, `(pagenumber - 1) * maxitems`. The list has zero-based indexing; therefore, if `maxitems` is 3, then the `startindex` for the third page is 6.

**https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=3&startindex=6**

<table>
    <tr>
        <td>index</td>
        <td>0</td>
        <td>1</td>
        <td>2</td>
        <td>3</td>
        <td>4</td>
        <td>5</td>
        <td>6</td>
        <td>7</td>
        <td>8</td>
        <td>9</td>
    </tr>
    <tr>
        <td>item</td>
        <td>newA</td>
        <td>newB</td>
        <td>newC</td>
        <td>newD</td>
        <td>newE</td>
        <td>newF</td>
        <td>newG</td>
        <td>newH</td>
        <td>newI</td>
        <td>newJ</td>
    </tr>
    <tr>
        <td>returned</td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td></td>
    </tr>
</table>

 

However, the pagination does not have to be equal pages. You can choose to ignore the first two items and display the next five items.

**https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=5&startindex=2**

<table>
    <tr>
        <td>index</td>
        <td>0</td>
        <td>1</td>
        <td>2</td>
        <td>3</td>
        <td>4</td>
        <td>5</td>
        <td>6</td>
        <td>7</td>
        <td>8</td>
        <td>9</td>
    </tr>
    <tr>
        <td>item</td>
        <td>newA</td>
        <td>newB</td>
        <td>newC</td>
        <td>newD</td>
        <td>newE</td>
        <td>newF</td>
        <td>newG</td>
        <td>newH</td>
        <td>newI</td>
        <td>newJ</td>
    </tr>
    <tr>
        <td>returned</td>
        <td></td>
        <td></td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td>yes</td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>
