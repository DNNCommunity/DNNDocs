---
uid: retrieve-system-info
topic: retrieve-system-info
locale: en
title: Retrieve System Information
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-servers-overview
related-topics: view-server-logs,restart-application,install-extension,about-web-servers,providers
---

# Retrieve System Information

 > [!Note]
 > In the DNN Platform, you can manage the web servers by using SQL commands (e.g., `select * from webservers`) through the **SQL Console**.</div>

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Servers**.
    
    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)
    
    
2.  In the **System Info** tab, browse the subtabs.
    *   Go to the System Info tab, and then the Application subtab.
        
        ![System Info > Application](/images/scr-pbtabs-host-Settings-Servers-SystemInfo-Application-E90.png)
        
         |**Field**|**Description**|
         |---|---|
         |<strong>Product Version </strong> | Also visible from the Persona Bar logo.|
         |<strong>Host GUID</strong>| Might be required by Support to identify your DNN installation.|
         |<strong>HTML Editor Provider</strong>|The default HTML Editor for all sites in the installation. [Each site can specify a different HTML editor.](xref:configure-html-editor)|
         |<strong>Data Provider</strong>|SQL is the default data provider for all sites in the installation. If necessary, you can replace it by installing a custom third-party provider (not supported by DNN) and updating web.config.|
         |<strong>Caching Provider</strong>|The default caching provider for all sites in the installation. [You can specify a different caching provider.](xref:configure-caching)|
         |<strong>Logging Provider</strong>|<div class="red-callout"><strong>Important:</strong> Changing these settings is strongly discouraged. If necessary, you can modify them in web.config.|
         |<strong>Friendly URL Provider<br />Friendly URL Enabled<br />Friendly URL Type</strong>|<div class="red-callout"><strong>Important:</strong> Changing these settings is strongly discouraged. If necessary, you can modify them in web.config.|
        |<strong>Scheduler Mode: </strong>|<ul><li><strong>TIMER_METHOD: </strong>A separate thread executes scheduled tasks independently.</li><li><strong>REQUEST_METHOD</strong>Tasks are executed when HTTP requests are made.</li><li><strong>DISABLED: </strong>No scheduled tasks can be executed.</li></ul>|     
        |<strong>Web Farm Enabled</strong>|Automatically updated from the web servers table. You can view the list of servers, [enable or disable servers](xref:enable-or-disable-web-server), or [delete the obsolete ones](xref:delete-web-server).|
        |<strong>CAS Permissions</strong>|<div class="red-callout"><strong>Important:</strong> Changing these settings is strongly discouraged. If necessary, you can modify them in web.config.</div>|

        
    *   Go to the **System Info** tab, and then the **Web** subtab.
        
        ![System Info > Web](/images/scr-pbtabs-host-Settings-Servers-SystemInfo-Web-E90.png)

        
        |**Field**|**Description**|
        |---|---|
        |<strong>OS Version<br />Web Server Version<br />.NET Framework Version<br /></strong>|Version numbers of systems installed and required by the DNN installation.|
        |<strong>ASP.NET Identity</strong>|The Windows user account used with the DNN installation. This account must have sufficient permissions to access and modify folders on the server.|
        |<strong>Host Name</strong>|The name of the web server used for the current host/superuser session.|
        |<strong>Physical Path</strong>|The local server path to the site's root folder.|
        |<strong>Site URL</strong>|The primary URL for the site.|
        |<strong>Relative Path</strong>|The path to the DNN installation folder, relative to the site's root folder.|
        |<strong>Server Time</strong>|The current date and time of the server.|

        
    *   Go to the **System Info** tab, and then the Database subtab.
        
        ![System Info > Database](/images/scr-pbtabs-host-Settings-Servers-SystemInfo-Database-E90.png)

        
        |**Field**|**Description**|
        |---|---|
        |<strong>Database Version<br />Service Pack<br />Product Edition<br />Software Platform</strong>|Information about the database provider. The default database provider is SQL.|
        |<strong>Database Backup History</strong>|Prior database backups. To configure database backups, use the database backup application (i.e., SQL Backup Manager).|
        |<strong>Database Files</strong>|Current files used by the database.|
