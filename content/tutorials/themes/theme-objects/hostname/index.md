---
uid: hostname  
locale: en  
title: Hostname Theme object  
dnnversion: 09.02.00  
previous-topic: help  
next-topic: jsexclude  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Hostname Theme Object Introduction  

Displays the Host Title linked to the Host URL 


**Current Version:** 01.00.00  

> [!NOTE]  
> 

## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="HostName" Src="~/Admin/Skins/Hostname.ascx" %>  
<dnn:HostName runat="server" id="dnnHostName" />
```

### HTML Token
[HOSTNAME]

### HTML Object Token
``` html
<object id="dnnHOSTNAME" codetype="dotnetnuke/server" codebase="HOSTNAME"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | CSS Class of the link | SkinObject | CSS Class String | 01.00.00 |

##  Title / Tokens / Extra




## Examples:

### Default
~~~html
<dnn:HostName runat="server" id="dnnHostName" />
~~~

