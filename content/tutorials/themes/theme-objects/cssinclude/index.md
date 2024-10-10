---
uid: cssinclude  
locale: en  
title: CSSInclude Theme object  
dnnversion: 09.02.00  
previous-topic: cssexclude  
next-topic: currentdate  
related-topics: theme-objects,themes,create-theme  
links:  
---

# CSSInclude Theme Object Introduction  

Load a Custom Stylesheet for your Theme 


**Current Version:** 01.00.00  

> [!NOTE]  
> Please note that DNN automatically loads the following Style Sheets if they exist:
From the Skin / Layout folder: Skin.css & \"SkinName\".css (same name as the ascx file).
From the Container folder: Container.css & \"ContainerName\".css (same name as the ascx file).
Although the loading specific CSS files for a Layout or a Container seems like a great option, in general adding a class to the Theme of Container and referencing that from your Skin.css if more efficient and easier to manage
> [!NOTE]  
> FYI, you must provide FilePath or DNN will throw an error

## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>  
<dnn:DnnCssInclude runat="server" FilePath="style.css"  />
```

### HTML Token


### HTML Object Token
``` html

```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| FilePath | Path to the CSS file to load |  |  | 01.00.00 |
| PathNameAlias | Base Location of the CSS file to load |  | SkinPath<br/>SharedScripts | 01.00.00 |
| Priority | With this value you can set the relative order of the loaded Style Sheet. Where 100 is after Portal.css (which is prio 35) | 100 | DefaultCss: 5<br/>ModuleCss: 10<br/>SkinCss: 15<br/>SpecificSkinCss: 20<br/>ContainerCss: 25<br/>SpecificContainerCss: 30<br/>PortalCss: 35<br/>Default value: 100 | 01.00.00 |





## Examples:

### Load Blue Style Sheet
~~~html
<dnn:DnnCssInclude runat="server" FilePath="custom/css/blue.css" PathNameAlias="SkinPath" />
~~~
