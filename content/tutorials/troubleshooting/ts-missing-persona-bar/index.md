---
uid: ts-missing-persona-bar
locale: en
title: "Troubleshooting: Missing Persona Bar"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization
---

# Troubleshooting: Missing Persona Bar

## Symptom

Persona Bar does not load.

## Possible Cause

The site files are located on the root drive rather than inside a folder.

## Solution

1.  Move the website contents to a folder.
    1.  Create a new folder within the drive. The directory for websites is usually in C:\\inetpub\\wwwroot\\yourwebsitefolder.
    2.  [Apply IIS permissions to this new folder for your website.](xref:set-up-dnn-folder)
    3.  Move the DNN website files to the new folder.
    4.  [In IIS Manager, change the website's physical path to point to this new folder.](xref:set-up-iis#tsk-set-up-iis__point-to-DNN-folder)
2.  In IIS Manager, restart your website.
    
    1.  Go to **Control Panel \> Administrative Tools \> Internet Information Services (IIS) Manager**.
        
    2.  In the **Actions** panel on the right, click/tap **Manage Server \> Restart**.
        
          
        
        ![IIS Manager - Restart](/images/scr-IISManager-restart.png)
        
          
        > [!TIP]
        > Remember to update your DNS with your new server’s IP address.
        

## Possible Cause

The web.config file is missing the correct assembly binding.

## Solution

1.  [Access the web.config file.](xref:access-web-config)
2.  Look for the `assemblyIdentity` node.
    
    ```
    
    assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed"
    						
    ```
    
3.  In the `assemblyIdentity` node, replace the `bindingRedirect` tag with the following:
    
    ```
    
    bindingRedirect oldVersion="0.0.0.0-32767.32767.32767.32767" newVersion="7.0.0.0"
    						
    ```
    
4.  In IIS Manager, restart your website.
    
    1.  Go to **Control Panel \> Administrative Tools \> Internet Information Services (IIS) Manager**.
        
    2.  In the **Actions** panel on the right, click/tap **Manage Server \> Restart**.
        
          
        
        ![IIS Manager - Restart](/images/scr-IISManager-restart.png)
        
          
        > [!TIP]
        > Remember to update your DNS with your new server’s IP address.
