---
uid: expire-cached-item-in-web-server
topic: expire-cached-item-in-web-server
locale: en
title: Expire a Cached Item in a Web Server
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-servers-overview
related-topics: configure-caching,clear-cache,minify-resource-files
---

# Expire a Cached Item in a Web Server

These steps allow you delete individual items in the cache. To delete all cache items at once, use the Clear Cache button.

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Servers**.
    
    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the **Server Settings** tab, and then the **Web Servers** subtab.
    
    ![Server Settings > Web Servers](/images/scr-pbtabs-host-Settings-Servers-ServerSettings-WebServers-E90.png)
    
3.  Under **Serversv, find the server you want to edit. Click/Tap the pencil icon.
    
      
    
    ![](/images/scr-Servers-ServerSettings-WebServers-EditIcon-E90.png)
    
      
    
   > [!Tip]
   > You can filter the list to show only Enabled servers or only Disabled servers.
    
4.  Click/Tap the **Load Cache Items** link.
    
      
    
    ![](/images/scr-Servers-ServerSettings-WebServers-LoadCacheItems-link-E90.png)
    
      
    
5.  Expire individual cache items.
    
      
    
    ![](/images/scr-Servers-ServerSettings-WebServers-CacheItems.gif)
    
      
    
    1.  Select the cache item from the dropdown.
        
        Result: The cache item is displayed in the **Cache Key** field as XML.
        
    2.  Click/Tap **Expire Cache Item**.
6.  Click/Tap the X when done.
