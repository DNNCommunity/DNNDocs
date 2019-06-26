---
uid: transfer-an-export-package
locale: en
title: Transfer an Export Package
dnnversion: 09.02.00
related-topics: export-site,import-site
---

# Transfer an Export Package

An export creates a set of folders in the local server. To make the export package available for import in another server, you must copy the exported folders to the target server.

## Prerequisites

*   **A host / super user account.** Hosts have full permissions to all sites in the DNN instance.

## Steps

1.  In the source server (where the export was done), find the export package(s).
    1.  Go to **Persona Bar \> Settings \> Import-Export**.
        
        ![Persona Bar > Settings > Import-Export](/images/scr-pbar-host-Settings-E91.png)
        
    2.  Under **Import / Export Log**, search for the export package(s) you want.
        
        > [!Tip]
        > Set Filter to All Exports.
        
    3.  Note the **Folder Name** and the **Export Mode**.
        
        > [!Warning]
        > If the **Export Mode** is **Differential**, you must copy all export packages since your last import.
        
    4.  In **Windows Explorer**, go to the **App_Data/ExportImport** folder.
        
        Each subfolder is an export package.
        
2.  In the target server (where the import will be done), go to the **App_Data/ExportImport** folder.
3.  Copy the export package subfolder from the source server to the target server.
    
    > [!Important]
    > The path in the target server must be the same as the path in the source server.
    
4.  View the **Import / Export Log** of the DNN installation in the target server.
    
      
    
    ![Import / Export Log](/images/scr-Settings-ImportExport-Log-E91.png)
    
      
    

## Results

The export package appears in the **Import / Export Log** in the target server.
