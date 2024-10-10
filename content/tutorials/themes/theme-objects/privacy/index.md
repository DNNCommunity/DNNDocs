---
uid: privacy  
locale: en  
title: Privacy Theme object  
dnnversion: 09.02.00  
previous-topic: logo  
next-topic: search  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Privacy Theme Object Introduction  

Displays a link to the Privacy Information for the portal. 
 
By default, the URL used, will be "mywebite.com/privacy". 
This is not a "real page" (see further below). 
 
The shown Privacy Text will be loaded from this Resource file: "App_GlobalResources\GlobalResources.resx". 
The key: “MESSAGE_PORTAL_PRIVACY.Text” 
 
Please note you should not edit this file as it will be overwritten on upgrade, you can edit "GlobalResources.host.resx" or GlobalResources.Portalx.resx though. (see Static Localization) 
 
You can also set a custom Privacy page in the Site Settings and use a "real page" for your privacy message. 
In that case the text from the Resource file will not be used and you will have to add your own text to the page. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="Privacy" Src="~/Admin/Skins/Privacy.ascx" %>  
<dnn:Privacy runat="server" id="dnnPrivacy" />
```

### HTML Token
[PRIVACY]

### HTML Object Token
``` html
<object id="dnnPRIVACY" codetype="dotnetnuke/server" codebase="PRIVACY"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Text | The text of the privacy link | Privacy Statement | String | 01.00.00 |
| CssClass | Css Class of the link | SkinObject | CSS Class String | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:Privacy runat="server" id="dnnPrivacy" />
~~~


### Set Text
~~~html
<dnn:Privacy runat="server" Text="We care about your Privacy" id="dnnPrivacy" />
~~~

