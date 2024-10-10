---
uid: login  
locale: en  
title: Login Theme object  
dnnversion: 09.02.00  
previous-topic: language  
next-topic: logo  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Login Theme Object Introduction  

Dual state control – displays “Login” for anonymous users and “Logout” for authenticated users. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Login" Src="~/Admin/Skins/Login.ascx" %>  
<dnn:Login runat="server" id="dnnLogin" />
```

### HTML Token
[LOGIN]

### HTML Object Token
``` html
<object id="dnnLOGIN" codetype="dotnetnuke/server" codebase="LOGIN"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Text | The text of the login link | Login | String | 01.00.00 |
| CssClass |  | SkinObject | Valid CSS Class String | 01.00.00 |
| LogoffText | The text of the logoff link | Logoff |  | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:Login runat="server" id="dnnLogin" />
~~~


### Text and CSS Class
~~~html
<dnn:Login runat="server" Text="Knock knock" LogoffText="Let me out!" CssClass="my-login" id="dnnLogin" />
~~~
