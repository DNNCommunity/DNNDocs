---
uid: ts-page-remains-in-draft
locale: en
title: "Troubleshooting: Page Remains in Draft Mode"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Page Remains in Draft Mode

## Symptom

While editing the page, the page remains in draft mode, due to a conflict in changes made by two users.

## Possible Cause

Another user made a change that conflicts with your changes.

## Solution

1.  Back up the site and the database.
2.  Log into the site as a host/superuser.
3.  Publish the page through SQL.
    1.  Go to Persona Bar \> Settings \> SQL Console.
    2.  Run the following SQL script:

        ```

        DECLARE @PageName VARCHAR(250);

        SET @PageName = 'Home';

        UPDATE TabVersions
        SET IsPublished = 1
        WHERE TabID = (
        		SELECT TabID
        		FROM Tabs
        		WHERE TabName LIKE @PageName
        		)
        	AND IsPublished = 0;

        ```

        where @PageName is the name of the page you are editing; e.g., 'Home'.

4.  [Clear the server cache.](xref:clear-cache)
5.  [Recycle the application pool](https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc770764(v%3dws.10)) to allow the changes to take effect.
