---
uid: help  
locale: en  
title: Help Theme object  
dnnversion: 09.02.00  
previous-topic: dotnetnuke  
next-topic: hostname  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Help Theme Object Introduction  

Displays a Help Email link for Users that are logged in. 
Either to the Installation Host or The Portal Administrator Email. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Help" Src="~/Admin/Skins/Help.ascx" %>  
<dnn:Help runat="server" id="dnnHelp" />
```

### HTML Token
[HELP]

### HTML Object Token
``` html
<object id="dnnHELP" codetype="dotnetnuke/server" codebase="HELP"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | The CSS class of the Help link | SkinObject | CSS Class String | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:Help runat="server" id="dnnHelp" />
~~~
