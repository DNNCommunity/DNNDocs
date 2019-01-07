---
topic: ts-site-theme-not-loading
locale: en
title: Troubleshooting: Site Theme Does Not Load
dnneditions: Platform,Evoq Content,Evoq Engage
dnnversion: 09.02.00
parent-topic: administrators-troubleshooting-overview
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Site Theme Does Not Load

## Symptom

The site loads, but the theme does not. Webpages are incorrectly rendered.

## Possible Cause

Insufficient permissions for anonymous users.

## Solution

1.  In IIS Manager, select your site and go to Authentication.
    
2.  Set Anonymous Authentication to Application pool identity.
    
3.  [Clear the DNN cache.](clear-cache)
    
4.  [Restart the DNN application.](restart-application)