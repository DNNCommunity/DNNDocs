---
uid: config-module-journal
locale: en
title: Configure the Journal Module
dnnversion: 09.02.00
related-topics: 
---

# Configure the Journal Module

## Photo entries and photo attachments

This module distinguishes between:

*   entries that are of type **Photos**, and
*   entries that have photo/image attachments.

If the type **Photos** is checked, photo entries are displayed. If unchecked, photo entries are hidden.

If either **Enable File Attachments** or **Enable Photo Attachments** is checked, entries with photo/image attachments are displayed. If both are unchecked, entries with photo/image attachments are hidden.

> [!NOTE]
> If **Enable Photo Attachments** is checked, be sure to also check the type **Photos**. Otherwise, a user could create an entry with an attached photo, but they would not know that it was actually created, because they cannot see it.

A photo entry cannot have a file attachment. However, an entry with a photo attachment can have additional attachments.

## Steps

1.  Go to the page containing the module to configure. Edit the page.
2.  In the module's action menu bar, go to **Manage (gear icon) \> Settings**.
    
      
    
    ![Manage action menu > Settings](/images/scr-actionmenu-manage-settings.png)
    
      
    
3.  Go to the **Journal Settings** tab.
    
      
    
    ![Module Settings — Journal](/images/scr-modulesettings-Journal.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |**Enable Journal Editor**|If checked, the user can add new entries using the inline editor. Otherwise, the user can only read the journal entries.|
    |**Enable File Attachments**|If checked:<ul><li>The paperclip icon is displayed in the inline editor, so that users can attach files to their entries.</li><li>Existing entries that include attachments are displayed in the list.</li><li>When possible, a preview of the attachment is displayed.</li></ul>|
    |**Enable Photo Attachments**|If checked:<ul><li>The photo icon is displayed in the inline editor, so that users can use a photo as their entry.</li><li>Existing photo entries are displayed in the list.</li><li>The photo is resized and compressed for improved performance.</li></ul>|
    |**Resize Photos**|If checked, attached photos would be resized proportionately as the page size changes.|
    |**Default Page Size**|The number of items to initially display, and the number of additional items to display when the **Get More** button is clicked/tapped.|
    |**Maximum Characters per Message**|The maximum number of single-byte characters in the text entry. The actual number of characters might be fewer with multi-byte characters.|
    |**Journal Types**|Content types that are displayed in the list of entries. Old content of a disabled type still remain in the database, and new content of a disabled type can still be created without error; however, they are not displayed in the list until the type is enabled again.|
