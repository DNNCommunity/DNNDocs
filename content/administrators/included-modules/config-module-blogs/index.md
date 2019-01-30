---
uid: config-module-blogs
topic: config-module-blogs
locale: en
title: Configure the Blogs Module
dnneditions: 
dnnversion: 09.02.00
parent-topic: module-blogs
related-topics: configure-module-on-page-pb-all
---

# Configure the Blogs Module

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to **Manage (gear icon) \> Settings**.
    
      
    
    ![Manage action menu > Settings](/images/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the **Blogs** tab.
    
      
    
    ![Module Settings — Blogs](/images/scr-modulesettings-Blogs.png)
    
      
    
     
    
    |  |**General**|
    |---|---|
    |**Mode**|The mode for the current module instance.<ul><li>**Normal**. If selected, the contents of the module are available to all registered users of the site.</li><li>**Group**. If selected, the blog and all entries is associated with a group.</li></ul>|
    |**Allow Windows Live Writer**|If checked, bloggers can use Windows Live Writer (or other remote blogging tools that use the MetaWeblog API) to post and edit blog posts.|
    |**Use Excerpt in Windows Live Writer**|If checked, bloggers can use the **Excerpt** in Windows Live Writer to create a summary of the post in plain text.|
    |**Comment Mode**|Entries can be individually set to allow or disallow comments.<ul><li>**None**. If selected, comments are disabled.</li><li>**Default**. If selected, the default comment settings for the site are used.</li><li>**Inline Login/Registration**. If selected, a login/registration link is displayed in the module for unauthenticated (anonymous) users who try to leave a comment.|
    
    
    |  |**Summary**|
    |---|---|
    |**Make Entry Summary Mandatory**|If checked, the blogger is required to include a summary when posting a blog entry.|
    |**Limit Auto-Generated Entry Summary to**|The maximum number of single-byte characters for the entry's summary. Enter "0" for unlimited characters. If Enforce Entry Summary Limit is unchecked, this limit applies to automatically generated summaries only.|
    |**Enforce Entry Summary Limit**|If checked, Limit Auto-Generated Entry Summary to applies to both automatically generated summaries and blogger-generated summaries.|
    |**Include Summary in Entry**|If checked, the summary is displayed at the top of each entry, when entries are listed.|
    |**Allow Summary HTML**|If checked, the blogger can format their entry summary in HTML.|
    

    |  |**Template Settings**|
    |---|---|    
    |**List Row Template**|The template to use when displaying the blog entries in a list.|
    |**Detail View Template**|The template to use when displaying the details of a single blog entry.|
    

    
    The following tokens are accepted in the templates:
    
    |**Token**|**Description**|
    |---|---|
    |`[ENTRY:IMAGE]`|Image to display with the blog entry's summary.|
    |`[ENTRY:DETAILESURL]`|URL to the blog entry's detailed view.|
    |`[ENTRY:TITLE]`|Blog entry title.|
    |`[ENTRY:PUBLISHONDATEDISPLAY]`|When the blog entry is published.|
    |`[ENTRY:COMMENTCOUNT]`|Number of comments on the blog entry.|
    |`[ENTRY:DECODEDSUMMARY]`|Summary of the blog entry. If **Allow Summary HTML** is checked, the summary is formatted in HTML; otherwise, the summary is in plain text.|
    |`[ENTRY:CONTENT]`|Blog entry content. Valid only in the **Detail View Template**.|
    |`[ENTRY:LIKESTRING]`|Blog entry's Like list. Valid only in the **Detail View Template**.|
    |`[ENTRY:VIEWS]`|Number of non-unique views of the blog entry.|
    |`[ENTRY:TAGS]`|Blog entry's tags.|
    |`[AUTHOR:AVATAR]`|Blogger's profile image; displayed as a 40x40-pixel image.|
    |`[AUTHOR:PROFILEURL]`|Blogger's profile URL.|
    |`[AUTHOR:DISPLAYNAME]`|Blogger's display name.|
    |`[AUTHOR:BIOGRAPHY]`|Blogger's biography.|
    |`[SOCIAL:LIKEBUTTON]`|**Like** button for the blog entry.|
    |`[SOCIAL:BOOKMARKBUTTON]`|**Bookmark** button for the blog entry.|
    |`[SOCIAL:SUBSCRIBEBUTTON]`|**Subscribe** button for the blog entry.|