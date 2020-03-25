---
uid: edit-starting-url-in-crawl-list
locale: en
title: Edit a Starting URL in Crawl List
dnnversion: 09.02.00
related-topics: add-starting-url-to-crawl-list,delete-starting-url-from-crawl-list,add-directory-to-included-list,delete-directory-from-included-list,add-directory-to-excluded-list,delete-directory-from-excluded-list,add-file-extension-to-included-or-excluded-list,delete-file-extension-from-included-or-excluded-list
---

# Edit a Starting URL in Crawl List

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to **Persona Bar \> Settings \> Site Settings**.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the **Search** tab, and then the **Crawling** subtab.
    
    ![Search > Crawling](/images/scr-pbtabs-all-Settings-SiteSettings-Search-Crawling-E90.png)
    
3.  In **URL Paths**, find the URL to edit and click/tap its pencil icon.
    
      
    
    ![](/images/scr-SiteSettings-Search-Crawling-url-paths-edit-E90.png)
    
      
    
4.  Configure the URL to crawl.
    
      
    
    ![](/images/scr-SiteSettings-Search-Crawling-url-paths-edit-url-E90.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |<strong>URL</strong>|The URL where crawling should start.|
    |<strong>Sitemap URL</strong>|The URL of the sitemap to use, if any.|
    |<strong>DNN Role Impersonation</strong>|The role assigned to the crawler to gain access to this URL path. Note: The role must have at least one user assigned to it.|
    |<strong>Enable Spidering</strong>|If enabled, the specified <strong>URL</strong>is marked to be included in the next crawl. If disabled, the specified <strong>URL</strong> is not included in the next crawl; however, any existing index for this URL is still used for search.|
    |<strong>Windows Authentication</strong>|If enabled, the crawler users the specified credentials to gain access to the site<ul><li><strong>Windows Domain</strong><li><strong>Windows User Account</strong></li><li><strong>Windows User Password</strong></li></ul><br />If the user account and password are blank, the local server's default Windows credentials are used.<br />Note: Enable this option if the site uses <strong>Integrated Windows Authentication</strong>.|
    
5.  Save.
