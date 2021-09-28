---
uid: configure-messaging
locale: en
title: Configure Messaging for Your Site
dnnversion: 09.02.00
related-topics: update-site-info,assign-key-pages,add-metadata-to-pages,access-web-config,configure-check-for-new-version,participate-in-improvement-program,configure-html-editor,administrators-extensions-overview,administrators-connectors-overview,administrators-search-overview,administrators-vocabularies-overview
---

# Configure Messaging for Your Site

## Prerequisites

*   **An administrator account for the site.** Administrators have full permissions to the specific site.

## Steps

1.  Go to **Persona Bar \> Settings \> Site Settings**.
    
    ![Persona Bar > Settings > Site Settings](/images/scr-pbar-host-Settings-E91-platform.png)
    
2.  Go to the **Site Behavior** tab, and then the **Messaging** subtab.
    
    ![Site Behavior > Messaging](/images/scr-pbtabs-host-Settings-SiteSettings-SiteBehavior-Messaging-E90.png)
    
3.  Set the fields that affect user messaging and system messages to the user.
    
      
    
    ![Site Settings > Site Behavior > Messaging](/images/scr-SiteSettings-SiteBehavior-Messaging-E90.png)
    
      
    
    > [!Note]
    > Administrators and hosts/superusers are not restricted by these settings.
    
    <ul><li>User messaging</li></ul>

    |**Field**|**Description**|
    |---|---|
    |<strong>Disable Private Message</strong>|If enabled, users will be unable to send messages directly to other users or to groups.|
    |<strong>Throttling Interval in Minutes</strong>|The minimum number of minutes to wait before allowing the same user to send another message. If 0, users can send another message immediately after the first one.|
    |<strong>Recipient Limit</strong>|The maximum number of recipients allowed in a message. A role is considered one recipient.|       
    |<strong>Allow Attachments</strong>|If enabled, users are allowed to attach files to their messages to other users or to groups.|
    
    <ul><li>System messages</li></ul>
        
    |**Field**|**Description**|
    |---|---|
    |<strong>Send Emails</strong>|If enabled, the system sends an email to the user for each message and notification.|
    |<strong>Include Attachments</strong>|If enabled, system emails can include file attachments.|
   

	## Change the Body Content Messaging Center Emails
	
	The Template for Emails the Messaging center sends is part of the Language Pack DNN uses for Localization. 
	You can edit these as follows: 
	
	In the Persona Bar, navigate to Settings > Site Settings > Languages. 
	Click on the last Icon on the right of a Language. 
	Make sure you select "Host" to change the text for all Portals and the option with the "name of your site" for the current Portal. 
	
	> [!Note]
    > Do not select "Global" as your change would get overwritten on the next DNN upgrade.
	
	In the Resource File Dropdown, navigate to GlobalResources.resx > GlobalResources 
	Edit the value of EMAIL_MESSAGING_DISPATCH_BODY.Text to change the Template of the sent Email.
	Make sure you keep the [TOKENS] used in this Template in the new Email Template.
