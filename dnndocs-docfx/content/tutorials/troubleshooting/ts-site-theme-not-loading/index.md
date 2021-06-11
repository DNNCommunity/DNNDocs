---
uid: ts-site-theme-not-loading
locale: en
title: "Troubleshooting: Site Theme Does Not Load"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting:  Site Theme Does Not Load As Expected

## Symptom

The site loads, but the Theme does not load correctly. Webpages are incorrectly rendered.


## Possible Cause

IIS is blocking access to Static Files (Images, Stylesheets, Javascripts etc.).
Because of insufficient permissions for Anonymous Users these files are blocked, which looks as if the Theme is not loading.


## Solution

1.  In IIS Manager, select your site and go to Authentication.
    
2.  Set Anonymous Authentication to Application pool identity.
    
3.  [Clear the DNN cache.](xref:clear-cache)
    
4.  [Restart the DNN application.](xref:restart-application)
