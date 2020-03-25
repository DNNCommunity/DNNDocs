---
uid: ts-error-could-not-load-awssdk
locale: en
title: "Error: Could not load file or assembly 'AWSSDK' or one of its dependencies"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Error: Could not load file or assembly 'AWSSDK' or one of its dependencies

## Symptom

Error after upgrading a site:

Could not load file or assembly 'AWSSDK' or one of its dependencies.

## Possible Cause

A custom module uses a different version of AWSSDK.DLL.

## Solution

1.  Back up the site and the database.
2.  Open the /bin/Providers subfolder of the site folder.
3.  Right-click the AWSSDK.DLL file and select Properties.
4.  Within the pop-up dialog, switch to the Details tab and verify that the file version is 1.2.3.1.
5.  Remove other copies of AWSSK.DLL in the /bin subfolder of the site folder.
