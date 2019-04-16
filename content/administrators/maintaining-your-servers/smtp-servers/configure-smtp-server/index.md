---
uid: configure-smtp-server
topic: configure-smtp-server
locale: en
title: Configure the SMTP Server
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-servers-overview
related-topics: test-smtp-settings
---

# Configure the SMTP Server

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Servers**.
    
    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the **Server Settings** tab, and then the **SMTP Server** subtab.
    
    ![Server Settings > SMTP Server](/images/scr-pbtabs-host-Settings-Servers-ServerSettings-SMTPServer-E90.png)
    
3.  Choose the scope of the settings.
    
    *   Global. Applies the SMTP settings to all sites in the installation.
    *   The name of the current site. Applies the SMTP settings only to the current site.
    
      
    
    ![SMTP Server Mode](/images/scr-Servers-ServerSettings-SMTPServer-SMTPServerMode-E90.png)
    
      
    
4.  Configure the settings.
    
      
    
    ![SMTP Server settings](/images/scr-Servers-ServerSettings-SMTPServer-E90.png)
    
      
    |**Field**|**Description**|
    |---|---|
    |<strong>SMTP Server and Port</strong>|The SMTP server and port to use for sending emails (e.g., smtp.example.com or smtp.example.com:25).|
    |<strong>Connection Limit</strong>|The maximum number of concurrent connections with the SMTP server.|
    |<strong>Max Idle Time</strong>|The maximum number of milliseconds that a connection is allowed to be idle before the it is closed.|
    |<strong>Number of Messages Sent in Each Batch</strong>|The number of messages sent by the messaging scheduler in each batch. <div class="red-callout"><strong>Important</strong>: If your SMTP server throttles messages to regulate the flow of messages, set this number to be less than the SMTP server's maximum number of messages per batch.</div>|
    |<strong>SMTP Authentication</strong>|<ul><li><strong>Anonymous</strong>. No authentication is used.</li><li><strong>Basic</strong>. User names and passwords are sent across the network as plain text.</li><li><strong>NTLM</strong>. The NT LAN Manager is used for authentication.</li></ul>|
    |<strong>SMTP Username<br />SMTP Password</strong>|The username and password for the account used to send email messages (e.g., myusername@example.com). Only required if SMTP Authentication is set to Basic.|
    |<strong>SMTP Enable SSL</strong>|(Optional) If enabled (On), a secure connection is used when communicating with the SMTP server.|
    
5.  (Optional) Click/Tap **Test SMTP Settings** to confirm that you can connect to the SMTP server with the current settings.
6.  Save.