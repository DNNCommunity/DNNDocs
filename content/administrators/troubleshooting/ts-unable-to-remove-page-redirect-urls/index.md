---
uid: ts-unable-to-remove-page-redirect-urls
locale: en
title: "Troubleshooting: Unable to Remove Page Redirect URLs"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Unable to Remove Page Redirect URLs

## Symptom

Unable to remove page redirect URLs through the web UI.

## Possible Cause

Unknown.

## Solution

1.  Back up the site and the database.
2.  Go to Persona Bar \> Settings \> SQL Console.
3.  Find the identifier (TabID) of the problematic page.
    
    1.  Run the following SQL script:
        
        ```
        
        SELECT TabID FROM tabs
        WHERE TabName = '@NameOfPage'
                                            
        ```
        
        where @NameOfPage is the name of the page.
        
    > [!NOTE]
    > You will need the TabID returned by the query in the following steps.
    
4.  Delete all redirects.
    1.  Run the following SQL script:
        
        ```
        
        DELETE FROM taburls
        WHERE TabID = @X AND HttpStatus = 301
                                            
        ```
        
        where @X is the identifier of the page.
        
5.  Delete specific redirects.
    1.  Run the following SQL script:
        
        ```
        
        DELETE FROM taburls
        WHERE Tabid = @X AND HttpStatus = 301 AND Url = '@Y'
                                            
        ```
        
        where
        
        *   @X is the identifier of the page, and
        *   @Y is the URL to remove.
