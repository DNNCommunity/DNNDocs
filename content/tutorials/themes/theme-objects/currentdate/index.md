---
uid: current date  
locale: en  
title: Current Date Theme object  
dnnversion: 09.02.00  
previous-topic: cssexclude  
next-topic: ddrmenu  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Current Date Theme Object Introduction  

			Displays the current date
  
**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
	<%@ Register TagPrefix="dnn" TagName="CURRENTDATE" Src="~/Admin/Skins/CurrentDate.ascx" %>  
	<dnn:CurrentDate runat="server" id="dnnCurrentDate" />
```

### HTML Token
	[CURRENTDATE]

### HTML Object Token
``` html
	<object id="dnnCURRENTDATE" codetype="dotnetnuke/server" codebase="CURRENTDATE"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | CSS Class of the rendered  | SkinObject | A Valid CSS Class | 01.00.00 |
| DateFormat | Format string for the Date text.<br/>If this is left empty the Dat  | Date Format of the current language. | A valid (.NET Date Format)[https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings] | 01.00.00 |
			