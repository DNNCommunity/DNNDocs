---
uid: access-web-config
locale: en
title: Access web.config and other .config files
dnnversion: 09.02.00
related-topics: update-site-info,assign-key-pages,add-metadata-to-pages,configure-messaging,configure-check-for-new-version,participate-in-improvement-program,configure-html-editor,administrators-extensions-overview,administrators-connectors-overview,administrators-search-overview,administrators-vocabularies-overview
---

# Access web.config and other .config files

## Steps

1.  Go to **Persona Bar \> Settings \> Config Manager**.
    
    ![Persona Bar > Settings > Config Manager](/images/scr-pbar-host-Settings-E91-platform.png)
    
2.  Go to the **Config Files** tab.
    
    ![Config Files](/images/scr-pbtabs-host-Settings-ConfigManager-ConfigFiles-E90.png)
    
3.  Choose the configuration file from the dropdown list.
    
    ![Config Files dropdown > web.config](/images/scr-ConfigMgr-ConfigFiles-webconfig-E91.png)
    
> [!IMPORTANT]
> When you edit the web.config, specifically, you should know that doing so could have a negative impact on the performance of your website.  The saved file will trigger the website to restart, which will clear all cache. This could result in the website appearing to load slowly and even throw errors temporarily in some instance.  It's suggested to only update the web.config file during non-peak hours on mission-critical websites.
