---
uid: create-single-page-standard
topic: create-single-page-standard
locale: en
title: Create a Standard Page
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-pages-templates-overview
related-topics: create-single-page-existing,create-single-page-url,create-single-page-file,create-multiple-pages-pb-all,configure-page-standard,configure-page-existing,configure-page-url,configure-page-file,copy-page-pb-all,edit-page-pb-all,view-hidden-page-pb-all,delete-page-pb-all,restore-deleted-pages,purge-deleted-pages,copy-permissions-to-child-pages-pb-all
---

# Create a Standard Page

## Steps

1.  Go to **Persona Bar \> Content \> Pages**.
    
    ![Persona Bar > Content > Pages](/images/scr-pbar-host-Content-E91-platform.png)
    
2.  Click/Tap **Add Page**.
    
      
    
    ![Pages > Click/Tap Add Page.](/images/scr-pb-Pages-AddSinglePage-E90.png)
    
      
    
3.  In the **Details** tab, configure the basic settings of the page.
    1.  Set **Page Type** to **Standard**.
        
        ![Page Details > Page Type options](/images/scr-pb-PageSettings-Details-PageType-E91.png)
        
    2.  Configure the new standard page.
        
          
        
        ![Add Page > Details > Page Type: Standard](/images/scr-pb-AddSinglePage-Details-Standard-E91.png)
        
          
        
        |**Field**|**Description**|
        |---|---|
        |<strong>[Page] Name</strong>|Required. Used in the navigation.|
        |<strong>[Page] Title</strong>|Displayed as the browser window's title. Tip: The title is used by search engines to identify the information on the page. Include at least five highly descriptive words, and keep the title under 200 characters.|
        |<strong>[Page] Description</strong>|Information about the page.|
        |<strong>Keywords</strong>|Comma-separated keywords that can be used by search engines to help index your site's pages.|
        |<strong>Tags</strong>|Predefined tags that you can choose from the dropdown, if any are defined in the Taxonomy Manager.|
        |<strong>Parent Page <br />Branch Parent</strong>|The page under which the new page(s) should reside in the hierarchy.|
        |<strong>Display in Menu</strong>|If enabled, the page is included in the main navigation menu. If the page is not included in the navigation menu, you can still link to it using its URL.|
        |<strong>Link Tracking</strong>|If enabled, tracking links are created to determine where traffic to the page is coming from.|
        |<strong>Workflow</strong>|Predefined workflow states that you can choose from the dropdown.|
        |<strong>Enable Scheduling</strong>|If enabled, the <strong>Start Date</strong> and <strong>End Date</strong> buttons appear below the switch. Click/Tap on either button to set the time span when the page is publicly visible on the site.<ul><li>The page is published after the specified start date. If Start Date is not set, the page is published immediately.</li><li>The page is hidden after the specified end date. If End Date is not set, the page is visible indefinitely.</li></ul>![Add Page > Details > Calendar](/images/scr-pb-AddPage-Details-Calendar.png)|
        |<strong>Template Mode<strong>|<ul><li><strong>Import from Xml</strong>. You must specify an XML file containing the template to import.</li><li><strong>Evoq Page Template</strong>. You must choose from the template layouts provided by the site's current theme.</li></ul>|
        |<strong>Page Template</strong>|The template layouts are defined by the theme used in the site.|
        |<strong>Xml File</strong>|The XML file containing the template to import.|
        
4.  (Optional) In the **Permissions** tab, configure which roles can do which actions on this page.
    
      
    
    ![Page > Permissions](/images/scr-pb-Page-Permissions-E91.png)
    
      
    
    *   Assign permissions for each role. Under Permissions by Role,
        *   To filter the displayed roles, select the role group from the Filter By Group dropdown.
        *   To add another role to the list, choose the additional role from the Select Role dropdown, and click/tap Add.
        *   Check the appropriate checkboxes to enable each role to perform actions.
    *   Assign permissions for a specific person. Under Permissions by User,
        *   To add a specific user to the list, enter part of their display name, select the correct user from the list, and click/tap Add.
        *   Check the appropriate checkboxes to enable each role to perform actions.
    
5.  (Optional) In the **Advanced** tab, configure additional settings.
    1.  In the **Modules** subtab, edit or delete the modules on the page, as needed.
        
          
        
        ![Page > Advanced > Modules](/images/scr-pb-Page-Advanced-Modules-E91.png)
        
          
        
        > [!Note]
        > The Modules tab appears only if configuring a standard page.
        
    2.  In the **Appearance** subtab, configure how the page is displayed.
        
          
        
        ![Page > Advanced > Appearance](/images/scr-pb-Page-Advanced-Appearance-E91.png)
        
          
        
        |**Field**|**Description**|
        |---|---|
        |<strong>Page Theme</strong>|The theme to use for the page.|
        |<strong>Layout</strong>|The layout to use for the page.|
        |<strong>Page Container</strong>|The container to use for all modules in the page. This setting is overridden by the module's container setting, if any.|
        |<strong>Page Stylesheet</strong>|The CSS to use for this page. If blank, a default CSS is used. (Note: The default CSS used depends on other settings; it might be from the page theme, the site theme, or other CSS defaults.)|
        |<strong>Preview Theme Layout and Container</strong>|If clicked/tapped, all the selected <strong>Appearance</strong> settings are applied to a page in a new browser window or tab.
        
    3.  In the **SEO** subtab, configure SEO-related settings for the page.
        
          
        
        ![Page > Advanced > SEO](/images/scr-pb-Page-Advanced-SEO-E91.png)
        
          
        
        |**Field**|**Description**|
        |---|---|
        |<strong>Page Header Tags</strong>|HTML `<meta>` tags to add to the `<head>` of the page. Example: `<meta name="keywords" content="CMS, Liquid Content, example">`|
        |<strong>Sitemap Priority</strong>|The priority for the page (0 to 1.0; default is 0.5). This value helps search engines to rank the page relative to other pages in the site.|
        |<strong>Allow Indexing</strong>|If enabled (<strong>On</strong>), the `ROBOTS` meta tag is set to `INDEX` to indicate that search engines should index the page; i.e., `<meta name="ROBOTS" content="INDEX" />`. Otherwise, the `ROBOTS` meta tag is set to `NOINDEX`, and search engines ignore the page.|

        
    4.  In the **More** subtab, configure security and caching for the page.
        
          
        
        ![Page > Advanced > More](/images/scr-pb-Page-Advanced-More-E91.png)
        
          
        
        |**Field**|**Description**|
        |---|---|
        |<strong>Secure Connection</strong>|If enabled (On), the page is forced to use SSL. Available only if the site is SSL-enabled.|
        |<strong>Disable Page</strong>|If enabled (On), the page appears in the navigation, but it cannot be clicked/tapped, thus creating a placeholder.|
        |<strong>Output Cache Provider</strong>|The caching provider to use for the page. If none is specified, the site's caching provider is used.|
        
6.  Click/Tap **Add Page**.

## Results

The page is displayed in edit mode. You can click/tap on any of the panes to add content or modules.