---
uid: export-site
locale: en
title: Export a Site
dnnversion: 09.02.00
related-topics: transfer-an-export-package,import-site
---

# Export a Site

> [!Note]
> An export can take time depending on the selected components and the size of the site.

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  Go to **Persona Bar \> Settings \> Import-Export**.
    
    ![Persona Bar > Settings > Import-Export](/images/scr-pbar-host-Settings-E91.png)
    
2.  Choose a site to export from.
    
      
    
    ![Site dropdown](/images/scr-Settings-ImportExport-ChooseSite-E91.png)
    
      
    
3.  Click/Tap the **Export Data** button.
    
      
    
    ![Export Data button](/images/scr-Settings-ImportExport-ExportData-button-E91.png)
    
      
    
4.  Configure the export settings.
    
      
    
    ![Export settings](/images/scr-Settings-ImportExport-ExportData-E91.png)
    
      
    
    |**Field**|**Description**|
    |---|---|
    |**Name**|A user-friendly name to refer to the export.|
    |**Include in Export**|The components to export.|
    |**Pages in Export**|The pages to export.|
    |**Include Deletions**|If enabled (**On**), **Recycle Bin** items are exported.
    |**Run Now**|If enabled (**On**), the process starts immediately.|
    |**Export Mode**|<ul><li>**Differential**. Exports only the differences between the last export and the current state.</li><li>**Full**. Exports the selected components and pages fully.|
        
    > [!Note]
    > Recycle bin items are not imported into a Production installation.

    > [!Note]
    > The first export is always a full export.

5.  Click/Tap **Begin Export**.

## What to do next

Check the **Import / Export Log** for the status of the export.
