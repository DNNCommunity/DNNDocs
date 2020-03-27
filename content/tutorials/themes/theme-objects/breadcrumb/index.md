---
uid: breadcrumb
locale: en
title: Breadcrumb them object
dnnversion: 09.02.00
previous-topic: theme-objects
next-topic: 
related-topics: theme-objects,themes,create-theme
links: ["[DNN Wiki: DotNetNuke Skins](https://www.dnnsoftware.com/wiki/dotnetnuke-skins)","[DNN Community blog: DotNetNuke Skinning 101 (Part 3) by Joe Brinkman](https://www.dnnsoftware.com/community-blog/cid/131995/dotnetnuke-skinning-101-part-3)","[DNN Professional Training: Creating HTML Skins](https://www.dnnsoftware.com/services/professional-training/training-videos-subscription/skinning-2-creating-html-skins)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# Breadcrumb Theme Object Introduction

The Breadcrumb Them Object displays the path to the currently selected page in the menu structure like this:
RootPage > SubPage > SubSubPage
The starting level, separator and styliong are configurable.

**Current Version:** 1.0.0

> [!NOTE]
> When you need even more control, you can also create breadcrumbs using a DDR menu template.

## Include in Theme

### ASCX
```html
<%@ Register TagPrefix="dnn" TagName="Breadcrumb" Src="~/Admin/Skins/breadcrumb.ascx" %>
<dnn:Breadcrumb runat="server" id="dnnBreadcrumb" />
```

### HTML Token
\[BREADCRUMB]

### HTML Object Token
``` html
<object id="dnnBREADCRUMB" codetype="dotnetnuke/server" codebase="BREADCRUMB">
```

<table>
<tr>
<th>Attribute</th>
<th>Description</th>
<th>Default</th>
<th>Values</th>
<th>Version</th>
</tr>
<tr>
<td>Separator</td>
<td>The separator between breadcrumb links.</td>
<td>></td>
<td>html / text / images</td>
<td>01.00.00</td>
</tr>
<tr>
<td>CssClass</td>
<td>CSS Class of the SkinObject</td>
<td>SkinObject</td>
<td>A valid CSS Class</td>
<td>01.00.00</td>
</tr>
<tr>
<td>RootLevel</td>
<td>The root level of the breadcrumb links.</td>
<td>1</td>
<td>
Valid values include:<br>
-1  -  show word “Root” and then all breadcrumb tabs<br>
0  -  show all breadcrumb tabs<br>
n (Integer > 0)  -  skip n breadcrumb tabs before displaying<br>
</td>
<td>01.00.00</td>
</tr>
<tr>
<td>UseTitle</td>
<td>Use the PageTitle instead of PageName</td>
<td>False</td>
<td>True / False</td>
<td>01.00.00</td>
</tr>
</table>


## Examples:

~~~html
<dnn:Breadcrumb runat="server" id="dnnBreadcrumb" Separator="++" CssClass="breadcrumb" RootLevel="2" UseTitle="true" />
~~~

