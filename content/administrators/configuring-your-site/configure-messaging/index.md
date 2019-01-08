---
uid: configure-messaging
topic: configure-messaging
locale: en
title: Configure Messaging for Your Site
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-configuring-your-site-overview
related-topics: update-site-info,assign-key-pages,add-metadata-to-pages,access-web-config,configure-check-for-new-version,participate-in-improvement-program,configure-html-editor,page-file-versioning,administrators-extensions-overview,administrators-connectors-overview,administrators-workflows-overview,administrators-search-overview,administrators-vocabularies-overview
---

# Configure Messaging for Your Site

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to Persona Bar \> Settings \> Site Settings.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Go to the Site Behavior tab, and then the Messaging subtab.
    
    ![Site Behavior > Messaging](/images/scr-pbtabs-host-Settings-SiteSettings-SiteBehavior-Messaging-E90.png)
    
3.  Set the fields that affect user messaging and system messages to the user.
    
      
    
    ![Site Settings > Site Behavior > Messaging](/images/scr-SiteSettings-SiteBehavior-Messaging-E90.png)
    
      
    
    Note: Administrators and hosts/superusers are not restricted by these settings.
    
    *   User messaging
        
        Field
        
        Description
        
        Disable Private Message
        
        If enabled, users will be unable to send messages directly to other users or to groups.
        
        Throttling Interval in Minutes
        
        The minimum number of minutes to wait before allowing the same user to send another message. If 0, users can send another message immediately after the first one.
        
        Recipient Limit
        
        The maximum number of recipients allowed in a message. A role is considered one recipient.
        
        Allow Attachments
        
        If enabled, users are allowed to attach files to their messages to other users or to groups.
        
    *   System messages
        
        Field
        
        Description
        
        Send Emails
        
        If enabled, the system sends an email to the user for each message and notification.
        
        Include Attachments
        
        If enabled, system emails can include file attachments.