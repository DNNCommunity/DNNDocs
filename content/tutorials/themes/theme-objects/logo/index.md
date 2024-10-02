---
uid: logo  
locale: en  
title: Logo Theme object  
dnnversion: 09.02.00  
previous-topic: login  
next-topic: privacy  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Logo Theme Object Introduction  

Displays the portal logo 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Logo" Src="~/Admin/Skins/Logo.ascx" %>  
<dnn:Logo runat="server" id="dnnLogo" />
```

### HTML Token
[LOGO]

### HTML Object Token
``` html
<object id="dnnLOGO" codetype="dotnetnuke/server" codebase="LOGO"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | Css Class of the image |  | Css Class String | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:Logo runat="server" id="dnnLogo" />
~~~


### Css Class
~~~html
<dnn:Logo runat="server" CssClass="my-logo" id="dnnLogo" />
~~~