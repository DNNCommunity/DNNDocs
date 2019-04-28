---
uid: ts-error-unknown-server-tag-DNNComboBox
locale: en
title: "Error: Unknown Server Tag - DNNComboBox"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Error: Unknown Server Tag - DNNComboBox

## Symptom

Error:

DotNetNuke.Framework.PageBase - An error has occurred while loading page.System.Web.HttpParseException (0x80004005): Unknown server tag 'dnn:DnnComboBox'.

## Possible Cause

An older version of the DNN Events module is installed.

## Solution

1.  Download [the latest version of the DNN Events module](https://github.com/DNNCommunity/DNN.Events/releases).
2.  Go to your site.
3.  Log into the site as a superuser/host.
4.  [Install the downloaded version of the DNN Events module.](xref:install-extension)
