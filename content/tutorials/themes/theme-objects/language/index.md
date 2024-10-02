---
uid: language  
locale: en  
title: Language Theme object  
dnnversion: 09.02.00  
previous-topic: jsexclude  
next-topic: login  
related-topics: theme-objects,themes,create-theme  
links:  
---

# Language Theme Object Introduction  

The skin object will show you the language in which the current page is available. 
It supports 2 display modes: dropdown menu and template based repeater (you can even use both at the same time). Apart from that, there is a common header and a common footer available (both templatable). 
 
All templates of the skinobject use the DNN core TokenReplace functionality as template engine. This means that you can control visible appearance of the language skin object to a great extent. 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="LANGUAGE" Src="~/Admin/Skins/Language.ascx" %>  
<dnn:Language runat="server" id="dnnLanguage" ShowMenu="False" ShowLinks="True" />
```

### HTML Token
[LANGUAGE]

### HTML Object Token
``` html
<object id="dnnLANGUAGE" codetype="dotnetnuke/server" codebase="LANGUAGE" />
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| CssClass | Used to style the<br/>language dropdown list | SkinObject | String | 01.00.00 |
| ShowMenu | Display the dropdown menu  | True | Boolean | 01.00.00 |
| ShowLinks | Display the language links<br/>repeater | False | Boolean | 01.00.00 |
| CommonHeaderTemplate | Template used as common header |  | HTML String | 01.00.00 |
| HeaderTemplate | Template for header |  | HTML String | 01.00.00 |
| ItemTemplate | Template for item  |  | HTML String | 01.00.00 |
| AlternateTemplate  | Template for alternate item |  | HTML String | 01.00.00 |
| SelectedItemTemplate | Template for Selected item |  | HTML String | 01.00.00 |
| SeparatorTemplate  | Template for separator item |  | HTML String | 01.00.00 |
| FooterTemplate | Template for footer item |  | HTML String | 01.00.00 |
| CommonFooterTemplate | Template for common footer item |  | HTML String | 01.00.00 |

##  Tokens


| Name | Value | Description | 
| --- | --- | --- | 
| "Core Token Replace" |  |  |
| [CULTURE:DISPLAYNAME] |  |  |
| [CULTURE:ENGLISHNAME] |  |  |
| [CULTURE:LCID] |  |  |
| [CULTURE:NAME]  |  |  |
| [CULTURE:NATIVENAME] |  |  |
| [CULTURE:TWOLETTERISOCODE]  |  |  |
| [CULTURE:THREELETTERISOCODE]  |  |  |
| [URL] |  |  |
| [SELECTED] |  |  |
| [LABEL]  |  |  |
| [I]  |  |  |
| [P] |  |  |
| [S]  |  |  |
| [G] |  |  |


## Examples:

### Default
Default configuration

~~~html
<dnn:LANGUAGE runat="server" ID="lang01" ShowMenu="False" ShowLinks="True" />
~~~


### Only Dropdown
~~~html
<dnn:LANGUAGE runat="server" ID="lang02" ShowMenu="True" ShowLinks="False" />
~~~


### Dropdown + Flag
Displays dropdownlist and flag of currently selected language

~~~html
<dnn:LANGUAGE runat="server" ID="lang03" ShowLinks="False"
ShowMenu="True" CommonFooterTemplate=' <img src="[I][FLAGSRC]"
alt="[CULTURE:NATIVENAME]" border="0" />' />
~~~


### Displays text links for languages.


Selected language has different a Classname

~~~html
<dnn:LANGUAGE runat="server" ID="lang04" 
		ShowLinks="True"
		ShowMenu="False" 
		ItemTemplate='<a href="[URL]" class="Language" title="[CULTURE:NATIVENAME]" ><span class="Language[SELECTED]">[CULTURE:NAME]</span></a>'
		AlternateTemplate='<a href="[URL]" class="Language" title="[CULTURE:NATIVENAME]" ><span class="Language[SELECTED]">[CULTURE:NAME]</span></a>'
		selectedItemTemplate='<a href="[URL]" class="Language" title="[CULTURE:NATIVENAME]" ><span class="Language[SELECTED]">[CULTURE:NAME]</span></a>'
/>

~~~


### Displays Flags in Unordered list.
Example of a fully custom dropdown.

Please note that this uses some extra CSS and Javascript.

~~~html
<dnn:LANGUAGE runat="server" ID="lang05" 
		
ShowLinks="True"
ShowMenu="False" 
HeaderTemplate='<ul class="language-ul-flags">'
ItemTemplate='<li class="lang-item lang-item-sel-[SELECTED]"><a href="[URL]" class="lang-link" title="[CULTURE:NATIVENAME]" ><img src="[I][FLAGSRC] " title="[CULTURE:NATIVENAME]" /></a></li>'
AlternateTemplate='<li class="lang-item lang-item-sel-[SELECTED]"><a href="[URL]" class="lang-link" title="[CULTURE:NATIVENAME]" ><img src="[I][FLAGSRC] " title="[CULTURE:NATIVENAME]" /></a></li>'
SelectedItemTemplate='<li class="lang-item lang-item-sel-[SELECTED]"><a href="[URL]" class="lang-link" title="[CULTURE:NATIVENAME]" ><img src="[I][FLAGSRC] " title="[CULTURE:NATIVENAME]" /></a><span class="lang-menu-toggle" id="lang-menu-toggle"></span></li>'
		FooterTemplate='</ul>'
		/>
<script>
	const langToggle = document.getElementById("lang-menu-toggle");
	langToggle.addEventListener("click", (event) => {
		langToggle.parentElement.parentElement.classList.toggle('lang-list-opened');
	});

</script>

~~~