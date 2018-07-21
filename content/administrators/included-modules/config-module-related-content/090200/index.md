---
topic: config-module-related-content
locale: en
title: Configure the Related Content Module
dnneditions: 
dnnversion: 09.02.00
parent-topic: module-related-content
related-topics: configure-module-on-page-pb-all
---

# Configure the Related Content Module

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to Manage (gear icon) \> Settings.
    
      
    
    ![Manage action menu > Settings](img/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the Related Content tab.
    
      
    
    ![Module Settings — Related Content](img/scr-modulesettings-RelatedContent.png)
    
      
    
     
    
    Initial View
    
    Items to Display
    
    The number of items to display.
    
     
    
    Sorting
    
    Sorting Column
    
    Sorts the list based on the selected column.
    
    Sort Order  
                                   Sort Direction  
                            
    
    Sorts the list in ascending or descending order.
    
     
    
    Filtering
    
    Filter Related Items on Taxonomy Tag
    
    Returns only the related items that have the specified tag. The tag must be defined in a Taxonomy directory.
    
    Filter Related Items on Content Type
    
    Returns only the related items that are of the selected content type.
    
     
    
    Display Templates
    
    Header Template
    
    The custom HTML template used as the prefix to the list. Typically the starting tags for the table or list.
    
    Item Template
    
    The custom HTML template used to display each item in the list. Typically an entire row of the table or a bullet in the list.
    
    Footer Template
    
    The custom HTML template used as the suffix to the list. Typically the terminating tags for the table or list.
    
    The following tokens are available for the Display Templates:
    
    Token
    
    Template
    
    Description
    
    \[Summary:TotalItems\]
    
    Header Template  
           Footer Template
    
    Count of related items returned by the query.
    
    \[Summary:ContentTitle\]
    
    Header Template  
           Footer Template
    
    Title of the primary content item for which we are searching related items.
    
    \[Item:ContentType\]
    
    Item Template
    
    The related item's content type.
    
    \[Item:ContentBrief\]
    
    Item Template
    
    A snippet of the related item.
    
    \[Item:Page\]
    
    Item Template
    
    The page hosting the related item.
    
    \[Item:Module\]
    
    Item Template
    
    The module hosting the related item.
    
    \[Item:Key\]
    
    Item Template
    
    The ContentKey associated with the related item.
    
    \[Item:CreatedBy\]
    
    Item Template
    
    The user who created the related item.
    
    \[Item:CreatedDate\]
    
    Item Template
    
    When the related item was created.