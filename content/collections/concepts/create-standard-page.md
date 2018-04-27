---
title: Creating A Standard Page
slug: creating-a-standard-page
---

# Create a Standard Page

Pages can be created through the API (Developers) or from the user interface within DNN (Administrators). 


---

### Creating a Page Through the User Interface ###

Pages can be created from the user interface within DNN. Users who have been granted access to create pages see the persona bar on the left hand side of the screen. The below guide demonstrates how to create pages in the user interface.

### Steps

1. Go to **Persona Bar** > **Content** > **Pages** 

![](/img/concepts/persona-bar-content-menu.png "Persona bar Content Menu image")	
2. Click/Tap **Add Page** 

![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Pages-AddSinglePage-E90.png "Persona bar Add Page Menu image")

3.In the **Details** tab, configure the basic settings of the page. 
 - Set **Page Type** to **Standard**
 
![](http://www.dnnsoftware.com/docs/common/img/scr-pb-PageSettings-Details-PageType-E91.png "Page Type Menu")
 - Configure the new standard page.
 ![](http://www.dnnsoftware.com/docs/common/img/scr-pb-AddSinglePage-Details-Standard-E91.png "Page details configuration")
 
| **Field**  |**Description**   |
|---|---|
| **[Page] Name**  | Required. Used in the navigation.  |
| **[Page] Title**  | Displayed as the browser window's title. Tip: The title is used by search engines to identify the information on the page. Include at least five highly descriptive words, and keep the title under 200 characters.  |
| **[Page] Description**  | Information about the page.  |
| **Keywords**  | Comma-separated keywords that can be used by search engines to help index your site's pages  |
| **Tags**  | Predefined tags that you can choose from the dropdown, if any are defined in the **Taxonomy Manager**   |
| **Parent Page** **Branch Parent**  |  The page under which the new page(s) should reside in the hierarchy. |
| **Display in Menu**  |  If enabled, the page is included in the main navigation menu. If the page is not included in the navigation menu, you can still link to it using its URL. |
| **Link Tracking**  |  If enabled, tracking links are created to determine where traffic to the page is coming from. |
| **Workflow**  |  Predefined workflow states that you can choose from the dropdown |
|**Enable Scheduling**   | If enabled, the **Start Date** and **End Date** buttons appear below the switch. Click/Tap on either button to set the time span when the page is publicly visible on the site.<ul><li> The page is published after the specified start date. If **Start Date** is not set, the page is published immediately.</li><li>The page is hidden after the specified end date. If **End Date**j is not set, the page is visible indefinitely.</li> ![](http://www.dnnsoftware.com/docs/common/img/scr-pb-AddPage-Details-Calendar.png "Select start date / end date menu image") |
| **Template Mode**  | <ul><li>**Import from XML**. You must specify an XML file containing the template to import.</li><li>**Evoq Page Template**. You must choose the template layouts provided by thte site's current theme.</li></ul>   |
| **XML File**  | The XML file containing the template to import.  |

4. (Optional) In the **Permissions** tab, configure which roles can do which actions on this page.
![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Page-Permissions-E91.png "Page permissions grid image")
<ul><li>Assign permissions for each role. Under <strong>Permissions by Role</strong><ul><li>To filter the displayed roles, select the role group from the <strong>Filter By Group</strong> dropdown.</li><li>To add another role to the list, choose the additional role from the <strong>Select Role</strong> dropdown, and click/tap <strong>Add</strong></li><li>Check the appopriate checkboxes to enable each role to perform actions.</li></ul><li>Assign permissions for a specific person. Under <strong>Permissions by User,</strong><ul><li>To add a specific user to the list, enter part of their display name, select the correct user from the list, and click/tap <strong>Add</strong></li><li>Check the appropriate checkboxes to enable each role to perform actions.</li></ul></li></ul>

5.(Optional) In the <strong>Advanced</strong> tab, configure additional settings.
- In the <strong>Modules</strong> sub-tab, edit or delete the modules on the page, as needed.
![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Page-Advanced-Modules-E91.png "The advanced tab, modules list in page settings image")
<blockquote><strong>Note:</strong> The <strong>Modules</strong> tab appears only if configuring a standard page.</blockquote>

- In the <strong>Appearance</strong> sub-tab, configure how the page is displayed.

![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Page-Advanced-Appearance-E91.png "The advanced tab, appearance view in page settings")


| **Field**  | **Description**  |
|---|---|
| **Page Theme**  |  The theme to use for the page. |
| **Layout**  | 	The layout to use for the page.  |
| **Page Container**  |  The container to use for all modules in the page. This setting is overridden by the module's container setting, if any. |
| **Page Stylesheet**  | The CSS to use for this page. If blank, a default CSS is used. (Note: The default CSS used depends on other settings; it might be from the page theme, the site theme, or other CSS defaults.)  |
| **Preview Theme Layout and Container**|If clicked/tapped, all the selected **Appearance** settings are applied to a page in a new browser window or tab.   |

- In the **SE0** sub-tab, configure SEO-related settings for the page.

![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Page-Advanced-SEO-E91.png "The advanced tab, SEO view in page settings")

|**Field**|**Description**|
|---|---|
|**Page Header Tags**| HTML <meta> tags to add to the ```<head>``` of the page. Example: ```<meta name="keywords content=CMS, DNN, DotNetNuke"```>|
|**Sitemap Priority**|The priority for the page (0 to 1.0; default is 0.5). This value helps search engines to rank the page relative to other pages in the site.|
|**Allow Indexing**|If enabled (**On**), the ```ROBOTS``` meta tag is set to ```INDEX``` to indicate that search engines should index the page; i.e., ```<meta name="ROBOTS" content="INDEX"/>```. Otherwise, the ```ROBOTS``` meta tag is et to ```NOINDEX```, and search engines ignore the page.|

- In the **More** sub-tab, ocnfigure security and caching for the page.

![](http://www.dnnsoftware.com/docs/common/img/scr-pb-Page-Advanced-More-E91.png "The advanced tab, security and caching settings view")

|**Field**|**Description**|
|---|---|
|**Secure Connection**|If enabled (**On**), the page is forced to use SSL. Available only if the site is SSL-enabled.|
|**Disable Page**|If enabled (**On**), the page appears in the navigation, but it cannot be clicked/tapped, thus creating a placeholder.|
|**Output Cache Provider**|The caching provider to use for the page. If none is specified, the site's caching provider is used.|

6. Click/Tap **Add Page**




---

### Creating a Page Through the API ###

##### TabController Class ####

###### C# ###### 
``` public class TabController : ServiceLocator<ITabController, TabController>, 	ITabController ```
###### VB ######
``` Public Class TabController Inherits ServiceLocator(Of ITabController, TabController) Implements ITabController ```