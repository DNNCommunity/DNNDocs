---
uid: configure-caching
topic: configure-caching
locale: en
title: Configure Caching
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-servers-overview
related-topics: clear-cache,expire-cached-item-in-web-server,minify-resource-files
links: ["[Caching Providers](http://www.dnnsoftware.com/wiki/caching-providers)"]
---

# Configure Caching

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to Persona Bar \> Settings \> Servers.
    
    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Go to the Server Settings tab, and then the Performance subtab.
    
    ![Server Settings > Performance](/images/scr-pbtabs-host-Settings-Servers-ServerSettings-Performance-E90.png)
    
3.  Choose how the page's state is persisted (Page State Persistence).
    
    *   Page. Information about the page's state is stored in a hidden field in the page. Recommended.
    *   Memory. Information about the page's state is cached in memory.
    
      
    
    ![Page State Persistence](/images/scr-Servers-ServerSettings-Performance-PageStatePersistence-E90.png)
    
      
    
4.  Choose the caching providers.
    
      
    
    ![Caching Providers](/images/scr-Servers-ServerSettings-Performance-CachingProviders-E90.png)
    
      
    
    Field
    
    Description
    
    Caching Provider
    
    The default caching provider for the site.
    
    *   WebRequestCachingProvider. Default for Evoq products. Uses a server web request adapter to automatically synchronize the caches of enabled web servers.
    *   FileBasedCachingProvider. Default for the DNN Platform. Cache synchronization is not automated.
    
    Module Cache Provider
    
    The default caching provider for modules. Each module can override this setting.
    
    *   File. The cache is stored in a file. Choose this if your server tends to run out of memory. Default.
    *   Memory. The cache is stored in memory. Fastest performance.
    *   Database. The cache is stored in a database. To be deprecated.
    
    Page Output Cache Provider
    
    The default caching provider for pages. Caching is enabled for a page, only if the cache timeout is set for that page.
    
    *   File. The cache is stored in a file. Choose this if your server tends to run out of memory.
    *   Memory. The cache is stored in memory. Fastest performance.
    *   Database. The cache is stored in a database. Default.
    
5.  Configure the caching behavior.
    
      
    
    ![Cachin behavior settings](/images/scr-Servers-ServerSettings-Performance-CachingBehavior-E90.png)
    
      
    
    Field
    
    Description
    
    Cache Setting
    
    The relative length of time that items remain in cache.
    
    *   NoCaching. No caching. Worst performance.
    *   LightCaching. Items are held in cache for the shortest time.
    *   ModerateCaching. Items are held in cache for a moderate length of time.
    *   HeavyCaching. Items are held in cache for the longest time. Best performance. Default.
    
    Authenticated Cacheability  
    Unauthenticated Cacheability
    
    The value of the Cache-Control field in the HTTP general header. The Cache-Control field indicates how caching is done. Authenticated Cacheability specifies the caching behavior for authenticated users; Unauthenticated Cacheability for anonymous users.
    
    *   NoCache
    *   Private
    *   Public
    *   Server
    *   ServerAndNoCache. Default.
    *   ServerAndPrivate
    
    These values are defined in [HttpCacheability Enumeration](https://msdn.microsoft.com/en-us/system.web.httpcacheability.aspx).
    
    SSL for Cache Synchronization
    
    (Optional) If enabled (On), a secure connection is used when synchronizing the caches of enabled web servers.
    
6.  Save.