---
uid: setup-upgrades-post-10.2.0
locale: en
title: DNN Platform Upgrades (Post 10.2.0)
dnnversion: 10.2.0
---

# DNN Platform Upgrades (Post 10.2.0)
Following are the basic steps for upgrading **DNN Platform** versions from 10.2.0 and above.

> [!NOTE]
> Every upgrade scenario is unique in some shape, form or fashion. This document is by no means intended to address every scenario. Some upgrades can be quite complex and it is virtually impossible to cover every scenario. This document is intended to focus only on the upgrade basics.

## Step 1 - Prepare
Before starting the upgrade process, it is recommended to have a very clear understanding of all upgrade requirements and expectations. Here are some tips to help prepare.

* Know the current version of DNN Platform.

* Know the desired version of DNN Platform and download the appropriate "Upgrade" ZIP package from [the official repository on GitHub](https://github.com/dnnsoftware/DNN.Platform/releases). The file can be found in the **Assets** section for the desired version release and will have a naming convention like **DNN_Platform_10.2.1_Upgrade.zip**.

* Know the [suggested upgrade path](xref:setup-upgrades-suggested-upgrade-path) from the current version of DNN Platform and download all appropriate "Upgrade" ZIP packages from the above referenced GitHub link.

* Know any changes to the minimum requirements for the desired version of DNN Platform and plan for implementation accordingly. 

* Know upgrade requirements (if applicable) for any installed third-party extensions and plan for implementation accordingly.

* If possible, plan to test the upgrade in a non-production environment prior to attempting in production.

## Step 2 - Backup Files & Database
All files, folders and subfolders (root and below) can be manually copied to a temporary location outside of the website directory structure.

The database can be backed up using Microsoft SQL Server Management Studio (SSMS).

If this level of access to the server is not possible, there are other options depending on the hosting environment and available third-party extensions.  Following is a short list of alternate backup options.

* Secure File Transfer Protocol (SFTP) or File Transfer Protocol (FTP) in combination with remote Microsoft SQL Server Management Studio (SSMS).
* Control Panel (e.g., Plesk)
* DNN Backup (3rd-party module by Evotiva)

## Step 3 - Upload Upgrade Package
Login has a SuperUser (Host) and navigate to: Servers => System Info => Upgrades.
Click on "Upload Package" and upload the previously downloaded upgrade zip file.
The system will validate the upgrade package and warn about potential issues if detected.

## Step 4 - Initiate Upgrade
If the uploaded file is valid, it will be listed and have a "steps" button. Clicking that button will perform any special upgrade steps that DNN may require and then show the upgrade page where you can again login as a SuperUser to start the auto-upgrade process.

## Step 5 - Check for Errors
Review upgrade results for any errors during the upgrade process. If no errors, proceed to the next step. 

If any errors are experienced, either resolve the errors (_contingent upon experience and skill level_), or restore website from the backup created in **Step 2**.

> [!NOTE]
> If you need to restore a website, it is important to first remove all files.  Then, replace it with the backup copy. It is not adequate to simply apply the backup over the top of the failed upgrade site.  Failure to follow this guidance can result in a non-functional, restored site.

## Step 6 - Test
Visit the upgraded website to ensure everything is working as expected. 

If any issues are experienced, either resolve the issues (_contingent upon experience and skill level_), or restore website from the backup created in **Step 3**.

## Step 9 - Repeat Steps 1-6 As Necessary
If the suggested upgrade path contains multiple upgrades, repeat **Steps 1-6** as necessary to get to the desired version of DNN Platform.
