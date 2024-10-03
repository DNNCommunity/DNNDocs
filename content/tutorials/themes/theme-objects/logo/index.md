---
uid: logo  
locale: en  
title: Logo Theme object  
dnnversion: 09.02.00  
previous-topic: login sko  
next-topic: privacy  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Logo Theme Object Introduction  

Displays the Site logo. 
The Logo can be set in the Site Settings. 


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
| CssClass | Css Class of the Image |  | Css Class String | 01.00.00 |
| LinkCssClass  | Css Class of the Link |  | Css Class String | 01.00.00 |
| InjectSvg | Set whether to inject the SVG content inline instead of wrapping it in an IMG tag. | False | True/False | 09.00.00 |





## Examples:

### Default
~~~html
<dnn:Logo runat="server" id="dnnLogo" />
~~~


### Css Class
~~~html
<dnn:Logo runat="server" CssClass="my-logo" id="dnnLogo" />
~~~
