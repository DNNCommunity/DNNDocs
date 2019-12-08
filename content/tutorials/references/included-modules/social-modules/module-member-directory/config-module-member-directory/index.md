---
uid: config-module-member-directory
locale: en
title: Configure the Member Directory Module
dnnversion: 09.02.00
related-topics: 
---

# Configure the Member Directory Module

In the Member Directory module, you can configure:

*   the HTML templates used to display member information,
*   how the list is filtered and sorted,
*   how users can search for members in the list, and
*   how the list is divided into pages.

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to **Manage (gear icon) \> Settings**.
    
      
    
    ![Manage action menu > Settings](/images/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the **Member Directory Settings** tab.
    
      
    
    ![Module Settings — Member Directory](/images/scr-modulesettings-MemberDirectory.png)
    
      
    
     
    
|  |**Templates**|
|---|---|
|**Item Template**|The HTML template used to display the first and every other (odd-numbered) item in the directory.|
|**Alternate Item Template**|The HTML template used to display the second and every other (even-numbered) item in the directory. Leave this blank to use the **Item Template** for all members.|
|**Enable PopUp**|If checked, the member details are displayed in a pop-up window when the user hovers over the member's listing.|
|**PopUp Template**|The HTML template used to display a member's details in a pop-up window.|

     

|   |**Filters and Sorting**|
|---|---|
|**Filter By**|<ul><li>**No Filter**. Displays all members.</li><li>**User**. Displays the profile of the current user.</li><li>**Group**. Displays only the members of the selected group.<br />![Module Settings — Member Directory — Filter by Group](/images/scr-modulesettings-MemberDirectory-FilterGroup.png) </li><li>**Relationship**. Displays only the members with the selected relationship to the current user. (Friends or Followers)<br />![Module Settings — Member Directory — Filter by Relationship](/images/scr-modulesettings-MemberDirectory-FilterRelationship.png)</li><li>**Profile Property**. Displays only the members who have the specified value for the selected property.<br />![Module Settings — Member Directory — Filter by Property](/images/scr-modulesettings-MemberDirectory-FilterProfileProperty.png)</li></ul>|
|**Sort Field<br />Sort List By**|Sorts the list based on the selected field.|
|**Sort Order<br />Sort Direction**|Sorts the list in ascending or descending order.|
|**Exclude Host Users**|If checked, hosts are excluded from the resulting list.|


> [!Tip]
> Checking this option is useful for security. By hiding users with maximum permissions, you reduce the risk of hackers targeting those accounts or leveraging the names of those users in social engineering attacks.
 

|  |**Search Settings**|
|---|---|
|**Display Search**|<ul><li>**None**. Removes the search capability.</li><li>**Simple Search**. Provides a basic case-insensitive search of the **Display Name** field only.</li><li>**Simple and Advanced Search**. Provides both the basic search and the advanced search. The **Advanced Search** allows you to narrow the search results by performing a case-insensitive Boolean-AND search on the specified **Search Fields**.</li></ul>|**Search Field 1**<br />**Search Field 2**<br />**Search Field 3**<br />**Search Field 4**|The fields to be used in the **Advanced Search**.| 

|  |**Paging Options**|
|---|---|
|**Disable Paging**|If checked, only the first page of the results is displayed and the Load more button is hidden.|
|**Page Size**|The number of items to display in each result page. (1 — 100)|
    

## Example

*   To list the current user's friends or followers,
    1.  Under Filters and Sorting, choose Relationship.
    2.  In the dropdown, choose Friends or Followers.
*   To add the current user's abbreviated profile on a page, such as on a sidebar,
    1.  Under Filters and Sorting, choose User.
    2.  Under Search Settings, set Display Search to None.
*   To allow the user to search for other members in the entire site,
    1.  Under Filters and Sorting, choose No Filter.
    2.  Under Search Settings, set Display Search to Simple Search or Simple and Advanced Search.
    3.  Choose four fields that you allow the users to search on.
*   To list the members of a group,
    1.  Under Filters and Sorting, choose Group.
    2.  In the dropdown, choose the social group or role group.
*   To list members located in a specific geographical area.
    1.  Under Filters and Sorting, choose Profile Property.
    2.  In the dropdown, choose a location field, such as City, Region, or Postal Code.
    3.  In the text field, enter the value to match for the selected property.
