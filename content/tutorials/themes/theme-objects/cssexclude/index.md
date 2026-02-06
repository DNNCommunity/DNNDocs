---
uid: cssexclude  
locale: en  
title: CSSEXCLUDE Theme object  
dnnversion: 09.02.00  
previous-topic: copyright  
next-topic: cssinclude  
related-topics: theme-objects,themes,create-theme  
links:  
---

# CSSEXCLUDE Theme Object Introduction  

Allows you to exclude a Stylesheet (that DNN would normally load) from being loaded 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="DnnCssExclude" src="~/Admin/Skins/DnnCssExclude.ascx" %>  
<dnn:DnnCssExclude runat="server" name="DnnDefault" />
```

### HTML Token
[DNNCSSEXCLUDE]

### HTML Object Token
``` html
<object id="DNNCSSEXCLUDE" codetype="dotnetnuke/server" codebase="DNNCSSEXCLUDE"> 
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| Name | Name of the framework  or library to remove |  | DnnDefault<br/>Bootstrap<br/><br/> | 01.00.00 |





## Examples:

### Don't load Default.css
~~~html
<dnn:DnnCssExclude runat="server" name="DnnDefault" />
~~~

### Load a newer Default.css version
~~~html
<dnn:DnnCssInclude runat="server" 
                   FilePath="~/resources/shared/stylesheets/dnndefault/8.0.0/default.css"
                   Priority="<%#FileOrder.Css.DefaultCss%>" 
                   Name="dnndefault" 
                   Version="8.0.0" />
~~~

### Load an older Default.css version
~~~html
<dnn:DnnCssInclude runat="server" 
                   FilePath="~/resources/shared/stylesheets/dnndefault/7.0.0/default.css"
                   Priority="<%#FileOrder.Css.DefaultCss%>" 
                   Name="dnndefault" 
                   Version="7.0.0"
                   ForceVersion="true" />
~~~

