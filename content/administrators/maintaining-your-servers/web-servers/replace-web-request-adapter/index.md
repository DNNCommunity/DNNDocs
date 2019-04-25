---
uid: replace-web-request-adapter
topic: replace-web-request-adapter
locale: en
title: Replace the Web Request Adapter
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: about-web-servers
related-topics: enable-or-disable-web-server,change-url-of-web-server,assign-web-server-to-server-group,delete-web-server
---

# Replace the Web Request Adapter

If a server is added to the web farm, the Server Web Request Adapter automatically retrieves the new server's default URL and adds it to the list of servers. The adapter also checks the availability of servers in the web farm and coordinates the synchronization of cache among Enabled servers.

> [!Note]
> In the Performance Tab, the Caching Provider must be set to WebRequestCachingProvider for the Server Web Request Adapter to be used.

|**Product and Environment**|**Default Caching Provider**|**Default Server Web Request Adapter**|
|---|---|---|
|Evoq (OnDemand)|WebRequestCachingProvider|DotNetNuke.Azure.WebRequestAdapter.ServerWebRequestAdapter|
|Evoq (other)|WebRequestCachingProvider|DotNetNuke.Entities.Host.ServerWebRequestAdapter|
|DNN Platform|FileBasedCachingProvider|(No adapter. Cache is not synchronized automatically.)|

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Servers**.
    
    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)
    
2.  Go to the **Server Settings** tab, and then the **Web Servers** subtab.
    
    ![Server Settings > Web Servers](/images/scr-pbtabs-host-Settings-Servers-ServerSettings-WebServers-E90.png)
    
3.  Expand the dropdown and choose.
    
      
    
    ![](/images/scr-Servers-ServerSettings-WebServers-ServerWebRequestAdapter-E90.png)
    
      
    
4.  Save.