---
uid: terms   
locale: en  
title: Terms  Theme object  
dnnversion: 09.02.00  
previous-topic: search  
next-topic: text  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Terms  Theme Object Introduction  

Displays a link to the Terms Information for the portal. 
 
By default, the URL used, will be "mywebite.com/terms". 
This is not a "real page" (see further below). 
 
The shown Terms Text will be loaded from this Resource file: "App_GlobalResources\GlobalResources.resx". 
The key: “MESSAGE_PORTAL_TERMS.Text” 
 
Please note you should not edit this file as it will be overwritten on upgrade, you can edit "GlobalResources.host.resx" or GlobalResources.Portalx.resx though. (see Static Localization) 
 
You can also set a custom Terms page in the Site Settings and use a "real page" for your terms message. 
In that case the text from the Resource file will not be used and you will have to add your own text to the page. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Terms" Src="~/Admin/Skins/terms.ascx" %>  
<dnn:Terms runat="server" id="dnnTerms" />
```

### HTML Token
[TERMS]

### HTML Object Token
``` html
<object id="dnnTERMS" codetype="dotnetnuke/server" codebase="TERMS"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Text | Use the PageTitle instead of PageName | Terms of Use | True / False | 01.00.00 |
| CssClass | Css Class of the Link | SkinObject | Css Class String | 01.00.00 |





## Examples:

### Default
Default implementation.

~~~html
<dnn:Terms runat="server" id="dnnTerms" />
~~~


### Css Class and Text
~~~html
<dnn:Terms runat="server" CssClass="my-terms" Text="Read our Terms!" id="dnnTerms" />
~~~

