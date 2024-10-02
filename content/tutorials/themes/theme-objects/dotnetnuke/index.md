---
uid: dotnetnuke  
locale: en  
title: Dotnetnuke Theme object  
dnnversion: 09.02.00  
previous-topic: ddrmenu  
next-topic: help  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Dotnetnuke Theme Object Introduction  

Displays the Copyright notice for DotNetNuke (not required) 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="DotNetNuke " Src="~/Admin/Skins/dotnetnuke.ascx" %>  
<dnn:DotNetNuke runat="server" id="dnnDotnetNuke" />
```

### HTML Token
[DOTNETNUKE]

### HTML Object Token
``` html
<object id="dnnDOTNETNUKE" codetype="dotnetnuke/server" codebase="DOTNETNUKE"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | The CSS class of the DotNetNuke Skin Object | SkinObject | "String" | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:DotNetNuke runat="server" id="dnnDotnetNuke" />
~~~
