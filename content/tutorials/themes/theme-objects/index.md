---
uid: theme-objects
locale: en
title: Theme Objects
dnnversion: 09.02.00
related-topics: create-layout-template,create-container,create-theme
links: ["[DNN UX Guide](https://uxguide.dnnsoftware.com/)","[DotNetNuke Skinning Guide (Appendix B: Skin Objects) by Timo Breumelhof](https://www.timo-design.nl/Portals/0/downloads/DotNetNuke-Skin-Objects-DNN5.pdf)","[Skinning Tool / Online Reference for DNN Skins & Container Objects by 10 Pound Gorilla](https://www.10poundgorilla.com)"]
---

# Theme Objects
A Theme Object is an element (user control in webforms) that is used to add specific functionality to your Theme.

The difference with the use of a Module in DNN is that a Theme Object is (mostly) not configurable or movable by a site admin.
You can control the behaviour of a Theme object by settings its attributes in your Theme and these settings are then "fixed" for that theme.

> [!NOTE]
> In previous versions of DNN these were called "Skin Objects"

## How to use a Theme object.

### Theme Object Function.
Every Theme object has a specific function. There are Theme objects for the site logo, a login link, menu etc.

### Theme Object Attributes.
Most Theme objects also allow you to set some attributes, to influence how the Theme object behaves.
Most of these attributes have a default value.

There are two things you have to do to add a Theme object to your Theme.
1. Add the Theme object to the Theme
2. Set its attributes

### Add a Theme Object.
You need to edit the ASCX file of you individual Theme's layout
Here there are 3 things you have to add.

#### Register the Theme Object.
This should be on top of the ASCX and it tells DNN where it can find the Theme Object on the server.
This register tag looks like this:

~~~
<%@ Register TagPrefix="dnn" TagName="ThemeObjectName" Src="ThemeObjectPath" %>
~~~

`ThemeObjectName` = The name of the Theme object
`ThemeObjectPath` = Location of the Theme Object on the server (~/Admin/Themes/BreadCrumb.ascx)

Even if you add the Theme object multiple times to your Theme you would only have to add this registration once for each Theme object type.

#### Add the Theme Object itself.
To add the actual Theme object you use a tag like this:
~~~
<TagPrefix:TagName  runat="server" id="UniqueId" />
~~~

`TagPrefix` = the value for the TagPrefix attribute in the register tag.
`TagName` = the value for the TagName attribute in the register tag.
`Runat="server"` is required to tell the Framework this is not static HTML but needs to be processed
`UniqueId` = an Id that should be unique to this Theme. 
If you use the Id multiple times you will get an error and the Theme will not work correctly.
This Id should be a valid Id (in HTML terms; start with a letter, no spaces etc.).

If you use a Theme object multiple times in one Theme, the only difference would be this Id (apart from attributes that might differ).


#### Add attributes.
Adding an attribute
~~~
<TagPrefix:TagName  runat="server" id="UniqueId" Attribute="Value" />
~~~


## BreadCrumb Theme Object Example.
Let's take the BreadCrumb Theme Object as an example.
It displays the path to the currently selected page in the menu structure like this:

RootPage > SubPage > SubSubPage

There are three attributes you can set:

### 1. Separator.
The separator between breadcrumb links. 
This can include custom Theme images, text, and HTML.
Default Value: /images/breadcrumb.gif

### 2. CssClass.
The CSS style name of the breadcrumb links.
Default Value: ThemeObject

### 3. RootLevel 1.
The root level of the breadcrumb links.  
Valid values include:
`-1`  	show word “Root” and then all breadcrumb tabs
`0`  	show all breadcrumb tabs
`N` 	skip N breadcrumb pages (levels) before displaying 
(where N is an integer greater than 0)
Default Value: 1

Let's say we want to add the BreadCrumb SKO to our Theme.
And we want to set the Separator attribute to "++" to get this result:

RootPage ++ SubPage ++ SubSubPage

This is what we would have to add to our Theme:

ASCX Theme
~~~
<%@ Register TagPrefix="dnn" TagName="BREADCRUMB" Src="~/Admin/Themes/BreadCrumb.ascx" %>

