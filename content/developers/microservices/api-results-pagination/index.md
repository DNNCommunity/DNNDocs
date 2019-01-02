---
topic: api-results-pagination
locale: en
title: Microservices: Results Pagination
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: developers-structured-content-overview
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

https://dnnapi.com/content/api/ContentItems?searchtext=new

index

0

1

2

3

4

5

6

7

8

9

item

newA

newB

newC

newD

newE

newF

newG

newH

newI

newJ

returned

yes

yes

yes

yes

yes

yes

yes

yes

yes

yes

If you want each page to have a maximum of three content items, then set `maxitems` to 3.

https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=3

To display the third page of the results, then set `startindex` to the first index of that page. That is, `(pagenumber - 1) * maxitems`. The list has zero-based indexing; therefore, if `maxitems` is 3, then the `startindex` for the third page is 6.

https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=3&startindex=6

index

0

1

2

3

4

5

6

7

8

9

item

newA

newB

newC

newD

newE

newF

newG

newH

newI

newJ

returned

 

 

 

 

 

 

yes

yes

yes

 

However, the pagination does not have to be equal pages. You can choose to ignore the first two items and display the next five items.

https://dnnapi.com/content/api/ContentItems?searchtext=new&maxitems=5&startindex=2

index

0

1

2

3

4

5

6

7

8

9

item

newA

newB

newC

newD

newE

newF

newG

newH

newI

newJ

returned

 

 

yes

yes

yes

yes

yes