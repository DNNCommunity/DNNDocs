---
uid: setup-telerik-removal
locale: en
title: DNN Platform Telerik Removal
dnnversion: 09.08.00
---

# DNN Platform Telerik Removal
Following are the basic steps for removing Telerik from **DNN Platform**.

> [!IMPORTANT]
> This is an OPTIONAL setup step for DNN Platorm, but HIGHLY RECOMMENDED. This is possible only in DNN 9.8.0 (and above for the 9.x series of releases). In DNN 10.x, Telerik removal will be forced, and no longer optional.

## Instructions
The major highlight for the DNN 9.8.0 release (and above for the 9.x series of releases) is that we removed all our dependencies on the Telerik library. In order to not make this a breaking change, we do leave Telerik removal as a manual option until v10. The main components that still relied on `Telerik` were `Site Assets` and `Global Assets`, which used the `Digital Assets Manager`. We ship a new file manager with v9.8.0 (and above for the 9.x series of releases) that has no dependencies on `Telerik`, but it is not installed by default so that it will not break existing sites upon upgrading. Please note it will be automatically replaced in v10, so please test and plan accordingly.

To identify any third-party extension(s) that depend on Telerik, our very own [Mitchel Sellers](https://github.com/mitchelsellers) has published the [DNN Telerik Identifier module](https://github.com/IowaComputerGurus/DnnTelerikIdentifier) which you can download and install to find assemblies that reference `Telerik`.  Carefully review the results from this module to determine if your website is ready for full removal of `Telerik`.  For any third-party modules that depend on `Telerik`, you should contact the module vendor/developer before following the steps below.

If you would like to remove Telerik in DNN 9.8.0 (and above for the 9.x series of releases), following are the steps to do so.  Again, proceed with caution based on your findings using the `DNN Telerik Identifier` module above, as performing these steps may also break third-party extensions that depend on `Telerik`.  We recommend you contact the developer/vendor in these cases for further guidance.

### Step 1
Create a full backup of the site and database.

### Step 2
Install the new `Resource Manager` module via `Extensions > Available Extensions (Modules)`.

### Step 3
Navigate to `Manage > Site Assets` via the `Persona Bar` and remove the `Digital Assets Management` module from the page.

### Step 4
Add an instance of the `Resource Manager` module to the `Site Assets` page.

### Step 5
Navigate to `Manage > Global Assets` via the `Persona Bar` and repeat `Steps 3 & 4` for that page.

### Step 6
Navigate to `Settings > SQL Console` via the `Persona Bar` and run the following script:

```
UPDATE {databaseOwner}{objectQualifier}Packages
SET IsSystemPackage = 0
WHERE Name IN ('DigitalAssetsManagement', 'DotNetNuke.Telerik.Web', 'DotNetNuke.Web.Deprecated', 'DotNetNuke.Website.Deprecated')
GO

DELETE FROM {databaseOwner}{objectQualifier}PackageDependencies
WHERE (PackageName = 'DotNetNuke.Web.Deprecated')
GO

UPDATE {databaseOwner}[{objectQualifier}Lists] SET Text = 'DotNetNuke.Web.UI.WebControls.Internal.PropertyEditorControls.DateEditControl, DotNetNuke.Web'
WHERE ListName = 'DataType' AND Value = 'Date'
GO

UPDATE {databaseOwner}[{objectQualifier}Lists] SET Text = 'DotNetNuke.Web.UI.WebControls.Internal.PropertyEditorControls.DateTimeEditControl, DotNetNuke.Web'
WHERE ListName = 'DataType' AND Value = 'DateTime'
GO
```

### Step 7
Navigate to `Settings > Servers` in the `Persona Bar` and click the `Clear Cache` button in the top-right corner.

### Step 8
Navigate to `Settings > Extensions (Modules)` in the `Persona Bar` and uninstall the `Digital Assets Management` extension.  Be sure to check the `Delete Files` checkbox.

### Step 9
Navigate to `Settings > Extensions (Libraries)` in the `Persona Bar` and uninstall the `DotNetNuke Telerik Web Components` extension.  Be sure to check the `Delete Files` checkbox.

### Step 10
Navigate to `Settings > Extensions (Libraries)` in the `Persona Bar` and uninstall the `DNN Deprecated Web Controls Library` extension.  Be sure to check the `Delete Files` checkbox.

### Step 11
Navigate to `Settings > Extensions (Libraries)` in the `Persona Bar` and uninstall the `DotNetNuke Deprecated Website Codebehind files` extension.  Be sure to check the `Delete Files` checkbox.

### Step 12
Open the `web.config` file within the site root and search for "Telerik".  Delete any lines that reference it.

### Step 13
Test all third-party modules to make sure they still work without Telerik.  If any do not work properly, please contact the developer/vendor for further guidance.