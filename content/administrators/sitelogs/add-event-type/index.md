---
uid: add-event-type
locale: en
title: Add an Event Type to Be Logged
dnnversion: 09.02.00
related-topics: view-site-logs,view-entry-details,clear-log,delete-entries,share-entries,edit-logged-event-type,delete-logged-event-type,toggle-logging-for-event-type,configure-notices
---

# Add an Event Type to Be Logged

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Manage \> Admin Logs**.
    
    ![Persona Bar > Manage > Admin Logs](/images/scr-pbar-host-Manage-E91.png)
    
2.  Go to the **Log Settings** tab.
    
    ![Log Settings](/images/scr-pbtabs-host-Manage-AdminLogs-LogSettings-E90.png)
    
3.  Click/Tap \+ **Add Log Setting**.
    
      
    
    ![](/images/scr-AdminLogs-logsettingslist-add-log-setting-button-E90.png)
    
      
    
4.  Turn on **Logging** to start logging the event type.
    
      
    
    ![](/images/scr-AdminLogs-logsettings-addevent-enable-logging-add-E90.png)
    
      
    
5.  Choose the values for the logging settings.
    
      
    
    ![](/images/scr-AdminLogs-logsettings-addevent-configure-logging-settings-add-E90.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |**Log Type**|The type of event being logged.|
    |**Website**|The site where this event type will be logged. **All** to log this event type in all sites of the DNN installation.|
    |**Keep Most Recent**|The maximum size of the log. If an event (of the selected **Log Type**) occurs when the log is already full, the oldest entry of the same type is pushed out to make room for the new.|
    
6.  Configure the **Email Notification Settings**.
    
      
    
    ![](/images/scr-AdminLogs-logsettings-addevent-email-notification-settings-add-E90.png)
    
      
    
    1.  Turn on **Email Notification** to enable email notification.
    2.  Set up the frequency of the notices and the email address.
        
        An email is sent to the **Mail To Address** whenever the event exceeds the **Occurrence Threshold**. The timespan is reset after the email is set; e.g., if the threshold is set to **1 Occurrence** in **1 Hour,** the next hour starts when the email is sent.
        
7.  Save.

## Results

*   If the **Log Type** and **Website** combination doesn't exist, the entry is created.
*   If an existing entry has the same **Log Type** and the same **Website**, the existing entry is updated with the new settings.
*   If an existing entry has the same **Log Type** but a different **Website**, the entry is created.
