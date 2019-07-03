---
uid: configure-search
locale: en
title: Configure Search
dnnversion: 09.02.00
related-topics: prioritize-search-items
---

# Configure Search

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to **Persona Bar \> Settings \> Site Settings**.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the **Search** tab, and then the **Basic Settings** subtab.
    
    ![Search > Basic Settings](/images/scr-pbtabs-host-Settings-SiteSettings-Search-BasicSettings-E90.png)
    
3.  Configure the basic search settings.
    
      
    
    ![](/images/scr-SiteSettings-Search-BasicSettings-config-E90.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |<strong>Minimum Word Length<br />Maximum Word Length</strong>|The range specifying the allowed length of words to be indexed. The word length is the number of single-byte characters in the word.|
    |<strong>Custom Analyzer Type</strong>|The full name of the custom analyzer to index the content. To force existing content to be reindexed with the new analyzer, click/tap the <strong>Reindex Content</strong> of <strong>Reindex Host Content</strong> buttons in the <strong>Search Index</strong> section.|
    |<strong>Enable Partial-Word Search (Slow)</strong>|If enabled, you can use wildcards to search for substrings inside words; i.e., not at the beginning of the word.|
