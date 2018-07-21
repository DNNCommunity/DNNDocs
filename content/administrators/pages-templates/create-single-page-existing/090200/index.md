---
topic: create-single-page-existing
locale: en
title: Create a Navigation Link to an Existing Page
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-pages-templates-overview
related-topics: create-single-page-standard,create-single-page-url,create-single-page-file,create-multiple-pages-pb-all,configure-page-standard,configure-page-existing,configure-page-url,configure-page-file,copy-page-pb-all,edit-page-pb-all,view-hidden-page-pb-all,delete-page-pb-all,restore-deleted-pages,purge-deleted-pages,copy-permissions-to-child-pages-pb-all
---

# Create a Navigation Link to an Existing Page

## Steps

1.  Go to Persona Bar \> Content \> Pages.
    
    ![Persona Bar > Content > Pages](img/scr-pbar-host-Content-E91.png)
    
    ➊
    
    ➋
    
2.  Click/Tap Add Page.
    
      
    
    ![Pages > Click/Tap Add Page.](img/scr-pb-Pages-AddSinglePage-E90.png)
    
      
    
3.  In the Details tab, configure the basic settings of the page.
    1.  Set Page Type to Existing.
        
        ![Page Details > Page Type options](img/scr-pb-PageSettings-Details-PageType-E91.png)
        
    2.  Configure the link to an existing page.
        
          
        
        ![Add Page > Details > Page Type: Existing](img/scr-pb-AddSinglePage-Details-Existing-E91.png)
        
          
        
        Field
        
        Description
        
        Existing Page
        
        An existing page in your site. To link to an external site, set Page Type to External Url.
        
        Permanent Redirect
        
        If enabled (On), the HTTP status code 301 is returned with the page to indicate that the redirect is permanent.
        
        Open Link In New Window
        
        If enabled (On), the page is displayed in a new browser window or tab.
        
        \[Page\] Name
        
        Required. Used in the navigation.
        
        Display in Menu
        
        If enabled, the page is included in the main navigation menu. If the page is not included in the navigation menu, you can still link to it using its URL.
        
        Enable Scheduling
        
        If enabled, the Start Date and End Date buttons appear below the switch. Click/Tap on either button to set the time span when the page is publicly visible on the site.
        
        *   The page is published after the specified start date. If Start Date is not set, the page is published immediately.
        *   The page is hidden after the specified end date. If End Date is not set, the page is visible indefinitely.
        
          
        
        ![Add Page > Details > Calendar](img/scr-pb-AddPage-Details-Calendar.png)
        
          
        
4.  (Optional) In the Permissions tab, configure which roles can do which actions on this page.
    
      
    
    ![Page > Permissions](img/scr-pb-Page-Permissions-E91.png)
    
      
    
    *   Assign permissions for each role. Under Permissions by Role,
        *   To filter the displayed roles, select the role group from the Filter By Group dropdown.
        *   To add another role to the list, choose the additional role from the Select Role dropdown, and click/tap Add.
        *   Check the appropriate checkboxes to enable each role to perform actions.
    *   Assign permissions for a specific person. Under Permissions by User,
        *   To add a specific user to the list, enter part of their display name, select the correct user from the list, and click/tap Add.
        *   Check the appropriate checkboxes to enable each role to perform actions.
    
5.  (Optional) In the Advanced tab, configure additional settings.
    1.  In the Modules subtab, edit or delete the modules on the page, as needed.
        
          
        
        ![Page > Advanced > Modules](img/scr-pb-Page-Advanced-Modules-E91.png)
        
          
        
        Note: The Modules tab appears only if configuring a standard page.
        
    2.  In the Appearance subtab, configure how the page is displayed.
        
          
        
        ![Page > Advanced > Appearance](img/scr-pb-Page-Advanced-Appearance-E91.png)
        
          
        
        Field
        
        Description
        
        Page Theme
        
        The theme to use for the page.
        
        Layout
        
        The layout to use for the page.
        
        Page Container
        
        The container to use for all modules in the page. This setting is overridden by the module's container setting, if any.
        
        Page Stylesheet
        
        The CSS to use for this page. If blank, a default CSS is used. (Note: The default CSS used depends on other settings; it might be from the page theme, the site theme, or other CSS defaults.)
        
        Preview Theme Layout and Container
        
        If clicked/tapped, all the selected Appearance settings are applied to a page in a new browser window or tab.
        
    3.  In the SEO subtab, configure SEO-related settings for the page.
        
          
        
        ![Page > Advanced > SEO](img/scr-pb-Page-Advanced-SEO-E91.png)
        
          
        
        Field
        
        Description
        
        Page Header Tags
        
        HTML `<meta>` tags to add to the `<head>` of the page. Example: `<meta name="keywords" content="CMS, Liquid Content, example">`
        
        Sitemap Priority
        
        The priority for the page (0 to 1.0; default is 0.5). This value helps search engines to rank the page relative to other pages in the site.
        
        Allow Indexing
        
        If enabled (On), the `ROBOTS` meta tag is set to `INDEX` to indicate that search engines should index the page; i.e., `<meta name="ROBOTS" content="INDEX" />`. Otherwise, the `ROBOTS` meta tag is set to `NOINDEX`, and search engines ignore the page.
        
    4.  In the More subtab, configure security and caching for the page.
        
          
        
        ![Page > Advanced > More](img/scr-pb-Page-Advanced-More-E91.png)
        
          
        
        Field
        
        Description
        
        Secure Connection
        
        If enabled (On), the page is forced to use SSL. Available only if the site is SSL-enabled.
        
        Disable Page
        
        If enabled (On), the page appears in the navigation, but it cannot be clicked/tapped, thus creating a placeholder.
        
        Output Cache Provider
        
        The caching provider to use for the page. If none is specified, the site's caching provider is used.
        
6.  Click/Tap Add Page.