<dnn:BREADCRUMB runat="server" id="dnnBREADCRUMB"  Separator="&nbsp;++&nbsp;" />
~~~

Where the "Register" block should be on top of the ASCX file.
The <dnn:BREADCRUMB...> block should be placed in the Theme on the spot you want it to appear.

> [!NOTE]
> The following list are the Core Theme / Container Objects.

|**Theme Object**|**Description**|
|---|---|
|ACTIONBUTTON|Displays an action from the **module action menu**.|
|[BREADCRUMB](xref:breadcrumb)|Displays the path to the current tab (`>` is the default separator). Example: `PageName1 > PageName2 > PageName3`|
|CONTROLPANEL|Displays the DNN control panel. If the **CONTROLPANEL** theme object is not used in the theme, then DNN inserts a control panel control at the top of the page.|
|COPYRIGHT|Displays the copyright notice for the website.|
|CURRENTDATE|Displays the current date on the server.|
|[DDRMENU](xref:ddrmenu-overview)|Displays a menu using the **DDRMenu** control.|
|DNNCSSEXCLUDE|Prevents a stylesheet reference from being included in the page.|
|DNNCSSINCLUDE|Adds a stylesheet reference to the page.|
|DNNJSEXCLUDE|Prevents a JavaScript file reference from being included in the page.|
|DNNJSINCLUDE|Adds a JavaScript file reference to the page.|
|DOTNETNUKE|Displays the copyright notice for DNN.|
|HELP|Displays a **Help** link, which sends an email to the website's administrator, using the user's default email client.|
|HOSTNAME|Displays the host title linked to the host URL. The host title and host URL are defined on the host settings page.|
|JQUERY|Adds jQuery JavaScript reference to the page.|
|JAVASCRIPTLIBRARYINCLUDE|Include an installed Javascripot Library|
|LANGUAGE|Displays the language selector dropdown list or the language flags based on the theme object attribute settings.|
|LINKTOFULLSITE|Displays a link to the Desktop version of the website|
|LINKTOMOBILE|Displays a link to the Mobile version of the website|
|LOGIN|Displays **Login** for anonymous users and **Logout** for authenticated users.|
|LOGO|Displays the website's logo.|
|META|Add Meta Tags to your page|
|PRIVACY|Displays a link to the Privacy Information page for the website.|
|SEARCH|Displays the search input box.|
|SIGNIN|Displays the login control.|
|TAGS|Displays the **Tag** control allowing users to view and edit tags associated with the page or module.|
|TERMS|Displays a link to the Terms and Conditions page of the website.|
|TEXT|Displays localized text in your theme and supports the use of token replacement.|
|TOAST|Adds the toast notification control to the page. Toast messages will be shown when a new user notification or message is received.|
|USER|Displays a **Register** link for anonymous users or the user's name for authenticated users.|
|USERANDLOGIN|Displays a **Register** / **login** / **User** block.|

|**Container Object**|**Description**|
|---|---|
|MODULEMESSAGE|Displays Module messages|
|ICON|Displays the module icon.|
|TITLE|Displays the module title.|
|PRINTMODULE|Displays a link for the Print action from the module action menu.|

|**Legacy Theme Object**|**Description**|**Replaced by**|
|---|---|---|
|LEFTMENU|Displays a vertical menu layout.|DDR Menu with the appropriate template|
|LINKS|Displays a flat menu of links associated with the current tab level and the parent node.|DDR Menu with the appropriate template|
|NAV|Displays a menu according to the type specified in the ProviderName attribute.|DDR Menu with the appropriate template|
|TREEVIEW|Displays a menu, similar to the Windows Explorer menu, using the **DNN Treeview Control**.|DDR Menu with the appropriate template|

|**Legacy Theme Object**|**Description**|**Better use**|
|---|---|---|
|VISIBILITY|Displays a visibility control for the module allowing users to show or hide a given module on the page.|Custom JS/jQuery|
|STYLES|Allows you to add Internet Explorer-specific stylesheets to your theme.|More modern methods like: <!--[if lt IE 9]>...<![endif]-->|
