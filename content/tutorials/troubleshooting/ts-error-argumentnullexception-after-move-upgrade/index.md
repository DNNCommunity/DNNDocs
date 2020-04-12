---
uid: ts-error-argumentnullexception-after-move-upgrade
locale: en
title: "Error: ArgumentNullException After a Move or an Upgrade"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Error: ArgumentNullException After a Move or an Upgrade

## Symptom

Error:

System.ArgumentNullException: Collection cannot be null.

## Possible Cause

The database user does not have owner rights for the database.

## Solution

1.  In the Microsoft SQL Server Management Studio, log into your database server.
2.  Go to **Security \> Logins**.
3.  Right-click the database associated with your DNN installation, and choose **Properties**.
4.  In the **User Mapping** section, set the role for the DNN database user as db_owner.

## Possible Cause

The IIS bindings do not match the correct portal alias.

## Solution

*   Correct the site alias in the IIS Manager.
    1.  Go to IIS Manager and select the site.
    2.  On the right panel, in the **Actions** section, go to **Bindings**.
    3.  Add a new binding.
    4.  Copy the correct site alias into the new binding.
*   Correct the site alias in the SQL database.
    
    1.  In the Microsoft SQL Server Management Studio, log in to your database server.
    2.  Create a new query for the DNN database.
    3.  Run the following: `SELECT * FROM PortalAlias`
    4.  If the result shows an incorrect site alias, replace it.
        
        Run the following SQL script:
        
        ```
        
        UPDATE PortalAlias
        SET HTTPAlias = 'newdomain.dnndev.me'
        WHERE HTTPAlias = 'olddomain.dnndev.me'
                                            
        ```
        
    5.  If the result does not show the site alias, insert it.
        
        Run the following SQL script:
        
        ```
        
        INSERT INTO PortalAlias (PortalID, HTTPAlias, CreatedByUserID, CreatedOnDate, LastModifiedByUserID, LastModifiedOnDate, BrowserType, IsPrimary)
        VALUES (0,'newdomain.dnndev.me',-1,GETDATE(),-1,GETDATE(),'Normal',0)
                                            
        ```
        
    > [!NOTE]
    > When using external domains, you might need to add an entry to **%SystemRoot%\\System32\\drivers\\etc\\hosts** in order to point the browser to the correct domain.
    

## Possible Cause

Incorrect `connectionString` entry in the **web.config** file.

## Solution

1.  Go to the web.config file on the root folder of the installation.
2.  Revise the entries for the connection string, specifically `Server Name`, `User`, and `Password`.

## Possible Cause

The Application Pool Identity account does not have modify rights for the DNN Installation folder.

## Solution

1.  Using Windows Explorer, go to your site folder and right-click on the DNN installation folder.
2.  Choose **Properties**, and go to the **Security** tab.
3.  Click/Tap **Edit**….
4.  Click/Tap **Add**….
5.  Select the correct location for the user.
6.  Set the object name to **IIS AppPool\\<AppPoolName>**, where **<AppPoolName>** is the Application Pool Identity account name.
7.  Click/Tap **Check Names**.
8.  Click/Tap **OK**, then **Apply**.
