---
uid: ts-install-missing-resources
locale: en
title: "Troubleshooting: Missing Resources After An Upgrade"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Missing Resources After An Upgrade

## Symptom

After an upgrade, errors about missing DLLs or other files from core functionality.

## Possible Cause

Some resources failed to install during the upgrade.

## Solution

1.  Back up the site and the database.
2.  In a browser, go to https://<yourdomain>/install/install.aspx?mode=installresources.
3.  Wait for the resource installation process to complete.
4.  After the process completes, click the View Site button.
5.  Verify that the errors no longer appear.
