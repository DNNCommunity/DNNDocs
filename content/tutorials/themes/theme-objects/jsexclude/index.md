---
uid: jsexclude  
locale: en  
title: JSEXCLUDE Theme object  
dnnversion: 09.02.00  
previous-topic: hostname  
next-topic: language  
related-topics: theme-objects,themes,create-theme  
links:  
---

# JSEXCLUDE Theme Object Introduction  

Allows you to exclude a Javascript (that DNN would normally load) from being loaded 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="JsExclude" src="~/Admin/Skins/DnnJsExclude.ascx" %>  
<dnn:CssExclude runat="server" name="DnnDefault" />
```

### HTML Token
[DNNJSEXCLUDE]

### HTML Object Token
``` html
<object id="DNNJSSEXCLUDE" codetype="dotnetnuke/server" codebase="DNNJSEXCLUDE"> 
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Name | Name of the framework  or library to remove |  | DnnDefault<br/>Bootstrap<br/><br/> | 01.00.00 |





## Examples:

### Don't load DNN.js
~~~html
<dnn:JsExclude runat="server" name="DnnDefault" />
~~~

