---
uid: breadcrumb  
locale: en  
title: Breadcrumb Theme object  
dnnversion: 09.02.00  
previous-topic: theme-objects  
next-topic: contentpane  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Breadcrumb Theme Object Introduction  

The Breadcrumb Theme Object displays the path to the currently selected page in the menu structure like this: 
RootPage > SubPage > SubSubPage 
The starting level, separator and styling are configurable. 


**Current Version:** 01.00.00  

> [!NOTE]  
> When you need even more control, you can also create breadcrumbs using a DDR menu template.

## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Breadcrumb" Src="~/Admin/Skins/breadcrumb.ascx" %>  
<dnn:Breadcrumb runat="server" id="dnnBreadcrumb" />
```

### HTML Token
[BREADCRUMB]

### HTML Object Token
``` html
<object id="dnnBREADCRUMB" codetype="dotnetnuke/server" codebase="BREADCRUMB">
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Separator | The separator between breadcrumb links. | Arrow Image | String | 01.00.00 |
| CssClass | CSS Class of the SkinObject | SkinObject | Valid CSS Class Name | 01.00.00 |
| RootLevel | The root level of the breadcrumb links. | 1 | Valid values include:<br/>-1 : show word “Root” and then all breadcrumb tabs<br/>0 : show all breadcrumb tabs<br/>(Integer > 0) : skip n breadcrumb tabs before displaying | 01.00.00 |
| UseTitle | Use the PageTitle instead of PageName | False | True / False | 01.00.00 |





## Examples:

### Default
Default implementation.

~~~html
<dnn:Breadcrumb runat="server" id="dnnBreadcrumb"  />
~~~


### Separator
Change the Separator used for Breadcrumbs

~~~html
<dnn:Breadcrumb id="dnnBreadcrumb" Separator=" > " runat="server"   />
~~~


### Options
Change Separator, Css Class, Root Level and use Page Title instead of Page Name

~~~html
<dnn:Breadcrumb id="dnnBreadcrumb" Separator=">" CssClass="breadcrumb" RootLevel="1" UseTitle="true"  runat="server"   />
~~~
