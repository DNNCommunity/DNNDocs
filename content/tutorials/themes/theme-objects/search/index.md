---
uid: search  
locale: en  
title: Search Theme object  
dnnversion: 09.02.00  
previous-topic: privacy  
next-topic: terms  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Search Theme Object Introduction  

Displays the search input box and a quick results dropdown 


**Current Version:** 01.00.00  

> [!NOTE]  
> As the web search option does not work any more, the ShowWeb and ShowSite options are useless?

## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="SEARCH" Src="~/Admin/Skins/Search.ascx" %>  
<dnn:Search runat="server" id="dnnSearch" />
```

### HTML Token
[SEARCH]

### HTML Object Token
``` html
<object id="dnnSEARCH" codetype="dotnetnuke/server" codebase="SEARCH"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | Sets the CSS class for the option buttons and<br/>search button. If you are using the DropDownList<br/>option then you can style the search elements<br/>without requiring a custom CssClass. |  | CSS class string | 01.00.00 |
| ShowSite | Sets the visibility of the radio button<br/>corresponding to site based search. Set to false to<br/>hide the "Site" radio button. This setting has no<br/>effect if UseDropDownList is true. |  | True / False | 01.00.00 |
| ShowWeb | Sets the visibility of the radio button<br/>corresponding to web based searchs. Set to false<br/>to hide the "Web" radio button. This setting has<br/>no effect if UseDropDownList is true. |  | True / False | 01.00.00 |
| SiteIconURL | Sets the site icon URL. If SiteIconURL is not set or<br/>empty then this will return a site relative URL for<br/>the dotnetnuke-icon.gif image in the<br/>images/search subfolder. SiteIconURL supports<br/>using app relative virtual paths designated by the<br/>use of the tilde (~).<br/> |  | String | 01.00.00 |
| SiteText | Gets or sets the text for the "site" radio button or<br/>option list item. If the value is not set or is an<br/>empty string, then the localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used.<br/> |  | String | 01.00.00 |
| SiteToolTip | Sets the tooltip text for the "site" radio button. If<br/>the value is not set or is an empty string, then the<br/>localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used.<br/> |  | String | 01.00.00 |
| SiteUrl | Gets or sets the URL for doing web based site<br/>searches. If the value is not set or is an empty<br/>string, then the localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used. The site URL is a<br/>template for an external search engine, which by<br/>default, uses Google.com. SiteURL should include<br/>the tokens [TEXT] and [DOMAIN] to be replaced<br/>automatically by the search text and the current<br/>site domain.<br/> |  | String | 01.00.00 |
| Submit | Sets the html for the submit button. If the value is<br/>not set or is an empty string, then the localized<br/>value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used. If you set the value to<br/>an hmtl img tag, then the src attribute will be<br/>made relative to the current skinpath.<br/> |  | String | 01.00.00 |
| UseWebForSite | Sets a value indicating whether to use the web<br/>search engine for site searches. Set this value to<br/>true to perform a domain limited search using the<br/>search engine defined by SiteURL.<br/> |  | True / False | 01.00.00 |
| UseDropDownList | Sets a value indicating whether to display the<br/>site/web options using a drop down list. If true,<br/>then the site and web options are displayed in a<br/>drop down list. If the drop down list is used, then<br/>the ShowWeb and ShowSite properties are not<br/>used.<br/> |  | True / False | 01.00.00 |
| WebIconURL | Sets the web icon URL. If the WebIconURL is not<br/>set or is an empty string then this will return a site<br/>relative URL for the google-icon.gif image in the<br/>images/search subfolder. WebIconURL supports<br/>using app relative virtual paths designated by the<br/>use of the tilde (~).<br/> |  | String | 01.00.00 |
| WebText | Sets the text for the "web" radio button or option<br/>list item.If the value is not set or is an empty<br/>string, then the localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used. |  | String | 01.00.00 |
| WebToolTip | Sets the tooltip text for the "web" radio button. If<br/>the value is not set or is an empty string, then the<br/>localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used. |  | String | 01.00.00 |
| WebURL | Gets or sets the URL for doing web based searches.<br/>If the value is not set or is an empty string, then<br/>the localized value from<br/>/admin/skins/app_localresources/Search.ascx.resx<br/>localresource file is used. The web URL is a<br/>template for an external search engine, which by<br/>default, uses Google.com. The WebURL should<br/>include the token [TEXT] to be replaced<br/>automatically by the search text. The [DOMAIN]<br/>token, if present, will be replaced by an empty<br/>string.<br/> |  | String | 01.00.00 |





## Examples:

### Default
~~~html
<dnn:Search runat="server" id="dnnSearch" />
~~~


### UseDropDownList = True
~~~html
<dnn:Search runat="server" UseDropDownList ="True" id="dnnSearch" />
~~~


### ShowSite = False, ShowWeb = False
As ShowWeb does not work any more, this should be the default option

~~~html
<dnn:Search runat="server" ShowSite="False" ShowWeb="False" id="dnnSearch" />
~~~


### Custom Submit text
FYI, It's better to get this text from a RESX file

~~~html
<dnn:Search runat="server" Submit="Show me some Results!" ShowSite="False" ShowWeb="False"  id="dnnSearch" />
~~~
