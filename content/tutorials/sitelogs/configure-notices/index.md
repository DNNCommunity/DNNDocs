---
uid: configure-notices
locale: en
title: Configure Notices About a Logged Event
dnnversion: 09.02.00
related-topics: view-site-logs,view-entry-details,clear-log,delete-entries,share-entries,add-event-type,edit-logged-event-type,delete-logged-event-type,toggle-logging-for-event-type
---

# Configure Notices About a Logged Event

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Manage \> Admin Logs**.
    
    ![Persona Bar > Manage > Admin Logs](/images/scr-pbar-host-Manage-E91.png)
    
2.  Go to the **Log Settings** tab.
    
    ![Log Settings](/images/scr-pbtabs-host-Manage-AdminLogs-LogSettings-E90.png)
    
3.  Click/Tap the pencil icon for the logged event type to configure.
    
      
    
    ![](/images/scr-AdminLogs-logsettingslist-edit-icon-event-type-E90.png)
    
      
    
4.  Configure the **Email Notification Settings**.
    
      
    
    ![](/images/scr-AdminLogs-logsettings-editevent-email-notification-settings-edit-E90.png)
    
      
    
    1.  Turn on **Email Notification** to enable email notification.
    2.  Set up the frequency of the notices and the email address.
        
        An email is sent to the Mail To Address whenever the event exceeds the Occurrence Threshold. The timespan is reset after the email is set; e.g., if the threshold is set to 1 Occurrence in 1 Hour, the next hour starts when the email is sent.
        
5.  Save.
