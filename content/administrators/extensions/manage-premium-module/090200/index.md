---
topic: manage-premium-module
locale: en
title: Manage a Premium Module
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-extensions-overview
related-topics: install-extension,allow-module-use
links: ["[DNN Community blog: Installing Our Module in Another DNN Instance by Clinton Patterson](http://www.dnnsoftware.com/community-blog/cid/155092/installing-our-module-in-another-dnn-instance)","[DNN Forge: 2sxc 8.0.11 — Amazing Content and Apps by 2sxc (installed as an example for screenshots)](http://www.dnnsoftware.com/forge/2sxc-800-amazing-content-and-apps-9733-9733-9733-9733-9733-rating)"]
---

# Manage a Premium Module

If a module is set as Premium, its availability can be restricted at the site level and at the role level.

After installation, hosts can set the module to Premium and select which websites can access the module. If a module is designed to be premium by default, hosts only need to select the sites that can use it.

Then the administrators of each enabled site can assign Deploy Module permissions to a role, such as the Content Manager, to allow users in that role to add the module to a page.

## Prerequisites

**A host / super user account.** Hosts have full permissions to all sites in the DNN instance. A host account is required to upload modules and themes, because they might contain executable code. (An administrator account is sufficient to apply modules and themes to a website.)

## Steps

Installing a module requires host permissions.

1.  Go to Persona Bar \> Settings \> Extensions.
    
    ![Persona Bar > Settings > Extensions](img/scr-pbar-host-Settings-E91.png)
    
    ➊
    
    ➋
    
2.  Open the module for editing.
    
      
    
    ![Installed Extensions tab > Showing: Modules > click/tap the pencil icon for the module to edit.](img/scr-Extensions-Installed-edit-E90.png)
    
      
    
    1.  Go to the Installed Extensions tab.
    2.  In the Showing dropdown, choose Modules.
    3.  Click/Tap the pencil icon for the module you want.
3.  Go to the Extension Settings tab and scroll down to the Premium Module Assignment section.
4.  Set the module to premium, and select the sites that you allow to use the module.
    
      
    
    ![Check Is Premium Module? > then drag websites from Unassigned to Assigned.](img/scr-Extensions-Edit-ExtensionSettings-PremiumModule-E90.png)
    
      
    
    1.  Check the Is Premium Module? box.
    2.  Drag a website to the Assigned panel or to the Unassigned panel to enable or disable the module for that website.

## What to do next

[Grant Deploy Module permissions to a role, such as the Content Manager, to allow users in that role to add the module to a page.](allow-module-use)