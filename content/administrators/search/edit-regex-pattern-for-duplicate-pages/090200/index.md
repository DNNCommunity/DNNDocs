---
topic: edit-regex-pattern-for-duplicate-pages
locale: en
title: Edit Regex Pattern for Duplicate Pages
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-search-overview
related-topics: add-regex-pattern-for-duplicate-pages,delete-regex-pattern-for-duplicate-pages
---

# Edit Regex Pattern for Duplicate Pages

You can optimize the search index by marking generated pages as duplicates if they differ in dynamic content only. The crawler indexes only one from each set of pages that match a specified regex pattern.

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to Persona Bar \> Settings \> Site Settings.
    
    ![Persona Bar > Settings > Site Settings](img/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Go to the Search tab, and then the Crawling subtab.
    
    ![Search > Crawling](img/scr-pbtabs-all-Settings-SiteSettings-Search-Crawling-E90.png)
    
3.  In Duplicates, find the regex pattern to edit and click/tap its pencil icon.
    
      
    
    ![](img/scr-SiteSettings-Search-Crawling-duplicates-edit-E90.png)
    
      
    
4.  Edit the regex pattern for duplicates.
    
      
    
    ![](img/scr-SiteSettings-Search-Crawling-duplicates-edit-regex-pattern-E90.png)
    
      
    
    Field
    
    Description
    
    Description
    
    A name for the regex pattern entry. Typically, the name of the module that generates the dynamic content in pages that match the specified pattern.
    
    Regex Pattern
    
    The regular expression that describes the various URLs and URL parameters of pages that are considered duplicates.
    
5.  Save.