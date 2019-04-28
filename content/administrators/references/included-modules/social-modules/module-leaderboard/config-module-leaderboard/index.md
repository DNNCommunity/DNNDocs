---
uid: config-module-leaderboard
locale: en
title: Configure the Leaderboard Module
dnnversion: 09.02.00
related-topics: 
---

# Configure the Leaderboard Module

Content managers and administrators can filter the results list by time frame (**Interval**), by relationship (**Display Mode**), or type (**Behavior**). These settings determine which user accounts are included in the results returned to the user. However, the user can also filter which of the results are displayed if **Show Mode Switch Button** is checked.

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to **Manage (gear icon) \> Settings**.
    
      
    
    ![Manage action menu > Settings](/images/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the **Leaderboard** tab.
    
      
    
    ![Module Settings — Leaderboard](/images/scr-modulesettings-Leaderboard.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |**Page Size**|The number of items to display in each result page. (5 — 100)|
    |**Interval**|The time period when the rankings would be based. Example: If you choose **Last Week**, the rankings would be based on points earned by users in the past seven days only.|
    |**Show Search Panel**|If checked, allows users to search for members by name in the displayed list.|
    |**Show Mode Switch Buttons**|Displays relevant buttons that can be used by the user to further filter what is displayed.<ul><li>**Everyone**. Displays all the results.</li><li>**Friends**. Displays only the current user's friends who are included in the results.</li><li>**Members**. Displays only the members of the group specified in **Membership in Group**.</li></ul>|
    |**Display Mode**|<ul><li>**All Users**. Ranks and returns all registered users of the site.</li><li>**Friends**. Ranks and returns only the friends of the current user.</li><li>**Members**. Ranks and returns only members of the specified group.</li></ul>|
    |**Membership in Group**|The group whose members to display. This field appears only if **Display Mode** is **Members**. If the selected group is **None**, all registered users will be included.|
    |**Behavior**|<ul><li>**Relative Ranking**. Displays users in order of ranking.</li><li>**Top Contributors**. Displays only the users with the highest points.</li></ul>|
    |**Template**|Template to use for the leaderboard. Some predefined templates are provided by DNN. If you choose **Custom**, the next four fields are displayed to allow you to enter custom HTML to be used with the current module instance only.
    |**Header Template**|The custom HTML template used as the prefix to the list. Typically the starting tags for the table or list. Available only if **Template** is set to **Custom**.|
    |**Item Template**|The custom HTML template used to display each item in the list. Typically an entire row of the table or a bullet in the list. Available only if **Template** is set to **Custom**.|
    |**Highlighted Item Template**|The custom HTML template used to display the selected item in the list. Typically an entire row of the table or a bullet in the list. Available only if **Template** is set to **Custom**.|
    |**Footer Template**|The custom HTML template used as the suffix to the list. Typically the terminating tags for the table or list. Available only if **Template** is set to **Custom**.|
