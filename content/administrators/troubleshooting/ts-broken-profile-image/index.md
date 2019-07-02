---
uid: ts-broken-profile-image
locale: en
title: "Troubleshooting: Profile Image Not Shown"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-sql-timeout,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Troubleshooting: Profile Image Not Shown

## Symptom

The user’s profile image is not shown.

## Possible Cause

The default URL regular expression is missing.

## Solution

1.  Log into the affected site with a superuser/host account.
2.  Go to Persona Bar \> Settings \> SEO.
3.  Go to the URL Management tab, and then the Expressions subtab.
4.  In Do Not Rewrite URL Regular Expression, enter `/DesktopModules/|/Providers/|/LinkClick\.aspx|/profilepic\.ashx|/DnnImageHandler\.ashx|/__browserLink/`.
5.  [Clear the server cache.](xref:clear-cache)
