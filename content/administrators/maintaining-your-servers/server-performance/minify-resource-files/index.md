---
uid: minify-resource-files
locale: en
title: Minify Resource Files
dnneditions: Evoq Content,Evoq Engage
dnnversion: 09.02.00
related-topics: configure-caching,clear-cache,expire-cached-item-in-web-server
links: ["[Caching Providers](https://www.dnnsoftware.com/wiki/caching-providers)"]
---

# Minify Resource Files

You can speed up page downloads in two steps:

*   Minify the resources (CSS and JavaScript files) to reduce their sizes.
*   Combine the resources into composite files to reduce the number of file requests that the browser makes.

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Servers**.

    ![Persona Bar > Settings > Servers](/images/scr-pbar-host-Settings-E91.png)

2.  Go to the **Server Settings** tab, and then the **Performance** subtab.

    ![Server Settings > Performance](/images/scr-pbtabs-host-Settings-Servers-ServerSettings-Performance-E90.png)




![](/images/scr-Servers-ServerSettings-Performance-ClientResourceMgmt-E90.png)



3.  Choose the scope of the settings.
    *   Global. Applies the Client Resource Management settings to all sites in the installation.
    *   The name of the current site. Applies the Client Resource Management settings only to the current site.
4.  Set Enable Composite Files to On.
5.  Set Minify CSS and Minify JS to On.
6.  Save.

   > [!Note]
   > You must save the settings to force the creation of a new composite file before incrementing the version number.

7.  Click/Tap **Increment Version**.
8.  Confirm.
