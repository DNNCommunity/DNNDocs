---
topic: ts-incomplete-content-localization
locale: en
title: Troubleshooting: Incomplete Content Localization
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-troubleshooting-overview
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-missing-persona-bar
---

# Troubleshooting: Incomplete Content Localization

## Symptom

After enabling localization, only some content is localized.

## Possible Cause

The localization process timed out during the conversion.

## Solution

1.  Back up the site and the database.
2.  Go to Persona Bar \> Settings \> SQL Console.
3.  Delete the culture code of the aborted localization process.
    
    Run the following SQL script:
    
    ```
    
    DELETE
    FROM Tabs
    WHERE CultureCode = 'xx-XX';
                                
    ```
    
    where xx-XX is the culture code of the added language.
    
4.  Disable content localization for the site.
    
    Run the following SQL script:
    
    ```
    
    UPDATE Tabs
    SET CultureCode = NULL;
    
    UPDATE PortalSettings
    SET SettingValue = 'False'
    WHERE SettingName = 'ContentLocalizationEnabled'
    	AND PortalID = xx;
                                
    ```
    
    where xx is the ID of the site for which localization was enabled.
    
5.  [Recycle the application pool](https://technet.microsoft.com/en-us/library/cc770764(v=ws.10).aspx) to allow the changes to take effect.
    
6.  Rerun the localization process.