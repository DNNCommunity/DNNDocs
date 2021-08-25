---
uid: copyright  
locale: en  
title: Copyright Theme object  
dnnversion: 09.02.00  
previous-topic: breadcrumb  
next-topic: cssinclude  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Copyright Theme Object Introduction  

Displays the copyright notice for the portal, which can be edited in the Website Settings.
You can use the [year] token to dynamically inject the current year
  
**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="COPYRIGHT" Src="~/Admin/Skins/CopyRight.ascx" %>  
 <dnn:Copyright runat="server" id="dnnCopyright" /> 
```

### HTML Token
[COPYRIGHT]

### HTML Object Token
``` html
<object id="dnnCOPYRIGHT" codetype="dotnetnuke/server"  codebase="COPYRIGHT"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | The CSS Class of the copyright link  |  |  | 01.00.00 |

## Examples:

### Default
~~~html
<dnn:Copyright runat="server" CssClass="CopyRight" id="dnnCopyright" /> 
~~~