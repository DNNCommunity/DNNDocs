---
topic: config-module-activity-stream
locale: en
title: Configure the Activity Stream Module
dnneditions: 
dnnversion: 09.02.00
parent-topic: module-activity-stream
related-topics: configure-module-on-page-pb-all
---

# Configure the Activity Stream Module

## About photo entries and photo attachments

This module distinguishes between:

*   entries that are of type Photos, and
*   entries that have photo/image attachments.

If the type Photos is checked, photo entries are displayed. If unchecked, photo entries are hidden.

If either Enable File Attachments or Enable Photo Attachments is checked, entries with photo/image attachments are displayed. If both are unchecked, entries with photo/image attachments are hidden.

Note: If Enable Photo Attachments is checked, be sure to also check the type Photos. Otherwise, a user could create an entry with an attached photo, but they would not know that it was actually created, because they cannot see it.

A photo entry cannot have a file attachment. However, an entry with a photo attachment can have additional attachments.

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to Manage (gear icon) \> Settings.
    
      
    
    ![Manage action menu > Settings](/images/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the Activity Stream tab.
    
      
    
    ![Module Settings — Activity Stream](/images/scr-modulesettings-ActivityStream.png)
    
      
    
    Field
    
    Description
    
    Enable Activity Stream Editor
    
    If checked, the user can add new entries using the inline editor. Otherwise, the user can only read the activity entries.
    
    Enable File Attachments
    
    If checked:
    
    *   The paperclip icon is displayed in the inline editor, so that users can attach files to their entries.
    *   Existing entries that include attachments are displayed in the list.
    *   When possible, a preview of the attachment is displayed.
    
    Enable Photo Attachments
    
    If checked:
    
    *   The photo icon is displayed in the inline editor, so that users can use a photo as their entry.
    *   Existing photo entries are displayed in the list.
    *   The photo is resized and compressed for improved performance.
    
    Max Files Per Journal
    
    The maximum number of attachments per entry
    
    Enable View Filters
    
    If checked, the user is allowed to filter the list based on activity type.
    
    Enable Grouping of Posts
    
    If checked, entries of the same type are represented on the list as a single entry.
    
    Default Page Size
    
    The number of items to initially display, and the number of additional items to display when the Get More button is clicked/tapped.
    
    Maximum Characters per Message
    
    The maximum number of single-byte characters in the text entry. The actual number of characters might be fewer with multi-byte characters.
    
    Activity Types
    
    Content types that are displayed in the list of entries. Old content of a disabled type still remain in the database, and new content of a disabled type can still be created without error; however, they are not displayed in the list until the type is enabled again.
    
    Available Activity Filter Types
    
    (In the Activity Stream Filter module settings.) Content types that are included in the Filter by activity dropdown list.