---
topic: upgrade-evoq
locale: en
title: Upgrade Evoq
dnneditions: 
dnnversion: 09.02.00
parent-topic: administrators-setup-overview
previous-topic: run-installation-wizard
---

# Upgrade Evoq

## Prerequisites

*   Your current version must be Evoq 7.0.0 or later. Otherwise, contact [Evoq Customer Support](http://www.dnnsoftware.com/services/customer-support) and provide your current version.

## Test Upgrade

Perform the upgrade on a test environment before you upgrade your live site. Your test environment must mimic the live site as closely as possible. It can be a second IIS site on the same server.

In the test environment,

*   Use the database backup of the live site as the SQL database in the test environment.
*   Set up a new application pool and identity for the test site. Confirm that the new application pool identity has access to the entire test website directory and database.
*   To keep the same portal alias as the live site, add the portal alias to the machine's hosts file. Alternatively, use localhost binding for the test site's portal alias.
*   When activating the license for the test site, set Activation Type to Development.

Even if your site is a web farm, only one server is required for the test environment. To avoid conflicts in a web farm, the upgrade is performed only with a single server enabled.

Tip: Take notes about the steps you perform and the configuration settings you use, so you can repeat them exactly when you upgrade your live site.

After you confirm that the upgraded test site works properly, create another backup of the live database and the live file system to include changes made to the live site during your test.

If you decide to simply use the upgraded test site as your new live site, you can point the live URL to the new location, or you can copy the files and the database from the test site to the live site. This is ideal if the live site was not significantly changed during the testing period; however, issues related to permissions or the environment could occur.

## Steps

1.  Back up your site.
    1.  Create a new database backup, even if you have a routine backup procedure in place. Verify that the backup was created correctly.
    2.  Compress the full website directory into a zip file. Verify that the backup was created correctly, then move it to an external location.
2.  Go to web.config and confirm that AutoUpgrade is set to false.
    
    ```
    <add key="AutoUpgrade" value="false">
    ```
    
3.  Close all other applications that might write-lock web.config for any reason.
    
    Note: The installation modifies web.config. If your web.config is substantially different from a standard web.config, you might encounter problems during the upgrade. Example, if nodes that are typically found in web.config are stored in other .config files, the application may not be able to access those nodes.
    
4.  To prevent automated tasks from executing during the upgrade, [disable the Scheduler](configure-scheduler).
5.  To prevent older installation files from executing during the upgrade, go to the root directory of the website and delete the install folder.
6.  Download and extract the latest Upgrade package.
    1.  Go to [the Downloads section of dnnsoftware.com](http://www.dnnsoftware.com/services/customer-support/success-network/software-downloads).
    2.  Click the Upgrade button for your Evoq product.
        
        Note: If Windows requires you to unblock the zip file after download, find the file in Windows Explorer, right-click and select Properties. Then click Unblock, if the option exists.
        
    3.  Extract the contents of the zip file to the root folder of the test website, while preserving the folder structure.
        
        If prompted, choose to merge all folders and overwrite all existing files.
        
7.  Go to http://localhost/install/install.aspx?mode=upgrade to start the installation.
    
    Note: If using a portal alias that was added to the machine's hosts file, use that fully-qualified domain name, instead of localhost.
    
    If you encounter ANY error:
    
    *   Note the error message, if any.
    *   Take screenshots, including the install.aspx page.
    *   Copy these files from the /portals/_default/logs folder to a safe location:
        *   InstallerLog\[currentdate\].resources
        *   \[currentdate\].log.resources
    *   Contact [Evoq Customer Support](http://www.dnnsoftware.com/services/customer-support).
    *   You might be asked to restore the site backup that you created at the start of this process and retry the upgrade. You might also have to try to upgrade to an intermediate version first before installing the latest version.
    
8.  Log in and visit all important pages to verify their functionality.
    
    If errors occur only in certain pages, check that you have installed the latest versions of the modules on those pages.