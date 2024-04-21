---
uid: text  
locale: en  
title: TEXT Theme object  
dnnversion: 09.02.00  
previous-topic: ddrmenu  
next-topic: theme-objects
related-topics: theme-objects,themes,create-theme  
links:  
---

# TEXT Theme Object Introduction  

Displays Localized text in your theme / skin, also supports the use of DNN Core Token replacement. 
 
The text will be loaded from a resource file (*.resx), you need a separate resx file per language. 
 
These should be located in a folder named "App_LocalResources" (in the Theme folder). 
 
  
 
## Naming convention: 
 
When your skin file = index.ascx: 
Default language: index.ascx.resx 
French: index.ascx.fr-FR.resx 
German: index.ascx.de-DE.resx 
 
  
 
## Resource file content: 
 
~~~ 
<?xml version="1.0" encoding="utf-8"?> 
<root> 
<data name="Welcome.Text"> 
    <value>Welcome</value> 
  </data> 
</root> 
~~~ 


**Current Version:** 01.00.00  


## Include in Theme

### ASCX
``` html
<%@ Register TagPrefix="dnn" TagName="TEXT" Src="~/Admin/Skins/Text.ascx" %>  
  <dnn:TEXT runat="server" id="dnnTEXT-Welcome" ShowText="Welcome, "  ResourceKey="Welcome.Text" ReplaceTokens="False" />
```

### HTML Token
[TEXT]

### HTML Object Token
``` html
<object id="dnnTEXT" codetype="dotnetnuke/server" codebase="TEXT"></object>
```

| Attribute | Description | Default | Posssible Values | DNN Version |
| --- | --- | --- | --- | --- |
| ShowText  | The text to display if there is no text<br/>available from a resource file. |  |  | 01.00.00 |
| CssClass  | This value is the name of a CSS class that will be added to the rendered HTML.<br/>(the text will be rendered inside a span) | Normal |  | 01.00.00 |
| ResourceKey  | The name of XML element's content in the resource file (*.resx) to be used.  |  | Hello.Text | 01.00.00 |
| ReplaceTokens  | This true/false value will tell DNN to look for system tokens and replace them with the appropriate text | False | True<br/>False | 01.00.00 |

##  Tokens
> [!NOTE] 
> 

Below is only a small selection of the tokens that can be useful, but you can use all of the supported Core Tokens
 



| Name | Value | Description |
| --- | --- | --- | 
| User Display name | [User:displayname] | The display name of the current user |
| User First Name | [User:firstname] | The first name of the current user |
| User Lastname | [User:lastname] | The last name of the current user |
| Portal Name | [Portal:portalname] | The name of the current Portal |
	



## Examples:

### Text Theme Object Fallback text
Show Fallback text as the Resourcekey is not found

~~~html
<dnn:TEXT runat="server" id="dnnTEXT-fallback" ShowText="Fallback"  CssClass="dnn-text" ResourceKey="Main.Text" ReplaceTokens="False" />


~~~


### Text Theme Object EN, FR, NL text
Example for English, French and Dutch

~~~html
<dnn:TEXT runat="server" id="dnnTEXT-Demo" ShowText="Demo"  CssClass="dnn-text" ResourceKey="Example.Text" ReplaceTokens="False" />
~~~


### Text Skin Object Tokens
Use Tokens for a personalized message

~~~html
<dnn:TEXT runat="server" id="dnnTEXT-Tokens" ShowText="Tokens"  CssClass="dnn-text" ResourceKey="Token.Text" ReplaceTokens="True" />
~~~

