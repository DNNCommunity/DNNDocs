---
uid: user  
locale: en  
title: User Theme object  
dnnversion: 09.02.00  
previous-topic: text  
next-topic:   
related-topics: theme-objects,themes,create-theme  
links:  
---

# User Theme Object Introduction  

Dual state control – displays a “Register” link for anonymous users or the users name for authenticated users. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="User" Src="~/Admin/Skins/user.ascx" %>  
<dnn:User runat="server" id="dnnUser" />
```

### HTML Token
[USER]

### HTML Object Token
``` html
<object id="dnnUSER" codetype="dotnetnuke/server" codebase="USER"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Text | The text of the register/user link | Register |  | 01.00.00 |
| CssClass | Css Class of the link | CssClass |  | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:User runat="server" id="dnnUser" />
~~~