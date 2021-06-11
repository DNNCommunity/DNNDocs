---
uid: setup-upgrades
locale: en
title: DNN Platform Upgrades
dnnversion: 09.04.03
---

# DNN Platform Upgrades
Following are the basic steps for upgrading **DNN Platform**.

> [!NOTE]
> Every upgrade scenario is unique in some shape, form or fashion. This document is by no means intended to address every scenario. Some upgrades can be quite complex and it is virtually impossible to cover every scenario. This document is intended to focus only on the upgrade basics.

## Step 1 - Prepare
Before starting the upgrade process, it is recommended to have a very clear understanding of all upgrade requirements and expectations. Here are some tips to help prepare.

* Know the current version of DNN Platform.

* Ensure **AutoUpgrade** setting is "False". This setting can be found within **AppSettings** section of the `web.config` file in the root. Setting this to "False" will prevent the upgrade process from being triggered by normal site visitors. 

* Know the desired version of DNN Platform and download the appropriate "Upgrade" ZIP package from [the official repository on GitHub](https://github.com/dnnsoftware/DNN.Platform/releases). The file can be found in the **Assets** section for the desired version release and will have a naming convention like **DNN_Platform_9.4.4_Upgrade.zip**.

* Know the [suggested upgrade path](xref:setup-upgrades-suggested-upgrade-path) from the current version of DNN Platform and download all appropriate "Upgrade" ZIP packages from the above referenced GitHub link.

* Know any changes to the minimum requirements for the desired version of DNN Platform and plan for implementation accordingly. 

* Know upgrade requirements (if applicable) for any installed third-party extensions and plan for implementation accordingly.

* If possible, plan to test the upgrade in a non-production environment prior to attempting in production.

## Step 2 - Take Website Offline
When ready to begin the upgrade process, take the website offline to avoid any access or changes to the site by other users. This can be done by adding an `app_offline.htm` file to the root of the site. This is an ASP.NET feature and the HTML file can contain any HTML you see fit to communicate with site visitors about the site unavailability. 

> [!NOTE]
> This also prevents access to any other site pages. Any attempts will be redirected to the base URL and will display the HTML message contained in the `app_offline.htm` file.

## Step 3 - Backup Files & Database
All files, folders and subfolders (root and below) can be manually copied to a temporary location outside of the website directory structure.

The database can be backed up using Microsoft SQL Server Management Studio (SSMS).

If this level of access to the server is not possible, there are other options depending on the hosting environment and available third-party extensions.  Following is a short list of alternate backup options.

* Secure File Transfer Protocol (SFTP) or File Transfer Protocol (FTP) in combination with remote Microsoft SQL Server Management Studio (SSMS).
* Control Panel (e.g., Plesk)
* DNN Backup (3rd-party module by Evotiva)

## Step 4 - Apply Upgrade Package
Extract the desired "Upgrade" ZIP package to the root of the website. (_If the "Upgrade" ZIP file was already extracted to a temporary location, then simply copy the extracted files to the root of the website._) If prompted, chose the option to overwrite/merge any files/folders.

> [!IMPORTANT]
> You may need to [UNBLOCK the downloaded ZIP file](https://answers.microsoft.com/en-us/windows/forum/windows_vista-files/unblocking-files-downloaded-from-the-internet/117fc963-6eed-47b8-9a58-8c13fb0ba1ab) to avoid security warnings.

## Step 5 - Bring Website Online
Rename the `app_offline.htm` file to something like `app_offline.htm.disabled`. This will automatically bring the website back online.

## Step 6 - Initiate Upgrade
Visit `http(s)://yourdomain.com/install/install.aspx?mode=upgrade` to initiate the upgrade.

## Step 7 - Check for Errors
Review upgrade results for any errors during the upgrade process. If no errors, proceed to the next step. 

If any errors are experienced, either resolve the errors (_contingent upon experience and skill level_), or restore website from the backup created in **Step 3**.

## Step 8 - Test
Visit the upgraded website to ensure everything is working as expected. 

If any issues are experienced, either resolve the issues (_contingent upon experience and skill level_), or restore website from the backup created in **Step 3**.

## Step 9 - Repeat Steps 1-8 As Necessary
If the suggested upgrade path contains multiple upgrades, repeat **Steps 1-8** as necessary to get to the desired version of DNN Platform.

## Step 10 - [Telerik Removal *](xref:setup-telerik-removal)
Learn the basic steps for removing `Telerik` from **DNN Platform**.

##### \* This is an OPTIONAL setup step for DNN Platorm, but HIGHLY RECOMMENDED. This is possible only in DNN 9.8.0 (and above for the 9.x series of releases). In DNN 10.x, Telerik removal will be forced, and no longer optional.
