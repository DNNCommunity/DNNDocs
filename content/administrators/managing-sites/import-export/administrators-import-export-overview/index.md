---
uid: administrators-import-export-overview
topic: administrators-import-export-overview
locale: en
title: Import / Export
dnneditions: DNN Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-sites-overview
---

# Import / Export

Import/Export in v9.1 is designed to synchronize two sites in different installations in different servers, such as a staging installation and a production installation.

Important: Before you perform an import, back up your site and database. Imports can only be undone by restoring from a backup.

In addition to exporting and importing within the same product, you can also import packages from a more basic product.

You can export from

and import the package to

DNN Platform

*   DNN Platform
*   Evoq Basic
*   Evoq Content
*   Evoq Engage

Evoq Basic

*   Evoq Basic
*   Evoq Content
*   Evoq Engage

Evoq Content

*   Evoq Content
*   Evoq Engage

Evoq Engage

*   Evoq Engage

## Differential Export

You can export the entire site or select which components to export. You can also choose to perform a Full export or a Differential export. A differential export includes only the changes from the last export; therefore, the process is faster and the package is smaller.

Warning: Differential exports must be managed and used carefully.

*   Differential packages must be imported in the same order as they were exported, so that the changes are applied correctly.
*   Deleting a differential export package will invalidate the differential export packages that were created after it.
    
      
    
    ![Illustration of differential scenario if middle differential export is deleted.](/images/gra-import-export-example.gif)