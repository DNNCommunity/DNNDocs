---
uid: contentpane  
locale: en  
title: Contentpane Theme object  
dnnversion: 09.02.00  
previous-topic: breadcrumb  
next-topic: copyright  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Contentpane Theme Object Introduction  

Injects a placeholder where u user with Page Edit Rights can insert DNN Modules(s). 


**Current Version:** 01.00.00  

> [!NOTE]  
> You can give your panes any name (ID) you want, as long as it's a valid .NET ID
> [!NOTE]  
> You have to include at least one Pane with the ID "ContentPane".

## Include in Theme

### ASCX
``` html
  
<div id=”ContentPane” runat=”server” />
```

### HTML Token
[CONTENTPANE]

### HTML Object Token
``` html
<object id="PaneName" codetype="dotnetnuke/server" codebase="CONTENTPANE">
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| ID | The content pane key identifier to be displayed in the user interface and stored in the database.<br/>Remark; "dnn_" will be added in front of the id you set. You should not use this ID to style your pane (the id is not the same in an HTML/ASCX skin and this might change in the future), use the CSS class to style content panes.<br/> |  | Valid ID Name | 01.00.00 |