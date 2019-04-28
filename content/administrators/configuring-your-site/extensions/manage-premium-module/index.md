---
uid: manage-premium-module
locale: en
title: Manage a Premium Module
dnnversion: 09.02.00
related-topics: install-extension,allow-module-use
links: ["[DNN Community blog: Installing Our Module in Another DNN Instance by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155092/installing-our-module-in-another-dnn-instance)","[DNN Store: 2sxc 8.12 — Amazing Content and Apps by 2sxc (installed as an example for screenshots)](https://store.dnnsoftware.com/home/product-details/2sxc-cms-apps-v812-free)"]
---

# Manage a Premium Module

If a module is set as Premium, its availability can be restricted at the site level and at the role level.

After installation, hosts can set the module to Premium and select which websites can access the module. If a module is designed to be premium by default, hosts only need to select the sites that can use it.

Then the administrators of each enabled site can assign Deploy Module permissions to a role, such as the Content Manager, to allow users in that role to add the module to a page.

## Prerequisites

**A host / super user account.** Hosts have full permissions to all sites in the DNN instance. A host account is required to upload modules and themes, because they might contain executable code. (An administrator account is sufficient to apply modules and themes to a website.)

## Steps

Installing a module requires host permissions.

1.  Go to **Persona Bar \> Settings \> Extensions**.

    ![Persona Bar > Settings > Extensions](/images/scr-pbar-host-Settings-E91.png)

2.  Open the module for editing.



    ![Installed Extensions tab > Showing: Modules > click/tap the pencil icon for the module to edit.](/images/scr-Extensions-Installed-edit-E90.png)



    1.  Go to the Installed Extensions tab.
    2.  In the Showing dropdown, choose Modules.
    3.  Click/Tap the pencil icon for the module you want.
3.  Go to the Extension Settings tab and scroll down to the Premium Module Assignment section.
4.  Set the module to premium, and select the sites that you allow to use the module.



    ![Check Is Premium Module? > then drag websites from Unassigned to Assigned.](/images/scr-Extensions-Edit-ExtensionSettings-PremiumModule-E90.png)



    1.  Check the Is Premium Module? box.
    2.  Drag a website to the Assigned panel or to the Unassigned panel to enable or disable the module for that website.

## What to do next

[Grant Deploy Module permissions to a role, such as the Content Manager, to allow users in that role to add the module to a page.](xref:allow-module-use)
